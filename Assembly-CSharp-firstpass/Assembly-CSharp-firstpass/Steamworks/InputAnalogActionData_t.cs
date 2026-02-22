using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002A9 RID: 681
	[StructLayout(2)]
	public struct InputAnalogActionData_t
	{
		// Token: 0x0600273C RID: 10044 RVA: 0x000ABCD0 File Offset: 0x000A9ED0
		// Note: this type is marked as 'beforefieldinit'.
		static InputAnalogActionData_t()
		{
			Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputAnalogActionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr);
			InputAnalogActionData_t.NativeFieldInfoPtr_eMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr, "eMode");
			InputAnalogActionData_t.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr, "x");
			InputAnalogActionData_t.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr, "y");
			InputAnalogActionData_t.NativeFieldInfoPtr_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr, "bActive");
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0000FA96 File Offset: 0x0000DC96
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputAnalogActionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeFieldInfoPtr_eMode;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeFieldInfoPtr_bActive;

		// Token: 0x04002664 RID: 9828
		[FieldOffset(0)]
		public EInputSourceMode eMode;

		// Token: 0x04002665 RID: 9829
		[FieldOffset(4)]
		public float x;

		// Token: 0x04002666 RID: 9830
		[FieldOffset(8)]
		public float y;

		// Token: 0x04002667 RID: 9831
		[FieldOffset(12)]
		public byte bActive;
	}
}
