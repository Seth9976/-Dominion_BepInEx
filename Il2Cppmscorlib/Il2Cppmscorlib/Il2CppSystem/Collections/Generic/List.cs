using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004B2 RID: 1202
	[Serializable]
	public class List<T> : Object
	{
		// Token: 0x060046E7 RID: 18151 RVA: 0x001461D4 File Offset: 0x001443D4
		// Note: this type is marked as 'beforefieldinit'.
		static List()
		{
			Il2CppClassPointerStore<List<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "List`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<List<T>>.NativeClassPtr);
			List<T>.NativeFieldInfoPtr__defaultCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_defaultCapacity");
			List<T>.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_items");
			List<T>.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_size");
			List<T>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_version");
			List<T>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_syncRoot");
			List<T>.NativeFieldInfoPtr__emptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "_emptyArray");
			List<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673808);
			List<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673809);
			List<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673810);
			List<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673811);
			List<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673812);
			List<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673813);
			List<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673814);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673815);
			List<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673816);
			List<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673817);
			List<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673818);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673819);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673820);
			List<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673821);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673822);
			List<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673823);
			List<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnlyCollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673824);
			List<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673825);
			List<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673826);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673827);
			List<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673828);
			List<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673829);
			List<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673830);
			List<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673831);
			List<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673832);
			List<T>.NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673833);
			List<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673834);
			List<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673835);
			List<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673836);
			List<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673837);
			List<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673838);
			List<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673839);
			List<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673840);
			List<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673841);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673842);
			List<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673843);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673844);
			List<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673845);
			List<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673846);
			List<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673847);
			List<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673848);
			List<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673849);
			List<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673850);
			List<T>.NativeMethodInfoPtr_Reverse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673851);
			List<T>.NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673852);
			List<T>.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673853);
			List<T>.NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673854);
			List<T>.NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673855);
			List<T>.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673856);
			List<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>>.NativeClassPtr, 100673857);
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x001466A0 File Offset: 0x001448A0
		[CallerCount(410)]
		[CachedScanResults(RefRangeStart = 364294, RefRangeEnd = 364704, XrefRangeStart = 364288, XrefRangeEnd = 364294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<List<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x001466DC File Offset: 0x001448DC
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 364709, RefRangeEnd = 364751, XrefRangeStart = 364704, XrefRangeEnd = 364709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<List<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00146724 File Offset: 0x00144924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364751, XrefRangeEnd = 364780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List(IEnumerable<T> collection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<List<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x00146770 File Offset: 0x00144970
		// (set) Token: 0x060046EC RID: 18156 RVA: 0x001467AC File Offset: 0x001449AC
		public unsafe int Capacity
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 364786, RefRangeEnd = 364796, XrefRangeStart = 364780, XrefRangeEnd = 364786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x001467EC File Offset: 0x001449EC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x00146828 File Offset: 0x00144A28
		public unsafe virtual bool System.Collections.Generic.ICollection<T>.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x00146864 File Offset: 0x00144A64
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011F0 RID: 4592
		public unsafe virtual T this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364796, XrefRangeEnd = 364797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 364798, RefRangeEnd = 364803, XrefRangeStart = 364797, XrefRangeEnd = 364798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x00146970 File Offset: 0x00144B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364803, XrefRangeEnd = 364806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleObject(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x001469B4 File Offset: 0x00144BB4
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00146A00 File Offset: 0x00144C00
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364806, XrefRangeEnd = 364808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364808, XrefRangeEnd = 364817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x00146A50 File Offset: 0x00144C50
		[CallerCount(416)]
		[CachedScanResults(RefRangeStart = 364817, RefRangeEnd = 365233, XrefRangeStart = 364817, XrefRangeEnd = 364817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00146AC8 File Offset: 0x00144CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365233, XrefRangeEnd = 365242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x00146B18 File Offset: 0x00144D18
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 365243, RefRangeEnd = 365280, XrefRangeStart = 365242, XrefRangeEnd = 365243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x00146B5C File Offset: 0x00144D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365282, RefRangeEnd = 365283, XrefRangeStart = 365280, XrefRangeEnd = 365282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<T> AsReadOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_AsReadOnly_Public_ReadOnlyCollection_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00146B9C File Offset: 0x00144D9C
		[CallerCount(129)]
		[CachedScanResults(RefRangeStart = 359192, RefRangeEnd = 359321, XrefRangeStart = 359192, XrefRangeEnd = 359321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x00146BD0 File Offset: 0x00144DD0
		[CallerCount(0)]
		public unsafe virtual bool Contains(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x00146C54 File Offset: 0x00144E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365283, XrefRangeEnd = 365287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00146CA4 File Offset: 0x00144EA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365288, RefRangeEnd = 365290, XrefRangeStart = 365287, XrefRangeEnd = 365288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00146CE8 File Offset: 0x00144EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365290, XrefRangeEnd = 365295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x00146D38 File Offset: 0x00144F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365297, RefRangeEnd = 365299, XrefRangeStart = 365295, XrefRangeEnd = 365297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(int index, Il2CppArrayBase<T> array, int arrayIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppArrayBase_1_T_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x00146DA4 File Offset: 0x00144FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365300, RefRangeEnd = 365301, XrefRangeStart = 365299, XrefRangeEnd = 365300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x00146DF4 File Offset: 0x00144FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365301, XrefRangeEnd = 365302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureCapacity(int min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00146E34 File Offset: 0x00145034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365302, XrefRangeEnd = 365303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Find(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00146E80 File Offset: 0x00145080
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 365303, RefRangeEnd = 365310, XrefRangeStart = 365303, XrefRangeEnd = 365303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndex(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x00146ED0 File Offset: 0x001450D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365310, XrefRangeEnd = 365313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00146F3C File Offset: 0x0014513C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365313, RefRangeEnd = 365314, XrefRangeStart = 365313, XrefRangeEnd = 365313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindLastIndex(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00146F8C File Offset: 0x0014518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365314, XrefRangeEnd = 365318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00146FF8 File Offset: 0x001451F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 365319, RefRangeEnd = 365537, XrefRangeStart = 365318, XrefRangeEnd = 365319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new List<T>.Enumerator(intPtr);
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00147030 File Offset: 0x00145230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365537, XrefRangeEnd = 365540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00147070 File Offset: 0x00145270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x001470B0 File Offset: 0x001452B0
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00147134 File Offset: 0x00145334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365540, XrefRangeEnd = 365544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00147184 File Offset: 0x00145384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365544, XrefRangeEnd = 365546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x0014720C File Offset: 0x0014540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365546, XrefRangeEnd = 365555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x0014725C File Offset: 0x0014545C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365555, XrefRangeEnd = 365581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertRange(int index, IEnumerable<T> collection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x001472AC File Offset: 0x001454AC
		[CallerCount(0)]
		public unsafe virtual bool Remove(T item)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00147330 File Offset: 0x00145530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365581, XrefRangeEnd = 365587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00147374 File Offset: 0x00145574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365587, XrefRangeEnd = 365590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RemoveAll(Predicate<T> match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x001473C4 File Offset: 0x001455C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365590, XrefRangeEnd = 365592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00147404 File Offset: 0x00145604
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 365597, RefRangeEnd = 365604, XrefRangeStart = 365592, XrefRangeEnd = 365597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRange(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00147450 File Offset: 0x00145650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365605, RefRangeEnd = 365606, XrefRangeStart = 365604, XrefRangeEnd = 365605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Reverse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00147484 File Offset: 0x00145684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365609, RefRangeEnd = 365612, XrefRangeStart = 365606, XrefRangeEnd = 365609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reverse(int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x001474D0 File Offset: 0x001456D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365612, RefRangeEnd = 365615, XrefRangeStart = 365612, XrefRangeEnd = 365612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00147504 File Offset: 0x00145704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365615, RefRangeEnd = 365616, XrefRangeStart = 365615, XrefRangeEnd = 365615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00147548 File Offset: 0x00145748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365619, RefRangeEnd = 365620, XrefRangeStart = 365616, XrefRangeEnd = 365619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(int index, int count, IComparer<T> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x001475A8 File Offset: 0x001457A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 365621, RefRangeEnd = 365628, XrefRangeStart = 365620, XrefRangeEnd = 365621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Comparison<T> comparison)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparison);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x001475EC File Offset: 0x001457EC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 365631, RefRangeEnd = 365687, XrefRangeStart = 365628, XrefRangeEnd = 365631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x0001AC7A File Offset: 0x00018E7A
		public List(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600471B RID: 18203 RVA: 0x00147624 File Offset: 0x00145824
		// (set) Token: 0x0600471C RID: 18204 RVA: 0x0001AC83 File Offset: 0x00018E83
		public unsafe static int _defaultCapacity
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(List<T>.NativeFieldInfoPtr__defaultCapacity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(List<T>.NativeFieldInfoPtr__defaultCapacity, (void*)(&value));
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x00147640 File Offset: 0x00145840
		// (set) Token: 0x0600471E RID: 18206 RVA: 0x0001AC91 File Offset: 0x00018E91
		public unsafe Il2CppArrayBase<T> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__items);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600471F RID: 18207 RVA: 0x00147668 File Offset: 0x00145868
		// (set) Token: 0x06004720 RID: 18208 RVA: 0x0001ACB0 File Offset: 0x00018EB0
		public unsafe int _size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__size)) = value;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x00147690 File Offset: 0x00145890
		// (set) Token: 0x06004722 RID: 18210 RVA: 0x0001ACCB File Offset: 0x00018ECB
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x001476B8 File Offset: 0x001458B8
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x0001ACE6 File Offset: 0x00018EE6
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x001476E8 File Offset: 0x001458E8
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x0001AD05 File Offset: 0x00018F05
		public unsafe static Il2CppArrayBase<T> _emptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(List<T>.NativeFieldInfoPtr__emptyArray, (void*)(&intPtr));
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(List<T>.NativeFieldInfoPtr__emptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003982 RID: 14722
		private static readonly IntPtr NativeFieldInfoPtr__defaultCapacity;

		// Token: 0x04003983 RID: 14723
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeFieldInfoPtr__size;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeFieldInfoPtr__emptyArray;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_T_0;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeMethodInfoPtr_set_Capacity_Public_set_Void_Int32_0;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_T__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Int32_T_0;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleObject_Private_Static_Boolean_Object_0;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Public_Void_IEnumerable_1_T_0;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnlyCollection_1_T_0;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Il2CppArrayBase_1_T_0;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCapacity_Private_Void_Int32_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_T_Predicate_1_T_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Predicate_1_T_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_FindIndex_Public_Int32_Int32_Int32_Predicate_1_T_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Predicate_1_T_0;

		// Token: 0x040039A5 RID: 14757
		private static readonly IntPtr NativeMethodInfoPtr_FindLastIndex_Public_Int32_Int32_Int32_Predicate_1_T_0;

		// Token: 0x040039A6 RID: 14758
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_T_0;

		// Token: 0x040039A7 RID: 14759
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_Final_New_Int32_T_0;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Final_New_Void_Int32_T_0;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_InsertRange_Public_Void_Int32_IEnumerable_1_T_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_T_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Int32_Predicate_1_T_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRange_Public_Void_Int32_Int32_0;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Void_0;

		// Token: 0x040039B4 RID: 14772
		private static readonly IntPtr NativeMethodInfoPtr_Reverse_Public_Void_Int32_Int32_0;

		// Token: 0x040039B5 RID: 14773
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;

		// Token: 0x040039B6 RID: 14774
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_IComparer_1_T_0;

		// Token: 0x040039B7 RID: 14775
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Int32_Int32_IComparer_1_T_0;

		// Token: 0x040039B8 RID: 14776
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Comparison_1_T_0;

		// Token: 0x040039B9 RID: 14777
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x02000669 RID: 1641
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005667 RID: 22119 RVA: 0x0017D4C8 File Offset: 0x0017B6C8
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<List<T>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr);
				List<T>.Enumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, "list");
				List<T>.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, "index");
				List<T>.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, "version");
				List<T>.Enumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, "current");
				List<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673859);
				List<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673860);
				List<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673861);
				List<T>.Enumerator.NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673862);
				List<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673863);
				List<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673864);
				List<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, 100673865);
			}

			// Token: 0x06005668 RID: 22120 RVA: 0x0017D60C File Offset: 0x0017B80C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 364052, RefRangeEnd = 364054, XrefRangeStart = 364052, XrefRangeEnd = 364052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(List<T> list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005669 RID: 22121 RVA: 0x0017D65C File Offset: 0x0017B85C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600566A RID: 22122 RVA: 0x0017D694 File Offset: 0x0017B894
			[CallerCount(227)]
			[CachedScanResults(RefRangeStart = 364054, RefRangeEnd = 364281, XrefRangeStart = 364054, XrefRangeEnd = 364054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600566B RID: 22123 RVA: 0x0017D6D8 File Offset: 0x0017B8D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364281, XrefRangeEnd = 364282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNextRare()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700163D RID: 5693
			// (get) Token: 0x0600566C RID: 22124 RVA: 0x0017D71C File Offset: 0x0017B91C
			public unsafe T Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x1700163E RID: 5694
			// (get) Token: 0x0600566D RID: 22125 RVA: 0x0017D75C File Offset: 0x0017B95C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364282, XrefRangeEnd = 364287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600566E RID: 22126 RVA: 0x0017D7A0 File Offset: 0x0017B9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364287, XrefRangeEnd = 364288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(List<T>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600566F RID: 22127 RVA: 0x000215CE File Offset: 0x0001F7CE
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005670 RID: 22128 RVA: 0x000215D7 File Offset: 0x0001F7D7
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17001639 RID: 5689
			// (get) Token: 0x06005671 RID: 22129 RVA: 0x0017D7D8 File Offset: 0x0017B9D8
			// (set) Token: 0x06005672 RID: 22130 RVA: 0x000215E9 File Offset: 0x0001F7E9
			public unsafe List<T> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700163A RID: 5690
			// (get) Token: 0x06005673 RID: 22131 RVA: 0x0017D808 File Offset: 0x0017BA08
			// (set) Token: 0x06005674 RID: 22132 RVA: 0x00021608 File Offset: 0x0001F808
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700163B RID: 5691
			// (get) Token: 0x06005675 RID: 22133 RVA: 0x0017D830 File Offset: 0x0017BA30
			// (set) Token: 0x06005676 RID: 22134 RVA: 0x00021623 File Offset: 0x0001F823
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x1700163C RID: 5692
			// (get) Token: 0x06005677 RID: 22135 RVA: 0x0017D858 File Offset: 0x0017BA58
			// (set) Token: 0x06005678 RID: 22136 RVA: 0x0017D880 File Offset: 0x0017BA80
			public unsafe T current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(List<T>.Enumerator.NativeFieldInfoPtr_current);
					Type typeFromHandle = typeof(T);
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

			// Token: 0x04004540 RID: 17728
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004541 RID: 17729
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04004542 RID: 17730
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04004543 RID: 17731
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x04004544 RID: 17732
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_T_0;

			// Token: 0x04004545 RID: 17733
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004546 RID: 17734
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004547 RID: 17735
			private static readonly IntPtr NativeMethodInfoPtr_MoveNextRare_Private_Boolean_0;

			// Token: 0x04004548 RID: 17736
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_T_0;

			// Token: 0x04004549 RID: 17737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400454A RID: 17738
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
