using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017D RID: 381
	[StructLayout(2)]
	public struct ClanOfficerListResponse_t
	{
		// Token: 0x06002102 RID: 8450 RVA: 0x000A0008 File Offset: 0x0009E208
		// Note: this type is marked as 'beforefieldinit'.
		static ClanOfficerListResponse_t()
		{
			Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ClanOfficerListResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr);
			ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "k_iCallback");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_steamIDClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_steamIDClan");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_cOfficers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_cOfficers");
			ClanOfficerListResponse_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x0000BE86 File Offset: 0x0000A086
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanOfficerListResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x000A0088 File Offset: 0x0009E288
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000BE98 File Offset: 0x0000A098
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClanOfficerListResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClan;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeFieldInfoPtr_m_cOfficers;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001ABC RID: 6844
		[FieldOffset(0)]
		public CSteamID m_steamIDClan;

		// Token: 0x04001ABD RID: 6845
		[FieldOffset(8)]
		public int m_cOfficers;

		// Token: 0x04001ABE RID: 6846
		[FieldOffset(12)]
		public byte m_bSuccess;
	}
}
