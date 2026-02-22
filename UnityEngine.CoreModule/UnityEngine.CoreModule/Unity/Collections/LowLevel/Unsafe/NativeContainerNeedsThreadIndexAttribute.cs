using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000026 RID: 38
	public sealed class NativeContainerNeedsThreadIndexAttribute : Attribute
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00002BB3 File Offset: 0x00000DB3
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerNeedsThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerNeedsThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerNeedsThreadIndexAttribute>.NativeClassPtr);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002BD8 File Offset: 0x00000DD8
		public NativeContainerNeedsThreadIndexAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
