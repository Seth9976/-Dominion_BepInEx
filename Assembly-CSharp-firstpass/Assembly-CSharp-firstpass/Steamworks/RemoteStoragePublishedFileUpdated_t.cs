using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000207 RID: 519
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUpdated_t
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x000A6EC0 File Offset: 0x000A50C0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUpdated_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr);
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_nAppID");
			RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_m_ulUnused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, "m_ulUnused");
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0000E390 File Offset: 0x0000C590
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000A6F40 File Offset: 0x000A5140
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0000E3A2 File Offset: 0x0000C5A2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeFieldInfoPtr_m_ulUnused;

		// Token: 0x04001DE0 RID: 7648
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DE1 RID: 7649
		[FieldOffset(8)]
		public AppId_t m_nAppID;

		// Token: 0x04001DE2 RID: 7650
		[FieldOffset(16)]
		public ulong m_ulUnused;
	}
}
