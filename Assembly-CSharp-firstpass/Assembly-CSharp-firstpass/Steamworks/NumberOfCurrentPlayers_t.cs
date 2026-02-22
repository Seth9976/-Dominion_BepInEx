using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000231 RID: 561
	[StructLayout(2)]
	public struct NumberOfCurrentPlayers_t
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x000A8CB0 File Offset: 0x000A6EB0
		// Note: this type is marked as 'beforefieldinit'.
		static NumberOfCurrentPlayers_t()
		{
			Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "NumberOfCurrentPlayers_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr);
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "k_iCallback");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "m_bSuccess");
			NumberOfCurrentPlayers_t.NativeFieldInfoPtr_m_cPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, "m_cPlayers");
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberOfCurrentPlayers_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000A8D1C File Offset: 0x000A6F1C
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x0000EC06 File Offset: 0x0000CE06
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberOfCurrentPlayers_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeFieldInfoPtr_m_cPlayers;

		// Token: 0x04001EE3 RID: 7907
		[FieldOffset(0)]
		public byte m_bSuccess;

		// Token: 0x04001EE4 RID: 7908
		[FieldOffset(4)]
		public int m_cPlayers;
	}
}
