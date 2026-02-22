using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000159 RID: 345
	public static class SteamHTTP : Object
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x0007836C File Offset: 0x0007656C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamHTTP()
		{
			Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamHTTP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr);
			SteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666816);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666817);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666818);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666819);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666820);
			SteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666821);
			SteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666822);
			SteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666823);
			SteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666824);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666825);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666826);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666827);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666828);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666829);
			SteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666830);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666831);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666832);
			SteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666833);
			SteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666834);
			SteamHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666835);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666836);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666837);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666838);
			SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666839);
			SteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamHTTP>.NativeClassPtr, 100666840);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00078590 File Offset: 0x00076790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199113, XrefRangeEnd = 199129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x000785E0 File Offset: 0x000767E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199129, XrefRangeEnd = 199133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0007862C File Offset: 0x0007682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199133, XrefRangeEnd = 199137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x00078678 File Offset: 0x00076878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199137, XrefRangeEnd = 199156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000786DC File Offset: 0x000768DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199156, XrefRangeEnd = 199175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00078740 File Offset: 0x00076940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199175, XrefRangeEnd = 199179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0007878C File Offset: 0x0007698C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199179, XrefRangeEnd = 199183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000787D8 File Offset: 0x000769D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199183, XrefRangeEnd = 199187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00078818 File Offset: 0x00076A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199187, XrefRangeEnd = 199191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00078858 File Offset: 0x00076A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199191, XrefRangeEnd = 199203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x000788B8 File Offset: 0x00076AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199203, XrefRangeEnd = 199215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00078928 File Offset: 0x00076B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199215, XrefRangeEnd = 199219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00078974 File Offset: 0x00076B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199219, XrefRangeEnd = 199223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x000789D4 File Offset: 0x00076BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199223, XrefRangeEnd = 199227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00078A40 File Offset: 0x00076C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199227, XrefRangeEnd = 199231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00078A80 File Offset: 0x00076C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199231, XrefRangeEnd = 199235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00078ACC File Offset: 0x00076CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199235, XrefRangeEnd = 199247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x00078B3C File Offset: 0x00076D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199247, XrefRangeEnd = 199255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAllowResponsesToModify;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00078B7C File Offset: 0x00076D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199255, XrefRangeEnd = 199259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hCookieContainer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00078BBC File Offset: 0x00076DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199259, XrefRangeEnd = 199285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x00078C30 File Offset: 0x00076E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199285, XrefRangeEnd = 199289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAC RID: 6828 RVA: 0x00078C7C File Offset: 0x00076E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199289, XrefRangeEnd = 199301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x00078CCC File Offset: 0x00076ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199301, XrefRangeEnd = 199305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x00078D18 File Offset: 0x00076F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199305, XrefRangeEnd = 199309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00078D64 File Offset: 0x00076F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199309, XrefRangeEnd = 199313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamHTTP.NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x0000BA81 File Offset: 0x00009C81
		public SteamHTTP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeMethodInfoPtr_CreateHTTPRequest_Public_Static_HTTPRequestHandle_EHTTPMethod_String_0;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestContextValue_Public_Static_Boolean_HTTPRequestHandle_UInt64_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestNetworkActivityTimeout_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestGetOrPostParameter_Public_Static_Boolean_HTTPRequestHandle_String_String_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr_SendHTTPRequestAndStreamResponse_Public_Static_Boolean_HTTPRequestHandle_byref_SteamAPICall_t_0;

		// Token: 0x04001493 RID: 5267
		private static readonly IntPtr NativeMethodInfoPtr_DeferHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001494 RID: 5268
		private static readonly IntPtr NativeMethodInfoPtr_PrioritizeHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001495 RID: 5269
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderSize_Public_Static_Boolean_HTTPRequestHandle_String_byref_UInt32_0;

		// Token: 0x04001496 RID: 5270
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseHeaderValue_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04001497 RID: 5271
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodySize_Public_Static_Boolean_HTTPRequestHandle_byref_UInt32_0;

		// Token: 0x04001498 RID: 5272
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x04001499 RID: 5273
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPStreamingResponseBodyData_Public_Static_Boolean_HTTPRequestHandle_UInt32_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400149A RID: 5274
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHTTPRequest_Public_Static_Boolean_HTTPRequestHandle_0;

		// Token: 0x0400149B RID: 5275
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPDownloadProgressPct_Public_Static_Boolean_HTTPRequestHandle_byref_Single_0;

		// Token: 0x0400149C RID: 5276
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRawPostBody_Public_Static_Boolean_HTTPRequestHandle_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x0400149D RID: 5277
		private static readonly IntPtr NativeMethodInfoPtr_CreateCookieContainer_Public_Static_HTTPCookieContainerHandle_Boolean_0;

		// Token: 0x0400149E RID: 5278
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCookieContainer_Public_Static_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x0400149F RID: 5279
		private static readonly IntPtr NativeMethodInfoPtr_SetCookie_Public_Static_Boolean_HTTPCookieContainerHandle_String_String_String_0;

		// Token: 0x040014A0 RID: 5280
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestCookieContainer_Public_Static_Boolean_HTTPRequestHandle_HTTPCookieContainerHandle_0;

		// Token: 0x040014A1 RID: 5281
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestUserAgentInfo_Public_Static_Boolean_HTTPRequestHandle_String_0;

		// Token: 0x040014A2 RID: 5282
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestRequiresVerifiedCertificate_Public_Static_Boolean_HTTPRequestHandle_Boolean_0;

		// Token: 0x040014A3 RID: 5283
		private static readonly IntPtr NativeMethodInfoPtr_SetHTTPRequestAbsoluteTimeoutMS_Public_Static_Boolean_HTTPRequestHandle_UInt32_0;

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_GetHTTPRequestWasTimedOut_Public_Static_Boolean_HTTPRequestHandle_byref_Boolean_0;
	}
}
