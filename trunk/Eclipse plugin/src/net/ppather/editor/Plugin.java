package net.ppather.editor;

import java.util.MissingResourceException;
import java.util.ResourceBundle;

import org.eclipse.jface.resource.ImageDescriptor;
import org.eclipse.ui.plugin.AbstractUIPlugin;
import org.osgi.framework.BundleContext;

import net.ppather.editor.editors.psc.PartitionScanner;

/**
 * The activator class controls the plug-in life cycle
 */
public class Plugin extends AbstractUIPlugin {

	// The plug-in ID
	public static final String PLUGIN_ID = "Ppather_plugin";
	// The shared instance
	private static Plugin plugin;
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


	public Plugin() {
	}


	@Override
	public void start(BundleContext context) throws Exception {
		super.start(context);
		plugin = this;
		try {
			resourceBundle=ResourceBundle.getBundle("net.ppather.editor.PluginResources");
		} catch (MissingResourceException x) {
			resourceBundle = null;
		}
	}


	@Override
	public void stop(BundleContext context) throws Exception {
		plugin = null;
		super.stop(context);
	}

	/**
	 * Returns the shared instance
	 *
	 * @return the shared instance
	 */
	public static Plugin getDefault() {
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
