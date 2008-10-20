package ppather_plugin.editors.psc;

import org.eclipse.jface.text.rules.EndOfLineRule;
import org.eclipse.jface.text.rules.IPredicateRule;
import org.eclipse.jface.text.rules.IToken;
import org.eclipse.jface.text.rules.RuleBasedPartitionScanner;
import org.eclipse.jface.text.rules.SingleLineRule;
import org.eclipse.jface.text.rules.Token;

public class PartitionScanner extends RuleBasedPartitionScanner {
	public final static String STRING = "_psc_string";
	public final static String COMMENT = "_psc_comment";
	public final static String[] PARTITION_TYPES = new String[]{STRING, COMMENT};

	public PartitionScanner() {
		super();
		
		IToken stringToken = new Token(STRING);
		IToken commentToken = new Token(COMMENT);
		
		IPredicateRule[] result= new IPredicateRule[]{
				new SingleLineRule("\"", "\"", stringToken, '\\'),
				new EndOfLineRule("//", commentToken),
		};
		setPredicateRules(result);
	}

}
