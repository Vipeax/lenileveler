/*******************************************************************************
 * Copyright (c) 2000, 2004 IBM Corporation and others.
 * All rights reserved. This program and the accompanying materials 
 * are made available under the terms of the Common Public License v1.0
 * which accompanies this distribution, and is available at
 * http://www.eclipse.org/legal/cpl-v10.html
 * 
 * Contributors:
 *     IBM Corporation - initial API and implementation
 *******************************************************************************/
package net.ppather.editor.views.actions;


import net.ppather.editor.PPatherPlugin;

import org.eclipse.core.resources.ResourcesPlugin;
import org.eclipse.core.runtime.IAdaptable;
import org.eclipse.jface.action.Action;
import org.eclipse.ui.IWorkbench;
import org.eclipse.ui.IWorkbenchPage;
import org.eclipse.ui.IWorkbenchWindow;
import org.eclipse.ui.WorkbenchException;

public class OpenPPatherPerspectiveAction extends Action {

	public OpenPPatherPerspectiveAction() {
		// WorkbenchHelp.setHelp(this,
		// IJavaHelpContextIds.OPEN_JAVA_PERSPECTIVE_ACTION);
	}

	@Override
	public void run() {
		IWorkbench workbench = PPatherPlugin.getDefault().getWorkbench();
		IWorkbenchWindow window = workbench.getActiveWorkbenchWindow();
		IWorkbenchPage page = window.getActivePage();
		IAdaptable input;
		if (page != null)
			input = page.getInput();
		else
			input = ResourcesPlugin.getWorkspace().getRoot();
		try {
			workbench.showPerspective(PPatherPlugin.PERSPECTIVE_ID, window,
					input);
		} catch (WorkbenchException e) {
		}
	}
}
