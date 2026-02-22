using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D2 RID: 466
	[StructLayout(2)]
	public struct ActiveBeaconsUpdated_t
	{
		// Token: 0x060022F4 RID: 8948 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveBeaconsUpdated_t()
		{
			Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ActiveBeaconsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr);
			ActiveBeaconsUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0000D204 File Offset: 0x0000B404
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActiveBeaconsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x000A40C8 File Offset: 0x000A22C8
		// (set) Token: 0x060022F7 RID: 8951 RVA: 0x0000D216 File Offset: 0x0000B416
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveBeaconsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveBeaconsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
