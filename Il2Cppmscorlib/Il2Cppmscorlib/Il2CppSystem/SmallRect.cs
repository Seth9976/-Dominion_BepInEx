using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200014E RID: 334
	[StructLayout(2)]
	public struct SmallRect
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x00089EB0 File Offset: 0x000880B0
		// Note: this type is marked as 'beforefieldinit'.
		static SmallRect()
		{
			Il2CppClassPointerStore<SmallRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SmallRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallRect>.NativeClassPtr);
			SmallRect.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Left");
			SmallRect.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Top");
			SmallRect.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Right");
			SmallRect.NativeFieldInfoPtr_Bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, "Bottom");
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0000828B File Offset: 0x0000648B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmallRect>.NativeClassPtr, ref this));
		}

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_Top;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_Bottom;

		// Token: 0x04001565 RID: 5477
		[FieldOffset(0)]
		public short Left;

		// Token: 0x04001566 RID: 5478
		[FieldOffset(2)]
		public short Top;

		// Token: 0x04001567 RID: 5479
		[FieldOffset(4)]
		public short Right;

		// Token: 0x04001568 RID: 5480
		[FieldOffset(6)]
		public short Bottom;
	}
}
