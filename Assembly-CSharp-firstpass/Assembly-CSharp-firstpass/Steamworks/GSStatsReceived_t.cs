using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000198 RID: 408
	[StructLayout(2)]
	public struct GSStatsReceived_t
	{
		// Token: 0x06002195 RID: 8597 RVA: 0x000A13D0 File Offset: 0x0009F5D0
		// Note: this type is marked as 'beforefieldinit'.
		static GSStatsReceived_t()
		{
			Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr);
			GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "k_iCallback");
			GSStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "m_eResult");
			GSStatsReceived_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x000A143C File Offset: 0x0009F63C
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x0000C40A File Offset: 0x0000A60A
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001B59 RID: 7001
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001B5A RID: 7002
		[FieldOffset(4)]
		public CSteamID m_steamIDUser;
	}
}
