using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000222 RID: 546
	[StructLayout(2)]
	public struct LicensesUpdated_t
	{
		// Token: 0x06002507 RID: 9479 RVA: 0x0000E8F7 File Offset: 0x0000CAF7
		// Note: this type is marked as 'beforefieldinit'.
		static LicensesUpdated_t()
		{
			Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LicensesUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr);
			LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0000E930 File Offset: 0x0000CB30
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LicensesUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x000A809C File Offset: 0x000A629C
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x0000E942 File Offset: 0x0000CB42
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LicensesUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
