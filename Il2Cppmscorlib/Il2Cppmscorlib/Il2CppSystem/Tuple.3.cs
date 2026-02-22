using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000059 RID: 89
	[Serializable]
	public class Tuple<T1, T2, T3> : Object
	{
		// Token: 0x06000606 RID: 1542 RVA: 0x0003D214 File Offset: 0x0003B414
		// Note: this type is marked as 'beforefieldinit'.
		static Tuple()
		{
			Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Tuple`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr);
			Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, "m_Item1");
			Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, "m_Item2");
			Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, "m_Item3");
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item1_Public_get_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664276);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item2_Public_get_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664277);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item3_Public_get_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664278);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664279);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664280);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664281);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664282);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664283);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664284);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664285);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664286);
			Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_ITupleInternal_ToString_Private_Virtual_Final_New_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr, 100664287);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0003D3D0 File Offset: 0x0003B5D0
		public unsafe T1 Item1
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item1_Public_get_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0003D40C File Offset: 0x0003B60C
		public unsafe T2 Item2
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item2_Public_get_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0003D448 File Offset: 0x0003B648
		public unsafe T3 Item3
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_get_Item3_Public_get_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, false, true);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0003D484 File Offset: 0x0003B684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274788, RefRangeEnd = 274789, XrefRangeStart = 274787, XrefRangeEnd = 274788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple(T1 item1, T2 item2, T3 item3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple<T1, T2, T3>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0003D598 File Offset: 0x0003B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274789, XrefRangeEnd = 274796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0003D5F0 File Offset: 0x0003B7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274796, XrefRangeEnd = 274806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IStructuralEquatable_Equals(Object other, IEqualityComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0003D650 File Offset: 0x0003B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274806, XrefRangeEnd = 274813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_IComparable_CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0003D6A0 File Offset: 0x0003B8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274813, XrefRangeEnd = 274823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralComparable_CompareTo(Object other, IComparer comparer)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0003D700 File Offset: 0x0003B900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274823, XrefRangeEnd = 274831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0003D748 File Offset: 0x0003B948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274831, XrefRangeEnd = 274840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0003D798 File Offset: 0x0003B998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274840, XrefRangeEnd = 274851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tuple<T1, T2, T3>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0003D7DC File Offset: 0x0003B9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274851, XrefRangeEnd = 274861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ITupleInternal_ToString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple<T1, T2, T3>.NativeMethodInfoPtr_System_ITupleInternal_ToString_Private_Virtual_Final_New_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00003F40 File Offset: 0x00002140
		public Tuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0003D824 File Offset: 0x0003BA24
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x0003D84C File Offset: 0x0003BA4C
		public unsafe T1 m_Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item1);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item1);
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

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x0003D91C File Offset: 0x0003BB1C
		public unsafe T2 m_Item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item2);
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0003D9EC File Offset: 0x0003BBEC
		public unsafe T3 m_Item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item3);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple<T1, T2, T3>.NativeFieldInfoPtr_m_Item3);
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

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_Item1;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_Item2;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_Item3;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_Item1_Public_get_T1_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_get_Item2_Public_get_T2_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_get_Item3_Public_get_T3_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_System_ITupleInternal_ToString_Private_Virtual_Final_New_String_StringBuilder_0;
	}
}
