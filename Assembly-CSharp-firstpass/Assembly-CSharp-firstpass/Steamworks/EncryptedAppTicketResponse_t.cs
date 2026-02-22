using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000225 RID: 549
	[StructLayout(2)]
	public struct EncryptedAppTicketResponse_t
	{
		// Token: 0x06002513 RID: 9491 RVA: 0x000A81F0 File Offset: 0x000A63F0
		// Note: this type is marked as 'beforefieldinit'.
		static EncryptedAppTicketResponse_t()
		{
			Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "EncryptedAppTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr);
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "k_iCallback");
			EncryptedAppTicketResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0000E990 File Offset: 0x0000CB90
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EncryptedAppTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x000A8248 File Offset: 0x000A6448
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0000E9A2 File Offset: 0x0000CBA2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EncryptedAppTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E89 RID: 7817
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
