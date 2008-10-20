/*
 * Created on 05-May-2004
 *
 * TODO To change the template for this generated file go to
 * Window - Preferences - Java - Code Generation - Code and Comments
 */
package ppather_plugin.editors.psc;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;


import org.eclipse.core.runtime.FileLocator;
import org.eclipse.core.runtime.Path;
import org.eclipse.jface.text.BadLocationException;
import org.eclipse.jface.text.BadPositionCategoryException;
import org.eclipse.jface.text.DefaultPositionUpdater;
import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.IPositionUpdater;
import org.eclipse.jface.text.Position;
import org.eclipse.jface.text.rules.IWordDetector;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.jface.viewers.ITreeContentProvider;
import org.eclipse.jface.viewers.LabelProvider;
import org.eclipse.jface.viewers.SelectionChangedEvent;
import org.eclipse.jface.viewers.TreeViewer;
import org.eclipse.jface.viewers.Viewer;
import org.eclipse.swt.graphics.Image;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Display;
import org.eclipse.ui.texteditor.IDocumentProvider;
import org.eclipse.ui.texteditor.ITextEditor;
import org.eclipse.ui.views.contentoutline.ContentOutlinePage;
import org.osgi.framework.Bundle;

import ppather_plugin.PPatherPlugin;
import ppather_plugin.editors.psc.sections.ISection;
import ppather_plugin.editors.psc.sections.Task;
import ppather_plugin.editors.psc.sections.Variable;
import ppather_plugin.editors.utils.LanguageHandler;


public class OutlineView extends ContentOutlinePage {

	public class OutlineLabelProvider extends LabelProvider {

		Image taskImage;
		Image defaultVariableImage;
		Image customVariableImage;

		public OutlineLabelProvider() {
			super(); 
			try {
				Bundle bundle = PPatherPlugin.getDefault().getBundle();
				this.taskImage =
					new Image(
						Display.getCurrent(),
						FileLocator.openStream(bundle, new Path("icons/task.gif"), false));
				this.defaultVariableImage =
					new Image(
						Display.getCurrent(),
						FileLocator.openStream(bundle, new Path("icons/default_variable.gif"), false));
				this.customVariableImage =
					new Image(
						Display.getCurrent(),
						FileLocator.openStream(bundle, new Path("icons/custom_variable.gif"), false));
			} catch (IOException ex) {
				System.out.println(ex.toString());
			}
		}

		public Image getImage(Object obj) {
			if (obj instanceof Task && taskImage != null) {
				return taskImage;
			}
			if (obj instanceof Variable && defaultVariableImage != null) {
				switch(((Variable)obj).getType()){
					case LanguageHandler.CUSTOM_VARIABLE:
						return customVariableImage;
					case LanguageHandler.DEFAULT_VARIABLE:
						return defaultVariableImage;
				}
			}
			return super.getImage(obj);
		}
		
		public String getText(Object obj){
			if (obj instanceof Task) {
				return ((Task)obj).getTitle();
			}
			if (obj instanceof Variable) {
				return ((Variable)obj).getTitle();
			}
			return super.getText(obj);
		}
		
	}

	protected class TexContentProvider implements ITreeContentProvider {

		private final static String SEGMENTS = "__psc_segments";
		private IPositionUpdater positionUpdater = new DefaultPositionUpdater(SEGMENTS);
		private List<Object> content = new ArrayList<Object>();

		public Object[] getChildren(Object o) {
			if (o instanceof ISection) {
				return ((ISection) o).getChildern();
			}
			return null;
		}

		public Object getParent(Object o) {
			if (o instanceof ISection) {
				return ((ISection) o).getParent();
			}
			return null;
		}

		public boolean hasChildren(Object o) {
			if (o instanceof ISection) {
				ISection e = (ISection) o;
				if (e.getChildern().length != 0)
					return true;
				else
					return false;
			}
			if (o == input)
				return true;
			else
				return false;
		}


		public Object[] getElements(Object arg0) {
			return content.toArray();
		}


		public void dispose() {
			if (content != null) {
				content.clear();
				content = null;
			}

		}


		public void inputChanged(
			Viewer viewer,
			Object oldInput,
			Object newInput) {
			if (oldInput != null) {
				IDocument document = provider.getDocument(oldInput);
				if (document != null) {
					try {
						document.removePositionCategory(SEGMENTS);
					} catch (BadPositionCategoryException x) {
					}
					document.removePositionUpdater(positionUpdater);
				}
			}

			content.clear();

			if (newInput != null) {
				IDocument document = provider.getDocument(newInput);
				if (document != null) {
					document.addPositionCategory(SEGMENTS);
					document.addPositionUpdater(positionUpdater);
					parse(document);
				}
			}

		}

		public void parse(IDocument document) {
			IWordDetector wDetector = new IWordDetector(){
				@Override
				public boolean isWordPart(char c) {
					return Character.isJavaIdentifierPart(c);
				}

				@Override
				public boolean isWordStart(char c) {
					return Character.isJavaIdentifierStart(c) || c == '$';
				}
			};
			parseRoot(document, null, 0, wDetector);
		}
		
		public int getWordType(String word){
			for(String match: LanguageHandler.TASKTAGS_MATCH){
				if(match.equals(word)){
					return LanguageHandler.TASK;
				}
			}
			for(String match: LanguageHandler.VARIABLETAGS_MATCH){
				if(match.equals(word)){
					return LanguageHandler.DEFAULT_VARIABLE;
				}
			}
			if(word.startsWith("$")){
				return LanguageHandler.CUSTOM_VARIABLE;
			}
			return LanguageHandler.OTHER;
		}
		
