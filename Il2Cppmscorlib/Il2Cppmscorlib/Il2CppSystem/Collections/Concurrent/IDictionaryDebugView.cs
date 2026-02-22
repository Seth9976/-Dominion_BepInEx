using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x02000489 RID: 1161
	public sealed class IDictionaryDebugView<K, V> : Object
	{
		// Token: 0x060045B3 RID: 17843 RVA: 0x0013F11C File Offset: 0x0013D31C
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryDebugView()
		{
			Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "IDictionaryDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDictionaryDebugView<K, V>>.NativeClassPtr);
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x0001A8FF File Offset: 0x00018AFF
		public IDictionaryDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
