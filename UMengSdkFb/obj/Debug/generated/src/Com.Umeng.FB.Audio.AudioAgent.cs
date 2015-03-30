using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.FB.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']"
	[global::Android.Runtime.Register ("com/umeng/fb/audio/AudioAgent", DoNotGenerateAcw=true)]
	public partial class AudioAgent : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='a']"
		[Register ("a")]
		protected const int A = (int) 16000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='b']"
		[Register ("b")]
		protected const int B = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='c']"
		[Register ("c")]
		protected const int C = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='d']"
		[Register ("d")]
		protected const int D = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='e']"
		[Register ("e")]
		protected const int E = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/field[@name='f']"
		[Register ("f")]
		protected const int F = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/fb/audio/AudioAgent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioAgent); }
		}

		protected AudioAgent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAudioDuration;
#pragma warning disable 0169
		static Delegate GetGetAudioDurationHandler ()
		{
			if (cb_getAudioDuration == null)
				cb_getAudioDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAudioDuration);
			return cb_getAudioDuration;
		}

		static float n_GetAudioDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioDuration;
		public virtual float AudioDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='getAudioDuration' and count(parameter)=0]"
			[Register ("getAudioDuration", "()F", "GetGetAudioDurationHandler")]
			get {
				if (id_getAudioDuration == IntPtr.Zero)
					id_getAudioDuration = JNIEnv.GetMethodID (class_ref, "getAudioDuration", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getAudioDuration);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioDuration", "()F"));
			}
		}

		static Delegate cb_getAudioInitStatus;
#pragma warning disable 0169
		static Delegate GetGetAudioInitStatusHandler ()
		{
			if (cb_getAudioInitStatus == null)
				cb_getAudioInitStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAudioInitStatus);
			return cb_getAudioInitStatus;
		}

		static bool n_GetAudioInitStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioInitStatus;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioInitStatus;
		public virtual bool AudioInitStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='getAudioInitStatus' and count(parameter)=0]"
			[Register ("getAudioInitStatus", "()Z", "GetGetAudioInitStatusHandler")]
			get {
				if (id_getAudioInitStatus == IntPtr.Zero)
					id_getAudioInitStatus = JNIEnv.GetMethodID (class_ref, "getAudioInitStatus", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getAudioInitStatus);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioInitStatus", "()Z"));
			}
		}

		static Delegate cb_getPlayStatus;
#pragma warning disable 0169
		static Delegate GetGetPlayStatusHandler ()
		{
			if (cb_getPlayStatus == null)
				cb_getPlayStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPlayStatus);
			return cb_getPlayStatus;
		}

		static bool n_GetPlayStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PlayStatus;
		}
#pragma warning restore 0169

		static IntPtr id_getPlayStatus;
		public virtual bool PlayStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='getPlayStatus' and count(parameter)=0]"
			[Register ("getPlayStatus", "()Z", "GetGetPlayStatusHandler")]
			get {
				if (id_getPlayStatus == IntPtr.Zero)
					id_getPlayStatus = JNIEnv.GetMethodID (class_ref, "getPlayStatus", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getPlayStatus);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayStatus", "()Z"));
			}
		}

		static Delegate cb_getRecordStatus;
#pragma warning disable 0169
		static Delegate GetGetRecordStatusHandler ()
		{
			if (cb_getRecordStatus == null)
				cb_getRecordStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRecordStatus);
			return cb_getRecordStatus;
		}

		static bool n_GetRecordStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordStatus;
		}
