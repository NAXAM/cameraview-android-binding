using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Cameraview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']"
	[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView", DoNotGenerateAcw=true)]
	public partial class CameraView : global::Android.Widget.FrameLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FACING_BACK']"
		[Register ("FACING_BACK")]
		public const int FacingBack = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FACING_FRONT']"
		[Register ("FACING_FRONT")]
		public const int FacingFront = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FLASH_AUTO']"
		[Register ("FLASH_AUTO")]
		public const int FlashAuto = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FLASH_OFF']"
		[Register ("FLASH_OFF")]
		public const int FlashOff = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FLASH_ON']"
		[Register ("FLASH_ON")]
		public const int FlashOn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FLASH_RED_EYE']"
		[Register ("FLASH_RED_EYE")]
		public const int FlashRedEye = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/field[@name='FLASH_TORCH']"
		[Register ("FLASH_TORCH")]
		public const int FlashTorch = (int) 2;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.Callback']"
		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$Callback", DoNotGenerateAcw=true)]
		public abstract partial class Callback : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/cameraview/CameraView$Callback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Callback); }
			}

			protected Callback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.Callback']/constructor[@name='CameraView.Callback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Callback ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Callback)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_onCameraClosed_Lcom_google_android_cameraview_CameraView_;
#pragma warning disable 0169
			static Delegate GetOnCameraClosed_Lcom_google_android_cameraview_CameraView_Handler ()
			{
				if (cb_onCameraClosed_Lcom_google_android_cameraview_CameraView_ == null)
					cb_onCameraClosed_Lcom_google_android_cameraview_CameraView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraClosed_Lcom_google_android_cameraview_CameraView_);
				return cb_onCameraClosed_Lcom_google_android_cameraview_CameraView_;
			}

			static void n_OnCameraClosed_Lcom_google_android_cameraview_CameraView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraClosed (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraClosed_Lcom_google_android_cameraview_CameraView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.Callback']/method[@name='onCameraClosed' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView']]"
			[Register ("onCameraClosed", "(Lcom/google/android/cameraview/CameraView;)V", "GetOnCameraClosed_Lcom_google_android_cameraview_CameraView_Handler")]
			public virtual unsafe void OnCameraClosed (global::Com.Google.Android.Cameraview.CameraView p0)
			{
				if (id_onCameraClosed_Lcom_google_android_cameraview_CameraView_ == IntPtr.Zero)
					id_onCameraClosed_Lcom_google_android_cameraview_CameraView_ = JNIEnv.GetMethodID (class_ref, "onCameraClosed", "(Lcom/google/android/cameraview/CameraView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraClosed_Lcom_google_android_cameraview_CameraView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraClosed", "(Lcom/google/android/cameraview/CameraView;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraOpened_Lcom_google_android_cameraview_CameraView_;
#pragma warning disable 0169
			static Delegate GetOnCameraOpened_Lcom_google_android_cameraview_CameraView_Handler ()
			{
				if (cb_onCameraOpened_Lcom_google_android_cameraview_CameraView_ == null)
					cb_onCameraOpened_Lcom_google_android_cameraview_CameraView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraOpened_Lcom_google_android_cameraview_CameraView_);
				return cb_onCameraOpened_Lcom_google_android_cameraview_CameraView_;
			}

			static void n_OnCameraOpened_Lcom_google_android_cameraview_CameraView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpened (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onCameraOpened_Lcom_google_android_cameraview_CameraView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.Callback']/method[@name='onCameraOpened' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView']]"
			[Register ("onCameraOpened", "(Lcom/google/android/cameraview/CameraView;)V", "GetOnCameraOpened_Lcom_google_android_cameraview_CameraView_Handler")]
			public virtual unsafe void OnCameraOpened (global::Com.Google.Android.Cameraview.CameraView p0)
			{
				if (id_onCameraOpened_Lcom_google_android_cameraview_CameraView_ == IntPtr.Zero)
					id_onCameraOpened_Lcom_google_android_cameraview_CameraView_ = JNIEnv.GetMethodID (class_ref, "onCameraOpened", "(Lcom/google/android/cameraview/CameraView;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraOpened_Lcom_google_android_cameraview_CameraView_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpened", "(Lcom/google/android/cameraview/CameraView;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB;
#pragma warning disable 0169
			static Delegate GetOnPictureTaken_Lcom_google_android_cameraview_CameraView_arrayBHandler ()
			{
				if (cb_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB == null)
					cb_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB);
				return cb_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB;
			}

			static void n_OnPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Android.Cameraview.CameraView.Callback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Cameraview.CameraView p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPictureTaken (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.Callback']/method[@name='onPictureTaken' and count(parameter)=2 and parameter[1][@type='com.google.android.cameraview.CameraView'] and parameter[2][@type='byte[]']]"
			[Register ("onPictureTaken", "(Lcom/google/android/cameraview/CameraView;[B)V", "GetOnPictureTaken_Lcom_google_android_cameraview_CameraView_arrayBHandler")]
			public virtual unsafe void OnPictureTaken (global::Com.Google.Android.Cameraview.CameraView p0, byte[] p1)
			{
				if (id_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB == IntPtr.Zero)
					id_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB = JNIEnv.GetMethodID (class_ref, "onPictureTaken", "(Lcom/google/android/cameraview/CameraView;[B)V");
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPictureTaken_Lcom_google_android_cameraview_CameraView_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPictureTaken", "(Lcom/google/android/cameraview/CameraView;[B)V"), __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$Callback", DoNotGenerateAcw=true)]
		internal partial class CallbackInvoker : Callback {

			public CallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackInvoker); }
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']"
		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$CallbackBridge", DoNotGenerateAcw=true)]
		public partial class CallbackBridge : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/cameraview/CameraView$CallbackBridge", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackBridge); }
			}

			protected CallbackBridge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_add_Lcom_google_android_cameraview_CameraView_Callback_;
