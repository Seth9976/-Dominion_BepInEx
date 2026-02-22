using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049F RID: 1183
	[Serializable]
	public class NullableEqualityComparer<T> : EqualityComparer<Nullable<T>> where T : new()
	{
		// Token: 0x0600467A RID: 18042 RVA: 0x001435A8 File Offset: 0x001417A8
		// Note: this type is marked as 'beforefieldinit'.
		static NullableEqualityComparer()
		{
			Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "NullableEqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673737);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673738);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673739);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673740);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673741);
			NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673742);
			NullableEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr, 100673743);
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x001436A0 File Offset: 0x001418A0
		[CallerCount(0)]
		public unsafe override bool Equals(Nullable<T> x, Nullable<T> y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x00143714 File Offset: 0x00141914
		[CallerCount(0)]
		public unsafe override int GetHashCode(Nullable<T> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00143774 File Offset: 0x00141974
		[CallerCount(0)]
		public unsafe override int IndexOf(Il2CppReferenceArray<Nullable<T>> array, Nullable<T> value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x00143800 File Offset: 0x00141A00
		[CallerCount(0)]
		public unsafe override int LastIndexOf(Il2CppReferenceArray<Nullable<T>> array, Nullable<T> value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x0014388C File Offset: 0x00141A8C
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x001438E4 File Offset: 0x00141AE4
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableEqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x0014392C File Offset: 0x00141B2C
		[CallerCount(0)]
		public unsafe NullableEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableEqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableEqualityComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x0001ABCF File Offset: 0x00018DCF
		public NullableEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Nullable_1_T_Nullable_1_T_0;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Nullable_1_T_0;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppReferenceArray_1_Nullable_1_T_Nullable_1_T_Int32_Int32_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003940 RID: 14656
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003941 RID: 14657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
