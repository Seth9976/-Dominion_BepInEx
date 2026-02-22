using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000154 RID: 340
	public static class SteamGameServerNetworkingUtils : Object
	{
		// Token: 0x060019D7 RID: 6615 RVA: 0x00073D60 File Offset: 0x00071F60
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerNetworkingUtils()
		{
			Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerNetworkingUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666635);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666636);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666637);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666638);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666639);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666640);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666641);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666642);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666643);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666644);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666645);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666646);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666647);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666648);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666649);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666650);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666651);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666652);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666653);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666654);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666655);
			SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingUtils>.NativeClassPtr, 100666656);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00073F48 File Offset: 0x00072148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197765, XrefRangeEnd = 197769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr AllocateMessage(int cbAllocateBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cbAllocateBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00073F88 File Offset: 0x00072188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197769, XrefRangeEnd = 197773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability GetRelayNetworkStatus(out SteamRelayNetworkStatus_t pDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pDetails = ((intPtr4 == 0) ? null : new SteamRelayNetworkStatus_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00073FDC File Offset: 0x000721DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197773, XrefRangeEnd = 197777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLocalPingLocation(out SteamNetworkPingLocation_t result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new SteamNetworkPingLocation_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00074030 File Offset: 0x00072230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197777, XrefRangeEnd = 197781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00074088 File Offset: 0x00072288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197781, XrefRangeEnd = 197785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int EstimatePingTimeFromLocalHost(ref SteamNetworkPingLocation_t remoteLocation)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(remoteLocation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000740CC File Offset: 0x000722CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197785, XrefRangeEnd = 197795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0007412C File Offset: 0x0007232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197795, XrefRangeEnd = 197807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new SteamNetworkPingLocation_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00074190 File Offset: 0x00072390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197807, XrefRangeEnd = 197811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckPingDataUpToDate(float flMaxAgeSeconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flMaxAgeSeconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x000741D0 File Offset: 0x000723D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197811, XrefRangeEnd = 197815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0007421C File Offset: 0x0007241C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197815, XrefRangeEnd = 197819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDirectPingToPOP(SteamNetworkingPOPID popID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref popID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0007425C File Offset: 0x0007245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197819, XrefRangeEnd = 197823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPOPCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0007428C File Offset: 0x0007248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197823, XrefRangeEnd = 197827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x000742D8 File Offset: 0x000724D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197827, XrefRangeEnd = 197831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingMicroseconds GetLocalTimestamp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00074308 File Offset: 0x00072508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197831, XrefRangeEnd = 197835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0007434C File Offset: 0x0007254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197835, XrefRangeEnd = 197839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000743C4 File Offset: 0x000725C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197839, XrefRangeEnd = 197843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00074448 File Offset: 0x00072648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197843, XrefRangeEnd = 197847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x000744C0 File Offset: 0x000726C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197847, XrefRangeEnd = 197851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingConfigValue GetFirstConfigValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x000744F0 File Offset: 0x000726F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197851, XrefRangeEnd = 197861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0007455C File Offset: 0x0007275C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197861, XrefRangeEnd = 197873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pAddr = ((intPtr4 == 0) ? null : new SteamNetworkingIPAddr(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x000745C0 File Offset: 0x000727C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197873, XrefRangeEnd = 197883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			buf = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00074620 File Offset: 0x00072820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197883, XrefRangeEnd = 197895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingUtils.NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pIdentity = ((intPtr4 == 0) ? null : new SteamNetworkingIdentity(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0000BA54 File Offset: 0x00009C54
		public SteamGameServerNetworkingUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_AllocateMessage_Public_Static_IntPtr_Int32_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_GetRelayNetworkStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamRelayNetworkStatus_t_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPingLocation_Public_Static_Single_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeBetweenTwoLocations_Public_Static_Int32_byref_SteamNetworkPingLocation_t_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_EstimatePingTimeFromLocalHost_Public_Static_Int32_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_ConvertPingLocationToString_Public_Static_Void_byref_SteamNetworkPingLocation_t_byref_String_Int32_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_ParsePingLocationString_Public_Static_Boolean_String_byref_SteamNetworkPingLocation_t_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_CheckPingDataUpToDate_Public_Static_Boolean_Single_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_GetPingToDataCenter_Public_Static_Int32_SteamNetworkingPOPID_byref_SteamNetworkingPOPID_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectPingToPOP_Public_Static_Int32_SteamNetworkingPOPID_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPCount_Public_Static_Int32_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_GetPOPList_Public_Static_Int32_byref_SteamNetworkingPOPID_Int32_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalTimestamp_Public_Static_SteamNetworkingMicroseconds_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugOutputFunction_Public_Static_Void_ESteamNetworkingSocketsDebugOutputType_FSteamNetworkingSocketsDebugOutput_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigValue_Public_Static_Boolean_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_ESteamNetworkingConfigDataType_IntPtr_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValue_Public_Static_ESteamNetworkingGetConfigValueResult_ESteamNetworkingConfigValue_ESteamNetworkingConfigScope_IntPtr_byref_ESteamNetworkingConfigDataType_IntPtr_byref_UInt64_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigValueInfo_Public_Static_Boolean_ESteamNetworkingConfigValue_IntPtr_byref_ESteamNetworkingConfigDataType_byref_ESteamNetworkingConfigScope_byref_ESteamNetworkingConfigValue_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstConfigValue_Public_Static_ESteamNetworkingConfigValue_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ToString_Public_Static_Void_byref_SteamNetworkingIPAddr_byref_String_UInt32_Boolean_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIPAddr_ParseString_Public_Static_Boolean_byref_SteamNetworkingIPAddr_String_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ToString_Public_Static_Void_byref_SteamNetworkingIdentity_byref_String_UInt32_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_SteamNetworkingIdentity_ParseString_Public_Static_Boolean_byref_SteamNetworkingIdentity_String_0;
	}
}
