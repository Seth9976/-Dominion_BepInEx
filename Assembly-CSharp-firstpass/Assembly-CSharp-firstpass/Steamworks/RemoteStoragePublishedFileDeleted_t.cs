using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000200 RID: 512
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileDeleted_t
	{
		// Token: 0x0600244A RID: 9290 RVA: 0x000A68C0 File Offset: 0x000A4AC0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileDeleted_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileDeleted_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr);
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0000E184 File Offset: 0x0000C384
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileDeleted_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000A692C File Offset: 0x000A4B2C
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0000E196 File Offset: 0x0000C396
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileDeleted_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001DB6 RID: 7606
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DB7 RID: 7607
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
