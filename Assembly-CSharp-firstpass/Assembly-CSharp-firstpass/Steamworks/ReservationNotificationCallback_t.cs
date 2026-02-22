using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001CF RID: 463
	[StructLayout(2)]
	public struct ReservationNotificationCallback_t
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x000A3FB0 File Offset: 0x000A21B0
		// Note: this type is marked as 'beforefieldinit'.
		static ReservationNotificationCallback_t()
		{
			Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ReservationNotificationCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr);
			ReservationNotificationCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "k_iCallback");
			ReservationNotificationCallback_t.NativeFieldInfoPtr_m_ulBeaconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "m_ulBeaconID");
			ReservationNotificationCallback_t.NativeFieldInfoPtr_m_steamIDJoiner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, "m_steamIDJoiner");
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0000D132 File Offset: 0x0000B332
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReservationNotificationCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x000A401C File Offset: 0x000A221C
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x0000D144 File Offset: 0x0000B344
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReservationNotificationCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReservationNotificationCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeFieldInfoPtr_m_ulBeaconID;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDJoiner;

		// Token: 0x04001CD0 RID: 7376
		[FieldOffset(0)]
		public PartyBeaconID_t m_ulBeaconID;

		// Token: 0x04001CD1 RID: 7377
		[FieldOffset(8)]
		public CSteamID m_steamIDJoiner;
	}
}
