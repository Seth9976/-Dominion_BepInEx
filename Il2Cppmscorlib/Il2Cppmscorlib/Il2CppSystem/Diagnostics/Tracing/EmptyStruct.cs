using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004C4 RID: 1220
	[StructLayout(2)]
	public struct EmptyStruct
	{
		// Token: 0x060047D5 RID: 18389 RVA: 0x0001B2A8 File Offset: 0x000194A8
		// Note: this type is marked as 'beforefieldinit'.
		static EmptyStruct()
		{
			Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EmptyStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr);
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0001B2CD File Offset: 0x000194CD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmptyStruct>.NativeClassPtr, ref this));
		}
	}
}
