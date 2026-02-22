using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000232 RID: 562
	[StructLayout(2)]
	public struct UserStatsUnloaded_t
	{
		// Token: 0x0600255E RID: 9566 RVA: 0x000A8D38 File Offset: 0x000A6F38
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsUnloaded_t()
		{
			Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsUnloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr);
			UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "k_iCallback");
			UserStatsUnloaded_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0000EC14 File Offset: 0x0000CE14
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsUnloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000A8D90 File Offset: 0x000A6F90
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x0000EC26 File Offset: 0x0000CE26
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsUnloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001EE7 RID: 7911
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;
	}
}
