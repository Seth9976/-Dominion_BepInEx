using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000011 RID: 17
	public sealed class ICollectionDebugView<T> : Object
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x00006F98 File Offset: 0x00005198
		// Note: this type is marked as 'beforefieldinit'.
		static ICollectionDebugView()
		{
			Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Collections.Generic", "ICollectionDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ICollectionDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002530 File Offset: 0x00000730
		public ICollectionDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
