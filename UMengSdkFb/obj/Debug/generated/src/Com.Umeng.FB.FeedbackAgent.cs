using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']"
	[global::Android.Runtime.Register ("com/umeng/fb/FeedbackAgent", DoNotGenerateAcw=true)]
	public partial class FeedbackAgent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/FeedbackAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FeedbackAgent); }
		}

		protected FeedbackAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/constructor[@name='FeedbackAgent' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public FeedbackAgent (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FeedbackAgent)) {
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

		static Delegate cb_getAllConversationIds;
#pragma warning disable 0169
		static Delegate GetGetAllConversationIdsHandler ()
		{
			if (cb_getAllConversationIds == null)
				cb_getAllConversationIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllConversationIds);
			return cb_getAllConversationIds;
		}

		static IntPtr n_GetAllConversationIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AllConversationIds);
		}
#pragma warning restore 0169

		static IntPtr id_getAllConversationIds;
		public virtual global::System.Collections.Generic.IList<string> AllConversationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='getAllConversationIds' and count(parameter)=0]"
			[Register ("getAllConversationIds", "()Ljava/util/List;", "GetGetAllConversationIdsHandler")]
			get {
				if (id_getAllConversationIds == IntPtr.Zero)
					id_getAllConversationIds = JNIEnv.GetMethodID (class_ref, "getAllConversationIds", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getAllConversationIds), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllConversationIds", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserInfo;
#pragma warning disable 0169
		static Delegate GetGetUserInfoHandler ()
		{
			if (cb_getUserInfo == null)
				cb_getUserInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfo);
			return cb_getUserInfo;
		}

		static IntPtr n_GetUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfo_Lcom_umeng_fb_model_UserInfo_;
#pragma warning disable 0169
		static Delegate GetSetUserInfo_Lcom_umeng_fb_model_UserInfo_Handler ()
		{
			if (cb_setUserInfo_Lcom_umeng_fb_model_UserInfo_ == null)
				cb_setUserInfo_Lcom_umeng_fb_model_UserInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserInfo_Lcom_umeng_fb_model_UserInfo_);
			return cb_setUserInfo_Lcom_umeng_fb_model_UserInfo_;
		}

		static void n_SetUserInfo_Lcom_umeng_fb_model_UserInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.FB.Model.UserInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserInfo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo;
		static IntPtr id_setUserInfo_Lcom_umeng_fb_model_UserInfo_;
		public virtual global::Com.Umeng.FB.Model.UserInfo UserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='getUserInfo' and count(parameter)=0]"
			[Register ("getUserInfo", "()Lcom/umeng/fb/model/UserInfo;", "GetGetUserInfoHandler")]
			get {
				if (id_getUserInfo == IntPtr.Zero)
					id_getUserInfo = JNIEnv.GetMethodID (class_ref, "getUserInfo", "()Lcom/umeng/fb/model/UserInfo;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (JNIEnv.CallObjectMethod  (Handle, id_getUserInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "()Lcom/umeng/fb/model/UserInfo;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='setUserInfo' and count(parameter)=1 and parameter[1][@type='com.umeng.fb.model.UserInfo']]"
			[Register ("setUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V", "GetSetUserInfo_Lcom_umeng_fb_model_UserInfo_Handler")]
			set {
				if (id_setUserInfo_Lcom_umeng_fb_model_UserInfo_ == IntPtr.Zero)
					id_setUserInfo_Lcom_umeng_fb_model_UserInfo_ = JNIEnv.GetMethodID (class_ref, "setUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserInfo_Lcom_umeng_fb_model_UserInfo_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V"), new JValue (value));
			}
		}

		static Delegate cb_getUserInfoLastUpdateAt;
#pragma warning disable 0169
		static Delegate GetGetUserInfoLastUpdateAtHandler ()
		{
			if (cb_getUserInfoLastUpdateAt == null)
				cb_getUserInfoLastUpdateAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetUserInfoLastUpdateAt);
			return cb_getUserInfoLastUpdateAt;
		}

		static long n_GetUserInfoLastUpdateAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserInfoLastUpdateAt;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoLastUpdateAt;
		public virtual long UserInfoLastUpdateAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='getUserInfoLastUpdateAt' and count(parameter)=0]"
			[Register ("getUserInfoLastUpdateAt", "()J", "GetGetUserInfoLastUpdateAtHandler")]
			get {
				if (id_getUserInfoLastUpdateAt == IntPtr.Zero)
					id_getUserInfoLastUpdateAt = JNIEnv.GetMethodID (class_ref, "getUserInfoLastUpdateAt", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getUserInfoLastUpdateAt);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfoLastUpdateAt", "()J"));
			}
		}

		static Delegate cb_closeAudioFeedback;
