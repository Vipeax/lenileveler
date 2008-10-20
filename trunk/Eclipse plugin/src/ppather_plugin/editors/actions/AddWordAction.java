/*
 * Created on 16-Mar-2004
 *
 * To change the template for this generated file go to
 * Window - Preferences - Java - Code Generation - Code and Comments
 */
package ppather_plugin.editors.actions;


import org.eclipse.jface.action.Action;
import org.eclipse.ui.texteditor.ITextEditor;


/**
 * @author ish
 *
 * To change the template for this generated type comment go to
 * Window - Preferences - Java - Code Generation - Code and Comments
 */
public class AddWordAction extends Action {
	private ITextEditor textEditor;

	public AddWordAction(ITextEditor editor) {
		this.textEditor = editor;
	}

	public void run() {
		textEditor.getDocumentProvider().getDocument(textEditor.getEditorInput());
	}

}