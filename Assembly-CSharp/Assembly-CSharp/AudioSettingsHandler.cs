using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200009B RID: 155
public class AudioSettingsHandler : MonoBehaviour
{
	// Token: 0x0600126F RID: 4719 RVA: 0x000518C8 File Offset: 0x0004FAC8
	// Note: this type is marked as 'beforefieldinit'.
	static AudioSettingsHandler()
	{
		Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AudioSettingsHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr);
		AudioSettingsHandler.NativeFieldInfoPtr_m_musicList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_musicList");
		AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_soundEffectList");
		AudioSettingsHandler.NativeFieldInfoPtr_m_musicSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_musicSource");
		AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_soundEffectToggle");
		AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_currentAudio");
		AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudioIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, "m_currentAudioIndex");
		AudioSettingsHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664735);
		AudioSettingsHandler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664736);
		AudioSettingsHandler.NativeMethodInfoPtr_PlayThemeMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664737);
		AudioSettingsHandler.NativeMethodInfoPtr_PlayEndGameMusic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664738);
		AudioSettingsHandler.NativeMethodInfoPtr_SetMusicVolume_Public_Void_Slider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664739);
		AudioSettingsHandler.NativeMethodInfoPtr_SetEffectsVolume_Public_Void_Slider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664740);
		AudioSettingsHandler.NativeMethodInfoPtr_RetrieveAudioSliderSettings_Public_Void_Slider_Slider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664741);
		AudioSettingsHandler.NativeMethodInfoPtr_StoreAudioSliderSettings_Public_Void_Slider_Slider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664742);
		AudioSettingsHandler.NativeMethodInfoPtr_DisableSoundEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664743);
		AudioSettingsHandler.NativeMethodInfoPtr_EnableSoundEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664744);
		AudioSettingsHandler.NativeMethodInfoPtr_DisableToggleSoundEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664745);
		AudioSettingsHandler.NativeMethodInfoPtr_EnableToggleSoundEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664746);
		AudioSettingsHandler.NativeMethodInfoPtr_StopAllMusic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664747);
		AudioSettingsHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr, 100664748);
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x00051A88 File Offset: 0x0004FC88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243427, XrefRangeEnd = 243471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x00051ABC File Offset: 0x0004FCBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243471, XrefRangeEnd = 243476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x00051AF0 File Offset: 0x0004FCF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243491, RefRangeEnd = 243492, XrefRangeStart = 243476, XrefRangeEnd = 243491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayThemeMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_PlayThemeMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x00051B24 File Offset: 0x0004FD24
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayEndGameMusic(bool bWinner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bWinner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_PlayEndGameMusic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00051B64 File Offset: 0x0004FD64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243492, XrefRangeEnd = 243503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMusicVolume(Slider slider, bool bStoreAnalytics)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bStoreAnalytics;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_SetMusicVolume_Public_Void_Slider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00051BB4 File Offset: 0x0004FDB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243503, XrefRangeEnd = 243514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEffectsVolume(Slider slider, bool bStoreAnalytics)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bStoreAnalytics;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_SetEffectsVolume_Public_Void_Slider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00051C04 File Offset: 0x0004FE04
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243521, RefRangeEnd = 243522, XrefRangeStart = 243514, XrefRangeEnd = 243521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveAudioSliderSettings(Slider musicSlider, Slider effectsSlider)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(musicSlider);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectsSlider);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_RetrieveAudioSliderSettings_Public_Void_Slider_Slider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00051C58 File Offset: 0x0004FE58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 243544, RefRangeEnd = 243546, XrefRangeStart = 243522, XrefRangeEnd = 243544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreAudioSliderSettings(Slider musicSlider, Slider effectsSlider, bool bStoreAnalytics)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(musicSlider);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectsSlider);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bStoreAnalytics;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_StoreAudioSliderSettings_Public_Void_Slider_Slider_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00051CBC File Offset: 0x0004FEBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243546, XrefRangeEnd = 243548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableSoundEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_DisableSoundEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00051CF0 File Offset: 0x0004FEF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243548, XrefRangeEnd = 243550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableSoundEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_EnableSoundEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x00051D24 File Offset: 0x0004FF24
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 243555, RefRangeEnd = 243562, XrefRangeStart = 243550, XrefRangeEnd = 243555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableToggleSoundEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_DisableToggleSoundEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00051D58 File Offset: 0x0004FF58
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 243567, RefRangeEnd = 243574, XrefRangeStart = 243562, XrefRangeEnd = 243567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableToggleSoundEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_EnableToggleSoundEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00051D8C File Offset: 0x0004FF8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243575, RefRangeEnd = 243576, XrefRangeStart = 243574, XrefRangeEnd = 243575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopAllMusic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr_StopAllMusic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00051DC0 File Offset: 0x0004FFC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243576, XrefRangeEnd = 243577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioSettingsHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettingsHandler>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettingsHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x0000C454 File Offset: 0x0000A654
	public AudioSettingsHandler(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005EA RID: 1514
	// (get) Token: 0x0600127F RID: 4735 RVA: 0x00051DFC File Offset: 0x0004FFFC
	// (set) Token: 0x06001280 RID: 4736 RVA: 0x0000C45D File Offset: 0x0000A65D
	public unsafe Il2CppStringArray m_musicList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_musicList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_musicList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x06001281 RID: 4737 RVA: 0x00051E2C File Offset: 0x0005002C
	// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000C47C File Offset: 0x0000A67C
	public unsafe Il2CppReferenceArray<AudioSource> m_soundEffectList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EC RID: 1516
	// (get) Token: 0x06001283 RID: 4739 RVA: 0x00051E5C File Offset: 0x0005005C
	// (set) Token: 0x06001284 RID: 4740 RVA: 0x0000C49B File Offset: 0x0000A69B
	public unsafe AudioSource m_musicSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_musicSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_musicSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005ED RID: 1517
	// (get) Token: 0x06001285 RID: 4741 RVA: 0x00051E8C File Offset: 0x0005008C
	// (set) Token: 0x06001286 RID: 4742 RVA: 0x0000C4BA File Offset: 0x0000A6BA
	public unsafe AudioSource m_soundEffectToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_soundEffectToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EE RID: 1518
	// (get) Token: 0x06001287 RID: 4743 RVA: 0x00051EBC File Offset: 0x000500BC
	// (set) Token: 0x06001288 RID: 4744 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
	public unsafe AudioClip m_currentAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005EF RID: 1519
	// (get) Token: 0x06001289 RID: 4745 RVA: 0x00051EEC File Offset: 0x000500EC
	// (set) Token: 0x0600128A RID: 4746 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
	public unsafe int m_currentAudioIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudioIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettingsHandler.NativeFieldInfoPtr_m_currentAudioIndex)) = value;
		}
	}

	// Token: 0x04000CE5 RID: 3301
	private static readonly IntPtr NativeFieldInfoPtr_m_musicList;

	// Token: 0x04000CE6 RID: 3302
	private static readonly IntPtr NativeFieldInfoPtr_m_soundEffectList;

	// Token: 0x04000CE7 RID: 3303
	private static readonly IntPtr NativeFieldInfoPtr_m_musicSource;

	// Token: 0x04000CE8 RID: 3304
	private static readonly IntPtr NativeFieldInfoPtr_m_soundEffectToggle;

	// Token: 0x04000CE9 RID: 3305
	private static readonly IntPtr NativeFieldInfoPtr_m_currentAudio;

	// Token: 0x04000CEA RID: 3306
	private static readonly IntPtr NativeFieldInfoPtr_m_currentAudioIndex;

	// Token: 0x04000CEB RID: 3307
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000CEC RID: 3308
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000CED RID: 3309
	private static readonly IntPtr NativeMethodInfoPtr_PlayThemeMusic_Public_Void_0;

	// Token: 0x04000CEE RID: 3310
	private static readonly IntPtr NativeMethodInfoPtr_PlayEndGameMusic_Public_Void_Boolean_0;

	// Token: 0x04000CEF RID: 3311
	private static readonly IntPtr NativeMethodInfoPtr_SetMusicVolume_Public_Void_Slider_Boolean_0;

	// Token: 0x04000CF0 RID: 3312
	private static readonly IntPtr NativeMethodInfoPtr_SetEffectsVolume_Public_Void_Slider_Boolean_0;

	// Token: 0x04000CF1 RID: 3313
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveAudioSliderSettings_Public_Void_Slider_Slider_0;

	// Token: 0x04000CF2 RID: 3314
	private static readonly IntPtr NativeMethodInfoPtr_StoreAudioSliderSettings_Public_Void_Slider_Slider_Boolean_0;

	// Token: 0x04000CF3 RID: 3315
	private static readonly IntPtr NativeMethodInfoPtr_DisableSoundEffects_Public_Void_0;

	// Token: 0x04000CF4 RID: 3316
	private static readonly IntPtr NativeMethodInfoPtr_EnableSoundEffects_Public_Void_0;

	// Token: 0x04000CF5 RID: 3317
	private static readonly IntPtr NativeMethodInfoPtr_DisableToggleSoundEffects_Public_Void_0;

	// Token: 0x04000CF6 RID: 3318
	private static readonly IntPtr NativeMethodInfoPtr_EnableToggleSoundEffects_Public_Void_0;

	// Token: 0x04000CF7 RID: 3319
	private static readonly IntPtr NativeMethodInfoPtr_StopAllMusic_Public_Void_0;

	// Token: 0x04000CF8 RID: 3320
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
