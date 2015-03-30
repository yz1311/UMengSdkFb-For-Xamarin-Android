using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Opus {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.opus']/class[@name='OpusTool']"
	[global::Android.Runtime.Register ("com/umeng/fb/opus/OpusTool", DoNotGenerateAcw=true)]
	public partial class OpusTool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/opus/OpusTool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpusTool); }
		}

		protected OpusTool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.fb.opus']/class[@name='OpusTool']/constructor[@name='OpusTool' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public OpusTool (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OpusTool)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.opus']/class[@name='OpusTool']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Z", "")]
		public static bool A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Z");
			return JNIEnv.CallStaticBooleanMethod  (class_ref, id_a);
		}

		static Delegate cb_a_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_A_Ljava_lang_String_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_A_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.FB.Opus.OpusTool __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Opus.OpusTool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.A (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.opus']/class[@name='OpusTool']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;)I", "GetA_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual int A (string p0, string p1)
		{
			if (id_a_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_a_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;Ljava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_b_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_B_Ljava_lang_String_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_B_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.FB.Opus.OpusTool __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Opus.OpusTool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.B (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.opus']/class[@name='OpusTool']/method[@name='b' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;Ljava/lang/String;)I", "GetB_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual int B (string p0, string p1)
		{
			if (id_b_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_b_Ljava_lang_String_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;Ljava/lang/String;)I"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
