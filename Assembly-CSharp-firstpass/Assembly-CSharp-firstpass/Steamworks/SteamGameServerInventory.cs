using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000151 RID: 337
	public static class SteamGameServerInventory : Object
	{
		// Token: 0x0600196D RID: 6509 RVA: 0x00071220 File Offset: 0x0006F420
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerInventory()
		{
			Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666535);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666536);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666537);
			SteamGameServerInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666538);
			SteamGameServerInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666539);
			SteamGameServerInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666540);
			SteamGameServerInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666541);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666542);
			SteamGameServerInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666543);
			SteamGameServerInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666544);
			SteamGameServerInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666545);
			SteamGameServerInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666546);
			SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666547);
			SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666548);
			SteamGameServerInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666549);
			SteamGameServerInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666550);
			SteamGameServerInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666551);
			SteamGameServerInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666552);
			SteamGameServerInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666553);
			SteamGameServerInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666554);
			SteamGameServerInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666555);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666556);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666557);
			SteamGameServerInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666558);
			SteamGameServerInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666559);
			SteamGameServerInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666560);
			SteamGameServerInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666561);
			SteamGameServerInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666562);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666563);
			SteamGameServerInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666564);
			SteamGameServerInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666565);
			SteamGameServerInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666566);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666567);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666568);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666569);
			SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666570);
			SteamGameServerInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666571);
			SteamGameServerInventory.NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerInventory>.NativeClassPtr, 100666572);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00071548 File Offset: 0x0006F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197192, XrefRangeEnd = 197196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00071588 File Offset: 0x0006F788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197196, XrefRangeEnd = 197200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetResultItems(SteamInventoryResult_t resultHandle, Il2CppStructArray<SteamItemDetails_t> pOutItemsArray, ref uint punOutItemsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutItemsArray);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutItemsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000715E8 File Offset: 0x0006F7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197200, XrefRangeEnd = 197221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unItemIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00071670 File Offset: 0x0006F870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197221, XrefRangeEnd = 197225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000716B0 File Offset: 0x0006F8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197225, XrefRangeEnd = 197229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckResultSteamID(SteamInventoryResult_t resultHandle, CSteamID steamIDExpected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000716FC File Offset: 0x0006F8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197229, XrefRangeEnd = 197233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00071730 File Offset: 0x0006F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197233, XrefRangeEnd = 197237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00071770 File Offset: 0x0006F970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197237, XrefRangeEnd = 197241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemsByID(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemInstanceID_t> pInstanceIDs, uint unCountInstanceIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pInstanceIDs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCountInstanceIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000717D0 File Offset: 0x0006F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197241, XrefRangeEnd = 197245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SerializeResult(SteamInventoryResult_t resultHandle, Il2CppStructArray<byte> pOutBuffer, out uint punOutBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punOutBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00071830 File Offset: 0x0006FA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197245, XrefRangeEnd = 197249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeserializeResult(out SteamInventoryResult_t pOutResultHandle, Il2CppStructArray<byte> pBuffer, uint unBufferSize, bool bRESERVED_MUST_BE_FALSE = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pOutResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRESERVED_MUST_BE_FALSE;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0007189C File Offset: 0x0006FA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197249, XrefRangeEnd = 197253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GenerateItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayQuantity);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0007190C File Offset: 0x0006FB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197253, XrefRangeEnd = 197257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0007194C File Offset: 0x0006FB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197257, XrefRangeEnd = 197261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddPromoItem(out SteamInventoryResult_t pResultHandle, SteamItemDef_t itemDef)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemDef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00071998 File Offset: 0x0006FB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197261, XrefRangeEnd = 197265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddPromoItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x000719F8 File Offset: 0x0006FBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197265, XrefRangeEnd = 197269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConsumeItem(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemConsume, uint unQuantity)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemConsume;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00071A54 File Offset: 0x0006FC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197269, XrefRangeEnd = 197273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExchangeItems(out SteamInventoryResult_t pResultHandle, Il2CppStructArray<SteamItemDef_t> pArrayGenerate, Il2CppStructArray<uint> punArrayGenerateQuantity, uint unArrayGenerateLength, Il2CppStructArray<SteamItemInstanceID_t> pArrayDestroy, Il2CppStructArray<uint> punArrayDestroyQuantity, uint unArrayDestroyLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGenerate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayGenerateQuantity);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayGenerateLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayDestroy);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayDestroyQuantity);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayDestroyLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00071AF8 File Offset: 0x0006FCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197273, XrefRangeEnd = 197277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TransferItemQuantity(out SteamInventoryResult_t pResultHandle, SteamItemInstanceID_t itemIdSource, uint unQuantity, SteamItemInstanceID_t itemIdDest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdSource;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemIdDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00071B60 File Offset: 0x0006FD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197277, XrefRangeEnd = 197281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendItemDropHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00071B88 File Offset: 0x0006FD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197281, XrefRangeEnd = 197285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TriggerItemDrop(out SteamInventoryResult_t pResultHandle, SteamItemDef_t dropListDefinition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dropListDefinition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00071BD4 File Offset: 0x0006FDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197285, XrefRangeEnd = 197289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TradeItems(out SteamInventoryResult_t pResultHandle, CSteamID steamIDTradePartner, Il2CppStructArray<SteamItemInstanceID_t> pArrayGive, Il2CppStructArray<uint> pArrayGiveQuantity, uint nArrayGiveLength, Il2CppStructArray<SteamItemInstanceID_t> pArrayGet, Il2CppStructArray<uint> pArrayGetQuantity, uint nArrayGetLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDTradePartner;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGive);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGiveQuantity);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGiveLength;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGet);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pArrayGetQuantity);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nArrayGetLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00071C88 File Offset: 0x0006FE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197289, XrefRangeEnd = 197293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadItemDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00071CB8 File Offset: 0x0006FEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197293, XrefRangeEnd = 197303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemDefinitionIDs(Il2CppStructArray<SteamItemDef_t> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pItemDefIDs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00071D08 File Offset: 0x0006FF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197303, XrefRangeEnd = 197324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer, ref uint punValueBufferSizeOut)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punValueBufferSizeOut;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00071D80 File Offset: 0x0006FF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197324, XrefRangeEnd = 197331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00071DC0 File Offset: 0x0006FFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197331, XrefRangeEnd = 197335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEligiblePromoItemDefinitionIDs(CSteamID steamID, Il2CppStructArray<SteamItemDef_t> pItemDefIDs, ref uint punItemDefIDsArraySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pItemDefIDs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punItemDefIDsArraySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00071E20 File Offset: 0x00070020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197335, XrefRangeEnd = 197342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StartPurchase(Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<uint> punArrayQuantity, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(punArrayQuantity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00071E84 File Offset: 0x00070084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197342, XrefRangeEnd = 197349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00071EB4 File Offset: 0x000700B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197349, XrefRangeEnd = 197353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumItemsWithPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00071EE4 File Offset: 0x000700E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197353, XrefRangeEnd = 197357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemsWithPrices(Il2CppStructArray<SteamItemDef_t> pArrayItemDefs, Il2CppStructArray<ulong> pCurrentPrices, Il2CppStructArray<ulong> pBasePrices, uint unArrayLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pArrayItemDefs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pCurrentPrices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pBasePrices);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unArrayLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00071F58 File Offset: 0x00070158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197357, XrefRangeEnd = 197361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pCurrentPrice, out ulong pBasePrice)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDefinition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pCurrentPrice;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pBasePrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00071FB4 File Offset: 0x000701B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197361, XrefRangeEnd = 197369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00071FE4 File Offset: 0x000701E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197369, XrefRangeEnd = 197381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00072044 File Offset: 0x00070244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197381, XrefRangeEnd = 197400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, string pchPropertyValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000720B4 File Offset: 0x000702B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197400, XrefRangeEnd = 197412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, bool bValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00072120 File Offset: 0x00070320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197412, XrefRangeEnd = 197424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, long nValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0007218C File Offset: 0x0007038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197424, XrefRangeEnd = 197436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetProperty(SteamInventoryUpdateHandle_t handle, SteamItemInstanceID_t nItemID, string pchPropertyName, float flValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nItemID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPropertyName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000721F8 File Offset: 0x000703F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197436, XrefRangeEnd = 197440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SubmitUpdateProperties(SteamInventoryUpdateHandle_t handle, out SteamInventoryResult_t pResultHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pResultHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00072244 File Offset: 0x00070444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197440, XrefRangeEnd = 197452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InspectItem(out SteamInventoryResult_t pResultHandle, string pchItemToken)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchItemToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerInventory.NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0000BA39 File Offset: 0x00009C39
		public SteamGameServerInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0;
	}
}
