using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Cameraview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']"
	[global::Android.Runtime.Register ("com/google/android/cameraview/AspectRatio", DoNotGenerateAcw=true)]
	public partial class AspectRatio : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.Lang.IComparable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/google/android/cameraview/AspectRatio", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AspectRatio); }
		}

		protected AspectRatio (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_compareTo_Lcom_google_android_cameraview_AspectRatio_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_google_android_cameraview_AspectRatio_Handler ()
		{
			if (cb_compareTo_Lcom_google_android_cameraview_AspectRatio_ == null)
				cb_compareTo_Lcom_google_android_cameraview_AspectRatio_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_google_android_cameraview_AspectRatio_);
			return cb_compareTo_Lcom_google_android_cameraview_AspectRatio_;
		}

		static int n_CompareTo_Lcom_google_android_cameraview_AspectRatio_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.AspectRatio p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_google_android_cameraview_AspectRatio_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.AspectRatio']]"
		[Register ("compareTo", "(Lcom/google/android/cameraview/AspectRatio;)I", "GetCompareTo_Lcom_google_android_cameraview_AspectRatio_Handler")]
		public virtual unsafe int CompareTo (global::Com.Google.Android.Cameraview.AspectRatio p0)
		{
			if (id_compareTo_Lcom_google_android_cameraview_AspectRatio_ == IntPtr.Zero)
				id_compareTo_Lcom_google_android_cameraview_AspectRatio_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/google/android/cameraview/AspectRatio;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lcom_google_android_cameraview_AspectRatio_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/google/android/cameraview/AspectRatio;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetX);
			return cb_getX;
		}

		static int n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()I", "GetGetXHandler")]
		public virtual unsafe int GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()I"));
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetY);
			return cb_getY;
		}

		static int n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()I", "GetGetYHandler")]
		public virtual unsafe int GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getY);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()I"));
			} finally {
			}
		}

		static Delegate cb_inverse;
#pragma warning disable 0169
		static Delegate GetInverseHandler ()
		{
			if (cb_inverse == null)
				cb_inverse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Inverse);
			return cb_inverse;
		}

		static IntPtr n_Inverse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Inverse ());
		}
#pragma warning restore 0169

		static IntPtr id_inverse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='inverse' and count(parameter)=0]"
		[Register ("inverse", "()Lcom/google/android/cameraview/AspectRatio;", "GetInverseHandler")]
		public virtual unsafe global::Com.Google.Android.Cameraview.AspectRatio Inverse ()
		{
			if (id_inverse == IntPtr.Zero)
				id_inverse = JNIEnv.GetMethodID (class_ref, "inverse", "()Lcom/google/android/cameraview/AspectRatio;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_inverse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inverse", "()Lcom/google/android/cameraview/AspectRatio;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_matches_Lcom_google_android_cameraview_Size_;
#pragma warning disable 0169
		static Delegate GetMatches_Lcom_google_android_cameraview_Size_Handler ()
		{
			if (cb_matches_Lcom_google_android_cameraview_Size_ == null)
				cb_matches_Lcom_google_android_cameraview_Size_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Matches_Lcom_google_android_cameraview_Size_);
			return cb_matches_Lcom_google_android_cameraview_Size_;
		}

		static bool n_Matches_Lcom_google_android_cameraview_Size_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Cameraview.Size p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.Size> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Matches (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_matches_Lcom_google_android_cameraview_Size_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='com.google.android.cameraview.Size']]"
		[Register ("matches", "(Lcom/google/android/cameraview/Size;)Z", "GetMatches_Lcom_google_android_cameraview_Size_Handler")]
		public virtual unsafe bool Matches (global::Com.Google.Android.Cameraview.Size p0)
		{
			if (id_matches_Lcom_google_android_cameraview_Size_ == IntPtr.Zero)
				id_matches_Lcom_google_android_cameraview_Size_ = JNIEnv.GetMethodID (class_ref, "matches", "(Lcom/google/android/cameraview/Size;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_matches_Lcom_google_android_cameraview_Size_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "matches", "(Lcom/google/android/cameraview/Size;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_of_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='of' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("of", "(II)Lcom/google/android/cameraview/AspectRatio;", "")]
		public static unsafe global::Com.Google.Android.Cameraview.AspectRatio Of (int p0, int p1)
		{
			if (id_of_II == IntPtr.Zero)
				id_of_II = JNIEnv.GetStaticMethodID (class_ref, "of", "(II)Lcom/google/android/cameraview/AspectRatio;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallStaticObjectMethod  (class_ref, id_of_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/google/android/cameraview/AspectRatio;", "")]
		public static unsafe global::Com.Google.Android.Cameraview.AspectRatio Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/google/android/cameraview/AspectRatio;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Android.Cameraview.AspectRatio __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_toFloat;
#pragma warning disable 0169
		static Delegate GetToFloatHandler ()
		{
			if (cb_toFloat == null)
				cb_toFloat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ToFloat);
			return cb_toFloat;
		}

		static float n_ToFloat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToFloat ();
		}
#pragma warning restore 0169

		static IntPtr id_toFloat;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='toFloat' and count(parameter)=0]"
		[Register ("toFloat", "()F", "GetToFloatHandler")]
		public virtual unsafe float ToFloat ()
		{
			if (id_toFloat == IntPtr.Zero)
				id_toFloat = JNIEnv.GetMethodID (class_ref, "toFloat", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_toFloat);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toFloat", "()F"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Google.Android.Cameraview.AspectRatio __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Cameraview.AspectRatio> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.cameraview']/class[@name='AspectRatio']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
