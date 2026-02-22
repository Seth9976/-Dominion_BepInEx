using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B4 RID: 180
public class UIP_AchievementSlot : MonoBehaviour
{
	// Token: 0x06001546 RID: 5446 RVA: 0x0005AA38 File Offset: 0x00058C38
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_AchievementSlot()
	{
		Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_AchievementSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr);
		UIP_AchievementSlot.NativeFieldInfoPtr_m_colorIncomplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_colorIncomplete");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_colorComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_colorComplete");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageIncomplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_displayImageIncomplete");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_displayImageComplete");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_progresSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_progresSlider");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_sliderBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_sliderBase");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_checkmark");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_valueNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_valueNode");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_titleText");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_descText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_descText");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_pointText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_pointText");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_progressText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_progressText");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_lockedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_lockedSprite");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_colorizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_colorizer");
		UIP_AchievementSlot.NativeFieldInfoPtr_m_setIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, "m_setIndex");
		UIP_AchievementSlot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665014);
		UIP_AchievementSlot.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665015);
		UIP_AchievementSlot.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665016);
		UIP_AchievementSlot.NativeMethodInfoPtr_Init_Public_Void_AchievementData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665017);
		UIP_AchievementSlot.NativeMethodInfoPtr_SetIsVisible_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665018);
		UIP_AchievementSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr, 100665019);
	}

	// Token: 0x06001547 RID: 5447 RVA: 0x0005AC0C File Offset: 0x00058E0C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x0005AC40 File Offset: 0x00058E40
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001549 RID: 5449 RVA: 0x0005AC74 File Offset: 0x00058E74
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x0005ACA8 File Offset: 0x00058EA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247000, RefRangeEnd = 247001, XrefRangeStart = 246983, XrefRangeEnd = 247000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(AchievementData achievement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(achievement));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr_Init_Public_Void_AchievementData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600154B RID: 5451 RVA: 0x0005ACF0 File Offset: 0x00058EF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247001, XrefRangeEnd = 247005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsVisible(uint activeSetIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref activeSetIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr_SetIsVisible_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x0005AD30 File Offset: 0x00058F30
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_AchievementSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_AchievementSlot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_AchievementSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x0000DC07 File Offset: 0x0000BE07
	public UIP_AchievementSlot(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006B8 RID: 1720
	// (get) Token: 0x0600154E RID: 5454 RVA: 0x0005AD6C File Offset: 0x00058F6C
	// (set) Token: 0x0600154F RID: 5455 RVA: 0x0000DC10 File Offset: 0x0000BE10
	public unsafe Color m_colorIncomplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorIncomplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorIncomplete)) = value;
		}
	}

	// Token: 0x170006B9 RID: 1721
	// (get) Token: 0x06001550 RID: 5456 RVA: 0x0005AD94 File Offset: 0x00058F94
	// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000DC2B File Offset: 0x0000BE2B
	public unsafe Color m_colorComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorComplete);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorComplete)) = value;
		}
	}

	// Token: 0x170006BA RID: 1722
	// (get) Token: 0x06001552 RID: 5458 RVA: 0x0005ADBC File Offset: 0x00058FBC
	// (set) Token: 0x06001553 RID: 5459 RVA: 0x0000DC46 File Offset: 0x0000BE46
	public unsafe Image m_displayImageIncomplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageIncomplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageIncomplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BB RID: 1723
	// (get) Token: 0x06001554 RID: 5460 RVA: 0x0005ADEC File Offset: 0x00058FEC
	// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000DC65 File Offset: 0x0000BE65
	public unsafe Image m_displayImageComplete
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageComplete);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_displayImageComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BC RID: 1724
	// (get) Token: 0x06001556 RID: 5462 RVA: 0x0005AE1C File Offset: 0x0005901C
	// (set) Token: 0x06001557 RID: 5463 RVA: 0x0000DC84 File Offset: 0x0000BE84
	public unsafe Image m_progresSlider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_progresSlider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_progresSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BD RID: 1725
	// (get) Token: 0x06001558 RID: 5464 RVA: 0x0005AE4C File Offset: 0x0005904C
	// (set) Token: 0x06001559 RID: 5465 RVA: 0x0000DCA3 File Offset: 0x0000BEA3
	public unsafe GameObject m_sliderBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_sliderBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_sliderBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BE RID: 1726
	// (get) Token: 0x0600155A RID: 5466 RVA: 0x0005AE7C File Offset: 0x0005907C
	// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000DCC2 File Offset: 0x0000BEC2
	public unsafe GameObject m_checkmark
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_checkmark);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x0600155C RID: 5468 RVA: 0x0005AEAC File Offset: 0x000590AC
	// (set) Token: 0x0600155D RID: 5469 RVA: 0x0000DCE1 File Offset: 0x0000BEE1
	public unsafe GameObject m_valueNode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_valueNode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_valueNode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x0600155E RID: 5470 RVA: 0x0005AEDC File Offset: 0x000590DC
	// (set) Token: 0x0600155F RID: 5471 RVA: 0x0000DD00 File Offset: 0x0000BF00
	public unsafe TextMeshProUGUI m_titleText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_titleText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C1 RID: 1729
	// (get) Token: 0x06001560 RID: 5472 RVA: 0x0005AF0C File Offset: 0x0005910C
	// (set) Token: 0x06001561 RID: 5473 RVA: 0x0000DD1F File Offset: 0x0000BF1F
	public unsafe TextMeshProUGUI m_descText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_descText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_descText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C2 RID: 1730
	// (get) Token: 0x06001562 RID: 5474 RVA: 0x0005AF3C File Offset: 0x0005913C
	// (set) Token: 0x06001563 RID: 5475 RVA: 0x0000DD3E File Offset: 0x0000BF3E
	public unsafe TextMeshProUGUI m_pointText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_pointText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_pointText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C3 RID: 1731
	// (get) Token: 0x06001564 RID: 5476 RVA: 0x0005AF6C File Offset: 0x0005916C
	// (set) Token: 0x06001565 RID: 5477 RVA: 0x0000DD5D File Offset: 0x0000BF5D
	public unsafe TextMeshProUGUI m_progressText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_progressText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_progressText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C4 RID: 1732
	// (get) Token: 0x06001566 RID: 5478 RVA: 0x0005AF9C File Offset: 0x0005919C
	// (set) Token: 0x06001567 RID: 5479 RVA: 0x0000DD7C File Offset: 0x0000BF7C
	public unsafe GameObject m_lockedSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_lockedSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_lockedSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C5 RID: 1733
	// (get) Token: 0x06001568 RID: 5480 RVA: 0x0005AFCC File Offset: 0x000591CC
	// (set) Token: 0x06001569 RID: 5481 RVA: 0x0000DD9B File Offset: 0x0000BF9B
	public unsafe ColorByFaction m_colorizer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorizer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorByFaction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_colorizer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006C6 RID: 1734
	// (get) Token: 0x0600156A RID: 5482 RVA: 0x0005AFFC File Offset: 0x000591FC
	// (set) Token: 0x0600156B RID: 5483 RVA: 0x0000DDBA File Offset: 0x0000BFBA
	public unsafe uint m_setIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_setIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_AchievementSlot.NativeFieldInfoPtr_m_setIndex)) = value;
		}
	}

	// Token: 0x04000EC6 RID: 3782
	private static readonly IntPtr NativeFieldInfoPtr_m_colorIncomplete;

	// Token: 0x04000EC7 RID: 3783
	private static readonly IntPtr NativeFieldInfoPtr_m_colorComplete;

	// Token: 0x04000EC8 RID: 3784
	private static readonly IntPtr NativeFieldInfoPtr_m_displayImageIncomplete;

	// Token: 0x04000EC9 RID: 3785
	private static readonly IntPtr NativeFieldInfoPtr_m_displayImageComplete;

	// Token: 0x04000ECA RID: 3786
	private static readonly IntPtr NativeFieldInfoPtr_m_progresSlider;

	// Token: 0x04000ECB RID: 3787
	private static readonly IntPtr NativeFieldInfoPtr_m_sliderBase;

	// Token: 0x04000ECC RID: 3788
	private static readonly IntPtr NativeFieldInfoPtr_m_checkmark;

	// Token: 0x04000ECD RID: 3789
	private static readonly IntPtr NativeFieldInfoPtr_m_valueNode;

	// Token: 0x04000ECE RID: 3790
	private static readonly IntPtr NativeFieldInfoPtr_m_titleText;

	// Token: 0x04000ECF RID: 3791
	private static readonly IntPtr NativeFieldInfoPtr_m_descText;

	// Token: 0x04000ED0 RID: 3792
	private static readonly IntPtr NativeFieldInfoPtr_m_pointText;

	// Token: 0x04000ED1 RID: 3793
	private static readonly IntPtr NativeFieldInfoPtr_m_progressText;

	// Token: 0x04000ED2 RID: 3794
	private static readonly IntPtr NativeFieldInfoPtr_m_lockedSprite;

	// Token: 0x04000ED3 RID: 3795
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizer;

	// Token: 0x04000ED4 RID: 3796
	private static readonly IntPtr NativeFieldInfoPtr_m_setIndex;

	// Token: 0x04000ED5 RID: 3797
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000ED6 RID: 3798
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000ED7 RID: 3799
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000ED8 RID: 3800
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AchievementData_0;

	// Token: 0x04000ED9 RID: 3801
	private static readonly IntPtr NativeMethodInfoPtr_SetIsVisible_Public_Void_UInt32_0;

	// Token: 0x04000EDA RID: 3802
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
