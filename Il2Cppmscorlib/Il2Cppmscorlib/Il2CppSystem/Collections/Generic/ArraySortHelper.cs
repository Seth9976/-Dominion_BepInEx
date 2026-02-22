using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048E RID: 1166
	public class ArraySortHelper<T> : Object
	{
		// Token: 0x060045CB RID: 17867 RVA: 0x0013F890 File Offset: 0x0013DA90
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySortHelper()
		{
			Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr);
			ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673585);
			ArraySortHelper<T>.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673586);
			ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673587);
			ArraySortHelper<T>.NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673588);
			ArraySortHelper<T>.NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673589);
			ArraySortHelper<T>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673590);
			ArraySortHelper<T>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673591);
			ArraySortHelper<T>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673592);
			ArraySortHelper<T>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673593);
			ArraySortHelper<T>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673594);
			ArraySortHelper<T>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673595);
			ArraySortHelper<T>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100673596);
		}

		// Token: 0x060045CC RID: 17868 RVA: 0x0013F9EC File Offset: 0x0013DBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361579, XrefRangeEnd = 361597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Il2CppArrayBase<T> keys, int index, int length, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CD RID: 17869 RVA: 0x0013FA50 File Offset: 0x0013DC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361597, XrefRangeEnd = 361603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045CE RID: 17870 RVA: 0x0013FB08 File Offset: 0x0013DD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361603, XrefRangeEnd = 361608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Sort(Il2CppArrayBase<T> keys, int index, int length, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045CF RID: 17871 RVA: 0x0013FB6C File Offset: 0x0013DD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361608, XrefRangeEnd = 361613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalBinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060045D0 RID: 17872 RVA: 0x0013FC24 File Offset: 0x0013DE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361613, XrefRangeEnd = 361616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SwapIfGreater(Il2CppArrayBase<T> keys, Comparison<T> comparer, int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D1 RID: 17873 RVA: 0x0013FC88 File Offset: 0x0013DE88
		[CallerCount(0)]
		public unsafe static void Swap(Il2CppArrayBase<T> a, int i, int j)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref j;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D2 RID: 17874 RVA: 0x0013FCDC File Offset: 0x0013DEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 361620, RefRangeEnd = 361621, XrefRangeStart = 361616, XrefRangeEnd = 361620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntrospectiveSort(Il2CppArrayBase<T> keys, int left, int length, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref left;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D3 RID: 17875 RVA: 0x0013FD40 File Offset: 0x0013DF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361621, XrefRangeEnd = 361649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IntroSort(Il2CppArrayBase<T> keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthLimit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x0013FDB4 File Offset: 0x0013DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361649, XrefRangeEnd = 361674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PickPivotAndPartition(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045D5 RID: 17877 RVA: 0x0013FE24 File Offset: 0x0013E024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361674, XrefRangeEnd = 361683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Heapsort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D6 RID: 17878 RVA: 0x0013FE88 File Offset: 0x0013E088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361683, XrefRangeEnd = 361690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DownHeap(Il2CppArrayBase<T> keys, int i, int n, int lo, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D7 RID: 17879 RVA: 0x0013FEFC File Offset: 0x0013E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361690, XrefRangeEnd = 361693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InsertionSort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySortHelper<T>.NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045D8 RID: 17880 RVA: 0x0001A977 File Offset: 0x00018B77
		public ArraySortHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeMethodInfoPtr_BinarySearch_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;
	}
}