#pragma warning restore 0169

		static IntPtr id_getRecordStatus;
		public virtual bool RecordStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='getRecordStatus' and count(parameter)=0]"
			[Register ("getRecordStatus", "()Z", "GetGetRecordStatusHandler")]
			get {
				if (id_getRecordStatus == IntPtr.Zero)
					id_getRecordStatus = JNIEnv.GetMethodID (class_ref, "getRecordStatus", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getRecordStatus);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordStatus", "()Z"));
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/audio/AudioAgent;", "")]
		public static global::Com.Umeng.FB.Audio.AudioAgent GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/umeng/fb/audio/AudioAgent;");
			global::Com.Umeng.FB.Audio.AudioAgent __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_recordShortStop;
#pragma warning disable 0169
		static Delegate GetRecordShortStopHandler ()
		{
			if (cb_recordShortStop == null)
				cb_recordShortStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecordShortStop);
			return cb_recordShortStop;
		}

		static void n_RecordShortStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordShortStop ();
		}
#pragma warning restore 0169

		static IntPtr id_recordShortStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='recordShortStop' and count(parameter)=0]"
		[Register ("recordShortStop", "()V", "GetRecordShortStopHandler")]
		public virtual void RecordShortStop ()
		{
			if (id_recordShortStop == IntPtr.Zero)
				id_recordShortStop = JNIEnv.GetMethodID (class_ref, "recordShortStop", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_recordShortStop);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordShortStop", "()V"));
		}

		static Delegate cb_recordStart_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRecordStart_Ljava_lang_String_Handler ()
		{
			if (cb_recordStart_Ljava_lang_String_ == null)
				cb_recordStart_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RecordStart_Ljava_lang_String_);
			return cb_recordStart_Ljava_lang_String_;
		}

		static bool n_RecordStart_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RecordStart (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_recordStart_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='recordStart' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("recordStart", "(Ljava/lang/String;)Z", "GetRecordStart_Ljava_lang_String_Handler")]
		public virtual bool RecordStart (string p0)
		{
			if (id_recordStart_Ljava_lang_String_ == IntPtr.Zero)
				id_recordStart_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "recordStart", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_recordStart_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordStart", "(Ljava/lang/String;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_recordStop;
#pragma warning disable 0169
		static Delegate GetRecordStopHandler ()
		{
			if (cb_recordStop == null)
				cb_recordStop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RecordStop);
			return cb_recordStop;
		}

		static int n_RecordStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordStop ();
		}
#pragma warning restore 0169

		static IntPtr id_recordStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='recordStop' and count(parameter)=0]"
		[Register ("recordStop", "()I", "GetRecordStopHandler")]
		public virtual int RecordStop ()
		{
			if (id_recordStop == IntPtr.Zero)
				id_recordStop = JNIEnv.GetMethodID (class_ref, "recordStop", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_recordStop);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recordStop", "()I"));
		}

		static Delegate cb_startPlay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartPlay_Ljava_lang_String_Handler ()
		{
			if (cb_startPlay_Ljava_lang_String_ == null)
				cb_startPlay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartPlay_Ljava_lang_String_);
			return cb_startPlay_Ljava_lang_String_;
		}

		static void n_StartPlay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartPlay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startPlay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='startPlay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startPlay", "(Ljava/lang/String;)V", "GetStartPlay_Ljava_lang_String_Handler")]
		public virtual void StartPlay (string p0)
		{
			if (id_startPlay_Ljava_lang_String_ == IntPtr.Zero)
				id_startPlay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startPlay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startPlay_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startPlay", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_stopPlayer;
#pragma warning disable 0169
		static Delegate GetStopPlayerHandler ()
		{
			if (cb_stopPlayer == null)
				cb_stopPlayer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlayer);
			return cb_stopPlayer;
		}

		static void n_StopPlayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.FB.Audio.AudioAgent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.FB.Audio.AudioAgent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlayer ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPlayer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.fb.audio']/class[@name='AudioAgent']/method[@name='stopPlayer' and count(parameter)=0]"
		[Register ("stopPlayer", "()V", "GetStopPlayerHandler")]
		public virtual void StopPlayer ()
		{
			if (id_stopPlayer == IntPtr.Zero)
				id_stopPlayer = JNIEnv.GetMethodID (class_ref, "stopPlayer", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopPlayer);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPlayer", "()V"));
		}

	}
}
