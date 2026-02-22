using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000130 RID: 304
public class SavedGamesTab : FeatureTab
{
	// Token: 0x06001607 RID: 5639 RVA: 0x00062AC4 File Offset: 0x00060CC4
	// Note: this type is marked as 'beforefieldinit'.
	static SavedGamesTab()
	{
		Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SavedGamesTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr);
		SavedGamesTab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "avatar");
		SavedGamesTab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "logo");
		SavedGamesTab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "defaulttexture");
		SavedGamesTab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "connectButton");
		SavedGamesTab.NativeFieldInfoPtr_connectButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "connectButtonLabel");
		SavedGamesTab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "playerLabel");
		SavedGamesTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "ConnectionDependedntButtons");
		SavedGamesTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665936);
		SavedGamesTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665937);
		SavedGamesTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665938);
		SavedGamesTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665939);
		SavedGamesTab.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665940);
		SavedGamesTab.NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665941);
		SavedGamesTab.NativeMethodInfoPtr_LoadSavedGames_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665942);
		SavedGamesTab.NativeMethodInfoPtr_ActionAvailableGameSavesLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665943);
		SavedGamesTab.NativeMethodInfoPtr_OnSpanshotLoadDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665944);
		SavedGamesTab.NativeMethodInfoPtr_ActionNewGameSaveRequest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665945);
		SavedGamesTab.NativeMethodInfoPtr_ActionGameSaveLoaded_Private_Void_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665946);
		SavedGamesTab.NativeMethodInfoPtr_ActionGameSaveResult_Private_Void_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665947);
		SavedGamesTab.NativeMethodInfoPtr_ActionConflict_Private_Void_GP_SnapshotConflict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665948);
		SavedGamesTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665949);
		SavedGamesTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665950);
		SavedGamesTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665951);
		SavedGamesTab.NativeMethodInfoPtr_MakeScreenshotAndSaveGameData_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665952);
		SavedGamesTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, 100665953);
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x00062CE8 File Offset: 0x00060EE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191331, XrefRangeEnd = 191398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x00062D1C File Offset: 0x00060F1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191398, XrefRangeEnd = 191450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00062D50 File Offset: 0x00060F50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191450, XrefRangeEnd = 191484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x00062D84 File Offset: 0x00060F84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191484, XrefRangeEnd = 191550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x00062DB8 File Offset: 0x00060FB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191550, XrefRangeEnd = 191556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateNewSnapshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x00062DEC File Offset: 0x00060FEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191556, XrefRangeEnd = 191565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowSavedGamesUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x00062E20 File Offset: 0x00061020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191565, XrefRangeEnd = 191588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSavedGames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_LoadSavedGames_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x00062E54 File Offset: 0x00061054
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191588, XrefRangeEnd = 191625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionAvailableGameSavesLoaded(GooglePlayResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ActionAvailableGameSavesLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x00062E98 File Offset: 0x00061098
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191625, XrefRangeEnd = 191636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSpanshotLoadDialogComplete(AndroidDialogResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_OnSpanshotLoadDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x00062ED8 File Offset: 0x000610D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191636, XrefRangeEnd = 191655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionNewGameSaveRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ActionNewGameSaveRequest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x00062F0C File Offset: 0x0006110C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191655, XrefRangeEnd = 191701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionGameSaveLoaded(GP_SpanshotLoadResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ActionGameSaveLoaded_Private_Void_GP_SpanshotLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x00062F50 File Offset: 0x00061150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191701, XrefRangeEnd = 191733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionGameSaveResult(GP_SpanshotLoadResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ActionGameSaveResult_Private_Void_GP_SpanshotLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00062F94 File Offset: 0x00061194
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191733, XrefRangeEnd = 191741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionConflict(GP_SnapshotConflict result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_ActionConflict_Private_Void_GP_SnapshotConflict_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x00062FD8 File Offset: 0x000611D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191741, XrefRangeEnd = 191746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x0006300C File Offset: 0x0006120C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191746, XrefRangeEnd = 191756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001617 RID: 5655 RVA: 0x00063040 File Offset: 0x00061240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191756, XrefRangeEnd = 191772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001618 RID: 5656 RVA: 0x00063084 File Offset: 0x00061284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191772, XrefRangeEnd = 191776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator MakeScreenshotAndSaveGameData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr_MakeScreenshotAndSaveGameData_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001619 RID: 5657 RVA: 0x000630C4 File Offset: 0x000612C4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SavedGamesTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600161A RID: 5658 RVA: 0x0000AD53 File Offset: 0x00008F53
	public SavedGamesTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000651 RID: 1617
	// (get) Token: 0x0600161B RID: 5659 RVA: 0x00063100 File Offset: 0x00061300
	// (set) Token: 0x0600161C RID: 5660 RVA: 0x0000AD5C File Offset: 0x00008F5C
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000652 RID: 1618
	// (get) Token: 0x0600161D RID: 5661 RVA: 0x00063130 File Offset: 0x00061330
	// (set) Token: 0x0600161E RID: 5662 RVA: 0x0000AD7B File Offset: 0x00008F7B
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000653 RID: 1619
	// (get) Token: 0x0600161F RID: 5663 RVA: 0x00063160 File Offset: 0x00061360
	// (set) Token: 0x06001620 RID: 5664 RVA: 0x0000AD9A File Offset: 0x00008F9A
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000654 RID: 1620
	// (get) Token: 0x06001621 RID: 5665 RVA: 0x00063190 File Offset: 0x00061390
	// (set) Token: 0x06001622 RID: 5666 RVA: 0x0000ADB9 File Offset: 0x00008FB9
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000655 RID: 1621
	// (get) Token: 0x06001623 RID: 5667 RVA: 0x000631C0 File Offset: 0x000613C0
	// (set) Token: 0x06001624 RID: 5668 RVA: 0x0000ADD8 File Offset: 0x00008FD8
	public unsafe Text connectButtonLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_connectButtonLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_connectButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000656 RID: 1622
	// (get) Token: 0x06001625 RID: 5669 RVA: 0x000631F0 File Offset: 0x000613F0
	// (set) Token: 0x06001626 RID: 5670 RVA: 0x0000ADF7 File Offset: 0x00008FF7
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000657 RID: 1623
	// (get) Token: 0x06001627 RID: 5671 RVA: 0x00063220 File Offset: 0x00061420
	// (set) Token: 0x06001628 RID: 5672 RVA: 0x0000AE16 File Offset: 0x00009016
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040010A4 RID: 4260
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x040010A5 RID: 4261
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x040010A6 RID: 4262
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x040010A7 RID: 4263
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x040010A8 RID: 4264
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonLabel;

	// Token: 0x040010A9 RID: 4265
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x040010AA RID: 4266
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x040010AB RID: 4267
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040010AC RID: 4268
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040010AD RID: 4269
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x040010AE RID: 4270
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x040010AF RID: 4271
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_0;

	// Token: 0x040010B0 RID: 4272
	private static readonly IntPtr NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_0;

	// Token: 0x040010B1 RID: 4273
	private static readonly IntPtr NativeMethodInfoPtr_LoadSavedGames_Public_Void_0;

	// Token: 0x040010B2 RID: 4274
	private static readonly IntPtr NativeMethodInfoPtr_ActionAvailableGameSavesLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x040010B3 RID: 4275
	private static readonly IntPtr NativeMethodInfoPtr_OnSpanshotLoadDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x040010B4 RID: 4276
	private static readonly IntPtr NativeMethodInfoPtr_ActionNewGameSaveRequest_Private_Void_0;

	// Token: 0x040010B5 RID: 4277
	private static readonly IntPtr NativeMethodInfoPtr_ActionGameSaveLoaded_Private_Void_GP_SpanshotLoadResult_0;

	// Token: 0x040010B6 RID: 4278
	private static readonly IntPtr NativeMethodInfoPtr_ActionGameSaveResult_Private_Void_GP_SpanshotLoadResult_0;

	// Token: 0x040010B7 RID: 4279
	private static readonly IntPtr NativeMethodInfoPtr_ActionConflict_Private_Void_GP_SnapshotConflict_0;

	// Token: 0x040010B8 RID: 4280
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x040010B9 RID: 4281
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x040010BA RID: 4282
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x040010BB RID: 4283
	private static readonly IntPtr NativeMethodInfoPtr_MakeScreenshotAndSaveGameData_Private_IEnumerator_0;

	// Token: 0x040010BC RID: 4284
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200039C RID: 924
	[ObfuscatedName("SavedGamesTab+<MakeScreenshotAndSaveGameData>d__23")]
	public sealed class _MakeScreenshotAndSaveGameData_d__23 : global::Il2CppSystem.Object
	{
		// Token: 0x060036AC RID: 13996 RVA: 0x000E004C File Offset: 0x000DE24C
		// Note: this type is marked as 'beforefieldinit'.
		static _MakeScreenshotAndSaveGameData_d__23()
		{
			Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SavedGamesTab>.NativeClassPtr, "<MakeScreenshotAndSaveGameData>d__23");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, "<>1__state");
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, "<>2__current");
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, "<>4__this");
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670246);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670247);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670248);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670249);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670250);
			SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr, 100670251);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000E012C File Offset: 0x000DE32C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _MakeScreenshotAndSaveGameData_d__23(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavedGamesTab._MakeScreenshotAndSaveGameData_d__23>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x000E0174 File Offset: 0x000DE374
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000E01A8 File Offset: 0x000DE3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191309, XrefRangeEnd = 191326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x000E01E4 File Offset: 0x000DE3E4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x000E0224 File Offset: 0x000DE424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191326, XrefRangeEnd = 191331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x000E0258 File Offset: 0x000DE458
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0001531D File Offset: 0x0001351D
		public _MakeScreenshotAndSaveGameData_d__23(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x000E0298 File Offset: 0x000DE498
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x00015326 File Offset: 0x00013526
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000E02C0 File Offset: 0x000DE4C0
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x00015341 File Offset: 0x00013541
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x000E02F0 File Offset: 0x000DE4F0
		// (set) Token: 0x060036B9 RID: 14009 RVA: 0x00015360 File Offset: 0x00013560
		public unsafe SavedGamesTab __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SavedGamesTab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SavedGamesTab._MakeScreenshotAndSaveGameData_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
