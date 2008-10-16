package ppather_plugin.perspectives;

import org.eclipse.ui.IPageLayout;
import org.eclipse.ui.IPerspectiveFactory;
import org.eclipse.ui.IFolderLayout;

public class PerspectivePPather implements IPerspectiveFactory {

	private static final String EXPLORER_VIEW_ID = "ppather_plugin.views.ExplorerView";
	private static final String BOTTOM = "bottom";

	
	@Override
	public void createInitialLayout(IPageLayout layout) {
		layout.addView(IPageLayout.ID_OUTLINE,IPageLayout.LEFT,0.30f, layout.getEditorArea());


		IFolderLayout bot = layout.createFolder(BOTTOM,IPageLayout.BOTTOM,0.76f,layout.getEditorArea());
		
		bot.addView(EXPLORER_VIEW_ID);

	}

}
