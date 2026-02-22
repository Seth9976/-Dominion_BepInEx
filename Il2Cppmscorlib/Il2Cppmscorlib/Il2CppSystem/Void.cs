using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000149 RID: 329
	[Serializable]
	[StructLayout(2)]
	public struct Void
	{
		// Token: 0x060016FC RID: 5884 RVA: 0x000081B2 File Offset: 0x000063B2
		// Note: this type is marked as 'beforefieldinit'.
		static Void()
		{
			Il2CppClassPointerStore<Void>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Void");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Void>.NativeClassPtr);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000081D7 File Offset: 0x000063D7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Void>.NativeClassPtr, ref this));
		}
	}
}
