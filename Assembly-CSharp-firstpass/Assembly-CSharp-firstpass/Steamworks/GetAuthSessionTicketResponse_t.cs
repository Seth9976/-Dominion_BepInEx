using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000226 RID: 550
	[StructLayout(2)]
	public struct GetAuthSessionTicketResponse_t
	{
		// Token: 0x06002517 RID: 9495 RVA: 0x000A8264 File Offset: 0x000A6464
		// Note: this type is marked as 'beforefieldinit'.
		static GetAuthSessionTicketResponse_t()
		{
			Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GetAuthSessionTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr);
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "k_iCallback");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_m_hAuthTicket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_hAuthTicket");
			GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetAuthSessionTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000A82D0 File Offset: 0x000A64D0
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x0000E9C2 File Offset: 0x0000CBC2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetAuthSessionTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeFieldInfoPtr_m_hAuthTicket;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E8D RID: 7821
		[FieldOffset(0)]
		public HAuthTicket m_hAuthTicket;

		// Token: 0x04001E8E RID: 7822
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}
