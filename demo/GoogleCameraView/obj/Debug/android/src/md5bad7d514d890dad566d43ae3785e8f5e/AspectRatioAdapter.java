package md5bad7d514d890dad566d43ae3785e8f5e;


public class AspectRatioAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("GoogleCameraView.AspectRatioAdapter, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AspectRatioAdapter.class, __md_methods);
	}


	public AspectRatioAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AspectRatioAdapter.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.AspectRatioAdapter, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public AspectRatioAdapter (com.google.android.cameraview.AspectRatio[] p0, com.google.android.cameraview.AspectRatio p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == AspectRatioAdapter.class)
			mono.android.TypeManager.Activate ("GoogleCameraView.AspectRatioAdapter, GoogleCameraView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Com.Google.Android.Cameraview.AspectRatio[], Naxam.CameraView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:Com.Google.Android.Cameraview.AspectRatio, Naxam.CameraView.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0, p1 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
