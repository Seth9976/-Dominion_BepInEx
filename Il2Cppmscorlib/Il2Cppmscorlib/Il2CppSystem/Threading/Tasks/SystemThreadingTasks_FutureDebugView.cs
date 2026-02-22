using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029B RID: 667
	public class SystemThreadingTasks_FutureDebugView<TResult> : Object
	{
		// Token: 0x06002D25 RID: 11557 RVA: 0x000E5280 File Offset: 0x000E3480
		// Note: this type is marked as 'beforefieldinit'.
		static SystemThreadingTasks_FutureDebugView()
		{
			Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "SystemThreadingTasks_FutureDebugView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemThreadingTasks_FutureDebugView<TResult>>.NativeClassPtr);
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0000FD8A File Offset: 0x0000DF8A
		public SystemThreadingTasks_FutureDebugView(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
