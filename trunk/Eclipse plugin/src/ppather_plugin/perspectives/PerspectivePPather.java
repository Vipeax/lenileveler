package ppather_plugin.perspectives;

import org.eclipse.ui.IPageLayout;
import org.eclipse.ui.IPerspectiveFactory;

public class PerspectivePPather implements IPerspectiveFactory {

	
	@Override
	public void createInitialLayout(IPageLayout layout) {
		layout.addView(IPageLayout.ID_OUTLINE,IPageLayout.LEFT,0.30f, layout.getEditorArea());
	}

}