#pragma warning disable 0169
			static Delegate GetAdd_Lcom_google_android_cameraview_CameraView_Callback_Handler ()
			{
				if (cb_add_Lcom_google_android_cameraview_CameraView_Callback_ == null)
					cb_add_Lcom_google_android_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_google_android_cameraview_CameraView_Callback_);
				return cb_add_Lcom_google_android_cameraview_CameraView_Callback_;
			}

			static void n_Add_Lcom_google_android_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Add (p0);
			}
#pragma warning restore 0169

			static IntPtr id_add_Lcom_google_android_cameraview_CameraView_Callback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView.Callback']]"
			[Register ("add", "(Lcom/google/android/cameraview/CameraView$Callback;)V", "GetAdd_Lcom_google_android_cameraview_CameraView_Callback_Handler")]
			public virtual unsafe void Add (global::Com.Google.Android.Cameraview.CameraView.Callback p0)
			{
				if (id_add_Lcom_google_android_cameraview_CameraView_Callback_ == IntPtr.Zero)
					id_add_Lcom_google_android_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/android/cameraview/CameraView$Callback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_google_android_cameraview_CameraView_Callback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/google/android/cameraview/CameraView$Callback;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onCameraClosed;
#pragma warning disable 0169
			static Delegate GetOnCameraClosedHandler ()
			{
				if (cb_onCameraClosed == null)
					cb_onCameraClosed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraClosed);
				return cb_onCameraClosed;
			}

			static void n_OnCameraClosed (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraClosed ();
			}
#pragma warning restore 0169

			static IntPtr id_onCameraClosed;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onCameraClosed' and count(parameter)=0]"
			[Register ("onCameraClosed", "()V", "GetOnCameraClosedHandler")]
			public virtual unsafe void OnCameraClosed ()
			{
				if (id_onCameraClosed == IntPtr.Zero)
					id_onCameraClosed = JNIEnv.GetMethodID (class_ref, "onCameraClosed", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraClosed);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraClosed", "()V"));
				} finally {
				}
			}

			static Delegate cb_onCameraOpened;
#pragma warning disable 0169
			static Delegate GetOnCameraOpenedHandler ()
			{
				if (cb_onCameraOpened == null)
					cb_onCameraOpened = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCameraOpened);
				return cb_onCameraOpened;
			}

			static void n_OnCameraOpened (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCameraOpened ();
			}
#pragma warning restore 0169

			static IntPtr id_onCameraOpened;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onCameraOpened' and count(parameter)=0]"
			[Register ("onCameraOpened", "()V", "GetOnCameraOpenedHandler")]
			public virtual unsafe void OnCameraOpened ()
			{
				if (id_onCameraOpened == IntPtr.Zero)
					id_onCameraOpened = JNIEnv.GetMethodID (class_ref, "onCameraOpened", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCameraOpened);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCameraOpened", "()V"));
				} finally {
				}
			}

			static Delegate cb_onPictureTaken_arrayB;
