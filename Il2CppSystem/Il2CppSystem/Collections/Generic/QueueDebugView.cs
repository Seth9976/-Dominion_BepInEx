using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B1 RID: 177
	public sealed class QueueDebugView<T> : Object
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00038EA4 File Offset: 0x000370A4
		// Note: this type is marked as 'beforefieldinit'.
		static QueueDebugView()
		{
			Il2CppClassPointerStore<QueueDebugView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "QueueDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueDebugView<T>>.NativeClassPtr);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000063FB File Offset: 0x000045FB
		public QueueDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
