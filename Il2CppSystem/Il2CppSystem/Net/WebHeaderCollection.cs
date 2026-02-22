using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Net
{
	// Token: 0x020000DA RID: 218
	[DefaultMember("Item")]
	[Serializable]
	public class WebHeaderCollection : NameValueCollection
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x0003F088 File Offset: 0x0003D288
		// Note: this type is marked as 'beforefieldinit'.
		static WebHeaderCollection()
		{
			Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebHeaderCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr);
			WebHeaderCollection.NativeFieldInfoPtr_HInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HInfo");
			WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_CommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_NumCommonHeaders");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderNames");
			WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "s_CommonHeaderHints");
			WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_InnerCollection");
			WebHeaderCollection.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "m_Type");
			WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "HttpTrimCharacters");
			WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, "RfcCharMap");
			WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665038);
			WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665039);
			WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665040);
			WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665041);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665042);
			WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665043);
			WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665044);
			WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665045);
			WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665046);
			WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665047);
			WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665048);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665049);
			WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665050);
			WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665051);
			WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665052);
			WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665053);
			WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665054);
			WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665055);
			WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665056);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665057);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665058);
			WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665059);
			WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665060);
			WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665061);
			WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665062);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665063);
			WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665064);
			WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665065);
			WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665066);
			WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr, 100665067);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 46548, RefRangeEnd = 46561, XrefRangeStart = 46542, XrefRangeEnd = 46548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NormalizeCommonHeaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0003F3F8 File Offset: 0x0003D5F8
		public unsafe NameValueCollection InnerCollection
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 46569, RefRangeEnd = 46581, XrefRangeStart = 46561, XrefRangeEnd = 46569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0003F438 File Offset: 0x0003D638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46587, RefRangeEnd = 46588, XrefRangeStart = 46581, XrefRangeEnd = 46587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowMultiValues(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0003F47C File Offset: 0x0003D67C
		public unsafe bool AllowHttpRequestHeader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46599, RefRangeEnd = 46600, XrefRangeStart = 46588, XrefRangeEnd = 46599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(HttpRequestHeader header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref header;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46604, RefRangeEnd = 46607, XrefRangeStart = 46600, XrefRangeEnd = 46604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003F54C File Offset: 0x0003D74C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46611, RefRangeEnd = 46616, XrefRangeStart = 46607, XrefRangeEnd = 46611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0003F5A0 File Offset: 0x0003D7A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 46618, RefRangeEnd = 46628, XrefRangeStart = 46616, XrefRangeEnd = 46618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveInternal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003F5E4 File Offset: 0x0003D7E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 46649, RefRangeEnd = 46658, XrefRangeStart = 46628, XrefRangeEnd = 46649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CheckBadChars(string name, bool isHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHeaderValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003F630 File Offset: 0x0003D830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46658, XrefRangeEnd = 46661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsNonAsciiChars(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003F674 File Offset: 0x0003D874
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 46671, RefRangeEnd = 46675, XrefRangeStart = 46661, XrefRangeEnd = 46671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowOnRestrictedHeader(string headerName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(headerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0003F6B8 File Offset: 0x0003D8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46675, XrefRangeEnd = 46700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Add(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0003F718 File Offset: 0x0003D918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46745, RefRangeEnd = 46746, XrefRangeStart = 46700, XrefRangeEnd = 46745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_Add_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0003F75C File Offset: 0x0003D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46746, XrefRangeEnd = 46780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0003F7BC File Offset: 0x0003D9BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46813, RefRangeEnd = 46816, XrefRangeStart = 46780, XrefRangeEnd = 46813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternal(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003F810 File Offset: 0x0003DA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46816, XrefRangeEnd = 46826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003F860 File Offset: 0x0003DA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46826, XrefRangeEnd = 46841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetValues(string header)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0003F8BC File Offset: 0x0003DABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46841, XrefRangeEnd = 46952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003F900 File Offset: 0x0003DB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46977, RefRangeEnd = 46978, XrefRangeStart = 46952, XrefRangeEnd = 46977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winInetCompat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0003F958 File Offset: 0x0003DB58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46983, RefRangeEnd = 46986, XrefRangeStart = 46978, XrefRangeEnd = 46983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0003F994 File Offset: 0x0003DB94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46998, RefRangeEnd = 47003, XrefRangeStart = 46986, XrefRangeEnd = 46998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(WebHeaderCollectionType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47003, XrefRangeEnd = 47026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebHeaderCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0003FA40 File Offset: 0x0003DC40
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0003FA90 File Offset: 0x0003DC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47026, XrefRangeEnd = 47036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0003FAF4 File Offset: 0x0003DCF4
		[CallerCount(0)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebHeaderCollection.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0003FB50 File Offset: 0x0003DD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47036, XrefRangeEnd = 47064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0003FBA4 File Offset: 0x0003DDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47064, XrefRangeEnd = 47070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0003FBF0 File Offset: 0x0003DDF0
		public unsafe override int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0003FC38 File Offset: 0x0003DE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47070, XrefRangeEnd = 47073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string Get(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0003FC88 File Offset: 0x0003DE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47073, XrefRangeEnd = 47076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebHeaderCollection.NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00006DB3 File Offset: 0x00004FB3
		public WebHeaderCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0003FCD8 File Offset: 0x0003DED8
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00006DBC File Offset: 0x00004FBC
		public unsafe static HeaderInfoTable HInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderInfoTable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0003FD00 File Offset: 0x0003DF00
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00006DCE File Offset: 0x00004FCE
		public unsafe Il2CppStringArray m_CommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_CommonHeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0003FD30 File Offset: 0x0003DF30
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00006DED File Offset: 0x00004FED
		public unsafe int m_NumCommonHeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_NumCommonHeaders)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0003FD58 File Offset: 0x0003DF58
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00006E08 File Offset: 0x00005008
		public unsafe static Il2CppStringArray s_CommonHeaderNames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderNames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0003FD80 File Offset: 0x0003DF80
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00006E1A File Offset: 0x0000501A
		public unsafe static Il2CppStructArray<sbyte> s_CommonHeaderHints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_s_CommonHeaderHints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0003FDA8 File Offset: 0x0003DFA8
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00006E2C File Offset: 0x0000502C
		public unsafe NameValueCollection m_InnerCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_InnerCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0003FDD8 File Offset: 0x0003DFD8
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00006E4B File Offset: 0x0000504B
		public unsafe WebHeaderCollectionType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebHeaderCollection.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0003FE00 File Offset: 0x0003E000
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00006E66 File Offset: 0x00005066
		public unsafe static Il2CppStructArray<char> HttpTrimCharacters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_HttpTrimCharacters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0003FE28 File Offset: 0x0003E028
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00006E78 File Offset: 0x00005078
		public unsafe static Il2CppStructArray<WebHeaderCollection.RfcChar> RfcCharMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<WebHeaderCollection.RfcChar>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebHeaderCollection.NativeFieldInfoPtr_RfcCharMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeFieldInfoPtr_HInfo;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeFieldInfoPtr_m_CommonHeaders;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeFieldInfoPtr_m_NumCommonHeaders;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderNames;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_s_CommonHeaderHints;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_m_InnerCollection;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_HttpTrimCharacters;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_RfcCharMap;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_NormalizeCommonHeaders_Private_Void_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerCollection_Private_get_NameValueCollection_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_AllowMultiValues_Internal_Static_Boolean_String_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowHttpRequestHeader_Private_get_Boolean_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_HttpRequestHeader_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternal_Internal_Void_String_String_0;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeMethodInfoPtr_RemoveInternal_Internal_Void_String_0;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeMethodInfoPtr_CheckBadChars_Internal_Static_String_String_Boolean_0;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeMethodInfoPtr_ContainsNonAsciiChars_Internal_Static_Boolean_String_0;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnRestrictedHeader_Internal_Void_String_0;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_String_String_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_String_String_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_SetInternal_Internal_Void_String_String_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Virtual_Il2CppStringArray_String_0;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeMethodInfoPtr_GetAsString_Internal_Static_String_NameValueCollection_Boolean_Boolean_0;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WebHeaderCollectionType_0;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_Void_Object_0;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_String_0;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_String_Int32_0;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Virtual_String_Int32_0;

		// Token: 0x020001AB RID: 427
		public enum RfcChar : byte
		{
			// Token: 0x04001356 RID: 4950
			High,
			// Token: 0x04001357 RID: 4951
			Reg,
			// Token: 0x04001358 RID: 4952
			Ctl,
			// Token: 0x04001359 RID: 4953
			CR,
			// Token: 0x0400135A RID: 4954
			LF,
			// Token: 0x0400135B RID: 4955
			WS,
			// Token: 0x0400135C RID: 4956
			Colon,
			// Token: 0x0400135D RID: 4957
			Delim
		}
	}
}
