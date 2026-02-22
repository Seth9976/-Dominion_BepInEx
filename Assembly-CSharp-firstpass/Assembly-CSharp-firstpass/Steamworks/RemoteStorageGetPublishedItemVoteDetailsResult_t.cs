using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FD RID: 509
	[StructLayout(2)]
	public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x000A66D8 File Offset: 0x000A48D8
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageGetPublishedItemVoteDetailsResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageGetPublishedItemVoteDetailsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr);
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_unPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_unPublishedFileId");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nVotesFor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nVotesFor");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nVotesAgainst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nVotesAgainst");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_nReports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_nReports");
			RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_m_fScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, "m_fScore");
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0000E124 File Offset: 0x0000C324
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageGetPublishedItemVoteDetailsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x000A6794 File Offset: 0x000A4994
		// (set) Token: 0x06002441 RID: 9281 RVA: 0x0000E136 File Offset: 0x0000C336
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageGetPublishedItemVoteDetailsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeFieldInfoPtr_m_unPublishedFileId;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeFieldInfoPtr_m_nVotesFor;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeFieldInfoPtr_m_nVotesAgainst;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeFieldInfoPtr_m_nReports;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeFieldInfoPtr_m_fScore;

		// Token: 0x04001DA3 RID: 7587
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001DA4 RID: 7588
		[FieldOffset(8)]
		public PublishedFileId_t m_unPublishedFileId;

		// Token: 0x04001DA5 RID: 7589
		[FieldOffset(16)]
		public int m_nVotesFor;

		// Token: 0x04001DA6 RID: 7590
		[FieldOffset(20)]
		public int m_nVotesAgainst;

		// Token: 0x04001DA7 RID: 7591
		[FieldOffset(24)]
		public int m_nReports;

		// Token: 0x04001DA8 RID: 7592
		[FieldOffset(28)]
		public float m_fScore;
	}
}
