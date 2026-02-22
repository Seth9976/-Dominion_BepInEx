using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200019A RID: 410
	[StructLayout(2)]
	public struct GSStatsUnloaded_t
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x000A14E0 File Offset: 0x0009F6E0
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsUnloaded_t()
		{
			Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr);
			GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "k_iCallback");
			GSStatsUnloaded_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0000C438 File Offset: 0x0000A638
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x000A1538 File Offset: 0x0009F738
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0000C44A File Offset: 0x0000A64A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001B62 RID: 7010
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;
	}
}
