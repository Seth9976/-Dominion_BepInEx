using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022B RID: 555
	[StructLayout(2)]
	public struct UserStatsReceived_t
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x000A8750 File Offset: 0x000A6950
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsReceived_t()
		{
			Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsReceived_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr);
			UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "k_iCallback");
			UserStatsReceived_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_nGameID");
			UserStatsReceived_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_eResult");
			UserStatsReceived_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsReceived_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x000A87D0 File Offset: 0x000A69D0
		// (set) Token: 0x06002538 RID: 9528 RVA: 0x0000EAB2 File Offset: 0x0000CCB2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsReceived_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001EB7 RID: 7863
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04001EB8 RID: 7864
		[FieldOffset(8)]
		public EResult m_eResult;

		// Token: 0x04001EB9 RID: 7865
		[FieldOffset(12)]
		public CSteamID m_steamIDUser;
	}
}
