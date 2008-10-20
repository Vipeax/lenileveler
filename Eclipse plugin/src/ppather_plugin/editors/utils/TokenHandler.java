package ppather_plugin.editors.utils;

import java.util.HashMap;
import java.util.Map;
import org.eclipse.jface.text.TextAttribute;
import org.eclipse.jface.text.rules.Token;
import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.RGB;


public class TokenHandler {

	private ColorHandler colorManager;
	protected Map<String,Token> fColorTable = new HashMap<String,Token>(10);
	
	public TokenHandler(ColorHandler colorManager) {
		this.colorManager = colorManager;
		fColorTable.put("COMMENT", new Token(new TextAttribute(colorManager.getColor(ColorHandler.COMMENT), null, SWT.ITALIC)));
		fColorTable.put("STRING", new Token(new TextAttribute(colorManager.getColor(ColorHandler.STRING), null, SWT.ITALIC)));
		fColorTable.put("VARIABLE", new Token(new TextAttribute(colorManager.getColor(ColorHandler.VARIABLE))));
		fColorTable.put("FUNCTION", new Token(new TextAttribute(colorManager.getColor(ColorHandler.FUNCTION), null, SWT.BOLD)));
		fColorTable.put("PARENT", new Token(new TextAttribute(colorManager.getColor(ColorHandler.PARENT), null, SWT.BOLD)));
		fColorTable.put("CONDITIONAL", new Token(new TextAttribute(colorManager.getColor(ColorHandler.CONDITIONAL), null, SWT.BOLD)));
		fColorTable.put("BASIC", new Token(new TextAttribute(colorManager.getColor(ColorHandler.BASIC), null, SWT.BOLD)));
		fColorTable.put("ADVENCED", new Token(new TextAttribute(colorManager.getColor(ColorHandler.ADVENCED), null, SWT.BOLD)));
		fColorTable.put("BETA", new Token(new TextAttribute(colorManager.getColor(ColorHandler.BETA), null, SWT.BOLD)));
		fColorTable.put("OTHER", new Token(new TextAttribute(colorManager.getColor(ColorHandler.OTHER))));
	}
	

	public Token getToken(String name) {
		Token token = (Token) fColorTable.get(name);
		if (token == null) {
			token = new Token(colorManager.getColor(new RGB(0,0,0)));
			fColorTable.put(name, token);
		}
		return token;
	}
}
