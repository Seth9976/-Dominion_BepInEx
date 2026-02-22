using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000017 RID: 23
	public sealed class DeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00002805 File Offset: 0x00000A05
		// Note: this type is marked as 'beforefieldinit'.
		static DeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "DeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeallocateOnJobCompletionAttribute>.NativeClassPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000282A File Offset: 0x00000A2A
		public DeallocateOnJobCompletionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
