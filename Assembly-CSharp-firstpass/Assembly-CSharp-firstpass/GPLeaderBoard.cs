using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000047 RID: 71
[Serializable]
public class GPLeaderBoard : global::Il2CppSystem.Object
{
	// Token: 0x060005D8 RID: 1496 RVA: 0x0002AFA8 File Offset: 0x000291A8
	// Note: this type is marked as 'beforefieldinit'.
	static GPLeaderBoard()
	{
		Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPLeaderBoard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr);
		GPLeaderBoard.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "IsOpen");
		GPLeaderBoard.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_id");
		GPLeaderBoard.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_name");
		GPLeaderBoard.NativeFieldInfoPtr__description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_description");
		GPLeaderBoard.NativeFieldInfoPtr__Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_Texture");
		GPLeaderBoard.NativeFieldInfoPtr__CurrentPlayerScoreLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_CurrentPlayerScoreLoaded");
		GPLeaderBoard.NativeFieldInfoPtr_SocsialCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "SocsialCollection");
		GPLeaderBoard.NativeFieldInfoPtr_GlobalCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "GlobalCollection");
		GPLeaderBoard.NativeFieldInfoPtr_CurrentPlayerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "CurrentPlayerScore");
		GPLeaderBoard.NativeFieldInfoPtr__ScoreUpdateListners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, "_ScoreUpdateListners");
		GPLeaderBoard.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664014);
		GPLeaderBoard.NativeMethodInfoPtr_UpdateName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664015);
		GPLeaderBoard.NativeMethodInfoPtr_GetScoresList_Public_List_1_GPScore_GPBoardTimeSpan_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664016);
		GPLeaderBoard.NativeMethodInfoPtr_GetScoreByPlayerId_Public_GPScore_String_GPBoardTimeSpan_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664017);
		GPLeaderBoard.NativeMethodInfoPtr_GetScore_Public_GPScore_Int32_GPBoardTimeSpan_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664018);
		GPLeaderBoard.NativeMethodInfoPtr_GetCurrentPlayerScore_Public_GPScore_GPBoardTimeSpan_GPCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664019);
		GPLeaderBoard.NativeMethodInfoPtr_CreateScoreListener_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664020);
		GPLeaderBoard.NativeMethodInfoPtr_ReportLocalPlayerScoreUpdate_Public_Void_GPScore_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664021);
		GPLeaderBoard.NativeMethodInfoPtr_ReportLocalPlayerScoreUpdateFail_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664022);
		GPLeaderBoard.NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_List_1_GPScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664023);
		GPLeaderBoard.NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_GPScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664024);
		GPLeaderBoard.NativeMethodInfoPtr_UpdateScore_Public_Void_GPScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664025);
		GPLeaderBoard.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664026);
		GPLeaderBoard.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664027);
		GPLeaderBoard.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664028);
		GPLeaderBoard.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664029);
		GPLeaderBoard.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664030);
		GPLeaderBoard.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664031);
		GPLeaderBoard.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664032);
		GPLeaderBoard.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664033);
		GPLeaderBoard.NativeMethodInfoPtr_get_CurrentPlayerScoreLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664034);
		GPLeaderBoard.NativeMethodInfoPtr_get_ScoreUpdateListners_Private_get_Dictionary_2_Int32_GP_LocalPlayerScoreUpdateListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr, 100664035);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002B258 File Offset: 0x00029458
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166260, XrefRangeEnd = 166278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPLeaderBoard(string lId, string lName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPLeaderBoard>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0002B2B8 File Offset: 0x000294B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateName(string lName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(lName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_UpdateName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0002B2FC File Offset: 0x000294FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166291, RefRangeEnd = 166292, XrefRangeStart = 166278, XrefRangeEnd = 166291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<GPScore> GetScoresList(GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref timeSpan;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_GetScoresList_Public_List_1_GPScore_GPBoardTimeSpan_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GPScore>>(intPtr3) : null;
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0002B358 File Offset: 0x00029558
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166292, XrefRangeEnd = 166322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPScore GetScoreByPlayerId(string playerId, GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSpan;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_GetScoreByPlayerId_Public_GPScore_String_GPBoardTimeSpan_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPScore>(intPtr3) : null;
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0002B3C4 File Offset: 0x000295C4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166327, RefRangeEnd = 166329, XrefRangeStart = 166322, XrefRangeEnd = 166327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPScore GetScore(int rank, GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rank;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSpan;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_GetScore_Public_GPScore_Int32_GPBoardTimeSpan_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPScore>(intPtr3) : null;
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0002B42C File Offset: 0x0002962C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 166345, RefRangeEnd = 166353, XrefRangeStart = 166329, XrefRangeEnd = 166345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPScore GetCurrentPlayerScore(GPBoardTimeSpan timeSpan, GPCollectionType collection)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref timeSpan;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_GetCurrentPlayerScore_Public_GPScore_GPBoardTimeSpan_GPCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPScore>(intPtr3) : null;
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0002B488 File Offset: 0x00029688
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166353, XrefRangeEnd = 166373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateScoreListener(int requestId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref requestId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_CreateScoreListener_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0002B4C8 File Offset: 0x000296C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166373, XrefRangeEnd = 166381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportLocalPlayerScoreUpdate(GPScore score, int requestId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_ReportLocalPlayerScoreUpdate_Public_Void_GPScore_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0002B518 File Offset: 0x00029718
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166381, XrefRangeEnd = 166395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportLocalPlayerScoreUpdateFail(string errorData, int requestId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_ReportLocalPlayerScoreUpdateFail_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0002B568 File Offset: 0x00029768
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166415, RefRangeEnd = 166416, XrefRangeStart = 166395, XrefRangeEnd = 166415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCurrentPlayerScore(List<GPScore> newScores)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newScores);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_List_1_GPScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002B5AC File Offset: 0x000297AC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166423, RefRangeEnd = 166425, XrefRangeStart = 166416, XrefRangeEnd = 166423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCurrentPlayerScore(GPScore score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_GPScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002B5F0 File Offset: 0x000297F0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166436, RefRangeEnd = 166438, XrefRangeStart = 166425, XrefRangeEnd = 166436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateScore(GPScore score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_UpdateScore_Public_Void_GPScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0002B634 File Offset: 0x00029834
	// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0002B66C File Offset: 0x0002986C
	public unsafe string Id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0002B6B0 File Offset: 0x000298B0
	// (set) Token: 0x060005E8 RID: 1512 RVA: 0x0002B6E8 File Offset: 0x000298E8
	public unsafe string Name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0002B72C File Offset: 0x0002992C
	// (set) Token: 0x060005EA RID: 1514 RVA: 0x0002B764 File Offset: 0x00029964
	public unsafe string Description
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x060005EB RID: 1515 RVA: 0x0002B7A8 File Offset: 0x000299A8
	// (set) Token: 0x060005EC RID: 1516 RVA: 0x0002B7E8 File Offset: 0x000299E8
	public unsafe Texture2D Texture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170001F5 RID: 501
	// (get) Token: 0x060005ED RID: 1517 RVA: 0x0002B82C File Offset: 0x00029A2C
	public unsafe bool CurrentPlayerScoreLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_CurrentPlayerScoreLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001F6 RID: 502
	// (get) Token: 0x060005EE RID: 1518 RVA: 0x0002B868 File Offset: 0x00029A68
	public unsafe Dictionary<int, GP_LocalPlayerScoreUpdateListener> ScoreUpdateListners
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166438, XrefRangeEnd = 166444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPLeaderBoard.NativeMethodInfoPtr_get_ScoreUpdateListners_Private_get_Dictionary_2_Int32_GP_LocalPlayerScoreUpdateListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GP_LocalPlayerScoreUpdateListener>>(intPtr3) : null;
		}
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00004565 File Offset: 0x00002765
	public GPLeaderBoard(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x060005F0 RID: 1520 RVA: 0x0002B8A8 File Offset: 0x00029AA8
	// (set) Token: 0x060005F1 RID: 1521 RVA: 0x0000456E File Offset: 0x0000276E
	public unsafe bool IsOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_IsOpen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_IsOpen)) = value;
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0002B8D0 File Offset: 0x00029AD0
	// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00004589 File Offset: 0x00002789
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0002B8F8 File Offset: 0x00029AF8
	// (set) Token: 0x060005F5 RID: 1525 RVA: 0x000045A8 File Offset: 0x000027A8
	public unsafe string _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0002B920 File Offset: 0x00029B20
	// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000045C7 File Offset: 0x000027C7
	public unsafe string _description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0002B948 File Offset: 0x00029B48
	// (set) Token: 0x060005F9 RID: 1529 RVA: 0x000045E6 File Offset: 0x000027E6
	public unsafe Texture2D _Texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__Texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x060005FA RID: 1530 RVA: 0x0002B978 File Offset: 0x00029B78
	// (set) Token: 0x060005FB RID: 1531 RVA: 0x00004605 File Offset: 0x00002805
	public unsafe bool _CurrentPlayerScoreLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__CurrentPlayerScoreLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__CurrentPlayerScoreLoaded)) = value;
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x060005FC RID: 1532 RVA: 0x0002B9A0 File Offset: 0x00029BA0
	// (set) Token: 0x060005FD RID: 1533 RVA: 0x00004620 File Offset: 0x00002820
	public unsafe GPScoreCollection SocsialCollection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_SocsialCollection);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPScoreCollection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_SocsialCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x060005FE RID: 1534 RVA: 0x0002B9D0 File Offset: 0x00029BD0
	// (set) Token: 0x060005FF RID: 1535 RVA: 0x0000463F File Offset: 0x0000283F
	public unsafe GPScoreCollection GlobalCollection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_GlobalCollection);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPScoreCollection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_GlobalCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06000600 RID: 1536 RVA: 0x0002BA00 File Offset: 0x00029C00
	// (set) Token: 0x06000601 RID: 1537 RVA: 0x0000465E File Offset: 0x0000285E
	public unsafe List<GPScore> CurrentPlayerScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_CurrentPlayerScore);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GPScore>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr_CurrentPlayerScore), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x06000602 RID: 1538 RVA: 0x0002BA30 File Offset: 0x00029C30
	// (set) Token: 0x06000603 RID: 1539 RVA: 0x0000467D File Offset: 0x0000287D
	public unsafe Dictionary<int, GP_LocalPlayerScoreUpdateListener> _ScoreUpdateListners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__ScoreUpdateListners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GP_LocalPlayerScoreUpdateListener>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPLeaderBoard.NativeFieldInfoPtr__ScoreUpdateListners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004DF RID: 1247
	private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

	// Token: 0x040004E0 RID: 1248
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x040004E1 RID: 1249
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x040004E2 RID: 1250
	private static readonly IntPtr NativeFieldInfoPtr__description;

	// Token: 0x040004E3 RID: 1251
	private static readonly IntPtr NativeFieldInfoPtr__Texture;

	// Token: 0x040004E4 RID: 1252
	private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerScoreLoaded;

	// Token: 0x040004E5 RID: 1253
	private static readonly IntPtr NativeFieldInfoPtr_SocsialCollection;

	// Token: 0x040004E6 RID: 1254
	private static readonly IntPtr NativeFieldInfoPtr_GlobalCollection;

	// Token: 0x040004E7 RID: 1255
	private static readonly IntPtr NativeFieldInfoPtr_CurrentPlayerScore;

	// Token: 0x040004E8 RID: 1256
	private static readonly IntPtr NativeFieldInfoPtr__ScoreUpdateListners;

	// Token: 0x040004E9 RID: 1257
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x040004EA RID: 1258
	private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Public_Void_String_0;

	// Token: 0x040004EB RID: 1259
	private static readonly IntPtr NativeMethodInfoPtr_GetScoresList_Public_List_1_GPScore_GPBoardTimeSpan_GPCollectionType_0;

	// Token: 0x040004EC RID: 1260
	private static readonly IntPtr NativeMethodInfoPtr_GetScoreByPlayerId_Public_GPScore_String_GPBoardTimeSpan_GPCollectionType_0;

	// Token: 0x040004ED RID: 1261
	private static readonly IntPtr NativeMethodInfoPtr_GetScore_Public_GPScore_Int32_GPBoardTimeSpan_GPCollectionType_0;

	// Token: 0x040004EE RID: 1262
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlayerScore_Public_GPScore_GPBoardTimeSpan_GPCollectionType_0;

	// Token: 0x040004EF RID: 1263
	private static readonly IntPtr NativeMethodInfoPtr_CreateScoreListener_Public_Void_Int32_0;

	// Token: 0x040004F0 RID: 1264
	private static readonly IntPtr NativeMethodInfoPtr_ReportLocalPlayerScoreUpdate_Public_Void_GPScore_Int32_0;

	// Token: 0x040004F1 RID: 1265
	private static readonly IntPtr NativeMethodInfoPtr_ReportLocalPlayerScoreUpdateFail_Public_Void_String_Int32_0;

	// Token: 0x040004F2 RID: 1266
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_List_1_GPScore_0;

	// Token: 0x040004F3 RID: 1267
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentPlayerScore_Public_Void_GPScore_0;

	// Token: 0x040004F4 RID: 1268
	private static readonly IntPtr NativeMethodInfoPtr_UpdateScore_Public_Void_GPScore_0;

	// Token: 0x040004F5 RID: 1269
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

	// Token: 0x040004F6 RID: 1270
	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

	// Token: 0x040004F7 RID: 1271
	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	// Token: 0x040004F8 RID: 1272
	private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

	// Token: 0x040004F9 RID: 1273
	private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

	// Token: 0x040004FA RID: 1274
	private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

	// Token: 0x040004FB RID: 1275
	private static readonly IntPtr NativeMethodInfoPtr_get_Texture_Public_get_Texture2D_0;

	// Token: 0x040004FC RID: 1276
	private static readonly IntPtr NativeMethodInfoPtr_set_Texture_Public_set_Void_Texture2D_0;

	// Token: 0x040004FD RID: 1277
	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerScoreLoaded_Public_get_Boolean_0;

	// Token: 0x040004FE RID: 1278
	private static readonly IntPtr NativeMethodInfoPtr_get_ScoreUpdateListners_Private_get_Dictionary_2_Int32_GP_LocalPlayerScoreUpdateListener_0;
}
