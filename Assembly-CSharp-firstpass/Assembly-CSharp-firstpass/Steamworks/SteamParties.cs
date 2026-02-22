using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015F RID: 351
	public static class SteamParties : Object
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x0007C628 File Offset: 0x0007A828
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParties()
		{
			Il2CppClassPointerStore<SteamParties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamParties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParties>.NativeClassPtr);
			SteamParties.NativeMethodInfoPtr_GetNumActiveBeacons_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666983);
			SteamParties.NativeMethodInfoPtr_GetBeaconByIndex_Public_Static_PartyBeaconID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666984);
			SteamParties.NativeMethodInfoPtr_GetBeaconDetails_Public_Static_Boolean_PartyBeaconID_t_byref_CSteamID_byref_SteamPartyBeaconLocation_t_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666985);
			SteamParties.NativeMethodInfoPtr_JoinParty_Public_Static_SteamAPICall_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666986);
			SteamParties.NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Public_Static_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666987);
			SteamParties.NativeMethodInfoPtr_GetAvailableBeaconLocations_Public_Static_Boolean_Il2CppStructArray_1_SteamPartyBeaconLocation_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666988);
			SteamParties.NativeMethodInfoPtr_CreateBeacon_Public_Static_SteamAPICall_t_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666989);
			SteamParties.NativeMethodInfoPtr_OnReservationCompleted_Public_Static_Void_PartyBeaconID_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666990);
			SteamParties.NativeMethodInfoPtr_CancelReservation_Public_Static_Void_PartyBeaconID_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666991);
			SteamParties.NativeMethodInfoPtr_ChangeNumOpenSlots_Public_Static_SteamAPICall_t_PartyBeaconID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666992);
			SteamParties.NativeMethodInfoPtr_DestroyBeacon_Public_Static_Boolean_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666993);
			SteamParties.NativeMethodInfoPtr_GetBeaconLocationData_Public_Static_Boolean_SteamPartyBeaconLocation_t_ESteamPartyBeaconLocationData_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamParties>.NativeClassPtr, 100666994);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0007C748 File Offset: 0x0007A948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200289, XrefRangeEnd = 200293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumActiveBeacons()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetNumActiveBeacons_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0007C778 File Offset: 0x0007A978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200293, XrefRangeEnd = 200301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PartyBeaconID_t GetBeaconByIndex(uint unIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetBeaconByIndex_Public_Static_PartyBeaconID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0007C7B8 File Offset: 0x0007A9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200301, XrefRangeEnd = 200313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBeaconDetails(PartyBeaconID_t ulBeaconID, out CSteamID pSteamIDBeaconOwner, out SteamPartyBeaconLocation_t pLocation, out string pchMetadata, int cchMetadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeaconID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDBeaconOwner;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLocation;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchMetadata;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetBeaconDetails_Public_Static_Boolean_PartyBeaconID_t_byref_CSteamID_byref_SteamPartyBeaconLocation_t_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchMetadata = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0007C83C File Offset: 0x0007AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200313, XrefRangeEnd = 200321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t JoinParty(PartyBeaconID_t ulBeaconID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeaconID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_JoinParty_Public_Static_SteamAPICall_t_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0007C87C File Offset: 0x0007AA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200321, XrefRangeEnd = 200325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetNumAvailableBeaconLocations(out uint puNumLocations)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &puNumLocations;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Public_Static_Boolean_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0007C8BC File Offset: 0x0007AABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200325, XrefRangeEnd = 200329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAvailableBeaconLocations(Il2CppStructArray<SteamPartyBeaconLocation_t> pLocationList, uint uMaxNumLocations)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pLocationList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uMaxNumLocations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetAvailableBeaconLocations_Public_Static_Boolean_Il2CppStructArray_1_SteamPartyBeaconLocation_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0007C90C File Offset: 0x0007AB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200329, XrefRangeEnd = 200352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CreateBeacon(uint unOpenSlots, ref SteamPartyBeaconLocation_t pBeaconLocation, string pchConnectString, string pchMetadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unOpenSlots;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBeaconLocation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMetadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_CreateBeacon_Public_Static_SteamAPICall_t_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0007C97C File Offset: 0x0007AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200352, XrefRangeEnd = 200356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnReservationCompleted(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_OnReservationCompleted_Public_Static_Void_PartyBeaconID_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0007C9BC File Offset: 0x0007ABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200356, XrefRangeEnd = 200360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelReservation(PartyBeaconID_t ulBeacon, CSteamID steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_CancelReservation_Public_Static_Void_PartyBeaconID_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x0007C9FC File Offset: 0x0007ABFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200360, XrefRangeEnd = 200368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t ChangeNumOpenSlots(PartyBeaconID_t ulBeacon, uint unOpenSlots)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unOpenSlots;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_ChangeNumOpenSlots_Public_Static_SteamAPICall_t_PartyBeaconID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0007CA48 File Offset: 0x0007AC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200368, XrefRangeEnd = 200372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DestroyBeacon(PartyBeaconID_t ulBeacon)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ulBeacon;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_DestroyBeacon_Public_Static_Boolean_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0007CA88 File Offset: 0x0007AC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200372, XrefRangeEnd = 200384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetBeaconLocationData(SteamPartyBeaconLocation_t BeaconLocation, ESteamPartyBeaconLocationData eData, out string pchDataStringOut, int cchDataStringOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref BeaconLocation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eData;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchDataStringOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamParties.NativeMethodInfoPtr_GetBeaconLocationData_Public_Static_Boolean_SteamPartyBeaconLocation_t_ESteamPartyBeaconLocationData_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchDataStringOut = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0000BAB7 File Offset: 0x00009CB7
		public SteamParties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_GetNumActiveBeacons_Public_Static_UInt32_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconByIndex_Public_Static_PartyBeaconID_t_UInt32_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconDetails_Public_Static_Boolean_PartyBeaconID_t_byref_CSteamID_byref_SteamPartyBeaconLocation_t_byref_String_Int32_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_JoinParty_Public_Static_SteamAPICall_t_PartyBeaconID_t_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_GetNumAvailableBeaconLocations_Public_Static_Boolean_byref_UInt32_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableBeaconLocations_Public_Static_Boolean_Il2CppStructArray_1_SteamPartyBeaconLocation_t_UInt32_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_CreateBeacon_Public_Static_SteamAPICall_t_UInt32_byref_SteamPartyBeaconLocation_t_String_String_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_OnReservationCompleted_Public_Static_Void_PartyBeaconID_t_CSteamID_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_CancelReservation_Public_Static_Void_PartyBeaconID_t_CSteamID_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_ChangeNumOpenSlots_Public_Static_SteamAPICall_t_PartyBeaconID_t_UInt32_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeacon_Public_Static_Boolean_PartyBeaconID_t_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_GetBeaconLocationData_Public_Static_Boolean_SteamPartyBeaconLocation_t_ESteamPartyBeaconLocationData_byref_String_Int32_0;
	}
}
