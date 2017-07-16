package md5bad7d514d890dad566d43ae3785e8f5e;


public class MainActivity_ClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("GoogleCameraView.MainActivity+ClickListener, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_ClickListener.class, __md_methods);
	}


	public MainActivity_ClickListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_ClickListener.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.MainActivity+ClickListener, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_ClickListener (com.google.android.cameraview.CameraView p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_ClickListener.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.MainActivity+ClickListener, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Com.Google.Android.Cameraview.CameraView, Naxam.CameraView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