#pragma warning disable 0169
			static Delegate GetOnPictureTaken_arrayBHandler ()
			{
				if (cb_onPictureTaken_arrayB == null)
					cb_onPictureTaken_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPictureTaken_arrayB);
				return cb_onPictureTaken_arrayB;
			}

			static void n_OnPictureTaken_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.OnPictureTaken (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPictureTaken_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='onPictureTaken' and count(parameter)=1 and parameter[1][@type='byte[]']]"
			[Register ("onPictureTaken", "([B)V", "GetOnPictureTaken_arrayBHandler")]
			public virtual unsafe void OnPictureTaken (byte[] p0)
			{
				if (id_onPictureTaken_arrayB == IntPtr.Zero)
					id_onPictureTaken_arrayB = JNIEnv.GetMethodID (class_ref, "onPictureTaken", "([B)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPictureTaken_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPictureTaken", "([B)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_remove_Lcom_google_android_cameraview_CameraView_Callback_;
#pragma warning disable 0169
			static Delegate GetRemove_Lcom_google_android_cameraview_CameraView_Callback_Handler ()
			{
				if (cb_remove_Lcom_google_android_cameraview_CameraView_Callback_ == null)
					cb_remove_Lcom_google_android_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_google_android_cameraview_CameraView_Callback_);
				return cb_remove_Lcom_google_android_cameraview_CameraView_Callback_;
			}

			static void n_Remove_Lcom_google_android_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Android.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Lcom_google_android_cameraview_CameraView_Callback_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView.Callback']]"
			[Register ("remove", "(Lcom/google/android/cameraview/CameraView$Callback;)V", "GetRemove_Lcom_google_android_cameraview_CameraView_Callback_Handler")]
			public virtual unsafe void Remove (global::Com.Google.Android.Cameraview.CameraView.Callback p0)
			{
				if (id_remove_Lcom_google_android_cameraview_CameraView_Callback_ == IntPtr.Zero)
					id_remove_Lcom_google_android_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/google/android/cameraview/CameraView$Callback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_google_android_cameraview_CameraView_Callback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/google/android/cameraview/CameraView$Callback;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_reserveRequestLayoutOnOpen;
#pragma warning disable 0169
			static Delegate GetReserveRequestLayoutOnOpenHandler ()
			{
				if (cb_reserveRequestLayoutOnOpen == null)
					cb_reserveRequestLayoutOnOpen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReserveRequestLayoutOnOpen);
				return cb_reserveRequestLayoutOnOpen;
			}

			static void n_ReserveRequestLayoutOnOpen (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.CallbackBridge __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.CallbackBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ReserveRequestLayoutOnOpen ();
			}
#pragma warning restore 0169

			static IntPtr id_reserveRequestLayoutOnOpen;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.CallbackBridge']/method[@name='reserveRequestLayoutOnOpen' and count(parameter)=0]"
			[Register ("reserveRequestLayoutOnOpen", "()V", "GetReserveRequestLayoutOnOpenHandler")]
			public virtual unsafe void ReserveRequestLayoutOnOpen ()
			{
				if (id_reserveRequestLayoutOnOpen == IntPtr.Zero)
					id_reserveRequestLayoutOnOpen = JNIEnv.GetMethodID (class_ref, "reserveRequestLayoutOnOpen", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reserveRequestLayoutOnOpen);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reserveRequestLayoutOnOpen", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.cameraview']/interface[@name='CameraView.Facing']"
		[Register ("com/google/android/cameraview/CameraView$Facing", "", "Com.Google.Android.Cameraview.CameraView/IFacingInvoker")]
		public partial interface IFacing : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$Facing", DoNotGenerateAcw=true)]
		internal class IFacingInvoker : global::Java.Lang.Object, IFacing {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/cameraview/CameraView$Facing");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFacingInvoker); }
			}

			IntPtr class_ref;

			public static IFacing GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFacing> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.cameraview.CameraView.Facing"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFacingInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFacing __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFacing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.cameraview']/interface[@name='CameraView.Flash']"
		[Register ("com/google/android/cameraview/CameraView$Flash", "", "Com.Google.Android.Cameraview.CameraView/IFlashInvoker")]
		public partial interface IFlash : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$Flash", DoNotGenerateAcw=true)]
		internal class IFlashInvoker : global::Java.Lang.Object, IFlash {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/cameraview/CameraView$Flash");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFlashInvoker); }
			}

			IntPtr class_ref;

			public static IFlash GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFlash> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.cameraview.CameraView.Flash"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFlashInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Cameraview.CameraView.IFlash __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.IFlash> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.SavedState']"
		[global::Android.Runtime.Register ("com/google/android/cameraview/CameraView$SavedState", DoNotGenerateAcw=true)]
		protected internal partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/cameraview/CameraView$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_os_Parcel_Ljava_lang_ClassLoader_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.SavedState']/constructor[@name='CameraView.SavedState' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='java.lang.ClassLoader']]"
			[Register (".ctor", "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)V", "")]
			public unsafe SavedState (global::Android.OS.Parcel p0, global::Java.Lang.ClassLoader p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (SavedState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcel_Ljava_lang_ClassLoader_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcel_Ljava_lang_ClassLoader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;Ljava/lang/ClassLoader;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_Ljava_lang_ClassLoader_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_Ljava_lang_ClassLoader_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_os_Parcelable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView.SavedState']/constructor[@name='CameraView.SavedState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
			[Register (".ctor", "(Landroid/os/Parcelable;)V", "")]
			public unsafe SavedState (global::Android.OS.IParcelable p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (SavedState)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcelable;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcelable;)V", __args);
						return;
					}

					if (id_ctor_Landroid_os_Parcelable_ == IntPtr.Zero)
						id_ctor_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcelable;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcelable_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcelable_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/cameraview/CameraView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CameraView); }
		}

		protected CameraView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (CameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (CameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/constructor[@name='CameraView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CameraView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CameraView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdjustViewBounds;
#pragma warning disable 0169
		static Delegate GetGetAdjustViewBoundsHandler ()
		{
			if (cb_getAdjustViewBounds == null)
				cb_getAdjustViewBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAdjustViewBounds);
			return cb_getAdjustViewBounds;
		}

		static bool n_GetAdjustViewBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdjustViewBounds;
		}
#pragma warning restore 0169

		static Delegate cb_setAdjustViewBounds_Z;
#pragma warning disable 0169
		static Delegate GetSetAdjustViewBounds_ZHandler ()
		{
			if (cb_setAdjustViewBounds_Z == null)
				cb_setAdjustViewBounds_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAdjustViewBounds_Z);
			return cb_setAdjustViewBounds_Z;
		}

		static void n_SetAdjustViewBounds_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdjustViewBounds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdjustViewBounds;
		static IntPtr id_setAdjustViewBounds_Z;
		public virtual unsafe bool AdjustViewBounds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getAdjustViewBounds' and count(parameter)=0]"
			[Register ("getAdjustViewBounds", "()Z", "GetGetAdjustViewBoundsHandler")]
			get {
				if (id_getAdjustViewBounds == IntPtr.Zero)
					id_getAdjustViewBounds = JNIEnv.GetMethodID (class_ref, "getAdjustViewBounds", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAdjustViewBounds);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdjustViewBounds", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='setAdjustViewBounds' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAdjustViewBounds", "(Z)V", "GetSetAdjustViewBounds_ZHandler")]
			set {
				if (id_setAdjustViewBounds_Z == IntPtr.Zero)
					id_setAdjustViewBounds_Z = JNIEnv.GetMethodID (class_ref, "setAdjustViewBounds", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdjustViewBounds_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdjustViewBounds", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioHandler ()
		{
			if (cb_getAspectRatio == null)
				cb_getAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAspectRatio);
			return cb_getAspectRatio;
		}

		static IntPtr n_GetAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AspectRatio);
		}
