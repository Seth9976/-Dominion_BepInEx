using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000AD RID: 173
	public sealed class DictionaryValueCollectionDebugView<TKey, TValue> : Object
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0003773C File Offset: 0x0003593C
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryValueCollectionDebugView()
		{
			Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "DictionaryValueCollectionDebugView`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryValueCollectionDebugView<TKey, TValue>>.NativeClassPtr);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000061EB File Offset: 0x000043EB
		public DictionaryValueCollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
