using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F4 RID: 500
	[StructLayout(2)]
	public struct RemoteStorageDeletePublishedFileResult_t
	{
		// Token: 0x060023B3 RID: 9139 RVA: 0x000A5450 File Offset: 0x000A3650
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageDeletePublishedFileResult_t()
		{
			Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageDeletePublishedFileResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr);
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "m_eResult");
			RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, "m_nPublishedFileId");
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0000DB22 File Offset: 0x0000BD22
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageDeletePublishedFileResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x000A54BC File Offset: 0x000A36BC
		// (set) Token: 0x060023B6 RID: 9142 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageDeletePublishedFileResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001D4D RID: 7501
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001D4E RID: 7502
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;
	}
}
