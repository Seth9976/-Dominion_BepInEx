using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000234 RID: 564
	[StructLayout(2)]
	public struct GlobalAchievementPercentagesReady_t
	{
		// Token: 0x06002571 RID: 9585 RVA: 0x000A8FB0 File Offset: 0x000A71B0
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalAchievementPercentagesReady_t()
		{
			Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GlobalAchievementPercentagesReady_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr);
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "k_iCallback");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "m_nGameID");
			GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x0000ECCD File Offset: 0x0000CECD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalAchievementPercentagesReady_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x000A901C File Offset: 0x000A721C
		// (set) Token: 0x06002574 RID: 9588 RVA: 0x0000ECDF File Offset: 0x0000CEDF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlobalAchievementPercentagesReady_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EF2 RID: 7922
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04001EF3 RID: 7923
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
