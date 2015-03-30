using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']"
	[global::Android.Runtime.Register ("com/umeng/fb/util/Res", DoNotGenerateAcw=true)]
	public partial class Res : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/util/Res", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Res); }
		}

		protected Res (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetA_Ljava_lang_String_Handler ()
		{
			if (cb_a_Ljava_lang_String_ == null)
				cb_a_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_A_Ljava_lang_String_);
			return cb_a_Ljava_lang_String_;
		}

		static int n_A_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)I", "GetA_Ljava_lang_String_Handler")]
		public virtual int A (string p0)
		{
			if (id_a_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "a", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_a_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_b_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetB_Ljava_lang_String_Handler ()
		{
			if (cb_b_Ljava_lang_String_ == null)
				cb_b_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_B_Ljava_lang_String_);
			return cb_b_Ljava_lang_String_;
		}

		static int n_B_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.B (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_b_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='b' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("b", "(Ljava/lang/String;)I", "GetB_Ljava_lang_String_Handler")]
		public virtual int B (string p0)
		{
			if (id_b_Ljava_lang_String_ == IntPtr.Zero)
				id_b_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "b", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_b_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "b", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_c_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetC_Ljava_lang_String_Handler ()
		{
			if (cb_c_Ljava_lang_String_ == null)
				cb_c_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_C_Ljava_lang_String_);
			return cb_c_Ljava_lang_String_;
		}

		static int n_C_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.C (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_c_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='c' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("c", "(Ljava/lang/String;)I", "GetC_Ljava_lang_String_Handler")]
		public virtual int C (string p0)
		{
			if (id_c_Ljava_lang_String_ == IntPtr.Zero)
				id_c_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "c", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_c_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "c", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_d_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_D_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_;
		}

		static int n_D_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.D (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)I", "GetD_Ljava_lang_String_Handler")]
		public virtual int D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_d_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static int n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.E (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)I", "GetE_Ljava_lang_String_Handler")]
		public virtual int E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_e_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_f_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetF_Ljava_lang_String_Handler ()
		{
			if (cb_f_Ljava_lang_String_ == null)
				cb_f_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_F_Ljava_lang_String_);
			return cb_f_Ljava_lang_String_;
		}

		static int n_F_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.F (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_f_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='f' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("f", "(Ljava/lang/String;)I", "GetF_Ljava_lang_String_Handler")]
		public virtual int F (string p0)
		{
			if (id_f_Ljava_lang_String_ == IntPtr.Zero)
				id_f_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "f", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_f_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "f", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_g_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetG_Ljava_lang_String_Handler ()
		{
			if (cb_g_Ljava_lang_String_ == null)
				cb_g_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_G_Ljava_lang_String_);
			return cb_g_Ljava_lang_String_;
		}

		static int n_G_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.G (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_g_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='g' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("g", "(Ljava/lang/String;)I", "GetG_Ljava_lang_String_Handler")]
		public virtual int G (string p0)
		{
			if (id_g_Ljava_lang_String_ == IntPtr.Zero)
				id_g_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "g", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_g_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "g", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/util/Res;", "")]
		public static global::Com.Umeng.FB.Util.Res GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/util/Res;");
			global::Com.Umeng.FB.Util.Res __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_h_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetH_Ljava_lang_String_Handler ()
		{
			if (cb_h_Ljava_lang_String_ == null)
				cb_h_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_H_Ljava_lang_String_);
			return cb_h_Ljava_lang_String_;
		}

		static int n_H_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Util.Res __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Util.Res> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.H (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_h_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='h' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("h", "(Ljava/lang/String;)I", "GetH_Ljava_lang_String_Handler")]
		public virtual int H (string p0)
		{
			if (id_h_Ljava_lang_String_ == IntPtr.Zero)
				id_h_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "h", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_h_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_setPackageName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.util']/class[@name='Res']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPackageName", "(Ljava/lang/String;)V", "")]
		public static void SetPackageName (string p0)
		{
			if (id_setPackageName_Ljava_lang_String_ == IntPtr.Zero)
				id_setPackageName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setPackageName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setPackageName_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
