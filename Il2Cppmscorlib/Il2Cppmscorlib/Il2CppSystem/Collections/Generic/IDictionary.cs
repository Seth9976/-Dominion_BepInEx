using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A9 RID: 1193
	public class IDictionary<TKey, TValue> : Il2CppObjectBase
	{
		// Token: 0x060046C3 RID: 18115 RVA: 0x001453CC File Offset: 0x001435CC
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionary()
		{
			Il2CppClassPointerStore<IDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary<TKey, TValue>>.NativeClassPtr, 100673790);
			IDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary<TKey, TValue>>.NativeClassPtr, 100673791);
			IDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary<TKey, TValue>>.NativeClassPtr, 100673792);
		}

		// Token: 0x170011E1 RID: 4577
		public unsafe virtual TKey this[TKey key]
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_TKey_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x00145548 File Offset: 0x00143748
		[CallerCount(0)]
		public unsafe virtual void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_TKey_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x00145614 File Offset: 0x00143814
		[CallerCount(0)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0001AC29 File Offset: 0x00018E29
		public IDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_TKey_TValue_0;

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_TKey_TValue_0;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Abstract_Virtual_New_Boolean_TKey_byref_TValue_0;
	}
}
