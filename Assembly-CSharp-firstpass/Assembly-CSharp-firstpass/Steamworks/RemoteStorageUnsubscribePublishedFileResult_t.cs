using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F8 RID: 504
	[StructLayout(2)]
	public struct RemoteStorageUnsubscribePublishedFileResult_t
	{
		// Token: 0x060023D7 RID: 9175 RVA: 0x000A5854 File Offset: 0x000A3A54
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageUnsubscribePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageUnsubscribePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0000DCB3 File Offset: 0x0000BEB3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageUnsubscribePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x000A58C0 File Offset: 0x000A3AC0
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x0000DCC5 File Offset: 0x0000BEC5
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageUnsubscribePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D5F RID: 7519
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D60 RID: 7520
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D61 RID: 7521
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D62 RID: 7522
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001D63 RID: 7523
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
