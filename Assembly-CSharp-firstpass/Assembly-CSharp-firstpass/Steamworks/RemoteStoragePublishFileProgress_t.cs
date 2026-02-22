using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000206 RID: 518
	[StructLayout(2)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x06002478 RID: 9336 RVA: 0x000A6E38 File Offset: 0x000A5038
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStoragePublishFileProgress_t()
		{
			Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStoragePublishFileProgress_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr);
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "k_iCallback");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_m_dPercentFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "m_dPercentFile");
			RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_m_bPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, "m_bPreview");
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0000E370 File Offset: 0x0000C570
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStoragePublishFileProgress_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x000A6EA4 File Offset: 0x000A50A4
		// (set) Token: 0x0600247B RID: 9339 RVA: 0x0000E382 File Offset: 0x0000C582
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStoragePublishFileProgress_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeFieldInfoPtr_m_dPercentFile;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeFieldInfoPtr_m_bPreview;

		// Token: 0x04001DDA RID: 7642
		[FieldOffset(0)]
		public double m_dPercentFile;

		// Token: 0x04001DDB RID: 7643
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_bPreview;
	}
}
