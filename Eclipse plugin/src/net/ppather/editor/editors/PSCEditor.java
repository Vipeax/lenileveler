package net.ppather.editor.editors;

import java.util.ResourceBundle;

import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IProject;
import org.eclipse.jface.action.IAction;
import org.eclipse.jface.text.source.SourceViewer;
import org.eclipse.swt.SWT;
import org.eclipse.ui.IEditorInput;
import org.eclipse.ui.IFileEditorInput;
import org.eclipse.ui.editors.text.TextEditor;
import org.eclipse.ui.texteditor.TextOperationAction;
import org.eclipse.ui.views.contentoutline.IContentOutlinePage;

import net.ppather.editor.Plugin;
import net.ppather.editor.editors.psc.Configuration;
import net.ppather.editor.editors.psc.OutlineView;
import net.ppather.editor.editors.utils.ColorHandler;

public class PSCEditor extends TextEditor  {
	private ColorHandler colorManager;

	private OutlineView outline;
	 
	public PSCEditor() {
		colorManager = new ColorHandler();
		setSourceViewerConfiguration(new Configuration(colorManager));
	}

	@Override
	public void dispose() {
		colorManager.dispose();
		super.dispose();
	}

	private static final String CONTENTASSIST_PROPOSAL_ID = "net.ppather.editor.editors.PSCEditor.ContentAssistProposal"; 

	@Override
	protected void createActions() {
		super.createActions();

		// This action will fire a CONTENTASSIST_PROPOSALS operation when executed
		ResourceBundle bundle = Plugin.getDefault().getResourceBundle();
		IAction action= new TextOperationAction(bundle, "ContentAssistProposal", this, SourceViewer.CONTENTASSIST_PROPOSALS);
		action.setActionDefinitionId(CONTENTASSIST_PROPOSAL_ID);
		setAction(CONTENTASSIST_PROPOSAL_ID, action);
		setActionActivationCode(CONTENTASSIST_PROPOSAL_ID,' ', -1, SWT.CTRL);
	}


	
	public IFile getFile(){
		IEditorInput input =  this.getEditorInput();
		IFile file = null;
		if(input instanceof IFileEditorInput){
			file = ((IFileEditorInput)input).getFile();
		}
		return file;		
	}
	
	@SuppressWarnings("unchecked")
	@Override
	public Object getAdapter(Class required){
		if(IContentOutlinePage.class.equals(required)){
			if(outline==null){
				outline = new OutlineView(getDocumentProvider(),this);
				if(getEditorInput()!=null){
					outline.setInput(getEditorInput());
				}
			}
			return outline;
		}
	
		return super.getAdapter(required);
	}
	

	public IProject getProject(){
		IEditorInput input = getEditorInput();
		IFile file = null;
		if(input instanceof IFileEditorInput){
			file = ((IFileEditorInput)input).getFile();
		}
		if(file==null)
			return null;
		
		IProject project = file.getProject();
		
		return project;	
	}
	
	
	@Override
	public void editorSaved() {
		super.editorSaved();
		if (outline != null)
			outline.update();
	}
}
