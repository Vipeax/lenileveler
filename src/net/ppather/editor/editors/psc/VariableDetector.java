package net.ppather.editor.editors.psc;

import org.eclipse.jface.text.rules.IWordDetector;

public class VariableDetector implements IWordDetector {

	@Override
	public boolean isWordPart(char c) {
		return Character.isLetter(c) || Character.isDigit(c) || c == '_';
	}

	@Override
	public boolean isWordStart(char c) {
		return (Character.isLetter(c) || c == '$');
	}

}
