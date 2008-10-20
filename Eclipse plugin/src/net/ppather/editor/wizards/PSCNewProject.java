/*
 * Created on 15 janv. 2005
 *
 * TODO To change the template for this generated file go to
 * Window - Preferences - Java - Code Style - Code Templates
 */
package net.ppather.editor.wizards;

import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.InvocationTargetException;

import org.eclipse.core.resources.IContainer;
import org.eclipse.core.resources.IFile;
import org.eclipse.core.resources.IFolder;
import org.eclipse.core.resources.IProject;
import org.eclipse.core.resources.IProjectDescription;
import org.eclipse.core.resources.IWorkspace;
import org.eclipse.core.resources.IWorkspaceRoot;
import org.eclipse.core.resources.ResourcesPlugin;
import org.eclipse.core.runtime.CoreException;
import org.eclipse.core.runtime.IPath;
import org.eclipse.core.runtime.IProgressMonitor;
import org.eclipse.core.runtime.OperationCanceledException;
import org.eclipse.core.runtime.Path;
import org.eclipse.core.runtime.Platform;
import org.eclipse.core.runtime.SubProgressMonitor;
import org.eclipse.jface.dialogs.MessageDialog;
import org.eclipse.jface.operation.IRunnableWithProgress;
import org.eclipse.jface.viewers.ISelection;
import org.eclipse.jface.viewers.IStructuredSelection;
import org.eclipse.jface.wizard.Wizard;
import org.eclipse.ui.INewWizard;
import org.eclipse.ui.IWorkbench;
import org.eclipse.ui.actions.WorkspaceModifyOperation;


public class PSCNewProject extends Wizard implements INewWizard
{
	private PSCNewProjectPage page;
	private ISelection selection;
	private IProjectDescription description;
	private String contenuFicProject;

	public PSCNewProject()
	{
		super();
		setNeedsProgressMonitor(true);
	}
	
	@Override
	public void addPages()
	{
		page = new PSCNewProjectPage(selection);
		addPage(page);
	}
	
