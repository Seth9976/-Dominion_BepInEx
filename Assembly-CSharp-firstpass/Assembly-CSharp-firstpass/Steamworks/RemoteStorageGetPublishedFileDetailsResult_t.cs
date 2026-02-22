using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FB RID: 507
	public sealed class RemoteStorageGetPublishedFileDetailsResult_t : ValueType
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x000A5BF4 File Offset: 0x000A3DF4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageGetPublishedFileDetailsResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageGetPublishedFileDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nCreatorAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_nCreatorAppID");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nConsumerAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_nConsumerAppID");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTitle_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rgchTitle_");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchDescription_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rgchDescription_");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_hFile");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hPreviewFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_hPreviewFile");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_ulSteamIDOwner");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rtimeCreated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rtimeUpdated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_eVisibility");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_bBanned");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTags_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rgchTags_");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bTagsTruncated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_bTagsTruncated");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_pchFileName_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_pchFileName_");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_nFileSize");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPreviewFileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_nPreviewFileSize");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchURL_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_rgchURL_");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eFileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_eFileType");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bAcceptedForUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, "m_bAcceptedForUse");
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668357);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668358);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668359);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668360);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668361);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668362);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668363);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668364);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668365);
			RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr, 100668366);
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x000A5EA4 File Offset: 0x000A40A4
		// (set) Token: 0x060023F4 RID: 9204 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		public unsafe string m_rgchTitle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206876, XrefRangeEnd = 206877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x000A5F28 File Offset: 0x000A4128
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x000A5F64 File Offset: 0x000A4164
		public unsafe string m_rgchDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206877, XrefRangeEnd = 206878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206878, XrefRangeEnd = 206879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x000A5FAC File Offset: 0x000A41AC
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		public unsafe string m_rgchTags
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206879, XrefRangeEnd = 206880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206880, XrefRangeEnd = 206881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000A6030 File Offset: 0x000A4230
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x000A606C File Offset: 0x000A426C
		public unsafe string m_pchFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206881, XrefRangeEnd = 206882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206882, XrefRangeEnd = 206883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000A60B4 File Offset: 0x000A42B4
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x000A60F0 File Offset: 0x000A42F0
		public unsafe string m_rgchURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206883, XrefRangeEnd = 206884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206884, XrefRangeEnd = 206885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageGetPublishedFileDetailsResult_t.NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
		public RemoteStorageGetPublishedFileDetailsResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0000DDCB File Offset: 0x0000BFCB
		public RemoteStorageGetPublishedFileDetailsResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageGetPublishedFileDetailsResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000A6138 File Offset: 0x000A4338
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000DDDD File Offset: 0x0000BFDD
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000A6154 File Offset: 0x000A4354
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000DDEB File Offset: 0x0000BFEB
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000A617C File Offset: 0x000A437C
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x0000DE06 File Offset: 0x0000C006
		public unsafe PublishedFileId_t m_nPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPublishedFileId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPublishedFileId)) = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000A61A4 File Offset: 0x000A43A4
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0000DE21 File Offset: 0x0000C021
		public unsafe AppId_t m_nCreatorAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nCreatorAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nCreatorAppID)) = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000A61CC File Offset: 0x000A43CC
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public unsafe AppId_t m_nConsumerAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nConsumerAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nConsumerAppID)) = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000A61F4 File Offset: 0x000A43F4
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0000DE57 File Offset: 0x0000C057
		public unsafe Il2CppStructArray<byte> m_rgchTitle_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTitle_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTitle_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000A6224 File Offset: 0x000A4424
		// (set) Token: 0x0600240C RID: 9228 RVA: 0x0000DE76 File Offset: 0x0000C076
		public unsafe Il2CppStructArray<byte> m_rgchDescription_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchDescription_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchDescription_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000A6254 File Offset: 0x000A4454
		// (set) Token: 0x0600240E RID: 9230 RVA: 0x0000DE95 File Offset: 0x0000C095
		public unsafe UGCHandle_t m_hFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hFile)) = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000A627C File Offset: 0x000A447C
		// (set) Token: 0x06002410 RID: 9232 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		public unsafe UGCHandle_t m_hPreviewFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hPreviewFile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_hPreviewFile)) = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000A62A4 File Offset: 0x000A44A4
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0000DECB File Offset: 0x0000C0CB
		public unsafe ulong m_ulSteamIDOwner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_ulSteamIDOwner)) = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x000A62CC File Offset: 0x000A44CC
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0000DEE6 File Offset: 0x0000C0E6
		public unsafe uint m_rtimeCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeCreated)) = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x000A62F4 File Offset: 0x000A44F4
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0000DF01 File Offset: 0x0000C101
		public unsafe uint m_rtimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeUpdated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rtimeUpdated)) = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000A631C File Offset: 0x000A451C
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0000DF1C File Offset: 0x0000C11C
		public unsafe ERemoteStoragePublishedFileVisibility m_eVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eVisibility)) = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000A6344 File Offset: 0x000A4544
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0000DF37 File Offset: 0x0000C137
		public unsafe bool m_bBanned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bBanned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bBanned)) = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000A636C File Offset: 0x000A456C
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0000DF52 File Offset: 0x0000C152
		public unsafe Il2CppStructArray<byte> m_rgchTags_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTags_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchTags_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000A639C File Offset: 0x000A459C
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0000DF71 File Offset: 0x0000C171
		public unsafe bool m_bTagsTruncated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bTagsTruncated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bTagsTruncated)) = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000A63C4 File Offset: 0x000A45C4
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0000DF8C File Offset: 0x0000C18C
		public unsafe Il2CppStructArray<byte> m_pchFileName_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_pchFileName_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_pchFileName_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000A63F4 File Offset: 0x000A45F4
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0000DFAB File Offset: 0x0000C1AB
		public unsafe int m_nFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nFileSize)) = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000A641C File Offset: 0x000A461C
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0000DFC6 File Offset: 0x0000C1C6
		public unsafe int m_nPreviewFileSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPreviewFileSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_nPreviewFileSize)) = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000A6444 File Offset: 0x000A4644
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0000DFE1 File Offset: 0x0000C1E1
		public unsafe Il2CppStructArray<byte> m_rgchURL_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchURL_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_rgchURL_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000A6474 File Offset: 0x000A4674
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0000E000 File Offset: 0x0000C200
		public unsafe EWorkshopFileType m_eFileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eFileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_eFileType)) = value;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000A649C File Offset: 0x000A469C
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0000E01B File Offset: 0x0000C21B
		public unsafe bool m_bAcceptedForUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bAcceptedForUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageGetPublishedFileDetailsResult_t.NativeFieldInfoPtr_m_bAcceptedForUse)) = value;
			}
		}

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeFieldInfoPtr_m_nCreatorAppID;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeFieldInfoPtr_m_nConsumerAppID;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTitle_;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchDescription_;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeFieldInfoPtr_m_hFile;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeFieldInfoPtr_m_hPreviewFile;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDOwner;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeCreated;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeFieldInfoPtr_m_rtimeUpdated;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeFieldInfoPtr_m_eVisibility;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeFieldInfoPtr_m_bBanned;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchTags_;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeFieldInfoPtr_m_bTagsTruncated;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeFieldInfoPtr_m_pchFileName_;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr_m_nFileSize;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeFieldInfoPtr_m_nPreviewFileSize;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchURL_;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeFieldInfoPtr_m_eFileType;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeFieldInfoPtr_m_bAcceptedForUse;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchTitle_Public_get_String_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchTitle_Public_set_Void_String_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchDescription_Public_get_String_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchDescription_Public_set_Void_String_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchTags_Public_get_String_0;

		// Token: 0x04001D8F RID: 7567
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchTags_Public_set_Void_String_0;

		// Token: 0x04001D90 RID: 7568
		private static readonly IntPtr NativeMethodInfoPtr_get_m_pchFileName_Public_get_String_0;

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeMethodInfoPtr_set_m_pchFileName_Public_set_Void_String_0;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchURL_Public_get_String_0;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchURL_Public_set_Void_String_0;
	}
}
