package md5bad7d514d890dad566d43ae3785e8f5e;


public class ConfirmationDialogFragment
	extends android.support.v4.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("GoogleCameraView.ConfirmationDialogFragment, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ConfirmationDialogFragment.class, __md_methods);
	}


	public ConfirmationDialogFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ConfirmationDialogFragment.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.ConfirmationDialogFragment, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.app.Dialog onCreateDialog (android.os.Bundle p0)
	{
		return n_onCreateDialog (p0);
	}

	private native android.app.Dialog n_onCreateDialog (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
