package ppather_plugin.editors.utils;


import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;

import org.eclipse.swt.graphics.Color;
import org.eclipse.swt.graphics.RGB;
import org.eclipse.swt.widgets.Display;

public class ColorHandler {
	public static RGB COMMENT = new RGB(0, 128, 0);
	public static RGB STRING = new RGB(32, 32, 196);
	public static RGB VARIABLE = new RGB(196, 128, 0);
	public static RGB FUNCTION = new RGB(0, 196, 196);
	public static RGB PARENT = new RGB(0, 0, 64);
	public static RGB CONDITIONAL = new RGB(0, 64, 128);
	public static RGB BASIC = new RGB(0, 0, 128);
	public static RGB ADVENCED = new RGB(0, 0, 128);
	public static RGB BETA = new RGB(196, 0, 0);
	public static RGB OTHER = new RGB(32, 32, 32);

	protected Map<RGB, Color> fColorTable = new HashMap<RGB, Color>(10);

	public void dispose() {
		Iterator<Color> e = fColorTable.values().iterator();
		while (e.hasNext())
			 ((Color) e.next()).dispose();
	}
	public Color getColor(RGB rgb) {
		Color color = (Color) fColorTable.get(rgb);
		if (color == null) {
			color = new Color(Display.getCurrent(), rgb);
			fColorTable.put(rgb, color);
		}
		return color;
	}
}
