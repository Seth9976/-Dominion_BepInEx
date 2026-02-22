using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200049D RID: 1181
	[Serializable]
	public class EqualityComparer<T> : Object
	{
		// Token: 0x06004664 RID: 18020 RVA: 0x00142B64 File Offset: 0x00140D64
		// Note: this type is marked as 'beforefieldinit'.
		static EqualityComparer()
		{
			Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "EqualityComparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr);
			EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, "defaultComparer");
			EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673721);
			EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673722);
			EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673723);
			EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673724);
			EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673725);
			EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673726);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673727);
			EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673728);
			EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr, 100673729);
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x00142C98 File Offset: 0x00140E98
		public unsafe static EqualityComparer<T> Default
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 363766, RefRangeEnd = 363776, XrefRangeStart = 363766, XrefRangeEnd = 363776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00142CCC File Offset: 0x00140ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363848, XrefRangeEnd = 363965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EqualityComparer<T> CreateComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr3) : null;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00142D00 File Offset: 0x00140F00
		[CallerCount(0)]
		public unsafe virtual bool Equals(T x, T y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = y;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref y;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00142DD8 File Offset: 0x00140FD8
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00142E68 File Offset: 0x00141068
		[CallerCount(0)]
		public unsafe virtual int IndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00142F24 File Offset: 0x00141124
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(Il2CppArrayBase<T> array, T value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EqualityComparer<T>.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00142FE0 File Offset: 0x001411E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363965, XrefRangeEnd = 363968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IEqualityComparer_GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00143030 File Offset: 0x00141230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363968, XrefRangeEnd = 363976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00143090 File Offset: 0x00141290
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EqualityComparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EqualityComparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x0001ABAB File Offset: 0x00018DAB
		public EqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x001430CC File Offset: 0x001412CC
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x0001ABB4 File Offset: 0x00018DB4
		public unsafe static EqualityComparer<T> defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EqualityComparer<T>.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_EqualityComparer_1_T_0;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeMethodInfoPtr_CreateComparer_Private_Static_EqualityComparer_1_T_0;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_T_T_0;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_T_0;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_New_Int32_Il2CppArrayBase_1_T_T_Int32_Int32_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
