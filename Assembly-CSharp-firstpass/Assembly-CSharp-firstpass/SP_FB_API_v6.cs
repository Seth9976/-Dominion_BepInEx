using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200008D RID: 141
public class SP_FB_API_v6 : global::Il2CppSystem.Object
{
	// Token: 0x06000A54 RID: 2644 RVA: 0x0003B3C8 File Offset: 0x000395C8
	// Note: this type is marked as 'beforefieldinit'.
	static SP_FB_API_v6()
	{
		Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SP_FB_API_v6");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr);
		SP_FB_API_v6.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664566);
		SP_FB_API_v6.NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664567);
		SP_FB_API_v6.NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664568);
		SP_FB_API_v6.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664569);
		SP_FB_API_v6.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664570);
		SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664571);
		SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664572);
		SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664573);
		SP_FB_API_v6.NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664574);
		SP_FB_API_v6.NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664575);
		SP_FB_API_v6.NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664576);
		SP_FB_API_v6.NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664577);
		SP_FB_API_v6.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664578);
		SP_FB_API_v6.NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664579);
		SP_FB_API_v6.NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664580);
		SP_FB_API_v6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr, 100664581);
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x0003B538 File Offset: 0x00039738
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x0003B56C File Offset: 0x0003976C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x0003B5BC File Offset: 0x000397BC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Logout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0003B5F0 File Offset: 0x000397F0
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x0003B654 File Offset: 0x00039854
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x0003B6CC File Offset: 0x000398CC
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x0003B768 File Offset: 0x00039968
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0003B830 File Offset: 0x00039A30
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x0003B8E8 File Offset: 0x00039AE8
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x0003B9C4 File Offset: 0x00039BC4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AppInvite(string appLinkUrl, string previewImageUrl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appLinkUrl);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(previewImageUrl);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x06000A5F RID: 2655 RVA: 0x0003BA18 File Offset: 0x00039C18
	public unsafe virtual bool IsLoggedIn
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0003BA54 File Offset: 0x00039C54
	public unsafe virtual string UserId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173471, XrefRangeEnd = 173473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x06000A61 RID: 2657 RVA: 0x0003BA8C File Offset: 0x00039C8C
	public unsafe virtual string AccessToken
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173473, XrefRangeEnd = 173475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0003BAC4 File Offset: 0x00039CC4
	public unsafe virtual string AppId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173475, XrefRangeEnd = 173477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0003BAFC File Offset: 0x00039CFC
	public unsafe static bool IsAPIEnabled
	{
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0003BB2C File Offset: 0x00039D2C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SP_FB_API_v6()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SP_FB_API_v6>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SP_FB_API_v6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00006053 File Offset: 0x00004253
	public virtual void Login(params string[] scopes)
	{
		this.Login(new Il2CppStringArray(scopes));
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00006061 File Offset: 0x00004261
	public SP_FB_API_v6(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000851 RID: 2129
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000852 RID: 2130
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Virtual_Final_New_Void_Il2CppStringArray_0;

	// Token: 0x04000853 RID: 2131
	private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000854 RID: 2132
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_0;

	// Token: 0x04000855 RID: 2133
	private static readonly IntPtr NativeMethodInfoPtr_API_Public_Virtual_Final_New_Void_String_FB_HttpMethod_FB_Delegate_WWWForm_0;

	// Token: 0x04000856 RID: 2134
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0;

	// Token: 0x04000857 RID: 2135
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x04000858 RID: 2136
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Virtual_Final_New_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x04000859 RID: 2137
	private static readonly IntPtr NativeMethodInfoPtr_FeedShare_Public_Virtual_Final_New_Void_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x0400085A RID: 2138
	private static readonly IntPtr NativeMethodInfoPtr_AppInvite_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x0400085B RID: 2139
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggedIn_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400085C RID: 2140
	private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400085D RID: 2141
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400085E RID: 2142
	private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400085F RID: 2143
	private static readonly IntPtr NativeMethodInfoPtr_get_IsAPIEnabled_Public_Static_get_Boolean_0;

	// Token: 0x04000860 RID: 2144
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
