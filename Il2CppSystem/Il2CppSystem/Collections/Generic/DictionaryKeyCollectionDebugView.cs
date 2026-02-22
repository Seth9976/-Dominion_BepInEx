using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000AC RID: 172
	public sealed class DictionaryKeyCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x06000A68 RID: 2664 RVA: 0x000376BC File Offset: 0x000358BC
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryKeyCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "DictionaryKeyCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryKeyCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000061E2 File Offset: 0x000043E2
		public DictionaryKeyCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
