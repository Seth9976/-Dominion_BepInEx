using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049C RID: 1180
	public sealed class Mscorlib_CollectionDebugView<T> : Object
	{
		// Token: 0x06004662 RID: 18018 RVA: 0x00142AF8 File Offset: 0x00140CF8
		// Note: this type is marked as 'beforefieldinit'.
		static Mscorlib_CollectionDebugView()
		{
			Il2CppClassPointerStore<Mscorlib_CollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Mscorlib_CollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mscorlib_CollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x0001ABA2 File Offset: 0x00018DA2
		public Mscorlib_CollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
