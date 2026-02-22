using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000203 RID: 515
	public sealed class RemoteStorageEnumerateUserSharedWorkshopFilesResult_t : ValueType
	{
		// Token: 0x06002456 RID: 9302 RVA: 0x000A6A6C File Offset: 0x000A4C6C
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserSharedWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000E1ED File Offset: 0x0000C3ED
		public RemoteStorageEnumerateUserSharedWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSharedWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000A6B00 File Offset: 0x000A4D00
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x0000E1FF File Offset: 0x0000C3FF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000A6B1C File Offset: 0x000A4D1C
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x0000E20D File Offset: 0x0000C40D
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000A6B44 File Offset: 0x000A4D44
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x0000E228 File Offset: 0x0000C428
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000A6B6C File Offset: 0x000A4D6C
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x0000E243 File Offset: 0x0000C443
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000A6B94 File Offset: 0x000A4D94
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x0000E25E File Offset: 0x0000C45E
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSharedWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;
	}
}
