using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001FE RID: 510
	[StructLayout(2)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		// Token: 0x06002442 RID: 9282 RVA: 0x000A67B0 File Offset: 0x000A49B0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishedFileSubscribed_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishedFileSubscribed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr);
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0000E144 File Offset: 0x0000C344
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishedFileSubscribed_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000A681C File Offset: 0x000A4A1C
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x0000E156 File Offset: 0x0000C356
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishedFileSubscribed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001DAC RID: 7596
		[FieldOffset(0)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001DAD RID: 7597
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}
