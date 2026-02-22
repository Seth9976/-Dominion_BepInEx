using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000018 RID: 24
	public sealed class NativeFixedLengthAttribute : Attribute
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002833 File Offset: 0x00000A33
		// Note: this type is marked as 'beforefieldinit'.
		static NativeFixedLengthAttribute()
		{
			Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeFixedLengthAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeFixedLengthAttribute>.NativeClassPtr);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002858 File Offset: 0x00000A58
		public NativeFixedLengthAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
