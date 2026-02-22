using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CB RID: 1227
	public class EventIgnoreAttribute : Attribute
	{
		// Token: 0x060047FE RID: 18430 RVA: 0x0001B414 File Offset: 0x00019614
		// Note: this type is marked as 'beforefieldinit'.
		static EventIgnoreAttribute()
		{
			Il2CppClassPointerStore<EventIgnoreAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventIgnoreAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventIgnoreAttribute>.NativeClassPtr);
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0001B439 File Offset: 0x00019639
		public EventIgnoreAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
