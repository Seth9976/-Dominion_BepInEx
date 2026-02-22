using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B6 RID: 438
	[StructLayout(2)]
	public struct SteamInventoryFullUpdate_t
	{
		// Token: 0x06002272 RID: 8818 RVA: 0x000A2DAC File Offset: 0x000A0FAC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryFullUpdate_t()
		{
			Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryFullUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr);
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryFullUpdate_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, "m_handle");
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x0000CD1D File Offset: 0x0000AF1D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryFullUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000A2E04 File Offset: 0x000A1004
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0000CD2F File Offset: 0x0000AF2F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryFullUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x04001C10 RID: 7184
		[FieldOffset(0)]
		public SteamInventoryResult_t m_handle;
	}
}
