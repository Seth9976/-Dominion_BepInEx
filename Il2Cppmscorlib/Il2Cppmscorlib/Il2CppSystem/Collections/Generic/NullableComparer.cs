using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049A RID: 1178
	[Serializable]
	public class NullableComparer<T> : Comparer<Nullable<T>> where T : new()
	{
		// Token: 0x06004656 RID: 18006 RVA: 0x0014267C File Offset: 0x0014087C
		// Note: this type is marked as 'beforefieldinit'.
		static NullableComparer()
		{
			Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "NullableComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr);
			NullableComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Nullable_1_T_Nullable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr, 100673713);
			NullableComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr, 100673714);
			NullableComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr, 100673715);
			NullableComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr, 100673716);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x00142738 File Offset: 0x00140938
		[CallerCount(0)]
		public unsafe override int Compare(Nullable<T> x, Nullable<T> y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableComparer<T>.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Nullable_1_T_Nullable_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x001427AC File Offset: 0x001409AC
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableComparer<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00142804 File Offset: 0x00140A04
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NullableComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x0014284C File Offset: 0x00140A4C
		[CallerCount(0)]
		public unsafe NullableComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullableComparer<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0001AB90 File Offset: 0x00018D90
		public NullableComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Nullable_1_T_Nullable_1_T_0;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
