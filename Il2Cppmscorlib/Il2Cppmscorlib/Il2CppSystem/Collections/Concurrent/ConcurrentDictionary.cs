using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Collections.Concurrent
{
	// Token: 0x02000488 RID: 1160
	[Serializable]
	public class ConcurrentDictionary<TKey, TValue> : Object
	{
		// Token: 0x0600457C RID: 17788 RVA: 0x0013DA78 File Offset: 0x0013BC78
		// Note: this type is marked as 'beforefieldinit'.
		static ConcurrentDictionary()
		{
			Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Concurrent", "ConcurrentDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr);
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_tables");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_comparer");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_growLockArray");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "_budget");
			ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "s_isValueWriteAtomic");
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673517);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673518);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673519);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673520);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673521);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673522);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673523);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673524);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673525);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673526);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673527);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673528);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673529);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673530);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673531);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673532);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673533);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673534);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673535);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673536);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673537);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673538);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673539);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673540);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673541);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673542);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673543);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673544);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673545);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673546);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673547);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673548);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673549);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673550);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673551);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673552);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673553);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673554);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673555);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673556);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673557);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673558);
			ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, 100673559);
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x0013DEB8 File Offset: 0x0013C0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361218, XrefRangeEnd = 361228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueWriteAtomic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600457E RID: 17790 RVA: 0x0013DEE8 File Offset: 0x0013C0E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 361232, RefRangeEnd = 361237, XrefRangeStart = 361228, XrefRangeEnd = 361232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600457F RID: 17791 RVA: 0x0013DF24 File Offset: 0x0013C124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361237, XrefRangeEnd = 361255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConcurrentDictionary(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref concurrencyLevel;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growLockArray;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004580 RID: 17792 RVA: 0x0013DF9C File Offset: 0x0013C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361255, XrefRangeEnd = 361257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(TKey key, TValue value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x0013E068 File Offset: 0x0013C268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361257, RefRangeEnd = 361258, XrefRangeStart = 361257, XrefRangeEnd = 361257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x0013E0EC File Offset: 0x0013C2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361258, RefRangeEnd = 361259, XrefRangeStart = 361258, XrefRangeEnd = 361258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRemove(TKey key, out TValue value)
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x0013E1C0 File Offset: 0x0013C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361259, XrefRangeEnd = 361287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchValue;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = oldValue;
				intPtr4 = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref oldValue;
			}
			ptr4 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr7 = intPtr2;
				value = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr7, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06004584 RID: 17796 RVA: 0x0013E2EC File Offset: 0x0013C4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361289, RefRangeEnd = 361291, XrefRangeStart = 361287, XrefRangeEnd = 361289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004585 RID: 17797 RVA: 0x0013E3C0 File Offset: 0x0013C5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361291, XrefRangeEnd = 361300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueInternal(TKey key, int hashcode, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06004586 RID: 17798 RVA: 0x0013E4A0 File Offset: 0x0013C6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361300, XrefRangeEnd = 361316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004587 RID: 17799 RVA: 0x0013E4D4 File Offset: 0x0013C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361316, XrefRangeEnd = 361321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x0013E524 File Offset: 0x0013C724
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 361330, RefRangeEnd = 361332, XrefRangeStart = 361321, XrefRangeEnd = 361330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<KeyValuePair<TKey, TValue>> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x0013E564 File Offset: 0x0013C764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361332, XrefRangeEnd = 361336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToPairs(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x0013E5B4 File Offset: 0x0013C7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361336, XrefRangeEnd = 361344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToEntries(Il2CppReferenceArray<DictionaryEntry> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x0013E604 File Offset: 0x0013C804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361344, XrefRangeEnd = 361351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToObjects(Il2CppReferenceArray<Object> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x0013E654 File Offset: 0x0013C854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361351, XrefRangeEnd = 361353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x0013E694 File Offset: 0x0013C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361353, XrefRangeEnd = 361390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateIfExists;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acquireLock;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(TValue).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref resultingValue;
			}
			ptr4 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr7 = intPtr3;
				resultingValue = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr7, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x170011B6 RID: 4534
		public unsafe virtual TKey this[TKey key]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 361392, RefRangeEnd = 361393, XrefRangeStart = 361390, XrefRangeEnd = 361392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x0600458F RID: 17807 RVA: 0x0013E89C File Offset: 0x0013CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361393, XrefRangeEnd = 361405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNullException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x0013E8C4 File Offset: 0x0013CAC4
		public unsafe virtual int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 361406, RefRangeEnd = 361409, XrefRangeStart = 361405, XrefRangeEnd = 361406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004591 RID: 17809 RVA: 0x0013E900 File Offset: 0x0013CB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361409, XrefRangeEnd = 361415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCountInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetCountInternal_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x0013E93C File Offset: 0x0013CB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361415, XrefRangeEnd = 361417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x0013E9D0 File Offset: 0x0013CBD0
		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361417, XrefRangeEnd = 361424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x0013EA0C File Offset: 0x0013CC0C
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_TKey_TValue_0(TKey key, TValue value)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x0013EACC File Offset: 0x0013CCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361424, XrefRangeEnd = 361426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0013EB14 File Offset: 0x0013CD14
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x0013EB68 File Offset: 0x0013CD68
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x0013EBA4 File Offset: 0x0013CDA4
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x0013EBF8 File Offset: 0x0013CDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361426, XrefRangeEnd = 361427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x0013EC38 File Offset: 0x0013CE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361427, XrefRangeEnd = 361433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x0013EC88 File Offset: 0x0013CE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361433, XrefRangeEnd = 361435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x0013ECC8 File Offset: 0x0013CEC8
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361435, XrefRangeEnd = 361436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x0013ED08 File Offset: 0x0013CF08
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x0013ED58 File Offset: 0x0013CF58
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361436, XrefRangeEnd = 361446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361446, XrefRangeEnd = 361458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600459F RID: 17823 RVA: 0x0013EDAC File Offset: 0x0013CFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361458, XrefRangeEnd = 361473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A0 RID: 17824 RVA: 0x0013EDFC File Offset: 0x0013CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361473, XrefRangeEnd = 361516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowTable(ConcurrentDictionary<TKey, TValue>.Tables tables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045A1 RID: 17825 RVA: 0x0013EE40 File Offset: 0x0013D040
		[CallerCount(0)]
		public unsafe static int GetBucket(int hashcode, int bucketCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x0013EE8C File Offset: 0x0013D08C
		[CallerCount(0)]
		public unsafe static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hashcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bucketNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lockNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bucketCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lockCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x0013EEF8 File Offset: 0x0013D0F8
		public unsafe static int DefaultConcurrencyLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361516, XrefRangeEnd = 361517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x0013EF28 File Offset: 0x0013D128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361517, XrefRangeEnd = 361526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireAllLocks(ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &locksAcquired;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x0013EF68 File Offset: 0x0013D168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361526, XrefRangeEnd = 361530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &locksAcquired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x0013EFC4 File Offset: 0x0013D1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361530, XrefRangeEnd = 361532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseLocks(int fromInclusive, int toExclusive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x0013F010 File Offset: 0x0013D210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361532, XrefRangeEnd = 361542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TKey> GetKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TKey>>(intPtr3) : null;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x0001A874 File Offset: 0x00018A74
		public ConcurrentDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x0013F050 File Offset: 0x0013D250
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x0001A87D File Offset: 0x00018A7D
		public unsafe ConcurrentDictionary<TKey, TValue>.Tables _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Tables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x0013F080 File Offset: 0x0013D280
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x0001A89C File Offset: 0x00018A9C
		public unsafe IEqualityComparer<TKey> _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x0013F0B0 File Offset: 0x0013D2B0
		// (set) Token: 0x060045AE RID: 17838 RVA: 0x0001A8BB File Offset: 0x00018ABB
		public unsafe bool _growLockArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__growLockArray)) = value;
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x0013F0D8 File Offset: 0x0013D2D8
		// (set) Token: 0x060045B0 RID: 17840 RVA: 0x0001A8D6 File Offset: 0x00018AD6
		public unsafe int _budget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr__budget)) = value;
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x0013F100 File Offset: 0x0013D300
		// (set) Token: 0x060045B2 RID: 17842 RVA: 0x0001A8F1 File Offset: 0x00018AF1
		public unsafe static bool s_isValueWriteAtomic
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConcurrentDictionary<TKey, TValue>.NativeFieldInfoPtr_s_isValueWriteAtomic, (void*)(&value));
			}
		}

		// Token: 0x04003880 RID: 14464
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x04003881 RID: 14465
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04003882 RID: 14466
		private static readonly IntPtr NativeFieldInfoPtr__growLockArray;

		// Token: 0x04003883 RID: 14467
		private static readonly IntPtr NativeFieldInfoPtr__budget;

		// Token: 0x04003884 RID: 14468
		private static readonly IntPtr NativeFieldInfoPtr_s_isValueWriteAtomic;

		// Token: 0x04003885 RID: 14469
		private static readonly IntPtr NativeMethodInfoPtr_IsValueWriteAtomic_Private_Static_Boolean_0;

		// Token: 0x04003886 RID: 14470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003887 RID: 14471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Boolean_IEqualityComparer_1_TKey_0;

		// Token: 0x04003888 RID: 14472
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Public_Boolean_TKey_TValue_0;

		// Token: 0x04003889 RID: 14473
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x0400388A RID: 14474
		private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400388B RID: 14475
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveInternal_Private_Boolean_TKey_byref_TValue_Boolean_TValue_0;

		// Token: 0x0400388C RID: 14476
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x0400388D RID: 14477
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueInternal_Private_Boolean_TKey_Int32_byref_TValue_0;

		// Token: 0x0400388E RID: 14478
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400388F RID: 14479
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003890 RID: 14480
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003891 RID: 14481
		private static readonly IntPtr NativeMethodInfoPtr_CopyToPairs_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeMethodInfoPtr_CopyToEntries_Private_Void_Il2CppReferenceArray_1_DictionaryEntry_Int32_0;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeMethodInfoPtr_CopyToObjects_Private_Void_Il2CppReferenceArray_1_Object_Int32_0;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeMethodInfoPtr_TryAddInternal_Private_Boolean_TKey_Int32_TValue_Boolean_Boolean_byref_TValue_0;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNullException_Private_Static_Void_0;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeMethodInfoPtr_GetCountInternal_Private_Int32_0;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_TValue_TKey_Func_2_TKey_TValue_0;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeMethodInfoPtr_GrowTable_Private_Void_Tables_TKey_TValue_0;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeMethodInfoPtr_GetBucket_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeMethodInfoPtr_GetBucketAndLockNo_Private_Static_Void_Int32_byref_Int32_byref_Int32_Int32_Int32_0;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultConcurrencyLevel_Private_Static_get_Int32_0;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeMethodInfoPtr_AcquireAllLocks_Private_Void_byref_Int32_0;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeMethodInfoPtr_AcquireLocks_Private_Void_Int32_Int32_byref_Int32_0;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseLocks_Private_Void_Int32_Int32_0;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_ReadOnlyCollection_1_TKey_0;

		// Token: 0x0200065F RID: 1631
		public sealed class Tables : Object
		{
			// Token: 0x060055F1 RID: 22001 RVA: 0x0017B530 File Offset: 0x00179730
			// Note: this type is marked as 'beforefieldinit'.
			static Tables()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Tables"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_buckets");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_locks");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, "_countPerLock");
				ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr, 100673561);
			}

			// Token: 0x060055F2 RID: 22002 RVA: 0x0017B5F8 File Offset: 0x001797F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361149, XrefRangeEnd = 361151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tables(Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> buckets, Il2CppReferenceArray<Object> locks, Il2CppStructArray<int> countPerLock)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Tables>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buckets);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locks);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(countPerLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Tables.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060055F3 RID: 22003 RVA: 0x000212D9 File Offset: 0x0001F4D9
			public Tables(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001611 RID: 5649
			// (get) Token: 0x060055F4 RID: 22004 RVA: 0x0017B668 File Offset: 0x00179868
			// (set) Token: 0x060055F5 RID: 22005 RVA: 0x000212E2 File Offset: 0x0001F4E2
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001612 RID: 5650
			// (get) Token: 0x060055F6 RID: 22006 RVA: 0x0017B698 File Offset: 0x00179898
			// (set) Token: 0x060055F7 RID: 22007 RVA: 0x00021301 File Offset: 0x0001F501
			public unsafe Il2CppReferenceArray<Object> _locks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__locks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001613 RID: 5651
			// (get) Token: 0x060055F8 RID: 22008 RVA: 0x0017B6C8 File Offset: 0x001798C8
			// (set) Token: 0x060055F9 RID: 22009 RVA: 0x00021320 File Offset: 0x0001F520
			public unsafe Il2CppStructArray<int> _countPerLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Tables.NativeFieldInfoPtr__countPerLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044F5 RID: 17653
			private static readonly IntPtr NativeFieldInfoPtr__buckets;

			// Token: 0x040044F6 RID: 17654
			private static readonly IntPtr NativeFieldInfoPtr__locks;

			// Token: 0x040044F7 RID: 17655
			private static readonly IntPtr NativeFieldInfoPtr__countPerLock;

			// Token: 0x040044F8 RID: 17656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Node_TKey_TValue_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_0;
		}

		// Token: 0x02000660 RID: 1632
		[Serializable]
		public sealed class Node : Object
		{
			// Token: 0x060055FA RID: 22010 RVA: 0x0017B6F8 File Offset: 0x001798F8
			// Note: this type is marked as 'beforefieldinit'.
			static Node()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "Node"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_key");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_value");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_next");
				ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, "_hashcode");
				ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr, 100673562);
			}

			// Token: 0x060055FB RID: 22011 RVA: 0x0017B7D4 File Offset: 0x001799D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361151, XrefRangeEnd = 361153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Node(TKey key, TValue value, int hashcode, ConcurrentDictionary<TKey, TValue>.Node next)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.Node>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
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
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashcode;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.Node.NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}

			// Token: 0x060055FC RID: 22012 RVA: 0x0002133F File Offset: 0x0001F53F
			public Node(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001614 RID: 5652
			// (get) Token: 0x060055FD RID: 22013 RVA: 0x0017B8C0 File Offset: 0x00179AC0
			// (set) Token: 0x060055FE RID: 22014 RVA: 0x0017B8E8 File Offset: 0x00179AE8
			public unsafe TKey _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__key);
					Type typeFromHandle = typeof(TKey);
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

			// Token: 0x17001615 RID: 5653
			// (get) Token: 0x060055FF RID: 22015 RVA: 0x0017B990 File Offset: 0x00179B90
			// (set) Token: 0x06005600 RID: 22016 RVA: 0x0017B9B8 File Offset: 0x00179BB8
			public unsafe TValue _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__value);
					Type typeFromHandle = typeof(TValue);
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

			// Token: 0x17001616 RID: 5654
			// (get) Token: 0x06005601 RID: 22017 RVA: 0x0017BA60 File Offset: 0x00179C60
			// (set) Token: 0x06005602 RID: 22018 RVA: 0x00021348 File Offset: 0x0001F548
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001617 RID: 5655
			// (get) Token: 0x06005603 RID: 22019 RVA: 0x0017BA90 File Offset: 0x00179C90
			// (set) Token: 0x06005604 RID: 22020 RVA: 0x00021367 File Offset: 0x0001F567
			public unsafe int _hashcode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.Node.NativeFieldInfoPtr__hashcode)) = value;
				}
			}

			// Token: 0x040044F9 RID: 17657
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x040044FA RID: 17658
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x040044FB RID: 17659
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x040044FC RID: 17660
			private static readonly IntPtr NativeFieldInfoPtr__hashcode;

			// Token: 0x040044FD RID: 17661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TKey_TValue_Int32_Node_TKey_TValue_0;
		}

		// Token: 0x02000661 RID: 1633
		[Serializable]
		public sealed class DictionaryEnumerator : Object
		{
			// Token: 0x06005605 RID: 22021 RVA: 0x0017BAB8 File Offset: 0x00179CB8
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "DictionaryEnumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, "_enumerator");
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673563);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673564);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673565);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673566);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673567);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673568);
				ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr, 100673569);
			}

			// Token: 0x06005606 RID: 22022 RVA: 0x0017BBD0 File Offset: 0x00179DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361153, XrefRangeEnd = 361154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(ConcurrentDictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001619 RID: 5657
			// (get) Token: 0x06005607 RID: 22023 RVA: 0x0017BC1C File Offset: 0x00179E1C
			public unsafe DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361154, XrefRangeEnd = 361163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x1700161A RID: 5658
			// (get) Token: 0x06005608 RID: 22024 RVA: 0x0017BC54 File Offset: 0x00179E54
			public unsafe Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361163, XrefRangeEnd = 361167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700161B RID: 5659
			// (get) Token: 0x06005609 RID: 22025 RVA: 0x0017BC94 File Offset: 0x00179E94
			public unsafe Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361167, XrefRangeEnd = 361171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700161C RID: 5660
			// (get) Token: 0x0600560A RID: 22026 RVA: 0x0017BCD4 File Offset: 0x00179ED4
			public unsafe Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361171, XrefRangeEnd = 361174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600560B RID: 22027 RVA: 0x0017BD14 File Offset: 0x00179F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361174, XrefRangeEnd = 361190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600560C RID: 22028 RVA: 0x0017BD50 File Offset: 0x00179F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361190, XrefRangeEnd = 361198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600560D RID: 22029 RVA: 0x00021382 File Offset: 0x0001F582
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001618 RID: 5656
			// (get) Token: 0x0600560E RID: 22030 RVA: 0x0017BD84 File Offset: 0x00179F84
			// (set) Token: 0x0600560F RID: 22031 RVA: 0x0002138B File Offset: 0x0001F58B
			public unsafe IEnumerator<KeyValuePair<TKey, TValue>> _enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>.DictionaryEnumerator.NativeFieldInfoPtr__enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044FE RID: 17662
			private static readonly IntPtr NativeFieldInfoPtr__enumerator;

			// Token: 0x040044FF RID: 17663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ConcurrentDictionary_2_TKey_TValue_0;

			// Token: 0x04004500 RID: 17664
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004501 RID: 17665
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004502 RID: 17666
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004503 RID: 17667
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004504 RID: 17668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004505 RID: 17669
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000662 RID: 1634
		[ObfuscatedName("System.Collections.Concurrent.ConcurrentDictionary`2+<GetEnumerator>d__32")]
		public sealed class _GetEnumerator_d__32 : Object
		{
			// Token: 0x06005610 RID: 22032 RVA: 0x0017BDB4 File Offset: 0x00179FB4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__32()
			{
				Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>>.NativeClassPtr, "<GetEnumerator>d__32"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>1__state");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>2__current");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<>4__this");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<buckets>5__1");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<current>5__2");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, "<i>5__3");
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673570);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673571);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673572);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673573);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673574);
				ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr, 100673575);
			}

			// Token: 0x06005611 RID: 22033 RVA: 0x0017BF1C File Offset: 0x0017A11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__32(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005612 RID: 22034 RVA: 0x0017BF64 File Offset: 0x0017A164
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005613 RID: 22035 RVA: 0x0017BF98 File Offset: 0x0017A198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361198, XrefRangeEnd = 361204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001623 RID: 5667
			// (get) Token: 0x06005614 RID: 22036 RVA: 0x0017BFD4 File Offset: 0x0017A1D4
			public unsafe KeyValuePair<TKey, TValue> prop_KeyValuePair_2_TKey_TValue_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06005615 RID: 22037 RVA: 0x0017C00C File Offset: 0x0017A20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361204, XrefRangeEnd = 361216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001624 RID: 5668
			// (get) Token: 0x06005616 RID: 22038 RVA: 0x0017C040 File Offset: 0x0017A240
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361216, XrefRangeEnd = 361218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005617 RID: 22039 RVA: 0x000213AA File Offset: 0x0001F5AA
			public _GetEnumerator_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700161D RID: 5661
			// (get) Token: 0x06005618 RID: 22040 RVA: 0x0017C080 File Offset: 0x0017A280
			// (set) Token: 0x06005619 RID: 22041 RVA: 0x000213B3 File Offset: 0x0001F5B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700161E RID: 5662
			// (get) Token: 0x0600561A RID: 22042 RVA: 0x0017C0A8 File Offset: 0x0017A2A8
			// (set) Token: 0x0600561B RID: 22043 RVA: 0x000213CE File Offset: 0x0001F5CE
			public KeyValuePair<TKey, TValue> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700161F RID: 5663
			// (get) Token: 0x0600561C RID: 22044 RVA: 0x0017C0D8 File Offset: 0x0017A2D8
			// (set) Token: 0x0600561D RID: 22045 RVA: 0x000213FC File Offset: 0x0001F5FC
			public unsafe ConcurrentDictionary<TKey, TValue> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001620 RID: 5664
			// (get) Token: 0x0600561E RID: 22046 RVA: 0x0017C108 File Offset: 0x0017A308
			// (set) Token: 0x0600561F RID: 22047 RVA: 0x0002141B File Offset: 0x0001F61B
			public unsafe Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node> _buckets_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConcurrentDictionary<TKey, TValue>.Node>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__buckets_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001621 RID: 5665
			// (get) Token: 0x06005620 RID: 22048 RVA: 0x0017C138 File Offset: 0x0017A338
			// (set) Token: 0x06005621 RID: 22049 RVA: 0x0002143A File Offset: 0x0001F63A
			public unsafe ConcurrentDictionary<TKey, TValue>.Node _current_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<TKey, TValue>.Node>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__current_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001622 RID: 5666
			// (get) Token: 0x06005622 RID: 22050 RVA: 0x0017C168 File Offset: 0x0017A368
			// (set) Token: 0x06005623 RID: 22051 RVA: 0x00021459 File Offset: 0x0001F659
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConcurrentDictionary<TKey, TValue>._GetEnumerator_d__32.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04004506 RID: 17670
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004507 RID: 17671
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004508 RID: 17672
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004509 RID: 17673
			private static readonly IntPtr NativeFieldInfoPtr__buckets_5__1;

			// Token: 0x0400450A RID: 17674
			private static readonly IntPtr NativeFieldInfoPtr__current_5__2;

			// Token: 0x0400450B RID: 17675
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400450C RID: 17676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400450D RID: 17677
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400450E RID: 17678
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400450F RID: 17679
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04004510 RID: 17680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004511 RID: 17681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
