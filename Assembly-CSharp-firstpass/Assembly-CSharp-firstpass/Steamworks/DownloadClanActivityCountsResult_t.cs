using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000183 RID: 387
	[StructLayout(2)]
	public struct DownloadClanActivityCountsResult_t
	{
		// Token: 0x06002121 RID: 8481 RVA: 0x000A048C File Offset: 0x0009E68C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadClanActivityCountsResult_t()
		{
			Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DownloadClanActivityCountsResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr);
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "k_iCallback");
			DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0000BF89 File Offset: 0x0000A189
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DownloadClanActivityCountsResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000A04E4 File Offset: 0x0009E6E4
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000BF9B File Offset: 0x0000A19B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadClanActivityCountsResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001AE0 RID: 6880
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bSuccess;
	}
}
