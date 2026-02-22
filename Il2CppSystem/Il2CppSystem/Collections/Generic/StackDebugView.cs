using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B9 RID: 185
	public sealed class StackDebugView<T> : Object
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x0003B6D8 File Offset: 0x000398D8
		// Note: this type is marked as 'beforefieldinit'.
		static StackDebugView()
		{
			Il2CppClassPointerStore<StackDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "StackDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000066E1 File Offset: 0x000048E1
		public StackDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
