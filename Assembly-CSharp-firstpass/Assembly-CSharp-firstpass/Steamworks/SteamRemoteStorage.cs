using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Steamworks
{
	// Token: 0x02000168 RID: 360
	public static class SteamRemoteStorage : Object
	{
		// Token: 0x06001BF7 RID: 7159 RVA: 0x0008034C File Offset: 0x0007E54C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemoteStorage()
		{
			Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamRemoteStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667139);
			SteamRemoteStorage.NativeMethodInfoPtr_FileRead_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667140);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWriteAsync_Public_Static_SteamAPICall_t_String_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667141);
			SteamRemoteStorage.NativeMethodInfoPtr_FileReadAsync_Public_Static_SteamAPICall_t_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667142);
			SteamRemoteStorage.NativeMethodInfoPtr_FileReadAsyncComplete_Public_Static_Boolean_SteamAPICall_t_Il2CppStructArray_1_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667143);
			SteamRemoteStorage.NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667144);
			SteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667145);
			SteamRemoteStorage.NativeMethodInfoPtr_FileShare_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667146);
			SteamRemoteStorage.NativeMethodInfoPtr_SetSyncPlatforms_Public_Static_Boolean_String_ERemoteStoragePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667147);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamOpen_Public_Static_UGCFileWriteStreamHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667148);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamWriteChunk_Public_Static_Boolean_UGCFileWriteStreamHandle_t_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667149);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamClose_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667150);
			SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamCancel_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667151);
			SteamRemoteStorage.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667152);
			SteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667153);
			SteamRemoteStorage.NativeMethodInfoPtr_GetFileSize_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667154);
			SteamRemoteStorage.NativeMethodInfoPtr_GetFileTimestamp_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667155);
			SteamRemoteStorage.NativeMethodInfoPtr_GetSyncPlatforms_Public_Static_ERemoteStoragePlatform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667156);
			SteamRemoteStorage.NativeMethodInfoPtr_GetFileCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667157);
			SteamRemoteStorage.NativeMethodInfoPtr_GetFileNameAndSize_Public_Static_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667158);
			SteamRemoteStorage.NativeMethodInfoPtr_GetQuota_Public_Static_Boolean_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667159);
			SteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForAccount_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667160);
			SteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForApp_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667161);
			SteamRemoteStorage.NativeMethodInfoPtr_SetCloudEnabledForApp_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667162);
			SteamRemoteStorage.NativeMethodInfoPtr_UGCDownload_Public_Static_SteamAPICall_t_UGCHandle_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667163);
			SteamRemoteStorage.NativeMethodInfoPtr_GetUGCDownloadProgress_Public_Static_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667164);
			SteamRemoteStorage.NativeMethodInfoPtr_GetUGCDetails_Public_Static_Boolean_UGCHandle_t_byref_AppId_t_byref_String_byref_Int32_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667165);
			SteamRemoteStorage.NativeMethodInfoPtr_UGCRead_Public_Static_Int32_UGCHandle_t_Il2CppStructArray_1_Byte_Int32_UInt32_EUGCReadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667166);
			SteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667167);
			SteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCHandle_Public_Static_UGCHandle_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667168);
			SteamRemoteStorage.NativeMethodInfoPtr_PublishWorkshopFile_Public_Static_SteamAPICall_t_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_EWorkshopFileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667169);
			SteamRemoteStorage.NativeMethodInfoPtr_CreatePublishedFileUpdateRequest_Public_Static_PublishedFileUpdateHandle_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667170);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667171);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFilePreviewFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667172);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileTitle_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667173);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667174);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileVisibility_Public_Static_Boolean_PublishedFileUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667175);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileTags_Public_Static_Boolean_PublishedFileUpdateHandle_t_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667176);
			SteamRemoteStorage.NativeMethodInfoPtr_CommitPublishedFileUpdate_Public_Static_SteamAPICall_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667177);
			SteamRemoteStorage.NativeMethodInfoPtr_GetPublishedFileDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667178);
			SteamRemoteStorage.NativeMethodInfoPtr_DeletePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667179);
			SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserPublishedFiles_Public_Static_SteamAPICall_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667180);
			SteamRemoteStorage.NativeMethodInfoPtr_SubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667181);
			SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserSubscribedFiles_Public_Static_SteamAPICall_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667182);
			SteamRemoteStorage.NativeMethodInfoPtr_UnsubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667183);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileSetChangeDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667184);
			SteamRemoteStorage.NativeMethodInfoPtr_GetPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667185);
			SteamRemoteStorage.NativeMethodInfoPtr_UpdateUserPublishedItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667186);
			SteamRemoteStorage.NativeMethodInfoPtr_GetUserPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667187);
			SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserSharedWorkshopFiles_Public_Static_SteamAPICall_t_CSteamID_UInt32_IList_1_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667188);
			SteamRemoteStorage.NativeMethodInfoPtr_PublishVideo_Public_Static_SteamAPICall_t_EWorkshopVideoProvider_String_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667189);
			SteamRemoteStorage.NativeMethodInfoPtr_SetUserPublishedFileAction_Public_Static_SteamAPICall_t_PublishedFileId_t_EWorkshopFileAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667190);
			SteamRemoteStorage.NativeMethodInfoPtr_EnumeratePublishedFilesByUserAction_Public_Static_SteamAPICall_t_EWorkshopFileAction_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667191);
			SteamRemoteStorage.NativeMethodInfoPtr_EnumeratePublishedWorkshopFiles_Public_Static_SteamAPICall_t_EWorkshopEnumerationType_UInt32_UInt32_UInt32_IList_1_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667192);
			SteamRemoteStorage.NativeMethodInfoPtr_UGCDownloadToLocation_Public_Static_SteamAPICall_t_UGCHandle_t_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemoteStorage>.NativeClassPtr, 100667193);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x000807C8 File Offset: 0x0007E9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201115, XrefRangeEnd = 201127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileWrite(string pchFile, Il2CppStructArray<byte> pvData, int cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0008082C File Offset: 0x0007EA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201127, XrefRangeEnd = 201139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FileRead(string pchFile, Il2CppStructArray<byte> pvData, int cubDataToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileRead_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00080890 File Offset: 0x0007EA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201139, XrefRangeEnd = 201155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t FileWriteAsync(string pchFile, Il2CppStructArray<byte> pvData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWriteAsync_Public_Static_SteamAPICall_t_String_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x000808F4 File Offset: 0x0007EAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201155, XrefRangeEnd = 201171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t FileReadAsync(string pchFile, uint nOffset, uint cubToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileReadAsync_Public_Static_SteamAPICall_t_String_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00080954 File Offset: 0x0007EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201171, XrefRangeEnd = 201175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileReadAsyncComplete(SteamAPICall_t hReadCall, Il2CppStructArray<byte> pvBuffer, uint cubToRead)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hReadCall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubToRead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileReadAsyncComplete_Public_Static_Boolean_SteamAPICall_t_Il2CppStructArray_1_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x000809B4 File Offset: 0x0007EBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201175, XrefRangeEnd = 201187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileForget(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x000809F8 File Offset: 0x0007EBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201187, XrefRangeEnd = 201199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileDelete(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00080A3C File Offset: 0x0007EC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201199, XrefRangeEnd = 201215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t FileShare(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileShare_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00080A80 File Offset: 0x0007EC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201215, XrefRangeEnd = 201227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eRemoteStoragePlatform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_SetSyncPlatforms_Public_Static_Boolean_String_ERemoteStoragePlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00080AD0 File Offset: 0x0007ECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201227, XrefRangeEnd = 201243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCFileWriteStreamHandle_t FileWriteStreamOpen(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamOpen_Public_Static_UGCFileWriteStreamHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00080B14 File Offset: 0x0007ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201243, XrefRangeEnd = 201247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileWriteStreamWriteChunk(UGCFileWriteStreamHandle_t writeHandle, Il2CppStructArray<byte> pvData, int cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamWriteChunk_Public_Static_Boolean_UGCFileWriteStreamHandle_t_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00080B74 File Offset: 0x0007ED74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201247, XrefRangeEnd = 201251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileWriteStreamClose(UGCFileWriteStreamHandle_t writeHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamClose_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00080BB4 File Offset: 0x0007EDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201251, XrefRangeEnd = 201255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileWriteStreamCancel(UGCFileWriteStreamHandle_t writeHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref writeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileWriteStreamCancel_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00080BF4 File Offset: 0x0007EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201255, XrefRangeEnd = 201267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FileExists(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x00080C38 File Offset: 0x0007EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201267, XrefRangeEnd = 201279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FilePersisted(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00080C7C File Offset: 0x0007EE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201279, XrefRangeEnd = 201291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFileSize(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetFileSize_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00080CC0 File Offset: 0x0007EEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201291, XrefRangeEnd = 201303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetFileTimestamp(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetFileTimestamp_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00080D04 File Offset: 0x0007EF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201303, XrefRangeEnd = 201315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetSyncPlatforms_Public_Static_ERemoteStoragePlatform_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00080D48 File Offset: 0x0007EF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201315, XrefRangeEnd = 201319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFileCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetFileCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00080D78 File Offset: 0x0007EF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201319, XrefRangeEnd = 201324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileNameAndSize(int iFile, out int pnFileSizeInBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFile;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetFileNameAndSize_Public_Static_String_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00080DC0 File Offset: 0x0007EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201324, XrefRangeEnd = 201328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQuota(out ulong pnTotalBytes, out ulong puAvailableBytes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pnTotalBytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &puAvailableBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetQuota_Public_Static_Boolean_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00080E0C File Offset: 0x0007F00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201328, XrefRangeEnd = 201332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCloudEnabledForAccount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForAccount_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00080E3C File Offset: 0x0007F03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201332, XrefRangeEnd = 201336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCloudEnabledForApp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_IsCloudEnabledForApp_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00080E6C File Offset: 0x0007F06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201336, XrefRangeEnd = 201340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCloudEnabledForApp(bool bEnabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_SetCloudEnabledForApp_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00080EA0 File Offset: 0x0007F0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201340, XrefRangeEnd = 201348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UGCDownload(UGCHandle_t hContent, uint unPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UGCDownload_Public_Static_SteamAPICall_t_UGCHandle_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00080EEC File Offset: 0x0007F0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201348, XrefRangeEnd = 201352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUGCDownloadProgress(UGCHandle_t hContent, out int pnBytesDownloaded, out int pnBytesExpected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnBytesExpected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetUGCDownloadProgress_Public_Static_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00080F48 File Offset: 0x0007F148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201352, XrefRangeEnd = 201358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUGCDetails(UGCHandle_t hContent, out AppId_t pnAppID, out string ppchName, out int pnFileSizeInBytes, out CSteamID pSteamIDOwner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnFileSizeInBytes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDOwner;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetUGCDetails_Public_Static_Boolean_UGCHandle_t_byref_AppId_t_byref_String_byref_Int32_byref_CSteamID_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			ppchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00080FCC File Offset: 0x0007F1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201358, XrefRangeEnd = 201362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UGCRead(UGCHandle_t hContent, Il2CppStructArray<byte> pvData, int cubDataToRead, uint cOffset, EUGCReadAction eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubDataToRead;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UGCRead_Public_Static_Int32_UGCHandle_t_Il2CppStructArray_1_Byte_Int32_UInt32_EUGCReadAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00081048 File Offset: 0x0007F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201362, XrefRangeEnd = 201366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCachedUGCCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00081078 File Offset: 0x0007F278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201366, XrefRangeEnd = 201374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UGCHandle_t GetCachedUGCHandle(int iCachedContent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCachedContent;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetCachedUGCHandle_Public_Static_UGCHandle_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000810B8 File Offset: 0x0007F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201374, XrefRangeEnd = 201415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t PublishWorkshopFile(string pchFile, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags, EWorkshopFileType eWorkshopFileType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPreviewFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConsumerAppId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchTitle);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVisibility;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTags);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eWorkshopFileType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_PublishWorkshopFile_Public_Static_SteamAPICall_t_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_EWorkshopFileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00081170 File Offset: 0x0007F370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201415, XrefRangeEnd = 201423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PublishedFileUpdateHandle_t CreatePublishedFileUpdateRequest(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_CreatePublishedFileUpdateRequest_Public_Static_PublishedFileUpdateHandle_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000811B0 File Offset: 0x0007F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201423, XrefRangeEnd = 201435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileFile(PublishedFileUpdateHandle_t updateHandle, string pchFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00081200 File Offset: 0x0007F400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201435, XrefRangeEnd = 201447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFilePreviewFile(PublishedFileUpdateHandle_t updateHandle, string pchPreviewFile)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPreviewFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFilePreviewFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00081250 File Offset: 0x0007F450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201447, XrefRangeEnd = 201459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileTitle(PublishedFileUpdateHandle_t updateHandle, string pchTitle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileTitle_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000812A0 File Offset: 0x0007F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201459, XrefRangeEnd = 201471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileDescription(PublishedFileUpdateHandle_t updateHandle, string pchDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000812F0 File Offset: 0x0007F4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201471, XrefRangeEnd = 201475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileVisibility(PublishedFileUpdateHandle_t updateHandle, ERemoteStoragePublishedFileVisibility eVisibility)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVisibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileVisibility_Public_Static_Boolean_PublishedFileUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0008133C File Offset: 0x0007F53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201475, XrefRangeEnd = 201484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileTags(PublishedFileUpdateHandle_t updateHandle, IList<string> pTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileTags_Public_Static_Boolean_PublishedFileUpdateHandle_t_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0008138C File Offset: 0x0007F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201484, XrefRangeEnd = 201492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CommitPublishedFileUpdate(PublishedFileUpdateHandle_t updateHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_CommitPublishedFileUpdate_Public_Static_SteamAPICall_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000813CC File Offset: 0x0007F5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201492, XrefRangeEnd = 201500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetPublishedFileDetails(PublishedFileId_t unPublishedFileId, uint unMaxSecondsOld)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unMaxSecondsOld;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetPublishedFileDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00081418 File Offset: 0x0007F618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201500, XrefRangeEnd = 201508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DeletePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_DeletePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00081458 File Offset: 0x0007F658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201508, XrefRangeEnd = 201516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumerateUserPublishedFiles(uint unStartIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unStartIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserPublishedFiles_Public_Static_SteamAPICall_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00081498 File Offset: 0x0007F698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201516, XrefRangeEnd = 201524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_SubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000814D8 File Offset: 0x0007F6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201524, XrefRangeEnd = 201532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumerateUserSubscribedFiles(uint unStartIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unStartIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserSubscribedFiles_Public_Static_SteamAPICall_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00081518 File Offset: 0x0007F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201532, XrefRangeEnd = 201540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UnsubscribePublishedFile(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UnsubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00081558 File Offset: 0x0007F758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201540, XrefRangeEnd = 201552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdatePublishedFileSetChangeDescription(PublishedFileUpdateHandle_t updateHandle, string pchChangeDescription)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchChangeDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdatePublishedFileSetChangeDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000815A8 File Offset: 0x0007F7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201552, XrefRangeEnd = 201560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000815E8 File Offset: 0x0007F7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201560, XrefRangeEnd = 201568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UpdateUserPublishedItemVote(PublishedFileId_t unPublishedFileId, bool bVoteUp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bVoteUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UpdateUserPublishedItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00081634 File Offset: 0x0007F834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201568, XrefRangeEnd = 201576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetUserPublishedItemVoteDetails(PublishedFileId_t unPublishedFileId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_GetUserPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00081674 File Offset: 0x0007F874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201576, XrefRangeEnd = 201592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumerateUserSharedWorkshopFiles(CSteamID steamId, uint unStartIndex, IList<string> pRequiredTags, IList<string> pExcludedTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequiredTags);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pExcludedTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_EnumerateUserSharedWorkshopFiles_Public_Static_SteamAPICall_t_CSteamID_UInt32_IList_1_String_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000816E4 File Offset: 0x0007F8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201592, XrefRangeEnd = 201640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t PublishVideo(EWorkshopVideoProvider eVideoProvider, string pchVideoAccount, string pchVideoIdentifier, string pchPreviewFile, AppId_t nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, IList<string> pTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eVideoProvider;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVideoAccount);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVideoIdentifier);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPreviewFile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConsumerAppId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchTitle);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVisibility;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_PublishVideo_Public_Static_SteamAPICall_t_EWorkshopVideoProvider_String_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000817B0 File Offset: 0x0007F9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201640, XrefRangeEnd = 201648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SetUserPublishedFileAction(PublishedFileId_t unPublishedFileId, EWorkshopFileAction eAction)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unPublishedFileId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_SetUserPublishedFileAction_Public_Static_SteamAPICall_t_PublishedFileId_t_EWorkshopFileAction_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000817FC File Offset: 0x0007F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201648, XrefRangeEnd = 201656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, uint unStartIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eAction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unStartIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_EnumeratePublishedFilesByUserAction_Public_Static_SteamAPICall_t_EWorkshopFileAction_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00081848 File Offset: 0x0007FA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201656, XrefRangeEnd = 201672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eEnumerationType, uint unStartIndex, uint unCount, uint unDays, IList<string> pTags, IList<string> pUserTags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eEnumerationType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unStartIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unDays;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pTags);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pUserTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_EnumeratePublishedWorkshopFiles_Public_Static_SteamAPICall_t_EWorkshopEnumerationType_UInt32_UInt32_UInt32_IList_1_String_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000818D8 File Offset: 0x0007FAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201672, XrefRangeEnd = 201688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UGCDownloadToLocation(UGCHandle_t hContent, string pchLocation, uint unPriority)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hContent;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLocation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unPriority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemoteStorage.NativeMethodInfoPtr_UGCDownloadToLocation_Public_Static_SteamAPICall_t_UGCHandle_t_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0000BB08 File Offset: 0x00009D08
		public SteamRemoteStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_FileWrite_Public_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_FileRead_Public_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteAsync_Public_Static_SteamAPICall_t_String_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_FileReadAsync_Public_Static_SteamAPICall_t_String_UInt32_UInt32_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_FileReadAsyncComplete_Public_Static_Boolean_SteamAPICall_t_Il2CppStructArray_1_Byte_UInt32_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_FileForget_Public_Static_Boolean_String_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_FileDelete_Public_Static_Boolean_String_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_FileShare_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_SetSyncPlatforms_Public_Static_Boolean_String_ERemoteStoragePlatform_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamOpen_Public_Static_UGCFileWriteStreamHandle_t_String_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamWriteChunk_Public_Static_Boolean_UGCFileWriteStreamHandle_t_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamClose_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_FileWriteStreamCancel_Public_Static_Boolean_UGCFileWriteStreamHandle_t_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_FilePersisted_Public_Static_Boolean_String_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_GetFileSize_Public_Static_Int32_String_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_GetFileTimestamp_Public_Static_Int64_String_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_GetSyncPlatforms_Public_Static_ERemoteStoragePlatform_String_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_GetFileCount_Public_Static_Int32_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_GetFileNameAndSize_Public_Static_String_Int32_byref_Int32_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_GetQuota_Public_Static_Boolean_byref_UInt64_byref_UInt64_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudEnabledForAccount_Public_Static_Boolean_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_IsCloudEnabledForApp_Public_Static_Boolean_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_SetCloudEnabledForApp_Public_Static_Void_Boolean_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_UGCDownload_Public_Static_SteamAPICall_t_UGCHandle_t_UInt32_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_GetUGCDownloadProgress_Public_Static_Boolean_UGCHandle_t_byref_Int32_byref_Int32_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_GetUGCDetails_Public_Static_Boolean_UGCHandle_t_byref_AppId_t_byref_String_byref_Int32_byref_CSteamID_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_UGCRead_Public_Static_Int32_UGCHandle_t_Il2CppStructArray_1_Byte_Int32_UInt32_EUGCReadAction_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedUGCCount_Public_Static_Int32_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedUGCHandle_Public_Static_UGCHandle_t_Int32_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_PublishWorkshopFile_Public_Static_SteamAPICall_t_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_EWorkshopFileType_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_CreatePublishedFileUpdateRequest_Public_Static_PublishedFileUpdateHandle_t_PublishedFileId_t_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFilePreviewFile_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileTitle_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileVisibility_Public_Static_Boolean_PublishedFileUpdateHandle_t_ERemoteStoragePublishedFileVisibility_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileTags_Public_Static_Boolean_PublishedFileUpdateHandle_t_IList_1_String_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_CommitPublishedFileUpdate_Public_Static_SteamAPICall_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_GetPublishedFileDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_UInt32_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_DeletePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateUserPublishedFiles_Public_Static_SteamAPICall_t_UInt32_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_SubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateUserSubscribedFiles_Public_Static_SteamAPICall_t_UInt32_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribePublishedFile_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePublishedFileSetChangeDescription_Public_Static_Boolean_PublishedFileUpdateHandle_t_String_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_GetPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUserPublishedItemVote_Public_Static_SteamAPICall_t_PublishedFileId_t_Boolean_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_GetUserPublishedItemVoteDetails_Public_Static_SteamAPICall_t_PublishedFileId_t_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateUserSharedWorkshopFiles_Public_Static_SteamAPICall_t_CSteamID_UInt32_IList_1_String_IList_1_String_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_PublishVideo_Public_Static_SteamAPICall_t_EWorkshopVideoProvider_String_String_String_AppId_t_String_String_ERemoteStoragePublishedFileVisibility_IList_1_String_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_SetUserPublishedFileAction_Public_Static_SteamAPICall_t_PublishedFileId_t_EWorkshopFileAction_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_EnumeratePublishedFilesByUserAction_Public_Static_SteamAPICall_t_EWorkshopFileAction_UInt32_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_EnumeratePublishedWorkshopFiles_Public_Static_SteamAPICall_t_EWorkshopEnumerationType_UInt32_UInt32_UInt32_IList_1_String_IList_1_String_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_UGCDownloadToLocation_Public_Static_SteamAPICall_t_UGCHandle_t_String_UInt32_0;
	}
}
