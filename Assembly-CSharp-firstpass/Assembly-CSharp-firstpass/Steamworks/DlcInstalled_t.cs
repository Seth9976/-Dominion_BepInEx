using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000172 RID: 370
	[StructLayout(2)]
	public struct DlcInstalled_t
	{
		// Token: 0x060020B9 RID: 8377 RVA: 0x0009F670 File Offset: 0x0009D870
		// Note: this type is marked as 'beforefieldinit'.
		static DlcInstalled_t()
		{
			Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DlcInstalled_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr);
			DlcInstalled_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "k_iCallback");
			DlcInstalled_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0000BBB4 File Offset: 0x00009DB4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DlcInstalled_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0009F6C8 File Offset: 0x0009D8C8
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x0000BBC6 File Offset: 0x00009DC6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DlcInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DlcInstalled_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001A7F RID: 6783
		[FieldOffset(0)]
		public AppId_t m_nAppID;
	}
}
