using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F0 RID: 496
	public sealed class RemoteStorageAppSyncProgress_t : ValueType
	{
		// Token: 0x0600238D RID: 9101 RVA: 0x000A4F24 File Offset: 0x000A3124
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncProgress_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncProgress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr);
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_rgchCurrentFile_");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_uBytesTransferredThisChunk");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_dAppPercentComplete");
			RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, "m_bUploading");
			RemoteStorageAppSyncProgress_t.NativeMethodInfoPtr_get_m_rgchCurrentFile_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, 100668351);
			RemoteStorageAppSyncProgress_t.NativeMethodInfoPtr_set_m_rgchCurrentFile_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr, 100668352);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x000A4FF4 File Offset: 0x000A31F4
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x000A5030 File Offset: 0x000A3230
		public unsafe string m_rgchCurrentFile
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageAppSyncProgress_t.NativeMethodInfoPtr_get_m_rgchCurrentFile_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206872, XrefRangeEnd = 206873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteStorageAppSyncProgress_t.NativeMethodInfoPtr_set_m_rgchCurrentFile_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
		public RemoteStorageAppSyncProgress_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0000D9B9 File Offset: 0x0000BBB9
		public RemoteStorageAppSyncProgress_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageAppSyncProgress_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x000A5078 File Offset: 0x000A3278
		// (set) Token: 0x06002393 RID: 9107 RVA: 0x0000D9CB File Offset: 0x0000BBCB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06002394 RID: 9108 RVA: 0x000A5094 File Offset: 0x000A3294
		// (set) Token: 0x06002395 RID: 9109 RVA: 0x0000D9D9 File Offset: 0x0000BBD9
		public unsafe Il2CppStructArray<byte> m_rgchCurrentFile_
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile_);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_rgchCurrentFile_), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x000A50C4 File Offset: 0x000A32C4
		// (set) Token: 0x06002397 RID: 9111 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public unsafe AppId_t m_nAppID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_nAppID)) = value;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000A50EC File Offset: 0x000A32EC
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x0000DA13 File Offset: 0x0000BC13
		public unsafe uint m_uBytesTransferredThisChunk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_uBytesTransferredThisChunk)) = value;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600239A RID: 9114 RVA: 0x000A5114 File Offset: 0x000A3314
		// (set) Token: 0x0600239B RID: 9115 RVA: 0x0000DA2E File Offset: 0x0000BC2E
		public unsafe double m_dAppPercentComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_dAppPercentComplete)) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600239C RID: 9116 RVA: 0x000A513C File Offset: 0x000A333C
		// (set) Token: 0x0600239D RID: 9117 RVA: 0x0000DA49 File Offset: 0x0000BC49
		public unsafe bool m_bUploading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageAppSyncProgress_t.NativeFieldInfoPtr_m_bUploading)) = value;
			}
		}

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeFieldInfoPtr_m_rgchCurrentFile_;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeFieldInfoPtr_m_uBytesTransferredThisChunk;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeFieldInfoPtr_m_dAppPercentComplete;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeFieldInfoPtr_m_bUploading;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_get_m_rgchCurrentFile_Public_get_String_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_set_m_rgchCurrentFile_Public_set_Void_String_0;
	}
}
