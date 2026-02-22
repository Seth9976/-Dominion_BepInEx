using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F9 RID: 505
	[StructLayout(2)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x000A58DC File Offset: 0x000A3ADC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUpdatePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUpdatePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
			RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, "m_bUserNeedsToAcceptWorkshopLegalAgreement");
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0000DCD3 File Offset: 0x0000BED3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUpdatePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x000A595C File Offset: 0x000A3B5C
		// (set) Token: 0x060023DE RID: 9182 RVA: 0x0000DCE5 File Offset: 0x0000BEE5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUpdatePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D64 RID: 7524
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeFieldInfoPtr_m_bUserNeedsToAcceptWorkshopLegalAgreement;

		// Token: 0x04001D68 RID: 7528
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001D69 RID: 7529
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001D6A RID: 7530
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
