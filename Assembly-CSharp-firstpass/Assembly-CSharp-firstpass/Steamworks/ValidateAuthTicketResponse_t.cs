using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000223 RID: 547
	[StructLayout(2)]
	public struct ValidateAuthTicketResponse_t
	{
		// Token: 0x0600250B RID: 9483 RVA: 0x000A80B8 File Offset: 0x000A62B8
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateAuthTicketResponse_t()
		{
			Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ValidateAuthTicketResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr);
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "k_iCallback");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_SteamID");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_eAuthSessionResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_eAuthSessionResponse");
			ValidateAuthTicketResponse_t.NativeFieldInfoPtr_m_OwnerSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, "m_OwnerSteamID");
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0000E950 File Offset: 0x0000CB50
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidateAuthTicketResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x000A8138 File Offset: 0x000A6338
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0000E962 File Offset: 0x0000CB62
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidateAuthTicketResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamID;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeFieldInfoPtr_m_eAuthSessionResponse;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeFieldInfoPtr_m_OwnerSteamID;

		// Token: 0x04001E7D RID: 7805
		[FieldOffset(0)]
		public CSteamID m_SteamID;

		// Token: 0x04001E7E RID: 7806
		[FieldOffset(8)]
		public EAuthSessionResponse m_eAuthSessionResponse;

		// Token: 0x04001E7F RID: 7807
		[FieldOffset(12)]
		public CSteamID m_OwnerSteamID;
	}
}
