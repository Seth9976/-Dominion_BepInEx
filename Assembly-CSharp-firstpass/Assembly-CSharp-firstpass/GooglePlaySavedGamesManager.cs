using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x0200006B RID: 107
public class GooglePlaySavedGamesManager : Singleton<GooglePlaySavedGamesManager>
{
	// Token: 0x0600081A RID: 2074 RVA: 0x00032B74 File Offset: 0x00030D74
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlaySavedGamesManager()
	{
		Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlaySavedGamesManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr);
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveUIClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionGameSaveUIClosed");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionNewGameSaveRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionNewGameSaveRequest");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionAvailableGameSavesLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionAvailableGameSavesLoaded");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionGameSaveLoaded");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionGameSaveResult");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionConflict");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "ActionGameSaveRemoved");
		GooglePlaySavedGamesManager.NativeFieldInfoPtr__AvailableGameSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "_AvailableGameSaves");
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveUIClosed_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664271);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveUIClosed_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664272);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionNewGameSaveRequest_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664273);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionNewGameSaveRequest_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664274);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionAvailableGameSavesLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664275);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionAvailableGameSavesLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664276);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveLoaded_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664277);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveLoaded_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664278);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveResult_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664279);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveResult_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664280);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionConflict_Public_Static_add_Void_Action_1_GP_SnapshotConflict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664281);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionConflict_Public_Static_rem_Void_Action_1_GP_SnapshotConflict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664282);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveRemoved_Public_Static_add_Void_Action_1_GP_DeleteSnapshotResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664283);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveRemoved_Public_Static_rem_Void_Action_1_GP_DeleteSnapshotResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664284);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664285);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664286);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664287);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664288);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_LoadSpanshotByName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664289);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_DeleteSpanshotByName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664290);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_LoadAvailableSavedGames_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664291);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_get_AvailableGameSaves_Public_get_List_1_GP_SnapshotMeta_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664292);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664293);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664294);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnLoadSnapshotsResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664295);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGamePicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664296);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGameSaveResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664297);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnConflict_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664298);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnNewGameSaveRequest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664299);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGamesUIClosed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664300);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnDeleteResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664301);
		GooglePlaySavedGamesManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, 100664302);
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00032EC4 File Offset: 0x000310C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168717, XrefRangeEnd = 168728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGameSaveUIClosed(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveUIClosed_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600081C RID: 2076 RVA: 0x00032EFC File Offset: 0x000310FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168728, XrefRangeEnd = 168739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGameSaveUIClosed(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveUIClosed_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600081D RID: 2077 RVA: 0x00032F34 File Offset: 0x00031134
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168750, RefRangeEnd = 168751, XrefRangeStart = 168739, XrefRangeEnd = 168750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionNewGameSaveRequest(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionNewGameSaveRequest_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600081E RID: 2078 RVA: 0x00032F6C File Offset: 0x0003116C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168762, RefRangeEnd = 168763, XrefRangeStart = 168751, XrefRangeEnd = 168762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionNewGameSaveRequest(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionNewGameSaveRequest_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600081F RID: 2079 RVA: 0x00032FA4 File Offset: 0x000311A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168774, RefRangeEnd = 168775, XrefRangeStart = 168763, XrefRangeEnd = 168774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAvailableGameSavesLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionAvailableGameSavesLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000820 RID: 2080 RVA: 0x00032FDC File Offset: 0x000311DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168786, RefRangeEnd = 168787, XrefRangeStart = 168775, XrefRangeEnd = 168786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAvailableGameSavesLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionAvailableGameSavesLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000821 RID: 2081 RVA: 0x00033014 File Offset: 0x00031214
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168798, RefRangeEnd = 168799, XrefRangeStart = 168787, XrefRangeEnd = 168798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGameSaveLoaded(Action<GP_SpanshotLoadResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveLoaded_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000822 RID: 2082 RVA: 0x0003304C File Offset: 0x0003124C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168810, RefRangeEnd = 168811, XrefRangeStart = 168799, XrefRangeEnd = 168810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGameSaveLoaded(Action<GP_SpanshotLoadResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveLoaded_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000823 RID: 2083 RVA: 0x00033084 File Offset: 0x00031284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168811, XrefRangeEnd = 168822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGameSaveResult(Action<GP_SpanshotLoadResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveResult_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000824 RID: 2084 RVA: 0x000330BC File Offset: 0x000312BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168833, RefRangeEnd = 168834, XrefRangeStart = 168822, XrefRangeEnd = 168833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGameSaveResult(Action<GP_SpanshotLoadResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveResult_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000825 RID: 2085 RVA: 0x000330F4 File Offset: 0x000312F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168845, RefRangeEnd = 168846, XrefRangeStart = 168834, XrefRangeEnd = 168845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionConflict(Action<GP_SnapshotConflict> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionConflict_Public_Static_add_Void_Action_1_GP_SnapshotConflict_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x0003312C File Offset: 0x0003132C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168857, RefRangeEnd = 168858, XrefRangeStart = 168846, XrefRangeEnd = 168857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionConflict(Action<GP_SnapshotConflict> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionConflict_Public_Static_rem_Void_Action_1_GP_SnapshotConflict_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00033164 File Offset: 0x00031364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168858, XrefRangeEnd = 168869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGameSaveRemoved(Action<GP_DeleteSnapshotResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_add_ActionGameSaveRemoved_Public_Static_add_Void_Action_1_GP_DeleteSnapshotResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x0003319C File Offset: 0x0003139C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168869, XrefRangeEnd = 168880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGameSaveRemoved(Action<GP_DeleteSnapshotResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_remove_ActionGameSaveRemoved_Public_Static_rem_Void_Action_1_GP_DeleteSnapshotResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x000331D4 File Offset: 0x000313D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168880, XrefRangeEnd = 168885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x00033208 File Offset: 0x00031408
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168890, RefRangeEnd = 168891, XrefRangeStart = 168885, XrefRangeEnd = 168890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowSavedGamesUI(string title, int maxNumberOfSavedGamesToShow, bool allowAddButton = true, bool allowDelete = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNumberOfSavedGamesToShow;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowAddButton;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDelete;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00033274 File Offset: 0x00031474
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168891, XrefRangeEnd = 168922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateNewSnapshot(string name, string description, Texture2D coverImage, string spanshotData, long PlayedTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coverImage);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spanshotData);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PlayedTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x000332FC File Offset: 0x000314FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168922, XrefRangeEnd = 168944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateNewSnapshot(string name, string description, Texture2D coverImage, Il2CppStructArray<byte> spanshotData, long PlayedTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coverImage);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spanshotData);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PlayedTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_Il2CppStructArray_1_Byte_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x00033384 File Offset: 0x00031584
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168945, RefRangeEnd = 168946, XrefRangeStart = 168944, XrefRangeEnd = 168945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadSpanshotByName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_LoadSpanshotByName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x000333C8 File Offset: 0x000315C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168946, XrefRangeEnd = 168947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteSpanshotByName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_DeleteSpanshotByName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0003340C File Offset: 0x0003160C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168948, RefRangeEnd = 168949, XrefRangeStart = 168947, XrefRangeEnd = 168948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAvailableSavedGames()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_LoadAvailableSavedGames_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06000830 RID: 2096 RVA: 0x00033440 File Offset: 0x00031640
	public unsafe List<GP_SnapshotMeta> AvailableGameSaves
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_get_AvailableGameSaves_Public_get_List_1_GP_SnapshotMeta_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_SnapshotMeta>>(intPtr3) : null;
		}
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x00033480 File Offset: 0x00031680
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168949, XrefRangeEnd = 168954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetBytes(string str)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}
	}

	// Token: 0x06000832 RID: 2098 RVA: 0x000334C4 File Offset: 0x000316C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168954, XrefRangeEnd = 168960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(Il2CppStructArray<byte> bytes)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x00033500 File Offset: 0x00031700
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168960, XrefRangeEnd = 169018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadSnapshotsResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnLoadSnapshotsResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000834 RID: 2100 RVA: 0x00033544 File Offset: 0x00031744
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169018, XrefRangeEnd = 169076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSavedGamePicked(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGamePicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00033588 File Offset: 0x00031788
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169076, XrefRangeEnd = 169134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSavedGameSaveResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGameSaveResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x000335CC File Offset: 0x000317CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169134, XrefRangeEnd = 169211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConflict(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnConflict_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00033610 File Offset: 0x00031810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169211, XrefRangeEnd = 169223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNewGameSaveRequest(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnNewGameSaveRequest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00033654 File Offset: 0x00031854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169223, XrefRangeEnd = 169235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSavedGamesUIClosed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnSavedGamesUIClosed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00033698 File Offset: 0x00031898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169235, XrefRangeEnd = 169260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeleteResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr_OnDeleteResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x000336DC File Offset: 0x000318DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169260, XrefRangeEnd = 169272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlaySavedGamesManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00005482 File Offset: 0x00003682
	public GooglePlaySavedGamesManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x0600083C RID: 2108 RVA: 0x00033718 File Offset: 0x00031918
	// (set) Token: 0x0600083D RID: 2109 RVA: 0x0000548B File Offset: 0x0000368B
	public unsafe static Action ActionGameSaveUIClosed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveUIClosed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveUIClosed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600083E RID: 2110 RVA: 0x00033740 File Offset: 0x00031940
	// (set) Token: 0x0600083F RID: 2111 RVA: 0x0000549D File Offset: 0x0000369D
	public unsafe static Action ActionNewGameSaveRequest
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionNewGameSaveRequest, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionNewGameSaveRequest, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06000840 RID: 2112 RVA: 0x00033768 File Offset: 0x00031968
	// (set) Token: 0x06000841 RID: 2113 RVA: 0x000054AF File Offset: 0x000036AF
	public unsafe static Action<GooglePlayResult> ActionAvailableGameSavesLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionAvailableGameSavesLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionAvailableGameSavesLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06000842 RID: 2114 RVA: 0x00033790 File Offset: 0x00031990
	// (set) Token: 0x06000843 RID: 2115 RVA: 0x000054C1 File Offset: 0x000036C1
	public unsafe static Action<GP_SpanshotLoadResult> ActionGameSaveLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_SpanshotLoadResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x06000844 RID: 2116 RVA: 0x000337B8 File Offset: 0x000319B8
	// (set) Token: 0x06000845 RID: 2117 RVA: 0x000054D3 File Offset: 0x000036D3
	public unsafe static Action<GP_SpanshotLoadResult> ActionGameSaveResult
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveResult, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_SpanshotLoadResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveResult, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x06000846 RID: 2118 RVA: 0x000337E0 File Offset: 0x000319E0
	// (set) Token: 0x06000847 RID: 2119 RVA: 0x000054E5 File Offset: 0x000036E5
	public unsafe static Action<GP_SnapshotConflict> ActionConflict
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionConflict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_SnapshotConflict>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionConflict, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06000848 RID: 2120 RVA: 0x00033808 File Offset: 0x00031A08
	// (set) Token: 0x06000849 RID: 2121 RVA: 0x000054F7 File Offset: 0x000036F7
	public unsafe static Action<GP_DeleteSnapshotResult> ActionGameSaveRemoved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveRemoved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_DeleteSnapshotResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.NativeFieldInfoPtr_ActionGameSaveRemoved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x0600084A RID: 2122 RVA: 0x00033830 File Offset: 0x00031A30
	// (set) Token: 0x0600084B RID: 2123 RVA: 0x00005509 File Offset: 0x00003709
	public unsafe List<GP_SnapshotMeta> _AvailableGameSaves
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlaySavedGamesManager.NativeFieldInfoPtr__AvailableGameSaves);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GP_SnapshotMeta>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlaySavedGamesManager.NativeFieldInfoPtr__AvailableGameSaves), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000687 RID: 1671
	private static readonly IntPtr NativeFieldInfoPtr_ActionGameSaveUIClosed;

	// Token: 0x04000688 RID: 1672
	private static readonly IntPtr NativeFieldInfoPtr_ActionNewGameSaveRequest;

	// Token: 0x04000689 RID: 1673
	private static readonly IntPtr NativeFieldInfoPtr_ActionAvailableGameSavesLoaded;

	// Token: 0x0400068A RID: 1674
	private static readonly IntPtr NativeFieldInfoPtr_ActionGameSaveLoaded;

	// Token: 0x0400068B RID: 1675
	private static readonly IntPtr NativeFieldInfoPtr_ActionGameSaveResult;

	// Token: 0x0400068C RID: 1676
	private static readonly IntPtr NativeFieldInfoPtr_ActionConflict;

	// Token: 0x0400068D RID: 1677
	private static readonly IntPtr NativeFieldInfoPtr_ActionGameSaveRemoved;

	// Token: 0x0400068E RID: 1678
	private static readonly IntPtr NativeFieldInfoPtr__AvailableGameSaves;

	// Token: 0x0400068F RID: 1679
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGameSaveUIClosed_Public_Static_add_Void_Action_0;

	// Token: 0x04000690 RID: 1680
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGameSaveUIClosed_Public_Static_rem_Void_Action_0;

	// Token: 0x04000691 RID: 1681
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionNewGameSaveRequest_Public_Static_add_Void_Action_0;

	// Token: 0x04000692 RID: 1682
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionNewGameSaveRequest_Public_Static_rem_Void_Action_0;

	// Token: 0x04000693 RID: 1683
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAvailableGameSavesLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0;

	// Token: 0x04000694 RID: 1684
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAvailableGameSavesLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0;

	// Token: 0x04000695 RID: 1685
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGameSaveLoaded_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0;

	// Token: 0x04000696 RID: 1686
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGameSaveLoaded_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0;

	// Token: 0x04000697 RID: 1687
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGameSaveResult_Public_Static_add_Void_Action_1_GP_SpanshotLoadResult_0;

	// Token: 0x04000698 RID: 1688
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGameSaveResult_Public_Static_rem_Void_Action_1_GP_SpanshotLoadResult_0;

	// Token: 0x04000699 RID: 1689
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionConflict_Public_Static_add_Void_Action_1_GP_SnapshotConflict_0;

	// Token: 0x0400069A RID: 1690
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionConflict_Public_Static_rem_Void_Action_1_GP_SnapshotConflict_0;

	// Token: 0x0400069B RID: 1691
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGameSaveRemoved_Public_Static_add_Void_Action_1_GP_DeleteSnapshotResult_0;

	// Token: 0x0400069C RID: 1692
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGameSaveRemoved_Public_Static_rem_Void_Action_1_GP_DeleteSnapshotResult_0;

	// Token: 0x0400069D RID: 1693
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400069E RID: 1694
	private static readonly IntPtr NativeMethodInfoPtr_ShowSavedGamesUI_Public_Void_String_Int32_Boolean_Boolean_0;

	// Token: 0x0400069F RID: 1695
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_String_Int64_0;

	// Token: 0x040006A0 RID: 1696
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewSnapshot_Public_Void_String_String_Texture2D_Il2CppStructArray_1_Byte_Int64_0;

	// Token: 0x040006A1 RID: 1697
	private static readonly IntPtr NativeMethodInfoPtr_LoadSpanshotByName_Public_Void_String_0;

	// Token: 0x040006A2 RID: 1698
	private static readonly IntPtr NativeMethodInfoPtr_DeleteSpanshotByName_Public_Void_String_0;

	// Token: 0x040006A3 RID: 1699
	private static readonly IntPtr NativeMethodInfoPtr_LoadAvailableSavedGames_Public_Void_0;

	// Token: 0x040006A4 RID: 1700
	private static readonly IntPtr NativeMethodInfoPtr_get_AvailableGameSaves_Public_get_List_1_GP_SnapshotMeta_0;

	// Token: 0x040006A5 RID: 1701
	private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Private_Static_Il2CppStructArray_1_Byte_String_0;

	// Token: 0x040006A6 RID: 1702
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_Il2CppStructArray_1_Byte_0;

	// Token: 0x040006A7 RID: 1703
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadSnapshotsResult_Private_Void_String_0;

	// Token: 0x040006A8 RID: 1704
	private static readonly IntPtr NativeMethodInfoPtr_OnSavedGamePicked_Private_Void_String_0;

	// Token: 0x040006A9 RID: 1705
	private static readonly IntPtr NativeMethodInfoPtr_OnSavedGameSaveResult_Private_Void_String_0;

	// Token: 0x040006AA RID: 1706
	private static readonly IntPtr NativeMethodInfoPtr_OnConflict_Private_Void_String_0;

	// Token: 0x040006AB RID: 1707
	private static readonly IntPtr NativeMethodInfoPtr_OnNewGameSaveRequest_Private_Void_String_0;

	// Token: 0x040006AC RID: 1708
	private static readonly IntPtr NativeMethodInfoPtr_OnSavedGamesUIClosed_Private_Void_String_0;

	// Token: 0x040006AD RID: 1709
	private static readonly IntPtr NativeMethodInfoPtr_OnDeleteResult_Private_Void_String_0;

	// Token: 0x040006AE RID: 1710
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000376 RID: 886
	[ObfuscatedName("GooglePlaySavedGamesManager+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600350A RID: 13578 RVA: 0x000DB01C File Offset: 0x000D921C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlaySavedGamesManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr);
			GooglePlaySavedGamesManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, "<>9");
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670058);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670059);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670060);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_2_Internal_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670061);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_3_Internal_Void_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670062);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_4_Internal_Void_GP_SpanshotLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670063);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_5_Internal_Void_GP_SnapshotConflict_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670064);
			GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_6_Internal_Void_GP_DeleteSnapshotResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr, 100670065);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x000DB0FC File Offset: 0x000D92FC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlaySavedGamesManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x000DB138 File Offset: 0x000D9338
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x000DB16C File Offset: 0x000D936C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x000DB1A0 File Offset: 0x000D93A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_2(GooglePlayResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_2_Internal_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000DB1E4 File Offset: 0x000D93E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_3(GP_SpanshotLoadResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_3_Internal_Void_GP_SpanshotLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000DB228 File Offset: 0x000D9428
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_4(GP_SpanshotLoadResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_4_Internal_Void_GP_SpanshotLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x000DB26C File Offset: 0x000D946C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_5(GP_SnapshotConflict <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_5_Internal_Void_GP_SnapshotConflict_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000DB2B0 File Offset: 0x000D94B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__41_6(GP_DeleteSnapshotResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlaySavedGamesManager.__c.NativeMethodInfoPtr___cctor_b__41_6_Internal_Void_GP_DeleteSnapshotResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000149E2 File Offset: 0x00012BE2
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000DB2F4 File Offset: 0x000D94F4
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x000149EB File Offset: 0x00012BEB
		public unsafe static GooglePlaySavedGamesManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlaySavedGamesManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlaySavedGamesManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlaySavedGamesManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_0_Internal_Void_0;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_1_Internal_Void_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_2_Internal_Void_GooglePlayResult_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_3_Internal_Void_GP_SpanshotLoadResult_0;

		// Token: 0x040030F8 RID: 12536
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_4_Internal_Void_GP_SpanshotLoadResult_0;

		// Token: 0x040030F9 RID: 12537
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_5_Internal_Void_GP_SnapshotConflict_0;

		// Token: 0x040030FA RID: 12538
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__41_6_Internal_Void_GP_DeleteSnapshotResult_0;
	}
}
