using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000A5 RID: 165
public class TwitterManagerInterface : Il2CppObjectBase
{
	// Token: 0x06000BED RID: 3053 RVA: 0x00040D28 File Offset: 0x0003EF28
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterManagerInterface()
	{
		Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterManagerInterface");
		TwitterManagerInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664741);
		TwitterManagerInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664742);
		TwitterManagerInterface.NativeMethodInfoPtr_AuthenticateUser_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664743);
		TwitterManagerInterface.NativeMethodInfoPtr_LoadUserData_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664744);
		TwitterManagerInterface.NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664745);
		TwitterManagerInterface.NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664746);
		TwitterManagerInterface.NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664747);
		TwitterManagerInterface.NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664748);
		TwitterManagerInterface.NativeMethodInfoPtr_LogOut_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664749);
		TwitterManagerInterface.NativeMethodInfoPtr_get_IsAuthed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664750);
		TwitterManagerInterface.NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664751);
		TwitterManagerInterface.NativeMethodInfoPtr_get_userInfo_Public_Abstract_Virtual_New_get_TwitterUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664752);
		TwitterManagerInterface.NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664753);
		TwitterManagerInterface.NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664754);
		TwitterManagerInterface.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664755);
		TwitterManagerInterface.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664756);
		TwitterManagerInterface.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664757);
		TwitterManagerInterface.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664758);
		TwitterManagerInterface.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664759);
		TwitterManagerInterface.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterManagerInterface>.NativeClassPtr, 100664760);
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x00040EE0 File Offset: 0x0003F0E0
	[CallerCount(0)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00040F1C File Offset: 0x0003F11C
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x00040F7C File Offset: 0x0003F17C
	[CallerCount(0)]
	public unsafe virtual void AuthenticateUser()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_AuthenticateUser_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00040FB8 File Offset: 0x0003F1B8
	[CallerCount(0)]
	public unsafe virtual void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_LoadUserData_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00040FF4 File Offset: 0x0003F1F4
	[CallerCount(0)]
	public unsafe virtual void Post(string status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00041044 File Offset: 0x0003F244
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_Texture2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x000410A4 File Offset: 0x0003F2A4
	[CallerCount(0)]
	public unsafe virtual TwitterPostingTask PostWithAuthCheck(string status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask>(intPtr3) : null;
		}
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00041100 File Offset: 0x0003F300
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_Texture2D_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterPostingTask>(intPtr3) : null;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x00041170 File Offset: 0x0003F370
	[CallerCount(0)]
	public unsafe virtual void LogOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_LogOut_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000411AC File Offset: 0x0003F3AC
	public unsafe virtual bool IsAuthed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_get_IsAuthed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x000411F4 File Offset: 0x0003F3F4
	public unsafe virtual bool IsInited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0004123C File Offset: 0x0003F43C
	public unsafe virtual TwitterUserInfo userInfo
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_get_userInfo_Public_Abstract_Virtual_New_get_TwitterUserInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterUserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00041288 File Offset: 0x0003F488
	[CallerCount(0)]
	public unsafe virtual void add_OnTwitterInitedAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x000412D8 File Offset: 0x0003F4D8
	[CallerCount(0)]
	public unsafe virtual void remove_OnTwitterInitedAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x00041328 File Offset: 0x0003F528
	[CallerCount(0)]
	public unsafe virtual void add_OnAuthCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x00041378 File Offset: 0x0003F578
	[CallerCount(0)]
	public unsafe virtual void remove_OnAuthCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x000413C8 File Offset: 0x0003F5C8
	[CallerCount(0)]
	public unsafe virtual void add_OnPostingCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x00041418 File Offset: 0x0003F618
	[CallerCount(0)]
	public unsafe virtual void remove_OnPostingCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x00041468 File Offset: 0x0003F668
	[CallerCount(0)]
	public unsafe virtual void add_OnUserDataRequestCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x000414B8 File Offset: 0x0003F6B8
	[CallerCount(0)]
	public unsafe virtual void remove_OnUserDataRequestCompleteAction(Action<TWResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwitterManagerInterface.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00006C0D File Offset: 0x00004E0D
	public TwitterManagerInterface(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000968 RID: 2408
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x04000969 RID: 2409
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0;

	// Token: 0x0400096A RID: 2410
	private static readonly IntPtr NativeMethodInfoPtr_AuthenticateUser_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400096B RID: 2411
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400096C RID: 2412
	private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x0400096D RID: 2413
	private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Abstract_Virtual_New_Void_String_Texture2D_0;

	// Token: 0x0400096E RID: 2414
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_0;

	// Token: 0x0400096F RID: 2415
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Abstract_Virtual_New_TwitterPostingTask_String_Texture2D_0;

	// Token: 0x04000970 RID: 2416
	private static readonly IntPtr NativeMethodInfoPtr_LogOut_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x04000971 RID: 2417
	private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthed_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x04000972 RID: 2418
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x04000973 RID: 2419
	private static readonly IntPtr NativeMethodInfoPtr_get_userInfo_Public_Abstract_Virtual_New_get_TwitterUserInfo_0;

	// Token: 0x04000974 RID: 2420
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTwitterInitedAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0;

	// Token: 0x04000975 RID: 2421
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTwitterInitedAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x04000976 RID: 2422
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0;

	// Token: 0x04000977 RID: 2423
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x04000978 RID: 2424
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0;

	// Token: 0x04000979 RID: 2425
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0;

	// Token: 0x0400097A RID: 2426
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_add_Void_Action_1_TWResult_0;

	// Token: 0x0400097B RID: 2427
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Abstract_Virtual_New_rem_Void_Action_1_TWResult_0;
}
