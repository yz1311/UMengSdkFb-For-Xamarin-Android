using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FBMessage']"
	[global::Android.Runtime.Register ("com/umeng/fb/push/FBMessage", DoNotGenerateAcw=true)]
	public partial class FBMessage : global::Java.Lang.Object {


		static IntPtr custom_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FBMessage']/field[@name='custom']"
		[Register ("custom")]
		public string Custom {
			get {
				if (custom_jfieldId == IntPtr.Zero)
					custom_jfieldId = JNIEnv.GetFieldID (class_ref, "custom", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, custom_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (custom_jfieldId == IntPtr.Zero)
					custom_jfieldId = JNIEnv.GetFieldID (class_ref, "custom", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, custom_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/push/FBMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FBMessage); }
		}

		protected FBMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FBMessage']/constructor[@name='FBMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public FBMessage (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (FBMessage)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
