package ppather_plugin.editors.psc;

import org.eclipse.jface.text.rules.IWordDetector;

public class VariableWordDetector implements IWordDetector {

	@Override
	public boolean isWordPart(char c) {
		return  Character.isLetter(c) || Character.isDigit(c) || c == '_';
	}

	@Override
	public boolean isWordStart(char c) {
		return (Character.isLetter(c) || c == '$');
	}

}
