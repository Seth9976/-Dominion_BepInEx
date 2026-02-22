using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000215 RID: 533
	[StructLayout(2)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x060024C8 RID: 9416 RVA: 0x000A78D8 File Offset: 0x000A5AD8
		// Note: this type is marked as 'beforefieldinit'.
		static StartPlaytimeTrackingResult_t()
		{
			Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "StartPlaytimeTrackingResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr);
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "k_iCallback");
			StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0000E68A File Offset: 0x0000C88A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StartPlaytimeTrackingResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060024CA RID: 9418 RVA: 0x000A7930 File Offset: 0x000A5B30
		// (set) Token: 0x060024CB RID: 9419 RVA: 0x0000E69C File Offset: 0x0000C89C
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartPlaytimeTrackingResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E36 RID: 7734
		[FieldOffset(0)]
		public EResult m_eResult;
	}
}
