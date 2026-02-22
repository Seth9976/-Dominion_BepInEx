using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000033 RID: 51
public class GooglePlayInvitationManager : Singleton<GooglePlayInvitationManager>
{
	// Token: 0x060004C6 RID: 1222 RVA: 0x00026DB4 File Offset: 0x00024FB4
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayInvitationManager()
	{
		Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayInvitationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr);
		GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "ActionInvitationReceived");
		GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "ActionInvitationAccepted");
		GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationsListLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "ActionInvitationsListLoaded");
		GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationInboxClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "ActionInvitationInboxClosed");
		GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "ActionInvitationRemoved");
		GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663854);
		GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663855);
		GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663856);
		GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663857);
		GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationsListLoaded_Public_Static_add_Void_Action_1_List_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663858);
		GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationsListLoaded_Public_Static_rem_Void_Action_1_List_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663859);
		GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationInboxClosed_Public_Static_add_Void_Action_1_AN_InvitationInboxCloseResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663860);
		GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationInboxClosed_Public_Static_rem_Void_Action_1_AN_InvitationInboxCloseResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663861);
		GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663862);
		GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663863);
		GooglePlayInvitationManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663864);
		GooglePlayInvitationManager.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663865);
		GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663866);
		GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663867);
		GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663868);
		GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663869);
		GooglePlayInvitationManager.NativeMethodInfoPtr_OnLoadInvitationsResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663870);
		GooglePlayInvitationManager.NativeMethodInfoPtr_InviteFromString_Private_GP_Invite_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663871);
		GooglePlayInvitationManager.NativeMethodInfoPtr_RegisterInvitationListener_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663872);
		GooglePlayInvitationManager.NativeMethodInfoPtr_UnregisterInvitationListener_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663873);
		GooglePlayInvitationManager.NativeMethodInfoPtr_LoadInvitations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663874);
		GooglePlayInvitationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, 100663875);
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x00027000 File Offset: 0x00025200
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 164225, RefRangeEnd = 164228, XrefRangeStart = 164214, XrefRangeEnd = 164225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationReceived(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00027038 File Offset: 0x00025238
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164228, XrefRangeEnd = 164239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationReceived(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00027070 File Offset: 0x00025270
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 164250, RefRangeEnd = 164253, XrefRangeStart = 164239, XrefRangeEnd = 164250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationAccepted(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x000270A8 File Offset: 0x000252A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164253, XrefRangeEnd = 164264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationAccepted(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x000270E0 File Offset: 0x000252E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164264, XrefRangeEnd = 164275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationsListLoaded(Action<List<GP_Invite>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationsListLoaded_Public_Static_add_Void_Action_1_List_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00027118 File Offset: 0x00025318
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164275, XrefRangeEnd = 164286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationsListLoaded(Action<List<GP_Invite>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationsListLoaded_Public_Static_rem_Void_Action_1_List_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00027150 File Offset: 0x00025350
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164286, XrefRangeEnd = 164297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationInboxClosed(Action<AN_InvitationInboxCloseResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationInboxClosed_Public_Static_add_Void_Action_1_AN_InvitationInboxCloseResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00027188 File Offset: 0x00025388
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164297, XrefRangeEnd = 164308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationInboxClosed(Action<AN_InvitationInboxCloseResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationInboxClosed_Public_Static_rem_Void_Action_1_AN_InvitationInboxCloseResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x000271C0 File Offset: 0x000253C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164319, RefRangeEnd = 164320, XrefRangeStart = 164308, XrefRangeEnd = 164319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationRemoved(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x000271F8 File Offset: 0x000253F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164320, XrefRangeEnd = 164331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationRemoved(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x00027230 File Offset: 0x00025430
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164331, XrefRangeEnd = 164342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x00027264 File Offset: 0x00025464
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x00027298 File Offset: 0x00025498
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164342, XrefRangeEnd = 164360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationReceived(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x000272DC File Offset: 0x000254DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164360, XrefRangeEnd = 164384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationAccepted(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x00027320 File Offset: 0x00025520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164384, XrefRangeEnd = 164392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationRemoved(string invId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x00027364 File Offset: 0x00025564
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164392, XrefRangeEnd = 164404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationBoxUiClosed(string response)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(response);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000273A8 File Offset: 0x000255A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164404, XrefRangeEnd = 164458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadInvitationsResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_OnLoadInvitationsResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x000273EC File Offset: 0x000255EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 164472, RefRangeEnd = 164475, XrefRangeStart = 164458, XrefRangeEnd = 164472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Invite InviteFromString(Il2CppStringArray storeData, int offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_InviteFromString_Private_GP_Invite_Il2CppStringArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Invite>(intPtr3) : null;
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x0002744C File Offset: 0x0002564C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 164476, RefRangeEnd = 164480, XrefRangeStart = 164475, XrefRangeEnd = 164476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterInvitationListener()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_RegisterInvitationListener_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x00027480 File Offset: 0x00025680
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164480, XrefRangeEnd = 164533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnregisterInvitationListener()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_UnregisterInvitationListener_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x000274B4 File Offset: 0x000256B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164533, XrefRangeEnd = 164534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInvitations()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr_LoadInvitations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x000274E8 File Offset: 0x000256E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164534, XrefRangeEnd = 164540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayInvitationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00004009 File Offset: 0x00002209
	public GooglePlayInvitationManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x00027524 File Offset: 0x00025724
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004012 File Offset: 0x00002212
	public unsafe static Action<GP_Invite> ActionInvitationReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_Invite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0002754C File Offset: 0x0002574C
	// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004024 File Offset: 0x00002224
	public unsafe static Action<GP_Invite> ActionInvitationAccepted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationAccepted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_Invite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationAccepted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00027574 File Offset: 0x00025774
	// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004036 File Offset: 0x00002236
	public unsafe static Action<List<GP_Invite>> ActionInvitationsListLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationsListLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<GP_Invite>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationsListLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0002759C File Offset: 0x0002579C
	// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00004048 File Offset: 0x00002248
	public unsafe static Action<AN_InvitationInboxCloseResult> ActionInvitationInboxClosed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationInboxClosed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_InvitationInboxCloseResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationInboxClosed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000275C4 File Offset: 0x000257C4
	// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0000405A File Offset: 0x0000225A
	public unsafe static Action<string> ActionInvitationRemoved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationRemoved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.NativeFieldInfoPtr_ActionInvitationRemoved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000390 RID: 912
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationReceived;

	// Token: 0x04000391 RID: 913
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationAccepted;

	// Token: 0x04000392 RID: 914
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationsListLoaded;

	// Token: 0x04000393 RID: 915
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationInboxClosed;

	// Token: 0x04000394 RID: 916
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationRemoved;

	// Token: 0x04000395 RID: 917
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0;

	// Token: 0x04000396 RID: 918
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0;

	// Token: 0x04000397 RID: 919
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0;

	// Token: 0x04000398 RID: 920
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0;

	// Token: 0x04000399 RID: 921
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationsListLoaded_Public_Static_add_Void_Action_1_List_1_GP_Invite_0;

	// Token: 0x0400039A RID: 922
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationsListLoaded_Public_Static_rem_Void_Action_1_List_1_GP_Invite_0;

	// Token: 0x0400039B RID: 923
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationInboxClosed_Public_Static_add_Void_Action_1_AN_InvitationInboxCloseResult_0;

	// Token: 0x0400039C RID: 924
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationInboxClosed_Public_Static_rem_Void_Action_1_AN_InvitationInboxCloseResult_0;

	// Token: 0x0400039D RID: 925
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x0400039E RID: 926
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x0400039F RID: 927
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040003A0 RID: 928
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040003A1 RID: 929
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationReceived_Private_Void_String_0;

	// Token: 0x040003A2 RID: 930
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_String_0;

	// Token: 0x040003A3 RID: 931
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0;

	// Token: 0x040003A4 RID: 932
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0;

	// Token: 0x040003A5 RID: 933
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadInvitationsResult_Private_Void_String_0;

	// Token: 0x040003A6 RID: 934
	private static readonly IntPtr NativeMethodInfoPtr_InviteFromString_Private_GP_Invite_Il2CppStringArray_Int32_0;

	// Token: 0x040003A7 RID: 935
	private static readonly IntPtr NativeMethodInfoPtr_RegisterInvitationListener_Public_Void_0;

	// Token: 0x040003A8 RID: 936
	private static readonly IntPtr NativeMethodInfoPtr_UnregisterInvitationListener_Public_Void_0;

	// Token: 0x040003A9 RID: 937
	private static readonly IntPtr NativeMethodInfoPtr_LoadInvitations_Public_Void_0;

	// Token: 0x040003AA RID: 938
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000370 RID: 880
	[ObfuscatedName("GooglePlayInvitationManager+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060034AC RID: 13484 RVA: 0x000D9944 File Offset: 0x000D7B44
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayInvitationManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr);
			GooglePlayInvitationManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, "<>9");
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100669996);
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100669997);
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100669998);
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_2_Internal_Void_List_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100669999);
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_3_Internal_Void_AN_InvitationInboxCloseResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100670000);
			GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_4_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr, 100670001);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000D99FC File Offset: 0x000D7BFC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayInvitationManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000D9A38 File Offset: 0x000D7C38
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__27_0(GP_Invite <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000D9A7C File Offset: 0x000D7C7C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__27_1(GP_Invite <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000D9AC0 File Offset: 0x000D7CC0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__27_2(List<GP_Invite> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_2_Internal_Void_List_1_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000D9B04 File Offset: 0x000D7D04
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__27_3(AN_InvitationInboxCloseResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_3_Internal_Void_AN_InvitationInboxCloseResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x000D9B48 File Offset: 0x000D7D48
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__27_4(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayInvitationManager.__c.NativeMethodInfoPtr___cctor_b__27_4_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x000148C2 File Offset: 0x00012AC2
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000D9B8C File Offset: 0x000D7D8C
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x000148CB File Offset: 0x00012ACB
		public unsafe static GooglePlayInvitationManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayInvitationManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayInvitationManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayInvitationManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_0_Internal_Void_GP_Invite_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_1_Internal_Void_GP_Invite_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_2_Internal_Void_List_1_GP_Invite_0;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_3_Internal_Void_AN_InvitationInboxCloseResult_0;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__27_4_Internal_Void_String_0;
	}
}
