package md5bad7d514d890dad566d43ae3785e8f5e;


public class MainActivity_CameraViewCallback
	extends com.google.android.cameraview.CameraView.Callback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onPictureTaken:(Lcom/google/android/cameraview/CameraView;[B)V:GetOnPictureTaken_Lcom_google_android_cameraview_CameraView_arrayBHandler\n" +
			"";
		mono.android.Runtime.register ("GoogleCameraView.MainActivity+CameraViewCallback, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MainActivity_CameraViewCallback.class, __md_methods);
	}


	public MainActivity_CameraViewCallback () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_CameraViewCallback.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.MainActivity+CameraViewCallback, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MainActivity_CameraViewCallback (com.google.android.cameraview.CameraView p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MainActivity_CameraViewCallback.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.MainActivity+CameraViewCallback, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Com.Google.Android.Cameraview.CameraView, Naxam.CameraView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onPictureTaken (com.google.android.cameraview.CameraView p0, byte[] p1)
	{
		n_onPictureTaken (p0, p1);
	}

	private native void n_onPictureTaken (com.google.android.cameraview.CameraView p0, byte[] p1);

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
