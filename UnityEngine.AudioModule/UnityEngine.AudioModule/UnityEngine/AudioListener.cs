using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public sealed class AudioListener : AudioBehaviour
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000410C File Offset: 0x0000230C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioListener()
		{
			Il2CppClassPointerStore<AudioListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioListener>.NativeClassPtr);
			AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioListener>.NativeClassPtr, 100663308);
			AudioListener.GetOutputDataHelperDelegateField = IL2CPP.ResolveICall<AudioListener.GetOutputDataHelperDelegate>("UnityEngine.AudioListener::GetOutputDataHelper");
			AudioListener.GetSpectrumDataHelperDelegateField = IL2CPP.ResolveICall<AudioListener.GetSpectrumDataHelperDelegate>("UnityEngine.AudioListener::GetSpectrumDataHelper");
			AudioListener.get_volumeDelegateField = IL2CPP.ResolveICall<AudioListener.get_volumeDelegate>("UnityEngine.AudioListener::get_volume");
			AudioListener.get_pauseDelegateField = IL2CPP.ResolveICall<AudioListener.get_pauseDelegate>("UnityEngine.AudioListener::get_pause");
			AudioListener.set_pauseDelegateField = IL2CPP.ResolveICall<AudioListener.set_pauseDelegate>("UnityEngine.AudioListener::set_pause");
			AudioListener.get_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioListener.get_velocityUpdateModeDelegate>("UnityEngine.AudioListener::get_velocityUpdateMode");
			AudioListener.set_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioListener.set_velocityUpdateModeDelegate>("UnityEngine.AudioListener::set_velocityUpdateMode");
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000022F3 File Offset: 0x000004F3
		// (set) Token: 0x0600003F RID: 63 RVA: 0x000041BC File Offset: 0x000023BC
		public unsafe static float volume
		{
			get
			{
				return AudioListener.get_volumeDelegateField();
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 90094, RefRangeEnd = 90097, XrefRangeStart = 90092, XrefRangeEnd = 90094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioListener.NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000022C3 File Offset: 0x000004C3
		public AudioListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022CC File Offset: 0x000004CC
		public static void GetOutputDataHelper([Out] Il2CppStructArray<float> samples, int channel)
		{
			AudioListener.GetOutputDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(samples), channel);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022DF File Offset: 0x000004DF
		public static void GetSpectrumDataHelper([Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(samples), channel, window);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000022FF File Offset: 0x000004FF
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000230B File Offset: 0x0000050B
		public static bool pause
		{
			get
			{
				return AudioListener.get_pauseDelegateField();
			}
			set
			{
				AudioListener.set_pauseDelegateField(value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002318 File Offset: 0x00000518
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000232A File Offset: 0x0000052A
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			get
			{
				return AudioListener.get_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioListener.set_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000233D File Offset: 0x0000053D
		public static Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000234A File Offset: 0x0000054A
		public static void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			AudioListener.GetOutputDataHelper(samples, channel);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002355 File Offset: 0x00000555
		public static Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002362 File Offset: 0x00000562
		public static void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioListener.GetSpectrumDataHelper(samples, channel, window);
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_Static_set_Void_Single_0;

		// Token: 0x04000023 RID: 35
		private static readonly AudioListener.GetOutputDataHelperDelegate GetOutputDataHelperDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly AudioListener.GetSpectrumDataHelperDelegate GetSpectrumDataHelperDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly AudioListener.get_volumeDelegate get_volumeDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly AudioListener.get_pauseDelegate get_pauseDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly AudioListener.set_pauseDelegate set_pauseDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly AudioListener.get_velocityUpdateModeDelegate get_velocityUpdateModeDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly AudioListener.set_velocityUpdateModeDelegate set_velocityUpdateModeDelegateField;

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600023F RID: 575
		private delegate void GetOutputDataHelperDelegate([Out] IntPtr samples, int channel);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000241 RID: 577
		private delegate void GetSpectrumDataHelperDelegate([Out] IntPtr samples, int channel, FFTWindow window);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000243 RID: 579
		private delegate float get_volumeDelegate();

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000245 RID: 581
		private delegate bool get_pauseDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x06000247 RID: 583
		private delegate void set_pauseDelegate(bool value);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000249 RID: 585
		private delegate AudioVelocityUpdateMode get_velocityUpdateModeDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x0600024B RID: 587
		private delegate void set_velocityUpdateModeDelegate(IntPtr @this, AudioVelocityUpdateMode value);
	}
}
