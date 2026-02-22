using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class AudioSettings : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000039D8 File Offset: 0x00001BD8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "OnAudioConfigurationChanged");
			AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100663297);
			AudioSettings.GetSpeakerModeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpeakerModeDelegate>("UnityEngine.AudioSettings::GetSpeakerMode");
			AudioSettings.GetSampleRateDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSampleRateDelegate>("UnityEngine.AudioSettings::GetSampleRate");
			AudioSettings.get_driverCapabilitiesDelegateField = IL2CPP.ResolveICall<AudioSettings.get_driverCapabilitiesDelegate>("UnityEngine.AudioSettings::get_driverCapabilities");
			AudioSettings.get_profilerCaptureFlagsDelegateField = IL2CPP.ResolveICall<AudioSettings.get_profilerCaptureFlagsDelegate>("UnityEngine.AudioSettings::get_profilerCaptureFlags");
			AudioSettings.get_dspTimeDelegateField = IL2CPP.ResolveICall<AudioSettings.get_dspTimeDelegate>("UnityEngine.AudioSettings::get_dspTime");
			AudioSettings.GetDSPBufferSizeDelegateField = IL2CPP.ResolveICall<AudioSettings.GetDSPBufferSizeDelegate>("UnityEngine.AudioSettings::GetDSPBufferSize");
			AudioSettings.GetSpatializerPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetSpatializerPluginNameDelegate>("UnityEngine.AudioSettings::GetSpatializerPluginName");
			AudioSettings.get_unityAudioDisabledDelegateField = IL2CPP.ResolveICall<AudioSettings.get_unityAudioDisabledDelegate>("UnityEngine.AudioSettings::get_unityAudioDisabled");
			AudioSettings.GetAmbisonicDecoderPluginNameDelegateField = IL2CPP.ResolveICall<AudioSettings.GetAmbisonicDecoderPluginNameDelegate>("UnityEngine.AudioSettings::GetAmbisonicDecoderPluginName");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90073, XrefRangeEnd = 90079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceWasChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public AudioSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00003AEC File Offset: 0x00001CEC
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings.AudioConfigurationChangeHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSettings.NativeFieldInfoPtr_OnAudioConfigurationChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000206B File Offset: 0x0000026B
		public static AudioSpeakerMode GetSpeakerMode()
		{
			return AudioSettings.GetSpeakerModeDelegateField();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002077 File Offset: 0x00000277
		public static int GetSampleRate()
		{
			return AudioSettings.GetSampleRateDelegateField();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002083 File Offset: 0x00000283
		public static AudioSpeakerMode driverCapabilities
		{
			get
			{
				return AudioSettings.get_driverCapabilitiesDelegateField();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00003B14 File Offset: 0x00001D14
		// (set) Token: 0x0600000A RID: 10 RVA: 0x0000208F File Offset: 0x0000028F
		public static AudioSpeakerMode speakerMode
		{
			get
			{
				return AudioSettings.GetSpeakerMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000209C File Offset: 0x0000029C
		public static int profilerCaptureFlags
		{
			get
			{
				return AudioSettings.get_profilerCaptureFlagsDelegateField();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020A8 File Offset: 0x000002A8
		public static double dspTime
		{
			get
			{
				return AudioSettings.get_dspTimeDelegateField();
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00003B2C File Offset: 0x00001D2C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020B4 File Offset: 0x000002B4
		public static int outputSampleRate
		{
			get
			{
				return AudioSettings.GetSampleRate();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020C1 File Offset: 0x000002C1
		public static void GetDSPBufferSize(out int bufferLength, out int numBuffers)
		{
			AudioSettings.GetDSPBufferSizeDelegateField(out bufferLength, out numBuffers);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020CF File Offset: 0x000002CF
		public static void SetDSPBufferSize(int bufferLength, int numBuffers)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003B44 File Offset: 0x00001D44
		public static string GetSpatializerPluginName()
		{
			IntPtr intPtr = AudioSettings.GetSpatializerPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020DC File Offset: 0x000002DC
		public static void add_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020E9 File Offset: 0x000002E9
		public static void remove_OnAudioConfigurationChanged(AudioSettings.AudioConfigurationChangeHandler value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020F6 File Offset: 0x000002F6
		public static bool unityAudioDisabled
		{
			get
			{
				return AudioSettings.get_unityAudioDisabledDelegateField();
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003B64 File Offset: 0x00001D64
		public static string GetAmbisonicDecoderPluginName()
		{
			IntPtr intPtr = AudioSettings.GetAmbisonicDecoderPluginNameDelegateField();
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_OnAudioConfigurationChanged;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnAudioConfigurationChanged_Internal_Static_Void_Boolean_0;

		// Token: 0x04000003 RID: 3
		private static readonly AudioSettings.GetSpeakerModeDelegate GetSpeakerModeDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly AudioSettings.GetSampleRateDelegate GetSampleRateDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly AudioSettings.get_driverCapabilitiesDelegate get_driverCapabilitiesDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly AudioSettings.get_profilerCaptureFlagsDelegate get_profilerCaptureFlagsDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly AudioSettings.get_dspTimeDelegate get_dspTimeDelegateField;

		// Token: 0x04000008 RID: 8
		private static readonly AudioSettings.GetDSPBufferSizeDelegate GetDSPBufferSizeDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly AudioSettings.GetSpatializerPluginNameDelegate GetSpatializerPluginNameDelegateField;

		// Token: 0x0400000A RID: 10
		private static readonly AudioSettings.get_unityAudioDisabledDelegate get_unityAudioDisabledDelegateField;

		// Token: 0x0400000B RID: 11
		private static readonly AudioSettings.GetAmbisonicDecoderPluginNameDelegate GetAmbisonicDecoderPluginNameDelegateField;

		// Token: 0x0200002A RID: 42
		public sealed class AudioConfigurationChangeHandler : MulticastDelegate
		{
			// Token: 0x060001F7 RID: 503 RVA: 0x0000381E File Offset: 0x00001A1E
			// Note: this type is marked as 'beforefieldinit'.
			static AudioConfigurationChangeHandler()
			{
				Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AudioConfigurationChangeHandler");
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663298);
				AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr, 100663299);
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x00006944 File Offset: 0x00004B44
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AudioConfigurationChangeHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings.AudioConfigurationChangeHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x000069A0 File Offset: 0x00004BA0
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 80701, RefRangeEnd = 80719, XrefRangeStart = 80701, XrefRangeEnd = 80719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(bool deviceWasChanged)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref deviceWasChanged;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.AudioConfigurationChangeHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000385C File Offset: 0x00001A5C
			public AudioConfigurationChangeHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00003865 File Offset: 0x00001A65
			public static implicit operator AudioSettings.AudioConfigurationChangeHandler(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioSettings.AudioConfigurationChangeHandler>(A_0);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x0000386D File Offset: 0x00001A6D
			public static AudioSettings.AudioConfigurationChangeHandler operator +(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioSettings.AudioConfigurationChangeHandler>();
			}

			// Token: 0x060001FD RID: 509 RVA: 0x0000387B File Offset: 0x00001A7B
			public static AudioSettings.AudioConfigurationChangeHandler operator -(AudioSettings.AudioConfigurationChangeHandler A_0, AudioSettings.AudioConfigurationChangeHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioSettings.AudioConfigurationChangeHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400019B RID: 411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400019C RID: 412
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;
		}

		// Token: 0x0200002B RID: 43
		public static class Mobile
		{
		}

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060001FF RID: 511
		private delegate AudioSpeakerMode GetSpeakerModeDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000201 RID: 513
		private delegate int GetSampleRateDelegate();

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000203 RID: 515
		private delegate AudioSpeakerMode get_driverCapabilitiesDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000205 RID: 517
		private delegate int get_profilerCaptureFlagsDelegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x06000207 RID: 519
		private delegate double get_dspTimeDelegate();

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000209 RID: 521
		private delegate void GetDSPBufferSizeDelegate([Out] IntPtr bufferLength, [Out] IntPtr numBuffers);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600020B RID: 523
		private delegate IntPtr GetSpatializerPluginNameDelegate();

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x0600020D RID: 525
		private delegate bool get_unityAudioDisabledDelegate();

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x0600020F RID: 527
		private delegate IntPtr GetAmbisonicDecoderPluginNameDelegate();
	}
}
