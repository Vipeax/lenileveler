package ppather_plugin.editors;

import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.ITextDoubleClickStrategy;
import org.eclipse.jface.text.TextAttribute;
import org.eclipse.jface.text.presentation.IPresentationReconciler;
import org.eclipse.jface.text.presentation.PresentationReconciler;
import org.eclipse.jface.text.rules.DefaultDamagerRepairer;
import org.eclipse.jface.text.rules.Token;
import org.eclipse.jface.text.source.ISourceViewer;
import org.eclipse.jface.text.source.SourceViewerConfiguration;

public class PSCConfiguration extends SourceViewerConfiguration {
	private PSCDoubleClickStrategy doubleClickStrategy;
	private PSCTagScanner tagScanner;
	private PSCScanner scanner;
	private ColorManager colorManager;

	public PSCConfiguration(ColorManager colorManager) {
		this.colorManager = colorManager;
	}
	public String[] getConfiguredContentTypes(ISourceViewer sourceViewer) {
		return new String[] {
			IDocument.DEFAULT_CONTENT_TYPE,
			PSCPartitionScanner.PSC_COMMENT,
			PSCPartitionScanner.PSC_TAG };
	}
	public ITextDoubleClickStrategy getDoubleClickStrategy(
		ISourceViewer sourceViewer,
		String contentType) {
		if (doubleClickStrategy == null)
			doubleClickStrategy = new PSCDoubleClickStrategy();
		return doubleClickStrategy;
	}

	protected PSCScanner getPSCScanner() {
		if (scanner == null) {
			scanner = new PSCScanner(colorManager);
			scanner.setDefaultReturnToken(
				new Token(
					new TextAttribute(
						colorManager.getColor(IPSCColorConstants.DEFAULT))));
		}
		return scanner;
	}
	protected PSCTagScanner getPSCTagScanner() {
		if (tagScanner == null) {
			tagScanner = new PSCTagScanner(colorManager);
			tagScanner.setDefaultReturnToken(
				new Token(
					new TextAttribute(
						colorManager.getColor(IPSCColorConstants.TAG))));
		}
		return tagScanner;
	}

	public IPresentationReconciler getPresentationReconciler(ISourceViewer sourceViewer) {
		PresentationReconciler reconciler = new PresentationReconciler();

		DefaultDamagerRepairer dr =
			new DefaultDamagerRepairer(getPSCTagScanner());
		reconciler.setDamager(dr, PSCPartitionScanner.PSC_TAG);
		reconciler.setRepairer(dr, PSCPartitionScanner.PSC_TAG);

		dr = new DefaultDamagerRepairer(getPSCScanner());
		reconciler.setDamager(dr, IDocument.DEFAULT_CONTENT_TYPE);
		reconciler.setRepairer(dr, IDocument.DEFAULT_CONTENT_TYPE);

		NonRuleBasedDamagerRepairer ndr =
			new NonRuleBasedDamagerRepairer(
				new TextAttribute(
					colorManager.getColor(IPSCColorConstants.PSC_COMMENT)));
		reconciler.setDamager(ndr, PSCPartitionScanner.PSC_COMMENT);
		reconciler.setRepairer(ndr, PSCPartitionScanner.PSC_COMMENT);

		return reconciler;
	}

}