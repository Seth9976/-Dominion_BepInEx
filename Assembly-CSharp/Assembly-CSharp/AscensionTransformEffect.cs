using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class AscensionTransformEffect : MonoBehaviour
{
	// Token: 0x060008B3 RID: 2227 RVA: 0x000338A8 File Offset: 0x00031AA8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionTransformEffect()
	{
		Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionTransformEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr);
		AscensionTransformEffect.NativeFieldInfoPtr_m_TransformEffectRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_TransformEffectRoot");
		AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorResolveEffectStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_LocatorResolveEffectStack");
		AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPreTransformCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_LocatorPreTransformCard");
		AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPostTransformCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_LocatorPostTransformCard");
		AscensionTransformEffect.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_CardManager");
		AscensionTransformEffect.NativeFieldInfoPtr_m_AudioHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_AudioHandler");
		AscensionTransformEffect.NativeFieldInfoPtr_m_PreTransformCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_PreTransformCard");
		AscensionTransformEffect.NativeFieldInfoPtr_m_PostTransformCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, "m_PostTransformCard");
		AscensionTransformEffect.NativeMethodInfoPtr_IsInProgress_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663879);
		AscensionTransformEffect.NativeMethodInfoPtr_PlayTransformEffect_Public_Void_AscensionCard_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663880);
		AscensionTransformEffect.NativeMethodInfoPtr_CheckLoadComplete_Private_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663881);
		AscensionTransformEffect.NativeMethodInfoPtr_StartEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663882);
		AscensionTransformEffect.NativeMethodInfoPtr_EndEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663883);
		AscensionTransformEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr, 100663884);
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x000339F0 File Offset: 0x00031BF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235188, RefRangeEnd = 235189, XrefRangeStart = 235184, XrefRangeEnd = 235188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInProgress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr_IsInProgress_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00033A2C File Offset: 0x00031C2C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235203, RefRangeEnd = 235204, XrefRangeStart = 235189, XrefRangeEnd = 235203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayTransformEffect(AscensionCard pre_transform_card, AscensionCard post_transform_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pre_transform_card);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(post_transform_card);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr_PlayTransformEffect_Public_Void_AscensionCard_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00033A80 File Offset: 0x00031C80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235204, XrefRangeEnd = 235210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckLoadComplete(ResourceEntry resourceEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceEntry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr_CheckLoadComplete_Private_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00033AC4 File Offset: 0x00031CC4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 235269, RefRangeEnd = 235271, XrefRangeStart = 235210, XrefRangeEnd = 235269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr_StartEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00033AF8 File Offset: 0x00031CF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235298, RefRangeEnd = 235299, XrefRangeStart = 235271, XrefRangeEnd = 235298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr_EndEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00033B2C File Offset: 0x00031D2C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionTransformEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionTransformEffect>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionTransformEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x000076C8 File Offset: 0x000058C8
	public AscensionTransformEffect(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x060008BB RID: 2235 RVA: 0x00033B68 File Offset: 0x00031D68
	// (set) Token: 0x060008BC RID: 2236 RVA: 0x000076D1 File Offset: 0x000058D1
	public unsafe GameObject m_TransformEffectRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_TransformEffectRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_TransformEffectRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x060008BD RID: 2237 RVA: 0x00033B98 File Offset: 0x00031D98
	// (set) Token: 0x060008BE RID: 2238 RVA: 0x000076F0 File Offset: 0x000058F0
	public unsafe AscensionAnimationLocator m_LocatorResolveEffectStack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorResolveEffectStack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorResolveEffectStack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x060008BF RID: 2239 RVA: 0x00033BC8 File Offset: 0x00031DC8
	// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0000770F File Offset: 0x0000590F
	public unsafe AscensionAnimationLocator m_LocatorPreTransformCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPreTransformCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPreTransformCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00033BF8 File Offset: 0x00031DF8
	// (set) Token: 0x060008C2 RID: 2242 RVA: 0x0000772E File Offset: 0x0000592E
	public unsafe AscensionAnimationLocator m_LocatorPostTransformCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPostTransformCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_LocatorPostTransformCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00033C28 File Offset: 0x00031E28
	// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0000774D File Offset: 0x0000594D
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00033C58 File Offset: 0x00031E58
	// (set) Token: 0x060008C6 RID: 2246 RVA: 0x0000776C File Offset: 0x0000596C
	public unsafe AscensionAudioHandlerIngame m_AudioHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_AudioHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAudioHandlerIngame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_AudioHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00033C88 File Offset: 0x00031E88
	// (set) Token: 0x060008C8 RID: 2248 RVA: 0x0000778B File Offset: 0x0000598B
	public unsafe AscensionCard m_PreTransformCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_PreTransformCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_PreTransformCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00033CB8 File Offset: 0x00031EB8
	// (set) Token: 0x060008CA RID: 2250 RVA: 0x000077AA File Offset: 0x000059AA
	public unsafe AscensionCard m_PostTransformCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_PostTransformCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionTransformEffect.NativeFieldInfoPtr_m_PostTransformCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400056D RID: 1389
	private static readonly IntPtr NativeFieldInfoPtr_m_TransformEffectRoot;

	// Token: 0x0400056E RID: 1390
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorResolveEffectStack;

	// Token: 0x0400056F RID: 1391
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorPreTransformCard;

	// Token: 0x04000570 RID: 1392
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorPostTransformCard;

	// Token: 0x04000571 RID: 1393
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000572 RID: 1394
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioHandler;

	// Token: 0x04000573 RID: 1395
	private static readonly IntPtr NativeFieldInfoPtr_m_PreTransformCard;

	// Token: 0x04000574 RID: 1396
	private static readonly IntPtr NativeFieldInfoPtr_m_PostTransformCard;

	// Token: 0x04000575 RID: 1397
	private static readonly IntPtr NativeMethodInfoPtr_IsInProgress_Public_Boolean_0;

	// Token: 0x04000576 RID: 1398
	private static readonly IntPtr NativeMethodInfoPtr_PlayTransformEffect_Public_Void_AscensionCard_AscensionCard_0;

	// Token: 0x04000577 RID: 1399
	private static readonly IntPtr NativeMethodInfoPtr_CheckLoadComplete_Private_Void_ResourceEntry_0;

	// Token: 0x04000578 RID: 1400
	private static readonly IntPtr NativeMethodInfoPtr_StartEffect_Public_Void_0;

	// Token: 0x04000579 RID: 1401
	private static readonly IntPtr NativeMethodInfoPtr_EndEffect_Public_Void_0;

	// Token: 0x0400057A RID: 1402
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
