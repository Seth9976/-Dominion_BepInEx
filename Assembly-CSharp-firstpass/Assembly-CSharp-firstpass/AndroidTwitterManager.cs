using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000A2 RID: 162
public class AndroidTwitterManager : Singleton<AndroidTwitterManager>
{
	// Token: 0x06000B8E RID: 2958 RVA: 0x0003F7B0 File Offset: 0x0003D9B0
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidTwitterManager()
	{
		Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidTwitterManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr);
		AndroidTwitterManager.NativeFieldInfoPtr__IsAuthed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "_IsAuthed");
		AndroidTwitterManager.NativeFieldInfoPtr__IsInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "_IsInited");
		AndroidTwitterManager.NativeFieldInfoPtr__AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "_AccessToken");
		AndroidTwitterManager.NativeFieldInfoPtr__AccessTokenSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "_AccessTokenSecret");
		AndroidTwitterManager.NativeFieldInfoPtr__userInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "_userInfo");
		AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLoginStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnTwitterLoginStarted");
		AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLogOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnTwitterLogOut");
		AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterPostStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnTwitterPostStarted");
		AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterInitedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnTwitterInitedAction");
		AndroidTwitterManager.NativeFieldInfoPtr_OnAuthCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnAuthCompleteAction");
		AndroidTwitterManager.NativeFieldInfoPtr_OnPostingCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnPostingCompleteAction");
		AndroidTwitterManager.NativeFieldInfoPtr_OnUserDataRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "OnUserDataRequestCompleteAction");
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterLoginStarted_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664691);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterLoginStarted_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664692);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterLogOut_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664693);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterLogOut_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664694);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterPostStarted_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664695);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterPostStarted_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664696);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664697);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664698);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664699);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664700);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664701);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664702);
		AndroidTwitterManager.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664703);
		AndroidTwitterManager.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664704);
		AndroidTwitterManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664705);
		AndroidTwitterManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664706);
		AndroidTwitterManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664707);
		AndroidTwitterManager.NativeMethodInfoPtr_AuthenticateUser_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664708);
		AndroidTwitterManager.NativeMethodInfoPtr_LoadUserData_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664709);
		AndroidTwitterManager.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664710);
		AndroidTwitterManager.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664711);
		AndroidTwitterManager.NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664712);
		AndroidTwitterManager.NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664713);
		AndroidTwitterManager.NativeMethodInfoPtr_LogOut_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664714);
		AndroidTwitterManager.NativeMethodInfoPtr_get_IsAuthed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664715);
		AndroidTwitterManager.NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664716);
		AndroidTwitterManager.NativeMethodInfoPtr_get_userInfo_Public_Virtual_Final_New_get_TwitterUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664717);
		AndroidTwitterManager.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664718);
		AndroidTwitterManager.NativeMethodInfoPtr_get_AccessTokenSecret_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664719);
		AndroidTwitterManager.NativeMethodInfoPtr_OnInited_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664720);
		AndroidTwitterManager.NativeMethodInfoPtr_OnAuthSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664721);
		AndroidTwitterManager.NativeMethodInfoPtr_OnAuthFailed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664722);
		AndroidTwitterManager.NativeMethodInfoPtr_OnPostSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664723);
		AndroidTwitterManager.NativeMethodInfoPtr_OnPostFailed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664724);
		AndroidTwitterManager.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664725);
		AndroidTwitterManager.NativeMethodInfoPtr_OnUserDataLoadFailed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664726);
		AndroidTwitterManager.NativeMethodInfoPtr_OnAuthInfoReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664727);
		AndroidTwitterManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, 100664728);
	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x0003FBC8 File Offset: 0x0003DDC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174561, RefRangeEnd = 174562, XrefRangeStart = 174557, XrefRangeEnd = 174561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnTwitterLoginStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterLoginStarted_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B90 RID: 2960 RVA: 0x0003FC0C File Offset: 0x0003DE0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174562, XrefRangeEnd = 174566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnTwitterLoginStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterLoginStarted_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0003FC50 File Offset: 0x0003DE50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174570, RefRangeEnd = 174571, XrefRangeStart = 174566, XrefRangeEnd = 174570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnTwitterLogOut(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterLogOut_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0003FC94 File Offset: 0x0003DE94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174571, XrefRangeEnd = 174575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnTwitterLogOut(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterLogOut_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0003FCD8 File Offset: 0x0003DED8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174579, RefRangeEnd = 174580, XrefRangeStart = 174575, XrefRangeEnd = 174579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnTwitterPostStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterPostStarted_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0003FD1C File Offset: 0x0003DF1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174580, XrefRangeEnd = 174584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnTwitterPostStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterPostStarted_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B95 RID: 2965 RVA: 0x0003FD60 File Offset: 0x0003DF60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174588, RefRangeEnd = 174589, XrefRangeStart = 174584, XrefRangeEnd = 174588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnTwitterInitedAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B96 RID: 2966 RVA: 0x0003FDA4 File Offset: 0x0003DFA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174589, XrefRangeEnd = 174593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnTwitterInitedAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B97 RID: 2967 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174597, RefRangeEnd = 174599, XrefRangeStart = 174593, XrefRangeEnd = 174597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnAuthCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B98 RID: 2968 RVA: 0x0003FE2C File Offset: 0x0003E02C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174599, XrefRangeEnd = 174603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnAuthCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B99 RID: 2969 RVA: 0x0003FE70 File Offset: 0x0003E070
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174607, RefRangeEnd = 174609, XrefRangeStart = 174603, XrefRangeEnd = 174607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnPostingCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B9A RID: 2970 RVA: 0x0003FEB4 File Offset: 0x0003E0B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174609, XrefRangeEnd = 174613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnPostingCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B9B RID: 2971 RVA: 0x0003FEF8 File Offset: 0x0003E0F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174617, RefRangeEnd = 174619, XrefRangeStart = 174613, XrefRangeEnd = 174617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnUserDataRequestCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x0003FF3C File Offset: 0x0003E13C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174619, XrefRangeEnd = 174623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnUserDataRequestCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x0003FF80 File Offset: 0x0003E180
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174623, XrefRangeEnd = 174628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x0003FFB4 File Offset: 0x0003E1B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174643, RefRangeEnd = 174644, XrefRangeStart = 174628, XrefRangeEnd = 174643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x0003FFE8 File Offset: 0x0003E1E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174644, XrefRangeEnd = 174654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init(string consumer_key, string consumer_secret)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(consumer_key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(consumer_secret);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x0004003C File Offset: 0x0003E23C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174671, RefRangeEnd = 174672, XrefRangeStart = 174654, XrefRangeEnd = 174671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AuthenticateUser()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_AuthenticateUser_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00040070 File Offset: 0x0003E270
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174694, RefRangeEnd = 174696, XrefRangeStart = 174672, XrefRangeEnd = 174694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_LoadUserData_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x000400A4 File Offset: 0x0003E2A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174724, RefRangeEnd = 174725, XrefRangeStart = 174696, XrefRangeEnd = 174724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Post(string status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BA3 RID: 2979 RVA: 0x000400E8 File Offset: 0x0003E2E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174725, XrefRangeEnd = 174763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Post(string status, Texture2D texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0004013C File Offset: 0x0003E33C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174765, RefRangeEnd = 174766, XrefRangeStart = 174763, XrefRangeEnd = 174765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual TwitterPostingTask PostWithAuthCheck(string status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask>(intPtr3) : null;
		}
	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0004018C File Offset: 0x0003E38C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174766, XrefRangeEnd = 174768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual TwitterPostingTask PostWithAuthCheck(string status, Texture2D texture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(texture);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask>(intPtr3) : null;
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x000401F0 File Offset: 0x0003E3F0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174778, RefRangeEnd = 174780, XrefRangeStart = 174768, XrefRangeEnd = 174778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LogOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_LogOut_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00040224 File Offset: 0x0003E424
	public unsafe virtual bool IsAuthed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_get_IsAuthed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00040260 File Offset: 0x0003E460
	public unsafe virtual bool IsInited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0004029C File Offset: 0x0003E49C
	public unsafe virtual TwitterUserInfo userInfo
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_get_userInfo_Public_Virtual_Final_New_get_TwitterUserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterUserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06000BAA RID: 2986 RVA: 0x000402DC File Offset: 0x0003E4DC
	public unsafe string AccessToken
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06000BAB RID: 2987 RVA: 0x00040314 File Offset: 0x0003E514
	public unsafe string AccessTokenSecret
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_get_AccessTokenSecret_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0004034C File Offset: 0x0003E54C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174780, XrefRangeEnd = 174791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInited(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnInited_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00040390 File Offset: 0x0003E590
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174791, XrefRangeEnd = 174799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuthSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnAuthSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x000403C4 File Offset: 0x0003E5C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174799, XrefRangeEnd = 174807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuthFailed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnAuthFailed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x000403F8 File Offset: 0x0003E5F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174807, XrefRangeEnd = 174815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnPostSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x0004042C File Offset: 0x0003E62C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174815, XrefRangeEnd = 174823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostFailed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnPostFailed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00040460 File Offset: 0x0003E660
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174823, XrefRangeEnd = 174835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserDataLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x000404A4 File Offset: 0x0003E6A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174835, XrefRangeEnd = 174843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserDataLoadFailed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnUserDataLoadFailed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x000404D8 File Offset: 0x0003E6D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174843, XrefRangeEnd = 174856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuthInfoReceived(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr_OnAuthInfoReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0004051C File Offset: 0x0003E71C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174856, XrefRangeEnd = 174950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidTwitterManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x000069CF File Offset: 0x00004BCF
	public AndroidTwitterManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00040558 File Offset: 0x0003E758
	// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x000069D8 File Offset: 0x00004BD8
	public unsafe bool _IsAuthed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__IsAuthed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__IsAuthed)) = value;
		}
	}

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00040580 File Offset: 0x0003E780
	// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000069F3 File Offset: 0x00004BF3
	public unsafe bool _IsInited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__IsInited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__IsInited)) = value;
		}
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000405A8 File Offset: 0x0003E7A8
	// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00006A0E File Offset: 0x00004C0E
	public unsafe string _AccessToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__AccessToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__AccessToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000405D0 File Offset: 0x0003E7D0
	// (set) Token: 0x06000BBD RID: 3005 RVA: 0x00006A2D File Offset: 0x00004C2D
	public unsafe string _AccessTokenSecret
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__AccessTokenSecret);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__AccessTokenSecret), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000405F8 File Offset: 0x0003E7F8
	// (set) Token: 0x06000BBF RID: 3007 RVA: 0x00006A4C File Offset: 0x00004C4C
	public unsafe TwitterUserInfo _userInfo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__userInfo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterUserInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr__userInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00040628 File Offset: 0x0003E828
	// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x00006A6B File Offset: 0x00004C6B
	public unsafe Action OnTwitterLoginStarted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLoginStarted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLoginStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x00040658 File Offset: 0x0003E858
	// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00006A8A File Offset: 0x00004C8A
	public unsafe Action OnTwitterLogOut
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLogOut);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterLogOut), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00040688 File Offset: 0x0003E888
	// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00006AA9 File Offset: 0x00004CA9
	public unsafe Action OnTwitterPostStarted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterPostStarted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterPostStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x000406B8 File Offset: 0x0003E8B8
	// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00006AC8 File Offset: 0x00004CC8
	public unsafe Action<TWResult> OnTwitterInitedAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterInitedAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnTwitterInitedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x000406E8 File Offset: 0x0003E8E8
	// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00006AE7 File Offset: 0x00004CE7
	public unsafe Action<TWResult> OnAuthCompleteAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnAuthCompleteAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnAuthCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00040718 File Offset: 0x0003E918
	// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00006B06 File Offset: 0x00004D06
	public unsafe Action<TWResult> OnPostingCompleteAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnPostingCompleteAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnPostingCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00040748 File Offset: 0x0003E948
	// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00006B25 File Offset: 0x00004D25
	public unsafe Action<TWResult> OnUserDataRequestCompleteAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnUserDataRequestCompleteAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidTwitterManager.NativeFieldInfoPtr_OnUserDataRequestCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000923 RID: 2339
	private static readonly IntPtr NativeFieldInfoPtr__IsAuthed;

	// Token: 0x04000924 RID: 2340
	private static readonly IntPtr NativeFieldInfoPtr__IsInited;

	// Token: 0x04000925 RID: 2341
	private static readonly IntPtr NativeFieldInfoPtr__AccessToken;

	// Token: 0x04000926 RID: 2342
	private static readonly IntPtr NativeFieldInfoPtr__AccessTokenSecret;

	// Token: 0x04000927 RID: 2343
	private static readonly IntPtr NativeFieldInfoPtr__userInfo;

	// Token: 0x04000928 RID: 2344
	private static readonly IntPtr NativeFieldInfoPtr_OnTwitterLoginStarted;

	// Token: 0x04000929 RID: 2345
	private static readonly IntPtr NativeFieldInfoPtr_OnTwitterLogOut;

	// Token: 0x0400092A RID: 2346
	private static readonly IntPtr NativeFieldInfoPtr_OnTwitterPostStarted;

	// Token: 0x0400092B RID: 2347
	private static readonly IntPtr NativeFieldInfoPtr_OnTwitterInitedAction;

	// Token: 0x0400092C RID: 2348
	private static readonly IntPtr NativeFieldInfoPtr_OnAuthCompleteAction;

	// Token: 0x0400092D RID: 2349
	private static readonly IntPtr NativeFieldInfoPtr_OnPostingCompleteAction;

	// Token: 0x0400092E RID: 2350
	private static readonly IntPtr NativeFieldInfoPtr_OnUserDataRequestCompleteAction;

	// Token: 0x0400092F RID: 2351
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTwitterLoginStarted_Public_add_Void_Action_0;

	// Token: 0x04000930 RID: 2352
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTwitterLoginStarted_Public_rem_Void_Action_0;

	// Token: 0x04000931 RID: 2353
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTwitterLogOut_Public_add_Void_Action_0;

	// Token: 0x04000932 RID: 2354
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTwitterLogOut_Public_rem_Void_Action_0;

	// Token: 0x04000933 RID: 2355
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTwitterPostStarted_Public_add_Void_Action_0;

	// Token: 0x04000934 RID: 2356
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTwitterPostStarted_Public_rem_Void_Action_0;

	// Token: 0x04000935 RID: 2357
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0;

	// Token: 0x04000936 RID: 2358
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x04000937 RID: 2359
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0;

	// Token: 0x04000938 RID: 2360
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x04000939 RID: 2361
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0;

	// Token: 0x0400093A RID: 2362
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x0400093B RID: 2363
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_add_Void_Action_1_TWResult_0;

	// Token: 0x0400093C RID: 2364
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Virtual_Final_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x0400093D RID: 2365
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400093E RID: 2366
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

	// Token: 0x0400093F RID: 2367
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x04000940 RID: 2368
	private static readonly IntPtr NativeMethodInfoPtr_AuthenticateUser_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000941 RID: 2369
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000942 RID: 2370
	private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000943 RID: 2371
	private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_Texture2D_0;

	// Token: 0x04000944 RID: 2372
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_0;

	// Token: 0x04000945 RID: 2373
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Virtual_Final_New_TwitterPostingTask_String_Texture2D_0;

	// Token: 0x04000946 RID: 2374
	private static readonly IntPtr NativeMethodInfoPtr_LogOut_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000947 RID: 2375
	private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthed_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000948 RID: 2376
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000949 RID: 2377
	private static readonly IntPtr NativeMethodInfoPtr_get_userInfo_Public_Virtual_Final_New_get_TwitterUserInfo_0;

	// Token: 0x0400094A RID: 2378
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

	// Token: 0x0400094B RID: 2379
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessTokenSecret_Public_get_String_0;

	// Token: 0x0400094C RID: 2380
	private static readonly IntPtr NativeMethodInfoPtr_OnInited_Private_Void_String_0;

	// Token: 0x0400094D RID: 2381
	private static readonly IntPtr NativeMethodInfoPtr_OnAuthSuccess_Private_Void_0;

	// Token: 0x0400094E RID: 2382
	private static readonly IntPtr NativeMethodInfoPtr_OnAuthFailed_Private_Void_0;

	// Token: 0x0400094F RID: 2383
	private static readonly IntPtr NativeMethodInfoPtr_OnPostSuccess_Private_Void_0;

	// Token: 0x04000950 RID: 2384
	private static readonly IntPtr NativeMethodInfoPtr_OnPostFailed_Private_Void_0;

	// Token: 0x04000951 RID: 2385
	private static readonly IntPtr NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_String_0;

	// Token: 0x04000952 RID: 2386
	private static readonly IntPtr NativeMethodInfoPtr_OnUserDataLoadFailed_Private_Void_0;

	// Token: 0x04000953 RID: 2387
	private static readonly IntPtr NativeMethodInfoPtr_OnAuthInfoReceived_Private_Void_String_0;

	// Token: 0x04000954 RID: 2388
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000382 RID: 898
	[ObfuscatedName("AndroidTwitterManager+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003587 RID: 13703 RVA: 0x000DCB30 File Offset: 0x000DAD30
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidTwitterManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr);
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_0");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_1");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_2");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_3");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_4");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_5");
			AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, "<>9__54_6");
			AndroidTwitterManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670131);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670132);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670133);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670134);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_3_Internal_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670135);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_4_Internal_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670136);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_5_Internal_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670137);
			AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_6_Internal_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr, 100670138);
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000DCC9C File Offset: 0x000DAE9C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidTwitterManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x000DCCD8 File Offset: 0x000DAED8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x000DCD0C File Offset: 0x000DAF0C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x000DCD40 File Offset: 0x000DAF40
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x000DCD74 File Offset: 0x000DAF74
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_3(TWResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_3_Internal_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x000DCDB8 File Offset: 0x000DAFB8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_4(TWResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_4_Internal_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x000DCDFC File Offset: 0x000DAFFC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_5(TWResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_5_Internal_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000DCE40 File Offset: 0x000DB040
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__54_6(TWResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidTwitterManager.__c.NativeMethodInfoPtr___ctor_b__54_6_Internal_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00014BB9 File Offset: 0x00012DB9
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06003591 RID: 13713 RVA: 0x000DCE84 File Offset: 0x000DB084
		// (set) Token: 0x06003592 RID: 13714 RVA: 0x00014BC2 File Offset: 0x00012DC2
		public unsafe static AndroidTwitterManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidTwitterManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06003593 RID: 13715 RVA: 0x000DCEAC File Offset: 0x000DB0AC
		// (set) Token: 0x06003594 RID: 13716 RVA: 0x00014BD4 File Offset: 0x00012DD4
		public unsafe static Action __9__54_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x000DCED4 File Offset: 0x000DB0D4
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x00014BE6 File Offset: 0x00012DE6
		public unsafe static Action __9__54_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x000DCEFC File Offset: 0x000DB0FC
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x00014BF8 File Offset: 0x00012DF8
		public unsafe static Action __9__54_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x000DCF24 File Offset: 0x000DB124
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x00014C0A File Offset: 0x00012E0A
		public unsafe static Action<TWResult> __9__54_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x000DCF4C File Offset: 0x000DB14C
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x00014C1C File Offset: 0x00012E1C
		public unsafe static Action<TWResult> __9__54_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x000DCF74 File Offset: 0x000DB174
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x00014C2E File Offset: 0x00012E2E
		public unsafe static Action<TWResult> __9__54_5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x000DCF9C File Offset: 0x000DB19C
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x00014C40 File Offset: 0x00012E40
		public unsafe static Action<TWResult> __9__54_6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TWResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidTwitterManager.__c.NativeFieldInfoPtr___9__54_6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeFieldInfoPtr___9__54_0;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeFieldInfoPtr___9__54_1;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeFieldInfoPtr___9__54_2;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeFieldInfoPtr___9__54_3;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeFieldInfoPtr___9__54_4;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeFieldInfoPtr___9__54_5;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeFieldInfoPtr___9__54_6;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_0_Internal_Void_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_1_Internal_Void_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_2_Internal_Void_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_3_Internal_Void_TWResult_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_4_Internal_Void_TWResult_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_5_Internal_Void_TWResult_0;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__54_6_Internal_Void_TWResult_0;
	}
}
