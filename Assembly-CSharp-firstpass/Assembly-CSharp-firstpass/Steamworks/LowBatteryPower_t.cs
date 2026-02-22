using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000238 RID: 568
	[StructLayout(2)]
	public struct LowBatteryPower_t
	{
		// Token: 0x06002581 RID: 9601 RVA: 0x000A9164 File Offset: 0x000A7364
		// Note: this type is marked as 'beforefieldinit'.
		static LowBatteryPower_t()
		{
			Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LowBatteryPower_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr);
			LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "k_iCallback");
			LowBatteryPower_t.NativeFieldInfoPtr_m_nMinutesBatteryLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, "m_nMinutesBatteryLeft");
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0000ED86 File Offset: 0x0000CF86
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LowBatteryPower_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000A91BC File Offset: 0x000A73BC
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowBatteryPower_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_m_nMinutesBatteryLeft;

		// Token: 0x04001F01 RID: 7937
		[FieldOffset(0)]
		public byte m_nMinutesBatteryLeft;
	}
}
