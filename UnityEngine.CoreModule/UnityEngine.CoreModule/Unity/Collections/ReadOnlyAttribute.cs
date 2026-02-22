using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000015 RID: 21
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x000027A9 File Offset: 0x000009A9
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "ReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000027CE File Offset: 0x000009CE
		public ReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
