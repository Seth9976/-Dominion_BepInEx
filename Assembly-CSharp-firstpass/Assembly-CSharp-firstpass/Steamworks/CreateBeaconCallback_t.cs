using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CE RID: 462
	[StructLayout(2)]
	public struct CreateBeaconCallback_t
	{
		// Token: 0x060022E4 RID: 8932 RVA: 0x000A3F28 File Offset: 0x000A2128
		// Note: this type is marked as 'beforefieldinit'.
		static CreateBeaconCallback_t()
		{
			Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CreateBeaconCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr);
			CreateBeaconCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "k_iCallback");
			CreateBeaconCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "m_eResult");
			CreateBeaconCallback_t.NativeFieldInfoPtr_m_ulBeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, "m_ulBeaconID");
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0000D112 File Offset: 0x0000B312
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateBeaconCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000A3F94 File Offset: 0x000A2194
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x0000D124 File Offset: 0x0000B324
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CreateBeaconCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateBeaconCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CC8 RID: 7368
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CC9 RID: 7369
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeFieldInfoPtr_m_ulBeaconID;

		// Token: 0x04001CCB RID: 7371
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001CCC RID: 7372
		[FieldOffset(8)]
		public PartyBeaconID_t m_ulBeaconID;
	}
}
