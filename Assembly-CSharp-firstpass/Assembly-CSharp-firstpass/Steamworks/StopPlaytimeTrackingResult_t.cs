using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000216 RID: 534
	[StructLayout(2)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x060024CC RID: 9420 RVA: 0x000A794C File Offset: 0x000A5B4C
		// Note: this type is marked as 'beforefieldinit'.
		static StopPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StopPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr);
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "k_iCallback");
			StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0000E6AA File Offset: 0x0000C8AA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StopPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x000A79A4 File Offset: 0x000A5BA4
		// (set) Token: 0x060024CF RID: 9423 RVA: 0x0000E6BC File Offset: 0x0000C8BC
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StopPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E39 RID: 7737
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
