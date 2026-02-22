using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200023A RID: 570
	[StructLayout(2)]
	public struct SteamShutdown_t
	{
		// Token: 0x06002589 RID: 9609 RVA: 0x0000EDC6 File Offset: 0x0000CFC6
		// Note: this type is marked as 'beforefieldinit'.
		static SteamShutdown_t()
		{
			Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamShutdown_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr);
			SteamShutdown_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x0000EDFF File Offset: 0x0000CFFF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamShutdown_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000A9274 File Offset: 0x000A7474
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x0000EE11 File Offset: 0x0000D011
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamShutdown_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamShutdown_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
