using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000493 RID: 1171
	public sealed class IDictionaryDebugView<K, V> : Object
	{
		// Token: 0x06004635 RID: 17973 RVA: 0x00141CB8 File Offset: 0x0013FEB8
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryDebugView()
		{
			Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IDictionaryDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr);
		}

		// Token: 0x06004636 RID: 17974 RVA: 0x0001AB2D File Offset: 0x00018D2D
		public IDictionaryDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
