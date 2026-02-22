using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x020001E4 RID: 484
	public class AssemblyBuilder : Assembly
	{
		// Token: 0x06001F38 RID: 7992 RVA: 0x0000AB02 File Offset: 0x00008D02
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyBuilder()
		{
			Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "AssemblyBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyBuilder>.NativeClassPtr);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0000AB27 File Offset: 0x00008D27
		public AssemblyBuilder(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
