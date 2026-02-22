using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AA RID: 682
	[StructLayout(2)]
	public struct InputDigitalActionData_t
	{
		// Token: 0x0600273E RID: 10046 RVA: 0x000ABD50 File Offset: 0x000A9F50
		// Note: this type is marked as 'beforefieldinit'.
		static InputDigitalActionData_t()
		{
			Il2CppClassPointerStore<InputDigitalActionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputDigitalActionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDigitalActionData_t>.NativeClassPtr);
			InputDigitalActionData_t.NativeFieldInfoPtr_bState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDigitalActionData_t>.NativeClassPtr, "bState");
			InputDigitalActionData_t.NativeFieldInfoPtr_bActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDigitalActionData_t>.NativeClassPtr, "bActive");
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0000FAA8 File Offset: 0x0000DCA8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDigitalActionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeFieldInfoPtr_bState;

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeFieldInfoPtr_bActive;

		// Token: 0x0400266A RID: 9834
		[FieldOffset(0)]
		public byte bState;

		// Token: 0x0400266B RID: 9835
		[FieldOffset(1)]
		public byte bActive;
	}
}
