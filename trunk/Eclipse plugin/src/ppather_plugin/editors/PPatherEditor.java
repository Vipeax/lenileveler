package ppather_plugin.editors;

import org.eclipse.ui.editors.text.TextEditor;

public class PPatherEditor extends TextEditor {

	private ColorManager colorManager;

	public PPatherEditor() {
		super();
		colorManager = new ColorManager();
		setSourceViewerConfiguration(new PSCConfiguration(colorManager));
		setDocumentProvider(new PSCDocumentProvider());
	}
	public void dispose() {
		colorManager.dispose();
		super.dispose();
	}

}
