using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x0200002C RID: 44
public class GP_AppInvitesController : Singleton<GP_AppInvitesController>
{
	// Token: 0x06000457 RID: 1111 RVA: 0x000253BC File Offset: 0x000235BC
	// Note: this type is marked as 'beforefieldinit'.
	static GP_AppInvitesController()
	{
		Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_AppInvitesController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr);
		GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInvitesSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, "ActionAppInvitesSent");
		GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInviteRetrieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, "ActionAppInviteRetrieved");
		GP_AppInvitesController.NativeMethodInfoPtr_add_ActionAppInvitesSent_Public_Static_add_Void_Action_1_GP_SendAppInvitesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663787);
		GP_AppInvitesController.NativeMethodInfoPtr_remove_ActionAppInvitesSent_Public_Static_rem_Void_Action_1_GP_SendAppInvitesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663788);
		GP_AppInvitesController.NativeMethodInfoPtr_add_ActionAppInviteRetrieved_Public_Static_add_Void_Action_1_GP_RetrieveAppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663789);
		GP_AppInvitesController.NativeMethodInfoPtr_remove_ActionAppInviteRetrieved_Public_Static_rem_Void_Action_1_GP_RetrieveAppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663790);
		GP_AppInvitesController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663791);
		GP_AppInvitesController.NativeMethodInfoPtr_StartInvitationDialog_Public_Void_GP_AppInviteBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663792);
		GP_AppInvitesController.NativeMethodInfoPtr_GetInvitation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663793);
		GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationDialogComplete_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663794);
		GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationDialogFailed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663795);
		GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationLoadFailed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663796);
		GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663797);
		GP_AppInvitesController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, 100663798);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00025504 File Offset: 0x00023704
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163547, RefRangeEnd = 163549, XrefRangeStart = 163536, XrefRangeEnd = 163547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAppInvitesSent(Action<GP_SendAppInvitesResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_add_ActionAppInvitesSent_Public_Static_add_Void_Action_1_GP_SendAppInvitesResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0002553C File Offset: 0x0002373C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163560, RefRangeEnd = 163562, XrefRangeStart = 163549, XrefRangeEnd = 163560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAppInvitesSent(Action<GP_SendAppInvitesResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_remove_ActionAppInvitesSent_Public_Static_rem_Void_Action_1_GP_SendAppInvitesResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00025574 File Offset: 0x00023774
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163573, RefRangeEnd = 163575, XrefRangeStart = 163562, XrefRangeEnd = 163573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAppInviteRetrieved(Action<GP_RetrieveAppInviteResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_add_ActionAppInviteRetrieved_Public_Static_add_Void_Action_1_GP_RetrieveAppInviteResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x000255AC File Offset: 0x000237AC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163586, RefRangeEnd = 163588, XrefRangeStart = 163575, XrefRangeEnd = 163586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAppInviteRetrieved(Action<GP_RetrieveAppInviteResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_remove_ActionAppInviteRetrieved_Public_Static_rem_Void_Action_1_GP_RetrieveAppInviteResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600045C RID: 1116 RVA: 0x000255E4 File Offset: 0x000237E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163588, XrefRangeEnd = 163593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600045D RID: 1117 RVA: 0x00025618 File Offset: 0x00023818
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163619, RefRangeEnd = 163621, XrefRangeStart = 163593, XrefRangeEnd = 163619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartInvitationDialog(GP_AppInviteBuilder builder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_StartInvitationDialog_Public_Void_GP_AppInviteBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0002565C File Offset: 0x0002385C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163622, RefRangeEnd = 163624, XrefRangeStart = 163621, XrefRangeEnd = 163622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInvitation(bool autoLaunchDeepLink = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref autoLaunchDeepLink;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_GetInvitation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x0002569C File Offset: 0x0002389C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163624, XrefRangeEnd = 163637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationDialogComplete(string InvitationIds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(InvitationIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationDialogComplete_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x000256E0 File Offset: 0x000238E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163637, XrefRangeEnd = 163649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationDialogFailed(string erroCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(erroCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationDialogFailed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00025724 File Offset: 0x00023924
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163649, XrefRangeEnd = 163661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationLoadFailed(string erroCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(erroCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationLoadFailed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00025768 File Offset: 0x00023968
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163661, XrefRangeEnd = 163699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr_OnInvitationLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x000257AC File Offset: 0x000239AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163699, XrefRangeEnd = 163705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AppInvitesController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00003E45 File Offset: 0x00002045
	public GP_AppInvitesController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x000257E8 File Offset: 0x000239E8
	// (set) Token: 0x06000466 RID: 1126 RVA: 0x00003E4E File Offset: 0x0000204E
	public unsafe static Action<GP_SendAppInvitesResult> ActionAppInvitesSent
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInvitesSent, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_SendAppInvitesResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInvitesSent, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x00025810 File Offset: 0x00023A10
	// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003E60 File Offset: 0x00002060
	public unsafe static Action<GP_RetrieveAppInviteResult> ActionAppInviteRetrieved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInviteRetrieved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RetrieveAppInviteResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GP_AppInvitesController.NativeFieldInfoPtr_ActionAppInviteRetrieved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400033F RID: 831
	private static readonly IntPtr NativeFieldInfoPtr_ActionAppInvitesSent;

	// Token: 0x04000340 RID: 832
	private static readonly IntPtr NativeFieldInfoPtr_ActionAppInviteRetrieved;

	// Token: 0x04000341 RID: 833
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAppInvitesSent_Public_Static_add_Void_Action_1_GP_SendAppInvitesResult_0;

	// Token: 0x04000342 RID: 834
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAppInvitesSent_Public_Static_rem_Void_Action_1_GP_SendAppInvitesResult_0;

	// Token: 0x04000343 RID: 835
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAppInviteRetrieved_Public_Static_add_Void_Action_1_GP_RetrieveAppInviteResult_0;

	// Token: 0x04000344 RID: 836
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAppInviteRetrieved_Public_Static_rem_Void_Action_1_GP_RetrieveAppInviteResult_0;

	// Token: 0x04000345 RID: 837
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000346 RID: 838
	private static readonly IntPtr NativeMethodInfoPtr_StartInvitationDialog_Public_Void_GP_AppInviteBuilder_0;

	// Token: 0x04000347 RID: 839
	private static readonly IntPtr NativeMethodInfoPtr_GetInvitation_Public_Void_Boolean_0;

	// Token: 0x04000348 RID: 840
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationDialogComplete_Private_Void_String_0;

	// Token: 0x04000349 RID: 841
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationDialogFailed_Private_Void_String_0;

	// Token: 0x0400034A RID: 842
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationLoadFailed_Private_Void_String_0;

	// Token: 0x0400034B RID: 843
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationLoaded_Private_Void_String_0;

	// Token: 0x0400034C RID: 844
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200036D RID: 877
	[ObfuscatedName("GP_AppInvitesController+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003494 RID: 13460 RVA: 0x000D949C File Offset: 0x000D769C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GP_AppInvitesController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr);
			GP_AppInvitesController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr, "<>9");
			GP_AppInvitesController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr, 100669983);
			GP_AppInvitesController.__c.NativeMethodInfoPtr___cctor_b__14_0_Internal_Void_GP_SendAppInvitesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr, 100669984);
			GP_AppInvitesController.__c.NativeMethodInfoPtr___cctor_b__14_1_Internal_Void_GP_RetrieveAppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr, 100669985);
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x000D9518 File Offset: 0x000D7718
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AppInvitesController.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x000D9554 File Offset: 0x000D7754
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__14_0(GP_SendAppInvitesResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.__c.NativeMethodInfoPtr___cctor_b__14_0_Internal_Void_GP_SendAppInvitesResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003497 RID: 13463 RVA: 0x000D9598 File Offset: 0x000D7798
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__14_1(GP_RetrieveAppInviteResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AppInvitesController.__c.NativeMethodInfoPtr___cctor_b__14_1_Internal_Void_GP_RetrieveAppInviteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x0001485F File Offset: 0x00012A5F
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000D95DC File Offset: 0x000D77DC
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x00014868 File Offset: 0x00012A68
		public unsafe static GP_AppInvitesController.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GP_AppInvitesController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_AppInvitesController.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GP_AppInvitesController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__14_0_Internal_Void_GP_SendAppInvitesResult_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__14_1_Internal_Void_GP_RetrieveAppInviteResult_0;
	}
}
