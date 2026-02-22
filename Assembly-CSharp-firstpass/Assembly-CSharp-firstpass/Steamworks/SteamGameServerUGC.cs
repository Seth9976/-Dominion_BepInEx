using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x02000156 RID: 342
	public static class SteamGameServerUGC : Object
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x00074AE8 File Offset: 0x00072CE8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerUGC()
		{
			Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerUGC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr);
			SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666667);
			SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666668);
			SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666669);
			SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666670);
			SteamGameServerUGC.NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666671);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666672);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666673);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666674);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666675);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666676);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666677);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666678);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666679);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666680);
			SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666681);
			SteamGameServerUGC.NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666682);
			SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666683);
			SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666684);
			SteamGameServerUGC.NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666685);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666686);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666687);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666688);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666689);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666690);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666691);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666692);
			SteamGameServerUGC.NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666693);
			SteamGameServerUGC.NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666694);
			SteamGameServerUGC.NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666695);
			SteamGameServerUGC.NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666696);
			SteamGameServerUGC.NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666697);
			SteamGameServerUGC.NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666698);
			SteamGameServerUGC.NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666699);
			SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666700);
			SteamGameServerUGC.NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666701);
			SteamGameServerUGC.NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666702);
			SteamGameServerUGC.NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666703);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666704);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666705);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666706);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666707);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666708);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666709);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666710);
			SteamGameServerUGC.NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666711);
			SteamGameServerUGC.NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666712);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666713);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666714);
			SteamGameServerUGC.NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666715);
			SteamGameServerUGC.NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666716);
			SteamGameServerUGC.NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666717);
			SteamGameServerUGC.NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666718);
			SteamGameServerUGC.NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666719);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666720);
			SteamGameServerUGC.NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666721);
			SteamGameServerUGC.NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666722);
			SteamGameServerUGC.NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666723);
			SteamGameServerUGC.NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666724);
			SteamGameServerUGC.NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666725);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666726);
			SteamGameServerUGC.NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666727);
			SteamGameServerUGC.NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666728);
			SteamGameServerUGC.NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666729);
			SteamGameServerUGC.NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666730);
			SteamGameServerUGC.NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666731);
			SteamGameServerUGC.NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666732);
			SteamGameServerUGC.NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666733);
			SteamGameServerUGC.NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666734);
			SteamGameServerUGC.NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666735);
			SteamGameServerUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666736);
			SteamGameServerUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666737);
			SteamGameServerUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666738);
			SteamGameServerUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666739);
			SteamGameServerUGC.NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666740);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666741);
			SteamGameServerUGC.NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666742);
			SteamGameServerUGC.NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666743);
			SteamGameServerUGC.NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666744);
			SteamGameServerUGC.NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUGC>.NativeClassPtr, 100666745);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00075144 File Offset: 0x00073344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198007, XrefRangeEnd = 198015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCQueryHandle_t CreateQueryUserUGCRequest(AccountID_t unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unAccountID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eListType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMatchingUGCType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eSortOrder;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCreatorAppID;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConsumerAppID;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000751D8 File Offset: 0x000733D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198015, XrefRangeEnd = 198023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, uint unPage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eQueryType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMatchingeMatchingUGCTypeFileType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCreatorAppID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConsumerAppID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00075250 File Offset: 0x00073450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198023, XrefRangeEnd = 198039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCQueryHandle_t CreateQueryAllUGCRequest(EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, AppId_t nCreatorAppID, AppId_t nConsumerAppID, string pchCursor = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eQueryType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMatchingeMatchingUGCTypeFileType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCreatorAppID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConsumerAppID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchCursor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000752CC File Offset: 0x000734CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198039, XrefRangeEnd = 198047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCQueryHandle_t CreateQueryUGCDetailsRequest(Il2CppStructArray<PublishedFileId_t> pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecPublishedFileID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNumPublishedFileIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0007531C File Offset: 0x0007351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198047, XrefRangeEnd = 198055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0007535C File Offset: 0x0007355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198055, XrefRangeEnd = 198059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCResult(UGCQueryHandle_t handle, uint index, out SteamUGCDetails_t pDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pDetails = ((intPtr4 == 0) ? null : new SteamUGCDetails_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000753CC File Offset: 0x000735CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198059, XrefRangeEnd = 198071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCPreviewURL(UGCQueryHandle_t handle, uint index, out string pchURL, uint cchURLSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchURLSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchURL = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00075440 File Offset: 0x00073640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198071, XrefRangeEnd = 198083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCMetadata(UGCQueryHandle_t handle, uint index, out string pchMetadata, uint cchMetadatasize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchMetadatasize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchMetadata = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000754B4 File Offset: 0x000736B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198083, XrefRangeEnd = 198087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCChildren(UGCQueryHandle_t handle, uint index, Il2CppStructArray<PublishedFileId_t> pvecPublishedFileID, uint cMaxEntries)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvecPublishedFileID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxEntries;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00075520 File Offset: 0x00073720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198087, XrefRangeEnd = 198091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCStatistic(UGCQueryHandle_t handle, uint index, EItemStatistic eStatType, out ulong pStatValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eStatType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pStatValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00075588 File Offset: 0x00073788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198091, XrefRangeEnd = 198095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetQueryUGCNumAdditionalPreviews(UGCQueryHandle_t handle, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000755D4 File Offset: 0x000737D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198095, XrefRangeEnd = 198113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCAdditionalPreview(UGCQueryHandle_t handle, uint index, uint previewIndex, out string pchURLOrVideoID, uint cchURLSize, out string pchOriginalFileName, uint cchOriginalFileNameSize, out EItemPreviewType pPreviewType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previewIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchURLSize;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchOriginalFileNameSize;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPreviewType;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchURLOrVideoID = IL2CPP.Il2CppStringToManaged(intPtr);
			pchOriginalFileName = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00075690 File Offset: 0x00073890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198113, XrefRangeEnd = 198117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetQueryUGCNumKeyValueTags(UGCQueryHandle_t handle, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000756DC File Offset: 0x000738DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198117, XrefRangeEnd = 198135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, uint keyValueTagIndex, out string pchKey, uint cchKeySize, out string pchValue, uint cchValueSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyValueTagIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchKeySize;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchValueSize;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchKey = IL2CPP.Il2CppStringToManaged(intPtr);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00075788 File Offset: 0x00073988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198135, XrefRangeEnd = 198156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQueryUGCKeyValueTag(UGCQueryHandle_t handle, uint index, string pchKey, out string pchValue, uint cchValueSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchValueSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00075810 File Offset: 0x00073A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198156, XrefRangeEnd = 198160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00075850 File Offset: 0x00073A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198160, XrefRangeEnd = 198172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddRequiredTag(UGCQueryHandle_t handle, string pTagName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pTagName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000758A0 File Offset: 0x00073AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198172, XrefRangeEnd = 198181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddRequiredTagGroup(UGCQueryHandle_t handle, IList<string> pTagGroups)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTagGroups);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000758F0 File Offset: 0x00073AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198181, XrefRangeEnd = 198193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddExcludedTag(UGCQueryHandle_t handle, string pTagName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pTagName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00075940 File Offset: 0x00073B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198193, XrefRangeEnd = 198197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnOnlyIDs(UGCQueryHandle_t handle, bool bReturnOnlyIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnOnlyIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0007598C File Offset: 0x00073B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198197, XrefRangeEnd = 198201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnKeyValueTags(UGCQueryHandle_t handle, bool bReturnKeyValueTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnKeyValueTags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000759D8 File Offset: 0x00073BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198201, XrefRangeEnd = 198205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnLongDescription(UGCQueryHandle_t handle, bool bReturnLongDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnLongDescription;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00075A24 File Offset: 0x00073C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198205, XrefRangeEnd = 198209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnMetadata(UGCQueryHandle_t handle, bool bReturnMetadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnMetadata;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00075A70 File Offset: 0x00073C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198209, XrefRangeEnd = 198213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnChildren(UGCQueryHandle_t handle, bool bReturnChildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00075ABC File Offset: 0x00073CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198213, XrefRangeEnd = 198217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnAdditionalPreviews(UGCQueryHandle_t handle, bool bReturnAdditionalPreviews)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnAdditionalPreviews;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00075B08 File Offset: 0x00073D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198217, XrefRangeEnd = 198221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnTotalOnly(UGCQueryHandle_t handle, bool bReturnTotalOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bReturnTotalOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00075B54 File Offset: 0x00073D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198221, XrefRangeEnd = 198225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetReturnPlaytimeStats(UGCQueryHandle_t handle, uint unDays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unDays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00075BA0 File Offset: 0x00073DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198225, XrefRangeEnd = 198237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLanguage(UGCQueryHandle_t handle, string pchLanguage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLanguage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00075BF0 File Offset: 0x00073DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198237, XrefRangeEnd = 198241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetAllowCachedResponse(UGCQueryHandle_t handle, uint unMaxAgeSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMaxAgeSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00075C3C File Offset: 0x00073E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198241, XrefRangeEnd = 198253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCloudFileNameFilter(UGCQueryHandle_t handle, string pMatchCloudFileName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pMatchCloudFileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00075C8C File Offset: 0x00073E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198253, XrefRangeEnd = 198257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetMatchAnyTag(UGCQueryHandle_t handle, bool bMatchAnyTag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bMatchAnyTag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00075CD8 File Offset: 0x00073ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198257, XrefRangeEnd = 198269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetSearchText(UGCQueryHandle_t handle, string pSearchText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pSearchText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00075D28 File Offset: 0x00073F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198269, XrefRangeEnd = 198273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetRankedByTrendDays(UGCQueryHandle_t handle, uint unDays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unDays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00075D74 File Offset: 0x00073F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198273, XrefRangeEnd = 198292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddRequiredKeyValueTag(UGCQueryHandle_t handle, string pKey, string pValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00075DD8 File Offset: 0x00073FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198292, XrefRangeEnd = 198300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestUGCDetails(PublishedFileId_t nPublishedFileID, uint unMaxAgeSeconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMaxAgeSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00075E24 File Offset: 0x00074024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198300, XrefRangeEnd = 198308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CreateItem(AppId_t nConsumerAppId, EWorkshopFileType eFileType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nConsumerAppId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFileType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00075E70 File Offset: 0x00074070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198308, XrefRangeEnd = 198316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCUpdateHandle_t StartItemUpdate(AppId_t nConsumerAppId, PublishedFileId_t nPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nConsumerAppId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00075EBC File Offset: 0x000740BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198316, XrefRangeEnd = 198328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemTitle(UGCUpdateHandle_t handle, string pchTitle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00075F0C File Offset: 0x0007410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198328, XrefRangeEnd = 198340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemDescription(UGCUpdateHandle_t handle, string pchDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00075F5C File Offset: 0x0007415C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198340, XrefRangeEnd = 198352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemUpdateLanguage(UGCUpdateHandle_t handle, string pchLanguage)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLanguage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00075FAC File Offset: 0x000741AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198352, XrefRangeEnd = 198364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemMetadata(UGCUpdateHandle_t handle, string pchMetaData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMetaData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00075FFC File Offset: 0x000741FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198364, XrefRangeEnd = 198368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemVisibility(UGCUpdateHandle_t handle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVisibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00076048 File Offset: 0x00074248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198368, XrefRangeEnd = 198377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemTags(UGCUpdateHandle_t updateHandle, IList<string> pTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00076098 File Offset: 0x00074298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198377, XrefRangeEnd = 198389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemContent(UGCUpdateHandle_t handle, string pszContentFolder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszContentFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000760E8 File Offset: 0x000742E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198389, XrefRangeEnd = 198401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetItemPreview(UGCUpdateHandle_t handle, string pszPreviewFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszPreviewFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00076138 File Offset: 0x00074338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198401, XrefRangeEnd = 198405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetAllowLegacyUpload(UGCUpdateHandle_t handle, bool bAllowLegacyUpload)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowLegacyUpload;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00076184 File Offset: 0x00074384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198405, XrefRangeEnd = 198409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000761C4 File Offset: 0x000743C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198409, XrefRangeEnd = 198421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveItemKeyValueTags(UGCUpdateHandle_t handle, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00076214 File Offset: 0x00074414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198421, XrefRangeEnd = 198440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddItemKeyValueTag(UGCUpdateHandle_t handle, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00076278 File Offset: 0x00074478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198440, XrefRangeEnd = 198452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddItemPreviewFile(UGCUpdateHandle_t handle, string pszPreviewFile, EItemPreviewType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszPreviewFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000762D8 File Offset: 0x000744D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198452, XrefRangeEnd = 198464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddItemPreviewVideo(UGCUpdateHandle_t handle, string pszVideoID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszVideoID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00076328 File Offset: 0x00074528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198464, XrefRangeEnd = 198476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateItemPreviewFile(UGCUpdateHandle_t handle, uint index, string pszPreviewFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszPreviewFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00076388 File Offset: 0x00074588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198476, XrefRangeEnd = 198488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateItemPreviewVideo(UGCUpdateHandle_t handle, uint index, string pszVideoID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszVideoID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000763E8 File Offset: 0x000745E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198488, XrefRangeEnd = 198492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveItemPreview(UGCUpdateHandle_t handle, uint index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00076434 File Offset: 0x00074634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198492, XrefRangeEnd = 198508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SubmitItemUpdate(UGCUpdateHandle_t handle, string pchChangeNote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchChangeNote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00076484 File Offset: 0x00074684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198508, XrefRangeEnd = 198512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EItemUpdateStatus GetItemUpdateProgress(UGCUpdateHandle_t handle, out ulong punBytesProcessed, out ulong punBytesTotal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesProcessed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000764E0 File Offset: 0x000746E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198512, XrefRangeEnd = 198520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SetUserItemVote(PublishedFileId_t nPublishedFileID, bool bVoteUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bVoteUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0007652C File Offset: 0x0007472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198520, XrefRangeEnd = 198528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0007656C File Offset: 0x0007476C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198528, XrefRangeEnd = 198536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t AddItemToFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000765B8 File Offset: 0x000747B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198536, XrefRangeEnd = 198544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RemoveItemFromFavorites(AppId_t nAppId, PublishedFileId_t nPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00076604 File Offset: 0x00074804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198544, XrefRangeEnd = 198552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00076644 File Offset: 0x00074844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198552, XrefRangeEnd = 198560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00076684 File Offset: 0x00074884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198560, XrefRangeEnd = 198564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumSubscribedItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000766B4 File Offset: 0x000748B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198564, XrefRangeEnd = 198568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSubscribedItems(Il2CppStructArray<PublishedFileId_t> pvecPublishedFileID, uint cMaxEntries)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecPublishedFileID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxEntries;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00076704 File Offset: 0x00074904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198568, XrefRangeEnd = 198572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00076744 File Offset: 0x00074944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198572, XrefRangeEnd = 198584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemInstallInfo(PublishedFileId_t nPublishedFileID, out ulong punSizeOnDisk, out string pchFolder, uint cchFolderSize, out uint punTimeStamp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punSizeOnDisk;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchFolderSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punTimeStamp;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchFolder = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000767C8 File Offset: 0x000749C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198584, XrefRangeEnd = 198588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetItemDownloadInfo(PublishedFileId_t nPublishedFileID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00076824 File Offset: 0x00074A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198588, XrefRangeEnd = 198592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DownloadItem(PublishedFileId_t nPublishedFileID, bool bHighPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bHighPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00076870 File Offset: 0x00074A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198592, XrefRangeEnd = 198604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BInitWorkshopForGameServer(DepotId_t unWorkshopDepotID, string pszFolder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unWorkshopDepotID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000768C0 File Offset: 0x00074AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198604, XrefRangeEnd = 198608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuspendDownloads(bool bSuspend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bSuspend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000768F4 File Offset: 0x00074AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198608, XrefRangeEnd = 198616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StartPlaytimeTracking(Il2CppStructArray<PublishedFileId_t> pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecPublishedFileID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNumPublishedFileIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00076944 File Offset: 0x00074B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198616, XrefRangeEnd = 198624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StopPlaytimeTracking(Il2CppStructArray<PublishedFileId_t> pvecPublishedFileID, uint unNumPublishedFileIDs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pvecPublishedFileID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNumPublishedFileIDs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00076994 File Offset: 0x00074B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198624, XrefRangeEnd = 198632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x000769C4 File Offset: 0x00074BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198632, XrefRangeEnd = 198640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t AddDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nParentPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChildPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00076A10 File Offset: 0x00074C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198640, XrefRangeEnd = 198648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RemoveDependency(PublishedFileId_t nParentPublishedFileID, PublishedFileId_t nChildPublishedFileID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nParentPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChildPublishedFileID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00076A5C File Offset: 0x00074C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198648, XrefRangeEnd = 198656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t AddAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00076AA8 File Offset: 0x00074CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198656, XrefRangeEnd = 198664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RemoveAppDependency(PublishedFileId_t nPublishedFileID, AppId_t nAppID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nAppID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00076AF4 File Offset: 0x00074CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198664, XrefRangeEnd = 198672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00076B34 File Offset: 0x00074D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198672, XrefRangeEnd = 198680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUGC.NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0000BA66 File Offset: 0x00009C66
		public SteamGameServerUGC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;
	}
}
