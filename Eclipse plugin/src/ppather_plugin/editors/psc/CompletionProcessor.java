package ppather_plugin.editors.psc;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import org.eclipse.jface.text.BadLocationException;
import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.ITextViewer;
import org.eclipse.jface.text.contentassist.ICompletionProposal;
import org.eclipse.jface.text.contentassist.IContentAssistProcessor;
import org.eclipse.jface.text.contentassist.IContextInformation;
import org.eclipse.jface.text.contentassist.IContextInformationValidator;

import ppather_plugin.editors.utils.EditorUtils;
import ppather_plugin.editors.utils.LanguageHandler;

public class CompletionProcessor implements IContentAssistProcessor {
	// Proposal part before cursor

	
	
	
	private final char[] PROPOSAL_ACTIVATION_CHARS = new char[] { 'P' };

	
	@Override
	public ICompletionProposal[] computeCompletionProposals(ITextViewer viewer, int offset) {
		// Retrieve current document
		IDocument doc = viewer.getDocument();
		
		// Construct structures
		String indent = EditorUtils.getIndentOfLine(doc, offset);

		List<CompletionProposal> propList = new ArrayList<CompletionProposal>();
		
		// Retrieve qualifier
		String qualifier = getQualifier(doc, offset);
		int qlen = qualifier.length();
		if(qlen == 0){
			for (int i = 0; i < LanguageHandler.VARIABLETAGS_VIEW.length; i++) {
				propList.add(getVariableCompletionProposal(i, offset, qlen));
			}
			for (int i = 0; i < LanguageHandler.TASKTAGS_MATCH.length; i++) {
				propList.add(getTaskCompletionProposal(i, offset, qlen, indent));
			}
			for (int i = 0; i < LanguageHandler.FUNCTIONTAGS_MATCH.length; i++) {
				propList.add(getFunctionCompletionProposal(i, offset, qlen));
			}
		}else{
			if(qualifier.startsWith("$")){
				for (int i = 0; i < LanguageHandler.VARIABLETAGS_VIEW.length; i++) {
					if (LanguageHandler.VARIABLETAGS_VIEW[i].startsWith(qualifier)) {
						propList.add(getVariableCompletionProposal(i, offset, qlen));
					}
				}
			}else{
				for (int i = 0; i < LanguageHandler.TASKTAGS_MATCH.length; i++) {
					if (LanguageHandler.TASKTAGS_MATCH[i].startsWith(qualifier)) {
						propList.add(getTaskCompletionProposal(i, offset, qlen, indent));
					}
				}
				for (int i = 0; i < LanguageHandler.FUNCTIONTAGS_MATCH.length; i++) {
					if (LanguageHandler.FUNCTIONTAGS_MATCH[i].startsWith(qualifier)) {
						propList.add(getFunctionCompletionProposal(i, offset, qlen));
					}
				}
			}
		}
		
		// Create completion proposal array
		ICompletionProposal[] proposals = new ICompletionProposal[propList.size()];

		Collections.sort(propList, Collections.reverseOrder());
		
		// and fill with list elements
		propList.toArray(proposals);
		
		
		// Return the proposals
		return proposals;

	}

	private CompletionProposal getTaskCompletionProposal(int index, int offset, int negOffset, String indent) {
		String text = LanguageHandler.TASKTAGS_REPLACEMENT[index];
		text = text.replaceAll("\\{\\}", " {\r\n\t__INDENT____CURSOR__\r\n__INDENT__}").replaceAll("__INDENT__", indent);
		int cursor = text.indexOf("__CURSOR__");
		if(cursor < 0){
			cursor = text.length();
		}
		text = text.replaceAll("__CURSOR__", "");
		String help = LanguageHandler.TASKTAGS_HELP[index] + "\r\n\r\nCode:\r\n" + text + "\r\n\r\nWiki:\r\n" + LanguageHandler.TASKTAGS_WIKI[index]; 
		return new CompletionProposal(text, offset - negOffset, negOffset, cursor, null, LanguageHandler.TASKTAGS_VIEW[index], null, help);
	}

	private CompletionProposal getVariableCompletionProposal(int index, int offset, int negOffset) {
		String text = LanguageHandler.VARIABLETAGS_REPLACEMENT[index];
		int cursor = text.indexOf("__CURSOR__");
		if(cursor < 0){
			cursor = text.length();
		}
		text = text.replaceAll("__CURSOR__", "");
		String help = LanguageHandler.VARIABLETAGS_HELP[index] + "\r\n\r\nWiki:\r\n" + LanguageHandler.VARIABLETAGS_WIKI[index];
		return new CompletionProposal(text, offset - negOffset, negOffset, cursor, null, LanguageHandler.VARIABLETAGS_VIEW[index], null, help);
	}

	private CompletionProposal getFunctionCompletionProposal(int index, int offset, int negOffset) {
		String text = LanguageHandler.FUNCTIONTAGS_REPLACEMENT[index];
		int cursor = text.indexOf("__CURSOR__");
		if(cursor < 0){
			cursor = text.length();
		}
		text = text.replaceAll("__CURSOR__", "");
		String help = LanguageHandler.FUNCTIONTAGS_HELP[index] + "\r\n\r\nWiki:\r\n" + LanguageHandler.FUNCTIONTAGS_WIKI[index];
		return new CompletionProposal(text, offset - negOffset, negOffset, cursor, null, LanguageHandler.FUNCTIONTAGS_VIEW[index], null, help);
	}
	
	private String getQualifier(IDocument doc, int offset) {

		// Use string buffer to collect characters
		StringBuffer buf = new StringBuffer();
		while (true) {
			try {
				// Read character backwards
				char c = doc.getChar(--offset);

				// This was not the start of a tag
				if (Character.isWhitespace(c)){
					return buf.reverse().toString();
				}
				// Collect character
				buf.append(c);

			} catch (BadLocationException e) {
				// Document start reached, no tag found
				return buf.reverse().toString();
			}
		}
	}

	@Override
	public IContextInformation[] computeContextInformation(ITextViewer viewer,
			int offset) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public char[] getCompletionProposalAutoActivationCharacters() {
		// TODO Auto-generated method stub
		return PROPOSAL_ACTIVATION_CHARS;
	}

	@Override
	public char[] getContextInformationAutoActivationCharacters() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public IContextInformationValidator getContextInformationValidator() {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public String getErrorMessage() {
		// TODO Auto-generated method stub
		return null;
	}

}
