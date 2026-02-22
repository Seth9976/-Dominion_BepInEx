using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000053 RID: 83
	[Serializable]
	public sealed class ValueTuple<T1, T2, T3, T4> : ValueType
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x00036F60 File Offset: 0x00035160
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueTuple`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr);
			ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, "Item1");
			ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, "Item2");
			ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, "Item3");
			ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, "Item4");
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664046);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664047);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_4_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664048);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664049);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664050);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_4_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664051);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664052);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664053);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664054);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664055);
			ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr, 100664056);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00037130 File Offset: 0x00035330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266877, RefRangeEnd = 266878, XrefRangeStart = 266877, XrefRangeEnd = 266877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00037290 File Offset: 0x00035490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266878, XrefRangeEnd = 266881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000372E4 File Offset: 0x000354E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266881, XrefRangeEnd = 266893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTuple<T1, T2, T3, T4> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_4_T1_T2_T3_T4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0003733C File Offset: 0x0003553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266893, XrefRangeEnd = 266921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000373A0 File Offset: 0x000355A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266921, XrefRangeEnd = 266929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000373F4 File Offset: 0x000355F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266941, RefRangeEnd = 266942, XrefRangeStart = 266929, XrefRangeEnd = 266941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ValueTuple<T1, T2, T3, T4> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_4_T1_T2_T3_T4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0003744C File Offset: 0x0003564C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266942, XrefRangeEnd = 266970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000374B0 File Offset: 0x000356B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266970, XrefRangeEnd = 266975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000374F4 File Offset: 0x000356F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266975, XrefRangeEnd = 266977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00037548 File Offset: 0x00035748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266993, RefRangeEnd = 266994, XrefRangeStart = 266977, XrefRangeEnd = 266993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeCore(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0003759C File Offset: 0x0003579C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266994, XrefRangeEnd = 267023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3, T4>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00003E53 File Offset: 0x00002053
		public ValueTuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00003E5C File Offset: 0x0000205C
		public ValueTuple()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3, T4>>.NativeClassPtr))
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000375D8 File Offset: 0x000357D8
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00037600 File Offset: 0x00035800
		public unsafe T1 Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item1);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item1);
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

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000376A8 File Offset: 0x000358A8
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x000376D0 File Offset: 0x000358D0
		public unsafe T2 Item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item2);
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00037778 File Offset: 0x00035978
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000377A0 File Offset: 0x000359A0
		public unsafe T3 Item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item3);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item3);
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

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00037848 File Offset: 0x00035A48
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00037870 File Offset: 0x00035A70
		public unsafe T4 Item4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item4);
				return IL2CPP.PointerToValueGeneric<T4>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3, T4>.NativeFieldInfoPtr_Item4);
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

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeFieldInfoPtr_Item1;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeFieldInfoPtr_Item2;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeFieldInfoPtr_Item3;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeFieldInfoPtr_Item4;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_T4_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_4_T1_T2_T3_T4_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_4_T1_T2_T3_T4_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
