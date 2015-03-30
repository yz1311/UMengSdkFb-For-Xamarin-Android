using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']"
	[global::Android.Runtime.Register ("com/umeng/fb/push/FeedbackPush", DoNotGenerateAcw=true)]
	public partial class FeedbackPush : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/push/FeedbackPush", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeedbackPush); }
		}

		protected FeedbackPush (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_clearPushInfo;
#pragma warning disable 0169
		static Delegate GetClearPushInfoHandler ()
		{
			if (cb_clearPushInfo == null)
				cb_clearPushInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPushInfo);
			return cb_clearPushInfo;
		}

		static void n_ClearPushInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPushInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPushInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='clearPushInfo' and count(parameter)=0]"
		[Register ("clearPushInfo", "()V", "GetClearPushInfoHandler")]
		public virtual void ClearPushInfo ()
		{
			if (id_clearPushInfo == IntPtr.Zero)
				id_clearPushInfo = JNIEnv.GetMethodID (class_ref, "clearPushInfo", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearPushInfo);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPushInfo", "()V"));
		}

		static Delegate cb_dealFBMessage_Lcom_umeng_fb_push_FBMessage_;
#pragma warning disable 0169
		static Delegate GetDealFBMessage_Lcom_umeng_fb_push_FBMessage_Handler ()
		{
			if (cb_dealFBMessage_Lcom_umeng_fb_push_FBMessage_ == null)
				cb_dealFBMessage_Lcom_umeng_fb_push_FBMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DealFBMessage_Lcom_umeng_fb_push_FBMessage_);
			return cb_dealFBMessage_Lcom_umeng_fb_push_FBMessage_;
		}

		static bool n_DealFBMessage_Lcom_umeng_fb_push_FBMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.FB.Push.FBMessage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FBMessage> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DealFBMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dealFBMessage_Lcom_umeng_fb_push_FBMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='dealFBMessage' and count(parameter)=1 and parameter[1][@type='com.umeng.fb.push.FBMessage']]"
		[Register ("dealFBMessage", "(Lcom/umeng/fb/push/FBMessage;)Z", "GetDealFBMessage_Lcom_umeng_fb_push_FBMessage_Handler")]
		public virtual bool DealFBMessage (global::Com.Umeng.FB.Push.FBMessage p0)
		{
			if (id_dealFBMessage_Lcom_umeng_fb_push_FBMessage_ == IntPtr.Zero)
				id_dealFBMessage_Lcom_umeng_fb_push_FBMessage_ = JNIEnv.GetMethodID (class_ref, "dealFBMessage", "(Lcom/umeng/fb/push/FBMessage;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_dealFBMessage_Lcom_umeng_fb_push_FBMessage_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dealFBMessage", "(Lcom/umeng/fb/push/FBMessage;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
		}

		static Delegate cb_enable;
#pragma warning disable 0169
		static Delegate GetEnableHandler ()
		{
			if (cb_enable == null)
				cb_enable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Enable);
			return cb_enable;
		}

		static void n_Enable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable ();
		}
#pragma warning restore 0169

		static IntPtr id_enable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='enable' and count(parameter)=0]"
		[Register ("enable", "()V", "GetEnableHandler")]
		public virtual void Enable ()
		{
			if (id_enable == IntPtr.Zero)
				id_enable = JNIEnv.GetMethodID (class_ref, "enable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "()V"));
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/push/FeedbackPush;", "")]
		public static global::Com.Umeng.FB.Push.FeedbackPush GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/push/FeedbackPush;");
			global::Com.Umeng.FB.Push.FeedbackPush __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_init_Z;
#pragma warning disable 0169
		static Delegate GetInit_ZHandler ()
		{
			if (cb_init_Z == null)
				cb_init_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Init_Z);
			return cb_init_Z;
		}

		static void n_Init_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		static IntPtr id_init_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='init' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("init", "(Z)V", "GetInit_ZHandler")]
		public virtual void Init (bool p0)
		{
			if (id_init_Z == IntPtr.Zero)
				id_init_Z = JNIEnv.GetMethodID (class_ref, "init", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_init_Ljava_lang_Class_Z;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_lang_Class_ZHandler ()
		{
			if (cb_init_Ljava_lang_Class_Z == null)
				cb_init_Ljava_lang_Class_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_Init_Ljava_lang_Class_Z);
			return cb_init_Ljava_lang_Class_Z;
		}

		static void n_Init_Ljava_lang_Class_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_init_Ljava_lang_Class_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='init' and count(parameter)=2 and parameter[1][@type='java.lang.Class'] and parameter[2][@type='boolean']]"
		[Register ("init", "(Ljava/lang/Class;Z)V", "GetInit_Ljava_lang_Class_ZHandler")]
		public virtual void Init (global::Java.Lang.Class p0, bool p1)
		{
			if (id_init_Ljava_lang_Class_Z == IntPtr.Zero)
				id_init_Ljava_lang_Class_Z = JNIEnv.GetMethodID (class_ref, "init", "(Ljava/lang/Class;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init_Ljava_lang_Class_Z, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Ljava/lang/Class;Z)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onFBMessage_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnFBMessage_Landroid_content_Intent_Handler ()
		{
			if (cb_onFBMessage_Landroid_content_Intent_ == null)
				cb_onFBMessage_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnFBMessage_Landroid_content_Intent_);
			return cb_onFBMessage_Landroid_content_Intent_;
		}

		static bool n_OnFBMessage_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnFBMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onFBMessage_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='onFBMessage' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onFBMessage", "(Landroid/content/Intent;)Z", "GetOnFBMessage_Landroid_content_Intent_Handler")]
		public virtual bool OnFBMessage (global::Android.Content.Intent p0)
		{
			if (id_onFBMessage_Landroid_content_Intent_ == IntPtr.Zero)
				id_onFBMessage_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onFBMessage", "(Landroid/content/Intent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onFBMessage_Landroid_content_Intent_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFBMessage", "(Landroid/content/Intent;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_setConversationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetConversationId_Ljava_lang_String_Handler ()
		{
			if (cb_setConversationId_Ljava_lang_String_ == null)
				cb_setConversationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationId_Ljava_lang_String_);
			return cb_setConversationId_Ljava_lang_String_;
		}

		static void n_SetConversationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConversationId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setConversationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setConversationId", "(Ljava/lang/String;)V", "GetSetConversationId_Ljava_lang_String_Handler")]
		public virtual void SetConversationId (string p0)
		{
			if (id_setConversationId_Ljava_lang_String_ == IntPtr.Zero)
				id_setConversationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setConversationId_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationId", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setFbFragmentTag_Z;
#pragma warning disable 0169
		static Delegate GetSetFbFragmentTag_ZHandler ()
		{
			if (cb_setFbFragmentTag_Z == null)
				cb_setFbFragmentTag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFbFragmentTag_Z);
			return cb_setFbFragmentTag_Z;
		}

		static void n_SetFbFragmentTag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Umeng.FB.Push.FeedbackPush __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Push.FeedbackPush> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFbFragmentTag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFbFragmentTag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.push']/class[@name='FeedbackPush']/method[@name='setFbFragmentTag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFbFragmentTag", "(Z)V", "GetSetFbFragmentTag_ZHandler")]
		public virtual void SetFbFragmentTag (bool p0)
		{
			if (id_setFbFragmentTag_Z == IntPtr.Zero)
				id_setFbFragmentTag_Z = JNIEnv.GetMethodID (class_ref, "setFbFragmentTag", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFbFragmentTag_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFbFragmentTag", "(Z)V"), new JValue (p0));
		}

	}
}
