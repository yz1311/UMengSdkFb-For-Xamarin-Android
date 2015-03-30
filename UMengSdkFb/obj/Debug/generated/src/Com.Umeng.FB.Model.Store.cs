using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']"
	[global::Android.Runtime.Register ("com/umeng/fb/model/Store", DoNotGenerateAcw=true)]
	public partial class Store : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/model/Store", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Store); }
		}

		protected Store (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AllConversationIds);
		}
#pragma warning restore 0169

		static IntPtr id_getAllConversationIds;
		public virtual global::System.Collections.Generic.IList<string> AllConversationIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getAllConversationIds' and count(parameter)=0]"
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

		static Delegate cb_getDeviceUUID;
#pragma warning disable 0169
		static Delegate GetGetDeviceUUIDHandler ()
		{
			if (cb_getDeviceUUID == null)
				cb_getDeviceUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceUUID);
			return cb_getDeviceUUID;
		}

		static IntPtr n_GetDeviceUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceUUID);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceUUID;
		public virtual string DeviceUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getDeviceUUID' and count(parameter)=0]"
			[Register ("getDeviceUUID", "()Ljava/lang/String;", "GetGetDeviceUUIDHandler")]
			get {
				if (id_getDeviceUUID == IntPtr.Zero)
					id_getDeviceUUID = JNIEnv.GetMethodID (class_ref, "getDeviceUUID", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeviceUUID), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isMigrated;
#pragma warning disable 0169
		static Delegate GetIsMigratedHandler ()
		{
			if (cb_isMigrated == null)
				cb_isMigrated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMigrated);
			return cb_isMigrated;
		}

		static bool n_IsMigrated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMigrated;
		}
#pragma warning restore 0169

		static IntPtr id_isMigrated;
		public virtual bool IsMigrated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='isMigrated' and count(parameter)=0]"
			[Register ("isMigrated", "()Z", "GetIsMigratedHandler")]
			get {
				if (id_isMigrated == IntPtr.Zero)
					id_isMigrated = JNIEnv.GetMethodID (class_ref, "isMigrated", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMigrated);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMigrated", "()Z"));
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static Delegate cb_setUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUid_Ljava_lang_String_Handler ()
		{
			if (cb_setUid_Ljava_lang_String_ == null)
				cb_setUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUid_Ljava_lang_String_);
			return cb_setUid_Ljava_lang_String_;
		}

		static void n_SetUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		static IntPtr id_setUid_Ljava_lang_String_;
		public virtual string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='setUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUid", "(Ljava/lang/String;)V", "GetSetUid_Ljava_lang_String_Handler")]
			set {
				if (id_setUid_Ljava_lang_String_ == IntPtr.Zero)
					id_setUid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUid", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUid_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUid", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo;
		public virtual global::Com.Umeng.FB.Model.UserInfo UserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getUserInfo' and count(parameter)=0]"
			[Register ("getUserInfo", "()Lcom/umeng/fb/model/UserInfo;", "GetGetUserInfoHandler")]
			get {
				if (id_getUserInfo == IntPtr.Zero)
					id_getUserInfo = JNIEnv.GetMethodID (class_ref, "getUserInfo", "()Lcom/umeng/fb/model/UserInfo;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (JNIEnv.CallObjectMethod  (Handle, id_getUserInfo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "()Lcom/umeng/fb/model/UserInfo;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUserInfoLastSyncAt;
#pragma warning disable 0169
		static Delegate GetGetUserInfoLastSyncAtHandler ()
		{
			if (cb_getUserInfoLastSyncAt == null)
				cb_getUserInfoLastSyncAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetUserInfoLastSyncAt);
			return cb_getUserInfoLastSyncAt;
		}

		static long n_GetUserInfoLastSyncAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserInfoLastSyncAt;
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfoLastSyncAt_J;
#pragma warning disable 0169
		static Delegate GetSetUserInfoLastSyncAt_JHandler ()
		{
			if (cb_setUserInfoLastSyncAt_J == null)
				cb_setUserInfoLastSyncAt_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetUserInfoLastSyncAt_J);
			return cb_setUserInfoLastSyncAt_J;
		}

		static void n_SetUserInfoLastSyncAt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserInfoLastSyncAt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoLastSyncAt;
		static IntPtr id_setUserInfoLastSyncAt_J;
		public virtual long UserInfoLastSyncAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getUserInfoLastSyncAt' and count(parameter)=0]"
			[Register ("getUserInfoLastSyncAt", "()J", "GetGetUserInfoLastSyncAtHandler")]
			get {
				if (id_getUserInfoLastSyncAt == IntPtr.Zero)
					id_getUserInfoLastSyncAt = JNIEnv.GetMethodID (class_ref, "getUserInfoLastSyncAt", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getUserInfoLastSyncAt);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfoLastSyncAt", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='setUserInfoLastSyncAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setUserInfoLastSyncAt", "(J)V", "GetSetUserInfoLastSyncAt_JHandler")]
			set {
				if (id_setUserInfoLastSyncAt_J == IntPtr.Zero)
					id_setUserInfoLastSyncAt_J = JNIEnv.GetMethodID (class_ref, "setUserInfoLastSyncAt", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserInfoLastSyncAt_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfoLastSyncAt", "(J)V"), new JValue (value));
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
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserInfoLastUpdateAt;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoLastUpdateAt;
		public virtual long UserInfoLastUpdateAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getUserInfoLastUpdateAt' and count(parameter)=0]"
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

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/model/Store;", "")]
		public static global::Com.Umeng.FB.Model.Store GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/model/Store;");
			global::Com.Umeng.FB.Model.Store __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_migrateData;
#pragma warning disable 0169
		static Delegate GetMigrateDataHandler ()
		{
			if (cb_migrateData == null)
				cb_migrateData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MigrateData);
			return cb_migrateData;
		}

		static void n_MigrateData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MigrateData ();
		}
