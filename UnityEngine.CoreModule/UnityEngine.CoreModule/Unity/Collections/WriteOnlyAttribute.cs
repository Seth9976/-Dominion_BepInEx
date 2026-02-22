using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000016 RID: 22
	public sealed class WriteOnlyAttribute : Attribute
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x000027D7 File Offset: 0x000009D7
		// Note: this type is marked as 'beforefieldinit'.
		static WriteOnlyAttribute()
		{
			Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "WriteOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000027FC File Offset: 0x000009FC
		public WriteOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
