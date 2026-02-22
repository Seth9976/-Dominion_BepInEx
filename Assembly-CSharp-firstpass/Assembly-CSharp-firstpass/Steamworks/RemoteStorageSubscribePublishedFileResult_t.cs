using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F6 RID: 502
	[StructLayout(2)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		// Token: 0x060023C4 RID: 9156 RVA: 0x000A5630 File Offset: 0x000A3830
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageSubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageSubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0000DBDB File Offset: 0x0000BDDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageSubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000A569C File Offset: 0x000A389C
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x0000DBED File Offset: 0x0000BDED
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageSubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D57 RID: 7511
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001D58 RID: 7512
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
