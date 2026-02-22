using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F3 RID: 499
	[StructLayout(2)]
	public struct RemoteStoragePublishFileResult_t
	{
		// Token: 0x060023AF RID: 9135 RVA: 0x000A53B4 File Offset: 0x000A35B4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr);
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0000DB02 File Offset: 0x0000BD02
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060023B1 RID: 9137 RVA: 0x000A5434 File Offset: 0x000A3634
		// (set) Token: 0x060023B2 RID: 9138 RVA: 0x0000DB14 File Offset: 0x0000BD14
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001D47 RID: 7495
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001D48 RID: 7496
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001D49 RID: 7497
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
