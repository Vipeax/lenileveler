package ppather_plugin.editors.psc;

import org.eclipse.jface.text.rules.IRule;
import org.eclipse.jface.text.rules.RuleBasedScanner;
import org.eclipse.jface.text.rules.SingleLineRule;
import org.eclipse.jface.text.rules.WordRule;

import ppather_plugin.editors.utils.ColorHandler;
import ppather_plugin.editors.utils.LanguageHandler;
import ppather_plugin.editors.utils.TokenHandler;



public class Scanner extends RuleBasedScanner {

	private ColorHandler colorManager;
	private TokenHandler tokenManater;

	/**
	 * Initialize scanner.
	 */
	public Scanner(ColorHandler cManager) {
		colorManager = cManager;
		tokenManater = new TokenHandler(colorManager);
		
		WordRule keywordsRule = new WordRule(new TFWordDetector(), tokenManater.getToken("OTHER"));
		
		for (String k : LanguageHandler.PARENT_TOKENTYPE) {							// Keyword parent
			keywordsRule.addWord(k, tokenManater.getToken("PARENT"));
		}
		for (String k : LanguageHandler.CONDITIONAL_TOKENTYPE) {						// Keyword conditional
			keywordsRule.addWord(k, tokenManater.getToken("CONDITIONAL"));
		}
		for (String k : LanguageHandler.BASIC_TOKENTYPE) {							// Keyword basic
			keywordsRule.addWord(k, tokenManater.getToken("BASIC"));
		}
		for (String k : LanguageHandler.ADVENCED_TOKENTYPE) {							// Keyword advenced
			keywordsRule.addWord(k, tokenManater.getToken("ADVENCED"));
		}
		for (String k : LanguageHandler.BETA_TOKENTYPE) {								// Keyword beta
			keywordsRule.addWord(k, tokenManater.getToken("BETA"));
		}
		for (String k : LanguageHandler.FUNCTION_TOKENTYPE) {								// Keyword beta
			keywordsRule.addWord(k, tokenManater.getToken("FUNCTION"));
		}
		

		WordRule varibalesRule = new WordRule(new VariableWordDetector(), tokenManater.getToken("VARIABLE"));

		varibalesRule.addWord("$MinLevel", tokenManater.getToken("BETA"));
		
		setRules(new IRule[] {
					keywordsRule,
					varibalesRule,
					new SingleLineRule("//", null, tokenManater.getToken("COMMENT"), (char) 0, true),
					new SingleLineRule("\"", "\"", tokenManater.getToken("STRING"), '\\', true),
		});		
	}

	
	
}
