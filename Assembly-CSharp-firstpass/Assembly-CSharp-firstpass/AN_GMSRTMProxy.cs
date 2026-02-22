using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000BF RID: 191
public class AN_GMSRTMProxy : MonoBehaviour
{
	// Token: 0x06000DD4 RID: 3540 RVA: 0x00047CCC File Offset: 0x00045ECC
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GMSRTMProxy()
	{
		Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GMSRTMProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr);
		AN_GMSRTMProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GMSRTMProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665005);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665006);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665007);
		AN_GMSRTMProxy.NativeMethodInfoPtr_sendDataToAll_Public_Static_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665008);
		AN_GMSRTMProxy.NativeMethodInfoPtr_sendDataToPlayers_Public_Static_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665009);
		AN_GMSRTMProxy.NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665010);
		AN_GMSRTMProxy.NativeMethodInfoPtr_InvitePlayers_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665011);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_SetVariant_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665012);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_SetExclusiveBitMask_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665013);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_AcceptInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665014);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_DeclineInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665015);
		AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_DismissInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665016);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_AcceptInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665017);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_DeclineInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665018);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_DismissInvitation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665019);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_CreateMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665020);
		AN_GMSRTMProxy.NativeMethodInfoPtr_CancelMatch_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665021);
		AN_GMSRTMProxy.NativeMethodInfoPtr_DismissMatch_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665022);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_FinishMatch_Public_Static_Void_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665023);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_FinishMatchWithId_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665024);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LeaveMatch_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665025);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LeaveMatchDuringTurn_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665026);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadMatchInfo_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665027);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadMatchesInfo_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665028);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadAllMatchesInfo_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665029);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_Rematch_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665030);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_RegisterMatchUpdateListener_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665031);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_UnregisterMatchUpdateListener_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665032);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_TakeTrun_Public_Static_Void_String_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665033);
		AN_GMSRTMProxy.NativeMethodInfoPtr_StartSelectOpponentsView_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665034);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_ShowInbox_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665035);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_SetVariant_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665036);
		AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_SetExclusiveBitMask_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665037);
		AN_GMSRTMProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr, 100665038);
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00047FB8 File Offset: 0x000461B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177778, XrefRangeEnd = 177779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00048010 File Offset: 0x00046210
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 177792, RefRangeEnd = 177795, XrefRangeStart = 177779, XrefRangeEnd = 177792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTMFindMatch(int minPlayers, int maxPlayers, Il2CppStringArray pIds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pIds);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00048064 File Offset: 0x00046264
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177797, RefRangeEnd = 177799, XrefRangeStart = 177795, XrefRangeEnd = 177797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTMFindMatch(Il2CppStringArray pIds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x0004809C File Offset: 0x0004629C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177811, RefRangeEnd = 177812, XrefRangeStart = 177799, XrefRangeEnd = 177811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sendDataToAll(string data, int sendType, int dataId = 0)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_sendDataToAll_Public_Static_Void_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x000480F0 File Offset: 0x000462F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177825, RefRangeEnd = 177826, XrefRangeStart = 177812, XrefRangeEnd = 177825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sendDataToPlayers(string data, string players, int sendType, int dataId = 0)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(players);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_sendDataToPlayers_Public_Static_Void_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00048154 File Offset: 0x00046354
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177831, RefRangeEnd = 177832, XrefRangeStart = 177826, XrefRangeEnd = 177831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowWaitingRoomIntent()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x0004817C File Offset: 0x0004637C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177841, RefRangeEnd = 177842, XrefRangeStart = 177832, XrefRangeEnd = 177841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvitePlayers(int minPlayers, int maxPlayers)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_InvitePlayers_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x000481BC File Offset: 0x000463BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177851, RefRangeEnd = 177852, XrefRangeStart = 177842, XrefRangeEnd = 177851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTM_SetVariant(int val)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_SetVariant_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x000481F0 File Offset: 0x000463F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177861, RefRangeEnd = 177862, XrefRangeStart = 177852, XrefRangeEnd = 177861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTM_SetExclusiveBitMask(int val)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_SetExclusiveBitMask_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00048224 File Offset: 0x00046424
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177868, RefRangeEnd = 177869, XrefRangeStart = 177862, XrefRangeEnd = 177868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTM_AcceptInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_AcceptInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x0004825C File Offset: 0x0004645C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177875, RefRangeEnd = 177876, XrefRangeStart = 177869, XrefRangeEnd = 177875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTM_DeclineInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_DeclineInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00048294 File Offset: 0x00046494
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177882, RefRangeEnd = 177883, XrefRangeStart = 177876, XrefRangeEnd = 177882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RTM_DismissInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_RTM_DismissInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x000482CC File Offset: 0x000464CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177889, RefRangeEnd = 177890, XrefRangeStart = 177883, XrefRangeEnd = 177889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_AcceptInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_AcceptInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00048304 File Offset: 0x00046504
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177896, RefRangeEnd = 177897, XrefRangeStart = 177890, XrefRangeEnd = 177896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_DeclineInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_DeclineInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0004833C File Offset: 0x0004653C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177903, RefRangeEnd = 177904, XrefRangeStart = 177897, XrefRangeEnd = 177903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_DismissInvitation(string invitationId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_DismissInvitation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00048374 File Offset: 0x00046574
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177917, RefRangeEnd = 177918, XrefRangeStart = 177904, XrefRangeEnd = 177917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_CreateMatch(int minPlayers, int maxPlayers, Il2CppStringArray playersIds)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersIds);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_CreateMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x000483C8 File Offset: 0x000465C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177924, RefRangeEnd = 177925, XrefRangeStart = 177918, XrefRangeEnd = 177924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CancelMatch(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_CancelMatch_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00048400 File Offset: 0x00046600
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177931, RefRangeEnd = 177932, XrefRangeStart = 177925, XrefRangeEnd = 177931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DismissMatch(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_DismissMatch_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00048438 File Offset: 0x00046638
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177943, RefRangeEnd = 177944, XrefRangeStart = 177932, XrefRangeEnd = 177943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_FinishMatch(string matchId, string matchData, Il2CppStringArray pIds, Il2CppStructArray<int> results, Il2CppStructArray<int> placing, Il2CppStructArray<int> versions)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pIds);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placing);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(versions);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_FinishMatch_Public_Static_Void_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x000484CC File Offset: 0x000466CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177950, RefRangeEnd = 177952, XrefRangeStart = 177944, XrefRangeEnd = 177950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_FinishMatchWithId(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_FinishMatchWithId_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00048504 File Offset: 0x00046704
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177958, RefRangeEnd = 177959, XrefRangeStart = 177952, XrefRangeEnd = 177958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_LeaveMatch(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LeaveMatch_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x0004853C File Offset: 0x0004673C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177966, RefRangeEnd = 177967, XrefRangeStart = 177959, XrefRangeEnd = 177966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_LeaveMatchDuringTurn(string matchId, string pendingParticipantId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pendingParticipantId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LeaveMatchDuringTurn_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00048584 File Offset: 0x00046784
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177973, RefRangeEnd = 177974, XrefRangeStart = 177967, XrefRangeEnd = 177973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_LoadMatchInfo(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadMatchInfo_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x000485BC File Offset: 0x000467BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177984, RefRangeEnd = 177985, XrefRangeStart = 177974, XrefRangeEnd = 177984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_LoadMatchesInfo(int invitationSortOrder, Il2CppStructArray<int> matchTurnStatuses)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref invitationSortOrder;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchTurnStatuses);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadMatchesInfo_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00048600 File Offset: 0x00046800
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177994, RefRangeEnd = 177995, XrefRangeStart = 177985, XrefRangeEnd = 177994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_LoadAllMatchesInfo(int invitationSortOrder)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref invitationSortOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_LoadAllMatchesInfo_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00048634 File Offset: 0x00046834
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178001, RefRangeEnd = 178002, XrefRangeStart = 177995, XrefRangeEnd = 178001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_Rematch(string matchId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_Rematch_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x0004866C File Offset: 0x0004686C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178007, RefRangeEnd = 178008, XrefRangeStart = 178002, XrefRangeEnd = 178007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_RegisterMatchUpdateListener()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_RegisterMatchUpdateListener_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00048694 File Offset: 0x00046894
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178013, RefRangeEnd = 178014, XrefRangeStart = 178008, XrefRangeEnd = 178013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_UnregisterMatchUpdateListener()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_UnregisterMatchUpdateListener_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x000486BC File Offset: 0x000468BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178026, RefRangeEnd = 178027, XrefRangeStart = 178014, XrefRangeEnd = 178026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_TakeTrun(string matchId, string matchData, string pendingParticipantId, Il2CppStringArray pIds, Il2CppStructArray<int> results, Il2CppStructArray<int> placing, Il2CppStructArray<int> versions)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(matchId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(matchData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pendingParticipantId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pIds);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(placing);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(versions);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_TakeTrun_Public_Static_Void_String_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00048764 File Offset: 0x00046964
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178043, RefRangeEnd = 178044, XrefRangeStart = 178027, XrefRangeEnd = 178043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartSelectOpponentsView(int minPlayers, int maxPlayers, bool allowAutomatch)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowAutomatch;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_StartSelectOpponentsView_Public_Static_Void_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x000487B4 File Offset: 0x000469B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178049, RefRangeEnd = 178050, XrefRangeStart = 178044, XrefRangeEnd = 178049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_ShowInbox()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_ShowInbox_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x000487DC File Offset: 0x000469DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178059, RefRangeEnd = 178060, XrefRangeStart = 178050, XrefRangeEnd = 178059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_SetVariant(int val)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_SetVariant_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00048810 File Offset: 0x00046A10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178069, RefRangeEnd = 178070, XrefRangeStart = 178060, XrefRangeEnd = 178069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TBM_SetExclusiveBitMask(int val)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr_TBM_SetExclusiveBitMask_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00048844 File Offset: 0x00046A44
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GMSRTMProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GMSRTMProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GMSRTMProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00007605 File Offset: 0x00005805
	public static void CallActivityFunction(string methodName, params global::Il2CppSystem.Object[] args)
	{
		AN_GMSRTMProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00007613 File Offset: 0x00005813
	public AN_GMSRTMProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00048880 File Offset: 0x00046A80
	// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0000761C File Offset: 0x0000581C
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GMSRTMProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GMSRTMProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000AC0 RID: 2752
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000AC1 RID: 2753
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000AC2 RID: 2754
	private static readonly IntPtr NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0;

	// Token: 0x04000AC3 RID: 2755
	private static readonly IntPtr NativeMethodInfoPtr_RTMFindMatch_Public_Static_Void_Il2CppStringArray_0;

	// Token: 0x04000AC4 RID: 2756
	private static readonly IntPtr NativeMethodInfoPtr_sendDataToAll_Public_Static_Void_String_Int32_Int32_0;

	// Token: 0x04000AC5 RID: 2757
	private static readonly IntPtr NativeMethodInfoPtr_sendDataToPlayers_Public_Static_Void_String_String_Int32_Int32_0;

	// Token: 0x04000AC6 RID: 2758
	private static readonly IntPtr NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Static_Void_0;

	// Token: 0x04000AC7 RID: 2759
	private static readonly IntPtr NativeMethodInfoPtr_InvitePlayers_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000AC8 RID: 2760
	private static readonly IntPtr NativeMethodInfoPtr_RTM_SetVariant_Public_Static_Void_Int32_0;

	// Token: 0x04000AC9 RID: 2761
	private static readonly IntPtr NativeMethodInfoPtr_RTM_SetExclusiveBitMask_Public_Static_Void_Int32_0;

	// Token: 0x04000ACA RID: 2762
	private static readonly IntPtr NativeMethodInfoPtr_RTM_AcceptInvitation_Public_Static_Void_String_0;

	// Token: 0x04000ACB RID: 2763
	private static readonly IntPtr NativeMethodInfoPtr_RTM_DeclineInvitation_Public_Static_Void_String_0;

	// Token: 0x04000ACC RID: 2764
	private static readonly IntPtr NativeMethodInfoPtr_RTM_DismissInvitation_Public_Static_Void_String_0;

	// Token: 0x04000ACD RID: 2765
	private static readonly IntPtr NativeMethodInfoPtr_TBM_AcceptInvitation_Public_Static_Void_String_0;

	// Token: 0x04000ACE RID: 2766
	private static readonly IntPtr NativeMethodInfoPtr_TBM_DeclineInvitation_Public_Static_Void_String_0;

	// Token: 0x04000ACF RID: 2767
	private static readonly IntPtr NativeMethodInfoPtr_TBM_DismissInvitation_Public_Static_Void_String_0;

	// Token: 0x04000AD0 RID: 2768
	private static readonly IntPtr NativeMethodInfoPtr_TBM_CreateMatch_Public_Static_Void_Int32_Int32_Il2CppStringArray_0;

	// Token: 0x04000AD1 RID: 2769
	private static readonly IntPtr NativeMethodInfoPtr_CancelMatch_Public_Static_Void_String_0;

	// Token: 0x04000AD2 RID: 2770
	private static readonly IntPtr NativeMethodInfoPtr_DismissMatch_Public_Static_Void_String_0;

	// Token: 0x04000AD3 RID: 2771
	private static readonly IntPtr NativeMethodInfoPtr_TBM_FinishMatch_Public_Static_Void_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	// Token: 0x04000AD4 RID: 2772
	private static readonly IntPtr NativeMethodInfoPtr_TBM_FinishMatchWithId_Public_Static_Void_String_0;

	// Token: 0x04000AD5 RID: 2773
	private static readonly IntPtr NativeMethodInfoPtr_TBM_LeaveMatch_Public_Static_Void_String_0;

	// Token: 0x04000AD6 RID: 2774
	private static readonly IntPtr NativeMethodInfoPtr_TBM_LeaveMatchDuringTurn_Public_Static_Void_String_String_0;

	// Token: 0x04000AD7 RID: 2775
	private static readonly IntPtr NativeMethodInfoPtr_TBM_LoadMatchInfo_Public_Static_Void_String_0;

	// Token: 0x04000AD8 RID: 2776
	private static readonly IntPtr NativeMethodInfoPtr_TBM_LoadMatchesInfo_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

	// Token: 0x04000AD9 RID: 2777
	private static readonly IntPtr NativeMethodInfoPtr_TBM_LoadAllMatchesInfo_Public_Static_Void_Int32_0;

	// Token: 0x04000ADA RID: 2778
	private static readonly IntPtr NativeMethodInfoPtr_TBM_Rematch_Public_Static_Void_String_0;

	// Token: 0x04000ADB RID: 2779
	private static readonly IntPtr NativeMethodInfoPtr_TBM_RegisterMatchUpdateListener_Public_Static_Void_0;

	// Token: 0x04000ADC RID: 2780
	private static readonly IntPtr NativeMethodInfoPtr_TBM_UnregisterMatchUpdateListener_Public_Static_Void_0;

	// Token: 0x04000ADD RID: 2781
	private static readonly IntPtr NativeMethodInfoPtr_TBM_TakeTrun_Public_Static_Void_String_String_String_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	// Token: 0x04000ADE RID: 2782
	private static readonly IntPtr NativeMethodInfoPtr_StartSelectOpponentsView_Public_Static_Void_Int32_Int32_Boolean_0;

	// Token: 0x04000ADF RID: 2783
	private static readonly IntPtr NativeMethodInfoPtr_TBM_ShowInbox_Public_Static_Void_0;

	// Token: 0x04000AE0 RID: 2784
	private static readonly IntPtr NativeMethodInfoPtr_TBM_SetVariant_Public_Static_Void_Int32_0;

	// Token: 0x04000AE1 RID: 2785
	private static readonly IntPtr NativeMethodInfoPtr_TBM_SetExclusiveBitMask_Public_Static_Void_Int32_0;

	// Token: 0x04000AE2 RID: 2786
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
