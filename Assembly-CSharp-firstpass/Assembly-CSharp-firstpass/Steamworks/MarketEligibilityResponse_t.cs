using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000229 RID: 553
	[StructLayout(2)]
	public struct MarketEligibilityResponse_t
	{
		// Token: 0x0600252D RID: 9517 RVA: 0x000A858C File Offset: 0x000A678C
		// Note: this type is marked as 'beforefieldinit'.
		static MarketEligibilityResponse_t()
		{
			Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "MarketEligibilityResponse_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr);
			MarketEligibilityResponse_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "k_iCallback");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_m_bAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "m_bAllowed");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_m_eNotAllowedReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "m_eNotAllowedReason");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_m_rtAllowedAtTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "m_rtAllowedAtTime");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_m_cdaySteamGuardRequiredDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "m_cdaySteamGuardRequiredDays");
			MarketEligibilityResponse_t.NativeFieldInfoPtr_m_cdayNewDeviceCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, "m_cdayNewDeviceCooldown");
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarketEligibilityResponse_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000A8634 File Offset: 0x000A6834
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x0000EA72 File Offset: 0x0000CC72
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MarketEligibilityResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MarketEligibilityResponse_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeFieldInfoPtr_m_bAllowed;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeFieldInfoPtr_m_eNotAllowedReason;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_m_rtAllowedAtTime;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_m_cdaySteamGuardRequiredDays;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr_m_cdayNewDeviceCooldown;

		// Token: 0x04001E9D RID: 7837
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool m_bAllowed;

		// Token: 0x04001E9E RID: 7838
		[FieldOffset(4)]
		public EMarketNotAllowedReasonFlags m_eNotAllowedReason;

		// Token: 0x04001E9F RID: 7839
		[FieldOffset(8)]
		public RTime32 m_rtAllowedAtTime;

		// Token: 0x04001EA0 RID: 7840
		[FieldOffset(12)]
		public int m_cdaySteamGuardRequiredDays;

		// Token: 0x04001EA1 RID: 7841
		[FieldOffset(16)]
		public int m_cdayNewDeviceCooldown;
	}
}
