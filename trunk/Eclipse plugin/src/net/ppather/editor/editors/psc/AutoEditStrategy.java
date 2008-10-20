package net.ppather.editor.editors.psc;


import org.eclipse.jface.text.DocumentCommand;
import org.eclipse.jface.text.IAutoEditStrategy;
import org.eclipse.jface.text.IDocument;

import net.ppather.editor.editors.utils.EditorUtils;

public class AutoEditStrategy implements IAutoEditStrategy {

	private static AutoEditStrategyItem[] SimpleItems = new AutoEditStrategyItem[]{
		new AutoEditStrategyItem("\"", "\"\""),
		new AutoEditStrategyItem("'", "''"),
		new AutoEditStrategyItem("(", "()"),
		new AutoEditStrategyItem("[", "[]"),
	};

	@Override
	public void customizeDocumentCommand(IDocument document, DocumentCommand command) {
		for(AutoEditStrategyItem item : SimpleItems){
			if(command.text.equals(item.source)){
				command.text = item.replacement;
				command.caretOffset = command.offset + 1;
				command.shiftsCaret = false;
				return;
			}
		}
		if(command.text.equals("{")){
			String indent = EditorUtils.getIndentOfLine(document, command.offset);
			command.text = "{" + "\r\n\t" + indent + "\r\n" + indent + "}";
			command.caretOffset = command.offset + 4 + indent.length();
			command.shiftsCaret = false;
		}
	}

}


