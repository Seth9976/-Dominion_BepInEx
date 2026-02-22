using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F5 RID: 501
	public sealed class RemoteStorageEnumerateUserPublishedFilesResult_t : ValueType
	{
		// Token: 0x060023B7 RID: 9143 RVA: 0x000A54D8 File Offset: 0x000A36D8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserPublishedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserPublishedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0000DB42 File Offset: 0x0000BD42
		public RemoteStorageEnumerateUserPublishedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0000DB4B File Offset: 0x0000BD4B
		public RemoteStorageEnumerateUserPublishedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserPublishedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x000A556C File Offset: 0x000A376C
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0000DB5D File Offset: 0x0000BD5D
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x000A5588 File Offset: 0x000A3788
		// (set) Token: 0x060023BD RID: 9149 RVA: 0x0000DB6B File Offset: 0x0000BD6B
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x000A55B0 File Offset: 0x000A37B0
		// (set) Token: 0x060023BF RID: 9151 RVA: 0x0000DB86 File Offset: 0x0000BD86
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060023C0 RID: 9152 RVA: 0x000A55D8 File Offset: 0x000A37D8
		// (set) Token: 0x060023C1 RID: 9153 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000A5600 File Offset: 0x000A3800
		// (set) Token: 0x060023C3 RID: 9155 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserPublishedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;
	}
}
