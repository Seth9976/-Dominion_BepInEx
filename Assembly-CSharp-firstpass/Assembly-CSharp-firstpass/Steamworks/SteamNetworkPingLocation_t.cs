using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B7 RID: 695
	public sealed class SteamNetworkPingLocation_t : ValueType
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x0001028F File Offset: 0x0000E48F
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkPingLocation_t()
		{
			Il2CppClassPointerStore<SteamNetworkPingLocation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkPingLocation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkPingLocation_t>.NativeClassPtr);
			SteamNetworkPingLocation_t.NativeFieldInfoPtr_m_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkPingLocation_t>.NativeClassPtr, "m_data");
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000102C8 File Offset: 0x0000E4C8
		public SteamNetworkPingLocation_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000102D1 File Offset: 0x0000E4D1
		public SteamNetworkPingLocation_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkPingLocation_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000AD7B8 File Offset: 0x000AB9B8
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x000102E3 File Offset: 0x0000E4E3
		public unsafe Il2CppStructArray<byte> m_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkPingLocation_t.NativeFieldInfoPtr_m_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkPingLocation_t.NativeFieldInfoPtr_m_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeFieldInfoPtr_m_data;
	}
}
