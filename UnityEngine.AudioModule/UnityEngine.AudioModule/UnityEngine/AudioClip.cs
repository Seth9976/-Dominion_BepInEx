using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public sealed class AudioClip : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00003B84 File Offset: 0x00001D84
		// Note: this type is marked as 'beforefieldinit'.
		static AudioClip()
		{
			Il2CppClassPointerStore<AudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioClip");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClip>.NativeClassPtr);
			AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMReaderCallback");
			AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMSetPositionCallback");
			AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663300);
			AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663301);
			AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663302);
			AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663303);
			AudioClip.GetDataDelegateField = IL2CPP.ResolveICall<AudioClip.GetDataDelegate>("UnityEngine.AudioClip::GetData");
			AudioClip.SetDataDelegateField = IL2CPP.ResolveICall<AudioClip.SetDataDelegate>("UnityEngine.AudioClip::SetData");
			AudioClip.Construct_InternalDelegateField = IL2CPP.ResolveICall<AudioClip.Construct_InternalDelegate>("UnityEngine.AudioClip::Construct_Internal");
			AudioClip.GetNameDelegateField = IL2CPP.ResolveICall<AudioClip.GetNameDelegate>("UnityEngine.AudioClip::GetName");
			AudioClip.CreateUserSoundDelegateField = IL2CPP.ResolveICall<AudioClip.CreateUserSoundDelegate>("UnityEngine.AudioClip::CreateUserSound");
			AudioClip.get_samplesDelegateField = IL2CPP.ResolveICall<AudioClip.get_samplesDelegate>("UnityEngine.AudioClip::get_samples");
			AudioClip.get_channelsDelegateField = IL2CPP.ResolveICall<AudioClip.get_channelsDelegate>("UnityEngine.AudioClip::get_channels");
			AudioClip.get_frequencyDelegateField = IL2CPP.ResolveICall<AudioClip.get_frequencyDelegate>("UnityEngine.AudioClip::get_frequency");
			AudioClip.get_isReadyToPlayDelegateField = IL2CPP.ResolveICall<AudioClip.get_isReadyToPlayDelegate>("UnityEngine.AudioClip::get_isReadyToPlay");
			AudioClip.get_loadTypeDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadTypeDelegate>("UnityEngine.AudioClip::get_loadType");
			AudioClip.LoadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.LoadAudioDataDelegate>("UnityEngine.AudioClip::LoadAudioData");
			AudioClip.UnloadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.UnloadAudioDataDelegate>("UnityEngine.AudioClip::UnloadAudioData");
			AudioClip.get_preloadAudioDataDelegateField = IL2CPP.ResolveICall<AudioClip.get_preloadAudioDataDelegate>("UnityEngine.AudioClip::get_preloadAudioData");
			AudioClip.get_ambisonicDelegateField = IL2CPP.ResolveICall<AudioClip.get_ambisonicDelegate>("UnityEngine.AudioClip::get_ambisonic");
			AudioClip.get_loadInBackgroundDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadInBackgroundDelegate>("UnityEngine.AudioClip::get_loadInBackground");
			AudioClip.get_loadStateDelegateField = IL2CPP.ResolveICall<AudioClip.get_loadStateDelegate>("UnityEngine.AudioClip::get_loadState");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003D1C File Offset: 0x00001F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90079, XrefRangeEnd = 90083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003D58 File Offset: 0x00001F58
		public unsafe float length
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90085, RefRangeEnd = 90087, XrefRangeStart = 90083, XrefRangeEnd = 90085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_get_length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003D94 File Offset: 0x00001F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90087, XrefRangeEnd = 90088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePCMReaderCallback_Internal(Il2CppStructArray<float> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003DD8 File Offset: 0x00001FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90088, XrefRangeEnd = 90092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePCMSetPositionCallback_Internal(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002102 File Offset: 0x00000302
		public AudioClip(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003E18 File Offset: 0x00002018
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000210B File Offset: 0x0000030B
		public unsafe AudioClip.PCMReaderCallback m_PCMReaderCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMReaderCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMReaderCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003E48 File Offset: 0x00002048
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000212A File Offset: 0x0000032A
		public unsafe AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip.PCMSetPositionCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioClip.NativeFieldInfoPtr_m_PCMSetPositionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002149 File Offset: 0x00000349
		public static bool GetData(AudioClip clip, [Out] Il2CppStructArray<float> data, int numSamples, int samplesOffset)
		{
			return AudioClip.GetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.Il2CppObjectBaseToPtr(data), numSamples, samplesOffset);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002163 File Offset: 0x00000363
		public static bool SetData(AudioClip clip, Il2CppStructArray<float> data, int numsamples, int samplesOffset)
		{
			return AudioClip.SetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtr(clip), IL2CPP.Il2CppObjectBaseToPtr(data), numsamples, samplesOffset);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003E78 File Offset: 0x00002078
		public static AudioClip Construct_Internal()
		{
			IntPtr intPtr = AudioClip.Construct_InternalDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003EA0 File Offset: 0x000020A0
		public string GetName()
		{
			IntPtr intPtr = AudioClip.GetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000217D File Offset: 0x0000037D
		public void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			AudioClip.CreateUserSoundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name), lengthSamples, channels, frequency, stream);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x0000219B File Offset: 0x0000039B
		public int samples
		{
			get
			{
				return AudioClip.get_samplesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000021AD File Offset: 0x000003AD
		public int channels
		{
			get
			{
				return AudioClip.get_channelsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021BF File Offset: 0x000003BF
		public int frequency
		{
			get
			{
				return AudioClip.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021D1 File Offset: 0x000003D1
		public bool isReadyToPlay
		{
			get
			{
				return AudioClip.get_isReadyToPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021E3 File Offset: 0x000003E3
		public AudioClipLoadType loadType
		{
			get
			{
				return AudioClip.get_loadTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000021F5 File Offset: 0x000003F5
		public bool LoadAudioData()
		{
			return AudioClip.LoadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002207 File Offset: 0x00000407
		public bool UnloadAudioData()
		{
			return AudioClip.UnloadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002219 File Offset: 0x00000419
		public bool preloadAudioData
		{
			get
			{
				return AudioClip.get_preloadAudioDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000222B File Offset: 0x0000042B
		public bool ambisonic
		{
			get
			{
				return AudioClip.get_ambisonicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000223D File Offset: 0x0000043D
		public bool loadInBackground
		{
			get
			{
				return AudioClip.get_loadInBackgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000224F File Offset: 0x0000044F
		public AudioDataLoadState loadState
		{
			get
			{
				return AudioClip.get_loadStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003EC4 File Offset: 0x000020C4
		public bool GetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			bool flag = this.channels <= 0;
			bool flag2;
			if (flag)
			{
				Debug.Log(String.Concat("AudioClip.GetData failed; AudioClip ", this.GetName(), " contains no data"));
				flag2 = false;
			}
			else
			{
				int num = ((data != null) ? (data.Length / this.channels) : 0);
				flag2 = AudioClip.GetData(this, data, num, offsetSamples);
			}
			return flag2;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003F24 File Offset: 0x00002124
		public bool SetData(Il2CppStructArray<float> data, int offsetSamples)
		{
			bool flag = this.channels <= 0;
			bool flag2;
			if (flag)
			{
				Debug.Log(String.Concat("AudioClip.SetData failed; AudioClip ", this.GetName(), " contains no data"));
				flag2 = false;
			}
			else
			{
				bool flag3 = offsetSamples < 0 || offsetSamples >= this.samples;
				if (flag3)
				{
					throw new ArgumentException("AudioClip.SetData failed; invalid offsetSamples");
				}
				bool flag4 = data == null || data.Length == 0;
				if (flag4)
				{
					throw new ArgumentException("AudioClip.SetData failed; invalid data");
				}
				flag2 = AudioClip.SetData(this, data, data.Length / this.channels, offsetSamples);
			}
			return flag2;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003FBC File Offset: 0x000021BC
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003FDC File Offset: 0x000021DC
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003FFC File Offset: 0x000021FC
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004020 File Offset: 0x00002220
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, null, null);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004044 File Offset: 0x00002244
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback)
		{
			return AudioClip.Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004068 File Offset: 0x00002268
		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback)
		{
			bool flag = name == null;
			if (flag)
			{
				throw new NullReferenceException();
			}
			bool flag2 = lengthSamples <= 0;
			if (flag2)
			{
				throw new ArgumentException("Length of created clip must be larger than 0");
			}
			bool flag3 = channels <= 0;
			if (flag3)
			{
				throw new ArgumentException("Number of channels in created clip must be greater than 0");
			}
			bool flag4 = frequency <= 0;
			if (flag4)
			{
				throw new ArgumentException("Frequency in created clip must be greater than 0");
			}
			AudioClip audioClip = AudioClip.Construct_Internal();
			bool flag5 = pcmreadercallback != null;
			if (flag5)
			{
				audioClip.add_m_PCMReaderCallback(pcmreadercallback);
			}
			bool flag6 = pcmsetpositioncallback != null;
			if (flag6)
			{
				audioClip.add_m_PCMSetPositionCallback(pcmsetpositioncallback);
			}
			audioClip.CreateUserSound(name, lengthSamples, channels, frequency, stream);
			return audioClip;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002261 File Offset: 0x00000461
		public void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000226E File Offset: 0x0000046E
		public void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000227B File Offset: 0x0000047B
		public void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002288 File Offset: 0x00000488
		public void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMReaderCallback;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_m_PCMSetPositionCallback;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly AudioClip.GetDataDelegate GetDataDelegateField;

		// Token: 0x04000013 RID: 19
		private static readonly AudioClip.SetDataDelegate SetDataDelegateField;

		// Token: 0x04000014 RID: 20
		private static readonly AudioClip.Construct_InternalDelegate Construct_InternalDelegateField;

		// Token: 0x04000015 RID: 21
		private static readonly AudioClip.GetNameDelegate GetNameDelegateField;

		// Token: 0x04000016 RID: 22
		private static readonly AudioClip.CreateUserSoundDelegate CreateUserSoundDelegateField;

		// Token: 0x04000017 RID: 23
		private static readonly AudioClip.get_samplesDelegate get_samplesDelegateField;

		// Token: 0x04000018 RID: 24
		private static readonly AudioClip.get_channelsDelegate get_channelsDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly AudioClip.get_frequencyDelegate get_frequencyDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly AudioClip.get_isReadyToPlayDelegate get_isReadyToPlayDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly AudioClip.get_loadTypeDelegate get_loadTypeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly AudioClip.LoadAudioDataDelegate LoadAudioDataDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly AudioClip.UnloadAudioDataDelegate UnloadAudioDataDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly AudioClip.get_preloadAudioDataDelegate get_preloadAudioDataDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly AudioClip.get_ambisonicDelegate get_ambisonicDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly AudioClip.get_loadInBackgroundDelegate get_loadInBackgroundDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly AudioClip.get_loadStateDelegate get_loadStateDelegateField;

		// Token: 0x02000035 RID: 53
		public sealed class PCMReaderCallback : MulticastDelegate
		{
			// Token: 0x06000210 RID: 528 RVA: 0x0000388C File Offset: 0x00001A8C
			// Note: this type is marked as 'beforefieldinit'.
			static PCMReaderCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMReaderCallback");
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663304);
				AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr, 100663305);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000069E0 File Offset: 0x00004BE0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMReaderCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMReaderCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00006A3C File Offset: 0x00004C3C
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 37089, RefRangeEnd = 37101, XrefRangeStart = 37089, XrefRangeEnd = 37101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppStructArray<float> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMReaderCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000213 RID: 531 RVA: 0x000038CA File Offset: 0x00001ACA
			public PCMReaderCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000214 RID: 532 RVA: 0x000038D3 File Offset: 0x00001AD3
			public static implicit operator AudioClip.PCMReaderCallback(Action<Il2CppStructArray<float>> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMReaderCallback>(A_0);
			}

			// Token: 0x06000215 RID: 533 RVA: 0x000038DB File Offset: 0x00001ADB
			public static AudioClip.PCMReaderCallback operator +(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMReaderCallback>();
			}

			// Token: 0x06000216 RID: 534 RVA: 0x000038E9 File Offset: 0x00001AE9
			public static AudioClip.PCMReaderCallback operator -(AudioClip.PCMReaderCallback A_0, AudioClip.PCMReaderCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMReaderCallback>();
				}
				return delegate2;
			}

			// Token: 0x0400019D RID: 413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400019E RID: 414
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0;
		}

		// Token: 0x02000036 RID: 54
		public sealed class PCMSetPositionCallback : MulticastDelegate
		{
			// Token: 0x06000217 RID: 535 RVA: 0x000038FA File Offset: 0x00001AFA
			// Note: this type is marked as 'beforefieldinit'.
			static PCMSetPositionCallback()
			{
				Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMSetPositionCallback");
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663306);
				AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr, 100663307);
			}

			// Token: 0x06000218 RID: 536 RVA: 0x00006A80 File Offset: 0x00004C80
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PCMSetPositionCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip.PCMSetPositionCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000219 RID: 537 RVA: 0x00006ADC File Offset: 0x00004CDC
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 84530, RefRangeEnd = 84546, XrefRangeStart = 84530, XrefRangeEnd = 84546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(int position)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref position;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioClip.PCMSetPositionCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00003938 File Offset: 0x00001B38
			public PCMSetPositionCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600021B RID: 539 RVA: 0x00003941 File Offset: 0x00001B41
			public static implicit operator AudioClip.PCMSetPositionCallback(Action<int> A_0)
			{
				return DelegateSupport.ConvertDelegate<AudioClip.PCMSetPositionCallback>(A_0);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00003949 File Offset: 0x00001B49
			public static AudioClip.PCMSetPositionCallback operator +(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<AudioClip.PCMSetPositionCallback>();
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00003957 File Offset: 0x00001B57
			public static AudioClip.PCMSetPositionCallback operator -(AudioClip.PCMSetPositionCallback A_0, AudioClip.PCMSetPositionCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<AudioClip.PCMSetPositionCallback>();
				}
				return delegate2;
			}

			// Token: 0x0400019F RID: 415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040001A0 RID: 416
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;
		}

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600021F RID: 543
		private delegate bool GetDataDelegate(IntPtr clip, [Out] IntPtr data, int numSamples, int samplesOffset);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x06000221 RID: 545
		private delegate bool SetDataDelegate(IntPtr clip, IntPtr data, int numsamples, int samplesOffset);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000223 RID: 547
		private delegate IntPtr Construct_InternalDelegate();

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000225 RID: 549
		private delegate IntPtr GetNameDelegate(IntPtr @this);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000227 RID: 551
		private delegate void CreateUserSoundDelegate(IntPtr @this, IntPtr name, int lengthSamples, int channels, int frequency, bool stream);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000229 RID: 553
		private delegate int get_samplesDelegate(IntPtr @this);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x0600022B RID: 555
		private delegate int get_channelsDelegate(IntPtr @this);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x0600022D RID: 557
		private delegate int get_frequencyDelegate(IntPtr @this);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600022F RID: 559
		private delegate bool get_isReadyToPlayDelegate(IntPtr @this);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x06000231 RID: 561
		private delegate AudioClipLoadType get_loadTypeDelegate(IntPtr @this);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x06000233 RID: 563
		private delegate bool LoadAudioDataDelegate(IntPtr @this);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000235 RID: 565
		private delegate bool UnloadAudioDataDelegate(IntPtr @this);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000237 RID: 567
		private delegate bool get_preloadAudioDataDelegate(IntPtr @this);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000239 RID: 569
		private delegate bool get_ambisonicDelegate(IntPtr @this);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x0600023B RID: 571
		private delegate bool get_loadInBackgroundDelegate(IntPtr @this);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x0600023D RID: 573
		private delegate AudioDataLoadState get_loadStateDelegate(IntPtr @this);
	}
}
