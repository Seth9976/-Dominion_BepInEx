using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000146 RID: 326
	[StructLayout(2)]
	public struct EndOfRainbowTray
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x000809D4 File Offset: 0x0007EBD4
		// Note: this type is marked as 'beforefieldinit'.
		static EndOfRainbowTray()
		{
			Il2CppClassPointerStore<EndOfRainbowTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "EndOfRainbowTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndOfRainbowTray>.NativeClassPtr);
			EndOfRainbowTray.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndOfRainbowTray>.NativeClassPtr, "player_instance_id");
			EndOfRainbowTray.NativeFieldInfoPtr_tray_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndOfRainbowTray>.NativeClassPtr, "tray_status");
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00015418 File Offset: 0x00013618
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndOfRainbowTray>.NativeClassPtr, ref this));
		}

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeFieldInfoPtr_tray_status;

		// Token: 0x04001776 RID: 6006
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x04001777 RID: 6007
		[FieldOffset(4)]
		public int tray_status;
	}
}
