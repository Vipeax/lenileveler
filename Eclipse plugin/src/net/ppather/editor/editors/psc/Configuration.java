package net.ppather.editor.editors.psc;

import net.ppather.editor.PPatherPlugin;

import org.eclipse.jface.text.DefaultIndentLineAutoEditStrategy;
import org.eclipse.jface.text.IAutoEditStrategy;
import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.contentassist.ContentAssistant;
import org.eclipse.jface.text.contentassist.IContentAssistProcessor;
import org.eclipse.jface.text.contentassist.IContentAssistant;
import org.eclipse.jface.text.presentation.IPresentationReconciler;
import org.eclipse.jface.text.presentation.PresentationReconciler;
import org.eclipse.jface.text.rules.DefaultDamagerRepairer;
import org.eclipse.jface.text.source.ISourceViewer;
import org.eclipse.swt.graphics.RGB;
import org.eclipse.ui.editors.text.TextSourceViewerConfiguration;

import net.ppather.editor.editors.utils.ColorHandler;


public class Configuration extends TextSourceViewerConfiguration {
	private ColorHandler colorManager;
	
	public Configuration(ColorHandler colorManager) {
		this.colorManager = colorManager;
	}
	
	@Override
	public IPresentationReconciler getPresentationReconciler(ISourceViewer sourceViewer) {
		PresentationReconciler pr = new PresentationReconciler();
		DefaultDamagerRepairer ddr = new DefaultDamagerRepairer(new Scanner(colorManager));
		pr.setDamager(ddr, IDocument.DEFAULT_CONTENT_TYPE);
		pr.setRepairer(ddr, IDocument.DEFAULT_CONTENT_TYPE);
		return pr;
	}

	@Override
	public String getConfiguredDocumentPartitioning(ISourceViewer sourceViewer) {
		return PPatherPlugin.PSC_PARTITIONING;
	}
	
	@Override
	public String[] getConfiguredContentTypes(ISourceViewer sourceViewer) {
		return new String[] { 
				IDocument.DEFAULT_CONTENT_TYPE,
				PartitionScanner.STRING, 
				PartitionScanner.COMMENT, 
		};
	}
	
	@Override
	public IAutoEditStrategy[] getAutoEditStrategies(ISourceViewer sourceViewer,String contentType) {
		IAutoEditStrategy strategy= (IDocument.DEFAULT_CONTENT_TYPE.equals(contentType) 
				? new AutoEditStrategy() : new DefaultIndentLineAutoEditStrategy());
		return new IAutoEditStrategy[] { strategy };
	}
	
	@Override
	public IContentAssistant getContentAssistant(ISourceViewer sourceViewer){
		// Create content assistant
		ContentAssistant assistant = new ContentAssistant();
		// Create content assistant processor
		IContentAssistProcessor processor = new CompletionProcessor();
		// Set this processor for each supported content type
		assistant.setContentAssistProcessor(processor, IDocument.DEFAULT_CONTENT_TYPE);
		assistant.setContentAssistProcessor(processor, PartitionScanner.STRING);
		assistant.setContentAssistProcessor(processor, PartitionScanner.COMMENT);
		
		// Set factory for information controller
		assistant.setInformationControlCreator(getInformationControlCreator(sourceViewer));
		
		// Allow automatic activation after 500
		assistant.enableAutoActivation(true);
		assistant.setAutoActivationDelay(500);
		
		// Set background color
		assistant.setProposalSelectorBackground(colorManager.getColor(new RGB(230,255,230)));
		
        // Return the content assistant
		return assistant;
		
	}
}
