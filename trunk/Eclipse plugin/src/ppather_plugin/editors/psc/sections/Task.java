package ppather_plugin.editors.psc.sections;

import java.util.ArrayList;

import org.eclipse.jface.text.Position;

public class Task implements ISection {

	private String title;
	private Position position;
	private Object parent;
	private ArrayList<ISection> children;
	
	public Task(String title, Position position, Object parent){
		this.children = new ArrayList<ISection>();
		this.title = title;
		this.position = position;
		setParent(parent);
	}
	
	@Override
	public void addChild(ISection child) {
		this.children.add(child);
	}

	@Override
	public ISection[] getChildern() {
		ISection[] sections = new ISection[children.size()];
		children.toArray(sections);
		return sections;
	}

	@Override
	public String getFile() {
		return null;
	}

	@Override
	public Object getParent() {
		return parent;
	}

	@Override
	public Position getPosition() {
		return position;
	}

	@Override
	public String getTitle() {
		return title;
	}

	@Override
	public void setParent(Object parent) {
		if (parent instanceof ISection) {
			((ISection) parent).addChild(this);
		}
		this.parent = parent;
	}

	@Override
	public void setPosition(Position position) {
		this.position = position;
	}

}
