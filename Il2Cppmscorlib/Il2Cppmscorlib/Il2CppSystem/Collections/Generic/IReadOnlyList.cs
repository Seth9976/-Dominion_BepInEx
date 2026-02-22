using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004B0 RID: 1200
	public class IReadOnlyList<T> : Il2CppObjectBase
	{
		// Token: 0x060046DF RID: 18143 RVA: 0x00145FB0 File Offset: 0x001441B0
		// Note: this type is marked as 'beforefieldinit'.
		static IReadOnlyList()
		{
			Il2CppClassPointerStore<IReadOnlyList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IReadOnlyList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IReadOnlyList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IReadOnlyList<T>>.NativeClassPtr, 100673804);
		}

		// Token: 0x170011E5 RID: 4581
		public unsafe virtual T this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IReadOnlyList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0001AC68 File Offset: 0x00018E68
		public IReadOnlyList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400397E RID: 14718
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0;
	}
}