#pragma warning restore 0169

		static IntPtr id_migrateData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='migrateData' and count(parameter)=0]"
		[Register ("migrateData", "()V", "GetMigrateDataHandler")]
		public virtual void MigrateData ()
		{
			if (id_migrateData == IntPtr.Zero)
				id_migrateData = JNIEnv.GetMethodID (class_ref, "migrateData", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_migrateData);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "migrateData", "()V"));
		}

		static Delegate cb_removeConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveConversation_Ljava_lang_String_Handler ()
		{
			if (cb_removeConversation_Ljava_lang_String_ == null)
				cb_removeConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveConversation_Ljava_lang_String_);
			return cb_removeConversation_Ljava_lang_String_;
		}

		static void n_RemoveConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='removeConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeConversation", "(Ljava/lang/String;)V", "GetRemoveConversation_Ljava_lang_String_Handler")]
		public virtual void RemoveConversation (string p0)
		{
			if (id_removeConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_removeConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeConversation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeConversation_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeConversation", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_saveUserInfo_Lcom_umeng_fb_model_UserInfo_;
#pragma warning disable 0169
		static Delegate GetSaveUserInfo_Lcom_umeng_fb_model_UserInfo_Handler ()
		{
			if (cb_saveUserInfo_Lcom_umeng_fb_model_UserInfo_ == null)
				cb_saveUserInfo_Lcom_umeng_fb_model_UserInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveUserInfo_Lcom_umeng_fb_model_UserInfo_);
			return cb_saveUserInfo_Lcom_umeng_fb_model_UserInfo_;
		}

		static void n_SaveUserInfo_Lcom_umeng_fb_model_UserInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.Store __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.Store> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.FB.Model.UserInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveUserInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveUserInfo_Lcom_umeng_fb_model_UserInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='Store']/method[@name='saveUserInfo' and count(parameter)=1 and parameter[1][@type='com.umeng.fb.model.UserInfo']]"
		[Register ("saveUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V", "GetSaveUserInfo_Lcom_umeng_fb_model_UserInfo_Handler")]
		public virtual void SaveUserInfo (global::Com.Umeng.FB.Model.UserInfo p0)
		{
			if (id_saveUserInfo_Lcom_umeng_fb_model_UserInfo_ == IntPtr.Zero)
				id_saveUserInfo_Lcom_umeng_fb_model_UserInfo_ = JNIEnv.GetMethodID (class_ref, "saveUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_saveUserInfo_Lcom_umeng_fb_model_UserInfo_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveUserInfo", "(Lcom/umeng/fb/model/UserInfo;)V"), new JValue (p0));
		}

	}
}
