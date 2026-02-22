using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000495 RID: 1173
	public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x06004639 RID: 17977 RVA: 0x00141DB8 File Offset: 0x0013FFB8
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryValueCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x0001AB3F File Offset: 0x00018D3F
		public DictionaryValueCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
