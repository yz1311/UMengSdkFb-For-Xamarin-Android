using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']"
	[global::Android.Runtime.Register ("com/umeng/fb/model/UserInfo", DoNotGenerateAcw=true)]
	public partial class UserInfo : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/model/UserInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserInfo); }
		}

		protected UserInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/constructor[@name='UserInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public UserInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (UserInfo)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getAgeGroup;
#pragma warning disable 0169
		static Delegate GetGetAgeGroupHandler ()
		{
			if (cb_getAgeGroup == null)
				cb_getAgeGroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAgeGroup);
			return cb_getAgeGroup;
		}

		static int n_GetAgeGroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AgeGroup;
		}
#pragma warning restore 0169

		static Delegate cb_setAgeGroup_I;
#pragma warning disable 0169
		static Delegate GetSetAgeGroup_IHandler ()
		{
			if (cb_setAgeGroup_I == null)
				cb_setAgeGroup_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAgeGroup_I);
			return cb_setAgeGroup_I;
		}

		static void n_SetAgeGroup_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AgeGroup = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAgeGroup;
		static IntPtr id_setAgeGroup_I;
		public virtual int AgeGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='getAgeGroup' and count(parameter)=0]"
			[Register ("getAgeGroup", "()I", "GetGetAgeGroupHandler")]
			get {
				if (id_getAgeGroup == IntPtr.Zero)
					id_getAgeGroup = JNIEnv.GetMethodID (class_ref, "getAgeGroup", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAgeGroup);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAgeGroup", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='setAgeGroup' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAgeGroup", "(I)V", "GetSetAgeGroup_IHandler")]
			set {
				if (id_setAgeGroup_I == IntPtr.Zero)
					id_setAgeGroup_I = JNIEnv.GetMethodID (class_ref, "setAgeGroup", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAgeGroup_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAgeGroup", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getContact;
#pragma warning disable 0169
		static Delegate GetGetContactHandler ()
		{
			if (cb_getContact == null)
				cb_getContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContact);
			return cb_getContact;
		}

		static IntPtr n_GetContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Contact);
		}
#pragma warning restore 0169

		static Delegate cb_setContact_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetContact_Ljava_util_Map_Handler ()
		{
			if (cb_setContact_Ljava_util_Map_ == null)
				cb_setContact_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContact_Ljava_util_Map_);
			return cb_setContact_Ljava_util_Map_;
		}

		static void n_SetContact_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contact = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContact;
		static IntPtr id_setContact_Ljava_util_Map_;
		public virtual global::System.Collections.Generic.IDictionary<string, string> Contact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='getContact' and count(parameter)=0]"
			[Register ("getContact", "()Ljava/util/Map;", "GetGetContactHandler")]
			get {
				if (id_getContact == IntPtr.Zero)
					id_getContact = JNIEnv.GetMethodID (class_ref, "getContact", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getContact), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='setContact' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setContact", "(Ljava/util/Map;)V", "GetSetContact_Ljava_util_Map_Handler")]
			set {
				if (id_setContact_Ljava_util_Map_ == IntPtr.Zero)
					id_setContact_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setContact", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setContact_Ljava_util_Map_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContact", "(Ljava/util/Map;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getGender;
#pragma warning disable 0169
		static Delegate GetGetGenderHandler ()
		{
			if (cb_getGender == null)
				cb_getGender = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGender);
			return cb_getGender;
		}

		static IntPtr n_GetGender (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Gender);
		}
#pragma warning restore 0169

		static Delegate cb_setGender_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGender_Ljava_lang_String_Handler ()
		{
			if (cb_setGender_Ljava_lang_String_ == null)
				cb_setGender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGender_Ljava_lang_String_);
			return cb_setGender_Ljava_lang_String_;
		}

		static void n_SetGender_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Gender = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGender;
		static IntPtr id_setGender_Ljava_lang_String_;
		public virtual string Gender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='getGender' and count(parameter)=0]"
			[Register ("getGender", "()Ljava/lang/String;", "GetGetGenderHandler")]
			get {
				if (id_getGender == IntPtr.Zero)
					id_getGender = JNIEnv.GetMethodID (class_ref, "getGender", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getGender), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGender", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='setGender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGender", "(Ljava/lang/String;)V", "GetSetGender_Ljava_lang_String_Handler")]
			set {
				if (id_setGender_Ljava_lang_String_ == IntPtr.Zero)
					id_setGender_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGender_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGender", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getRemark;
#pragma warning disable 0169
		static Delegate GetGetRemarkHandler ()
		{
			if (cb_getRemark == null)
				cb_getRemark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemark);
			return cb_getRemark;
		}

		static IntPtr n_GetRemark (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Remark);
		}
#pragma warning restore 0169

		static Delegate cb_setRemark_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetRemark_Ljava_util_Map_Handler ()
		{
			if (cb_setRemark_Ljava_util_Map_ == null)
				cb_setRemark_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemark_Ljava_util_Map_);
			return cb_setRemark_Ljava_util_Map_;
		}

		static void n_SetRemark_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remark = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemark;
		static IntPtr id_setRemark_Ljava_util_Map_;
		public virtual global::System.Collections.Generic.IDictionary<string, string> Remark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='getRemark' and count(parameter)=0]"
			[Register ("getRemark", "()Ljava/util/Map;", "GetGetRemarkHandler")]
			get {
				if (id_getRemark == IntPtr.Zero)
					id_getRemark = JNIEnv.GetMethodID (class_ref, "getRemark", "()Ljava/util/Map;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRemark), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemark", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='setRemark' and count(parameter)=1 and parameter[1][@type='java.util.Map']]"
			[Register ("setRemark", "(Ljava/util/Map;)V", "GetSetRemark_Ljava_util_Map_Handler")]
			set {
				if (id_setRemark_Ljava_util_Map_ == IntPtr.Zero)
					id_setRemark_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setRemark", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRemark_Ljava_util_Map_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemark", "(Ljava/util/Map;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getRemarkJson;
#pragma warning disable 0169
		static Delegate GetGetRemarkJsonHandler ()
		{
			if (cb_getRemarkJson == null)
				cb_getRemarkJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemarkJson);
			return cb_getRemarkJson;
		}

		static IntPtr n_GetRemarkJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemarkJson);
		}
#pragma warning restore 0169

		static IntPtr id_getRemarkJson;
		public virtual global::Org.Json.JSONObject RemarkJson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='getRemarkJson' and count(parameter)=0]"
			[Register ("getRemarkJson", "()Lorg/json/JSONObject;", "GetGetRemarkJsonHandler")]
			get {
				if (id_getRemarkJson == IntPtr.Zero)
					id_getRemarkJson = JNIEnv.GetMethodID (class_ref, "getRemarkJson", "()Lorg/json/JSONObject;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_getRemarkJson), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemarkJson", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Model.UserInfo __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Model.UserInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.model']/class[@name='UserInfo']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public virtual global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod  (Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJson", "()Lorg/json/JSONObject;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
