using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FF RID: 511
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileUnsubscribed_t
	{
		// Token: 0x06002446 RID: 9286 RVA: 0x000A6838 File Offset: 0x000A4A38
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileUnsubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileUnsubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0000E164 File Offset: 0x0000C364
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileUnsubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000A68A4 File Offset: 0x000A4AA4
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0000E176 File Offset: 0x0000C376
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileUnsubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001DB1 RID: 7601
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DB2 RID: 7602
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