		public boolean checkVariableAffectaction(IDocument document, int offset) throws BadLocationException{
			String rest = document.get(offset, document.getLength()-offset);
			int affOffset = rest.indexOf('=');
			if(affOffset >= 0){
				rest = rest.substring(0, affOffset).trim();
				return rest.length() == 0;
			}else{
				return false;
			}
			
		}
		
		public int parseRoot(IDocument document, ISection parent, int offset, IWordDetector wDetector) {
			char currentChar;
			String currentWord = "";
			Position p;
			ISection currentTask = null;
			ISection currentVariable = null;
			int wordType = -1;
			
			try {
				int length = document.getLength();
				for (int i = offset; i < length; i++) {
						currentChar = document.getChar(i);
						if (currentWord.length() > 0) {
							if (wDetector.isWordPart(currentChar)) {
								currentWord += currentChar;
//							}else if (wDetector.isWordStart(currentChar)){
//								switch(getWordType(currentWord)){
//									case LanguageHandler.TASK:
//										p = new Position(i - currentWord.length());
//										document.addPosition(SEGMENTS, p);
//										currentTask = new Task(currentWord, p, parent);
//										if(parent == null){
//											content.add(currentTask);
//										}
//										break;
//									default:
//										currentTask = null;
//										break;
//								}
//								currentWord = "" + currentChar;
							}else{
								wordType = getWordType(currentWord);
								switch(wordType){
									case LanguageHandler.TASK:
										p = new Position(i - currentWord.length());
										document.addPosition(SEGMENTS, p);
										currentTask = new Task(currentWord, p, parent);
										if(parent == null){
											content.add(currentTask);
										}
										break;
									case LanguageHandler.CUSTOM_VARIABLE:
									case LanguageHandler.DEFAULT_VARIABLE:
										if(checkVariableAffectaction(document, i+1)){
											p = new Position(i - currentWord.length());
											document.addPosition(SEGMENTS, p);
											currentVariable = new Variable(currentWord, p, parent, wordType);
											
											if(parent == null){
												content.add(currentVariable);
											}
										}
										currentTask = null;
										break;
									default:
										currentTask = null;
										break;
								}
								if(currentTask != null && currentChar == '{'){
									i = parseRoot(document, currentTask, i+1, wDetector);
								}else if(currentChar == '}'){
									return i+1;
								}
								currentWord = "";
							}
						} else {
							if (wDetector.isWordStart(currentChar)) {
								currentWord = "" + currentChar;
							}else if(currentTask != null && currentChar == '{'){
								i = parseRoot(document, currentTask, i+1, wDetector);
							}else if(currentChar == '}'){
								return i+1;
							}
						}
				}
				if(currentWord.length() > 0){
					wordType = getWordType(currentWord);
					switch(wordType){
						case LanguageHandler.TASK:
							p = new Position(document.getLength() - currentWord.length());
							document.addPosition(SEGMENTS, p);
							content.add(new Task(currentWord, p, parent));
							break;
//						case LanguageHandler.VARIABLE:
//							p = new Position(document.getLength() - currentWord.length());
//							document.addPosition(SEGMENTS, p);
//							content.add(new Variable(currentWord, p, parent));
//							break;
					}
				}
			} catch (BadLocationException blex) {
				blex.printStackTrace();
			} catch (BadPositionCategoryException bpcex) {
				bpcex.printStackTrace();
			}
			return 0;
		}
	}

	private String[] bibtexfiles = new String[0];

	protected Object input;
	protected IDocumentProvider provider;
	protected ITextEditor editor;

	public OutlineView(IDocumentProvider provider, ITextEditor editor) {
		super();
		this.provider = provider;
		this.editor = editor;
	}

	public String[] getBibtexFilenames() {
		return bibtexfiles;
	}
	public void createControl(Composite parent) {

		super.createControl(parent);

		TreeViewer viewer = getTreeViewer();
		viewer.setContentProvider(new TexContentProvider());
		viewer.setLabelProvider(new OutlineLabelProvider());
		viewer.addSelectionChangedListener(this);

		if (input != null)
			viewer.setInput(input);
	}

	public void setInput(Object input) {
		this.input = input;
		update();
	}

	public void update() {
		TreeViewer viewer = getTreeViewer();

		if (viewer != null) {
			Control control = viewer.getControl();
			if (control != null && !control.isDisposed()) {
				control.setRedraw(false);
				viewer.setInput(input);
				viewer.expandAll();
				control.setRedraw(true);
			}
		}
	}

	public void selectionChanged(SelectionChangedEvent event) {

		super.selectionChanged(event);

		ISelection selection = event.getSelection();
		if (selection.isEmpty())
			editor.resetHighlightRange();
		else {
			Object SelectionElement =
				((IStructuredSelection) selection).getFirstElement();
			if (SelectionElement instanceof ISection) {

				ISection section = (ISection) SelectionElement;
				if (section.getPosition() != null) {
					int start = section.getPosition().getOffset();
					try {
						editor.setHighlightRange(start, 0, true);
					} catch (IllegalArgumentException x) {
						editor.resetHighlightRange();
					}
				}
			}
		}
	}

}
