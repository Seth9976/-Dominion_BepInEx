using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200012E RID: 302
	[StructLayout(2)]
	public struct RuntimeArgumentHandle
	{
		// Token: 0x060015A3 RID: 5539 RVA: 0x0000781E File Offset: 0x00005A1E
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeArgumentHandle()
		{
			Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RuntimeArgumentHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr);
			RuntimeArgumentHandle.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, "args");
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00007857 File Offset: 0x00005A57
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeArgumentHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04001253 RID: 4691
		[FieldOffset(0)]
		public IntPtr args;
	}
}
