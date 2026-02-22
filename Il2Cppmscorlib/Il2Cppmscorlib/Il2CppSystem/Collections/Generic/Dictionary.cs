using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000491 RID: 1169
	[Serializable]
	public class Dictionary<TKey, TValue> : Object
	{
		// Token: 0x060045E9 RID: 17897 RVA: 0x0014060C File Offset: 0x0013E80C
		// Note: this type is marked as 'beforefieldinit'.
		static Dictionary()
		{
			Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "Dictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr);
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "buckets");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "entries");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "count");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "version");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "freeList");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "freeCount");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "comparer");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "keys");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "values");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "_syncRoot");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "VersionName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "HashSizeName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyValuePairsName");
			Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ComparerName");
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673609);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673610);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673611);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673612);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673613);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673614);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673615);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673616);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673617);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673618);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673619);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673620);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673621);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673622);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673623);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673624);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673625);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673626);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673627);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673628);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673629);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673630);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673631);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673632);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673633);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673634);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673635);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673636);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673637);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673638);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673639);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673640);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673641);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673642);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673643);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673644);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673645);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673646);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673647);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673648);
			Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, 100673649);
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00140AD8 File Offset: 0x0013ECD8
		[CallerCount(196)]
		[CachedScanResults(RefRangeStart = 362297, RefRangeEnd = 362493, XrefRangeStart = 362271, XrefRangeEnd = 362297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00140B14 File Offset: 0x0013ED14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 309492, RefRangeEnd = 309502, XrefRangeStart = 309492, XrefRangeEnd = 309502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00140B5C File Offset: 0x0013ED5C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 362520, RefRangeEnd = 362528, XrefRangeStart = 362493, XrefRangeEnd = 362520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00140BA8 File Offset: 0x0013EDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362528, XrefRangeEnd = 362529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(int capacity, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00140C04 File Offset: 0x0013EE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 362531, RefRangeEnd = 362532, XrefRangeStart = 362529, XrefRangeEnd = 362531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00140C50 File Offset: 0x0013EE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362532, XrefRangeEnd = 362557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00140CB0 File Offset: 0x0013EEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362557, XrefRangeEnd = 362584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x00140D14 File Offset: 0x0013EF14
		public unsafe virtual int Count
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 362584, RefRangeEnd = 362613, XrefRangeStart = 362584, XrefRangeEnd = 362584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x060045F2 RID: 17906 RVA: 0x00140D50 File Offset: 0x0013EF50
		public unsafe Dictionary<TKey, TValue>.KeyCollection Keys
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 362615, RefRangeEnd = 362634, XrefRangeStart = 362613, XrefRangeEnd = 362615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x00140D90 File Offset: 0x0013EF90
		public unsafe Dictionary<TKey, TValue>.ValueCollection Values
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 362636, RefRangeEnd = 362647, XrefRangeStart = 362634, XrefRangeEnd = 362636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170011D4 RID: 4564
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 362647, RefRangeEnd = 362653, XrefRangeStart = 362647, XrefRangeEnd = 362647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
				}
			}
			[CallerCount(147)]
			[CachedScanResults(RefRangeStart = 362653, RefRangeEnd = 362800, XrefRangeStart = 362653, XrefRangeEnd = 362653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			}
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x00140F10 File Offset: 0x0013F110
		[CallerCount(370)]
		[CachedScanResults(RefRangeStart = 362800, RefRangeEnd = 363170, XrefRangeStart = 362800, XrefRangeEnd = 362800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00140FD0 File Offset: 0x0013F1D0
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00141018 File Offset: 0x0013F218
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x0014106C File Offset: 0x0013F26C
		[CallerCount(0)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1(KeyValuePair<TKey, TValue> keyValuePair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(keyValuePair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x001410C0 File Offset: 0x0013F2C0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 363172, RefRangeEnd = 363191, XrefRangeStart = 363170, XrefRangeEnd = 363172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x001410F4 File Offset: 0x0013F2F4
		[CallerCount(214)]
		[CachedScanResults(RefRangeStart = 363191, RefRangeEnd = 363405, XrefRangeStart = 363191, XrefRangeEnd = 363191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00141178 File Offset: 0x0013F378
		[CallerCount(0)]
		public unsafe bool ContainsValue(TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x001411FC File Offset: 0x0013F3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363405, XrefRangeEnd = 363406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x0014124C File Offset: 0x0013F44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 363407, RefRangeEnd = 363408, XrefRangeStart = 363406, XrefRangeEnd = 363407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Dictionary<TKey, TValue>.Enumerator(intPtr);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00141284 File Offset: 0x0013F484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363408, XrefRangeEnd = 363411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x001412C4 File Offset: 0x0013F4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363411, XrefRangeEnd = 363433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00141328 File Offset: 0x0013F528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363433, XrefRangeEnd = 363439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindEntry(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x001413AC File Offset: 0x0013F5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363439, XrefRangeEnd = 363449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Initialize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x001413EC File Offset: 0x0013F5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363449, XrefRangeEnd = 363459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryInsert(TKey key, TValue value, InsertionBehavior behavior)
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behavior;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x001414C8 File Offset: 0x0013F6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363459, XrefRangeEnd = 363498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dictionary<TKey, TValue>.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00141518 File Offset: 0x0013F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363498, XrefRangeEnd = 363511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x0014154C File Offset: 0x0013F74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363511, XrefRangeEnd = 363520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int newSize, bool forceNewHashCodes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceNewHashCodes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00141598 File Offset: 0x0013F798
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 363524, RefRangeEnd = 363551, XrefRangeStart = 363520, XrefRangeEnd = 363524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(TKey key)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x0014161C File Offset: 0x0013F81C
		[CallerCount(157)]
		[CachedScanResults(RefRangeStart = 363551, RefRangeEnd = 363708, XrefRangeStart = 363551, XrefRangeEnd = 363551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr6 = intPtr2;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x001416F0 File Offset: 0x0013F8F0
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x0014172C File Offset: 0x0013F92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363708, XrefRangeEnd = 363709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x0014177C File Offset: 0x0013F97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363709, XrefRangeEnd = 363732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x001417CC File Offset: 0x0013F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x0014180C File Offset: 0x0013FA0C
		public unsafe virtual ICollection System.Collections.IDictionary.Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363732, XrefRangeEnd = 363737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x0600460E RID: 17934 RVA: 0x0014184C File Offset: 0x0013FA4C
		// (set) Token: 0x0600460F RID: 17935 RVA: 0x0014189C File Offset: 0x0013FA9C
		public unsafe virtual Object System.Collections.IDictionary.Item
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363737, XrefRangeEnd = 363739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363739, XrefRangeEnd = 363743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x001418F0 File Offset: 0x0013FAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363743, XrefRangeEnd = 363746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCompatibleKey(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x00141934 File Offset: 0x0013FB34
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_IDictionary_Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00141984 File Offset: 0x0013FB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363746, XrefRangeEnd = 363749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator System_Collections_IDictionary_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x0001A99B File Offset: 0x00018B9B
		public Dictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06004614 RID: 17940 RVA: 0x001419C4 File Offset: 0x0013FBC4
		// (set) Token: 0x06004615 RID: 17941 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public unsafe Il2CppStructArray<int> buckets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_buckets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06004616 RID: 17942 RVA: 0x001419F4 File Offset: 0x0013FBF4
		// (set) Token: 0x06004617 RID: 17943 RVA: 0x0001A9C3 File Offset: 0x00018BC3
		public unsafe Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Dictionary<TKey, TValue>.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06004618 RID: 17944 RVA: 0x00141A24 File Offset: 0x0013FC24
		// (set) Token: 0x06004619 RID: 17945 RVA: 0x0001A9E2 File Offset: 0x00018BE2
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600461A RID: 17946 RVA: 0x00141A4C File Offset: 0x0013FC4C
		// (set) Token: 0x0600461B RID: 17947 RVA: 0x0001A9FD File Offset: 0x00018BFD
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600461C RID: 17948 RVA: 0x00141A74 File Offset: 0x0013FC74
		// (set) Token: 0x0600461D RID: 17949 RVA: 0x0001AA18 File Offset: 0x00018C18
		public unsafe int freeList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeList)) = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600461E RID: 17950 RVA: 0x00141A9C File Offset: 0x0013FC9C
		// (set) Token: 0x0600461F RID: 17951 RVA: 0x0001AA33 File Offset: 0x00018C33
		public unsafe int freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_freeCount)) = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06004620 RID: 17952 RVA: 0x00141AC4 File Offset: 0x0013FCC4
		// (set) Token: 0x06004621 RID: 17953 RVA: 0x0001AA4E File Offset: 0x00018C4E
		public unsafe IEqualityComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x06004622 RID: 17954 RVA: 0x00141AF4 File Offset: 0x0013FCF4
		// (set) Token: 0x06004623 RID: 17955 RVA: 0x0001AA6D File Offset: 0x00018C6D
		public unsafe Dictionary<TKey, TValue>.KeyCollection keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.KeyCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x00141B24 File Offset: 0x0013FD24
		// (set) Token: 0x06004625 RID: 17957 RVA: 0x0001AA8C File Offset: 0x00018C8C
		public unsafe Dictionary<TKey, TValue>.ValueCollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>.ValueCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x00141B54 File Offset: 0x0013FD54
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x0001AAAB File Offset: 0x00018CAB
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06004628 RID: 17960 RVA: 0x00141B84 File Offset: 0x0013FD84
		// (set) Token: 0x06004629 RID: 17961 RVA: 0x0001AACA File Offset: 0x00018CCA
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600462A RID: 17962 RVA: 0x00141BA4 File Offset: 0x0013FDA4
		// (set) Token: 0x0600462B RID: 17963 RVA: 0x0001AADC File Offset: 0x00018CDC
		public unsafe static string HashSizeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_HashSizeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600462C RID: 17964 RVA: 0x00141BC4 File Offset: 0x0013FDC4
		// (set) Token: 0x0600462D RID: 17965 RVA: 0x0001AAEE File Offset: 0x00018CEE
		public unsafe static string KeyValuePairsName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_KeyValuePairsName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x00141BE4 File Offset: 0x0013FDE4
		// (set) Token: 0x0600462F RID: 17967 RVA: 0x0001AB00 File Offset: 0x00018D00
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dictionary<TKey, TValue>.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeFieldInfoPtr_buckets;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeFieldInfoPtr_freeList;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeFieldInfoPtr_freeCount;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeFieldInfoPtr_HashSizeName;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeFieldInfoPtr_KeyValuePairsName;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEqualityComparer_1_TKey_0;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_IEqualityComparer_1_TKey_0;

		// Token: 0x040038EA RID: 14570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_0;

		// Token: 0x040038EB RID: 14571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_TKey_TValue_IEqualityComparer_1_TKey_0;

		// Token: 0x040038EC RID: 14572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040038ED RID: 14573
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040038EE RID: 14574
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_KeyCollection_TKey_TValue_0;

		// Token: 0x040038EF RID: 14575
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ValueCollection_TKey_TValue_0;

		// Token: 0x040038F0 RID: 14576
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x040038F1 RID: 14577
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x040038F2 RID: 14578
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x040038F3 RID: 14579
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040038F4 RID: 14580
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_1;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeMethodInfoPtr_ContainsValue_Public_Boolean_TValue_0;

		// Token: 0x040038F9 RID: 14585
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Private_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x040038FA RID: 14586
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

		// Token: 0x040038FB RID: 14587
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_Int32_TKey_0;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Int32_0;

		// Token: 0x040038FF RID: 14591
		private static readonly IntPtr NativeMethodInfoPtr_TryInsert_Private_Boolean_TKey_TValue_InsertionBehavior_0;

		// Token: 0x04003900 RID: 14592
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x04003901 RID: 14593
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;

		// Token: 0x04003902 RID: 14594
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_Boolean_0;

		// Token: 0x04003903 RID: 14595
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04003904 RID: 14596
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04003905 RID: 14597
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Keys_Private_Virtual_Final_New_get_ICollection_0;

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_get_Item_Private_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_set_Item_Private_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeMethodInfoPtr_IsCompatibleKey_Private_Static_Boolean_Object_0;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionary_GetEnumerator_Private_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x02000665 RID: 1637
		public sealed class Entry : ValueType
		{
			// Token: 0x06005626 RID: 22054 RVA: 0x0017C258 File Offset: 0x0017A458
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Entry"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr);
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "hashCode");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "next");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "key");
				Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr, "value");
			}

			// Token: 0x06005627 RID: 22055 RVA: 0x00021474 File Offset: 0x0001F674
			public Entry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005628 RID: 22056 RVA: 0x0002147D File Offset: 0x0001F67D
			public Entry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Entry>.NativeClassPtr))
			{
			}

			// Token: 0x17001625 RID: 5669
			// (get) Token: 0x06005629 RID: 22057 RVA: 0x0017C320 File Offset: 0x0017A520
			// (set) Token: 0x0600562A RID: 22058 RVA: 0x0002148F File Offset: 0x0001F68F
			public unsafe int hashCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_hashCode)) = value;
				}
			}

			// Token: 0x17001626 RID: 5670
			// (get) Token: 0x0600562B RID: 22059 RVA: 0x0017C348 File Offset: 0x0017A548
			// (set) Token: 0x0600562C RID: 22060 RVA: 0x000214AA File Offset: 0x0001F6AA
			public unsafe int next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_next)) = value;
				}
			}

			// Token: 0x17001627 RID: 5671
			// (get) Token: 0x0600562D RID: 22061 RVA: 0x0017C370 File Offset: 0x0017A570
			// (set) Token: 0x0600562E RID: 22062 RVA: 0x0017C398 File Offset: 0x0017A598
			public unsafe TKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_key);
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

			// Token: 0x17001628 RID: 5672
			// (get) Token: 0x0600562F RID: 22063 RVA: 0x0017C440 File Offset: 0x0017A640
			// (set) Token: 0x06005630 RID: 22064 RVA: 0x0017C468 File Offset: 0x0017A668
			public unsafe TValue value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Entry.NativeFieldInfoPtr_value);
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

			// Token: 0x04004514 RID: 17684
			private static readonly IntPtr NativeFieldInfoPtr_hashCode;

			// Token: 0x04004515 RID: 17685
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04004516 RID: 17686
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04004517 RID: 17687
			private static readonly IntPtr NativeFieldInfoPtr_value;
		}

		// Token: 0x02000666 RID: 1638
		[Serializable]
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06005631 RID: 22065 RVA: 0x0017C510 File Offset: 0x0017A710
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr);
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "version");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "index");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "current");
				Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, "getEnumeratorRetType");
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673650);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673651);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673652);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673653);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673654);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673655);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673656);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673657);
				Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr, 100673658);
			}

			// Token: 0x06005632 RID: 22066 RVA: 0x0017C6A0 File Offset: 0x0017A8A0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 361794, RefRangeEnd = 361797, XrefRangeStart = 361794, XrefRangeEnd = 361794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Dictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getEnumeratorRetType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005633 RID: 22067 RVA: 0x0017C700 File Offset: 0x0017A900
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 361800, RefRangeEnd = 361801, XrefRangeStart = 361797, XrefRangeEnd = 361800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700162E RID: 5678
			// (get) Token: 0x06005634 RID: 22068 RVA: 0x0017C744 File Offset: 0x0017A944
			public unsafe KeyValuePair<TKey, TValue> Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<TKey, TValue>(intPtr);
				}
			}

			// Token: 0x06005635 RID: 22069 RVA: 0x0017C780 File Offset: 0x0017A980
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700162F RID: 5679
			// (get) Token: 0x06005636 RID: 22070 RVA: 0x0017C7B8 File Offset: 0x0017A9B8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361801, XrefRangeEnd = 361809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005637 RID: 22071 RVA: 0x0017C7FC File Offset: 0x0017A9FC
			[CallerCount(0)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001630 RID: 5680
			// (get) Token: 0x06005638 RID: 22072 RVA: 0x0017C834 File Offset: 0x0017AA34
			public unsafe DictionaryEntry System.Collections.IDictionaryEnumerator.Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361809, XrefRangeEnd = 361815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x17001631 RID: 5681
			// (get) Token: 0x06005639 RID: 22073 RVA: 0x0017C870 File Offset: 0x0017AA70
			public unsafe Object System.Collections.IDictionaryEnumerator.Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361815, XrefRangeEnd = 361819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001632 RID: 5682
			// (get) Token: 0x0600563A RID: 22074 RVA: 0x0017C8B4 File Offset: 0x0017AAB4
			public unsafe Object System.Collections.IDictionaryEnumerator.Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361819, XrefRangeEnd = 361820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.Enumerator.NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600563B RID: 22075 RVA: 0x000214C5 File Offset: 0x0001F6C5
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600563C RID: 22076 RVA: 0x000214CE File Offset: 0x0001F6CE
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17001629 RID: 5673
			// (get) Token: 0x0600563D RID: 22077 RVA: 0x0017C8F8 File Offset: 0x0017AAF8
			// (set) Token: 0x0600563E RID: 22078 RVA: 0x000214E0 File Offset: 0x0001F6E0
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700162A RID: 5674
			// (get) Token: 0x0600563F RID: 22079 RVA: 0x0017C928 File Offset: 0x0017AB28
			// (set) Token: 0x06005640 RID: 22080 RVA: 0x000214FF File Offset: 0x0001F6FF
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x1700162B RID: 5675
			// (get) Token: 0x06005641 RID: 22081 RVA: 0x0017C950 File Offset: 0x0017AB50
			// (set) Token: 0x06005642 RID: 22082 RVA: 0x0002151A File Offset: 0x0001F71A
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700162C RID: 5676
			// (get) Token: 0x06005643 RID: 22083 RVA: 0x0017C978 File Offset: 0x0017AB78
			// (set) Token: 0x06005644 RID: 22084 RVA: 0x00021535 File Offset: 0x0001F735
			public KeyValuePair<TKey, TValue> current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current);
					return new KeyValuePair<TKey, TValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<TKey, TValue>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700162D RID: 5677
			// (get) Token: 0x06005645 RID: 22085 RVA: 0x0017C9A8 File Offset: 0x0017ABA8
			// (set) Token: 0x06005646 RID: 22086 RVA: 0x00021563 File Offset: 0x0001F763
			public unsafe int getEnumeratorRetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.Enumerator.NativeFieldInfoPtr_getEnumeratorRetType)) = value;
				}
			}

			// Token: 0x04004518 RID: 17688
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x04004519 RID: 17689
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x0400451A RID: 17690
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400451B RID: 17691
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400451C RID: 17692
			private static readonly IntPtr NativeFieldInfoPtr_getEnumeratorRetType;

			// Token: 0x0400451D RID: 17693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_Int32_0;

			// Token: 0x0400451E RID: 17694
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x0400451F RID: 17695
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x04004520 RID: 17696
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004521 RID: 17697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004522 RID: 17698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004523 RID: 17699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Entry_Private_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004524 RID: 17700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Key_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004525 RID: 17701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IDictionaryEnumerator_get_Value_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000667 RID: 1639
		[Serializable]
		public sealed class KeyCollection : Object
		{
			// Token: 0x06005647 RID: 22087 RVA: 0x0017C9D0 File Offset: 0x0017ABD0
			// Note: this type is marked as 'beforefieldinit'.
			static KeyCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "KeyCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673659);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673660);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673661);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673662);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673663);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673664);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673665);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673666);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673667);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673668);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673669);
				Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, 100673670);
			}

			// Token: 0x06005648 RID: 22088 RVA: 0x0017CB4C File Offset: 0x0017AD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361827, XrefRangeEnd = 361828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005649 RID: 22089 RVA: 0x0017CB98 File Offset: 0x0017AD98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361828, XrefRangeEnd = 361829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.KeyCollection.Enumerator(intPtr);
			}

			// Token: 0x0600564A RID: 22090 RVA: 0x0017CBD0 File Offset: 0x0017ADD0
			[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001634 RID: 5684
			// (get) Token: 0x0600564B RID: 22091 RVA: 0x0017CC20 File Offset: 0x0017AE20
			public unsafe int Count
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 143823, RefRangeEnd = 143825, XrefRangeStart = 143823, XrefRangeEnd = 143825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001635 RID: 5685
			// (get) Token: 0x0600564C RID: 22092 RVA: 0x0017CC5C File Offset: 0x0017AE5C
			public unsafe bool System.Collections.Generic.ICollection<TKey>.IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600564D RID: 22093 RVA: 0x0017CC98 File Offset: 0x0017AE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361829, XrefRangeEnd = 361859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x0600564E RID: 22094 RVA: 0x0017CD10 File Offset: 0x0017AF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361859, XrefRangeEnd = 361877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TKey__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600564F RID: 22095 RVA: 0x0017CD44 File Offset: 0x0017AF44
			[CallerCount(0)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005650 RID: 22096 RVA: 0x0017CDC8 File Offset: 0x0017AFC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361877, XrefRangeEnd = 361943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005651 RID: 22097 RVA: 0x0017CE4C File Offset: 0x0017B04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361943, XrefRangeEnd = 361946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TKey> System_Collections_Generic_IEnumerable_TKey__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TKey>>(intPtr3) : null;
			}

			// Token: 0x06005652 RID: 22098 RVA: 0x0017CE8C File Offset: 0x0017B08C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005653 RID: 22099 RVA: 0x0017CECC File Offset: 0x0017B0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361946, XrefRangeEnd = 361960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005654 RID: 22100 RVA: 0x0002157E File Offset: 0x0001F77E
			public KeyCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001633 RID: 5683
			// (get) Token: 0x06005655 RID: 22101 RVA: 0x0017CF1C File Offset: 0x0017B11C
			// (set) Token: 0x06005656 RID: 22102 RVA: 0x00021587 File Offset: 0x0001F787
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004526 RID: 17702
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x04004527 RID: 17703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x04004528 RID: 17704
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004529 RID: 17705
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TKey_Int32_0;

			// Token: 0x0400452A RID: 17706
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400452B RID: 17707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400452C RID: 17708
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Add_Private_Virtual_Final_New_Void_TKey_0;

			// Token: 0x0400452D RID: 17709
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400452E RID: 17710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Contains_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x0400452F RID: 17711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TKey__Remove_Private_Virtual_Final_New_Boolean_TKey_0;

			// Token: 0x04004530 RID: 17712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TKey__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TKey_0;

			// Token: 0x04004531 RID: 17713
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04004532 RID: 17714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x020006C7 RID: 1735
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x060057F0 RID: 22512 RVA: 0x00180AC4 File Offset: 0x0017ECC4
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "dictionary");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "index");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "version");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, "currentKey");
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673671);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673672);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673673);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673674);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673675);
					Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr, 100673676);
				}

				// Token: 0x060057F1 RID: 22513 RVA: 0x00180C04 File Offset: 0x0017EE04
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 361820, RefRangeEnd = 361823, XrefRangeStart = 361820, XrefRangeEnd = 361820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060057F2 RID: 22514 RVA: 0x00180C54 File Offset: 0x0017EE54
				[CallerCount(3728)]
				[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057F3 RID: 22515 RVA: 0x00180C8C File Offset: 0x0017EE8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361823, XrefRangeEnd = 361824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17001689 RID: 5769
				// (get) Token: 0x060057F4 RID: 22516 RVA: 0x00180CD0 File Offset: 0x0017EED0
				public unsafe TKey Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
					}
				}

				// Token: 0x1700168A RID: 5770
				// (get) Token: 0x060057F5 RID: 22517 RVA: 0x00180D10 File Offset: 0x0017EF10
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361824, XrefRangeEnd = 361827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060057F6 RID: 22518 RVA: 0x00180D54 File Offset: 0x0017EF54
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057F7 RID: 22519 RVA: 0x000227B7 File Offset: 0x000209B7
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060057F8 RID: 22520 RVA: 0x000227C0 File Offset: 0x000209C0
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.KeyCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x17001685 RID: 5765
				// (get) Token: 0x060057F9 RID: 22521 RVA: 0x00180D8C File Offset: 0x0017EF8C
				// (set) Token: 0x060057FA RID: 22522 RVA: 0x000227D2 File Offset: 0x000209D2
				public unsafe Dictionary<TKey, TValue> dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001686 RID: 5766
				// (get) Token: 0x060057FB RID: 22523 RVA: 0x00180DBC File Offset: 0x0017EFBC
				// (set) Token: 0x060057FC RID: 22524 RVA: 0x000227F1 File Offset: 0x000209F1
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x17001687 RID: 5767
				// (get) Token: 0x060057FD RID: 22525 RVA: 0x00180DE4 File Offset: 0x0017EFE4
				// (set) Token: 0x060057FE RID: 22526 RVA: 0x0002280C File Offset: 0x00020A0C
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x17001688 RID: 5768
				// (get) Token: 0x060057FF RID: 22527 RVA: 0x00180E0C File Offset: 0x0017F00C
				// (set) Token: 0x06005800 RID: 22528 RVA: 0x00180E34 File Offset: 0x0017F034
				public unsafe TKey currentKey
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey);
						return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.KeyCollection.Enumerator.NativeFieldInfoPtr_currentKey);
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

				// Token: 0x0400462C RID: 17964
				private static readonly IntPtr NativeFieldInfoPtr_dictionary;

				// Token: 0x0400462D RID: 17965
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x0400462E RID: 17966
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x0400462F RID: 17967
				private static readonly IntPtr NativeFieldInfoPtr_currentKey;

				// Token: 0x04004630 RID: 17968
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x04004631 RID: 17969
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x04004632 RID: 17970
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04004633 RID: 17971
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TKey_0;

				// Token: 0x04004634 RID: 17972
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04004635 RID: 17973
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x02000668 RID: 1640
		[Serializable]
		public sealed class ValueCollection : Object
		{
			// Token: 0x06005657 RID: 22103 RVA: 0x0017CF4C File Offset: 0x0017B14C
			// Note: this type is marked as 'beforefieldinit'.
			static ValueCollection()
			{
				Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>>.NativeClassPtr, "ValueCollection"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr);
				Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "dictionary");
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673677);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673678);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673679);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673680);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673681);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673682);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673683);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673684);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673685);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673686);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673687);
				Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, 100673688);
			}

			// Token: 0x06005658 RID: 22104 RVA: 0x0017D0C8 File Offset: 0x0017B2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361964, XrefRangeEnd = 361965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueCollection(Dictionary<TKey, TValue> dictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005659 RID: 22105 RVA: 0x0017D114 File Offset: 0x0017B314
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 361966, RefRangeEnd = 361985, XrefRangeStart = 361965, XrefRangeEnd = 361966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Dictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Dictionary<TKey, TValue>.ValueCollection.Enumerator(intPtr);
			}

			// Token: 0x0600565A RID: 22106 RVA: 0x0017D14C File Offset: 0x0017B34C
			[CallerCount(0)]
			public unsafe void CopyTo(Il2CppArrayBase<TValue> array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001637 RID: 5687
			// (get) Token: 0x0600565B RID: 22107 RVA: 0x0017D19C File Offset: 0x0017B39C
			public unsafe int Count
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 143823, RefRangeEnd = 143825, XrefRangeStart = 143823, XrefRangeEnd = 143825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001638 RID: 5688
			// (get) Token: 0x0600565C RID: 22108 RVA: 0x0017D1D8 File Offset: 0x0017B3D8
			public unsafe bool System.Collections.Generic.ICollection<TValue>.IsReadOnly
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600565D RID: 22109 RVA: 0x0017D214 File Offset: 0x0017B414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361985, XrefRangeEnd = 362093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Add(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x0600565E RID: 22110 RVA: 0x0017D28C File Offset: 0x0017B48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362093, XrefRangeEnd = 362147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Remove(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600565F RID: 22111 RVA: 0x0017D310 File Offset: 0x0017B510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362147, XrefRangeEnd = 362255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_Generic_ICollection_TValue__Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005660 RID: 22112 RVA: 0x0017D344 File Offset: 0x0017B544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362255, XrefRangeEnd = 362256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool System_Collections_Generic_ICollection_TValue__Contains(TValue item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TValue).IsValueType)
					{
						TValue tvalue = item;
						intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref item;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005661 RID: 22113 RVA: 0x0017D3C8 File Offset: 0x0017B5C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362256, XrefRangeEnd = 362259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TValue> System_Collections_Generic_IEnumerable_TValue__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TValue>>(intPtr3) : null;
			}

			// Token: 0x06005662 RID: 22114 RVA: 0x0017D408 File Offset: 0x0017B608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005663 RID: 22115 RVA: 0x0017D448 File Offset: 0x0017B648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362259, XrefRangeEnd = 362271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005664 RID: 22116 RVA: 0x000215A6 File Offset: 0x0001F7A6
			public ValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001636 RID: 5686
			// (get) Token: 0x06005665 RID: 22117 RVA: 0x0017D498 File Offset: 0x0017B698
			// (set) Token: 0x06005666 RID: 22118 RVA: 0x000215AF File Offset: 0x0001F7AF
			public unsafe Dictionary<TKey, TValue> dictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004533 RID: 17715
			private static readonly IntPtr NativeFieldInfoPtr_dictionary;

			// Token: 0x04004534 RID: 17716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_TKey_TValue_0;

			// Token: 0x04004535 RID: 17717
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_TKey_TValue_0;

			// Token: 0x04004536 RID: 17718
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppArrayBase_1_TValue_Int32_0;

			// Token: 0x04004537 RID: 17719
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04004538 RID: 17720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004539 RID: 17721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Add_Private_Virtual_Final_New_Void_TValue_0;

			// Token: 0x0400453A RID: 17722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Remove_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x0400453B RID: 17723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Clear_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400453C RID: 17724
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_TValue__Contains_Private_Virtual_Final_New_Boolean_TValue_0;

			// Token: 0x0400453D RID: 17725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TValue__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TValue_0;

			// Token: 0x0400453E RID: 17726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400453F RID: 17727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x020006C8 RID: 1736
			[Serializable]
			public sealed class Enumerator : ValueType
			{
				// Token: 0x06005801 RID: 22529 RVA: 0x00180EDC File Offset: 0x0017F0DC
				// Note: this type is marked as 'beforefieldinit'.
				static Enumerator()
				{
					Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection>.NativeClassPtr, "Enumerator"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
					{
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
						Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
					})).TypeHandle.value);
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "dictionary");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "index");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "version");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, "currentValue");
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673689);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673690);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673691);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673692);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673693);
					Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr, 100673694);
				}

				// Token: 0x06005802 RID: 22530 RVA: 0x0018101C File Offset: 0x0017F21C
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 361960, RefRangeEnd = 361963, XrefRangeStart = 361960, XrefRangeEnd = 361960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Enumerator(Dictionary<TKey, TValue> dictionary)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06005803 RID: 22531 RVA: 0x0018106C File Offset: 0x0017F26C
				[CallerCount(3728)]
				[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005804 RID: 22532 RVA: 0x001810A4 File Offset: 0x0017F2A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361963, XrefRangeEnd = 361964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700168F RID: 5775
				// (get) Token: 0x06005805 RID: 22533 RVA: 0x001810E8 File Offset: 0x0017F2E8
				public unsafe TValue Current
				{
					[CallerCount(7)]
					[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
					}
				}

				// Token: 0x17001690 RID: 5776
				// (get) Token: 0x06005806 RID: 22534 RVA: 0x00181128 File Offset: 0x0017F328
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06005807 RID: 22535 RVA: 0x0018116C File Offset: 0x0017F36C
				[CallerCount(0)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06005808 RID: 22536 RVA: 0x00022827 File Offset: 0x00020A27
				public Enumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06005809 RID: 22537 RVA: 0x00022830 File Offset: 0x00020A30
				public Enumerator()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dictionary<TKey, TValue>.ValueCollection.Enumerator>.NativeClassPtr))
				{
				}

				// Token: 0x1700168B RID: 5771
				// (get) Token: 0x0600580A RID: 22538 RVA: 0x001811A4 File Offset: 0x0017F3A4
				// (set) Token: 0x0600580B RID: 22539 RVA: 0x00022842 File Offset: 0x00020A42
				public unsafe Dictionary<TKey, TValue> dictionary
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700168C RID: 5772
				// (get) Token: 0x0600580C RID: 22540 RVA: 0x001811D4 File Offset: 0x0017F3D4
				// (set) Token: 0x0600580D RID: 22541 RVA: 0x00022861 File Offset: 0x00020A61
				public unsafe int index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_index)) = value;
					}
				}

				// Token: 0x1700168D RID: 5773
				// (get) Token: 0x0600580E RID: 22542 RVA: 0x001811FC File Offset: 0x0017F3FC
				// (set) Token: 0x0600580F RID: 22543 RVA: 0x0002287C File Offset: 0x00020A7C
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x1700168E RID: 5774
				// (get) Token: 0x06005810 RID: 22544 RVA: 0x00181224 File Offset: 0x0017F424
				// (set) Token: 0x06005811 RID: 22545 RVA: 0x0018124C File Offset: 0x0017F44C
				public unsafe TValue currentValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue);
						return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dictionary<TKey, TValue>.ValueCollection.Enumerator.NativeFieldInfoPtr_currentValue);
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

				// Token: 0x04004636 RID: 17974
				private static readonly IntPtr NativeFieldInfoPtr_dictionary;

				// Token: 0x04004637 RID: 17975
				private static readonly IntPtr NativeFieldInfoPtr_index;

				// Token: 0x04004638 RID: 17976
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x04004639 RID: 17977
				private static readonly IntPtr NativeFieldInfoPtr_currentValue;

				// Token: 0x0400463A RID: 17978
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_TKey_TValue_0;

				// Token: 0x0400463B RID: 17979
				private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

				// Token: 0x0400463C RID: 17980
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400463D RID: 17981
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TValue_0;

				// Token: 0x0400463E RID: 17982
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400463F RID: 17983
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
			}
		}
	}
}
