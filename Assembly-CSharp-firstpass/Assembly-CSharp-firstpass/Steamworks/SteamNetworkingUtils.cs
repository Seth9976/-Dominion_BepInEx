using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000165 RID: 357
	public static class SteamNetworkingUtils : Object
	{
		// Token: 0x06001BCE RID: 7118 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingUtils()
		{
			Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr);
			SteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667104);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667105);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667106);
			SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667107);
			SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667108);
			SteamNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667109);
			SteamNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667110);
			SteamNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667111);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667112);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667113);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667114);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667115);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667116);
			SteamNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667117);
			SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667118);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667119);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667120);
			SteamNetworkingUtils.NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667121);
			SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667122);
			SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667123);
			SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667124);
			SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingUtils>.NativeClassPtr, 100667125);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0007F788 File Offset: 0x0007D988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200927, XrefRangeEnd = 200931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cbAllocateBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0007F7C8 File Offset: 0x0007D9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200931, XrefRangeEnd = 200935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pDetails = ((intPtr4 == 0) ? null : new SteamRelayNetworkStatus_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0007F81C File Offset: 0x0007DA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200935, XrefRangeEnd = 200939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new SteamNetworkPingLocation_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0007F870 File Offset: 0x0007DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200939, XrefRangeEnd = 200943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EstimatePingTimeBetweenTwoLocations(ref SteamNetworkPingLocation_t location1, ref SteamNetworkPingLocation_t location2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(location1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(location2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0007F8C8 File Offset: 0x0007DAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200943, XrefRangeEnd = 200947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(remoteLocation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0007F90C File Offset: 0x0007DB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200947, XrefRangeEnd = 200957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConvertPingLocationToString(ref SteamNetworkPingLocation_t location, out string pszBuf, int cchBufSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(location);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchBufSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0007F96C File Offset: 0x0007DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200957, XrefRangeEnd = 200969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParsePingLocationString(string pszString, out SteamNetworkPingLocation_t result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszString);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new SteamNetworkPingLocation_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0007F9D0 File Offset: 0x0007DBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200969, XrefRangeEnd = 200973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flMaxAgeSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0007FA10 File Offset: 0x0007DC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200973, XrefRangeEnd = 200977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPingToDataCenter(SteamNetworkingPOPID popID, out SteamNetworkingPOPID pViaRelayPoP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref popID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pViaRelayPoP;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007FA5C File Offset: 0x0007DC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200977, XrefRangeEnd = 200981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref popID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0007FA9C File Offset: 0x0007DC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200981, XrefRangeEnd = 200985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPOPCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0007FACC File Offset: 0x0007DCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200985, XrefRangeEnd = 200989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPOPList(out SteamNetworkingPOPID list, int nListSz)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &list;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nListSz;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0007FB18 File Offset: 0x0007DD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200989, XrefRangeEnd = 200993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0007FB48 File Offset: 0x0007DD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200993, XrefRangeEnd = 200997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDebugOutputFunction(ESteamNetworkingSocketsDebugOutputType eDetailLevel, FSteamNetworkingSocketsDebugOutput pfnFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eDetailLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pfnFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0007FB8C File Offset: 0x0007DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200997, XrefRangeEnd = 201001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, ESteamNetworkingConfigDataType eDataType, IntPtr pArg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eDataType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pArg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0007FC04 File Offset: 0x0007DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201001, XrefRangeEnd = 201005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingGetConfigValueResult GetConfigValue(ESteamNetworkingConfigValue eValue, ESteamNetworkingConfigScope eScopeType, IntPtr scopeObj, out ESteamNetworkingConfigDataType pOutDataType, IntPtr pResult, out ulong cbResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eScopeType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scopeObj;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pResult;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cbResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0007FC88 File Offset: 0x0007DE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201005, XrefRangeEnd = 201009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConfigValueInfo(ESteamNetworkingConfigValue eValue, IntPtr pOutName, out ESteamNetworkingConfigDataType pOutDataType, out ESteamNetworkingConfigScope pOutScope, out ESteamNetworkingConfigValue pOutNextValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOutName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutDataType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutScope;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutNextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0007FD00 File Offset: 0x0007DF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201009, XrefRangeEnd = 201013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingConfigValue GetFirstConfigValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0007FD30 File Offset: 0x0007DF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201013, XrefRangeEnd = 201023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SteamNetworkingIPAddr_ToString(ref SteamNetworkingIPAddr addr, out string buf, uint cbBuf, bool bWithPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(addr);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bWithPort;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0007FD9C File Offset: 0x0007DF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201023, XrefRangeEnd = 201035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SteamNetworkingIPAddr_ParseString(out SteamNetworkingIPAddr pAddr, string pszStr)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pAddr = ((intPtr4 == 0) ? null : new SteamNetworkingIPAddr(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0007FE00 File Offset: 0x0007E000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201035, XrefRangeEnd = 201045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SteamNetworkingIdentity_ToString(ref SteamNetworkingIdentity identity, out string buf, uint cbBuf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identity);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0007FE60 File Offset: 0x0007E060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201045, XrefRangeEnd = 201057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SteamNetworkingIdentity_ParseString(out SteamNetworkingIdentity pIdentity, string pszStr)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszStr);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pIdentity = ((intPtr4 == 0) ? null : new SteamNetworkingIdentity(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000BAED File Offset: 0x00009CED
		public SteamNetworkingUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0;

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0;
	}
}