	@Override
	public boolean performFinish()
	{
		final String nomProjet;
		final IPath nomRep;
		IRunnableWithProgress op = null;
		try {
			nomProjet = page.getProjectName();
			nomRep = page.getLocationPath() ;
			op = new IRunnableWithProgress() {
				public void run(IProgressMonitor monitor) throws InvocationTargetException {
					try {
						
						doFinish(nomProjet, nomRep, monitor);
					} catch (CoreException e) {
						throw new InvocationTargetException(e);
					} finally {
						monitor.done();
					}
				}
			};
		} catch (NullPointerException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		
		try {
			getContainer().run(true, false, op);
		} catch (InterruptedException e) {
			return false;
		} catch (InvocationTargetException e) {
			Throwable realException = e.getTargetException();
			MessageDialog.openError(getShell(), "Error !", realException.getMessage());
			return false;
		}
		return true;
	}
	
	private void doFinish(String nomProjet,IPath nomRep,IProgressMonitor monitor)
	throws CoreException
	{
		IWorkspaceRoot root = ResourcesPlugin.getWorkspace().getRoot();
		
		String nomProjet2 = nomProjet;
		nomProjet = nomRep.toOSString()+"\\"+nomProjet;
		
		IPath monIPath = new Path(nomProjet);
		File monDir = monIPath.toFile();
		monDir.mkdir();
		
		File monFicProject = new File(nomProjet.toString()+"\\.project");
		try {
            monFicProject.createNewFile();
        } catch (IOException e2) {
            e2.printStackTrace();
        }

        IProject monIProject = root.getProject(nomProjet2);

        	
		try
		{
		    InputStream stream = openContentStream(nomProjet2);
		    
		    this.remplirFicProject(monFicProject);
		    
		    // L'ERREUR SE SITUE ICI, LORS DE LA CREATION DE LIEN
		    final IFile ficProjet = monIProject.getFile(monFicProject.toString());
		    ficProjet.createLink(monIPath,IFile.ALLOW_MISSING_LOCAL,monitor);
		    
/*			if (ficProjet.exists())
			{ 
			    System.out.println("setContents.");
			    ficProjet.setContents(stream, true, true, monitor);
			}
			else
			{
			    System.out.println("creation fichier.");
			    ficProjet.create(stream, true, monitor);
			    System.out.println("creation lien.");
			    ficProjet.createLink(monIPath,IFile.ALLOW_MISSING_LOCAL,monitor);
			}*/
			stream.close();
		}
		catch (IOException e) {System.out.println("Erreur de remplissage du fichier");}
		

		
		System.out.println("mon Path OS : "+nomRep.toOSString());
		System.out.println("mon Path : "+nomRep.toString());
		
		IContainer container = root.getContainerForLocation(monIPath);
		if(root == null) System.out.println("root nul");
		if(monIPath == null) System.out.println("monIPath nul");		
		if(container == null) System.out.println("container nul");

		IPath cheminRep = (IPath) nomRep;
		final IFolder folderProjet;
		try
		{
			if(container != null) 
			{
				folderProjet = container.getFolder(cheminRep);
			}
			else folderProjet = null;
			folderProjet.createLink(cheminRep,IFolder.ALLOW_MISSING_LOCAL,monitor);
		}
		catch (RuntimeException e1) { 
		}

		monitor.worked(1);
		monitor.setTaskName("Ouverture du projet ...");
		monitor.worked(1);		
	}
		
	
	private InputStream openContentStream(String nomProjet)
	{
	    System.out.println("je suis dans openContentStream(String nomProjet).");
	    String contents = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
	    contents += "<projectDescription>\n";
	    contents +=	"\t<name>"+nomProjet+"</name>\n";
	    contents += "\t<comment></comment>\n";
	    contents +=	"\t<projects>\n";
	    contents += "\t</projects>\n";
	    contents +=	"\t<buildSpec>\n";
	    contents +=	"\t</buildSpec>\n";
	    contents +=	"\t<natures>\n";
	    contents +=	"\t</natures>\n";
	    contents +=	"</projectDescription>\n";
	    
	    contenuFicProject = contents;
		return new ByteArrayInputStream(contents.getBytes());
	}
	
	public void remplirFicProject(File nom) throws IOException
	{
		FileOutputStream flotS = new FileOutputStream(nom);
		flotS.write(contenuFicProject.getBytes());
		flotS.close();
	}


	IProject createExistingProject(String projectName, IPath locationPath)
	{
	    
		final IWorkspace workspace = ResourcesPlugin.getWorkspace();
		final IProject project = workspace.getRoot().getProject(projectName);
		if(description == null){
			description =	workspace.newProjectDescription(projectName);
			if (isPrefixOfRoot(locationPath))
				description.setLocation(null);
			else
				description.setLocation(locationPath);
		}
		else
			description.setName(projectName);

		WorkspaceModifyOperation op = new WorkspaceModifyOperation() {
			@Override
			protected void execute(IProgressMonitor monitor) throws CoreException {
				monitor.beginTask("", 2000); //$NON-NLS-1$
				project.create(description, new SubProgressMonitor(monitor, 1000));
				if (monitor.isCanceled())
					throw new OperationCanceledException();
				project.open(new SubProgressMonitor(monitor, 1000));

			}
		};

		try {
			getContainer().run(true, true, op);
		} catch (InterruptedException e) {
			return null;
		} catch (InvocationTargetException e) {
			return null;
		}

		return project;
	}
	
	private boolean isPrefixOfRoot(IPath locationPath) {
		return Platform.getLocation().isPrefixOf(locationPath);
	}
	
	public void init(IWorkbench workbench, IStructuredSelection selection)
	{
		this.selection = selection;
	}

}
