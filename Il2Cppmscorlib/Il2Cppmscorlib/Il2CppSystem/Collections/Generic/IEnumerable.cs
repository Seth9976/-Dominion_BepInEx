using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004AA RID: 1194
	public class IEnumerable<T> : Il2CppObjectBase
	{
		// Token: 0x060046C8 RID: 18120 RVA: 0x001456F4 File Offset: 0x001438F4
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerable()
		{
			Il2CppClassPointerStore<IEnumerable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerable<T>>.NativeClassPtr, 100673793);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0014576C File Offset: 0x0014396C
		[CallerCount(0)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerable<T>.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0001AC32 File Offset: 0x00018E32
		public IEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IEnumerator_1_T_0;
	}
}
