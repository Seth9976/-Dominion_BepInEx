using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000177 RID: 375
	[StructLayout(2)]
	public struct TimedTrialStatus_t
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x0009FAE4 File Offset: 0x0009DCE4
		// Note: this type is marked as 'beforefieldinit'.
		static TimedTrialStatus_t()
		{
			Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "TimedTrialStatus_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr);
			TimedTrialStatus_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "k_iCallback");
			TimedTrialStatus_t.NativeFieldInfoPtr_m_unAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "m_unAppID");
			TimedTrialStatus_t.NativeFieldInfoPtr_m_bIsOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "m_bIsOffline");
			TimedTrialStatus_t.NativeFieldInfoPtr_m_unSecondsAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "m_unSecondsAllowed");
			TimedTrialStatus_t.NativeFieldInfoPtr_m_unSecondsPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, "m_unSecondsPlayed");
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0000BD7F File Offset: 0x00009F7F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimedTrialStatus_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0009FB78 File Offset: 0x0009DD78
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0000BD91 File Offset: 0x00009F91
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimedTrialStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimedTrialStatus_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeFieldInfoPtr_m_unAppID;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeFieldInfoPtr_m_bIsOffline;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeFieldInfoPtr_m_unSecondsAllowed;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_m_unSecondsPlayed;

		// Token: 0x04001A97 RID: 6807
		[FieldOffset(0)]
		public AppId_t m_unAppID;

		// Token: 0x04001A98 RID: 6808
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool m_bIsOffline;

		// Token: 0x04001A99 RID: 6809
		[FieldOffset(8)]
		public uint m_unSecondsAllowed;

		// Token: 0x04001A9A RID: 6810
		[FieldOffset(12)]
		public uint m_unSecondsPlayed;
	}
}
