using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015B RID: 347
	public static class SteamInventory : Object
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00079A40 File Offset: 0x00077C40
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventory()
		{
			Il2CppClassPointerStore<SteamInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr);
			SteamInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666876);
			SteamInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666877);
			SteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666878);
			SteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666879);
			SteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666880);
			SteamInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666881);
			SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666882);
			SteamInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666883);
			SteamInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666884);
			SteamInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666885);
			SteamInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666886);
			SteamInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666887);
			SteamInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666888);
			SteamInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666889);
			SteamInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666890);
			SteamInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666891);
			SteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666892);
			SteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666893);
			SteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666894);
			SteamInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666895);
			SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666896);
			SteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666897);
			SteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666898);
			SteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666899);
			SteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666900);
			SteamInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666901);
			SteamInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666902);
			SteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666903);
			SteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666904);
			SteamInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666905);
			SteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666906);
			SteamInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666907);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666908);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666909);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666910);
			SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666911);
			SteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666912);
			SteamInventory.NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInventory>.NativeClassPtr, 100666913);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00079D68 File Offset: 0x00077F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199498, XrefRangeEnd = 199502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetResultStatus(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00079DA8 File Offset: 0x00077FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199502, XrefRangeEnd = 199506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00079E08 File Offset: 0x00078008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199506, XrefRangeEnd = 199527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x00079E90 File Offset: 0x00078090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199527, XrefRangeEnd = 199531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetResultTimestamp(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00079ED0 File Offset: 0x000780D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199531, XrefRangeEnd = 199535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00079F1C File Offset: 0x0007811C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199535, XrefRangeEnd = 199539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyResult(SteamInventoryResult_t resultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00079F50 File Offset: 0x00078150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199539, XrefRangeEnd = 199543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAllItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00079F90 File Offset: 0x00078190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199543, XrefRangeEnd = 199547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00079FF0 File Offset: 0x000781F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199547, XrefRangeEnd = 199551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0007A050 File Offset: 0x00078250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199551, XrefRangeEnd = 199555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0007A0BC File Offset: 0x000782BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199555, XrefRangeEnd = 199559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0007A12C File Offset: 0x0007832C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199559, XrefRangeEnd = 199563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GrantPromoItems(out SteamInventoryResult_t pResultHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pResultHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x0007A16C File Offset: 0x0007836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199563, XrefRangeEnd = 199567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x0007A1B8 File Offset: 0x000783B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199567, XrefRangeEnd = 199571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0007A218 File Offset: 0x00078418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199571, XrefRangeEnd = 199575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0007A274 File Offset: 0x00078474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199575, XrefRangeEnd = 199579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0007A318 File Offset: 0x00078518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199579, XrefRangeEnd = 199583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0007A380 File Offset: 0x00078580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199583, XrefRangeEnd = 199587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendItemDropHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0007A3A8 File Offset: 0x000785A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199587, XrefRangeEnd = 199591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0007A3F4 File Offset: 0x000785F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199591, XrefRangeEnd = 199595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0007A4A8 File Offset: 0x000786A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199595, XrefRangeEnd = 199599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadItemDefinitions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0007A4D8 File Offset: 0x000786D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199599, XrefRangeEnd = 199609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AED RID: 6893 RVA: 0x0007A528 File Offset: 0x00078728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199609, XrefRangeEnd = 199630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValueBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0007A5A0 File Offset: 0x000787A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199630, XrefRangeEnd = 199638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestEligiblePromoItemDefinitionsIDs(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0007A5E0 File Offset: 0x000787E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199638, XrefRangeEnd = 199642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0007A640 File Offset: 0x00078840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199642, XrefRangeEnd = 199650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0007A6A4 File Offset: 0x000788A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199650, XrefRangeEnd = 199658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0007A6D4 File Offset: 0x000788D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199658, XrefRangeEnd = 199662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumItemsWithPrices()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0007A704 File Offset: 0x00078904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199662, XrefRangeEnd = 199666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0007A778 File Offset: 0x00078978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199666, XrefRangeEnd = 199670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0007A7D4 File Offset: 0x000789D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199670, XrefRangeEnd = 199677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamInventoryUpdateHandle_t StartUpdateProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0007A804 File Offset: 0x00078A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199677, XrefRangeEnd = 199689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0007A864 File Offset: 0x00078A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199689, XrefRangeEnd = 199708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0007A8D4 File Offset: 0x00078AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199708, XrefRangeEnd = 199720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0007A940 File Offset: 0x00078B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199720, XrefRangeEnd = 199732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0007A9AC File Offset: 0x00078BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199732, XrefRangeEnd = 199744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0007AA18 File Offset: 0x00078C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199744, XrefRangeEnd = 199748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0007AA64 File Offset: 0x00078C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199748, XrefRangeEnd = 199760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInventory.NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0000BA93 File Offset: 0x00009C93
		public SteamInventory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeMethodInfoPtr_GetResultStatus_Public_Static_EResult_SteamInventoryResult_t_0;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItems_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDetails_t_byref_UInt32_0;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeMethodInfoPtr_GetResultItemProperty_Public_Static_Boolean_SteamInventoryResult_t_UInt32_String_byref_String_byref_UInt32_0;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeMethodInfoPtr_GetResultTimestamp_Public_Static_UInt32_SteamInventoryResult_t_0;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeMethodInfoPtr_CheckResultSteamID_Public_Static_Boolean_SteamInventoryResult_t_CSteamID_0;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeMethodInfoPtr_DestroyResult_Public_Static_Void_SteamInventoryResult_t_0;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeMethodInfoPtr_GetAllItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsByID_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_SerializeResult_Public_Static_Boolean_SteamInventoryResult_t_Il2CppStructArray_1_Byte_byref_UInt32_0;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeResult_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_Byte_UInt32_Boolean_0;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_GenerateItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_GrantPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeMethodInfoPtr_AddPromoItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_UInt32_0;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeItem_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_0;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr_ExchangeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_TransferItemQuantity_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemInstanceID_t_UInt32_SteamItemInstanceID_t_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_SendItemDropHeartbeat_Public_Static_Void_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_TriggerItemDrop_Public_Static_Boolean_byref_SteamInventoryResult_t_SteamItemDef_t_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Public_Static_Boolean_byref_SteamInventoryResult_t_CSteamID_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_Il2CppStructArray_1_SteamItemInstanceID_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_LoadItemDefinitions_Public_Static_Boolean_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionIDs_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDefinitionProperty_Public_Static_Boolean_SteamItemDef_t_String_byref_String_byref_UInt32_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_RequestEligiblePromoItemDefinitionsIDs_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_GetEligiblePromoItemDefinitionIDs_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_SteamItemDef_t_byref_UInt32_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_StartPurchase_Public_Static_SteamAPICall_t_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt32_UInt32_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_RequestPrices_Public_Static_SteamAPICall_t_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_GetNumItemsWithPrices_Public_Static_UInt32_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_GetItemsWithPrices_Public_Static_Boolean_Il2CppStructArray_1_SteamItemDef_t_Il2CppStructArray_1_UInt64_Il2CppStructArray_1_UInt64_UInt32_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_GetItemPrice_Public_Static_Boolean_SteamItemDef_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_StartUpdateProperties_Public_Static_SteamInventoryUpdateHandle_t_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_String_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Boolean_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Int64_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Public_Static_Boolean_SteamInventoryUpdateHandle_t_SteamItemInstanceID_t_String_Single_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_SubmitUpdateProperties_Public_Static_Boolean_SteamInventoryUpdateHandle_t_byref_SteamInventoryResult_t_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_InspectItem_Public_Static_Boolean_byref_SteamInventoryResult_t_String_0;
	}
}
