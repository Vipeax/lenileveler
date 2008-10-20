package net.ppather.editor.editors.psc.sections;


import org.eclipse.jface.text.Position;

public class Variable implements ISection {


	private String title;
	private Position position;
	private Object parent;
	private int type;
	

	public Variable(String title, Position position, Object parent, int type){
		this.title = title;
		this.position = position;
		setParent(parent);
		this.type = type;
	}
	
	@Override
	public void addChild(ISection child) {
	}

	@Override
	public ISection[] getChildern() {
		return new ISection[]{};
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

	public int getType() {
		return type;
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
