using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000AA RID: 170
	public sealed class ICollectionDebugView<T> : Object
	{
		// Token: 0x06000A64 RID: 2660 RVA: 0x000375D0 File Offset: 0x000357D0
		// Note: this type is marked as 'beforefieldinit'.
		static ICollectionDebugView()
		{
			Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "ICollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000061D0 File Offset: 0x000043D0
		public ICollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
