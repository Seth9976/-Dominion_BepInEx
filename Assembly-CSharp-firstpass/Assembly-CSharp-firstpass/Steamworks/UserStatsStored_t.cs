using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022C RID: 556
	[StructLayout(2)]
	public struct UserStatsStored_t
	{
		// Token: 0x06002539 RID: 9529 RVA: 0x000A87EC File Offset: 0x000A69EC
		// Note: this type is marked as 'beforefieldinit'.
		static UserStatsStored_t()
		{
			Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "UserStatsStored_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr);
			UserStatsStored_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "k_iCallback");
			UserStatsStored_t.NativeFieldInfoPtr_m_nGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "m_nGameID");
			UserStatsStored_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserStatsStored_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x0600253B RID: 9531 RVA: 0x000A8858 File Offset: 0x000A6A58
		// (set) Token: 0x0600253C RID: 9532 RVA: 0x0000EAD2 File Offset: 0x0000CCD2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UserStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserStatsStored_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_m_nGameID;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EBD RID: 7869
		[FieldOffset(0)]
		public ulong m_nGameID;

		// Token: 0x04001EBE RID: 7870
		[FieldOffset(8)]
		public EResult m_eResult;
	}
}
