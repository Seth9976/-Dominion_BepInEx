using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022A RID: 554
	[StructLayout(2)]
	public struct DurationControl_t
	{
		// Token: 0x06002531 RID: 9521 RVA: 0x000A8650 File Offset: 0x000A6850
		// Note: this type is marked as 'beforefieldinit'.
		static DurationControl_t()
		{
			Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "DurationControl_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr);
			DurationControl_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "k_iCallback");
			DurationControl_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_eResult");
			DurationControl_t.NativeFieldInfoPtr_m_appid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_appid");
			DurationControl_t.NativeFieldInfoPtr_m_bApplicable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_bApplicable");
			DurationControl_t.NativeFieldInfoPtr_m_csecsLast5h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_csecsLast5h");
			DurationControl_t.NativeFieldInfoPtr_m_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_progress");
			DurationControl_t.NativeFieldInfoPtr_m_notification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_notification");
			DurationControl_t.NativeFieldInfoPtr_m_csecsToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_csecsToday");
			DurationControl_t.NativeFieldInfoPtr_m_csecsRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, "m_csecsRemaining");
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0000EA80 File Offset: 0x0000CC80
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DurationControl_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x000A8734 File Offset: 0x000A6934
		// (set) Token: 0x06002534 RID: 9524 RVA: 0x0000EA92 File Offset: 0x0000CC92
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DurationControl_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DurationControl_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeFieldInfoPtr_m_appid;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeFieldInfoPtr_m_bApplicable;

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeFieldInfoPtr_m_csecsLast5h;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_m_progress;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_m_notification;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_m_csecsToday;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_m_csecsRemaining;

		// Token: 0x04001EAB RID: 7851
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001EAC RID: 7852
		[FieldOffset(4)]
		public AppId_t m_appid;

		// Token: 0x04001EAD RID: 7853
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_bApplicable;

		// Token: 0x04001EAE RID: 7854
		[FieldOffset(12)]
		public int m_csecsLast5h;

		// Token: 0x04001EAF RID: 7855
		[FieldOffset(16)]
		public EDurationControlProgress m_progress;

		// Token: 0x04001EB0 RID: 7856
		[FieldOffset(20)]
		public EDurationControlNotification m_notification;

		// Token: 0x04001EB1 RID: 7857
		[FieldOffset(24)]
		public int m_csecsToday;

		// Token: 0x04001EB2 RID: 7858
		[FieldOffset(28)]
		public int m_csecsRemaining;
	}
}
