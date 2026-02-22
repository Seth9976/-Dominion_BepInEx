using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000A RID: 10
	public class IOrderedEnumerable<TElement> : Il2CppObjectBase
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00005198 File Offset: 0x00003398
		// Note: this type is marked as 'beforefieldinit'.
		static IOrderedEnumerable()
		{
			Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "IOrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IOrderedEnumerable<TElement>.NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOrderedEnumerable<TElement>>.NativeClassPtr, 100663463);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005210 File Offset: 0x00003410
		[CallerCount(0)]
		public unsafe virtual IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOrderedEnumerable<TKey>.MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000221D File Offset: 0x0000041D
		public IOrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x0200003F RID: 63
		private sealed class MethodInfoStoreGeneric_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
		{
			// Token: 0x04000166 RID: 358
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IOrderedEnumerable<TKey>.NativeMethodInfoPtr_CreateOrderedEnumerable_Public_Abstract_Virtual_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<IOrderedEnumerable<TKey>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) }))));
		}
	}
}
