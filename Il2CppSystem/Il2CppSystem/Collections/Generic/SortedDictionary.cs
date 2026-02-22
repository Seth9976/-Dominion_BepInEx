using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020000B2 RID: 178
	[Serializable]
	public class SortedDictionary<TKey, TValue> : Object
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00038F10 File Offset: 0x00037110
		// Note: this type is marked as 'beforefieldinit'.
		static SortedDictionary()
		{
			Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Generic", "SortedDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr);
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_keys");
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_values");
			SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "_set");
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664760);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664761);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664762);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664763);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664764);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664765);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664766);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664767);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664768);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664769);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664770);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664771);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664772);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664773);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664774);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664775);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664776);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664777);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664778);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664779);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664780);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664781);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664782);
			SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, 100664783);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000391AC File Offset: 0x000373AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45276, RefRangeEnd = 45277, XrefRangeStart = 45275, XrefRangeEnd = 45276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x000391E8 File Offset: 0x000373E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45277, XrefRangeEnd = 45282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary(IComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00039234 File Offset: 0x00037434
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003927C File Offset: 0x0003747C
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000392D0 File Offset: 0x000374D0
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00039324 File Offset: 0x00037524
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033A RID: 826
		public unsafe virtual TKey this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45282, XrefRangeEnd = 45284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = key;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref key;
					}
					ptr2 = intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr2 = ref value;
				}
				ptr3 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00039420 File Offset: 0x00037620
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45284, XrefRangeEnd = 45285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0003945C File Offset: 0x0003765C
		public unsafe SortedDictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45285, XrefRangeEnd = 45287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003949C File Offset: 0x0003769C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 45288, RefRangeEnd = 45297, XrefRangeStart = 45287, XrefRangeEnd = 45288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr2 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003955C File Offset: 0x0003775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45297, XrefRangeEnd = 45298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00039590 File Offset: 0x00037790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45298, XrefRangeEnd = 45299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00039614 File Offset: 0x00037814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45299, XrefRangeEnd = 45300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00039664 File Offset: 0x00037864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45301, RefRangeEnd = 45302, XrefRangeStart = 45300, XrefRangeEnd = 45301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortedDictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new SortedDictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0003969C File Offset: 0x0003789C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45302, XrefRangeEnd = 45305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000396DC File Offset: 0x000378DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45305, XrefRangeEnd = 45306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref key;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			IntPtr intPtr3;
			if (!typeof(TValue).IsValueType)
			{
				intPtr2 = 0;
				intPtr3 = &intPtr2;
			}
			else
			{
				intPtr3 = ref value;
			}
			ptr3 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000397B0 File Offset: 0x000379B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45306, XrefRangeEnd = 45311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x00039800 File Offset: 0x00037A00
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45311, XrefRangeEnd = 45312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00039840 File Offset: 0x00037A40
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x00039890 File Offset: 0x00037A90
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45312, XrefRangeEnd = 45315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45315, XrefRangeEnd = 45319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x000398E4 File Offset: 0x00037AE4
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00039934 File Offset: 0x00037B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45319, XrefRangeEnd = 45322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00039978 File Offset: 0x00037B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45322, XrefRangeEnd = 45325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x000399B8 File Offset: 0x00037BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00006404 File Offset: 0x00004604
		public SortedDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x000399F8 File Offset: 0x00037BF8
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0000640D File Offset: 0x0000460D
		public unsafe SortedDictionary<TKey, TValue>.KeyCollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00039A28 File Offset: 0x00037C28
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0000642C File Offset: 0x0000462C
		public unsafe SortedDictionary<TKey, TValue>.ValueCollection _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00039A58 File Offset: 0x00037C58
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x0000644B File Offset: 0x0000464B
		public unsafe TreeSet<KeyValuePair<TKey, TValue>> _set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TreeSet<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.NativeFieldInfoPtr__set), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr__set;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020001A1 RID: 417
		public sealed class Enumerator : ValueType
		{
			// Token: 0x060017D8 RID: 6104 RVA: 0x00066BF8 File Offset: 0x00064DF8
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_treeEnum");
				SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "_getEnumeratorRetType");
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664784);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664785);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664786);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664787);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664788);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664789);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664790);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664791);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664792);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664793);
				SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100664794);
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00066D74 File Offset: 0x00064F74
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 44822, RefRangeEnd = 44826, XrefRangeStart = 44819, XrefRangeEnd = 44822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(SortedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x00066DD4 File Offset: 0x00064FD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44831, RefRangeEnd = 44832, XrefRangeStart = 44826, XrefRangeEnd = 44831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060017DB RID: 6107 RVA: 0x00066E18 File Offset: 0x00065018
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44835, RefRangeEnd = 44837, XrefRangeStart = 44832, XrefRangeEnd = 44835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A7 RID: 1959
			// (get) Token: 0x060017DC RID: 6108 RVA: 0x00066E50 File Offset: 0x00065050
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 44839, RefRangeEnd = 44840, XrefRangeStart = 44837, XrefRangeEnd = 44839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x170007A8 RID: 1960
			// (get) Token: 0x060017DD RID: 6109 RVA: 0x00066E8C File Offset: 0x0006508C
			public unsafe bool NotStartedOrEnded
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44840, XrefRangeEnd = 44842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x00066ED0 File Offset: 0x000650D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44842, XrefRangeEnd = 44850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017DF RID: 6111 RVA: 0x00066F08 File Offset: 0x00065108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007A9 RID: 1961
			// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00066F40 File Offset: 0x00065140
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44850, XrefRangeEnd = 44867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007AA RID: 1962
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00066F84 File Offset: 0x00065184
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44867, XrefRangeEnd = 44874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007AB RID: 1963
			// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00066FC8 File Offset: 0x000651C8
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44874, XrefRangeEnd = 44881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170007AC RID: 1964
			// (get) Token: 0x060017E3 RID: 6115 RVA: 0x0006700C File Offset: 0x0006520C
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44881, XrefRangeEnd = 44893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x0000C962 File Offset: 0x0000AB62
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0000C96B File Offset: 0x0000AB6B
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x170007A5 RID: 1957
			// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00067048 File Offset: 0x00065248
			// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000C97D File Offset: 0x0000AB7D
			public SortedSet<KeyValuePair<TKey, TValue>>.Enumerator _treeEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum);
					return new SortedSet<KeyValuePair<TKey, TValue>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortedSet<KeyValuePair<TKey, TValue>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__treeEnum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SortedSet<KeyValuePair<TKey, TValue>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007A6 RID: 1958
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00067078 File Offset: 0x00065278
			// (set) Token: 0x060017E9 RID: 6121 RVA: 0x0000C9AB File Offset: 0x0000ABAB
			public unsafe int _getEnumeratorRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr__getEnumeratorRetType)) = value;
				}
			}

			// Token: 0x040012F1 RID: 4849
			private static readonly IntPtr NativeFieldInfoPtr__treeEnum;

			// Token: 0x040012F2 RID: 4850
			private static readonly IntPtr NativeFieldInfoPtr__getEnumeratorRetType;

			// Token: 0x040012F3 RID: 4851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_Int32_0;

			// Token: 0x040012F4 RID: 4852
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040012F5 RID: 4853
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x040012F6 RID: 4854
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x040012F7 RID: 4855
			private static readonly IntPtr NativeMethodInfoPtr_get_NotStartedOrEnded_Internal_get_Boolean_0;

			// Token: 0x040012F8 RID: 4856
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

			// Token: 0x040012F9 RID: 4857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012FA RID: 4858
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012FB RID: 4859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012FC RID: 4860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012FD RID: 4861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;
		}

		// Token: 0x020001A2 RID: 418
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x060017EA RID: 6122 RVA: 0x000670A0 File Offset: 0x000652A0
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "_dictionary");
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664795);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664796);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664797);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664798);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664799);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664800);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664801);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664802);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664803);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664804);
				SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100664805);
			}

			// Token: 0x060017EB RID: 6123 RVA: 0x00067208 File Offset: 0x00065408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44927, XrefRangeEnd = 44928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(SortedDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017EC RID: 6124 RVA: 0x00067254 File Offset: 0x00065454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44928, XrefRangeEnd = 44931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x060017ED RID: 6125 RVA: 0x00067294 File Offset: 0x00065494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060017EE RID: 6126 RVA: 0x000672D4 File Offset: 0x000654D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44931, XrefRangeEnd = 44959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Il2CppArrayBase<TKey> array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017EF RID: 6127 RVA: 0x00067324 File Offset: 0x00065524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44959, XrefRangeEnd = 44974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007AE RID: 1966
			// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00067374 File Offset: 0x00065574
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44974, XrefRangeEnd = 44975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170007AF RID: 1967
			// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000673B0 File Offset: 0x000655B0
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060017F2 RID: 6130 RVA: 0x000673EC File Offset: 0x000655EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44975, XrefRangeEnd = 45143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Add(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x060017F3 RID: 6131 RVA: 0x00067464 File Offset: 0x00065664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45143, XrefRangeEnd = 45185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060017F4 RID: 6132 RVA: 0x00067498 File Offset: 0x00065698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45185, XrefRangeEnd = 45235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Contains(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060017F5 RID: 6133 RVA: 0x0006751C File Offset: 0x0006571C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45235, XrefRangeEnd = 45271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TKey__Remove(TKey item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TKey).IsValueType)
					{
						TKey tkey = item;
						intPtr = ((tkey is string) ? IL2CPP.ManagedStringToIl2Cpp(tkey as string) : IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060017F6 RID: 6134 RVA: 0x0000C9C6 File Offset: 0x0000ABC6
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007AD RID: 1965
			// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000675A0 File Offset: 0x000657A0
			// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0000C9CF File Offset: 0x0000ABCF
			public unsafe SortedDictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012FE RID: 4862
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;

			// Token: 0x040012FF RID: 4863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SortedDictionary_2_TKey_TValue_0;

			// Token: 0x04001300 RID: 4864
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x04001301 RID: 4865
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04001302 RID: 4866
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x04001303 RID: 4867
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04001304 RID: 4868
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04001305 RID: 4869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x0200021A RID: 538
			public sealed class Enumerator : ValueType
			{
				// Token: 0x06001CBA RID: 7354 RVA: 0x00073DE8 File Offset: 0x00071FE8
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "_dictEnum");
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664806);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664807);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664808);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664809);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664810);
					SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100664811);
				}

				// Token: 0x06001CBB RID: 7355 RVA: 0x00073EEC File Offset: 0x000720EC
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 44896, RefRangeEnd = 44898, XrefRangeStart = 44893, XrefRangeEnd = 44896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(SortedDictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06001CBC RID: 7356 RVA: 0x00073F3C File Offset: 0x0007213C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44898, XrefRangeEnd = 44901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CBD RID: 7357 RVA: 0x00073F74 File Offset: 0x00072174
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44901, XrefRangeEnd = 44905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700091C RID: 2332
				// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00073FB8 File Offset: 0x000721B8
				public unsafe TKey Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44905, XrefRangeEnd = 44909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x1700091D RID: 2333
				// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00073FF8 File Offset: 0x000721F8
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44909, XrefRangeEnd = 44923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001CC0 RID: 7360 RVA: 0x0007403C File Offset: 0x0007223C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44923, XrefRangeEnd = 44926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CC1 RID: 7361 RVA: 0x000105AB File Offset: 0x0000E7AB
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001CC2 RID: 7362 RVA: 0x000105B4 File Offset: 0x0000E7B4
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x1700091B RID: 2331
				// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00074074 File Offset: 0x00072274
				// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x000105C6 File Offset: 0x0000E7C6
				public SortedDictionary<TKey, TValue>.Enumerator _dictEnum
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum);
						return new SortedDictionary<TKey, TValue>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr__dictEnum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.Enumerator>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x040015A1 RID: 5537
				private static readonly IntPtr NativeFieldInfoPtr__dictEnum;

				// Token: 0x040015A2 RID: 5538
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SortedDictionary_2_TKey_TValue_0;

				// Token: 0x040015A3 RID: 5539
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x040015A4 RID: 5540
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040015A5 RID: 5541
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x040015A6 RID: 5542
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040015A7 RID: 5543
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}

			// Token: 0x0200021B RID: 539
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+KeyCollection+<>c__DisplayClass5_0")]
			public sealed class __c__DisplayClass5_0 : Object
			{
				// Token: 0x06001CC5 RID: 7365 RVA: 0x000740A4 File Offset: 0x000722A4
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass5_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, "array");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, 100664812);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr, 100664813);
				}

				// Token: 0x06001CC6 RID: 7366 RVA: 0x0007416C File Offset: 0x0007236C
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass5_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CC7 RID: 7367 RVA: 0x000741A8 File Offset: 0x000723A8
				[CallerCount(0)]
				public unsafe bool _CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001CC8 RID: 7368 RVA: 0x000105F4 File Offset: 0x0000E7F4
				public __c__DisplayClass5_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700091E RID: 2334
				// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000741F8 File Offset: 0x000723F8
				// (set) Token: 0x06001CCA RID: 7370 RVA: 0x000105FD File Offset: 0x0000E7FD
				public unsafe Il2CppArrayBase<TKey> array
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array);
						return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700091F RID: 2335
				// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00074220 File Offset: 0x00072420
				// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0001061C File Offset: 0x0000E81C
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass5_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x040015A8 RID: 5544
				private static readonly IntPtr NativeFieldInfoPtr_array;

				// Token: 0x040015A9 RID: 5545
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040015AA RID: 5546
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040015AB RID: 5547
				private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}

			// Token: 0x0200021C RID: 540
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+KeyCollection+<>c__DisplayClass6_0")]
			public sealed class __c__DisplayClass6_0 : Object
			{
				// Token: 0x06001CCD RID: 7373 RVA: 0x00074248 File Offset: 0x00072448
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_0()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, "index");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr, 100664814);
				}

				// Token: 0x06001CCE RID: 7374 RVA: 0x000742E8 File Offset: 0x000724E8
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CCF RID: 7375 RVA: 0x00010637 File Offset: 0x0000E837
				public __c__DisplayClass6_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000920 RID: 2336
				// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00074324 File Offset: 0x00072524
				// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x00010640 File Offset: 0x0000E840
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x040015AC RID: 5548
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x040015AD RID: 5549
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x0200021D RID: 541
			[ObfuscatedName("System.Collections.Generic.SortedDictionary`2+KeyCollection+<>c__DisplayClass6_1")]
			public sealed class __c__DisplayClass6_1 : Object
			{
				// Token: 0x06001CD2 RID: 7378 RVA: 0x0007434C File Offset: 0x0007254C
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass6_1()
				{
					Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "<>c__DisplayClass6_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr, "objects");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_TKey_TValue_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr, 100664815);
					SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr, 100664816);
				}

				// Token: 0x06001CD3 RID: 7379 RVA: 0x00074414 File Offset: 0x00072614
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass6_1()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CD4 RID: 7380 RVA: 0x00074450 File Offset: 0x00072650
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44926, XrefRangeEnd = 44927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _System_Collections_ICollection_CopyTo_b__0(SortedSet<KeyValuePair<TKey, TValue>>.Node node)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001CD5 RID: 7381 RVA: 0x0001065B File Offset: 0x0000E85B
				public __c__DisplayClass6_1(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000921 RID: 2337
				// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000744A0 File Offset: 0x000726A0
				// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x00010664 File Offset: 0x0000E864
				public unsafe Il2CppReferenceArray<Object> objects
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_objects);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000922 RID: 2338
				// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000744D0 File Offset: 0x000726D0
				// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x00010683 File Offset: 0x0000E883
				public unsafe SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_TKey_TValue_0
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_TKey_TValue_0);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyCollection.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_TKey_TValue_0), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040015AE RID: 5550
				private static readonly IntPtr NativeFieldInfoPtr_objects;

				// Token: 0x040015AF RID: 5551
				private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_TKey_TValue_0;

				// Token: 0x040015B0 RID: 5552
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040015B1 RID: 5553
				private static readonly IntPtr NativeMethodInfoPtr__System_Collections_ICollection_CopyTo_b__0_Internal_Boolean_Node_KeyValuePair_2_TKey_TValue_0;
			}
		}

		// Token: 0x020001A3 RID: 419
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x060017F9 RID: 6137 RVA: 0x000675D0 File Offset: 0x000657D0
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "_dictionary");
			}

			// Token: 0x060017FA RID: 6138 RVA: 0x0000C9EE File Offset: 0x0000ABEE
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B0 RID: 1968
			// (get) Token: 0x060017FB RID: 6139 RVA: 0x0006765C File Offset: 0x0006585C
			// (set) Token: 0x060017FC RID: 6140 RVA: 0x0000C9F7 File Offset: 0x0000ABF7
			public unsafe SortedDictionary<TKey, TValue> _dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeFieldInfoPtr__dictionary;
		}

		// Token: 0x020001A4 RID: 420
		[Serializable]
		public sealed class KeyValuePairComparer : Comparer<KeyValuePair<TKey, TValue>>
		{
			// Token: 0x060017FD RID: 6141 RVA: 0x0006768C File Offset: 0x0006588C
			// Note: this type is marked as 'beforefieldinit'.
			static KeyValuePairComparer()
			{
				Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>>.NativeClassPtr, "KeyValuePairComparer"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr);
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, "keyComparer");
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, 100664817);
				SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr, 100664818);
			}

			// Token: 0x060017FE RID: 6142 RVA: 0x00067740 File Offset: 0x00065940
			[CallerCount(0)]
			public unsafe KeyValuePairComparer(IComparer<TKey> keyComparer)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortedDictionary<TKey, TValue>.KeyValuePairComparer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyComparer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060017FF RID: 6143 RVA: 0x0006778C File Offset: 0x0006598C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45271, XrefRangeEnd = 45275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Compare(KeyValuePair<TKey, TValue> x, KeyValuePair<TKey, TValue> y)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001800 RID: 6144 RVA: 0x0000CA16 File Offset: 0x0000AC16
			public KeyValuePairComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007B1 RID: 1969
			// (get) Token: 0x06001801 RID: 6145 RVA: 0x000677F8 File Offset: 0x000659F8
			// (set) Token: 0x06001802 RID: 6146 RVA: 0x0000CA1F File Offset: 0x0000AC1F
			public unsafe IComparer<TKey> keyComparer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortedDictionary<TKey, TValue>.KeyValuePairComparer.NativeFieldInfoPtr_keyComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeFieldInfoPtr_keyComparer;

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_1_TKey_0;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_KeyValuePair_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0;
		}
	}
}
