/*
 * Created on 15 janv. 2005
 *
 * TODO To change the template for this generated file go to
 * Window - Preferences - Java - Code Style - Code Templates
 */
package net.ppather.editor.wizards;

import org.eclipse.core.runtime.IPath;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.ui.dialogs.WizardNewProjectCreationPage;

public class PSCProjectWizardPage extends WizardNewProjectCreationPage
{
	private String nomProjet;
	private IPath nomRep;
	private ISelection selection;
	
	public PSCProjectWizardPage(ISelection sel)
	{
		super("WizardNewProjectCreationPage");
		setTitle("Editeur PSC");
		setDescription("Ce wizard crée un nouveau projet PPather.");
		setSelection(sel);
	}
	
	@SuppressWarnings("unused")
	private void dialogChanged()
	{
		setNomProjet(getProjectName());
		setNomRep(getLocationPath());


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

	public void setSelection(ISelection selection) {
		this.selection = selection;
	}

	public ISelection getSelection() {
		return selection;
	}

	public void setNomRep(IPath nomRep) {
		this.nomRep = nomRep;
	}

	public IPath getNomRep() {
		return nomRep;
	}

	public void setNomProjet(String nomProjet) {
		this.nomProjet = nomProjet;
	}

	public String getNomProjet() {
		return nomProjet;
	}


}
