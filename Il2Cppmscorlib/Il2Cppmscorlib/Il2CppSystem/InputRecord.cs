using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014C RID: 332
	[StructLayout(2)]
	public struct InputRecord
	{
		// Token: 0x0600171B RID: 5915 RVA: 0x00089D74 File Offset: 0x00087F74
		// Note: this type is marked as 'beforefieldinit'.
		static InputRecord()
		{
			Il2CppClassPointerStore<InputRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InputRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRecord>.NativeClassPtr);
			InputRecord.NativeFieldInfoPtr_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "EventType");
			InputRecord.NativeFieldInfoPtr_KeyDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "KeyDown");
			InputRecord.NativeFieldInfoPtr_RepeatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "RepeatCount");
			InputRecord.NativeFieldInfoPtr_VirtualKeyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualKeyCode");
			InputRecord.NativeFieldInfoPtr_VirtualScanCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "VirtualScanCode");
			InputRecord.NativeFieldInfoPtr_Character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "Character");
			InputRecord.NativeFieldInfoPtr_ControlKeyState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "ControlKeyState");
			InputRecord.NativeFieldInfoPtr_pad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad1");
			InputRecord.NativeFieldInfoPtr_pad2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, "pad2");
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00008267 File Offset: 0x00006467
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputRecord>.NativeClassPtr, ref this));
		}

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeFieldInfoPtr_EventType;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeFieldInfoPtr_KeyDown;

		// Token: 0x0400154D RID: 5453
		private static readonly IntPtr NativeFieldInfoPtr_RepeatCount;

		// Token: 0x0400154E RID: 5454
		private static readonly IntPtr NativeFieldInfoPtr_VirtualKeyCode;

		// Token: 0x0400154F RID: 5455
		private static readonly IntPtr NativeFieldInfoPtr_VirtualScanCode;

		// Token: 0x04001550 RID: 5456
		private static readonly IntPtr NativeFieldInfoPtr_Character;

		// Token: 0x04001551 RID: 5457
		private static readonly IntPtr NativeFieldInfoPtr_ControlKeyState;

		// Token: 0x04001552 RID: 5458
		private static readonly IntPtr NativeFieldInfoPtr_pad1;

		// Token: 0x04001553 RID: 5459
		private static readonly IntPtr NativeFieldInfoPtr_pad2;

		// Token: 0x04001554 RID: 5460
		[FieldOffset(0)]
		public short EventType;

		// Token: 0x04001555 RID: 5461
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool KeyDown;

		// Token: 0x04001556 RID: 5462
		[FieldOffset(4)]
		public short RepeatCount;

		// Token: 0x04001557 RID: 5463
		[FieldOffset(6)]
		public short VirtualKeyCode;

		// Token: 0x04001558 RID: 5464
		[FieldOffset(8)]
		public short VirtualScanCode;

		// Token: 0x04001559 RID: 5465
		[FieldOffset(10)]
		public char Character;

		// Token: 0x0400155A RID: 5466
		[FieldOffset(12)]
		public int ControlKeyState;

		// Token: 0x0400155B RID: 5467
		[FieldOffset(16)]
		public int pad1;

		// Token: 0x0400155C RID: 5468
		[FieldOffset(20)]
		[MarshalAs(4)]
		public bool pad2;
	}
}
