using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000211 RID: 529
	[StructLayout(2)]
	public struct DownloadItemResult_t
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x000A7640 File Offset: 0x000A5840
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadItemResult_t()
		{
			Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DownloadItemResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr);
			DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "k_iCallback");
			DownloadItemResult_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_unAppID");
			DownloadItemResult_t.NativeFieldInfoPtr_m_nPublishedFileId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_nPublishedFileId");
			DownloadItemResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0000E60A File Offset: 0x0000C80A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadItemResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000A76C0 File Offset: 0x000A58C0
		// (set) Token: 0x060024BB RID: 9403 RVA: 0x0000E61C File Offset: 0x0000C81C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadItemResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeFieldInfoPtr_m_nPublishedFileId;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E18 RID: 7704
		[FieldOffset(0)]
		public AppId_t m_unAppID;

		// Token: 0x04001E19 RID: 7705
		[FieldOffset(8)]
		public PublishedFileId_t m_nPublishedFileId;

		// Token: 0x04001E1A RID: 7706
		[FieldOffset(16)]
		public EResult m_eResult;
	}
}
