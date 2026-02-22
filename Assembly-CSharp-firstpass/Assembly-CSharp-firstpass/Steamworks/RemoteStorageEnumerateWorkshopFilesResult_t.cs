using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FC RID: 508
	public sealed class RemoteStorageEnumerateWorkshopFilesResult_t : ValueType
	{
		// Token: 0x0600242B RID: 9259 RVA: 0x000A64C4 File Offset: 0x000A46C4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateWorkshopFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateWorkshopFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_rgScore");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_nAppId");
			RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr, "m_unStartIndex");
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0000E036 File Offset: 0x0000C236
		public RemoteStorageEnumerateWorkshopFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0000E03F File Offset: 0x0000C23F
		public RemoteStorageEnumerateWorkshopFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateWorkshopFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000A6594 File Offset: 0x000A4794
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x0000E051 File Offset: 0x0000C251
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x000A65B0 File Offset: 0x000A47B0
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x0000E05F File Offset: 0x0000C25F
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06002432 RID: 9266 RVA: 0x000A65D8 File Offset: 0x000A47D8
		// (set) Token: 0x06002433 RID: 9267 RVA: 0x0000E07A File Offset: 0x0000C27A
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x000A6600 File Offset: 0x000A4800
		// (set) Token: 0x06002435 RID: 9269 RVA: 0x0000E095 File Offset: 0x0000C295
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x000A6628 File Offset: 0x000A4828
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000A6658 File Offset: 0x000A4858
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x0000E0CF File Offset: 0x0000C2CF
		public unsafe Il2CppStructArray<float> m_rgScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_rgScore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000A6688 File Offset: 0x000A4888
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x0000E0EE File Offset: 0x0000C2EE
		public unsafe AppId_t m_nAppId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_nAppId)) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000A66B0 File Offset: 0x000A48B0
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x0000E109 File Offset: 0x0000C309
		public unsafe uint m_unStartIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateWorkshopFilesResult_t.NativeFieldInfoPtr_m_unStartIndex)) = value;
			}
		}

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeFieldInfoPtr_m_rgScore;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppId;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeFieldInfoPtr_m_unStartIndex;
	}
}
