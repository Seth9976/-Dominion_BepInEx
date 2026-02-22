using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F7 RID: 503
	public sealed class RemoteStorageEnumerateUserSubscribedFilesResult_t : ValueType
	{
		// Token: 0x060023C8 RID: 9160 RVA: 0x000A56B8 File Offset: 0x000A38B8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageEnumerateUserSubscribedFilesResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageEnumerateUserSubscribedFilesResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr);
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nResultsReturned");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_nTotalResultCount");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgPublishedFileId");
			RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr, "m_rgRTimeSubscribed");
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0000DBFB File Offset: 0x0000BDFB
		public RemoteStorageEnumerateUserSubscribedFilesResult_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0000DC04 File Offset: 0x0000BE04
		public RemoteStorageEnumerateUserSubscribedFilesResult_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoteStorageEnumerateUserSubscribedFilesResult_t>.NativeClassPtr))
		{
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x000A5760 File Offset: 0x000A3960
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x0000DC16 File Offset: 0x0000BE16
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x000A577C File Offset: 0x000A397C
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x0000DC24 File Offset: 0x0000BE24
		public unsafe EResult m_eResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_eResult)) = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x000A57A4 File Offset: 0x000A39A4
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x0000DC3F File Offset: 0x0000BE3F
		public unsafe int m_nResultsReturned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nResultsReturned)) = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000A57CC File Offset: 0x000A39CC
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x0000DC5A File Offset: 0x0000BE5A
		public unsafe int m_nTotalResultCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_nTotalResultCount)) = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x000A57F4 File Offset: 0x000A39F4
		// (set) Token: 0x060023D4 RID: 9172 RVA: 0x0000DC75 File Offset: 0x0000BE75
		public unsafe Il2CppStructArray<PublishedFileId_t> m_rgPublishedFileId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<PublishedFileId_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgPublishedFileId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x000A5824 File Offset: 0x000A3A24
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x0000DC94 File Offset: 0x0000BE94
		public unsafe Il2CppStructArray<uint> m_rgRTimeSubscribed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteStorageEnumerateUserSubscribedFilesResult_t.NativeFieldInfoPtr_m_rgRTimeSubscribed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeFieldInfoPtr_m_nResultsReturned;

		// Token: 0x04001D5C RID: 7516
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalResultCount;

		// Token: 0x04001D5D RID: 7517
		private static readonly IntPtr NativeFieldInfoPtr_m_rgPublishedFileId;

		// Token: 0x04001D5E RID: 7518
		private static readonly IntPtr NativeFieldInfoPtr_m_rgRTimeSubscribed;
	}
}
