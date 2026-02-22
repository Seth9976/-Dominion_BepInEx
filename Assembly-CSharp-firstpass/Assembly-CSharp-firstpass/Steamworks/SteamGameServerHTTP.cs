using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000150 RID: 336
	public static class SteamGameServerHTTP : Object
	{
		// Token: 0x06001952 RID: 6482 RVA: 0x000707DC File Offset: 0x0006E9DC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerHTTP()
		{
			Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerHTTP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr);
			SteamGameServerHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666510);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666511);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666512);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666513);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666514);
			SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666515);
			SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666516);
			SteamGameServerHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666517);
			SteamGameServerHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666518);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666519);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666520);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666521);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666522);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666523);
			SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666524);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666525);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666526);
			SteamGameServerHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666527);
			SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666528);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666529);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666530);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666531);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666532);
			SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666533);
			SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerHTTP>.NativeClassPtr, 100666534);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00070A00 File Offset: 0x0006EC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196992, XrefRangeEnd = 197008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eHTTPRequestMethod;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchAbsoluteURL);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00070A50 File Offset: 0x0006EC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197008, XrefRangeEnd = 197012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ulContextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00070A9C File Offset: 0x0006EC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197012, XrefRangeEnd = 197016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unTimeoutSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00070AE8 File Offset: 0x0006ECE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197016, XrefRangeEnd = 197035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00070B4C File Offset: 0x0006ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197035, XrefRangeEnd = 197054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchParamValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00070BB0 File Offset: 0x0006EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197054, XrefRangeEnd = 197058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00070BFC File Offset: 0x0006EDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197058, XrefRangeEnd = 197062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCallHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00070C48 File Offset: 0x0006EE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197062, XrefRangeEnd = 197066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00070C88 File Offset: 0x0006EE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197066, XrefRangeEnd = 197070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197070, XrefRangeEnd = 197082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unResponseHeaderSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00070D28 File Offset: 0x0006EF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197082, XrefRangeEnd = 197094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, Il2CppStructArray<byte> pHeaderValueBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHeaderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pHeaderValueBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00070D98 File Offset: 0x0006EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197094, XrefRangeEnd = 197098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &unBodySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00070DE4 File Offset: 0x0006EFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197098, XrefRangeEnd = 197102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, Il2CppStructArray<byte> pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBodyDataBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00070E44 File Offset: 0x0006F044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197102, XrefRangeEnd = 197106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, Il2CppStructArray<byte> pBodyDataBuffer, uint unBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBodyDataBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197106, XrefRangeEnd = 197110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00070EF0 File Offset: 0x0006F0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197110, XrefRangeEnd = 197114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercentOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00070F3C File Offset: 0x0006F13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197114, XrefRangeEnd = 197126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, Il2CppStructArray<byte> pubBody, uint unBodyLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchContentType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubBody);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBodyLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00070FAC File Offset: 0x0006F1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197126, XrefRangeEnd = 197134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllowResponsesToModify;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00070FEC File Offset: 0x0006F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197134, XrefRangeEnd = 197138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0007102C File Offset: 0x0006F22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197138, XrefRangeEnd = 197164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUrl);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchCookie);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000710A0 File Offset: 0x0006F2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197164, XrefRangeEnd = 197168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hCookieContainer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000710EC File Offset: 0x0006F2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197168, XrefRangeEnd = 197180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchUserAgentInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0007113C File Offset: 0x0006F33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197180, XrefRangeEnd = 197184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireVerifiedCertificate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x00071188 File Offset: 0x0006F388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197184, XrefRangeEnd = 197188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMilliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000711D4 File Offset: 0x0006F3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197188, XrefRangeEnd = 197192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbWasTimedOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0000BA30 File Offset: 0x00009C30
		public SteamGameServerHTTP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x0400135D RID: 4957
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x0400135E RID: 4958
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x0400135F RID: 4959
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0;

		// Token: 0x04001370 RID: 4976
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0;

		// Token: 0x04001371 RID: 4977
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x04001372 RID: 4978
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0;
	}
}
