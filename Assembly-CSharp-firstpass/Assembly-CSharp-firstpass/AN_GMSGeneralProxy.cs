using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BB RID: 187
public class AN_GMSGeneralProxy : MonoBehaviour
{
	// Token: 0x06000D81 RID: 3457 RVA: 0x0004679C File Offset: 0x0004499C
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GMSGeneralProxy()
	{
		Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GMSGeneralProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr);
		AN_GMSGeneralProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GMSGeneralProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664942);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_GetPlayServicesStatus_Public_Static_GP_PlayServicesStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664943);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadGoogleAccountNames_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664944);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_clearDefaultAccount_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664945);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_signOut_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664946);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceInit_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664947);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_setConnectionParams_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664948);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664949);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664950);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664951);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadToken_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664952);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_invalidateToken_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664953);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceDisconnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664954);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_showAchievementsUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664955);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoardsUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664956);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadConnectedPlayers_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664957);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoard_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664958);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoardById_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664959);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_submitScore_Public_Static_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664960);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_submitScoreById_Public_Static_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664961);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadLeaderBoards_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664962);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadLeaderboardInfoLocal_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664963);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadPlayerCenteredScores_Public_Static_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664964);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadTopScores_Public_Static_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664965);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_reportAchievement_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664966);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_reportAchievementById_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664967);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_revealAchievement_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664968);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_revealAchievementById_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664969);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_incrementAchievement_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664970);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_incrementAchievementById_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664971);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_setStepsImmediate_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664972);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_loadAchievements_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664973);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_resetAchievement_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664974);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_ResetAllAchievements_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664975);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_resetLeaderBoard_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664976);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_OnApplicationPause_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664977);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_ShowSavedGamesUI_Bridge_Public_Static_Void_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664978);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_CreateNewSpanshot_Bridge_Public_Static_Void_String_String_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664979);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_ResolveSnapshotsConflict_Bridge_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664980);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_LoadSpanshots_Bridge_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664981);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_OpenSpanshotByName_Bridge_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664982);
		AN_GMSGeneralProxy.NativeMethodInfoPtr_DeleteSpanshotByName_Bridge_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664983);
		AN_GMSGeneralProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr, 100664984);
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00046B3C File Offset: 0x00044D3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177347, XrefRangeEnd = 177348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00046B94 File Offset: 0x00044D94
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GP_PlayServicesStatus GetPlayServicesStatus()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_GetPlayServicesStatus_Public_Static_GP_PlayServicesStatus_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00046BC4 File Offset: 0x00044DC4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177353, RefRangeEnd = 177354, XrefRangeStart = 177348, XrefRangeEnd = 177353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadGoogleAccountNames()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadGoogleAccountNames_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00046BEC File Offset: 0x00044DEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177359, RefRangeEnd = 177360, XrefRangeStart = 177354, XrefRangeEnd = 177359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearDefaultAccount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_clearDefaultAccount_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00046C14 File Offset: 0x00044E14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177365, RefRangeEnd = 177366, XrefRangeStart = 177360, XrefRangeEnd = 177365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void signOut()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_signOut_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x00046C3C File Offset: 0x00044E3C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177372, RefRangeEnd = 177373, XrefRangeStart = 177366, XrefRangeEnd = 177372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playServiceInit(string scopes)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scopes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceInit_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x00046C74 File Offset: 0x00044E74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177380, RefRangeEnd = 177381, XrefRangeStart = 177373, XrefRangeEnd = 177380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setConnectionParams(bool showPopup)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref showPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_setConnectionParams_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00046CA8 File Offset: 0x00044EA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177386, RefRangeEnd = 177387, XrefRangeStart = 177381, XrefRangeEnd = 177386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playServiceConnect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00046CD0 File Offset: 0x00044ED0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177393, RefRangeEnd = 177394, XrefRangeStart = 177387, XrefRangeEnd = 177393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playServiceConnect(string accountName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00046D08 File Offset: 0x00044F08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177400, RefRangeEnd = 177401, XrefRangeStart = 177394, XrefRangeEnd = 177400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGamesServerAuthCode(string serverClientId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(serverClientId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x00046D40 File Offset: 0x00044F40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177408, RefRangeEnd = 177410, XrefRangeStart = 177401, XrefRangeEnd = 177408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadToken(string accountName, string scope)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scope);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadToken_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00046D88 File Offset: 0x00044F88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177416, RefRangeEnd = 177417, XrefRangeStart = 177410, XrefRangeEnd = 177416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void invalidateToken(string token)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_invalidateToken_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00046DC0 File Offset: 0x00044FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177422, RefRangeEnd = 177423, XrefRangeStart = 177417, XrefRangeEnd = 177422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playServiceDisconnect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_playServiceDisconnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00046DE8 File Offset: 0x00044FE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177428, RefRangeEnd = 177429, XrefRangeStart = 177423, XrefRangeEnd = 177428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showAchievementsUI()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_showAchievementsUI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00046E10 File Offset: 0x00045010
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177434, RefRangeEnd = 177435, XrefRangeStart = 177429, XrefRangeEnd = 177434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showLeaderBoardsUI()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoardsUI_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00046E38 File Offset: 0x00045038
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177440, RefRangeEnd = 177442, XrefRangeStart = 177435, XrefRangeEnd = 177440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadConnectedPlayers()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadConnectedPlayers_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00046E60 File Offset: 0x00045060
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177448, RefRangeEnd = 177449, XrefRangeStart = 177442, XrefRangeEnd = 177448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showLeaderBoard(string leaderboardName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoard_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00046E98 File Offset: 0x00045098
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177455, RefRangeEnd = 177456, XrefRangeStart = 177449, XrefRangeEnd = 177455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showLeaderBoardById(string leaderboardId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_showLeaderBoardById_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00046ED0 File Offset: 0x000450D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177465, RefRangeEnd = 177466, XrefRangeStart = 177456, XrefRangeEnd = 177465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void submitScore(string leaderboardName, long score, string tag)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_submitScore_Public_Static_Void_String_Int64_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00046F28 File Offset: 0x00045128
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177475, RefRangeEnd = 177476, XrefRangeStart = 177466, XrefRangeEnd = 177475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void submitScoreById(string leaderboardId, long score, string tag)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_submitScoreById_Public_Static_Void_String_Int64_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00046F80 File Offset: 0x00045180
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177481, RefRangeEnd = 177482, XrefRangeStart = 177476, XrefRangeEnd = 177481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadLeaderBoards()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadLeaderBoards_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00046FA8 File Offset: 0x000451A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177492, RefRangeEnd = 177493, XrefRangeStart = 177482, XrefRangeEnd = 177492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadLeaderboardInfoLocal(string leaderboardId, int requestId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadLeaderboardInfoLocal_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00046FEC File Offset: 0x000451EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177505, RefRangeEnd = 177506, XrefRangeStart = 177493, XrefRangeEnd = 177505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadPlayerCenteredScores(string leaderboardId, int span, int leaderboardCollection, int maxResults)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaderboardCollection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxResults;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadPlayerCenteredScores_Public_Static_Void_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0004704C File Offset: 0x0004524C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177518, RefRangeEnd = 177519, XrefRangeStart = 177506, XrefRangeEnd = 177518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadTopScores(string leaderboardId, int span, int leaderboardCollection, int maxResults)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaderboardCollection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxResults;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadTopScores_Public_Static_Void_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x000470AC File Offset: 0x000452AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177525, RefRangeEnd = 177526, XrefRangeStart = 177519, XrefRangeEnd = 177525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reportAchievement(string achievementName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_reportAchievement_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x000470E4 File Offset: 0x000452E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177532, RefRangeEnd = 177533, XrefRangeStart = 177526, XrefRangeEnd = 177532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reportAchievementById(string achievementId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_reportAchievementById_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0004711C File Offset: 0x0004531C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177539, RefRangeEnd = 177540, XrefRangeStart = 177533, XrefRangeEnd = 177539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void revealAchievement(string achievementName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_revealAchievement_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00047154 File Offset: 0x00045354
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177546, RefRangeEnd = 177547, XrefRangeStart = 177540, XrefRangeEnd = 177546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void revealAchievementById(string achievementId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_revealAchievementById_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0004718C File Offset: 0x0004538C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177554, RefRangeEnd = 177555, XrefRangeStart = 177547, XrefRangeEnd = 177554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void incrementAchievement(string achievementName, string numsteps)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(numsteps);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_incrementAchievement_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x000471D4 File Offset: 0x000453D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177562, RefRangeEnd = 177563, XrefRangeStart = 177555, XrefRangeEnd = 177562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void incrementAchievementById(string achievementId, string numsteps)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(numsteps);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_incrementAchievementById_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0004721C File Offset: 0x0004541C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177570, RefRangeEnd = 177571, XrefRangeStart = 177563, XrefRangeEnd = 177570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setStepsImmediate(string achievementId, string numsteps)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(numsteps);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_setStepsImmediate_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x00047264 File Offset: 0x00045464
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177576, RefRangeEnd = 177577, XrefRangeStart = 177571, XrefRangeEnd = 177576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadAchievements()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_loadAchievements_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0004728C File Offset: 0x0004548C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177583, RefRangeEnd = 177584, XrefRangeStart = 177577, XrefRangeEnd = 177583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetAchievement(string achievementId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_resetAchievement_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x000472C4 File Offset: 0x000454C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177589, RefRangeEnd = 177590, XrefRangeStart = 177584, XrefRangeEnd = 177589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAllAchievements()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_ResetAllAchievements_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x000472EC File Offset: 0x000454EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177596, RefRangeEnd = 177597, XrefRangeStart = 177590, XrefRangeEnd = 177596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetLeaderBoard(string leaderboardId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_resetLeaderBoard_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x00047324 File Offset: 0x00045524
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177606, RefRangeEnd = 177607, XrefRangeStart = 177597, XrefRangeEnd = 177606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnApplicationPause(bool isPaused)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isPaused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_OnApplicationPause_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00047358 File Offset: 0x00045558
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177624, RefRangeEnd = 177625, XrefRangeStart = 177607, XrefRangeEnd = 177624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowSavedGamesUI_Bridge(string title, int maxNumberOfSavedGamesToShow, bool allowAddButton, bool allowDelete)
	{
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_ShowSavedGamesUI_Bridge_Public_Static_Void_String_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x000473B8 File Offset: 0x000455B8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177638, RefRangeEnd = 177640, XrefRangeStart = 177625, XrefRangeEnd = 177638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateNewSpanshot_Bridge(string name, string description, string ImageData, string Data, long PlayedTime)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ImageData);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Data);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PlayedTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_CreateNewSpanshot_Bridge_Public_Static_Void_String_String_String_String_Int64_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00047434 File Offset: 0x00045634
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177649, RefRangeEnd = 177651, XrefRangeStart = 177640, XrefRangeEnd = 177649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResolveSnapshotsConflict_Bridge(int index)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_ResolveSnapshotsConflict_Bridge_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00047468 File Offset: 0x00045668
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177656, RefRangeEnd = 177657, XrefRangeStart = 177651, XrefRangeEnd = 177656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadSpanshots_Bridge()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_LoadSpanshots_Bridge_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x00047490 File Offset: 0x00045690
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177663, RefRangeEnd = 177664, XrefRangeStart = 177657, XrefRangeEnd = 177663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenSpanshotByName_Bridge(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_OpenSpanshotByName_Bridge_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x000474C8 File Offset: 0x000456C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177670, RefRangeEnd = 177671, XrefRangeStart = 177664, XrefRangeEnd = 177670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteSpanshotByName_Bridge(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr_DeleteSpanshotByName_Bridge_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x00047500 File Offset: 0x00045700
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GMSGeneralProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GMSGeneralProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSGeneralProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00007561 File Offset: 0x00005761
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GMSGeneralProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0000756F File Offset: 0x0000576F
	public AN_GMSGeneralProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06000DAF RID: 3503 RVA: 0x0004753C File Offset: 0x0004573C
	// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00007578 File Offset: 0x00005778
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GMSGeneralProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GMSGeneralProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A7D RID: 2685
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A7E RID: 2686
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A7F RID: 2687
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayServicesStatus_Public_Static_GP_PlayServicesStatus_0;

	// Token: 0x04000A80 RID: 2688
	private static readonly IntPtr NativeMethodInfoPtr_loadGoogleAccountNames_Public_Static_Void_0;

	// Token: 0x04000A81 RID: 2689
	private static readonly IntPtr NativeMethodInfoPtr_clearDefaultAccount_Public_Static_Void_0;

	// Token: 0x04000A82 RID: 2690
	private static readonly IntPtr NativeMethodInfoPtr_signOut_Public_Static_Void_0;

	// Token: 0x04000A83 RID: 2691
	private static readonly IntPtr NativeMethodInfoPtr_playServiceInit_Public_Static_Void_String_0;

	// Token: 0x04000A84 RID: 2692
	private static readonly IntPtr NativeMethodInfoPtr_setConnectionParams_Public_Static_Void_Boolean_0;

	// Token: 0x04000A85 RID: 2693
	private static readonly IntPtr NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_0;

	// Token: 0x04000A86 RID: 2694
	private static readonly IntPtr NativeMethodInfoPtr_playServiceConnect_Public_Static_Void_String_0;

	// Token: 0x04000A87 RID: 2695
	private static readonly IntPtr NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Static_Void_String_0;

	// Token: 0x04000A88 RID: 2696
	private static readonly IntPtr NativeMethodInfoPtr_loadToken_Public_Static_Void_String_String_0;

	// Token: 0x04000A89 RID: 2697
	private static readonly IntPtr NativeMethodInfoPtr_invalidateToken_Public_Static_Void_String_0;

	// Token: 0x04000A8A RID: 2698
	private static readonly IntPtr NativeMethodInfoPtr_playServiceDisconnect_Public_Static_Void_0;

	// Token: 0x04000A8B RID: 2699
	private static readonly IntPtr NativeMethodInfoPtr_showAchievementsUI_Public_Static_Void_0;

	// Token: 0x04000A8C RID: 2700
	private static readonly IntPtr NativeMethodInfoPtr_showLeaderBoardsUI_Public_Static_Void_0;

	// Token: 0x04000A8D RID: 2701
	private static readonly IntPtr NativeMethodInfoPtr_loadConnectedPlayers_Public_Static_Void_0;

	// Token: 0x04000A8E RID: 2702
	private static readonly IntPtr NativeMethodInfoPtr_showLeaderBoard_Public_Static_Void_String_0;

	// Token: 0x04000A8F RID: 2703
	private static readonly IntPtr NativeMethodInfoPtr_showLeaderBoardById_Public_Static_Void_String_0;

	// Token: 0x04000A90 RID: 2704
	private static readonly IntPtr NativeMethodInfoPtr_submitScore_Public_Static_Void_String_Int64_String_0;

	// Token: 0x04000A91 RID: 2705
	private static readonly IntPtr NativeMethodInfoPtr_submitScoreById_Public_Static_Void_String_Int64_String_0;

	// Token: 0x04000A92 RID: 2706
	private static readonly IntPtr NativeMethodInfoPtr_loadLeaderBoards_Public_Static_Void_0;

	// Token: 0x04000A93 RID: 2707
	private static readonly IntPtr NativeMethodInfoPtr_loadLeaderboardInfoLocal_Public_Static_Void_String_Int32_0;

	// Token: 0x04000A94 RID: 2708
	private static readonly IntPtr NativeMethodInfoPtr_loadPlayerCenteredScores_Public_Static_Void_String_Int32_Int32_Int32_0;

	// Token: 0x04000A95 RID: 2709
	private static readonly IntPtr NativeMethodInfoPtr_loadTopScores_Public_Static_Void_String_Int32_Int32_Int32_0;

	// Token: 0x04000A96 RID: 2710
	private static readonly IntPtr NativeMethodInfoPtr_reportAchievement_Public_Static_Void_String_0;

	// Token: 0x04000A97 RID: 2711
	private static readonly IntPtr NativeMethodInfoPtr_reportAchievementById_Public_Static_Void_String_0;

	// Token: 0x04000A98 RID: 2712
	private static readonly IntPtr NativeMethodInfoPtr_revealAchievement_Public_Static_Void_String_0;

	// Token: 0x04000A99 RID: 2713
	private static readonly IntPtr NativeMethodInfoPtr_revealAchievementById_Public_Static_Void_String_0;

	// Token: 0x04000A9A RID: 2714
	private static readonly IntPtr NativeMethodInfoPtr_incrementAchievement_Public_Static_Void_String_String_0;

	// Token: 0x04000A9B RID: 2715
	private static readonly IntPtr NativeMethodInfoPtr_incrementAchievementById_Public_Static_Void_String_String_0;

	// Token: 0x04000A9C RID: 2716
	private static readonly IntPtr NativeMethodInfoPtr_setStepsImmediate_Public_Static_Void_String_String_0;

	// Token: 0x04000A9D RID: 2717
	private static readonly IntPtr NativeMethodInfoPtr_loadAchievements_Public_Static_Void_0;

	// Token: 0x04000A9E RID: 2718
	private static readonly IntPtr NativeMethodInfoPtr_resetAchievement_Public_Static_Void_String_0;

	// Token: 0x04000A9F RID: 2719
	private static readonly IntPtr NativeMethodInfoPtr_ResetAllAchievements_Public_Static_Void_0;

	// Token: 0x04000AA0 RID: 2720
	private static readonly IntPtr NativeMethodInfoPtr_resetLeaderBoard_Public_Static_Void_String_0;

	// Token: 0x04000AA1 RID: 2721
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Public_Static_Void_Boolean_0;

	// Token: 0x04000AA2 RID: 2722
	private static readonly IntPtr NativeMethodInfoPtr_ShowSavedGamesUI_Bridge_Public_Static_Void_String_Int32_Boolean_Boolean_0;

	// Token: 0x04000AA3 RID: 2723
	private static readonly IntPtr NativeMethodInfoPtr_CreateNewSpanshot_Bridge_Public_Static_Void_String_String_String_String_Int64_0;

	// Token: 0x04000AA4 RID: 2724
	private static readonly IntPtr NativeMethodInfoPtr_ResolveSnapshotsConflict_Bridge_Public_Static_Void_Int32_0;

	// Token: 0x04000AA5 RID: 2725
	private static readonly IntPtr NativeMethodInfoPtr_LoadSpanshots_Bridge_Public_Static_Void_0;

	// Token: 0x04000AA6 RID: 2726
	private static readonly IntPtr NativeMethodInfoPtr_OpenSpanshotByName_Bridge_Public_Static_Void_String_0;

	// Token: 0x04000AA7 RID: 2727
	private static readonly IntPtr NativeMethodInfoPtr_DeleteSpanshotByName_Bridge_Public_Static_Void_String_0;

	// Token: 0x04000AA8 RID: 2728
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
