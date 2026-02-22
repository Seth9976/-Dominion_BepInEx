using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000214 RID: 532
	[StructLayout(2)]
	public struct GetUserItemVoteResult_t
	{
		// Token: 0x060024C4 RID: 9412 RVA: 0x000A7814 File Offset: 0x000A5A14
		// Note: this type is marked as 'beforefieldinit'.
		static GetUserItemVoteResult_t()
		{
			Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetUserItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr);
			GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_eResult");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVotedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVotedUp");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVotedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVotedDown");
			GetUserItemVoteResult_t.NativeFieldInfoPtr_m_bVoteSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, "m_bVoteSkipped");
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0000E66A File Offset: 0x0000C86A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetUserItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060024C6 RID: 9414 RVA: 0x000A78BC File Offset: 0x000A5ABC
		// (set) Token: 0x060024C7 RID: 9415 RVA: 0x0000E67C File Offset: 0x0000C87C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetUserItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeFieldInfoPtr_m_bVotedUp;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeFieldInfoPtr_m_bVotedDown;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeFieldInfoPtr_m_bVoteSkipped;

		// Token: 0x04001E2F RID: 7727
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E30 RID: 7728
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001E31 RID: 7729
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bVotedUp;

		// Token: 0x04001E32 RID: 7730
		[FieldOffset(13)]
		[MarshalAs(4)]
		public bool m_bVotedDown;

		// Token: 0x04001E33 RID: 7731
		[FieldOffset(14)]
		[MarshalAs(4)]
		public bool m_bVoteSkipped;
	}
}
