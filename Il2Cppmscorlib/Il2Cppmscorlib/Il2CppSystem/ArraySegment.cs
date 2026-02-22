using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000079 RID: 121
	[Serializable]
	public sealed class ArraySegment<T> : ValueType
	{
		// Token: 0x06000732 RID: 1842 RVA: 0x00042474 File Offset: 0x00040674
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySegment()
		{
			Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArraySegment`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr);
			ArraySegment<T>.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, "_array");
			ArraySegment<T>.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, "_offset");
			ArraySegment<T>.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, "_count");
			ArraySegment<T>.NativeMethodInfoPtr_get_Array_Public_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664413);
			ArraySegment<T>.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664414);
			ArraySegment<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664415);
			ArraySegment<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664416);
			ArraySegment<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664417);
			ArraySegment<T>.NativeMethodInfoPtr_Equals_Public_Boolean_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664418);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664419);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664420);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664421);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664422);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664423);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IReadOnlyList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664424);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664425);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664426);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664427);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664428);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664429);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664430);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664431);
			ArraySegment<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, 100664432);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x000426AC File Offset: 0x000408AC
		public unsafe Il2CppArrayBase<T> Array
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_get_Array_Public_get_Il2CppArrayBase_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000426E8 File Offset: 0x000408E8
		public unsafe int Offset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x0004272C File Offset: 0x0004092C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00042770 File Offset: 0x00040970
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000427B4 File Offset: 0x000409B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276246, XrefRangeEnd = 276253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00042808 File Offset: 0x00040A08
		[CallerCount(0)]
		public unsafe bool Equals(ArraySegment<T> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_Equals_Public_Boolean_ArraySegment_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00042860 File Offset: 0x00040A60
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x000428AC File Offset: 0x00040AAC
		public unsafe T System.Collections.Generic.IList<T>.Item
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00042938 File Offset: 0x00040B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276253, XrefRangeEnd = 276256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_Collections_Generic_IList_T__IndexOf(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x000429C0 File Offset: 0x00040BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276256, XrefRangeEnd = 276266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_IList_T__Insert(int index, T item)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00042A4C File Offset: 0x00040C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276266, XrefRangeEnd = 276276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_IList_T__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00042A90 File Offset: 0x00040C90
		public unsafe T System.Collections.Generic.IReadOnlyList<T>.Item
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IReadOnlyList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00042ADC File Offset: 0x00040CDC
		public unsafe bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00042B20 File Offset: 0x00040D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276276, XrefRangeEnd = 276286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_ICollection_T__Add(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00042BA0 File Offset: 0x00040DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276286, XrefRangeEnd = 276294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_ICollection_T__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00042BD8 File Offset: 0x00040DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276294, XrefRangeEnd = 276297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_Generic_ICollection_T__Contains(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00042C60 File Offset: 0x00040E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276297, XrefRangeEnd = 276298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_Generic_ICollection_T__CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00042CB8 File Offset: 0x00040EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276298, XrefRangeEnd = 276303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_Generic_ICollection_T__Remove(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00042D40 File Offset: 0x00040F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276303, XrefRangeEnd = 276309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00042D84 File Offset: 0x00040F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276309, XrefRangeEnd = 276315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00004508 File Offset: 0x00002708
		public ArraySegment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00004511 File Offset: 0x00002711
		public ArraySegment()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00042DC8 File Offset: 0x00040FC8
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00004523 File Offset: 0x00002723
		public unsafe Il2CppArrayBase<T> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00042DF0 File Offset: 0x00040FF0
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00004542 File Offset: 0x00002742
		public unsafe int _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00042E18 File Offset: 0x00041018
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0000455D File Offset: 0x0000275D
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_get_Array_Public_get_Il2CppArrayBase_1_T_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Int32_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ArraySegment_1_T_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__set_Item_Private_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__IndexOf_Private_Virtual_Final_New_Int32_T_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__Insert_Private_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_T__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IReadOnlyList_T__get_Item_Private_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Add_Private_Virtual_Final_New_Void_T_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Contains_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__CopyTo_Private_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__Remove_Private_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200058C RID: 1420
		[Serializable]
		public sealed class ArraySegmentEnumerator : Object
		{
			// Token: 0x06004ECB RID: 20171 RVA: 0x00163270 File Offset: 0x00161470
			// Note: this type is marked as 'beforefieldinit'.
			static ArraySegmentEnumerator()
			{
				Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArraySegment<T>>.NativeClassPtr, "ArraySegmentEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr);
				ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, "_array");
				ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, "_start");
				ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, "_end");
				ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, "_current");
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ArraySegment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664433);
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664434);
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664435);
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664436);
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664437);
				ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr, 100664438);
			}

			// Token: 0x06004ECC RID: 20172 RVA: 0x001633A0 File Offset: 0x001615A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276243, XrefRangeEnd = 276244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArraySegmentEnumerator(ArraySegment<T> arraySegment)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySegment<T>.ArraySegmentEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arraySegment));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ArraySegment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004ECD RID: 20173 RVA: 0x001633F0 File Offset: 0x001615F0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001404 RID: 5124
			// (get) Token: 0x06004ECE RID: 20174 RVA: 0x0016342C File Offset: 0x0016162C
			public unsafe T Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x17001405 RID: 5125
			// (get) Token: 0x06004ECF RID: 20175 RVA: 0x00163468 File Offset: 0x00161668
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276244, XrefRangeEnd = 276246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004ED0 RID: 20176 RVA: 0x001634A8 File Offset: 0x001616A8
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED1 RID: 20177 RVA: 0x001634DC File Offset: 0x001616DC
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySegment<T>.ArraySegmentEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004ED2 RID: 20178 RVA: 0x0001DC3D File Offset: 0x0001BE3D
			public ArraySegmentEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001400 RID: 5120
			// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x00163510 File Offset: 0x00161710
			// (set) Token: 0x06004ED4 RID: 20180 RVA: 0x0001DC46 File Offset: 0x0001BE46
			public unsafe Il2CppArrayBase<T> _array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001401 RID: 5121
			// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x00163538 File Offset: 0x00161738
			// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x0001DC65 File Offset: 0x0001BE65
			public unsafe int _start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__start)) = value;
				}
			}

			// Token: 0x17001402 RID: 5122
			// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x00163560 File Offset: 0x00161760
			// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x0001DC80 File Offset: 0x0001BE80
			public unsafe int _end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__end)) = value;
				}
			}

			// Token: 0x17001403 RID: 5123
			// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x00163588 File Offset: 0x00161788
			// (set) Token: 0x06004EDA RID: 20186 RVA: 0x0001DC9B File Offset: 0x0001BE9B
			public unsafe int _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySegment<T>.ArraySegmentEnumerator.NativeFieldInfoPtr__current)) = value;
				}
			}

			// Token: 0x04003F98 RID: 16280
			private static readonly IntPtr NativeFieldInfoPtr__array;

			// Token: 0x04003F99 RID: 16281
			private static readonly IntPtr NativeFieldInfoPtr__start;

			// Token: 0x04003F9A RID: 16282
			private static readonly IntPtr NativeFieldInfoPtr__end;

			// Token: 0x04003F9B RID: 16283
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x04003F9C RID: 16284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArraySegment_1_T_0;

			// Token: 0x04003F9D RID: 16285
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F9E RID: 16286
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04003F9F RID: 16287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FA0 RID: 16288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FA1 RID: 16289
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}
