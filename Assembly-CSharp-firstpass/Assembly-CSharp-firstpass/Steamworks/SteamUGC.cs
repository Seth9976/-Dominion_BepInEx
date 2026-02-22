using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x0200016A RID: 362
	public static class SteamUGC : Object
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x00081CD0 File Offset: 0x0007FED0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGC()
		{
			Il2CppClassPointerStore<SteamUGC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr);
			SteamUGC.NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667203);
			SteamUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667204);
			SteamUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667205);
			SteamUGC.NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667206);
			SteamUGC.NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667207);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667208);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667209);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667210);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667211);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667212);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667213);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667214);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667215);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667216);
			SteamUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667217);
			SteamUGC.NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667218);
			SteamUGC.NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667219);
			SteamUGC.NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667220);
			SteamUGC.NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667221);
			SteamUGC.NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667222);
			SteamUGC.NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667223);
			SteamUGC.NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667224);
			SteamUGC.NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667225);
			SteamUGC.NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667226);
			SteamUGC.NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667227);
			SteamUGC.NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667228);
			SteamUGC.NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667229);
			SteamUGC.NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667230);
			SteamUGC.NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667231);
			SteamUGC.NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667232);
			SteamUGC.NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667233);
			SteamUGC.NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667234);
			SteamUGC.NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667235);
			SteamUGC.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667236);
			SteamUGC.NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667237);
			SteamUGC.NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667238);
			SteamUGC.NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667239);
			SteamUGC.NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667240);
			SteamUGC.NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667241);
			SteamUGC.NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667242);
			SteamUGC.NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667243);
			SteamUGC.NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667244);
			SteamUGC.NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667245);
			SteamUGC.NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667246);
			SteamUGC.NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667247);
			SteamUGC.NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667248);
			SteamUGC.NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667249);
			SteamUGC.NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667250);
			SteamUGC.NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667251);
			SteamUGC.NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667252);
			SteamUGC.NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667253);
			SteamUGC.NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667254);
			SteamUGC.NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667255);
			SteamUGC.NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667256);
			SteamUGC.NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667257);
			SteamUGC.NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667258);
			SteamUGC.NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667259);
			SteamUGC.NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667260);
			SteamUGC.NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667261);
			SteamUGC.NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667262);
			SteamUGC.NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667263);
			SteamUGC.NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667264);
			SteamUGC.NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667265);
			SteamUGC.NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667266);
			SteamUGC.NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667267);
			SteamUGC.NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667268);
			SteamUGC.NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667269);
			SteamUGC.NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667270);
			SteamUGC.NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667271);
			SteamUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667272);
			SteamUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667273);
			SteamUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667274);
			SteamUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667275);
			SteamUGC.NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667276);
			SteamUGC.NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667277);
			SteamUGC.NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667278);
			SteamUGC.NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667279);
			SteamUGC.NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667280);
			SteamUGC.NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGC>.NativeClassPtr, 100667281);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0008232C File Offset: 0x0008052C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201774, XrefRangeEnd = 201782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x000823C0 File Offset: 0x000805C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201782, XrefRangeEnd = 201790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00082438 File Offset: 0x00080638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201790, XrefRangeEnd = 201806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x000824B4 File Offset: 0x000806B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201806, XrefRangeEnd = 201814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00082504 File Offset: 0x00080704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201814, XrefRangeEnd = 201822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SendQueryUGCRequest(UGCQueryHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00082544 File Offset: 0x00080744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201822, XrefRangeEnd = 201826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pDetails = ((intPtr4 == 0) ? null : new SteamUGCDetails_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x000825B4 File Offset: 0x000807B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201826, XrefRangeEnd = 201838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchURL = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00082628 File Offset: 0x00080828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201838, XrefRangeEnd = 201850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchMetadata = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0008269C File Offset: 0x0008089C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201850, XrefRangeEnd = 201854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00082708 File Offset: 0x00080908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201854, XrefRangeEnd = 201858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00082770 File Offset: 0x00080970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201858, XrefRangeEnd = 201862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000827BC File Offset: 0x000809BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201862, XrefRangeEnd = 201880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchURLOrVideoID = IL2CPP.Il2CppStringToManaged(intPtr);
			pchOriginalFileName = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00082878 File Offset: 0x00080A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201880, XrefRangeEnd = 201884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000828C4 File Offset: 0x00080AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201884, XrefRangeEnd = 201902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchKey = IL2CPP.Il2CppStringToManaged(intPtr);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00082970 File Offset: 0x00080B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201902, XrefRangeEnd = 201923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000829F8 File Offset: 0x00080BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201923, XrefRangeEnd = 201927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReleaseQueryUGCRequest(UGCQueryHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00082A38 File Offset: 0x00080C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201927, XrefRangeEnd = 201939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00082A88 File Offset: 0x00080C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201939, XrefRangeEnd = 201948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00082AD8 File Offset: 0x00080CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201948, XrefRangeEnd = 201960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00082B28 File Offset: 0x00080D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201960, XrefRangeEnd = 201964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00082B74 File Offset: 0x00080D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201964, XrefRangeEnd = 201968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00082BC0 File Offset: 0x00080DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201968, XrefRangeEnd = 201972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00082C0C File Offset: 0x00080E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201972, XrefRangeEnd = 201976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00082C58 File Offset: 0x00080E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201976, XrefRangeEnd = 201980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00082CA4 File Offset: 0x00080EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201980, XrefRangeEnd = 201984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00082CF0 File Offset: 0x00080EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201984, XrefRangeEnd = 201988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00082D3C File Offset: 0x00080F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201988, XrefRangeEnd = 201992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00082D88 File Offset: 0x00080F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201992, XrefRangeEnd = 202004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00082DD8 File Offset: 0x00080FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202004, XrefRangeEnd = 202008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x00082E24 File Offset: 0x00081024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202008, XrefRangeEnd = 202020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x00082E74 File Offset: 0x00081074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202020, XrefRangeEnd = 202024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00082EC0 File Offset: 0x000810C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202024, XrefRangeEnd = 202036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00082F10 File Offset: 0x00081110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202036, XrefRangeEnd = 202040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00082F5C File Offset: 0x0008115C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202040, XrefRangeEnd = 202059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x00082FC0 File Offset: 0x000811C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202059, XrefRangeEnd = 202067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0008300C File Offset: 0x0008120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202067, XrefRangeEnd = 202075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00083058 File Offset: 0x00081258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202075, XrefRangeEnd = 202083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000830A4 File Offset: 0x000812A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202083, XrefRangeEnd = 202095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000830F4 File Offset: 0x000812F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202095, XrefRangeEnd = 202107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00083144 File Offset: 0x00081344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202107, XrefRangeEnd = 202119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00083194 File Offset: 0x00081394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202119, XrefRangeEnd = 202131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000831E4 File Offset: 0x000813E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202131, XrefRangeEnd = 202135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00083230 File Offset: 0x00081430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202135, XrefRangeEnd = 202144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00083280 File Offset: 0x00081480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202144, XrefRangeEnd = 202156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000832D0 File Offset: 0x000814D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202156, XrefRangeEnd = 202168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00083320 File Offset: 0x00081520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202168, XrefRangeEnd = 202172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0008336C File Offset: 0x0008156C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202172, XrefRangeEnd = 202176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveAllItemKeyValueTags(UGCUpdateHandle_t handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000833AC File Offset: 0x000815AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202176, XrefRangeEnd = 202188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000833FC File Offset: 0x000815FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202188, XrefRangeEnd = 202207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00083460 File Offset: 0x00081660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202207, XrefRangeEnd = 202219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000834C0 File Offset: 0x000816C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202219, XrefRangeEnd = 202231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00083510 File Offset: 0x00081710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202231, XrefRangeEnd = 202243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x00083570 File Offset: 0x00081770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202243, XrefRangeEnd = 202255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000835D0 File Offset: 0x000817D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202255, XrefRangeEnd = 202259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0008361C File Offset: 0x0008181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202259, XrefRangeEnd = 202275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0008366C File Offset: 0x0008186C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202275, XrefRangeEnd = 202279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000836C8 File Offset: 0x000818C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202279, XrefRangeEnd = 202287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00083714 File Offset: 0x00081914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202287, XrefRangeEnd = 202295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetUserItemVote(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00083754 File Offset: 0x00081954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202295, XrefRangeEnd = 202303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000837A0 File Offset: 0x000819A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202303, XrefRangeEnd = 202311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000837EC File Offset: 0x000819EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202311, XrefRangeEnd = 202319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0008382C File Offset: 0x00081A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202319, XrefRangeEnd = 202327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UnsubscribeItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0008386C File Offset: 0x00081A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202327, XrefRangeEnd = 202331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumSubscribedItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0008389C File Offset: 0x00081A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202331, XrefRangeEnd = 202335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000838EC File Offset: 0x00081AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202335, XrefRangeEnd = 202339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetItemState(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0008392C File Offset: 0x00081B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202339, XrefRangeEnd = 202351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchFolder = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000839B0 File Offset: 0x00081BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202351, XrefRangeEnd = 202355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00083A0C File Offset: 0x00081C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202355, XrefRangeEnd = 202359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00083A58 File Offset: 0x00081C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202359, XrefRangeEnd = 202371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00083AA8 File Offset: 0x00081CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202371, XrefRangeEnd = 202375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuspendDownloads(bool bSuspend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bSuspend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00083ADC File Offset: 0x00081CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202375, XrefRangeEnd = 202383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00083B2C File Offset: 0x00081D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202383, XrefRangeEnd = 202391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00083B7C File Offset: 0x00081D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202391, XrefRangeEnd = 202399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t StopPlaytimeTrackingForAllItems()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00083BAC File Offset: 0x00081DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202399, XrefRangeEnd = 202407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00083BF8 File Offset: 0x00081DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202407, XrefRangeEnd = 202415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00083C44 File Offset: 0x00081E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202415, XrefRangeEnd = 202423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00083C90 File Offset: 0x00081E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202423, XrefRangeEnd = 202431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00083CDC File Offset: 0x00081EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202431, XrefRangeEnd = 202439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetAppDependencies(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00083D1C File Offset: 0x00081F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202439, XrefRangeEnd = 202447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DeleteItem(PublishedFileId_t nPublishedFileID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPublishedFileID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGC.NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0000BB1A File Offset: 0x00009D1A
		public SteamUGC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryUserUGCRequest_Public_Static_UGCQueryHandle_t_AccountID_t_EUserUGCList_EUGCMatchingUGCType_EUserUGCListSortOrder_AppId_t_AppId_t_UInt32_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_UInt32_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryAllUGCRequest_Public_Static_UGCQueryHandle_t_EUGCQuery_EUGCMatchingUGCType_AppId_t_AppId_t_String_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueryUGCDetailsRequest_Public_Static_UGCQueryHandle_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_SendQueryUGCRequest_Public_Static_SteamAPICall_t_UGCQueryHandle_t_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCResult_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_SteamUGCDetails_t_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCPreviewURL_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCMetadata_Public_Static_Boolean_UGCQueryHandle_t_UInt32_byref_String_UInt32_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCChildren_Public_Static_Boolean_UGCQueryHandle_t_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCStatistic_Public_Static_Boolean_UGCQueryHandle_t_UInt32_EItemStatistic_byref_UInt64_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCNumAdditionalPreviews_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCAdditionalPreview_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_byref_EItemPreviewType_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCNumKeyValueTags_Public_Static_UInt32_UGCQueryHandle_t_UInt32_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_UInt32_byref_String_UInt32_byref_String_UInt32_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_GetQueryUGCKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_UInt32_String_byref_String_UInt32_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseQueryUGCRequest_Public_Static_Boolean_UGCQueryHandle_t_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredTag_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredTagGroup_Public_Static_Boolean_UGCQueryHandle_t_IList_1_String_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_AddExcludedTag_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnOnlyIDs_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnKeyValueTags_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnLongDescription_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnMetadata_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnChildren_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnAdditionalPreviews_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnTotalOnly_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr_SetReturnPlaytimeStats_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowCachedResponse_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_SetCloudFileNameFilter_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_SetMatchAnyTag_Public_Static_Boolean_UGCQueryHandle_t_Boolean_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchText_Public_Static_Boolean_UGCQueryHandle_t_String_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_SetRankedByTrendDays_Public_Static_Boolean_UGCQueryHandle_t_UInt32_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr_AddRequiredKeyValueTag_Public_Static_Boolean_UGCQueryHandle_t_String_String_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr_RequestUGCDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Public_Static_SteamAPICall_t_AppId_t_EWorkshopFileType_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_StartItemUpdate_Public_Static_UGCUpdateHandle_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_SetItemTitle_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_SetItemDescription_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_SetItemUpdateLanguage_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_SetItemMetadata_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_SetItemVisibility_Public_Static_Boolean_UGCUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_SetItemTags_Public_Static_Boolean_UGCUpdateHandle_t_IList_1_String_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_SetItemContent_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_SetItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowLegacyUpload_Public_Static_Boolean_UGCUpdateHandle_t_Boolean_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemKeyValueTags_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_AddItemKeyValueTag_Public_Static_Boolean_UGCUpdateHandle_t_String_String_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_AddItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_String_EItemPreviewType_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_AddItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_String_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_UpdateItemPreviewFile_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_UpdateItemPreviewVideo_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_String_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemPreview_Public_Static_Boolean_UGCUpdateHandle_t_UInt32_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_SubmitItemUpdate_Public_Static_SteamAPICall_t_UGCUpdateHandle_t_String_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_GetItemUpdateProgress_Public_Static_EItemUpdateStatus_UGCUpdateHandle_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_SetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_GetUserItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemFromFavorites_Public_Static_SteamAPICall_t_AppId_t_PublishedFileId_t_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_GetNumSubscribedItems_Public_Static_UInt32_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_GetSubscribedItems_Public_Static_UInt32_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_GetItemState_Public_Static_UInt32_PublishedFileId_t_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_GetItemInstallInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_String_UInt32_byref_UInt32_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_GetItemDownloadInfo_Public_Static_Boolean_PublishedFileId_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_DownloadItem_Public_Static_Boolean_PublishedFileId_t_Boolean_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_BInitWorkshopForGameServer_Public_Static_Boolean_DepotId_t_String_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_SuspendDownloads_Public_Static_Void_Boolean_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_StartPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTracking_Public_Static_SteamAPICall_t_Il2CppStructArray_1_PublishedFileId_t_UInt32_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_StopPlaytimeTrackingForAllItems_Public_Static_SteamAPICall_t_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_AddDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_PublishedFileId_t_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_AddAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAppDependency_Public_Static_SteamAPICall_t_PublishedFileId_t_AppId_t_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_GetAppDependencies_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr_DeleteItem_Public_Static_SteamAPICall_t_PublishedFileId_t_0;
	}
}
