package ppather_plugin.editors.utils;

import org.eclipse.jface.text.BadLocationException;
import org.eclipse.jface.text.IDocument;

public class EditorUtils {

	public static int findEndOfWhiteSpace(IDocument document, int offset, int end) throws BadLocationException {
		while (offset < end) {
				char c= document.getChar(offset);
				if (c != ' ' & c != '\t') {
					return offset;
				}
				offset++;
		}
		return end;
	}
	
	public static String getIndentOfLine(IDocument document, int offset) {
		try{
			int line = document.getLineOfOffset(offset);
			if (line > -1){
				int start = document.getLineOffset(line);
				int end = start + document.getLineLength(line) - 1;
				int whiteend = EditorUtils.findEndOfWhiteSpace(document, start, end);
				return document.get(start, whiteend - start);
			}else{
				return "";
			}
		}catch(BadLocationException ex){
			return "";
		}
	}
}
