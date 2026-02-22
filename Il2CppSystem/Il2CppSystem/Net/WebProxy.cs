using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class WebProxy : Object
	{
		// Token: 0x06000EA7 RID: 3751 RVA: 0x00047670 File Offset: 0x00045870
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxy()
		{
			Il2CppClassPointerStore<WebProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxy>.NativeClassPtr);
			WebProxy.NativeFieldInfoPtr__UseRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_UseRegistry");
			WebProxy.NativeFieldInfoPtr__BypassOnLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassOnLocal");
			WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_EnableAutoproxy");
			WebProxy.NativeFieldInfoPtr__ProxyAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyAddress");
			WebProxy.NativeFieldInfoPtr__BypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_BypassList");
			WebProxy.NativeFieldInfoPtr__Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_Credentials");
			WebProxy.NativeFieldInfoPtr__RegExBypassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_RegExBypassList");
			WebProxy.NativeFieldInfoPtr__ProxyHostAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "_ProxyHostAddresses");
			WebProxy.NativeFieldInfoPtr_m_ScriptEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, "m_ScriptEngine");
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665342);
			WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665343);
			WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665344);
			WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665345);
			WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665346);
			WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665347);
			WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665348);
			WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665349);
			WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665350);
			WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665351);
			WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665352);
			WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665353);
			WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665354);
			WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665355);
			WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665356);
			WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665357);
			WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665358);
			WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665359);
			WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665360);
			WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665361);
			WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665362);
			WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665363);
			WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxy>.NativeClassPtr, 100665364);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00047920 File Offset: 0x00045B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49264, XrefRangeEnd = 49266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0004795C File Offset: 0x00045B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49266, XrefRangeEnd = 49272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(Uri Address, bool BypassOnLocal, Il2CppStringArray BypassList, ICredentials Credentials)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref BypassOnLocal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(BypassList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Credentials);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x000479DC File Offset: 0x00045BDC
		public unsafe virtual ICredentials Credentials
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr3) : null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x00047A1C File Offset: 0x00045C1C
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00047A58 File Offset: 0x00045C58
		public unsafe bool UseDefaultCredentials
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49272, XrefRangeEnd = 49274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49274, XrefRangeEnd = 49279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00047A98 File Offset: 0x00045C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49292, RefRangeEnd = 49293, XrefRangeStart = 49279, XrefRangeEnd = 49292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Uri GetProxy(Uri destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00047AE8 File Offset: 0x00045CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49304, RefRangeEnd = 49306, XrefRangeStart = 49293, XrefRangeEnd = 49304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegExList(bool canThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canThrow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00047B28 File Offset: 0x00045D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49325, RefRangeEnd = 49326, XrefRangeStart = 49306, XrefRangeEnd = 49325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchInBypassList(Uri input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00047B78 File Offset: 0x00045D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49326, XrefRangeEnd = 49337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocal(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00047BC8 File Offset: 0x00045DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49337, XrefRangeEnd = 49344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalInProxyHash(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00047C18 File Offset: 0x00045E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49353, RefRangeEnd = 49354, XrefRangeStart = 49344, XrefRangeEnd = 49353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBypassed(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00047C68 File Offset: 0x00045E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49382, RefRangeEnd = 49383, XrefRangeStart = 49354, XrefRangeEnd = 49382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedManual(Uri host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00047CB8 File Offset: 0x00045EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49383, XrefRangeEnd = 49420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00047D1C File Offset: 0x00045F1C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00047D78 File Offset: 0x00045F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49420, XrefRangeEnd = 49439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WebProxy.NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x00047DDC File Offset: 0x00045FDC
		public unsafe AutoWebProxyScriptEngine ScriptEngine
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr3) : null;
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00047E1C File Offset: 0x0004601C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49444, RefRangeEnd = 49447, XrefRangeStart = 49439, XrefRangeEnd = 49444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy CreateDefaultProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00047E50 File Offset: 0x00046050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49447, XrefRangeEnd = 49448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxy(bool enableAutoproxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enableAutoproxy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00047E98 File Offset: 0x00046098
		[CallerCount(0)]
		public unsafe void UnsafeUpdateFromRegistry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00047ECC File Offset: 0x000460CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49466, RefRangeEnd = 49467, XrefRangeStart = 49448, XrefRangeEnd = 49466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxyAuto(Uri destination, out Uri proxyUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyUri = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00047F3C File Offset: 0x0004613C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49467, XrefRangeEnd = 49472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBypassedAuto(Uri destination, out bool isBypassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isBypassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00047F98 File Offset: 0x00046198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49488, RefRangeEnd = 49491, XrefRangeStart = 49472, XrefRangeEnd = 49488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxies);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFirstOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00047FE8 File Offset: 0x000461E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49491, XrefRangeEnd = 49498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ProxyUri(string proxyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(proxyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxy.NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00007C61 File Offset: 0x00005E61
		public WebProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0004802C File Offset: 0x0004622C
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00007C6A File Offset: 0x00005E6A
		public unsafe bool _UseRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__UseRegistry)) = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00048054 File Offset: 0x00046254
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00007C85 File Offset: 0x00005E85
		public unsafe bool _BypassOnLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassOnLocal)) = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0004807C File Offset: 0x0004627C
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00007CA0 File Offset: 0x00005EA0
		public unsafe bool m_EnableAutoproxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_EnableAutoproxy)) = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x000480A4 File Offset: 0x000462A4
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00007CBB File Offset: 0x00005EBB
		public unsafe Uri _ProxyAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyAddress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x000480D4 File Offset: 0x000462D4
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00007CDA File Offset: 0x00005EDA
		public unsafe ArrayList _BypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__BypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x00048104 File Offset: 0x00046304
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00007CF9 File Offset: 0x00005EF9
		public unsafe ICredentials _Credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__Credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00048134 File Offset: 0x00046334
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00007D18 File Offset: 0x00005F18
		public unsafe Il2CppReferenceArray<Regex> _RegExBypassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Regex>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__RegExBypassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00048164 File Offset: 0x00046364
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00007D37 File Offset: 0x00005F37
		public unsafe Hashtable _ProxyHostAddresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr__ProxyHostAddresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x00048194 File Offset: 0x00046394
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00007D56 File Offset: 0x00005F56
		public unsafe AutoWebProxyScriptEngine m_ScriptEngine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoWebProxyScriptEngine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebProxy.NativeFieldInfoPtr_m_ScriptEngine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr__UseRegistry;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr__BypassOnLocal;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableAutoproxy;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr__ProxyAddress;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr__BypassList;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr__Credentials;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr__RegExBypassList;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeFieldInfoPtr__ProxyHostAddresses;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeFieldInfoPtr_m_ScriptEngine;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Boolean_Il2CppStringArray_ICredentials_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_get_Credentials_Public_Virtual_Final_New_get_ICredentials_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultCredentials_Public_get_Boolean_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDefaultCredentials_Public_set_Void_Boolean_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_GetProxy_Public_Virtual_Final_New_Uri_Uri_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegExList_Private_Void_Boolean_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchInBypassList_Private_Boolean_Uri_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_IsLocal_Private_Boolean_Uri_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalInProxyHash_Private_Boolean_Uri_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassed_Public_Virtual_Final_New_Boolean_Uri_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedManual_Private_Boolean_Uri_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_get_ScriptEngine_Internal_get_AutoWebProxyScriptEngine_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultProxy_Public_Static_IWebProxy_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeUpdateFromRegistry_Internal_Void_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyAuto_Private_Boolean_Uri_byref_Uri_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_IsBypassedAuto_Private_Boolean_Uri_byref_Boolean_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_AreAllBypassed_Private_Static_Boolean_IEnumerable_1_String_Boolean_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_ProxyUri_Private_Static_Uri_String_0;
	}
}
