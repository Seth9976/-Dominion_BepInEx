using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002F1 RID: 753
	[Serializable]
	public sealed class SteamNetworkingErrMsg : ValueType
	{
		// Token: 0x06002B6B RID: 11115 RVA: 0x000111CB File Offset: 0x0000F3CB
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingErrMsg()
		{
			Il2CppClassPointerStore<SteamNetworkingErrMsg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingErrMsg");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingErrMsg>.NativeClassPtr);
			SteamNetworkingErrMsg.NativeFieldInfoPtr_m_SteamNetworkingErrMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingErrMsg>.NativeClassPtr, "m_SteamNetworkingErrMsg");
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00011204 File Offset: 0x0000F404
		public SteamNetworkingErrMsg(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0001120D File Offset: 0x0000F40D
		public SteamNetworkingErrMsg()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingErrMsg>.NativeClassPtr))
		{
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000BA2F8 File Offset: 0x000B84F8
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x0001121F File Offset: 0x0000F41F
		public unsafe Il2CppStructArray<byte> m_SteamNetworkingErrMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingErrMsg.NativeFieldInfoPtr_m_SteamNetworkingErrMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingErrMsg.NativeFieldInfoPtr_m_SteamNetworkingErrMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029BE RID: 10686
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamNetworkingErrMsg;
	}
}
