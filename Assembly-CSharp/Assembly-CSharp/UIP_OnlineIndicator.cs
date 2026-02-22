using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000B9 RID: 185
public class UIP_OnlineIndicator : MonoBehaviour
{
	// Token: 0x06001640 RID: 5696 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_OnlineIndicator()
	{
		Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_OnlineIndicator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr);
		UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, "m_IndicatorOnline");
		UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, "m_IndicatorOffline");
		UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorAway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, "m_IndicatorAway");
		UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, "m_IndicatorUnknown");
		UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorForfeit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, "m_IndicatorForfeit");
		UIP_OnlineIndicator.NativeMethodInfoPtr_SetIndicator_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, 100665075);
		UIP_OnlineIndicator.NativeMethodInfoPtr_SetIndicator_Public_Void_PlayerOnlineStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, 100665076);
		UIP_OnlineIndicator.NativeMethodInfoPtr_ShowForfeit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, 100665077);
		UIP_OnlineIndicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr, 100665078);
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x0005D594 File Offset: 0x0005B794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247685, XrefRangeEnd = 247691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIndicator(uint playerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_OnlineIndicator.NativeMethodInfoPtr_SetIndicator_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247691, XrefRangeEnd = 247696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIndicator(PlayerOnlineStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_OnlineIndicator.NativeMethodInfoPtr_SetIndicator_Public_Void_PlayerOnlineStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x0005D614 File Offset: 0x0005B814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247696, XrefRangeEnd = 247698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowForfeit(bool bShow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bShow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_OnlineIndicator.NativeMethodInfoPtr_ShowForfeit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x0005D654 File Offset: 0x0005B854
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_OnlineIndicator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_OnlineIndicator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_OnlineIndicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x0000E64F File Offset: 0x0000C84F
	public UIP_OnlineIndicator(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000712 RID: 1810
	// (get) Token: 0x06001646 RID: 5702 RVA: 0x0005D690 File Offset: 0x0005B890
	// (set) Token: 0x06001647 RID: 5703 RVA: 0x0000E658 File Offset: 0x0000C858
	public unsafe GameObject m_IndicatorOnline
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOnline);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOnline), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000713 RID: 1811
	// (get) Token: 0x06001648 RID: 5704 RVA: 0x0005D6C0 File Offset: 0x0005B8C0
	// (set) Token: 0x06001649 RID: 5705 RVA: 0x0000E677 File Offset: 0x0000C877
	public unsafe GameObject m_IndicatorOffline
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOffline);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorOffline), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000714 RID: 1812
	// (get) Token: 0x0600164A RID: 5706 RVA: 0x0005D6F0 File Offset: 0x0005B8F0
	// (set) Token: 0x0600164B RID: 5707 RVA: 0x0000E696 File Offset: 0x0000C896
	public unsafe GameObject m_IndicatorAway
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorAway);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorAway), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000715 RID: 1813
	// (get) Token: 0x0600164C RID: 5708 RVA: 0x0005D720 File Offset: 0x0005B920
	// (set) Token: 0x0600164D RID: 5709 RVA: 0x0000E6B5 File Offset: 0x0000C8B5
	public unsafe GameObject m_IndicatorUnknown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorUnknown);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorUnknown), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000716 RID: 1814
	// (get) Token: 0x0600164E RID: 5710 RVA: 0x0005D750 File Offset: 0x0005B950
	// (set) Token: 0x0600164F RID: 5711 RVA: 0x0000E6D4 File Offset: 0x0000C8D4
	public unsafe GameObject m_IndicatorForfeit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorForfeit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_OnlineIndicator.NativeFieldInfoPtr_m_IndicatorForfeit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F5C RID: 3932
	private static readonly IntPtr NativeFieldInfoPtr_m_IndicatorOnline;

	// Token: 0x04000F5D RID: 3933
	private static readonly IntPtr NativeFieldInfoPtr_m_IndicatorOffline;

	// Token: 0x04000F5E RID: 3934
	private static readonly IntPtr NativeFieldInfoPtr_m_IndicatorAway;

	// Token: 0x04000F5F RID: 3935
	private static readonly IntPtr NativeFieldInfoPtr_m_IndicatorUnknown;

	// Token: 0x04000F60 RID: 3936
	private static readonly IntPtr NativeFieldInfoPtr_m_IndicatorForfeit;

	// Token: 0x04000F61 RID: 3937
	private static readonly IntPtr NativeMethodInfoPtr_SetIndicator_Public_Void_UInt32_0;

	// Token: 0x04000F62 RID: 3938
	private static readonly IntPtr NativeMethodInfoPtr_SetIndicator_Public_Void_PlayerOnlineStatus_0;

	// Token: 0x04000F63 RID: 3939
	private static readonly IntPtr NativeMethodInfoPtr_ShowForfeit_Public_Void_Boolean_0;

	// Token: 0x04000F64 RID: 3940
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
