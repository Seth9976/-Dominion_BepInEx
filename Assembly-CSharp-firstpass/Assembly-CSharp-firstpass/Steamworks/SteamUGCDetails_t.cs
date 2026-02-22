using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B0 RID: 688
	public sealed class SteamUGCDetails_t : ValueType
	{
		// Token: 0x0600274A RID: 10058 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUGCDetails_t()
		{
			Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUGCDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr);
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nPublishedFileId");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eResult");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eFileType");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nCreatorAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nConsumerAppID");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchTitle_");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchDescription_");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_ulSteamIDOwner");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeCreated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeUpdated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rtimeAddedToUserList");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_eVisibility");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bBanned");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bAcceptedForUse");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_bTagsTruncated");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchTags_");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_hFile");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_hPreviewFile");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_pchFileName_");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nFileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_nPreviewFileSize");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_rgchURL_");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unVotesUp");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unVotesDown");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_flScore");
			SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, "m_unNumChildren");
			SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668379);
			SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668380);
			SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668381);
			SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668382);
			SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668383);
			SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668384);
			SteamUGCDetails_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668385);
			SteamUGCDetails_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668386);
			SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668387);
			SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr, 100668388);
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000AC3A0 File Offset: 0x000AA5A0
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		public unsafe string m_rgchTitle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000AC424 File Offset: 0x000AA624
		// (set) Token: 0x0600274E RID: 10062 RVA: 0x000AC460 File Offset: 0x000AA660
		public unsafe string m_rgchDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x000AC4E4 File Offset: 0x000AA6E4
		public unsafe string m_rgchTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206888, XrefRangeEnd = 206889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206889, XrefRangeEnd = 206890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AC52C File Offset: 0x000AA72C
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x000AC568 File Offset: 0x000AA768
		public unsafe string m_pchFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x000AC5B0 File Offset: 0x000AA7B0
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		public unsafe string m_rgchURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUGCDetails_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x0000FB14 File Offset: 0x0000DD14
		public SteamUGCDetails_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x0000FB1D File Offset: 0x0000DD1D
		public SteamUGCDetails_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUGCDetails_t>.NativeClassPtr))
		{
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000AC634 File Offset: 0x000AA834
		// (set) Token: 0x06002758 RID: 10072 RVA: 0x0000FB2F File Offset: 0x0000DD2F
		public unsafe PublishedFileId_t m_nPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPublishedFileId)) = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x000AC65C File Offset: 0x000AA85C
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x0000FB4A File Offset: 0x0000DD4A
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x000AC684 File Offset: 0x000AA884
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x0000FB65 File Offset: 0x0000DD65
		public unsafe EWorkshopFileType m_eFileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eFileType)) = value;
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x000AC6AC File Offset: 0x000AA8AC
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x0000FB80 File Offset: 0x0000DD80
		public unsafe AppId_t m_nCreatorAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nCreatorAppID)) = value;
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x000AC6D4 File Offset: 0x000AA8D4
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x0000FB9B File Offset: 0x0000DD9B
		public unsafe AppId_t m_nConsumerAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nConsumerAppID)) = value;
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000AC6FC File Offset: 0x000AA8FC
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x0000FBB6 File Offset: 0x0000DDB6
		public unsafe Il2CppStructArray<byte> m_rgchTitle_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTitle_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000AC72C File Offset: 0x000AA92C
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x0000FBD5 File Offset: 0x0000DDD5
		public unsafe Il2CppStructArray<byte> m_rgchDescription_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchDescription_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000AC75C File Offset: 0x000AA95C
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public unsafe ulong m_ulSteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_ulSteamIDOwner)) = value;
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000AC784 File Offset: 0x000AA984
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x0000FC0F File Offset: 0x0000DE0F
		public unsafe uint m_rtimeCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeCreated)) = value;
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000AC7AC File Offset: 0x000AA9AC
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x0000FC2A File Offset: 0x0000DE2A
		public unsafe uint m_rtimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeUpdated)) = value;
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0000FC45 File Offset: 0x0000DE45
		public unsafe uint m_rtimeAddedToUserList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rtimeAddedToUserList)) = value;
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000AC7FC File Offset: 0x000AA9FC
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0000FC60 File Offset: 0x0000DE60
		public unsafe ERemoteStoragePublishedFileVisibility m_eVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_eVisibility)) = value;
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000AC824 File Offset: 0x000AAA24
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public unsafe bool m_bBanned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bBanned)) = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000AC84C File Offset: 0x000AAA4C
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x0000FC96 File Offset: 0x0000DE96
		public unsafe bool m_bAcceptedForUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bAcceptedForUse)) = value;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000AC874 File Offset: 0x000AAA74
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x0000FCB1 File Offset: 0x0000DEB1
		public unsafe bool m_bTagsTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_bTagsTruncated)) = value;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000AC89C File Offset: 0x000AAA9C
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x0000FCCC File Offset: 0x0000DECC
		public unsafe Il2CppStructArray<byte> m_rgchTags_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchTags_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000AC8CC File Offset: 0x000AAACC
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x0000FCEB File Offset: 0x0000DEEB
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000AC8F4 File Offset: 0x000AAAF4
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x0000FD06 File Offset: 0x0000DF06
		public unsafe UGCHandle_t m_hPreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_hPreviewFile)) = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000AC91C File Offset: 0x000AAB1C
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x0000FD21 File Offset: 0x0000DF21
		public unsafe Il2CppStructArray<byte> m_pchFileName_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_pchFileName_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000AC94C File Offset: 0x000AAB4C
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x0000FD40 File Offset: 0x0000DF40
		public unsafe int m_nFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nFileSize)) = value;
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x000AC974 File Offset: 0x000AAB74
		// (set) Token: 0x06002780 RID: 10112 RVA: 0x0000FD5B File Offset: 0x0000DF5B
		public unsafe int m_nPreviewFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_nPreviewFileSize)) = value;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000AC99C File Offset: 0x000AAB9C
		// (set) Token: 0x06002782 RID: 10114 RVA: 0x0000FD76 File Offset: 0x0000DF76
		public unsafe Il2CppStructArray<byte> m_rgchURL_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_rgchURL_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000AC9CC File Offset: 0x000AABCC
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x0000FD95 File Offset: 0x0000DF95
		public unsafe uint m_unVotesUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesUp)) = value;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000AC9F4 File Offset: 0x000AABF4
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		public unsafe uint m_unVotesDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unVotesDown)) = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000ACA1C File Offset: 0x000AAC1C
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x0000FDCB File Offset: 0x0000DFCB
		public unsafe float m_flScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_flScore)) = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000ACA44 File Offset: 0x000AAC44
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x0000FDE6 File Offset: 0x0000DFE6
		public unsafe uint m_unNumChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUGCDetails_t.NativeFieldInfoPtr_m_unNumChildren)) = value;
			}
		}

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeFieldInfoPtr_m_eFileType;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeFieldInfoPtr_m_nCreatorAppID;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeFieldInfoPtr_m_nConsumerAppID;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTitle_;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchDescription_;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDOwner;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeCreated;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeUpdated;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeAddedToUserList;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeFieldInfoPtr_m_eVisibility;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeFieldInfoPtr_m_bBanned;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr_m_bAcceptedForUse;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr_m_bTagsTruncated;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTags_;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr_m_hPreviewFile;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeFieldInfoPtr_m_pchFileName_;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeFieldInfoPtr_m_nFileSize;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeFieldInfoPtr_m_nPreviewFileSize;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchURL_;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeFieldInfoPtr_m_unVotesUp;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeFieldInfoPtr_m_unVotesDown;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeFieldInfoPtr_m_flScore;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumChildren;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0;
	}
}
