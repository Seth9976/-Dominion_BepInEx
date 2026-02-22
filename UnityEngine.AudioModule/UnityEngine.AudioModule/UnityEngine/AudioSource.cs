using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x0600004C RID: 76 RVA: 0x000041F0 File Offset: 0x000023F0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSource()
		{
			Il2CppClassPointerStore<AudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSource>.NativeClassPtr);
			AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663309);
			AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663310);
			AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663311);
			AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663312);
			AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663313);
			AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663314);
			AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663315);
			AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663316);
			AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663317);
			AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663318);
			AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663319);
			AudioSource.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663320);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663321);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663322);
			AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663323);
			AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663324);
			AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663325);
			AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663326);
			AudioSource.PlayDelegateField = IL2CPP.ResolveICall<AudioSource.PlayDelegate>("UnityEngine.AudioSource::Play");
			AudioSource.SetCustomCurveHelperDelegateField = IL2CPP.ResolveICall<AudioSource.SetCustomCurveHelperDelegate>("UnityEngine.AudioSource::SetCustomCurveHelper");
			AudioSource.GetCustomCurveHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetCustomCurveHelperDelegate>("UnityEngine.AudioSource::GetCustomCurveHelper");
			AudioSource.GetOutputDataHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetOutputDataHelperDelegate>("UnityEngine.AudioSource::GetOutputDataHelper");
			AudioSource.GetSpectrumDataHelperDelegateField = IL2CPP.ResolveICall<AudioSource.GetSpectrumDataHelperDelegate>("UnityEngine.AudioSource::GetSpectrumDataHelper");
			AudioSource.get_timeDelegateField = IL2CPP.ResolveICall<AudioSource.get_timeDelegate>("UnityEngine.AudioSource::get_time");
			AudioSource.set_timeDelegateField = IL2CPP.ResolveICall<AudioSource.set_timeDelegate>("UnityEngine.AudioSource::set_time");
			AudioSource.get_timeSamplesDelegateField = IL2CPP.ResolveICall<AudioSource.get_timeSamplesDelegate>("UnityEngine.AudioSource::get_timeSamples");
			AudioSource.set_timeSamplesDelegateField = IL2CPP.ResolveICall<AudioSource.set_timeSamplesDelegate>("UnityEngine.AudioSource::set_timeSamples");
			AudioSource.get_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioSource.get_outputAudioMixerGroupDelegate>("UnityEngine.AudioSource::get_outputAudioMixerGroup");
			AudioSource.set_outputAudioMixerGroupDelegateField = IL2CPP.ResolveICall<AudioSource.set_outputAudioMixerGroupDelegate>("UnityEngine.AudioSource::set_outputAudioMixerGroup");
			AudioSource.SetScheduledStartTimeDelegateField = IL2CPP.ResolveICall<AudioSource.SetScheduledStartTimeDelegate>("UnityEngine.AudioSource::SetScheduledStartTime");
			AudioSource.SetScheduledEndTimeDelegateField = IL2CPP.ResolveICall<AudioSource.SetScheduledEndTimeDelegate>("UnityEngine.AudioSource::SetScheduledEndTime");
			AudioSource.PauseDelegateField = IL2CPP.ResolveICall<AudioSource.PauseDelegate>("UnityEngine.AudioSource::Pause");
			AudioSource.UnPauseDelegateField = IL2CPP.ResolveICall<AudioSource.UnPauseDelegate>("UnityEngine.AudioSource::UnPause");
			AudioSource.get_isVirtualDelegateField = IL2CPP.ResolveICall<AudioSource.get_isVirtualDelegate>("UnityEngine.AudioSource::get_isVirtual");
			AudioSource.get_loopDelegateField = IL2CPP.ResolveICall<AudioSource.get_loopDelegate>("UnityEngine.AudioSource::get_loop");
			AudioSource.set_loopDelegateField = IL2CPP.ResolveICall<AudioSource.set_loopDelegate>("UnityEngine.AudioSource::set_loop");
			AudioSource.get_ignoreListenerVolumeDelegateField = IL2CPP.ResolveICall<AudioSource.get_ignoreListenerVolumeDelegate>("UnityEngine.AudioSource::get_ignoreListenerVolume");
			AudioSource.get_playOnAwakeDelegateField = IL2CPP.ResolveICall<AudioSource.get_playOnAwakeDelegate>("UnityEngine.AudioSource::get_playOnAwake");
			AudioSource.get_ignoreListenerPauseDelegateField = IL2CPP.ResolveICall<AudioSource.get_ignoreListenerPauseDelegate>("UnityEngine.AudioSource::get_ignoreListenerPause");
			AudioSource.set_ignoreListenerPauseDelegateField = IL2CPP.ResolveICall<AudioSource.set_ignoreListenerPauseDelegate>("UnityEngine.AudioSource::set_ignoreListenerPause");
			AudioSource.get_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioSource.get_velocityUpdateModeDelegate>("UnityEngine.AudioSource::get_velocityUpdateMode");
			AudioSource.set_velocityUpdateModeDelegateField = IL2CPP.ResolveICall<AudioSource.set_velocityUpdateModeDelegate>("UnityEngine.AudioSource::set_velocityUpdateMode");
			AudioSource.get_panStereoDelegateField = IL2CPP.ResolveICall<AudioSource.get_panStereoDelegate>("UnityEngine.AudioSource::get_panStereo");
			AudioSource.set_panStereoDelegateField = IL2CPP.ResolveICall<AudioSource.set_panStereoDelegate>("UnityEngine.AudioSource::set_panStereo");
			AudioSource.get_spatialBlendDelegateField = IL2CPP.ResolveICall<AudioSource.get_spatialBlendDelegate>("UnityEngine.AudioSource::get_spatialBlend");
			AudioSource.set_spatialBlendDelegateField = IL2CPP.ResolveICall<AudioSource.set_spatialBlendDelegate>("UnityEngine.AudioSource::set_spatialBlend");
			AudioSource.get_spatializeDelegateField = IL2CPP.ResolveICall<AudioSource.get_spatializeDelegate>("UnityEngine.AudioSource::get_spatialize");
			AudioSource.set_spatializeDelegateField = IL2CPP.ResolveICall<AudioSource.set_spatializeDelegate>("UnityEngine.AudioSource::set_spatialize");
			AudioSource.get_spatializePostEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_spatializePostEffectsDelegate>("UnityEngine.AudioSource::get_spatializePostEffects");
			AudioSource.set_spatializePostEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.set_spatializePostEffectsDelegate>("UnityEngine.AudioSource::set_spatializePostEffects");
			AudioSource.get_reverbZoneMixDelegateField = IL2CPP.ResolveICall<AudioSource.get_reverbZoneMixDelegate>("UnityEngine.AudioSource::get_reverbZoneMix");
			AudioSource.set_reverbZoneMixDelegateField = IL2CPP.ResolveICall<AudioSource.set_reverbZoneMixDelegate>("UnityEngine.AudioSource::set_reverbZoneMix");
			AudioSource.get_bypassEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassEffectsDelegate>("UnityEngine.AudioSource::get_bypassEffects");
			AudioSource.set_bypassEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.set_bypassEffectsDelegate>("UnityEngine.AudioSource::set_bypassEffects");
			AudioSource.get_bypassListenerEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassListenerEffectsDelegate>("UnityEngine.AudioSource::get_bypassListenerEffects");
			AudioSource.set_bypassListenerEffectsDelegateField = IL2CPP.ResolveICall<AudioSource.set_bypassListenerEffectsDelegate>("UnityEngine.AudioSource::set_bypassListenerEffects");
			AudioSource.get_bypassReverbZonesDelegateField = IL2CPP.ResolveICall<AudioSource.get_bypassReverbZonesDelegate>("UnityEngine.AudioSource::get_bypassReverbZones");
			AudioSource.set_bypassReverbZonesDelegateField = IL2CPP.ResolveICall<AudioSource.set_bypassReverbZonesDelegate>("UnityEngine.AudioSource::set_bypassReverbZones");
			AudioSource.get_dopplerLevelDelegateField = IL2CPP.ResolveICall<AudioSource.get_dopplerLevelDelegate>("UnityEngine.AudioSource::get_dopplerLevel");
			AudioSource.set_dopplerLevelDelegateField = IL2CPP.ResolveICall<AudioSource.set_dopplerLevelDelegate>("UnityEngine.AudioSource::set_dopplerLevel");
			AudioSource.get_spreadDelegateField = IL2CPP.ResolveICall<AudioSource.get_spreadDelegate>("UnityEngine.AudioSource::get_spread");
			AudioSource.set_spreadDelegateField = IL2CPP.ResolveICall<AudioSource.set_spreadDelegate>("UnityEngine.AudioSource::set_spread");
			AudioSource.get_priorityDelegateField = IL2CPP.ResolveICall<AudioSource.get_priorityDelegate>("UnityEngine.AudioSource::get_priority");
			AudioSource.set_priorityDelegateField = IL2CPP.ResolveICall<AudioSource.set_priorityDelegate>("UnityEngine.AudioSource::set_priority");
			AudioSource.get_muteDelegateField = IL2CPP.ResolveICall<AudioSource.get_muteDelegate>("UnityEngine.AudioSource::get_mute");
			AudioSource.set_muteDelegateField = IL2CPP.ResolveICall<AudioSource.set_muteDelegate>("UnityEngine.AudioSource::set_mute");
			AudioSource.get_minDistanceDelegateField = IL2CPP.ResolveICall<AudioSource.get_minDistanceDelegate>("UnityEngine.AudioSource::get_minDistance");
			AudioSource.set_minDistanceDelegateField = IL2CPP.ResolveICall<AudioSource.set_minDistanceDelegate>("UnityEngine.AudioSource::set_minDistance");
			AudioSource.get_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioSource.get_maxDistanceDelegate>("UnityEngine.AudioSource::get_maxDistance");
			AudioSource.set_maxDistanceDelegateField = IL2CPP.ResolveICall<AudioSource.set_maxDistanceDelegate>("UnityEngine.AudioSource::set_maxDistance");
			AudioSource.get_rolloffModeDelegateField = IL2CPP.ResolveICall<AudioSource.get_rolloffModeDelegate>("UnityEngine.AudioSource::get_rolloffMode");
			AudioSource.set_rolloffModeDelegateField = IL2CPP.ResolveICall<AudioSource.set_rolloffModeDelegate>("UnityEngine.AudioSource::set_rolloffMode");
			AudioSource.SetSpatializerFloatDelegateField = IL2CPP.ResolveICall<AudioSource.SetSpatializerFloatDelegate>("UnityEngine.AudioSource::SetSpatializerFloat");
			AudioSource.GetSpatializerFloatDelegateField = IL2CPP.ResolveICall<AudioSource.GetSpatializerFloatDelegate>("UnityEngine.AudioSource::GetSpatializerFloat");
			AudioSource.GetAmbisonicDecoderFloatDelegateField = IL2CPP.ResolveICall<AudioSource.GetAmbisonicDecoderFloatDelegate>("UnityEngine.AudioSource::GetAmbisonicDecoderFloat");
			AudioSource.SetAmbisonicDecoderFloatDelegateField = IL2CPP.ResolveICall<AudioSource.SetAmbisonicDecoderFloatDelegate>("UnityEngine.AudioSource::SetAmbisonicDecoderFloat");
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000046F0 File Offset: 0x000028F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90099, RefRangeEnd = 90103, XrefRangeStart = 90097, XrefRangeEnd = 90099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPitch(AudioSource source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004734 File Offset: 0x00002934
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 90105, RefRangeEnd = 90111, XrefRangeStart = 90103, XrefRangeEnd = 90105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPitch(AudioSource source, float pitch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004778 File Offset: 0x00002978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90111, XrefRangeEnd = 90113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayHelper(AudioSource source, ulong delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000047BC File Offset: 0x000029BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90113, XrefRangeEnd = 90115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004814 File Offset: 0x00002A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90115, XrefRangeEnd = 90117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool stopOneShots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopOneShots;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004854 File Offset: 0x00002A54
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004890 File Offset: 0x00002A90
		public unsafe float volume
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90119, RefRangeEnd = 90121, XrefRangeStart = 90117, XrefRangeEnd = 90119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 90123, RefRangeEnd = 90132, XrefRangeStart = 90121, XrefRangeEnd = 90123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000048D0 File Offset: 0x00002AD0
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000490C File Offset: 0x00002B0C
		public unsafe float pitch
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90099, RefRangeEnd = 90103, XrefRangeStart = 90099, XrefRangeEnd = 90103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 90105, RefRangeEnd = 90111, XrefRangeStart = 90105, XrefRangeEnd = 90111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000494C File Offset: 0x00002B4C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000498C File Offset: 0x00002B8C
		public unsafe AudioClip clip
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 90134, RefRangeEnd = 90138, XrefRangeStart = 90132, XrefRangeEnd = 90134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 90140, RefRangeEnd = 90149, XrefRangeStart = 90138, XrefRangeEnd = 90140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000049D0 File Offset: 0x00002BD0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 90151, RefRangeEnd = 90172, XrefRangeStart = 90149, XrefRangeEnd = 90151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004A04 File Offset: 0x00002C04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 90184, RefRangeEnd = 90191, XrefRangeStart = 90172, XrefRangeEnd = 90184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004A48 File Offset: 0x00002C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90191, XrefRangeEnd = 90203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip, float volumeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004A98 File Offset: 0x00002C98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 90205, RefRangeEnd = 90209, XrefRangeStart = 90203, XrefRangeEnd = 90205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004ACC File Offset: 0x00002CCC
		public unsafe bool isPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90211, RefRangeEnd = 90212, XrefRangeStart = 90209, XrefRangeEnd = 90211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002516 File Offset: 0x00000716
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00004B08 File Offset: 0x00002D08
		public unsafe bool ignoreListenerVolume
		{
			get
			{
				return AudioSource.get_ignoreListenerVolumeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90214, RefRangeEnd = 90215, XrefRangeStart = 90212, XrefRangeEnd = 90214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002528 File Offset: 0x00000728
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00004B48 File Offset: 0x00002D48
		public unsafe bool playOnAwake
		{
			get
			{
				return AudioSource.get_playOnAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 90217, RefRangeEnd = 90219, XrefRangeStart = 90215, XrefRangeEnd = 90217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000236E File Offset: 0x0000056E
		public AudioSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002377 File Offset: 0x00000577
		public void Play(double delay)
		{
			AudioSource.PlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), delay);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000238A File Offset: 0x0000058A
		public static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve)
		{
			AudioSource.SetCustomCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), type, IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004B88 File Offset: 0x00002D88
		public static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type)
		{
			IntPtr intPtr = AudioSource.GetCustomCurveHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), type);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000023A3 File Offset: 0x000005A3
		public static void GetOutputDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel)
		{
			AudioSource.GetOutputDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(samples), channel);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000023BC File Offset: 0x000005BC
		public static void GetSpectrumDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioSource.GetSpectrumDataHelperDelegateField(IL2CPP.Il2CppObjectBaseToPtr(source), IL2CPP.Il2CppObjectBaseToPtr(samples), channel, window);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000023D6 File Offset: 0x000005D6
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023E8 File Offset: 0x000005E8
		public float time
		{
			get
			{
				return AudioSource.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000023FB File Offset: 0x000005FB
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0000240D File Offset: 0x0000060D
		public int timeSamples
		{
			get
			{
				return AudioSource.get_timeSamplesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_timeSamplesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004BB8 File Offset: 0x00002DB8
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002420 File Offset: 0x00000620
		public AudioMixerGroup outputAudioMixerGroup
		{
			get
			{
				IntPtr intPtr = AudioSource.get_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				AudioSource.set_outputAudioMixerGroupDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002438 File Offset: 0x00000638
		public void Play(ulong delay)
		{
			AudioSource.PlayHelper(this, delay);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002443 File Offset: 0x00000643
		public void PlayDelayed(float delay)
		{
			this.Play((delay < 0f) ? 0.0 : (-(double)delay));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002463 File Offset: 0x00000663
		public void PlayScheduled(double time)
		{
			this.Play((time < 0.0) ? 0.0 : time);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002485 File Offset: 0x00000685
		public void SetScheduledStartTime(double time)
		{
			AudioSource.SetScheduledStartTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), time);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002498 File Offset: 0x00000698
		public void SetScheduledEndTime(double time)
		{
			AudioSource.SetScheduledEndTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), time);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000024AB File Offset: 0x000006AB
		public void Pause()
		{
			AudioSource.PauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000024BD File Offset: 0x000006BD
		public void UnPause()
		{
			AudioSource.UnPauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000024CF File Offset: 0x000006CF
		public bool isVirtual
		{
			get
			{
				return AudioSource.get_isVirtualDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000024E1 File Offset: 0x000006E1
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
			AudioSource.PlayClipAtPoint(clip, position, 1f);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume)
		{
			GameObject gameObject = new GameObject("One shot audio");
			gameObject.transform.position = position;
			AudioSource audioSource = gameObject.AddComponent(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AudioSource>())).Cast<AudioSource>();
			audioSource.clip = clip;
			audioSource.spatialBlend = 1f;
			audioSource.volume = volume;
			audioSource.Play();
			Object.Destroy(gameObject, clip.length * ((Time.timeScale < 0.01f) ? 0.01f : Time.timeScale));
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x000024F1 File Offset: 0x000006F1
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002503 File Offset: 0x00000703
		public bool loop
		{
			get
			{
				return AudioSource.get_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_loopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000253A File Offset: 0x0000073A
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000254C File Offset: 0x0000074C
		public bool ignoreListenerPause
		{
			get
			{
				return AudioSource.get_ignoreListenerPauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_ignoreListenerPauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000255F File Offset: 0x0000075F
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002571 File Offset: 0x00000771
		public AudioVelocityUpdateMode velocityUpdateMode
		{
			get
			{
				return AudioSource.get_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_velocityUpdateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002584 File Offset: 0x00000784
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002596 File Offset: 0x00000796
		public float panStereo
		{
			get
			{
				return AudioSource.get_panStereoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_panStereoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000025A9 File Offset: 0x000007A9
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000025BB File Offset: 0x000007BB
		public float spatialBlend
		{
			get
			{
				return AudioSource.get_spatialBlendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_spatialBlendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000025CE File Offset: 0x000007CE
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000025E0 File Offset: 0x000007E0
		public bool spatialize
		{
			get
			{
				return AudioSource.get_spatializeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_spatializeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000025F3 File Offset: 0x000007F3
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002605 File Offset: 0x00000805
		public bool spatializePostEffects
		{
			get
			{
				return AudioSource.get_spatializePostEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_spatializePostEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002618 File Offset: 0x00000818
		public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve)
		{
			AudioSource.SetCustomCurveHelper(this, type, curve);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004C6C File Offset: 0x00002E6C
		public AnimationCurve GetCustomCurve(AudioSourceCurveType type)
		{
			return AudioSource.GetCustomCurveHelper(this, type);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002636 File Offset: 0x00000836
		public float reverbZoneMix
		{
			get
			{
				return AudioSource.get_reverbZoneMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_reverbZoneMixDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002649 File Offset: 0x00000849
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000265B File Offset: 0x0000085B
		public bool bypassEffects
		{
			get
			{
				return AudioSource.get_bypassEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_bypassEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000266E File Offset: 0x0000086E
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002680 File Offset: 0x00000880
		public bool bypassListenerEffects
		{
			get
			{
				return AudioSource.get_bypassListenerEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_bypassListenerEffectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002693 File Offset: 0x00000893
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000026A5 File Offset: 0x000008A5
		public bool bypassReverbZones
		{
			get
			{
				return AudioSource.get_bypassReverbZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_bypassReverbZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000026CA File Offset: 0x000008CA
		public float dopplerLevel
		{
			get
			{
				return AudioSource.get_dopplerLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_dopplerLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000026DD File Offset: 0x000008DD
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000026EF File Offset: 0x000008EF
		public float spread
		{
			get
			{
				return AudioSource.get_spreadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_spreadDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002702 File Offset: 0x00000902
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002714 File Offset: 0x00000914
		public int priority
		{
			get
			{
				return AudioSource.get_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_priorityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002727 File Offset: 0x00000927
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002739 File Offset: 0x00000939
		public bool mute
		{
			get
			{
				return AudioSource.get_muteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_muteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000274C File Offset: 0x0000094C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x0000275E File Offset: 0x0000095E
		public float minDistance
		{
			get
			{
				return AudioSource.get_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_minDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002771 File Offset: 0x00000971
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002783 File Offset: 0x00000983
		public float maxDistance
		{
			get
			{
				return AudioSource.get_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_maxDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002796 File Offset: 0x00000996
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000027A8 File Offset: 0x000009A8
		public AudioRolloffMode rolloffMode
		{
			get
			{
				return AudioSource.get_rolloffModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AudioSource.set_rolloffModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000027BB File Offset: 0x000009BB
		public Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000027C8 File Offset: 0x000009C8
		public void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			AudioSource.GetOutputDataHelper(this, samples, channel);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000027D4 File Offset: 0x000009D4
		public Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000027E1 File Offset: 0x000009E1
		public void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			AudioSource.GetSpectrumDataHelper(this, samples, channel, window);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004C88 File Offset: 0x00002E88
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000027EE File Offset: 0x000009EE
		public float minVolume
		{
			get
			{
				Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("minVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004CAC File Offset: 0x00002EAC
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000027FC File Offset: 0x000009FC
		public float maxVolume
		{
			get
			{
				Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("maxVolume is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00004CD0 File Offset: 0x00002ED0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000280A File Offset: 0x00000A0A
		public float rolloffFactor
		{
			get
			{
				Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
				return 0f;
			}
			set
			{
				Debug.LogError("rolloffFactor is not supported anymore. Use min-, maxDistance and rolloffMode instead.");
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002818 File Offset: 0x00000A18
		public bool SetSpatializerFloat(int index, float value)
		{
			return AudioSource.SetSpatializerFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000282C File Offset: 0x00000A2C
		public bool GetSpatializerFloat(int index, out float value)
		{
			return AudioSource.GetSpatializerFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out value);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002840 File Offset: 0x00000A40
		public bool GetAmbisonicDecoderFloat(int index, out float value)
		{
			return AudioSource.GetAmbisonicDecoderFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out value);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002854 File Offset: 0x00000A54
		public bool SetAmbisonicDecoderFloat(int index, float value)
		{
			return AudioSource.SetAmbisonicDecoderFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_get_Single_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

		// Token: 0x0400003C RID: 60
		private static readonly AudioSource.PlayDelegate PlayDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly AudioSource.SetCustomCurveHelperDelegate SetCustomCurveHelperDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly AudioSource.GetCustomCurveHelperDelegate GetCustomCurveHelperDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly AudioSource.GetOutputDataHelperDelegate GetOutputDataHelperDelegateField;

		// Token: 0x04000040 RID: 64
		private static readonly AudioSource.GetSpectrumDataHelperDelegate GetSpectrumDataHelperDelegateField;

		// Token: 0x04000041 RID: 65
		private static readonly AudioSource.get_timeDelegate get_timeDelegateField;

		// Token: 0x04000042 RID: 66
		private static readonly AudioSource.set_timeDelegate set_timeDelegateField;

		// Token: 0x04000043 RID: 67
		private static readonly AudioSource.get_timeSamplesDelegate get_timeSamplesDelegateField;

		// Token: 0x04000044 RID: 68
		private static readonly AudioSource.set_timeSamplesDelegate set_timeSamplesDelegateField;

		// Token: 0x04000045 RID: 69
		private static readonly AudioSource.get_outputAudioMixerGroupDelegate get_outputAudioMixerGroupDelegateField;

		// Token: 0x04000046 RID: 70
		private static readonly AudioSource.set_outputAudioMixerGroupDelegate set_outputAudioMixerGroupDelegateField;

		// Token: 0x04000047 RID: 71
		private static readonly AudioSource.SetScheduledStartTimeDelegate SetScheduledStartTimeDelegateField;

		// Token: 0x04000048 RID: 72
		private static readonly AudioSource.SetScheduledEndTimeDelegate SetScheduledEndTimeDelegateField;

		// Token: 0x04000049 RID: 73
		private static readonly AudioSource.PauseDelegate PauseDelegateField;

		// Token: 0x0400004A RID: 74
		private static readonly AudioSource.UnPauseDelegate UnPauseDelegateField;

		// Token: 0x0400004B RID: 75
		private static readonly AudioSource.get_isVirtualDelegate get_isVirtualDelegateField;

		// Token: 0x0400004C RID: 76
		private static readonly AudioSource.get_loopDelegate get_loopDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly AudioSource.set_loopDelegate set_loopDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly AudioSource.get_ignoreListenerVolumeDelegate get_ignoreListenerVolumeDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly AudioSource.get_playOnAwakeDelegate get_playOnAwakeDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly AudioSource.get_ignoreListenerPauseDelegate get_ignoreListenerPauseDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly AudioSource.set_ignoreListenerPauseDelegate set_ignoreListenerPauseDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly AudioSource.get_velocityUpdateModeDelegate get_velocityUpdateModeDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly AudioSource.set_velocityUpdateModeDelegate set_velocityUpdateModeDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly AudioSource.get_panStereoDelegate get_panStereoDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly AudioSource.set_panStereoDelegate set_panStereoDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly AudioSource.get_spatialBlendDelegate get_spatialBlendDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly AudioSource.set_spatialBlendDelegate set_spatialBlendDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly AudioSource.get_spatializeDelegate get_spatializeDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly AudioSource.set_spatializeDelegate set_spatializeDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly AudioSource.get_spatializePostEffectsDelegate get_spatializePostEffectsDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly AudioSource.set_spatializePostEffectsDelegate set_spatializePostEffectsDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly AudioSource.get_reverbZoneMixDelegate get_reverbZoneMixDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly AudioSource.set_reverbZoneMixDelegate set_reverbZoneMixDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly AudioSource.get_bypassEffectsDelegate get_bypassEffectsDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly AudioSource.set_bypassEffectsDelegate set_bypassEffectsDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly AudioSource.get_bypassListenerEffectsDelegate get_bypassListenerEffectsDelegateField;

		// Token: 0x04000061 RID: 97
		private static readonly AudioSource.set_bypassListenerEffectsDelegate set_bypassListenerEffectsDelegateField;

		// Token: 0x04000062 RID: 98
		private static readonly AudioSource.get_bypassReverbZonesDelegate get_bypassReverbZonesDelegateField;

		// Token: 0x04000063 RID: 99
		private static readonly AudioSource.set_bypassReverbZonesDelegate set_bypassReverbZonesDelegateField;

		// Token: 0x04000064 RID: 100
		private static readonly AudioSource.get_dopplerLevelDelegate get_dopplerLevelDelegateField;

		// Token: 0x04000065 RID: 101
		private static readonly AudioSource.set_dopplerLevelDelegate set_dopplerLevelDelegateField;

		// Token: 0x04000066 RID: 102
		private static readonly AudioSource.get_spreadDelegate get_spreadDelegateField;

		// Token: 0x04000067 RID: 103
		private static readonly AudioSource.set_spreadDelegate set_spreadDelegateField;

		// Token: 0x04000068 RID: 104
		private static readonly AudioSource.get_priorityDelegate get_priorityDelegateField;

		// Token: 0x04000069 RID: 105
		private static readonly AudioSource.set_priorityDelegate set_priorityDelegateField;

		// Token: 0x0400006A RID: 106
		private static readonly AudioSource.get_muteDelegate get_muteDelegateField;

		// Token: 0x0400006B RID: 107
		private static readonly AudioSource.set_muteDelegate set_muteDelegateField;

		// Token: 0x0400006C RID: 108
		private static readonly AudioSource.get_minDistanceDelegate get_minDistanceDelegateField;

		// Token: 0x0400006D RID: 109
		private static readonly AudioSource.set_minDistanceDelegate set_minDistanceDelegateField;

		// Token: 0x0400006E RID: 110
		private static readonly AudioSource.get_maxDistanceDelegate get_maxDistanceDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly AudioSource.set_maxDistanceDelegate set_maxDistanceDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly AudioSource.get_rolloffModeDelegate get_rolloffModeDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly AudioSource.set_rolloffModeDelegate set_rolloffModeDelegateField;

		// Token: 0x04000072 RID: 114
		private static readonly AudioSource.SetSpatializerFloatDelegate SetSpatializerFloatDelegateField;

		// Token: 0x04000073 RID: 115
		private static readonly AudioSource.GetSpatializerFloatDelegate GetSpatializerFloatDelegateField;

		// Token: 0x04000074 RID: 116
		private static readonly AudioSource.GetAmbisonicDecoderFloatDelegate GetAmbisonicDecoderFloatDelegateField;

		// Token: 0x04000075 RID: 117
		private static readonly AudioSource.SetAmbisonicDecoderFloatDelegate SetAmbisonicDecoderFloatDelegateField;

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x0600024D RID: 589
		private delegate void PlayDelegate(IntPtr @this, double delay);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600024F RID: 591
		private delegate void SetCustomCurveHelperDelegate(IntPtr source, AudioSourceCurveType type, IntPtr curve);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000251 RID: 593
		private delegate IntPtr GetCustomCurveHelperDelegate(IntPtr source, AudioSourceCurveType type);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000253 RID: 595
		private delegate void GetOutputDataHelperDelegate(IntPtr source, [Out] IntPtr samples, int channel);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000255 RID: 597
		private delegate void GetSpectrumDataHelperDelegate(IntPtr source, [Out] IntPtr samples, int channel, FFTWindow window);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000257 RID: 599
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000259 RID: 601
		private delegate void set_timeDelegate(IntPtr @this, float value);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x0600025B RID: 603
		private delegate int get_timeSamplesDelegate(IntPtr @this);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x0600025D RID: 605
		private delegate void set_timeSamplesDelegate(IntPtr @this, int value);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x0600025F RID: 607
		private delegate IntPtr get_outputAudioMixerGroupDelegate(IntPtr @this);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate void set_outputAudioMixerGroupDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void SetScheduledStartTimeDelegate(IntPtr @this, double time);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate void SetScheduledEndTimeDelegate(IntPtr @this, double time);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate void PauseDelegate(IntPtr @this);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate void UnPauseDelegate(IntPtr @this);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate bool get_isVirtualDelegate(IntPtr @this);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate bool get_loopDelegate(IntPtr @this);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate void set_loopDelegate(IntPtr @this, bool value);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate bool get_ignoreListenerVolumeDelegate(IntPtr @this);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate bool get_playOnAwakeDelegate(IntPtr @this);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate bool get_ignoreListenerPauseDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate void set_ignoreListenerPauseDelegate(IntPtr @this, bool value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate AudioVelocityUpdateMode get_velocityUpdateModeDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate void set_velocityUpdateModeDelegate(IntPtr @this, AudioVelocityUpdateMode value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate float get_panStereoDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x0600027F RID: 639
		private delegate void set_panStereoDelegate(IntPtr @this, float value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000281 RID: 641
		private delegate float get_spatialBlendDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000283 RID: 643
		private delegate void set_spatialBlendDelegate(IntPtr @this, float value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x06000285 RID: 645
		private delegate bool get_spatializeDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x06000287 RID: 647
		private delegate void set_spatializeDelegate(IntPtr @this, bool value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000289 RID: 649
		private delegate bool get_spatializePostEffectsDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x0600028B RID: 651
		private delegate void set_spatializePostEffectsDelegate(IntPtr @this, bool value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x0600028D RID: 653
		private delegate float get_reverbZoneMixDelegate(IntPtr @this);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x0600028F RID: 655
		private delegate void set_reverbZoneMixDelegate(IntPtr @this, float value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000291 RID: 657
		private delegate bool get_bypassEffectsDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000293 RID: 659
		private delegate void set_bypassEffectsDelegate(IntPtr @this, bool value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x06000295 RID: 661
		private delegate bool get_bypassListenerEffectsDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000297 RID: 663
		private delegate void set_bypassListenerEffectsDelegate(IntPtr @this, bool value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000299 RID: 665
		private delegate bool get_bypassReverbZonesDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x0600029B RID: 667
		private delegate void set_bypassReverbZonesDelegate(IntPtr @this, bool value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x0600029D RID: 669
		private delegate float get_dopplerLevelDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x0600029F RID: 671
		private delegate void set_dopplerLevelDelegate(IntPtr @this, float value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x060002A1 RID: 673
		private delegate float get_spreadDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x060002A3 RID: 675
		private delegate void set_spreadDelegate(IntPtr @this, float value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x060002A5 RID: 677
		private delegate int get_priorityDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x060002A7 RID: 679
		private delegate void set_priorityDelegate(IntPtr @this, int value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060002A9 RID: 681
		private delegate bool get_muteDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002AB RID: 683
		private delegate void set_muteDelegate(IntPtr @this, bool value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002AD RID: 685
		private delegate float get_minDistanceDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002AF RID: 687
		private delegate void set_minDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002B1 RID: 689
		private delegate float get_maxDistanceDelegate(IntPtr @this);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060002B3 RID: 691
		private delegate void set_maxDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060002B5 RID: 693
		private delegate AudioRolloffMode get_rolloffModeDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060002B7 RID: 695
		private delegate void set_rolloffModeDelegate(IntPtr @this, AudioRolloffMode value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002B9 RID: 697
		private delegate bool SetSpatializerFloatDelegate(IntPtr @this, int index, float value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060002BB RID: 699
		private delegate bool GetSpatializerFloatDelegate(IntPtr @this, int index, [Out] IntPtr value);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x060002BD RID: 701
		private delegate bool GetAmbisonicDecoderFloatDelegate(IntPtr @this, int index, [Out] IntPtr value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x060002BF RID: 703
		private delegate bool SetAmbisonicDecoderFloatDelegate(IntPtr @this, int index, float value);
	}
}
