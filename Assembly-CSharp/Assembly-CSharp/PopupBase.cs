using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class PopupBase : MonoBehaviour
{
	// Token: 0x06000AB0 RID: 2736 RVA: 0x000395E8 File Offset: 0x000377E8
	// Note: this type is marked as 'beforefieldinit'.
	static PopupBase()
	{
		Il2CppClassPointerStore<PopupBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PopupBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupBase>.NativeClassPtr);
		PopupBase.NativeFieldInfoPtr_m_PopupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, "m_PopupManager");
		PopupBase.NativeMethodInfoPtr_SetPopupManager_Public_Void_PopupManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664030);
		PopupBase.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664031);
		PopupBase.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664032);
		PopupBase.NativeMethodInfoPtr_DismissPopup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664033);
		PopupBase.NativeMethodInfoPtr_RebuildPopup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664034);
		PopupBase.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664035);
		PopupBase.NativeMethodInfoPtr_HandleTutorialFlags_Public_Virtual_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664036);
		PopupBase.NativeMethodInfoPtr_OnActionButtonCancel_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664037);
		PopupBase.NativeMethodInfoPtr_OnActionButtonCheck_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664038);
		PopupBase.NativeMethodInfoPtr_OnActionButtonCommit_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664039);
		PopupBase.NativeMethodInfoPtr_OnActionButtonRoll_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664040);
		PopupBase.NativeMethodInfoPtr_OnActionButtonGeneric_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664041);
		PopupBase.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664042);
		PopupBase.NativeMethodInfoPtr_StartTimer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664043);
		PopupBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupBase>.NativeClassPtr, 100664044);
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00039758 File Offset: 0x00037958
	[CallerCount(0)]
	public unsafe void SetPopupManager(PopupManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupBase.NativeMethodInfoPtr_SetPopupManager_Public_Void_PopupManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0003979C File Offset: 0x0003799C
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool GetIsHidden()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x000397E4 File Offset: 0x000379E4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 183702, RefRangeEnd = 183706, XrefRangeStart = 183702, XrefRangeEnd = 183706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ActivatePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x00039820 File Offset: 0x00037A20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183709, RefRangeEnd = 183710, XrefRangeStart = 183709, XrefRangeEnd = 183710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DismissPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_DismissPopup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x0003985C File Offset: 0x00037A5C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RebuildPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_RebuildPopup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00039898 File Offset: 0x00037A98
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool BlockGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x000398E0 File Offset: 0x00037AE0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void HandleTutorialFlags(uint tutorialFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref tutorialFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_HandleTutorialFlags_Public_Virtual_New_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x0003992C File Offset: 0x00037B2C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnActionButtonCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_OnActionButtonCancel_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00039968 File Offset: 0x00037B68
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnActionButtonCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_OnActionButtonCheck_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x000399A4 File Offset: 0x00037BA4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnActionButtonCommit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_OnActionButtonCommit_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x000399E0 File Offset: 0x00037BE0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnActionButtonRoll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_OnActionButtonRoll_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00039A1C File Offset: 0x00037C1C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnActionButtonGeneric()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_OnActionButtonGeneric_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x00039A58 File Offset: 0x00037C58
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void EndAnnounce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00039A94 File Offset: 0x00037C94
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StartTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupBase.NativeMethodInfoPtr_StartTimer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00039AD0 File Offset: 0x00037CD0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PopupBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00008992 File Offset: 0x00006B92
	public PopupBase(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00039B0C File Offset: 0x00037D0C
	// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0000899B File Offset: 0x00006B9B
	public unsafe PopupManager m_PopupManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupBase.NativeFieldInfoPtr_m_PopupManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PopupManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupBase.NativeFieldInfoPtr_m_PopupManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040006A2 RID: 1698
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupManager;

	// Token: 0x040006A3 RID: 1699
	private static readonly IntPtr NativeMethodInfoPtr_SetPopupManager_Public_Void_PopupManager_0;

	// Token: 0x040006A4 RID: 1700
	private static readonly IntPtr NativeMethodInfoPtr_GetIsHidden_Public_Virtual_New_Boolean_0;

	// Token: 0x040006A5 RID: 1701
	private static readonly IntPtr NativeMethodInfoPtr_ActivatePopup_Public_Virtual_New_Void_0;

	// Token: 0x040006A6 RID: 1702
	private static readonly IntPtr NativeMethodInfoPtr_DismissPopup_Public_Virtual_New_Void_0;

	// Token: 0x040006A7 RID: 1703
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPopup_Public_Virtual_New_Void_0;

	// Token: 0x040006A8 RID: 1704
	private static readonly IntPtr NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_New_Boolean_0;

	// Token: 0x040006A9 RID: 1705
	private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialFlags_Public_Virtual_New_Void_UInt32_0;

	// Token: 0x040006AA RID: 1706
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonCancel_Public_Virtual_New_Void_0;

	// Token: 0x040006AB RID: 1707
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonCheck_Public_Virtual_New_Void_0;

	// Token: 0x040006AC RID: 1708
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonCommit_Public_Virtual_New_Void_0;

	// Token: 0x040006AD RID: 1709
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonRoll_Public_Virtual_New_Void_0;

	// Token: 0x040006AE RID: 1710
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonGeneric_Public_Virtual_New_Void_0;

	// Token: 0x040006AF RID: 1711
	private static readonly IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_New_Void_0;

	// Token: 0x040006B0 RID: 1712
	private static readonly IntPtr NativeMethodInfoPtr_StartTimer_Public_Virtual_New_Void_0;

	// Token: 0x040006B1 RID: 1713
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