#pragma warning disable 0169
		static Delegate GetCloseAudioFeedbackHandler ()
		{
			if (cb_closeAudioFeedback == null)
				cb_closeAudioFeedback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseAudioFeedback);
			return cb_closeAudioFeedback;
		}

		static void n_CloseAudioFeedback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseAudioFeedback ();
		}
#pragma warning restore 0169

		static IntPtr id_closeAudioFeedback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='closeAudioFeedback' and count(parameter)=0]"
		[Register ("closeAudioFeedback", "()V", "GetCloseAudioFeedbackHandler")]
		public virtual void CloseAudioFeedback ()
		{
			if (id_closeAudioFeedback == IntPtr.Zero)
				id_closeAudioFeedback = JNIEnv.GetMethodID (class_ref, "closeAudioFeedback", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeAudioFeedback);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeAudioFeedback", "()V"));
		}

		static Delegate cb_closeFeedbackPush;
#pragma warning disable 0169
		static Delegate GetCloseFeedbackPushHandler ()
		{
			if (cb_closeFeedbackPush == null)
				cb_closeFeedbackPush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseFeedbackPush);
			return cb_closeFeedbackPush;
		}

		static void n_CloseFeedbackPush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseFeedbackPush ();
		}
#pragma warning restore 0169

		static IntPtr id_closeFeedbackPush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='closeFeedbackPush' and count(parameter)=0]"
		[Register ("closeFeedbackPush", "()V", "GetCloseFeedbackPushHandler")]
		public virtual void CloseFeedbackPush ()
		{
			if (id_closeFeedbackPush == IntPtr.Zero)
				id_closeFeedbackPush = JNIEnv.GetMethodID (class_ref, "closeFeedbackPush", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_closeFeedbackPush);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "closeFeedbackPush", "()V"));
		}

		static Delegate cb_openAudioFeedback;
#pragma warning disable 0169
		static Delegate GetOpenAudioFeedbackHandler ()
		{
			if (cb_openAudioFeedback == null)
				cb_openAudioFeedback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OpenAudioFeedback);
			return cb_openAudioFeedback;
		}

		static void n_OpenAudioFeedback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenAudioFeedback ();
		}
#pragma warning restore 0169

		static IntPtr id_openAudioFeedback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='openAudioFeedback' and count(parameter)=0]"
		[Register ("openAudioFeedback", "()V", "GetOpenAudioFeedbackHandler")]
		public virtual void OpenAudioFeedback ()
		{
			if (id_openAudioFeedback == IntPtr.Zero)
				id_openAudioFeedback = JNIEnv.GetMethodID (class_ref, "openAudioFeedback", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openAudioFeedback);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openAudioFeedback", "()V"));
		}

		static Delegate cb_openFeedbackPush;
#pragma warning disable 0169
		static Delegate GetOpenFeedbackPushHandler ()
		{
			if (cb_openFeedbackPush == null)
				cb_openFeedbackPush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OpenFeedbackPush);
			return cb_openFeedbackPush;
		}

		static void n_OpenFeedbackPush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OpenFeedbackPush ();
		}
#pragma warning restore 0169

		static IntPtr id_openFeedbackPush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='openFeedbackPush' and count(parameter)=0]"
		[Register ("openFeedbackPush", "()V", "GetOpenFeedbackPushHandler")]
		public virtual void OpenFeedbackPush ()
		{
			if (id_openFeedbackPush == IntPtr.Zero)
				id_openFeedbackPush = JNIEnv.GetMethodID (class_ref, "openFeedbackPush", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_openFeedbackPush);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openFeedbackPush", "()V"));
		}

		static Delegate cb_removeWelcomeInfo;
#pragma warning disable 0169
		static Delegate GetRemoveWelcomeInfoHandler ()
		{
			if (cb_removeWelcomeInfo == null)
				cb_removeWelcomeInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveWelcomeInfo);
			return cb_removeWelcomeInfo;
		}

		static void n_RemoveWelcomeInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveWelcomeInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_removeWelcomeInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='removeWelcomeInfo' and count(parameter)=0]"
		[Register ("removeWelcomeInfo", "()V", "GetRemoveWelcomeInfoHandler")]
		public virtual void RemoveWelcomeInfo ()
		{
			if (id_removeWelcomeInfo == IntPtr.Zero)
				id_removeWelcomeInfo = JNIEnv.GetMethodID (class_ref, "removeWelcomeInfo", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeWelcomeInfo);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeWelcomeInfo", "()V"));
		}

		static IntPtr id_setDebug_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "")]
		public static void SetDebug (bool p0)
		{
			if (id_setDebug_Z == IntPtr.Zero)
				id_setDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebug", "(Z)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebug_Z, new JValue (p0));
		}

		static Delegate cb_setWelcomeInfo;
