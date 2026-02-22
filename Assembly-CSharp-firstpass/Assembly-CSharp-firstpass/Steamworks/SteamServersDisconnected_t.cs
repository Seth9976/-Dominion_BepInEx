using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021F RID: 543
	[StructLayout(2)]
	public struct SteamServersDisconnected_t
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x000A7EF0 File Offset: 0x000A60F0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServersDisconnected_t()
		{
			Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServersDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr);
			SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "k_iCallback");
			SteamServersDisconnected_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0000E897 File Offset: 0x0000CA97
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServersDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x000A7F48 File Offset: 0x000A6148
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x0000E8A9 File Offset: 0x0000CAA9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServersDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E69 RID: 7785
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
