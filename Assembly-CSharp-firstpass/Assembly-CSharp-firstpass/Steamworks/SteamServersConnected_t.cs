using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021D RID: 541
	[StructLayout(2)]
	public struct SteamServersConnected_t
	{
		// Token: 0x060024F3 RID: 9459 RVA: 0x0000E81E File Offset: 0x0000CA1E
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersConnected_t()
		{
			Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServersConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr);
			SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0000E857 File Offset: 0x0000CA57
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x000A7E4C File Offset: 0x000A604C
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x0000E869 File Offset: 0x0000CA69
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
