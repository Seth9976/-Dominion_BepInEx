using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001D1 RID: 465
	[StructLayout(2)]
	public struct AvailableBeaconLocationsUpdated_t
	{
		// Token: 0x060022F0 RID: 8944 RVA: 0x0000D172 File Offset: 0x0000B372
		// Note: this type is marked as 'beforefieldinit'.
		static AvailableBeaconLocationsUpdated_t()
		{
			Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "AvailableBeaconLocationsUpdated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr);
			AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0000D1AB File Offset: 0x0000B3AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AvailableBeaconLocationsUpdated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x000A40AC File Offset: 0x000A22AC
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x0000D1BD File Offset: 0x0000B3BD
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvailableBeaconLocationsUpdated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
