using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004AD RID: 1197
	public class IList<T> : Il2CppObjectBase
	{
		// Token: 0x060046D2 RID: 18130 RVA: 0x00145A68 File Offset: 0x00143C68
		// Note: this type is marked as 'beforefieldinit'.
		static IList()
		{
			Il2CppClassPointerStore<IList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IList`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList<T>>.NativeClassPtr, 100673797);
			IList<T>.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList<T>>.NativeClassPtr, 100673798);
			IList<T>.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList<T>>.NativeClassPtr, 100673799);
			IList<T>.NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList<T>>.NativeClassPtr, 100673800);
			IList<T>.NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList<T>>.NativeClassPtr, 100673801);
		}

		// Token: 0x170011E3 RID: 4579
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList<T>.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList<T>.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x00145C18 File Offset: 0x00143E18
		[CallerCount(0)]
		public unsafe virtual int IndexOf(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList<T>.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00145CA8 File Offset: 0x00143EA8
		[CallerCount(0)]
		public unsafe virtual void Insert(int index, T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList<T>.NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00145D3C File Offset: 0x00143F3C
		[CallerCount(0)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList<T>.NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0001AC4D File Offset: 0x00018E4D
		public IList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_T_Int32_0;

		// Token: 0x04003978 RID: 14712
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_T_0;

		// Token: 0x04003979 RID: 14713
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_T_0;

		// Token: 0x0400397A RID: 14714
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_T_0;

		// Token: 0x0400397B RID: 14715
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
