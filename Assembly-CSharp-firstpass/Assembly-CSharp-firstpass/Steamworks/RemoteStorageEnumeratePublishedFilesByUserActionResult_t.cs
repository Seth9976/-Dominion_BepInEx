using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000205 RID: 517
	public sealed class RemoteStorageEnumeratePublishedFilesByUserActionResult_t : ValueType
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x000A6C60 File Offset: 0x000A4E60
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumeratePublishedFilesByUserActionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr);
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_eAction");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr, "m_rgRTimeUpdated");
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0000E29D File Offset: 0x0000C49D
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		public RemoteStorageEnumeratePublishedFilesByUserActionResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumeratePublishedFilesByUserActionResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000A6D1C File Offset: 0x000A4F1C
		// (set) Token: 0x0600246B RID: 9323 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x000A6D38 File Offset: 0x000A4F38
		// (set) Token: 0x0600246D RID: 9325 RVA: 0x0000E2C6 File Offset: 0x0000C4C6
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x000A6D60 File Offset: 0x000A4F60
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x0000E2E1 File Offset: 0x0000C4E1
		public unsafe EWorkshopFileAction m_eAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_eAction)) = value;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000A6D88 File Offset: 0x000A4F88
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000A6DB0 File Offset: 0x000A4FB0
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x0000E317 File Offset: 0x0000C517
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000A6DD8 File Offset: 0x000A4FD8
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0000E332 File Offset: 0x0000C532
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06002476 RID: 9334 RVA: 0x000A6E08 File Offset: 0x000A5008
		// (set) Token: 0x06002477 RID: 9335 RVA: 0x0000E351 File Offset: 0x0000C551
		public unsafe Il2CppStructArray<uint> m_rgRTimeUpdated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumeratePublishedFilesByUserActionResult_t.NativeFieldInfoPtr_m_rgRTimeUpdated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DD0 RID: 7632
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DD1 RID: 7633
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeFieldInfoPtr_m_eAction;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeFieldInfoPtr_m_rgRTimeUpdated;
	}
}
