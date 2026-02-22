using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000054 RID: 84
	[Serializable]
	public sealed class ValueTuple<T1, T2, T3, T4, T5> : ValueType
	{
		// Token: 0x06000531 RID: 1329 RVA: 0x00037918 File Offset: 0x00035B18
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueTuple`5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr);
			ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, "Item1");
			ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, "Item2");
			ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, "Item3");
			ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, "Item4");
			ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, "Item5");
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664057);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664058);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_5_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664059);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664060);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664061);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_5_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664062);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664063);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664064);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664065);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664066);
			ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr, 100664067);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00037B0C File Offset: 0x00035D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267023, RefRangeEnd = 267025, XrefRangeStart = 267023, XrefRangeEnd = 267023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = item1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = item2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = item3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref item3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = item4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref item4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = item5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref item5;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00037CB4 File Offset: 0x00035EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267025, XrefRangeEnd = 267028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00037D08 File Offset: 0x00035F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267028, XrefRangeEnd = 267043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_5_T1_T2_T3_T4_T5_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00037D60 File Offset: 0x00035F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267043, XrefRangeEnd = 267073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00037DC4 File Offset: 0x00035FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267073, XrefRangeEnd = 267081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00037E18 File Offset: 0x00036018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267096, RefRangeEnd = 267097, XrefRangeStart = 267081, XrefRangeEnd = 267096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ValueTuple<T1, T2, T3, T4, T5> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_5_T1_T2_T3_T4_T5_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00037E70 File Offset: 0x00036070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267097, XrefRangeEnd = 267126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00037ED4 File Offset: 0x000360D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267126, XrefRangeEnd = 267132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00037F18 File Offset: 0x00036118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267132, XrefRangeEnd = 267134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00037F6C File Offset: 0x0003616C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267152, RefRangeEnd = 267153, XrefRangeStart = 267134, XrefRangeEnd = 267152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeCore(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00037FC0 File Offset: 0x000361C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267153, XrefRangeEnd = 267187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4, T5>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00003E6E File Offset: 0x0000206E
		public ValueTuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00003E77 File Offset: 0x00002077
		public ValueTuple()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4, T5>>.NativeClassPtr))
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00037FFC File Offset: 0x000361FC
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00038024 File Offset: 0x00036224
		public unsafe T1 Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item1);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item1);
				Type typeFromHandle = typeof(T1);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000380CC File Offset: 0x000362CC
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000380F4 File Offset: 0x000362F4
		public unsafe T2 Item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item2);
				Type typeFromHandle = typeof(T2);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0003819C File Offset: 0x0003639C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000381C4 File Offset: 0x000363C4
		public unsafe T3 Item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item3);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item3);
				Type typeFromHandle = typeof(T3);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0003826C File Offset: 0x0003646C
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00038294 File Offset: 0x00036494
		public unsafe T4 Item4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item4);
				return IL2CPP.PointerToValueGeneric<T4>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item4);
				Type typeFromHandle = typeof(T4);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0003833C File Offset: 0x0003653C
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00038364 File Offset: 0x00036564
		public unsafe T5 Item5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item5);
				return IL2CPP.PointerToValueGeneric<T5>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4, T5>.NativeFieldInfoPtr_Item5);
				Type typeFromHandle = typeof(T5);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr_Item1;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr_Item2;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr_Item3;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr_Item4;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeFieldInfoPtr_Item5;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_T5_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_5_T1_T2_T3_T4_T5_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_5_T1_T2_T3_T4_T5_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