#pragma warning disable 0169
		static Delegate GetSetWelcomeInfoHandler ()
		{
			if (cb_setWelcomeInfo == null)
				cb_setWelcomeInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetWelcomeInfo);
			return cb_setWelcomeInfo;
		}

		static void n_SetWelcomeInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetWelcomeInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_setWelcomeInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='setWelcomeInfo' and count(parameter)=0]"
		[Register ("setWelcomeInfo", "()V", "GetSetWelcomeInfoHandler")]
		public virtual void SetWelcomeInfo ()
		{
			if (id_setWelcomeInfo == IntPtr.Zero)
				id_setWelcomeInfo = JNIEnv.GetMethodID (class_ref, "setWelcomeInfo", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWelcomeInfo);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWelcomeInfo", "()V"));
		}

		static Delegate cb_setWelcomeInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetWelcomeInfo_Ljava_lang_String_Handler ()
		{
			if (cb_setWelcomeInfo_Ljava_lang_String_ == null)
				cb_setWelcomeInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWelcomeInfo_Ljava_lang_String_);
			return cb_setWelcomeInfo_Ljava_lang_String_;
		}

		static void n_SetWelcomeInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWelcomeInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWelcomeInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='setWelcomeInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setWelcomeInfo", "(Ljava/lang/String;)V", "GetSetWelcomeInfo_Ljava_lang_String_Handler")]
		public virtual void SetWelcomeInfo (string p0)
		{
			if (id_setWelcomeInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_setWelcomeInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWelcomeInfo", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setWelcomeInfo_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWelcomeInfo", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_startFeedbackActivity;
#pragma warning disable 0169
		static Delegate GetStartFeedbackActivityHandler ()
		{
			if (cb_startFeedbackActivity == null)
				cb_startFeedbackActivity = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartFeedbackActivity);
			return cb_startFeedbackActivity;
		}

		static void n_StartFeedbackActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartFeedbackActivity ();
		}
#pragma warning restore 0169

		static IntPtr id_startFeedbackActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='startFeedbackActivity' and count(parameter)=0]"
		[Register ("startFeedbackActivity", "()V", "GetStartFeedbackActivityHandler")]
		public virtual void StartFeedbackActivity ()
		{
			if (id_startFeedbackActivity == IntPtr.Zero)
				id_startFeedbackActivity = JNIEnv.GetMethodID (class_ref, "startFeedbackActivity", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startFeedbackActivity);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startFeedbackActivity", "()V"));
		}

		static Delegate cb_sync;
#pragma warning disable 0169
		static Delegate GetSyncHandler ()
		{
			if (cb_sync == null)
				cb_sync = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Sync);
			return cb_sync;
		}

		static void n_Sync (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sync ();
		}
#pragma warning restore 0169

		static IntPtr id_sync;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='sync' and count(parameter)=0]"
		[Register ("sync", "()V", "GetSyncHandler")]
		public virtual void Sync ()
		{
			if (id_sync == IntPtr.Zero)
				id_sync = JNIEnv.GetMethodID (class_ref, "sync", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_sync);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sync", "()V"));
		}

		static Delegate cb_updateUserInfo;
#pragma warning disable 0169
		static Delegate GetUpdateUserInfoHandler ()
		{
			if (cb_updateUserInfo == null)
				cb_updateUserInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UpdateUserInfo);
			return cb_updateUserInfo;
		}

		static bool n_UpdateUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.FeedbackAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.FeedbackAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateUserInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_updateUserInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb']/class[@name='FeedbackAgent']/method[@name='updateUserInfo' and count(parameter)=0]"
		[Register ("updateUserInfo", "()Z", "GetUpdateUserInfoHandler")]
		public virtual bool UpdateUserInfo ()
		{
			if (id_updateUserInfo == IntPtr.Zero)
				id_updateUserInfo = JNIEnv.GetMethodID (class_ref, "updateUserInfo", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_updateUserInfo);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserInfo", "()Z"));
		}

	}
}
