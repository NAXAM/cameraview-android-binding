using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Cameraview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='Size']"
	[global::Android.Runtime.Register ("com/google/android/cameraview/Size", DoNotGenerateAcw=true)]
	public partial class Size : global::Java.Lang.Object, global::Java.Lang.IComparable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/cameraview/Size", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Size); }
		}

		protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='Size']/constructor[@name='Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Size (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Size)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.Size __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='Size']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.Size __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='Size']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_compareTo_Lcom_google_android_cameraview_Size_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_google_android_cameraview_Size_Handler ()
		{
			if (cb_compareTo_Lcom_google_android_cameraview_Size_ == null)
				cb_compareTo_Lcom_google_android_cameraview_Size_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_google_android_cameraview_Size_);
			return cb_compareTo_Lcom_google_android_cameraview_Size_;
		}

		static int n_CompareTo_Lcom_google_android_cameraview_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.Size __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.Size p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_google_android_cameraview_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='Size']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.Size']]"
		[Register ("compareTo", "(Lcom/google/android/cameraview/Size;)I", "GetCompareTo_Lcom_google_android_cameraview_Size_Handler")]
		public virtual unsafe int CompareTo (global::Com.Google.Android.Cameraview.Size p0)
		{
			if (id_compareTo_Lcom_google_android_cameraview_Size_ == IntPtr.Zero)
				id_compareTo_Lcom_google_android_cameraview_Size_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/google/android/cameraview/Size;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lcom_google_android_cameraview_Size_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/google/android/cameraview/Size;)I"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
