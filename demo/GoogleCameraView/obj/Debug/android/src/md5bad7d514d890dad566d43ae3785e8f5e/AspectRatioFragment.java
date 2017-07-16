package md5bad7d514d890dad566d43ae3785e8f5e;


public class AspectRatioFragment
	extends android.support.v4.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAttach:(Landroid/content/Context;)V:GetOnAttach_Landroid_content_Context_Handler\n" +
			"n_onDetach:()V:GetOnDetachHandler\n" +
			"n_onCreateDialog:(Landroid/os/Bundle;)Landroid/app/Dialog;:GetOnCreateDialog_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("GoogleCameraView.AspectRatioFragment, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AspectRatioFragment.class, __md_methods);
	}


	public AspectRatioFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AspectRatioFragment.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.AspectRatioFragment, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onAttach (android.content.Context p0)
	{
		n_onAttach (p0);
	}

	private native void n_onAttach (android.content.Context p0);


	public void onDetach ()
	{
		n_onDetach ();
	}

	private native void n_onDetach ();


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
