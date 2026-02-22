using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004AB RID: 1195
	public class IEnumerator<T> : Il2CppObjectBase
	{
		// Token: 0x060046CB RID: 18123 RVA: 0x001457B8 File Offset: 0x001439B8
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerator()
		{
			Il2CppClassPointerStore<IEnumerator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IEnumerator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator<T>>.NativeClassPtr, 100673794);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x00145830 File Offset: 0x00143A30
		public unsafe virtual T Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator<T>.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0001AC3B File Offset: 0x00018E3B
		public IEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_T_0;
	}
}
