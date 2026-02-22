using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000052 RID: 82
	[Serializable]
	public sealed class ValueTuple<T1, T2, T3> : ValueType
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x000366E8 File Offset: 0x000348E8
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTuple()
		{
			Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ValueTuple`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr);
			ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, "Item1");
			ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, "Item2");
			ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, "Item3");
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664035);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664036);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664037);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664038);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664039);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664040);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664041);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664042);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664043);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664044);
			ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr, 100664045);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00036890 File Offset: 0x00034A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266758, RefRangeEnd = 266759, XrefRangeStart = 266758, XrefRangeEnd = 266758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple(T1 item1, T2 item2, T3 item3)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr))
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000369A8 File Offset: 0x00034BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266759, XrefRangeEnd = 266762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000369FC File Offset: 0x00034BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266762, XrefRangeEnd = 266771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTuple<T1, T2, T3> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_3_T1_T2_T3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00036A54 File Offset: 0x00034C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266771, XrefRangeEnd = 266791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00036AB8 File Offset: 0x00034CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266791, XrefRangeEnd = 266799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IComparable_CompareTo(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00036B0C File Offset: 0x00034D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 266808, RefRangeEnd = 266809, XrefRangeStart = 266799, XrefRangeEnd = 266808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ValueTuple<T1, T2, T3> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_3_T1_T2_T3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00036B64 File Offset: 0x00034D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266809, XrefRangeEnd = 266829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00036BC8 File Offset: 0x00034DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266829, XrefRangeEnd = 266832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00036C0C File Offset: 0x00034E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266832, XrefRangeEnd = 266842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_IStructuralEquatable_GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00036C60 File Offset: 0x00034E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266842, XrefRangeEnd = 266853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeCore(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00036CB4 File Offset: 0x00034EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266853, XrefRangeEnd = 266877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTuple<T1, T2, T3>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00003E38 File Offset: 0x00002038
		public ValueTuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003E41 File Offset: 0x00002041
		public ValueTuple()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTuple<T1, T2, T3>>.NativeClassPtr))
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00036CF0 File Offset: 0x00034EF0
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00036D18 File Offset: 0x00034F18
		public unsafe T1 Item1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item1);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item1);
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00036DC0 File Offset: 0x00034FC0
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00036DE8 File Offset: 0x00034FE8
		public unsafe T2 Item2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item2);
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00036E90 File Offset: 0x00035090
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x00036EB8 File Offset: 0x000350B8
		public unsafe T3 Item3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item3);
				return IL2CPP.PointerToValueGeneric<T3>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueTuple<T1, T2, T3>.NativeFieldInfoPtr_Item3);
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

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_Item1;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_Item2;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_Item3;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T1_T2_T3_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_3_T1_T2_T3_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_Equals_Private_Virtual_Final_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ValueTuple_3_T1_T2_T3_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_IComparer_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IStructuralEquatable_GetHashCode_Private_Virtual_Final_New_Int32_IEqualityComparer_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeCore_Private_Int32_IEqualityComparer_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
