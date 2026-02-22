using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000195 RID: 405
	[StructLayout(2)]
	public struct GSReputation_t
	{
		// Token: 0x06002189 RID: 8585 RVA: 0x000A11AC File Offset: 0x0009F3AC
		// Note: this type is marked as 'beforefieldinit'.
		static GSReputation_t()
		{
			Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GSReputation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr);
			GSReputation_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "k_iCallback");
			GSReputation_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_eResult");
			GSReputation_t.NativeFieldInfoPtr_m_unReputationScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unReputationScore");
			GSReputation_t.NativeFieldInfoPtr_m_bBanned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_bBanned");
			GSReputation_t.NativeFieldInfoPtr_m_unBannedIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unBannedIP");
			GSReputation_t.NativeFieldInfoPtr_m_usBannedPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_usBannedPort");
			GSReputation_t.NativeFieldInfoPtr_m_ulBannedGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_ulBannedGameID");
			GSReputation_t.NativeFieldInfoPtr_m_unBanExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, "m_unBanExpires");
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0000C398 File Offset: 0x0000A598
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GSReputation_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x000A127C File Offset: 0x0009F47C
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x0000C3AA File Offset: 0x0000A5AA
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GSReputation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GSReputation_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_m_unReputationScore;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_m_bBanned;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_m_unBannedIP;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_m_usBannedPort;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_m_ulBannedGameID;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_m_unBanExpires;

		// Token: 0x04001B41 RID: 6977
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001B42 RID: 6978
		[FieldOffset(4)]
		public uint m_unReputationScore;

		// Token: 0x04001B43 RID: 6979
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_bBanned;

		// Token: 0x04001B44 RID: 6980
		[FieldOffset(12)]
		public uint m_unBannedIP;

		// Token: 0x04001B45 RID: 6981
		[FieldOffset(16)]
		public ushort m_usBannedPort;

		// Token: 0x04001B46 RID: 6982
		[FieldOffset(24)]
		public ulong m_ulBannedGameID;

		// Token: 0x04001B47 RID: 6983
		[FieldOffset(32)]
		public uint m_unBanExpires;
	}
}
