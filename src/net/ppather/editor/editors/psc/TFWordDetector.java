package net.ppather.editor.editors.psc;

import org.eclipse.jface.text.rules.IWordDetector;

public class TFWordDetector implements IWordDetector {

	@Override
	public boolean isWordPart(char c) {
		return Character.isJavaIdentifierPart(c);
	}

	@Override
	public boolean isWordStart(char c) {
		return Character.isJavaIdentifierStart(c) && c != '$';
	}

}
