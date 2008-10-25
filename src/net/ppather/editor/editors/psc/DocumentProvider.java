package net.ppather.editor.editors.psc;

import net.ppather.editor.PPatherPlugin;

import org.eclipse.core.runtime.CoreException;
import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.IDocumentExtension3;
import org.eclipse.jface.text.IDocumentPartitioner;
import org.eclipse.jface.text.rules.FastPartitioner;
import org.eclipse.ui.editors.text.FileDocumentProvider;


public class DocumentProvider extends FileDocumentProvider {
	@Override
	protected IDocument createDocument(Object element) throws CoreException{
		IDocument document = super.createDocument(element);
		
		if (document instanceof IDocumentExtension3){
			IDocumentExtension3 extension3= (IDocumentExtension3) document;
			IDocumentPartitioner partitioner= new FastPartitioner(PPatherPlugin.getDefault().getPartitionScanner(),PartitionScanner.PARTITION_TYPES);
			extension3.setDocumentPartitioner(PPatherPlugin.PSC_PARTITIONING, partitioner);
			partitioner.connect(document);
		}
		return document;
	}
	
	@Override
	protected IDocument createEmptyDocument() {
		return super.createEmptyDocument();
	}
}
