using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000073 RID: 115
public class GooglePlayTBM : Singleton<GooglePlayTBM>
{
	// Token: 0x06000869 RID: 2153 RVA: 0x00033CC0 File Offset: 0x00031EC0
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayTBM()
	{
		Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayTBM");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr);
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchesResultLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchesResultLoaded");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInitiated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchInitiated");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchCanceled");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchLeaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchLeaved");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchDataLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchDataLoaded");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchUpdated");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchTurnFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchTurnFinished");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchReceived");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchRemoved");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCreationCanceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchCreationCanceled");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchInvitationAccepted");
		GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationDeclined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "ActionMatchInvitationDeclined");
		GooglePlayTBM.NativeFieldInfoPtr__Matches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "_Matches");
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchesResultLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664309);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchesResultLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664310);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInitiated_Public_Static_add_Void_Action_1_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664311);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInitiated_Public_Static_rem_Void_Action_1_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664312);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchCanceled_Public_Static_add_Void_Action_1_GP_TBM_CancelMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664313);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchCanceled_Public_Static_rem_Void_Action_1_GP_TBM_CancelMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664314);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchLeaved_Public_Static_add_Void_Action_1_GP_TBM_LeaveMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664315);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchLeaved_Public_Static_rem_Void_Action_1_GP_TBM_LeaveMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664316);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchDataLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664317);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchDataLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664318);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchUpdated_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664319);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchUpdated_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664320);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchTurnFinished_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664321);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchTurnFinished_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664322);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchReceived_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664323);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchReceived_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664324);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchRemoved_Public_Static_add_Void_Action_1_GP_TBM_MatchRemovedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664325);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchRemoved_Public_Static_rem_Void_Action_1_GP_TBM_MatchRemovedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664326);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchCreationCanceled_Public_Static_add_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664327);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchCreationCanceled_Public_Static_rem_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664328);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInvitationAccepted_Public_Static_add_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664329);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInvitationAccepted_Public_Static_rem_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664330);
		GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInvitationDeclined_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664331);
		GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInvitationDeclined_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664332);
		GooglePlayTBM.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664333);
		GooglePlayTBM.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664334);
		GooglePlayTBM.NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664335);
		GooglePlayTBM.NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664336);
		GooglePlayTBM.NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664337);
		GooglePlayTBM.NativeMethodInfoPtr_CreateMatch_Public_Void_Int32_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664338);
		GooglePlayTBM.NativeMethodInfoPtr_CancelMatch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664339);
		GooglePlayTBM.NativeMethodInfoPtr_DismissMatch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664340);
		GooglePlayTBM.NativeMethodInfoPtr_ConfirmMatchFinish_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664341);
		GooglePlayTBM.NativeMethodInfoPtr_ConfirmhMatchFinis_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664342);
		GooglePlayTBM.NativeMethodInfoPtr_FinishMatch_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_GP_ParticipantResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664343);
		GooglePlayTBM.NativeMethodInfoPtr_LeaveMatch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664344);
		GooglePlayTBM.NativeMethodInfoPtr_LeaveMatchDuringTurn_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664345);
		GooglePlayTBM.NativeMethodInfoPtr_LoadMatchInfo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664346);
		GooglePlayTBM.NativeMethodInfoPtr_LoadMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_Il2CppStructArray_1_GP_TBM_MatchTurnStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664347);
		GooglePlayTBM.NativeMethodInfoPtr_LoadAllMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664348);
		GooglePlayTBM.NativeMethodInfoPtr_Rematch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664349);
		GooglePlayTBM.NativeMethodInfoPtr_RegisterMatchUpdateListener_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664350);
		GooglePlayTBM.NativeMethodInfoPtr_UnregisterMatchUpdateListener_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664351);
		GooglePlayTBM.NativeMethodInfoPtr_TakeTrun_Public_Void_String_Il2CppStructArray_1_Byte_String_Il2CppReferenceArray_1_GP_ParticipantResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664352);
		GooglePlayTBM.NativeMethodInfoPtr_StartSelectOpponentsView_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664353);
		GooglePlayTBM.NativeMethodInfoPtr_ShowInbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664354);
		GooglePlayTBM.NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664355);
		GooglePlayTBM.NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664356);
		GooglePlayTBM.NativeMethodInfoPtr_get_Matches_Public_get_Dictionary_2_String_GP_TBM_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664357);
		GooglePlayTBM.NativeMethodInfoPtr_OnLoadMatchesResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664358);
		GooglePlayTBM.NativeMethodInfoPtr_OnMatchInitiatedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664359);
		GooglePlayTBM.NativeMethodInfoPtr_OnInvitationAcceptedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664360);
		GooglePlayTBM.NativeMethodInfoPtr_OnCancelMatchResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664361);
		GooglePlayTBM.NativeMethodInfoPtr_OnLeaveMatchResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664362);
		GooglePlayTBM.NativeMethodInfoPtr_OnLoadMatchResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664363);
		GooglePlayTBM.NativeMethodInfoPtr_OnUpdateMatchResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664364);
		GooglePlayTBM.NativeMethodInfoPtr_AN_OnTurnResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664365);
		GooglePlayTBM.NativeMethodInfoPtr_OnTurnBasedMatchRemoved_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664366);
		GooglePlayTBM.NativeMethodInfoPtr_OnTurnBasedMatchReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664367);
		GooglePlayTBM.NativeMethodInfoPtr_OnMatchCreationCanceled_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664368);
		GooglePlayTBM.NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664369);
		GooglePlayTBM.NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664370);
		GooglePlayTBM.NativeMethodInfoPtr_UpdateMatchInfo_Private_Void_GP_TBM_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664371);
		GooglePlayTBM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, 100664372);
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x000342F4 File Offset: 0x000324F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169281, XrefRangeEnd = 169292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchesResultLoaded(Action<GP_TBM_LoadMatchesResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchesResultLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchesResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0003432C File Offset: 0x0003252C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169292, XrefRangeEnd = 169303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchesResultLoaded(Action<GP_TBM_LoadMatchesResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchesResultLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchesResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x00034364 File Offset: 0x00032564
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169314, RefRangeEnd = 169315, XrefRangeStart = 169303, XrefRangeEnd = 169314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchInitiated(Action<GP_TBM_MatchInitiatedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInitiated_Public_Static_add_Void_Action_1_GP_TBM_MatchInitiatedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0003439C File Offset: 0x0003259C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169315, XrefRangeEnd = 169326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchInitiated(Action<GP_TBM_MatchInitiatedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInitiated_Public_Static_rem_Void_Action_1_GP_TBM_MatchInitiatedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x000343D4 File Offset: 0x000325D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169326, XrefRangeEnd = 169337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchCanceled(Action<GP_TBM_CancelMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchCanceled_Public_Static_add_Void_Action_1_GP_TBM_CancelMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0003440C File Offset: 0x0003260C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169337, XrefRangeEnd = 169348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchCanceled(Action<GP_TBM_CancelMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchCanceled_Public_Static_rem_Void_Action_1_GP_TBM_CancelMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x00034444 File Offset: 0x00032644
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169348, XrefRangeEnd = 169359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchLeaved(Action<GP_TBM_LeaveMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchLeaved_Public_Static_add_Void_Action_1_GP_TBM_LeaveMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0003447C File Offset: 0x0003267C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169359, XrefRangeEnd = 169370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchLeaved(Action<GP_TBM_LeaveMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchLeaved_Public_Static_rem_Void_Action_1_GP_TBM_LeaveMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x000344B4 File Offset: 0x000326B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169370, XrefRangeEnd = 169381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchDataLoaded(Action<GP_TBM_LoadMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchDataLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x000344EC File Offset: 0x000326EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169381, XrefRangeEnd = 169392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchDataLoaded(Action<GP_TBM_LoadMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchDataLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x00034524 File Offset: 0x00032724
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169403, RefRangeEnd = 169404, XrefRangeStart = 169392, XrefRangeEnd = 169403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchUpdated(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchUpdated_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x0003455C File Offset: 0x0003275C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169404, XrefRangeEnd = 169415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchUpdated(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchUpdated_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00034594 File Offset: 0x00032794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169415, XrefRangeEnd = 169426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchTurnFinished(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchTurnFinished_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x000345CC File Offset: 0x000327CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169426, XrefRangeEnd = 169437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchTurnFinished(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchTurnFinished_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00034604 File Offset: 0x00032804
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169437, XrefRangeEnd = 169448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchReceived(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchReceived_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x0003463C File Offset: 0x0003283C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169448, XrefRangeEnd = 169459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchReceived(Action<GP_TBM_UpdateMatchResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchReceived_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x00034674 File Offset: 0x00032874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169459, XrefRangeEnd = 169470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchRemoved(Action<GP_TBM_MatchRemovedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchRemoved_Public_Static_add_Void_Action_1_GP_TBM_MatchRemovedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000346AC File Offset: 0x000328AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169470, XrefRangeEnd = 169481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchRemoved(Action<GP_TBM_MatchRemovedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchRemoved_Public_Static_rem_Void_Action_1_GP_TBM_MatchRemovedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x000346E4 File Offset: 0x000328E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169492, RefRangeEnd = 169493, XrefRangeStart = 169481, XrefRangeEnd = 169492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchCreationCanceled(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchCreationCanceled_Public_Static_add_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0003471C File Offset: 0x0003291C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169493, XrefRangeEnd = 169504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchCreationCanceled(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchCreationCanceled_Public_Static_rem_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00034754 File Offset: 0x00032954
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169504, XrefRangeEnd = 169515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchInvitationAccepted(Action<string, GP_TBM_MatchInitiatedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInvitationAccepted_Public_Static_add_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0003478C File Offset: 0x0003298C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169515, XrefRangeEnd = 169526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchInvitationAccepted(Action<string, GP_TBM_MatchInitiatedResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInvitationAccepted_Public_Static_rem_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x000347C4 File Offset: 0x000329C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169526, XrefRangeEnd = 169537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionMatchInvitationDeclined(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_add_ActionMatchInvitationDeclined_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x000347FC File Offset: 0x000329FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169537, XrefRangeEnd = 169548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionMatchInvitationDeclined(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_remove_ActionMatchInvitationDeclined_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00034834 File Offset: 0x00032A34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169548, XrefRangeEnd = 169561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00034868 File Offset: 0x00032A68
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0003489C File Offset: 0x00032A9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169561, XrefRangeEnd = 169562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x000348E0 File Offset: 0x00032AE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169562, XrefRangeEnd = 169571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeclineInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00034924 File Offset: 0x00032B24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169571, XrefRangeEnd = 169572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DismissInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00034968 File Offset: 0x00032B68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169572, XrefRangeEnd = 169573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMatch(int minPlayers, int maxPlayers, Il2CppStringArray playersIds = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersIds);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_CreateMatch_Public_Void_Int32_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x000349C8 File Offset: 0x00032BC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169573, XrefRangeEnd = 169574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelMatch(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_CancelMatch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00034A0C File Offset: 0x00032C0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169574, XrefRangeEnd = 169575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DismissMatch(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_DismissMatch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00034A50 File Offset: 0x00032C50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169575, XrefRangeEnd = 169576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmMatchFinish(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_ConfirmMatchFinish_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00034A94 File Offset: 0x00032C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfirmhMatchFinis(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_ConfirmhMatchFinis_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00034AD8 File Offset: 0x00032CD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169576, XrefRangeEnd = 169622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishMatch(string matchId, Il2CppStructArray<byte> matchData, [Optional] Il2CppReferenceArray<GP_ParticipantResult> results)
	{
		if (results == null)
		{
			results = new Il2CppReferenceArray<GP_ParticipantResult>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_FinishMatch_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_GP_ParticipantResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00034B4C File Offset: 0x00032D4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169622, XrefRangeEnd = 169623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveMatch(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_LeaveMatch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00034B90 File Offset: 0x00032D90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169623, XrefRangeEnd = 169624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveMatchDuringTurn(string matchId, string pendingParticipantId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pendingParticipantId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_LeaveMatchDuringTurn_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00034BE4 File Offset: 0x00032DE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169624, XrefRangeEnd = 169625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadMatchInfo(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_LoadMatchInfo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00034C28 File Offset: 0x00032E28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169642, RefRangeEnd = 169643, XrefRangeStart = 169625, XrefRangeEnd = 169642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadMatchesInfo(GP_TBM_MatchesSortOrder sortOreder, [Optional] Il2CppStructArray<GP_TBM_MatchTurnStatus> matchTurnStatuses)
	{
		if (matchTurnStatuses == null)
		{
			matchTurnStatuses = new Il2CppStructArray<GP_TBM_MatchTurnStatus>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sortOreder;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchTurnStatuses);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_LoadMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_Il2CppStructArray_1_GP_TBM_MatchTurnStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00034C88 File Offset: 0x00032E88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169644, RefRangeEnd = 169645, XrefRangeStart = 169643, XrefRangeEnd = 169644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAllMatchesInfo(GP_TBM_MatchesSortOrder sortOreder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sortOreder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_LoadAllMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00034CC8 File Offset: 0x00032EC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169645, XrefRangeEnd = 169646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rematch(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_Rematch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00034D0C File Offset: 0x00032F0C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 169647, RefRangeEnd = 169649, XrefRangeStart = 169646, XrefRangeEnd = 169647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterMatchUpdateListener()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_RegisterMatchUpdateListener_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00034D40 File Offset: 0x00032F40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169649, XrefRangeEnd = 169650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterMatchUpdateListener()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_UnregisterMatchUpdateListener_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x00034D74 File Offset: 0x00032F74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169650, XrefRangeEnd = 169696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TakeTrun(string matchId, Il2CppStructArray<byte> matchData, string pendingParticipantId, [Optional] Il2CppReferenceArray<GP_ParticipantResult> results)
	{
		if (results == null)
		{
			results = new Il2CppReferenceArray<GP_ParticipantResult>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pendingParticipantId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_TakeTrun_Public_Void_String_Il2CppStructArray_1_Byte_String_Il2CppReferenceArray_1_GP_ParticipantResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x00034DFC File Offset: 0x00032FFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169697, RefRangeEnd = 169698, XrefRangeStart = 169696, XrefRangeEnd = 169697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartSelectOpponentsView(int minPlayers, int maxPlayers, bool allowAutomatch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowAutomatch;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_StartSelectOpponentsView_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00034E58 File Offset: 0x00033058
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 169699, RefRangeEnd = 169700, XrefRangeStart = 169698, XrefRangeEnd = 169699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInbox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_ShowInbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00034E8C File Offset: 0x0003308C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 169701, RefRangeEnd = 169703, XrefRangeStart = 169700, XrefRangeEnd = 169701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVariant(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00034ECC File Offset: 0x000330CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 169704, RefRangeEnd = 169706, XrefRangeStart = 169703, XrefRangeEnd = 169704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExclusiveBitMask(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600089A RID: 2202 RVA: 0x00034F0C File Offset: 0x0003310C
	public unsafe Dictionary<string, GP_TBM_Match> Matches
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_get_Matches_Public_get_Dictionary_2_String_GP_TBM_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GP_TBM_Match>>(intPtr3) : null;
		}
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00034F4C File Offset: 0x0003314C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169706, XrefRangeEnd = 169753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadMatchesResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnLoadMatchesResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x00034F90 File Offset: 0x00033190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169753, XrefRangeEnd = 169780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMatchInitiatedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnMatchInitiatedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x00034FD4 File Offset: 0x000331D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169780, XrefRangeEnd = 169818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationAcceptedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnInvitationAcceptedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x00035018 File Offset: 0x00033218
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169818, XrefRangeEnd = 169849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCancelMatchResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnCancelMatchResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x0003505C File Offset: 0x0003325C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169849, XrefRangeEnd = 169874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeaveMatchResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnLeaveMatchResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x000350A0 File Offset: 0x000332A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169874, XrefRangeEnd = 169901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadMatchResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnLoadMatchResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x000350E4 File Offset: 0x000332E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169901, XrefRangeEnd = 169928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdateMatchResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnUpdateMatchResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00035128 File Offset: 0x00033328
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169928, XrefRangeEnd = 169966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AN_OnTurnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_AN_OnTurnResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0003516C File Offset: 0x0003336C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169966, XrefRangeEnd = 169984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTurnBasedMatchRemoved(string matchId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnTurnBasedMatchRemoved_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x000351B0 File Offset: 0x000333B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169984, XrefRangeEnd = 170012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTurnBasedMatchReceived(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnTurnBasedMatchReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x000351F4 File Offset: 0x000333F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170012, XrefRangeEnd = 170037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMatchCreationCanceled(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_OnMatchCreationCanceled_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x00035238 File Offset: 0x00033438
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 170051, RefRangeEnd = 170052, XrefRangeStart = 170037, XrefRangeEnd = 170051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GP_TBM_Match ParceMatchInfo(string data)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_TBM_Match>(intPtr3) : null;
		}
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x0003527C File Offset: 0x0003347C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 170074, RefRangeEnd = 170081, XrefRangeStart = 170052, XrefRangeEnd = 170074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GP_TBM_Match ParceMatchInfo(Il2CppStringArray MatchData, int index)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(MatchData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_TBM_Match>(intPtr3) : null;
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x000352D0 File Offset: 0x000334D0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 170211, RefRangeEnd = 170218, XrefRangeStart = 170081, XrefRangeEnd = 170211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMatchInfo(GP_TBM_Match match)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr_UpdateMatchInfo_Private_Void_GP_TBM_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x00035314 File Offset: 0x00033514
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170218, XrefRangeEnd = 170230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayTBM()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00005652 File Offset: 0x00003852
	public void FinishMatch(string matchId, Il2CppStructArray<byte> matchData, params GP_ParticipantResult[] results)
	{
		this.FinishMatch(matchId, matchData, new Il2CppReferenceArray<GP_ParticipantResult>(results));
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00005662 File Offset: 0x00003862
	public void LoadMatchesInfo(GP_TBM_MatchesSortOrder sortOreder, params GP_TBM_MatchTurnStatus[] matchTurnStatuses)
	{
		this.LoadMatchesInfo(sortOreder, new Il2CppStructArray<GP_TBM_MatchTurnStatus>(matchTurnStatuses));
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00005671 File Offset: 0x00003871
	public void TakeTrun(string matchId, Il2CppStructArray<byte> matchData, string pendingParticipantId, params GP_ParticipantResult[] results)
	{
		this.TakeTrun(matchId, matchData, pendingParticipantId, new Il2CppReferenceArray<GP_ParticipantResult>(results));
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x00005683 File Offset: 0x00003883
	public GooglePlayTBM(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x060008AE RID: 2222 RVA: 0x00035350 File Offset: 0x00033550
	// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000568C File Offset: 0x0000388C
	public unsafe static Action<GP_TBM_LoadMatchesResult> ActionMatchesResultLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchesResultLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_LoadMatchesResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchesResultLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00035378 File Offset: 0x00033578
	// (set) Token: 0x060008B1 RID: 2225 RVA: 0x0000569E File Offset: 0x0000389E
	public unsafe static Action<GP_TBM_MatchInitiatedResult> ActionMatchInitiated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInitiated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_MatchInitiatedResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInitiated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000353A0 File Offset: 0x000335A0
	// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000056B0 File Offset: 0x000038B0
	public unsafe static Action<GP_TBM_CancelMatchResult> ActionMatchCanceled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCanceled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_CancelMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCanceled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x060008B4 RID: 2228 RVA: 0x000353C8 File Offset: 0x000335C8
	// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000056C2 File Offset: 0x000038C2
	public unsafe static Action<GP_TBM_LeaveMatchResult> ActionMatchLeaved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchLeaved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_LeaveMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchLeaved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000353F0 File Offset: 0x000335F0
	// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000056D4 File Offset: 0x000038D4
	public unsafe static Action<GP_TBM_LoadMatchResult> ActionMatchDataLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchDataLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_LoadMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchDataLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00035418 File Offset: 0x00033618
	// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000056E6 File Offset: 0x000038E6
	public unsafe static Action<GP_TBM_UpdateMatchResult> ActionMatchUpdated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchUpdated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_UpdateMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060008BA RID: 2234 RVA: 0x00035440 File Offset: 0x00033640
	// (set) Token: 0x060008BB RID: 2235 RVA: 0x000056F8 File Offset: 0x000038F8
	public unsafe static Action<GP_TBM_UpdateMatchResult> ActionMatchTurnFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchTurnFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_UpdateMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchTurnFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x060008BC RID: 2236 RVA: 0x00035468 File Offset: 0x00033668
	// (set) Token: 0x060008BD RID: 2237 RVA: 0x0000570A File Offset: 0x0000390A
	public unsafe static Action<GP_TBM_UpdateMatchResult> ActionMatchReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_UpdateMatchResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x060008BE RID: 2238 RVA: 0x00035490 File Offset: 0x00033690
	// (set) Token: 0x060008BF RID: 2239 RVA: 0x0000571C File Offset: 0x0000391C
	public unsafe static Action<GP_TBM_MatchRemovedResult> ActionMatchRemoved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchRemoved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_TBM_MatchRemovedResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchRemoved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000354B8 File Offset: 0x000336B8
	// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000572E File Offset: 0x0000392E
	public unsafe static Action<AndroidActivityResult> ActionMatchCreationCanceled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCreationCanceled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidActivityResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchCreationCanceled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x060008C2 RID: 2242 RVA: 0x000354E0 File Offset: 0x000336E0
	// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00005740 File Offset: 0x00003940
	public unsafe static Action<string, GP_TBM_MatchInitiatedResult> ActionMatchInvitationAccepted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationAccepted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, GP_TBM_MatchInitiatedResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationAccepted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00035508 File Offset: 0x00033708
	// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00005752 File Offset: 0x00003952
	public unsafe static Action<string> ActionMatchInvitationDeclined
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationDeclined, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.NativeFieldInfoPtr_ActionMatchInvitationDeclined, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00035530 File Offset: 0x00033730
	// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00005764 File Offset: 0x00003964
	public unsafe Dictionary<string, GP_TBM_Match> _Matches
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayTBM.NativeFieldInfoPtr__Matches);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GP_TBM_Match>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayTBM.NativeFieldInfoPtr__Matches), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040006D3 RID: 1747
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchesResultLoaded;

	// Token: 0x040006D4 RID: 1748
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchInitiated;

	// Token: 0x040006D5 RID: 1749
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchCanceled;

	// Token: 0x040006D6 RID: 1750
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchLeaved;

	// Token: 0x040006D7 RID: 1751
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchDataLoaded;

	// Token: 0x040006D8 RID: 1752
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchUpdated;

	// Token: 0x040006D9 RID: 1753
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchTurnFinished;

	// Token: 0x040006DA RID: 1754
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchReceived;

	// Token: 0x040006DB RID: 1755
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchRemoved;

	// Token: 0x040006DC RID: 1756
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchCreationCanceled;

	// Token: 0x040006DD RID: 1757
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchInvitationAccepted;

	// Token: 0x040006DE RID: 1758
	private static readonly IntPtr NativeFieldInfoPtr_ActionMatchInvitationDeclined;

	// Token: 0x040006DF RID: 1759
	private static readonly IntPtr NativeFieldInfoPtr__Matches;

	// Token: 0x040006E0 RID: 1760
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchesResultLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchesResult_0;

	// Token: 0x040006E1 RID: 1761
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchesResultLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchesResult_0;

	// Token: 0x040006E2 RID: 1762
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchInitiated_Public_Static_add_Void_Action_1_GP_TBM_MatchInitiatedResult_0;

	// Token: 0x040006E3 RID: 1763
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchInitiated_Public_Static_rem_Void_Action_1_GP_TBM_MatchInitiatedResult_0;

	// Token: 0x040006E4 RID: 1764
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchCanceled_Public_Static_add_Void_Action_1_GP_TBM_CancelMatchResult_0;

	// Token: 0x040006E5 RID: 1765
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchCanceled_Public_Static_rem_Void_Action_1_GP_TBM_CancelMatchResult_0;

	// Token: 0x040006E6 RID: 1766
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchLeaved_Public_Static_add_Void_Action_1_GP_TBM_LeaveMatchResult_0;

	// Token: 0x040006E7 RID: 1767
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchLeaved_Public_Static_rem_Void_Action_1_GP_TBM_LeaveMatchResult_0;

	// Token: 0x040006E8 RID: 1768
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchDataLoaded_Public_Static_add_Void_Action_1_GP_TBM_LoadMatchResult_0;

	// Token: 0x040006E9 RID: 1769
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchDataLoaded_Public_Static_rem_Void_Action_1_GP_TBM_LoadMatchResult_0;

	// Token: 0x040006EA RID: 1770
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchUpdated_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006EB RID: 1771
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchUpdated_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006EC RID: 1772
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchTurnFinished_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006ED RID: 1773
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchTurnFinished_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006EE RID: 1774
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchReceived_Public_Static_add_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006EF RID: 1775
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchReceived_Public_Static_rem_Void_Action_1_GP_TBM_UpdateMatchResult_0;

	// Token: 0x040006F0 RID: 1776
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchRemoved_Public_Static_add_Void_Action_1_GP_TBM_MatchRemovedResult_0;

	// Token: 0x040006F1 RID: 1777
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchRemoved_Public_Static_rem_Void_Action_1_GP_TBM_MatchRemovedResult_0;

	// Token: 0x040006F2 RID: 1778
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchCreationCanceled_Public_Static_add_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x040006F3 RID: 1779
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchCreationCanceled_Public_Static_rem_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x040006F4 RID: 1780
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchInvitationAccepted_Public_Static_add_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0;

	// Token: 0x040006F5 RID: 1781
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchInvitationAccepted_Public_Static_rem_Void_Action_2_String_GP_TBM_MatchInitiatedResult_0;

	// Token: 0x040006F6 RID: 1782
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionMatchInvitationDeclined_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x040006F7 RID: 1783
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionMatchInvitationDeclined_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x040006F8 RID: 1784
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040006F9 RID: 1785
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040006FA RID: 1786
	private static readonly IntPtr NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0;

	// Token: 0x040006FB RID: 1787
	private static readonly IntPtr NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0;

	// Token: 0x040006FC RID: 1788
	private static readonly IntPtr NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0;

	// Token: 0x040006FD RID: 1789
	private static readonly IntPtr NativeMethodInfoPtr_CreateMatch_Public_Void_Int32_Int32_Il2CppStringArray_0;

	// Token: 0x040006FE RID: 1790
	private static readonly IntPtr NativeMethodInfoPtr_CancelMatch_Public_Void_String_0;

	// Token: 0x040006FF RID: 1791
	private static readonly IntPtr NativeMethodInfoPtr_DismissMatch_Public_Void_String_0;

	// Token: 0x04000700 RID: 1792
	private static readonly IntPtr NativeMethodInfoPtr_ConfirmMatchFinish_Public_Void_String_0;

	// Token: 0x04000701 RID: 1793
	private static readonly IntPtr NativeMethodInfoPtr_ConfirmhMatchFinis_Public_Void_String_0;

	// Token: 0x04000702 RID: 1794
	private static readonly IntPtr NativeMethodInfoPtr_FinishMatch_Public_Void_String_Il2CppStructArray_1_Byte_Il2CppReferenceArray_1_GP_ParticipantResult_0;

	// Token: 0x04000703 RID: 1795
	private static readonly IntPtr NativeMethodInfoPtr_LeaveMatch_Public_Void_String_0;

	// Token: 0x04000704 RID: 1796
	private static readonly IntPtr NativeMethodInfoPtr_LeaveMatchDuringTurn_Public_Void_String_String_0;

	// Token: 0x04000705 RID: 1797
	private static readonly IntPtr NativeMethodInfoPtr_LoadMatchInfo_Public_Void_String_0;

	// Token: 0x04000706 RID: 1798
	private static readonly IntPtr NativeMethodInfoPtr_LoadMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_Il2CppStructArray_1_GP_TBM_MatchTurnStatus_0;

	// Token: 0x04000707 RID: 1799
	private static readonly IntPtr NativeMethodInfoPtr_LoadAllMatchesInfo_Public_Void_GP_TBM_MatchesSortOrder_0;

	// Token: 0x04000708 RID: 1800
	private static readonly IntPtr NativeMethodInfoPtr_Rematch_Public_Void_String_0;

	// Token: 0x04000709 RID: 1801
	private static readonly IntPtr NativeMethodInfoPtr_RegisterMatchUpdateListener_Public_Void_0;

	// Token: 0x0400070A RID: 1802
	private static readonly IntPtr NativeMethodInfoPtr_UnregisterMatchUpdateListener_Public_Void_0;

	// Token: 0x0400070B RID: 1803
	private static readonly IntPtr NativeMethodInfoPtr_TakeTrun_Public_Void_String_Il2CppStructArray_1_Byte_String_Il2CppReferenceArray_1_GP_ParticipantResult_0;

	// Token: 0x0400070C RID: 1804
	private static readonly IntPtr NativeMethodInfoPtr_StartSelectOpponentsView_Public_Void_Int32_Int32_Boolean_0;

	// Token: 0x0400070D RID: 1805
	private static readonly IntPtr NativeMethodInfoPtr_ShowInbox_Public_Void_0;

	// Token: 0x0400070E RID: 1806
	private static readonly IntPtr NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0;

	// Token: 0x0400070F RID: 1807
	private static readonly IntPtr NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0;

	// Token: 0x04000710 RID: 1808
	private static readonly IntPtr NativeMethodInfoPtr_get_Matches_Public_get_Dictionary_2_String_GP_TBM_Match_0;

	// Token: 0x04000711 RID: 1809
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadMatchesResult_Private_Void_String_0;

	// Token: 0x04000712 RID: 1810
	private static readonly IntPtr NativeMethodInfoPtr_OnMatchInitiatedCallback_Private_Void_String_0;

	// Token: 0x04000713 RID: 1811
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationAcceptedCallback_Private_Void_String_0;

	// Token: 0x04000714 RID: 1812
	private static readonly IntPtr NativeMethodInfoPtr_OnCancelMatchResult_Private_Void_String_0;

	// Token: 0x04000715 RID: 1813
	private static readonly IntPtr NativeMethodInfoPtr_OnLeaveMatchResult_Private_Void_String_0;

	// Token: 0x04000716 RID: 1814
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadMatchResult_Private_Void_String_0;

	// Token: 0x04000717 RID: 1815
	private static readonly IntPtr NativeMethodInfoPtr_OnUpdateMatchResult_Private_Void_String_0;

	// Token: 0x04000718 RID: 1816
	private static readonly IntPtr NativeMethodInfoPtr_AN_OnTurnResult_Private_Void_String_0;

	// Token: 0x04000719 RID: 1817
	private static readonly IntPtr NativeMethodInfoPtr_OnTurnBasedMatchRemoved_Private_Void_String_0;

	// Token: 0x0400071A RID: 1818
	private static readonly IntPtr NativeMethodInfoPtr_OnTurnBasedMatchReceived_Private_Void_String_0;

	// Token: 0x0400071B RID: 1819
	private static readonly IntPtr NativeMethodInfoPtr_OnMatchCreationCanceled_Private_Void_String_0;

	// Token: 0x0400071C RID: 1820
	private static readonly IntPtr NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_String_0;

	// Token: 0x0400071D RID: 1821
	private static readonly IntPtr NativeMethodInfoPtr_ParceMatchInfo_Public_Static_GP_TBM_Match_Il2CppStringArray_Int32_0;

	// Token: 0x0400071E RID: 1822
	private static readonly IntPtr NativeMethodInfoPtr_UpdateMatchInfo_Private_Void_GP_TBM_Match_0;

	// Token: 0x0400071F RID: 1823
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000377 RID: 887
	[ObfuscatedName("GooglePlayTBM+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003516 RID: 13590 RVA: 0x000DB31C File Offset: 0x000D951C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayTBM>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr);
			GooglePlayTBM.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, "<>9");
			GooglePlayTBM.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670067);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_0_Internal_Void_GP_TBM_LoadMatchesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670068);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_1_Internal_Void_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670069);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_2_Internal_Void_GP_TBM_CancelMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670070);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_3_Internal_Void_GP_TBM_LeaveMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670071);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_4_Internal_Void_GP_TBM_LoadMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670072);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_5_Internal_Void_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670073);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_6_Internal_Void_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670074);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_7_Internal_Void_GP_TBM_UpdateMatchResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670075);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_8_Internal_Void_GP_TBM_MatchRemovedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670076);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_9_Internal_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670077);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_10_Internal_Void_String_GP_TBM_MatchInitiatedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670078);
			GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_11_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr, 100670079);
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000DB460 File Offset: 0x000D9660
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayTBM.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000DB49C File Offset: 0x000D969C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_0(GP_TBM_LoadMatchesResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_0_Internal_Void_GP_TBM_LoadMatchesResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000DB4E0 File Offset: 0x000D96E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_1(GP_TBM_MatchInitiatedResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_1_Internal_Void_GP_TBM_MatchInitiatedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000DB524 File Offset: 0x000D9724
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_2(GP_TBM_CancelMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_2_Internal_Void_GP_TBM_CancelMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000DB568 File Offset: 0x000D9768
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_3(GP_TBM_LeaveMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_3_Internal_Void_GP_TBM_LeaveMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000DB5AC File Offset: 0x000D97AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_4(GP_TBM_LoadMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_4_Internal_Void_GP_TBM_LoadMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000DB5F0 File Offset: 0x000D97F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_5(GP_TBM_UpdateMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_5_Internal_Void_GP_TBM_UpdateMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x000DB634 File Offset: 0x000D9834
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_6(GP_TBM_UpdateMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_6_Internal_Void_GP_TBM_UpdateMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x000DB678 File Offset: 0x000D9878
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_7(GP_TBM_UpdateMatchResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_7_Internal_Void_GP_TBM_UpdateMatchResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x000DB6BC File Offset: 0x000D98BC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_8(GP_TBM_MatchRemovedResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_8_Internal_Void_GP_TBM_MatchRemovedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x000DB700 File Offset: 0x000D9900
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_9(AndroidActivityResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_9_Internal_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x000DB744 File Offset: 0x000D9944
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_10(string <p0>, GP_TBM_MatchInitiatedResult <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_10_Internal_Void_String_GP_TBM_MatchInitiatedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x000DB798 File Offset: 0x000D9998
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__78_11(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayTBM.__c.NativeMethodInfoPtr___cctor_b__78_11_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x000149FD File Offset: 0x00012BFD
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x000DB7DC File Offset: 0x000D99DC
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x00014A06 File Offset: 0x00012C06
		public unsafe static GooglePlayTBM.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayTBM.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayTBM.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayTBM.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030FB RID: 12539
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030FC RID: 12540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030FD RID: 12541
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_0_Internal_Void_GP_TBM_LoadMatchesResult_0;

		// Token: 0x040030FE RID: 12542
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_1_Internal_Void_GP_TBM_MatchInitiatedResult_0;

		// Token: 0x040030FF RID: 12543
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_2_Internal_Void_GP_TBM_CancelMatchResult_0;

		// Token: 0x04003100 RID: 12544
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_3_Internal_Void_GP_TBM_LeaveMatchResult_0;

		// Token: 0x04003101 RID: 12545
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_4_Internal_Void_GP_TBM_LoadMatchResult_0;

		// Token: 0x04003102 RID: 12546
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_5_Internal_Void_GP_TBM_UpdateMatchResult_0;

		// Token: 0x04003103 RID: 12547
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_6_Internal_Void_GP_TBM_UpdateMatchResult_0;

		// Token: 0x04003104 RID: 12548
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_7_Internal_Void_GP_TBM_UpdateMatchResult_0;

		// Token: 0x04003105 RID: 12549
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_8_Internal_Void_GP_TBM_MatchRemovedResult_0;

		// Token: 0x04003106 RID: 12550
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_9_Internal_Void_AndroidActivityResult_0;

		// Token: 0x04003107 RID: 12551
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_10_Internal_Void_String_GP_TBM_MatchInitiatedResult_0;

		// Token: 0x04003108 RID: 12552
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__78_11_Internal_Void_String_0;
	}
}
