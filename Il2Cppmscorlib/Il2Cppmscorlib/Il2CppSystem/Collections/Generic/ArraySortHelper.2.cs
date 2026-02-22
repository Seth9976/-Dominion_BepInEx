using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048F RID: 1167
	public class ArraySortHelper<TKey, TValue> : Object
	{
		// Token: 0x060045D9 RID: 17881 RVA: 0x0013FF60 File Offset: 0x0013E160
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
			Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr);
			ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, "s_defaultArraySortHelper");
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673597);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_CreateArraySortHelper_Private_Static_ArraySortHelper_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673598);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673599);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673600);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673601);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673602);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673603);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673604);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673605);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673606);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673607);
			ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100673608);
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060045DA RID: 17882 RVA: 0x001400E4 File Offset: 0x0013E2E4
		public unsafe static ArraySortHelper<TKey, TValue> Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361693, XrefRangeEnd = 361699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x00140118 File Offset: 0x0013E318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361699, XrefRangeEnd = 361711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArraySortHelper<TKey, TValue> CreateArraySortHelper()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_CreateArraySortHelper_Private_Static_ArraySortHelper_2_TKey_TValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr3) : null;
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x0014014C File Offset: 0x0013E34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361711, XrefRangeEnd = 361713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int index, int length, IComparer<TKey> comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x001401D0 File Offset: 0x0013E3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361713, XrefRangeEnd = 361716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwapIfGreaterWithItems(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, IComparer<TKey> comparer, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DE RID: 17886 RVA: 0x00140248 File Offset: 0x0013E448
		[CallerCount(0)]
		public unsafe static void Swap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int j)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045DF RID: 17887 RVA: 0x001402AC File Offset: 0x0013E4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361716, XrefRangeEnd = 361720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntrospectiveSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int left, int length, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E0 RID: 17888 RVA: 0x00140324 File Offset: 0x0013E524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361720, XrefRangeEnd = 361748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntroSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E1 RID: 17889 RVA: 0x001403AC File Offset: 0x0013E5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361748, XrefRangeEnd = 361773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PickPivotAndPartition(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045E2 RID: 17890 RVA: 0x00140430 File Offset: 0x0013E630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361773, XrefRangeEnd = 361782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Heapsort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E3 RID: 17891 RVA: 0x001404A8 File Offset: 0x0013E6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361782, XrefRangeEnd = 361790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DownHeap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int n, int lo, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x00140530 File Offset: 0x0013E730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361790, XrefRangeEnd = 361794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x001405A8 File Offset: 0x0013E7A8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySortHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x0001A980 File Offset: 0x00018B80
		public ArraySortHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060045E7 RID: 17895 RVA: 0x001405E4 File Offset: 0x0013E7E4
		// (set) Token: 0x060045E8 RID: 17896 RVA: 0x0001A989 File Offset: 0x00018B89
		public unsafe static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArraySortHelper<TKey, TValue>.NativeFieldInfoPtr_s_defaultArraySortHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultArraySortHelper;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeMethodInfoPtr_CreateArraySortHelper_Private_Static_ArraySortHelper_2_TKey_TValue_0;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
