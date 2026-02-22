using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000202 RID: 514
	[StructLayout(2)]
	public struct RemoteStorageUserVoteDetails_t
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x000A69D0 File Offset: 0x000A4BD0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUserVoteDetails_t()
		{
			Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUserVoteDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr);
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_m_eVote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, "m_eVote");
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUserVoteDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x000A6A50 File Offset: 0x000A4C50
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x0000E1D6 File Offset: 0x0000C3D6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUserVoteDetails_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeFieldInfoPtr_m_eVote;

		// Token: 0x04001DC1 RID: 7617
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001DC2 RID: 7618
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DC3 RID: 7619
		[FieldOffset(16)]
		public EWorkshopVote m_eVote;
	}
}
