using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AD RID: 685
	[StructLayout(2)]
	public struct SteamPartyBeaconLocation_t
	{
		// Token: 0x06002744 RID: 10052 RVA: 0x000ABF20 File Offset: 0x000AA120
		// Note: this type is marked as 'beforefieldinit'.
		static SteamPartyBeaconLocation_t()
		{
			Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamPartyBeaconLocation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr);
			SteamPartyBeaconLocation_t.NativeFieldInfoPtr_m_eType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, "m_eType");
			SteamPartyBeaconLocation_t.NativeFieldInfoPtr_m_ulLocationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, "m_ulLocationID");
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0000FADE File Offset: 0x0000DCDE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeFieldInfoPtr_m_eType;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeFieldInfoPtr_m_ulLocationID;

		// Token: 0x0400268A RID: 9866
		[FieldOffset(0)]
		public ESteamPartyBeaconLocationType m_eType;

		// Token: 0x0400268B RID: 9867
		[FieldOffset(8)]
		public ulong m_ulLocationID;
	}
}
