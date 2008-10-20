/*
 * Created on 15 janv. 2005
 *
 * TODO To change the template for this generated file go to
 * Window - Preferences - Java - Code Style - Code Templates
 */
package ppather_plugin.wizards;

import org.eclipse.core.runtime.IPath;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.ui.dialogs.WizardNewProjectCreationPage;

/**
 * @author Propriétaire
 *
 * TODO To change the template for this generated type comment go to
 * Window - Preferences - Java - Code Style - Code Templates
 */
public class PSCNewProjectPage extends WizardNewProjectCreationPage
{
	private String nomProjet;
	private IPath nomRep;
	private ISelection selection;
	
	public PSCNewProjectPage(ISelection sel)
	{
		super("WizardNewProjectCreationPage");
		setTitle("Editeur PSC");
		setDescription("Ce wizard crée un nouveau projet PPather.");
		selection = sel;
	}
	
	private void dialogChanged()
	{
		nomProjet = getProjectName();
		nomRep = getLocationPath();


		if (nomProjet.length() == 0) {
			updateStatus("Le nom du projet doit être spécifié.");
			return;
		}

		updateStatus(null);
	}

	private void updateStatus(String message) {
		setErrorMessage(message);
		setPageComplete(message == null);
	}


}
