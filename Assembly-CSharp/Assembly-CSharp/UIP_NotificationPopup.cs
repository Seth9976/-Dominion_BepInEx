using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B8 RID: 184
public class UIP_NotificationPopup : MonoBehaviour
{
	// Token: 0x0600162B RID: 5675 RVA: 0x0005D17C File Offset: 0x0005B37C
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_NotificationPopup()
	{
		Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_NotificationPopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr);
		UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleEmail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_ToggleEmail");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_EmailObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_EmailObj");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleIOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_ToggleIOS");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_IOSObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_IOSObj");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_ToggleAndroid");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_AndroidObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_AndroidObj");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_DisplayEmail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_DisplayEmail");
		UIP_NotificationPopup.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, "m_bIgnoreToggles");
		UIP_NotificationPopup.NativeMethodInfoPtr_Setup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, 100665072);
		UIP_NotificationPopup.NativeMethodInfoPtr_SetData_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, 100665073);
		UIP_NotificationPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr, 100665074);
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x0005D288 File Offset: 0x0005B488
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247627, XrefRangeEnd = 247684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_NotificationPopup.NativeMethodInfoPtr_Setup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x0005D2BC File Offset: 0x0005B4BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247684, XrefRangeEnd = 247685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_NotificationPopup.NativeMethodInfoPtr_SetData_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0005D2FC File Offset: 0x0005B4FC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_NotificationPopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_NotificationPopup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_NotificationPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x0000E552 File Offset: 0x0000C752
	public UIP_NotificationPopup(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700070A RID: 1802
	// (get) Token: 0x06001630 RID: 5680 RVA: 0x0005D338 File Offset: 0x0005B538
	// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000E55B File Offset: 0x0000C75B
	public unsafe Toggle m_ToggleEmail
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleEmail);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleEmail), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700070B RID: 1803
	// (get) Token: 0x06001632 RID: 5682 RVA: 0x0005D368 File Offset: 0x0005B568
	// (set) Token: 0x06001633 RID: 5683 RVA: 0x0000E57A File Offset: 0x0000C77A
	public unsafe GameObject m_EmailObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_EmailObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_EmailObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700070C RID: 1804
	// (get) Token: 0x06001634 RID: 5684 RVA: 0x0005D398 File Offset: 0x0005B598
	// (set) Token: 0x06001635 RID: 5685 RVA: 0x0000E599 File Offset: 0x0000C799
	public unsafe Toggle m_ToggleIOS
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleIOS);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleIOS), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700070D RID: 1805
	// (get) Token: 0x06001636 RID: 5686 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
	// (set) Token: 0x06001637 RID: 5687 RVA: 0x0000E5B8 File Offset: 0x0000C7B8
	public unsafe GameObject m_IOSObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_IOSObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_IOSObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700070E RID: 1806
	// (get) Token: 0x06001638 RID: 5688 RVA: 0x0005D3F8 File Offset: 0x0005B5F8
	// (set) Token: 0x06001639 RID: 5689 RVA: 0x0000E5D7 File Offset: 0x0000C7D7
	public unsafe Toggle m_ToggleAndroid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleAndroid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_ToggleAndroid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700070F RID: 1807
	// (get) Token: 0x0600163A RID: 5690 RVA: 0x0005D428 File Offset: 0x0005B628
	// (set) Token: 0x0600163B RID: 5691 RVA: 0x0000E5F6 File Offset: 0x0000C7F6
	public unsafe GameObject m_AndroidObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_AndroidObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_AndroidObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000710 RID: 1808
	// (get) Token: 0x0600163C RID: 5692 RVA: 0x0005D458 File Offset: 0x0005B658
	// (set) Token: 0x0600163D RID: 5693 RVA: 0x0000E615 File Offset: 0x0000C815
	public unsafe TextMeshProUGUI m_DisplayEmail
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_DisplayEmail);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_DisplayEmail), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000711 RID: 1809
	// (get) Token: 0x0600163E RID: 5694 RVA: 0x0005D488 File Offset: 0x0005B688
	// (set) Token: 0x0600163F RID: 5695 RVA: 0x0000E634 File Offset: 0x0000C834
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_NotificationPopup.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x04000F51 RID: 3921
	private static readonly IntPtr NativeFieldInfoPtr_m_ToggleEmail;

	// Token: 0x04000F52 RID: 3922
	private static readonly IntPtr NativeFieldInfoPtr_m_EmailObj;

	// Token: 0x04000F53 RID: 3923
	private static readonly IntPtr NativeFieldInfoPtr_m_ToggleIOS;

	// Token: 0x04000F54 RID: 3924
	private static readonly IntPtr NativeFieldInfoPtr_m_IOSObj;

	// Token: 0x04000F55 RID: 3925
	private static readonly IntPtr NativeFieldInfoPtr_m_ToggleAndroid;

	// Token: 0x04000F56 RID: 3926
	private static readonly IntPtr NativeFieldInfoPtr_m_AndroidObj;

	// Token: 0x04000F57 RID: 3927
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayEmail;

	// Token: 0x04000F58 RID: 3928
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x04000F59 RID: 3929
	private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_0;

	// Token: 0x04000F5A RID: 3930
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_0;

	// Token: 0x04000F5B RID: 3931
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
