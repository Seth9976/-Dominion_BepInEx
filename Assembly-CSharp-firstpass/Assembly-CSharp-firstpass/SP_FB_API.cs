using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200008A RID: 138
public class SP_FB_API : Il2CppObjectBase
{
	// Token: 0x06000983 RID: 2435 RVA: 0x000376DC File Offset: 0x000358DC
	// Note: this type is marked as 'beforefieldinit'.
	static SP_FB_API()
	{
		Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SP_FB_API");
		SP_FB_API.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664422);
		SP_FB_API.NativeMethodInfoPtr_Login_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664423);
		SP_FB_API.NativeMethodInfoPtr_Logout_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664424);
		SP_FB_API.NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664425);
		SP_FB_API.NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664426);
		SP_FB_API.NativeMethodInfoPtr_AppInvite_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664427);
		SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664428);
		SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664429);
		SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664430);
		SP_FB_API.NativeMethodInfoPtr_FeedShare_Public_Abstract_Virtual_New_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664431);
		SP_FB_API.NativeMethodInfoPtr_get_IsLoggedIn_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664432);
		SP_FB_API.NativeMethodInfoPtr_get_UserId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664433);
		SP_FB_API.NativeMethodInfoPtr_get_AccessToken_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664434);
		SP_FB_API.NativeMethodInfoPtr_get_AppId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API>.NativeClassPtr, 100664435);
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0003781C File Offset: 0x00035A1C
	[CallerCount(0)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00037858 File Offset: 0x00035A58
	[CallerCount(0)]
	public unsafe virtual void Login([Optional] Il2CppStringArray scopes)
	{
		if (scopes == null)
		{
			scopes = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_Login_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x000378B4 File Offset: 0x00035AB4
	[CallerCount(0)]
	public unsafe virtual void Logout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_Logout_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x000378F0 File Offset: 0x00035AF0
	[CallerCount(0)]
	public unsafe virtual void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(query);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x00037960 File Offset: 0x00035B60
	[CallerCount(0)]
	public unsafe virtual void API(string query, FB_HttpMethod method, SPFacebook.FB_Delegate callback, WWWForm form)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(query);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(form);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x000379E0 File Offset: 0x00035BE0
	[CallerCount(0)]
	public unsafe virtual void AppInvite(string appLinkUrl, string previewImgUrl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appLinkUrl);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(previewImgUrl);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_AppInvite_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00037A40 File Offset: 0x00035C40
	[CallerCount(0)]
	public unsafe virtual void AppRequest(string message, FB_RequestActionType actionType, string objectId, Il2CppStringArray to, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00037AE8 File Offset: 0x00035CE8
	[CallerCount(0)]
	public unsafe virtual void AppRequest(string message, FB_RequestActionType actionType, string objectId, List<global::Il2CppSystem.Object> filters = null, Il2CppStringArray excludeIds = null, Nullable<int> maxRecipients = null, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filters);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeIds);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(maxRecipients));
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x00037BBC File Offset: 0x00035DBC
	[CallerCount(0)]
	public unsafe virtual void AppRequest(string message, Il2CppStringArray to = null, List<global::Il2CppSystem.Object> filters = null, Il2CppStringArray excludeIds = null, Nullable<int> maxRecipients = null, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filters);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeIds);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(maxRecipients));
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00037C80 File Offset: 0x00035E80
	[CallerCount(0)]
	public unsafe virtual void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(toId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(link);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkName);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkCaption);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkDescription);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(picture);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionName);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionLink);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_FeedShare_Public_Abstract_Virtual_New_Void_String_String_String_String_String_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x0600098E RID: 2446 RVA: 0x00037D64 File Offset: 0x00035F64
	public unsafe virtual bool IsLoggedIn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_get_IsLoggedIn_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x0600098F RID: 2447 RVA: 0x00037DAC File Offset: 0x00035FAC
	public unsafe virtual string UserId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_get_UserId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x06000990 RID: 2448 RVA: 0x00037DF0 File Offset: 0x00035FF0
	public unsafe virtual string AccessToken
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_get_AccessToken_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x06000991 RID: 2449 RVA: 0x00037E34 File Offset: 0x00036034
	public unsafe virtual string AppId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SP_FB_API.NativeMethodInfoPtr_get_AppId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00005D98 File Offset: 0x00003F98
	public virtual void Login(params string[] scopes)
	{
		this.Login(new Il2CppStringArray(scopes));
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00005DA6 File Offset: 0x00003FA6
	public SP_FB_API(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040007A5 RID: 1957
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040007A6 RID: 1958
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0;

	// Token: 0x040007A7 RID: 1959
	private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x040007A8 RID: 1960
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_0;

	// Token: 0x040007A9 RID: 1961
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Abstract_Virtual_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0;

	// Token: 0x040007AA RID: 1962
	private static readonly IntPtr NativeMethodInfoPtr_AppInvite_Public_Abstract_Virtual_New_Void_String_String_0;

	// Token: 0x040007AB RID: 1963
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0;

	// Token: 0x040007AC RID: 1964
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x040007AD RID: 1965
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Abstract_Virtual_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x040007AE RID: 1966
	private static readonly IntPtr NativeMethodInfoPtr_FeedShare_Public_Abstract_Virtual_New_Void_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x040007AF RID: 1967
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggedIn_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x040007B0 RID: 1968
	private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_Abstract_Virtual_New_get_String_0;

	// Token: 0x040007B1 RID: 1969
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_Abstract_Virtual_New_get_String_0;

	// Token: 0x040007B2 RID: 1970
	private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_Abstract_Virtual_New_get_String_0;
}
