using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000025 RID: 37
	public sealed class NativeSetThreadIndexAttribute : Attribute
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00002B85 File Offset: 0x00000D85
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSetThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSetThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002BAA File Offset: 0x00000DAA
		public NativeSetThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
