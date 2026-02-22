using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200008E RID: 142
public class SP_FB_API_v7 : global::Il2CppSystem.Object
{
	// Token: 0x06000A67 RID: 2663 RVA: 0x0003BB68 File Offset: 0x00039D68
	// Note: this type is marked as 'beforefieldinit'.
	static SP_FB_API_v7()
	{
		Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SP_FB_API_v7");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr);
		SP_FB_API_v7.NativeFieldInfoPtr_PUBLISH_PERMISSION_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, "PUBLISH_PERMISSION_STRING");
		SP_FB_API_v7.NativeFieldInfoPtr__UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, "_UserId");
		SP_FB_API_v7.NativeFieldInfoPtr__AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, "_AccessToken");
		SP_FB_API_v7.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664582);
		SP_FB_API_v7.NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664583);
		SP_FB_API_v7.NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664584);
		SP_FB_API_v7.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664585);
		SP_FB_API_v7.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664586);
		SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664587);
		SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664588);
		SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664589);
		SP_FB_API_v7.NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664590);
		SP_FB_API_v7.NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664591);
		SP_FB_API_v7.NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664592);
		SP_FB_API_v7.NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664593);
		SP_FB_API_v7.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664594);
		SP_FB_API_v7.NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664595);
		SP_FB_API_v7.NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664596);
		SP_FB_API_v7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr, 100664597);
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0003BD14 File Offset: 0x00039F14
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x0003BD48 File Offset: 0x00039F48
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x0003BD98 File Offset: 0x00039F98
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Logout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x0003BDCC File Offset: 0x00039FCC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0003BE30 File Offset: 0x0003A030
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x0003BF44 File Offset: 0x0003A144
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x0003C00C File Offset: 0x0003A20C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x0003C0C4 File Offset: 0x0003A2C4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0003C1A0 File Offset: 0x0003A3A0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AppInvite(string appLink, string imgLink)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appLink);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imgLink);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0003C1F4 File Offset: 0x0003A3F4
	public unsafe virtual bool IsLoggedIn
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0003C230 File Offset: 0x0003A430
	public unsafe virtual string UserId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0003C268 File Offset: 0x0003A468
	public unsafe virtual string AccessToken
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
	public unsafe virtual string AppId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173477, XrefRangeEnd = 173479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003C2D8 File Offset: 0x0003A4D8
	public unsafe static bool IsAPIEnabled
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x0003C308 File Offset: 0x0003A508
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173479, XrefRangeEnd = 173483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SP_FB_API_v7()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SP_FB_API_v7>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x0000606A File Offset: 0x0000426A
	public virtual void Login(params string[] scopes)
	{
		this.Login(new Il2CppStringArray(scopes));
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00006078 File Offset: 0x00004278
	public SP_FB_API_v7(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0003C344 File Offset: 0x0003A544
	// (set) Token: 0x06000A7B RID: 2683 RVA: 0x00006081 File Offset: 0x00004281
	public unsafe static string PUBLISH_PERMISSION_STRING
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SP_FB_API_v7.NativeFieldInfoPtr_PUBLISH_PERMISSION_STRING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SP_FB_API_v7.NativeFieldInfoPtr_PUBLISH_PERMISSION_STRING, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0003C364 File Offset: 0x0003A564
	// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00006093 File Offset: 0x00004293
	public unsafe string _UserId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SP_FB_API_v7.NativeFieldInfoPtr__UserId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SP_FB_API_v7.NativeFieldInfoPtr__UserId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0003C38C File Offset: 0x0003A58C
	// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000060B2 File Offset: 0x000042B2
	public unsafe string _AccessToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SP_FB_API_v7.NativeFieldInfoPtr__AccessToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SP_FB_API_v7.NativeFieldInfoPtr__AccessToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000861 RID: 2145
	private static readonly IntPtr NativeFieldInfoPtr_PUBLISH_PERMISSION_STRING;

	// Token: 0x04000862 RID: 2146
	private static readonly IntPtr NativeFieldInfoPtr__UserId;

	// Token: 0x04000863 RID: 2147
	private static readonly IntPtr NativeFieldInfoPtr__AccessToken;

	// Token: 0x04000864 RID: 2148
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000865 RID: 2149
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0;

	// Token: 0x04000866 RID: 2150
	private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000867 RID: 2151
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0;

	// Token: 0x04000868 RID: 2152
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0;

	// Token: 0x04000869 RID: 2153
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0;

	// Token: 0x0400086A RID: 2154
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x0400086B RID: 2155
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x0400086C RID: 2156
	private static readonly IntPtr NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x0400086D RID: 2157
	private static readonly IntPtr NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x0400086E RID: 2158
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400086F RID: 2159
	private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x04000870 RID: 2160
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0;

	// Token: 0x04000871 RID: 2161
	private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x04000872 RID: 2162
	private static readonly IntPtr NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0;

	// Token: 0x04000873 RID: 2163
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
