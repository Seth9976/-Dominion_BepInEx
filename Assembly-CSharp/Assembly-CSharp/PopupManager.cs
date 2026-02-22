using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200003C RID: 60
public class PopupManager : MonoBehaviour
{
	// Token: 0x06000AC3 RID: 2755 RVA: 0x00039B3C File Offset: 0x00037D3C
	// Note: this type is marked as 'beforefieldinit'.
	static PopupManager()
	{
		Il2CppClassPointerStore<PopupManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PopupManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupManager>.NativeClassPtr);
		PopupManager.NativeFieldInfoPtr_m_Popups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_Popups");
		PopupManager.NativeFieldInfoPtr_m_PopupBasePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_PopupBasePanel");
		PopupManager.NativeFieldInfoPtr_m_BlurCameraMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_BlurCameraMobile");
		PopupManager.NativeFieldInfoPtr_m_BlurCameraSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_BlurCameraSteam");
		PopupManager.NativeFieldInfoPtr_m_OnCurrentPopupChangedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_OnCurrentPopupChangedCallback");
		PopupManager.NativeFieldInfoPtr_m_PopupBaseCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_PopupBaseCamera");
		PopupManager.NativeFieldInfoPtr_m_ActivePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_ActivePopup");
		PopupManager.NativeFieldInfoPtr_m_HiddenPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "m_HiddenPopup");
		PopupManager.NativeMethodInfoPtr_AddOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664045);
		PopupManager.NativeMethodInfoPtr_RemoveOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664046);
		PopupManager.NativeMethodInfoPtr_GetActivePopup_Public_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664047);
		PopupManager.NativeMethodInfoPtr_GetHiddenPopup_Public_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664048);
		PopupManager.NativeMethodInfoPtr_HasActivePopup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664049);
		PopupManager.NativeMethodInfoPtr_HasHiddenPopup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664050);
		PopupManager.NativeMethodInfoPtr_HasActiveOrHiddenPopup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664051);
		PopupManager.NativeMethodInfoPtr_GetPopup_Public_PopupBase_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664052);
		PopupManager.NativeMethodInfoPtr_BlockGameUpdate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664053);
		PopupManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664054);
		PopupManager.NativeMethodInfoPtr_SetPopup_Public_Void_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664055);
		PopupManager.NativeMethodInfoPtr_HideActivePopup_Public_Boolean_PopupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664056);
		PopupManager.NativeMethodInfoPtr_RestoreHiddenPopup_Public_Boolean_PopupBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664057);
		PopupManager.NativeMethodInfoPtr_RebuildPopups_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664058);
		PopupManager.NativeMethodInfoPtr_HandleTutorialFlags_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664059);
		PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664060);
		PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664061);
		PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCommit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664062);
		PopupManager.NativeMethodInfoPtr_OnPopupActionButtonRoll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664063);
		PopupManager.NativeMethodInfoPtr_OnPopupActionButtonGeneric_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664064);
		PopupManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, 100664065);
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00039DB0 File Offset: 0x00037FB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237088, RefRangeEnd = 237089, XrefRangeStart = 237085, XrefRangeEnd = 237088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnCurrentPopupChangedCallback(PopupManager.PopupChangedCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_AddOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00039DF4 File Offset: 0x00037FF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237089, XrefRangeEnd = 237092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnCurrentPopupChangedCallback(PopupManager.PopupChangedCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_RemoveOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00039E38 File Offset: 0x00038038
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EPopups GetActivePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_GetActivePopup_Public_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00039E74 File Offset: 0x00038074
	[CallerCount(0)]
	public unsafe EPopups GetHiddenPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_GetHiddenPopup_Public_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00039EB0 File Offset: 0x000380B0
	[CallerCount(0)]
	public unsafe bool HasActivePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_HasActivePopup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00039EEC File Offset: 0x000380EC
	[CallerCount(0)]
	public unsafe bool HasHiddenPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_HasHiddenPopup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00039F28 File Offset: 0x00038128
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237092, RefRangeEnd = 237093, XrefRangeStart = 237092, XrefRangeEnd = 237092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasActiveOrHiddenPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_HasActiveOrHiddenPopup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00039F64 File Offset: 0x00038164
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237093, RefRangeEnd = 237095, XrefRangeStart = 237093, XrefRangeEnd = 237093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PopupBase GetPopup(EPopups popupType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref popupType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_GetPopup_Public_PopupBase_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PopupBase>(intPtr3) : null;
		}
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00039FB0 File Offset: 0x000381B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237102, RefRangeEnd = 237104, XrefRangeStart = 237095, XrefRangeEnd = 237102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BlockGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_BlockGameUpdate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00039FEC File Offset: 0x000381EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237104, XrefRangeEnd = 237127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x0003A020 File Offset: 0x00038220
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 237148, RefRangeEnd = 237155, XrefRangeStart = 237127, XrefRangeEnd = 237148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPopup(EPopups popupType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref popupType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_SetPopup_Public_Void_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x0003A060 File Offset: 0x00038260
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237155, XrefRangeEnd = 237163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HideActivePopup(PopupBase popup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_HideActivePopup_Public_Boolean_PopupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x0003A0B0 File Offset: 0x000382B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237171, RefRangeEnd = 237173, XrefRangeStart = 237163, XrefRangeEnd = 237171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RestoreHiddenPopup(PopupBase popup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_RestoreHiddenPopup_Public_Boolean_PopupBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x0003A100 File Offset: 0x00038300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237173, XrefRangeEnd = 237180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPopups()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_RebuildPopups_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x0003A134 File Offset: 0x00038334
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237184, RefRangeEnd = 237185, XrefRangeStart = 237180, XrefRangeEnd = 237184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleTutorialFlags(uint tutorialFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref tutorialFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_HandleTutorialFlags_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x0003A174 File Offset: 0x00038374
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237185, XrefRangeEnd = 237189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPopupActionButtonCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0003A1A8 File Offset: 0x000383A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237189, XrefRangeEnd = 237193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPopupActionButtonCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0003A1DC File Offset: 0x000383DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237193, XrefRangeEnd = 237197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPopupActionButtonCommit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_OnPopupActionButtonCommit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0003A210 File Offset: 0x00038410
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237197, XrefRangeEnd = 237201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPopupActionButtonRoll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_OnPopupActionButtonRoll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x0003A244 File Offset: 0x00038444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237201, XrefRangeEnd = 237205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPopupActionButtonGeneric()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr_OnPopupActionButtonGeneric_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0003A278 File Offset: 0x00038478
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PopupManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x000089BA File Offset: 0x00006BBA
	public PopupManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0003A2B4 File Offset: 0x000384B4
	// (set) Token: 0x06000ADB RID: 2779 RVA: 0x000089C3 File Offset: 0x00006BC3
	public unsafe Il2CppReferenceArray<PopupBase> m_Popups
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_Popups);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PopupBase>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_Popups), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0003A2E4 File Offset: 0x000384E4
	// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000089E2 File Offset: 0x00006BE2
	public unsafe GameObject m_PopupBasePanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_PopupBasePanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_PopupBasePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0003A314 File Offset: 0x00038514
	// (set) Token: 0x06000ADF RID: 2783 RVA: 0x00008A01 File Offset: 0x00006C01
	public unsafe GameObject m_BlurCameraMobile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_BlurCameraMobile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_BlurCameraMobile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0003A344 File Offset: 0x00038544
	// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x00008A20 File Offset: 0x00006C20
	public unsafe GameObject m_BlurCameraSteam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_BlurCameraSteam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_BlurCameraSteam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0003A374 File Offset: 0x00038574
	// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00008A3F File Offset: 0x00006C3F
	public unsafe PopupManager.PopupChangedCallback m_OnCurrentPopupChangedCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_OnCurrentPopupChangedCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PopupManager.PopupChangedCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_OnCurrentPopupChangedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C0 RID: 960
	// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x0003A3A4 File Offset: 0x000385A4
	// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00008A5E File Offset: 0x00006C5E
	public unsafe GameObject m_PopupBaseCamera
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_PopupBaseCamera);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_PopupBaseCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C1 RID: 961
	// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0003A3D4 File Offset: 0x000385D4
	// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x00008A7D File Offset: 0x00006C7D
	public unsafe EPopups m_ActivePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_ActivePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_ActivePopup)) = value;
		}
	}

	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0003A3FC File Offset: 0x000385FC
	// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x00008A98 File Offset: 0x00006C98
	public unsafe EPopups m_HiddenPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_HiddenPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupManager.NativeFieldInfoPtr_m_HiddenPopup)) = value;
		}
	}

	// Token: 0x040006B2 RID: 1714
	private static readonly IntPtr NativeFieldInfoPtr_m_Popups;

	// Token: 0x040006B3 RID: 1715
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupBasePanel;

	// Token: 0x040006B4 RID: 1716
	private static readonly IntPtr NativeFieldInfoPtr_m_BlurCameraMobile;

	// Token: 0x040006B5 RID: 1717
	private static readonly IntPtr NativeFieldInfoPtr_m_BlurCameraSteam;

	// Token: 0x040006B6 RID: 1718
	private static readonly IntPtr NativeFieldInfoPtr_m_OnCurrentPopupChangedCallback;

	// Token: 0x040006B7 RID: 1719
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupBaseCamera;

	// Token: 0x040006B8 RID: 1720
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivePopup;

	// Token: 0x040006B9 RID: 1721
	private static readonly IntPtr NativeFieldInfoPtr_m_HiddenPopup;

	// Token: 0x040006BA RID: 1722
	private static readonly IntPtr NativeMethodInfoPtr_AddOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0;

	// Token: 0x040006BB RID: 1723
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnCurrentPopupChangedCallback_Public_Void_PopupChangedCallback_0;

	// Token: 0x040006BC RID: 1724
	private static readonly IntPtr NativeMethodInfoPtr_GetActivePopup_Public_EPopups_0;

	// Token: 0x040006BD RID: 1725
	private static readonly IntPtr NativeMethodInfoPtr_GetHiddenPopup_Public_EPopups_0;

	// Token: 0x040006BE RID: 1726
	private static readonly IntPtr NativeMethodInfoPtr_HasActivePopup_Public_Boolean_0;

	// Token: 0x040006BF RID: 1727
	private static readonly IntPtr NativeMethodInfoPtr_HasHiddenPopup_Public_Boolean_0;

	// Token: 0x040006C0 RID: 1728
	private static readonly IntPtr NativeMethodInfoPtr_HasActiveOrHiddenPopup_Public_Boolean_0;

	// Token: 0x040006C1 RID: 1729
	private static readonly IntPtr NativeMethodInfoPtr_GetPopup_Public_PopupBase_EPopups_0;

	// Token: 0x040006C2 RID: 1730
	private static readonly IntPtr NativeMethodInfoPtr_BlockGameUpdate_Public_Boolean_0;

	// Token: 0x040006C3 RID: 1731
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040006C4 RID: 1732
	private static readonly IntPtr NativeMethodInfoPtr_SetPopup_Public_Void_EPopups_0;

	// Token: 0x040006C5 RID: 1733
	private static readonly IntPtr NativeMethodInfoPtr_HideActivePopup_Public_Boolean_PopupBase_0;

	// Token: 0x040006C6 RID: 1734
	private static readonly IntPtr NativeMethodInfoPtr_RestoreHiddenPopup_Public_Boolean_PopupBase_0;

	// Token: 0x040006C7 RID: 1735
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPopups_Public_Void_0;

	// Token: 0x040006C8 RID: 1736
	private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialFlags_Public_Void_UInt32_0;

	// Token: 0x040006C9 RID: 1737
	private static readonly IntPtr NativeMethodInfoPtr_OnPopupActionButtonCancel_Public_Void_0;

	// Token: 0x040006CA RID: 1738
	private static readonly IntPtr NativeMethodInfoPtr_OnPopupActionButtonCheck_Public_Void_0;

	// Token: 0x040006CB RID: 1739
	private static readonly IntPtr NativeMethodInfoPtr_OnPopupActionButtonCommit_Public_Void_0;

	// Token: 0x040006CC RID: 1740
	private static readonly IntPtr NativeMethodInfoPtr_OnPopupActionButtonRoll_Public_Void_0;

	// Token: 0x040006CD RID: 1741
	private static readonly IntPtr NativeMethodInfoPtr_OnPopupActionButtonGeneric_Public_Void_0;

	// Token: 0x040006CE RID: 1742
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200017E RID: 382
	public sealed class PopupChangedCallback : MulticastDelegate
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x00085654 File Offset: 0x00083854
		// Note: this type is marked as 'beforefieldinit'.
		static PopupChangedCallback()
		{
			Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PopupManager>.NativeClassPtr, "PopupChangedCallback");
			PopupManager.PopupChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr, 100666134);
			PopupManager.PopupChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EPopups_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr, 100666135);
			PopupManager.PopupChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EPopups_EPopups_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr, 100666136);
			PopupManager.PopupChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr, 100666137);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x000856C8 File Offset: 0x000838C8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupChangedCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupManager.PopupChangedCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.PopupChangedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00085724 File Offset: 0x00083924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237075, RefRangeEnd = 237079, XrefRangeStart = 237070, XrefRangeEnd = 237075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(EPopups newPopup, EPopups oldPopup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newPopup;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.PopupChangedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EPopups_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00085770 File Offset: 0x00083970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237079, XrefRangeEnd = 237085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(EPopups newPopup, EPopups oldPopup, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newPopup;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldPopup;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.PopupChangedCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EPopups_EPopups_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x000857F0 File Offset: 0x000839F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupManager.PopupChangedCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00016482 File Offset: 0x00014682
		public PopupChangedCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0001648B File Offset: 0x0001468B
		public static implicit operator PopupManager.PopupChangedCallback(Action<EPopups, EPopups> A_0)
		{
			return DelegateSupport.ConvertDelegate<PopupManager.PopupChangedCallback>(A_0);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00016493 File Offset: 0x00014693
		public static PopupManager.PopupChangedCallback operator +(PopupManager.PopupChangedCallback A_0, PopupManager.PopupChangedCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PopupManager.PopupChangedCallback>();
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x000164A1 File Offset: 0x000146A1
		public static PopupManager.PopupChangedCallback operator -(PopupManager.PopupChangedCallback A_0, PopupManager.PopupChangedCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PopupManager.PopupChangedCallback>();
			}
			return delegate2;
		}

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EPopups_EPopups_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EPopups_EPopups_AsyncCallback_Object_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
