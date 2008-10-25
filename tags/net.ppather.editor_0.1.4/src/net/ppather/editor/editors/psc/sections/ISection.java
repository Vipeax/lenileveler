/*
 * Created on 22-Sep-2003
 *
 * To change the template for this generated file go to
 * Window - Preferences - Java - Code Generation - Code and Comments
 */
package net.ppather.editor.editors.psc.sections;

import org.eclipse.jface.text.Position;

public interface ISection {
	public String getTitle();
	public ISection[] getChildern();
	public Object getParent();
	public void addChild(ISection child);
	public void setParent(Object parent);
	public Position getPosition();
	public void setPosition(Position p);
	public String getFile();
}
