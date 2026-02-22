using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000236 RID: 566
	[StructLayout(2)]
	public struct GlobalStatsReceived_t
	{
		// Token: 0x06002579 RID: 9593 RVA: 0x000A90C0 File Offset: 0x000A72C0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalStatsReceived_t()
		{
			Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GlobalStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr);
			GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "k_iCallback");
			GlobalStatsReceived_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "m_nGameID");
			GlobalStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x0000ED0D File Offset: 0x0000CF0D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x0600257B RID: 9595 RVA: 0x000A912C File Offset: 0x000A732C
		// (set) Token: 0x0600257C RID: 9596 RVA: 0x0000ED1F File Offset: 0x0000CF1F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EFC RID: 7932
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04001EFD RID: 7933
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
