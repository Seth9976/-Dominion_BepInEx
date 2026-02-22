using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000201 RID: 513
	[StructLayout(2)]
	public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
	{
		// Token: 0x0600244E RID: 9294 RVA: 0x000A6948 File Offset: 0x000A4B48
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdateUserPublishedItemVoteResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUpdateUserPublishedItemVoteResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr);
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdateUserPublishedItemVoteResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000A69B4 File Offset: 0x000A4BB4
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdateUserPublishedItemVoteResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DBB RID: 7611
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001DBC RID: 7612
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
