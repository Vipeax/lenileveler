package ppather_plugin;

import java.util.MissingResourceException;
import java.util.ResourceBundle;

import org.eclipse.jface.resource.ImageDescriptor;
import org.eclipse.ui.plugin.AbstractUIPlugin;
import org.osgi.framework.BundleContext;

import ppather_plugin.editors.psc.PartitionScanner;

/**
 * The activator class controls the plug-in life cycle
 */
public class PPatherPlugin extends AbstractUIPlugin {

	// The plug-in ID
	public static final String PLUGIN_ID = "Ppather_plugin";
	// The shared instance
	private static PPatherPlugin plugin;
	//Resource bundle.
	private ResourceBundle resourceBundle;
	
	// Partition handling
	public final static String PSC_PARTITIONING = "___psc__partitioning____";
	private PartitionScanner fPartitionScanner;
	public PartitionScanner getPartitionScanner() {
		if (fPartitionScanner == null)
			fPartitionScanner= new PartitionScanner();
		return fPartitionScanner;
	}
	
	/**
	 * The constructor
	 */
	public PPatherPlugin() {
	}

	/*
	 * (non-Javadoc)
	 * @see org.eclipse.ui.plugin.AbstractUIPlugin#start(org.osgi.framework.BundleContext)
	 */
	public void start(BundleContext context) throws Exception {
		super.start(context);
		plugin = this;
		try {
			resourceBundle=ResourceBundle.getBundle("ppather_plugin.PPatherPluginResources");
		} catch (MissingResourceException x) {
			resourceBundle = null;
		}
	}

	/*
	 * (non-Javadoc)
	 * @see org.eclipse.ui.plugin.AbstractUIPlugin#stop(org.osgi.framework.BundleContext)
	 */
	public void stop(BundleContext context) throws Exception {
		plugin = null;
		super.stop(context);
	}

	/**
	 * Returns the shared instance
	 *
	 * @return the shared instance
	 */
	public static PPatherPlugin getDefault() {
		return plugin;
	}

	/**
	 * Returns an image descriptor for the image file at the given
	 * plug-in relative path
	 *
	 * @param path the path
	 * @return the image descriptor
	 */
	public static ImageDescriptor getImageDescriptor(String path) {
		return imageDescriptorFromPlugin(PLUGIN_ID, path);
	}

	/**
	 * Returns the plugin's resource bundle,
	 */
	public ResourceBundle getResourceBundle() {
		return resourceBundle;
	}
}