#pragma warning restore 0169

		static Delegate cb_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_;
#pragma warning disable 0169
		static Delegate GetSetAspectRatio_Lcom_google_android_cameraview_AspectRatio_Handler ()
		{
			if (cb_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_ == null)
				cb_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAspectRatio_Lcom_google_android_cameraview_AspectRatio_);
			return cb_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_;
		}

		static void n_SetAspectRatio_Lcom_google_android_cameraview_AspectRatio_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.AspectRatio p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AspectRatio = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAspectRatio;
		static IntPtr id_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_;
		public virtual unsafe global::Com.Google.Android.Cameraview.AspectRatio AspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getAspectRatio' and count(parameter)=0]"
			[Register ("getAspectRatio", "()Lcom/google/android/cameraview/AspectRatio;", "GetGetAspectRatioHandler")]
			get {
				if (id_getAspectRatio == IntPtr.Zero)
					id_getAspectRatio = JNIEnv.GetMethodID (class_ref, "getAspectRatio", "()Lcom/google/android/cameraview/AspectRatio;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAspectRatio), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAspectRatio", "()Lcom/google/android/cameraview/AspectRatio;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='setAspectRatio' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.AspectRatio']]"
			[Register ("setAspectRatio", "(Lcom/google/android/cameraview/AspectRatio;)V", "GetSetAspectRatio_Lcom_google_android_cameraview_AspectRatio_Handler")]
			set {
				if (id_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_ == IntPtr.Zero)
					id_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_ = JNIEnv.GetMethodID (class_ref, "setAspectRatio", "(Lcom/google/android/cameraview/AspectRatio;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAspectRatio_Lcom_google_android_cameraview_AspectRatio_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAspectRatio", "(Lcom/google/android/cameraview/AspectRatio;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAutoFocus;
#pragma warning disable 0169
		static Delegate GetGetAutoFocusHandler ()
		{
			if (cb_getAutoFocus == null)
				cb_getAutoFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoFocus);
			return cb_getAutoFocus;
		}

		static bool n_GetAutoFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoFocus;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoFocus_ZHandler ()
		{
			if (cb_setAutoFocus_Z == null)
				cb_setAutoFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoFocus_Z);
			return cb_setAutoFocus_Z;
		}

		static void n_SetAutoFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoFocus = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoFocus;
		static IntPtr id_setAutoFocus_Z;
		public virtual unsafe bool AutoFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getAutoFocus' and count(parameter)=0]"
			[Register ("getAutoFocus", "()Z", "GetGetAutoFocusHandler")]
			get {
				if (id_getAutoFocus == IntPtr.Zero)
					id_getAutoFocus = JNIEnv.GetMethodID (class_ref, "getAutoFocus", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoFocus);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoFocus", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='setAutoFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoFocus", "(Z)V", "GetSetAutoFocus_ZHandler")]
			set {
				if (id_setAutoFocus_Z == IntPtr.Zero)
					id_setAutoFocus_Z = JNIEnv.GetMethodID (class_ref, "setAutoFocus", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoFocus_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoFocus", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFacing;
#pragma warning disable 0169
		static Delegate GetGetFacingHandler ()
		{
			if (cb_getFacing == null)
				cb_getFacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFacing);
			return cb_getFacing;
		}

		static int n_GetFacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Facing;
		}
#pragma warning restore 0169

		static Delegate cb_setFacing_I;
#pragma warning disable 0169
		static Delegate GetSetFacing_IHandler ()
		{
			if (cb_setFacing_I == null)
				cb_setFacing_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFacing_I);
			return cb_setFacing_I;
		}

		static void n_SetFacing_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Facing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFacing;
		static IntPtr id_setFacing_I;
		public virtual unsafe int Facing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getFacing' and count(parameter)=0]"
			[Register ("getFacing", "()I", "GetGetFacingHandler")]
			get {
				if (id_getFacing == IntPtr.Zero)
					id_getFacing = JNIEnv.GetMethodID (class_ref, "getFacing", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFacing);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFacing", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='setFacing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFacing", "(I)V", "GetSetFacing_IHandler")]
			set {
				if (id_setFacing_I == IntPtr.Zero)
					id_setFacing_I = JNIEnv.GetMethodID (class_ref, "setFacing", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFacing_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacing", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFlash;
#pragma warning disable 0169
		static Delegate GetGetFlashHandler ()
		{
			if (cb_getFlash == null)
				cb_getFlash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFlash);
			return cb_getFlash;
		}

		static int n_GetFlash (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flash;
		}
#pragma warning restore 0169

		static Delegate cb_setFlash_I;
#pragma warning disable 0169
		static Delegate GetSetFlash_IHandler ()
		{
			if (cb_setFlash_I == null)
				cb_setFlash_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFlash_I);
			return cb_setFlash_I;
		}

		static void n_SetFlash_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flash = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFlash;
		static IntPtr id_setFlash_I;
		public virtual unsafe int Flash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getFlash' and count(parameter)=0]"
			[Register ("getFlash", "()I", "GetGetFlashHandler")]
			get {
				if (id_getFlash == IntPtr.Zero)
					id_getFlash = JNIEnv.GetMethodID (class_ref, "getFlash", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFlash);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlash", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='setFlash' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFlash", "(I)V", "GetSetFlash_IHandler")]
			set {
				if (id_setFlash_I == IntPtr.Zero)
					id_setFlash_I = JNIEnv.GetMethodID (class_ref, "setFlash", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFlash_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlash", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCameraOpened;
#pragma warning disable 0169
		static Delegate GetIsCameraOpenedHandler ()
		{
			if (cb_isCameraOpened == null)
				cb_isCameraOpened = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCameraOpened);
			return cb_isCameraOpened;
		}

		static bool n_IsCameraOpened (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCameraOpened;
		}
#pragma warning restore 0169

		static IntPtr id_isCameraOpened;
		public virtual unsafe bool IsCameraOpened {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='isCameraOpened' and count(parameter)=0]"
			[Register ("isCameraOpened", "()Z", "GetIsCameraOpenedHandler")]
			get {
				if (id_isCameraOpened == IntPtr.Zero)
					id_isCameraOpened = JNIEnv.GetMethodID (class_ref, "isCameraOpened", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCameraOpened);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCameraOpened", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedAspectRatios;
#pragma warning disable 0169
		static Delegate GetGetSupportedAspectRatiosHandler ()
		{
			if (cb_getSupportedAspectRatios == null)
				cb_getSupportedAspectRatios = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportedAspectRatios);
			return cb_getSupportedAspectRatios;
		}

		static IntPtr n_GetSupportedAspectRatios (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Google.Android.Cameraview.AspectRatio>.ToLocalJniHandle (__this.SupportedAspectRatios);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportedAspectRatios;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Google.Android.Cameraview.AspectRatio> SupportedAspectRatios {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='getSupportedAspectRatios' and count(parameter)=0]"
			[Register ("getSupportedAspectRatios", "()Ljava/util/Set;", "GetGetSupportedAspectRatiosHandler")]
			get {
				if (id_getSupportedAspectRatios == IntPtr.Zero)
					id_getSupportedAspectRatios = JNIEnv.GetMethodID (class_ref, "getSupportedAspectRatios", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Google.Android.Cameraview.AspectRatio>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedAspectRatios), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Google.Android.Cameraview.AspectRatio>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportedAspectRatios", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addCallback_Lcom_google_android_cameraview_CameraView_Callback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_google_android_cameraview_CameraView_Callback_Handler ()
		{
			if (cb_addCallback_Lcom_google_android_cameraview_CameraView_Callback_ == null)
				cb_addCallback_Lcom_google_android_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_google_android_cameraview_CameraView_Callback_);
			return cb_addCallback_Lcom_google_android_cameraview_CameraView_Callback_;
		}

		static void n_AddCallback_Lcom_google_android_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addCallback_Lcom_google_android_cameraview_CameraView_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView.Callback']]"
		[Register ("addCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V", "GetAddCallback_Lcom_google_android_cameraview_CameraView_Callback_Handler")]
		public virtual unsafe void AddCallback (global::Com.Google.Android.Cameraview.CameraView.Callback p0)
		{
			if (id_addCallback_Lcom_google_android_cameraview_CameraView_Callback_ == IntPtr.Zero)
				id_addCallback_Lcom_google_android_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_google_android_cameraview_CameraView_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_google_android_cameraview_CameraView_Callback_Handler ()
		{
			if (cb_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_ == null)
				cb_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_google_android_cameraview_CameraView_Callback_);
			return cb_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_;
		}

		static void n_RemoveCallback_Lcom_google_android_cameraview_CameraView_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.CameraView.Callback p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView.Callback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.CameraView.Callback']]"
		[Register ("removeCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V", "GetRemoveCallback_Lcom_google_android_cameraview_CameraView_Callback_Handler")]
		public virtual unsafe void RemoveCallback (global::Com.Google.Android.Cameraview.CameraView.Callback p0)
		{
			if (id_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_ == IntPtr.Zero)
				id_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_google_android_cameraview_CameraView_Callback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCallback", "(Lcom/google/android/cameraview/CameraView$Callback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_takePicture;
#pragma warning disable 0169
		static Delegate GetTakePictureHandler ()
		{
			if (cb_takePicture == null)
				cb_takePicture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TakePicture);
			return cb_takePicture;
		}

		static void n_TakePicture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.CameraView __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.CameraView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TakePicture ();
		}
#pragma warning restore 0169

		static IntPtr id_takePicture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='CameraView']/method[@name='takePicture' and count(parameter)=0]"
		[Register ("takePicture", "()V", "GetTakePictureHandler")]
		public virtual unsafe void TakePicture ()
		{
			if (id_takePicture == IntPtr.Zero)
				id_takePicture = JNIEnv.GetMethodID (class_ref, "takePicture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_takePicture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "takePicture", "()V"));
			} finally {
			}
		}

	}
}
