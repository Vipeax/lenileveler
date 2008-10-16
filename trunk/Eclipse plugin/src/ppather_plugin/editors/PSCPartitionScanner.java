package ppather_plugin.editors;

import org.eclipse.jface.text.rules.*;

public class PSCPartitionScanner extends RuleBasedPartitionScanner {
	public final static String PSC_COMMENT = "__PSC_comment";
	public final static String PSC_TAG = "__PSC_tag";

	public PSCPartitionScanner() {

		IToken PSCComment = new Token(PSC_COMMENT);
		IToken tag = new Token(PSC_TAG);

		IPredicateRule[] rules = new IPredicateRule[2];

		rules[0] = new MultiLineRule("<!--", "-->", PSCComment);
		rules[1] = new TagRule(tag);

		setPredicateRules(rules);
	}
}
