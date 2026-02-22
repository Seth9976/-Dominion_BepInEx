using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001B5 RID: 437
	[StructLayout(2)]
	public struct SteamInventoryResultReady_t
	{
		// Token: 0x0600226E RID: 8814 RVA: 0x000A2D24 File Offset: 0x000A0F24
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInventoryResultReady_t()
		{
			Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamInventoryResultReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr);
			SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "k_iCallback");
			SteamInventoryResultReady_t.NativeFieldInfoPtr_m_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "m_handle");
			SteamInventoryResultReady_t.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, "m_result");
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x0000CCFD File Offset: 0x0000AEFD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamInventoryResultReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000A2D90 File Offset: 0x000A0F90
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x0000CD0F File Offset: 0x0000AF0F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamInventoryResultReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr_m_handle;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04001C0C RID: 7180
		[FieldOffset(0)]
		public SteamInventoryResult_t m_handle;

		// Token: 0x04001C0D RID: 7181
		[FieldOffset(4)]
		public EResult m_result;
	}
}
