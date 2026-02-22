using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public class Comparer<T> : Object
	{
		// Token: 0x06004647 RID: 17991 RVA: 0x00142124 File Offset: 0x00140324
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Comparer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr);
			Comparer<T>.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, "defaultComparer");
			Comparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100673704);
			Comparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100673705);
			Comparer<T>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100673706);
			Comparer<T>.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100673707);
			Comparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr, 100673708);
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x00142208 File Offset: 0x00140408
		public unsafe static Comparer<T> Default
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 363766, RefRangeEnd = 363776, XrefRangeStart = 363757, XrefRangeEnd = 363766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x0014223C File Offset: 0x0014043C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363776, XrefRangeEnd = 363824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Comparer<T> CreateComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr3) : null;
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x00142270 File Offset: 0x00140470
		[CallerCount(0)]
		public unsafe virtual int Compare(T x, T y)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Comparer<T>.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x00142348 File Offset: 0x00140548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363824, XrefRangeEnd = 363832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IComparer_Compare(Object x, Object y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600464C RID: 17996 RVA: 0x001423A8 File Offset: 0x001405A8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x0001AB6C File Offset: 0x00018D6C
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x001423E4 File Offset: 0x001405E4
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x0001AB75 File Offset: 0x00018D75
		public unsafe static Comparer<T> defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer<T>.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer<T>.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_Comparer_1_T_0;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeMethodInfoPtr_CreateComparer_Private_Static_Comparer_1_T_0;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_T_T_0;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
