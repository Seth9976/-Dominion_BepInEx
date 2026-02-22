using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000020 RID: 32
	public sealed class NativeContainerIsReadOnlyAttribute : Attribute
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00002A63 File Offset: 0x00000C63
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerIsReadOnlyAttribute()
		{
			Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerIsReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerIsReadOnlyAttribute>.NativeClassPtr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002A88 File Offset: 0x00000C88
		public NativeContainerIsReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
