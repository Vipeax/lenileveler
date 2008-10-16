package ppather_plugin.editors;

import org.eclipse.jface.text.*;
import org.eclipse.jface.text.rules.*;

public class PSCTagScanner extends RuleBasedScanner {

	public PSCTagScanner(ColorManager manager) {
		IToken string =
			new Token(
				new TextAttribute(manager.getColor(IPSCColorConstants.STRING)));

		IRule[] rules = new IRule[3];

		// Add rule for double quotes
		rules[0] = new SingleLineRule("\"", "\"", string, '\\');
		// Add a rule for single quotes
		rules[1] = new SingleLineRule("'", "'", string, '\\');
		// Add generic whitespace rule.
		rules[2] = new WhitespaceRule(new PSCWhitespaceDetector());

		setRules(rules);
	}
}
