using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000123 RID: 291
	public sealed class MonoType : RuntimeType
	{
		// Token: 0x060014BC RID: 5308 RVA: 0x000073E6 File Offset: 0x000055E6
		// Note: this type is marked as 'beforefieldinit'.
		static MonoType()
		{
			Il2CppClassPointerStore<MonoType>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoType>.NativeClassPtr);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000740B File Offset: 0x0000560B
		public MonoType(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
