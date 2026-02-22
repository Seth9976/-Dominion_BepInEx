using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000007 RID: 7
	public static class Enumerable : Object
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00004374 File Offset: 0x00002574
		// Note: this type is marked as 'beforefieldinit'.
		static Enumerable()
		{
			Il2CppClassPointerStore<Enumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Enumerable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable>.NativeClassPtr);
			Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663346);
			Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663347);
			Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663348);
			Enumerable.NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663349);
			Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663350);
			Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663351);
			Enumerable.NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663352);
			Enumerable.NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663353);
			Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663354);
			Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663355);
			Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663356);
			Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663357);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663358);
			Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663359);
			Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663360);
			Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663361);
			Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663362);
			Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663363);
			Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663364);
			Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663365);
			Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663366);
			Enumerable.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663367);
			Enumerable.NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663368);
			Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663369);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663370);
			Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663371);
			Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663372);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663373);
			Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663374);
			Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, 100663375);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000045FC File Offset: 0x000027FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58120, RefRangeEnd = 58121, XrefRangeStart = 58112, XrefRangeEnd = 58120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004654 File Offset: 0x00002854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58134, RefRangeEnd = 58135, XrefRangeStart = 58121, XrefRangeEnd = 58134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000046AC File Offset: 0x000028AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58143, RefRangeEnd = 58144, XrefRangeStart = 58135, XrefRangeEnd = 58143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004704 File Offset: 0x00002904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58144, XrefRangeEnd = 58146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000475C File Offset: 0x0000295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58146, XrefRangeEnd = 58150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr3) : null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000047B4 File Offset: 0x000029B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58150, XrefRangeEnd = 58154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr3) : null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000480C File Offset: 0x00002A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58160, RefRangeEnd = 58161, XrefRangeStart = 58154, XrefRangeEnd = 58160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004860 File Offset: 0x00002A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58161, XrefRangeEnd = 58163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TSource> TakeIterator<TSource>(IEnumerable<TSource> source, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000048B4 File Offset: 0x00002AB4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58165, RefRangeEnd = 58175, XrefRangeStart = 58163, XrefRangeEnd = 58165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000490C File Offset: 0x00002B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58177, RefRangeEnd = 58179, XrefRangeStart = 58175, XrefRangeEnd = 58177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TSource>>(intPtr3) : null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004964 File Offset: 0x00002B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58181, RefRangeEnd = 58182, XrefRangeStart = 58179, XrefRangeEnd = 58181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<TSource> ToArray<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000049A0 File Offset: 0x00002BA0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 58184, RefRangeEnd = 58204, XrefRangeStart = 58182, XrefRangeEnd = 58184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr3) : null;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000049E4 File Offset: 0x00002BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58204, RefRangeEnd = 58206, XrefRangeStart = 58204, XrefRangeEnd = 58204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TSource>>(intPtr3) : null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004A3C File Offset: 0x00002C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58206, XrefRangeEnd = 58220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementSelector);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TElement>>(intPtr3) : null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58222, RefRangeEnd = 58223, XrefRangeStart = 58220, XrefRangeEnd = 58222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004AFC File Offset: 0x00002CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58223, XrefRangeEnd = 58225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004B40 File Offset: 0x00002D40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58239, RefRangeEnd = 58240, XrefRangeStart = 58225, XrefRangeEnd = 58239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource First<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004B80 File Offset: 0x00002D80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58252, RefRangeEnd = 58255, XrefRangeStart = 58240, XrefRangeEnd = 58252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004BD0 File Offset: 0x00002DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58273, RefRangeEnd = 58276, XrefRangeStart = 58255, XrefRangeEnd = 58273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Last<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004C10 File Offset: 0x00002E10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58289, RefRangeEnd = 58293, XrefRangeStart = 58276, XrefRangeEnd = 58289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58308, RefRangeEnd = 58311, XrefRangeStart = 58293, XrefRangeEnd = 58308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004CAC File Offset: 0x00002EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58315, RefRangeEnd = 58316, XrefRangeStart = 58311, XrefRangeEnd = 58315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = element;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr4) : null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004D34 File Offset: 0x00002F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58316, XrefRangeEnd = 58318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = element;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr4) : null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004DBC File Offset: 0x00002FBC
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 58322, RefRangeEnd = 58381, XrefRangeStart = 58318, XrefRangeEnd = 58322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TResult> Empty<TResult>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004DF0 File Offset: 0x00002FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58391, RefRangeEnd = 58392, XrefRangeStart = 58381, XrefRangeEnd = 58391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004E34 File Offset: 0x00003034
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58404, RefRangeEnd = 58408, XrefRangeStart = 58392, XrefRangeEnd = 58404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004E88 File Offset: 0x00003088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58424, RefRangeEnd = 58427, XrefRangeStart = 58408, XrefRangeEnd = 58424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Count<TSource>(this IEnumerable<TSource> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004ECC File Offset: 0x000030CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 58432, RefRangeEnd = 58440, XrefRangeStart = 58427, XrefRangeEnd = 58432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004F58 File Offset: 0x00003158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58440, XrefRangeEnd = 58455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TSource).IsValueType)
			{
				TSource tsource = value;
				intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004FF4 File Offset: 0x000031F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58471, RefRangeEnd = 58472, XrefRangeStart = 58455, XrefRangeEnd = 58471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(func);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.MethodInfoStoreGeneric_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0<TSource>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000021F0 File Offset: 0x000003F0
		public Enumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0;

		// Token: 0x02000013 RID: 19
		public class Iterator<TSource> : Object
		{
			// Token: 0x06000110 RID: 272 RVA: 0x00007244 File Offset: 0x00005444
			// Note: this type is marked as 'beforefieldinit'.
			static Iterator()
			{
				Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "Iterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr);
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "threadId");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "state");
				Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, "current");
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663376);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663377);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663378);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663379);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663380);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663381);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663382);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663383);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663384);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663385);
				Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr, 100663386);
			}

			// Token: 0x06000111 RID: 273 RVA: 0x000073C4 File Offset: 0x000055C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57930, XrefRangeEnd = 57933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Iterator()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.Iterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00007400 File Offset: 0x00005600
			public unsafe virtual TSource Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x0000743C File Offset: 0x0000563C
			[CallerCount(0)]
			public unsafe virtual Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x00007488 File Offset: 0x00005688
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000115 RID: 277 RVA: 0x000074C4 File Offset: 0x000056C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57933, XrefRangeEnd = 57935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<TSource> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00007504 File Offset: 0x00005704
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x0000754C File Offset: 0x0000574C
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TResult>.MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000118 RID: 280 RVA: 0x000075A8 File Offset: 0x000057A8
			[CallerCount(0)]
			public unsafe virtual IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.Iterator<TSource>.NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00007604 File Offset: 0x00005804
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57935, XrefRangeEnd = 57937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00007644 File Offset: 0x00005844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57937, XrefRangeEnd = 57938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00007684 File Offset: 0x00005884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57938, XrefRangeEnd = 57948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.Iterator<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600011C RID: 284 RVA: 0x000025DC File Offset: 0x000007DC
			public Iterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600011D RID: 285 RVA: 0x000076B8 File Offset: 0x000058B8
			// (set) Token: 0x0600011E RID: 286 RVA: 0x000025E5 File Offset: 0x000007E5
			public unsafe int threadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_threadId)) = value;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600011F RID: 287 RVA: 0x000076E0 File Offset: 0x000058E0
			// (set) Token: 0x06000120 RID: 288 RVA: 0x00002600 File Offset: 0x00000800
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00007708 File Offset: 0x00005908
			// (set) Token: 0x06000122 RID: 290 RVA: 0x00007730 File Offset: 0x00005930
			public unsafe TSource current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.Iterator<TSource>.NativeFieldInfoPtr_current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeFieldInfoPtr_threadId;

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040000B9 RID: 185
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040000BA RID: 186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000BB RID: 187
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_TSource_0;

			// Token: 0x040000BC RID: 188
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Iterator_1_TSource_0;

			// Token: 0x040000BD RID: 189
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

			// Token: 0x040000BE RID: 190
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x040000BF RID: 191
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

			// Token: 0x040000C0 RID: 192
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x040000C1 RID: 193
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Abstract_Virtual_New_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x040000C2 RID: 194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000C3 RID: 195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x040000C4 RID: 196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x02000047 RID: 71
			private sealed class MethodInfoStoreGeneric_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000181 RID: 385
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.Iterator<TResult>.NativeMethodInfoPtr_Select_Public_Abstract_Virtual_New_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.Iterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000014 RID: 20
		public class WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000123 RID: 291 RVA: 0x000077D8 File Offset: 0x000059D8
			// Note: this type is marked as 'beforefieldinit'.
			static WhereEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereEnumerableIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663387);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663388);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663389);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663390);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663391);
				Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr, 100663392);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000078F4 File Offset: 0x00005AF4
			[CallerCount(0)]
			public unsafe WhereEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00007954 File Offset: 0x00005B54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57948, XrefRangeEnd = 57950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x000079A0 File Offset: 0x00005BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57950, XrefRangeEnd = 57953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000127 RID: 295 RVA: 0x000079DC File Offset: 0x00005BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57953, XrefRangeEnd = 57963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00007A24 File Offset: 0x00005C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57963, XrefRangeEnd = 57965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00007A80 File Offset: 0x00005C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57965, XrefRangeEnd = 57967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereEnumerableIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x0000261B File Offset: 0x0000081B
			public WhereEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00007ADC File Offset: 0x00005CDC
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00002624 File Offset: 0x00000824
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00007B0C File Offset: 0x00005D0C
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00002643 File Offset: 0x00000843
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00007B3C File Offset: 0x00005D3C
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00002662 File Offset: 0x00000862
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereEnumerableIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000C5 RID: 197
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000C7 RID: 199
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040000C8 RID: 200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x040000C9 RID: 201
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x040000CA RID: 202
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x040000CB RID: 203
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000CC RID: 204
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x040000CD RID: 205
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000048 RID: 72
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000182 RID: 386
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereEnumerableIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereEnumerableIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000015 RID: 21
		public class WhereArrayIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x06000131 RID: 305 RVA: 0x00007B6C File Offset: 0x00005D6C
			// Note: this type is marked as 'beforefieldinit'.
			static WhereArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereArrayIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, "index");
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663393);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663394);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663395);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663396);
				Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr, 100663397);
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00007C74 File Offset: 0x00005E74
			[CallerCount(0)]
			public unsafe WhereArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00007CD4 File Offset: 0x00005ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00007D20 File Offset: 0x00005F20
			[CallerCount(0)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00007D68 File Offset: 0x00005F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00007DC4 File Offset: 0x00005FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57967, XrefRangeEnd = 57969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereArrayIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x06000137 RID: 311 RVA: 0x00002681 File Offset: 0x00000881
			public WhereArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000138 RID: 312 RVA: 0x00007E20 File Offset: 0x00006020
			// (set) Token: 0x06000139 RID: 313 RVA: 0x0000268A File Offset: 0x0000088A
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600013A RID: 314 RVA: 0x00007E48 File Offset: 0x00006048
			// (set) Token: 0x0600013B RID: 315 RVA: 0x000026A9 File Offset: 0x000008A9
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600013C RID: 316 RVA: 0x00007E78 File Offset: 0x00006078
			// (set) Token: 0x0600013D RID: 317 RVA: 0x000026C8 File Offset: 0x000008C8
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereArrayIterator<TSource>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x040000CE RID: 206
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000CF RID: 207
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000D0 RID: 208
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040000D1 RID: 209
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x040000D2 RID: 210
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x040000D3 RID: 211
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000D4 RID: 212
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x040000D5 RID: 213
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x02000049 RID: 73
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000183 RID: 387
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereArrayIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereArrayIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000016 RID: 22
		public class WhereListIterator<TSource> : Enumerable.Iterator<TSource>
		{
			// Token: 0x0600013E RID: 318 RVA: 0x00007EA0 File Offset: 0x000060A0
			// Note: this type is marked as 'beforefieldinit'.
			static WhereListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereListIterator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr);
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "source");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "predicate");
				Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, "enumerator");
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663398);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663399);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663400);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663401);
				Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr, 100663402);
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00007FA8 File Offset: 0x000061A8
			[CallerCount(0)]
			public unsafe WhereListIterator(List<TSource> source, Func<TSource, bool> predicate)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereListIterator<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00008008 File Offset: 0x00006208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TSource> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TSource>>(intPtr3) : null;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00008054 File Offset: 0x00006254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57969, XrefRangeEnd = 57971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000142 RID: 322 RVA: 0x0000809C File Offset: 0x0000629C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TResult>.MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000143 RID: 323 RVA: 0x000080F8 File Offset: 0x000062F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57971, XrefRangeEnd = 57973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TSource> Where(Func<TSource, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereListIterator<TSource>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr3) : null;
				}
			}

			// Token: 0x06000144 RID: 324 RVA: 0x000026E3 File Offset: 0x000008E3
			public WhereListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00008154 File Offset: 0x00006354
			// (set) Token: 0x06000146 RID: 326 RVA: 0x000026EC File Offset: 0x000008EC
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00008184 File Offset: 0x00006384
			// (set) Token: 0x06000148 RID: 328 RVA: 0x0000270B File Offset: 0x0000090B
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000149 RID: 329 RVA: 0x000081B4 File Offset: 0x000063B4
			// (set) Token: 0x0600014A RID: 330 RVA: 0x0000272A File Offset: 0x0000092A
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereListIterator<TSource>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040000D6 RID: 214
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000D7 RID: 215
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000D8 RID: 216
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040000D9 RID: 217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x040000DA RID: 218
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TSource_0;

			// Token: 0x040000DB RID: 219
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000DC RID: 220
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0;

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TSource_Func_2_TSource_Boolean_0;

			// Token: 0x0200004A RID: 74
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0
			{
				// Token: 0x04000184 RID: 388
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.WhereListIterator<TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable.WhereListIterator<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000017 RID: 23
		public class WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x0600014B RID: 331 RVA: 0x000081E4 File Offset: 0x000063E4
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectEnumerableIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectEnumerableIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663403);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663404);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663405);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663406);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663407);
				Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr, 100663408);
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00008324 File Offset: 0x00006524
			[CallerCount(0)]
			public unsafe WhereSelectEnumerableIterator(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectEnumerableIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00008394 File Offset: 0x00006594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57973, XrefRangeEnd = 57975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x0600014E RID: 334 RVA: 0x000083E0 File Offset: 0x000065E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57975, XrefRangeEnd = 57994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014F RID: 335 RVA: 0x0000841C File Offset: 0x0000661C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57994, XrefRangeEnd = 58002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00008464 File Offset: 0x00006664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58002, XrefRangeEnd = 58004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (06000150)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x06000151 RID: 337 RVA: 0x000084C0 File Offset: 0x000066C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58004, XrefRangeEnd = 58006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000152 RID: 338 RVA: 0x00002758 File Offset: 0x00000958
			public WhereSelectEnumerableIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000153 RID: 339 RVA: 0x0000851C File Offset: 0x0000671C
			// (set) Token: 0x06000154 RID: 340 RVA: 0x00002761 File Offset: 0x00000961
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000155 RID: 341 RVA: 0x0000854C File Offset: 0x0000674C
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00002780 File Offset: 0x00000980
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000157 RID: 343 RVA: 0x0000857C File Offset: 0x0000677C
			// (set) Token: 0x06000158 RID: 344 RVA: 0x0000279F File Offset: 0x0000099F
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000159 RID: 345 RVA: 0x000085AC File Offset: 0x000067AC
			// (set) Token: 0x0600015A RID: 346 RVA: 0x000027BE File Offset: 0x000009BE
			public unsafe IEnumerator<TSource> enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectEnumerableIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

			// Token: 0x040000E5 RID: 229
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000E6 RID: 230
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x040000E7 RID: 231
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x0200004B RID: 75
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000252 RID: 594 RVA: 0x0000C198 File Offset: 0x0000A398
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000252)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectEnumerableIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x04000185 RID: 389
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x02000018 RID: 24
		public class WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x0600015B RID: 347 RVA: 0x000085DC File Offset: 0x000067DC
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectArrayIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectArrayIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, "index");
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663409);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663410);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663411);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663412);
				Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr, 100663413);
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00008708 File Offset: 0x00006908
			[CallerCount(0)]
			public unsafe WhereSelectArrayIterator(Il2CppArrayBase<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectArrayIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00008778 File Offset: 0x00006978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x0600015E RID: 350 RVA: 0x000087C4 File Offset: 0x000069C4
			[CallerCount(0)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600015F RID: 351 RVA: 0x0000880C File Offset: 0x00006A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (0600015F)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x06000160 RID: 352 RVA: 0x00008868 File Offset: 0x00006A68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58006, XrefRangeEnd = 58008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000161 RID: 353 RVA: 0x000027DD File Offset: 0x000009DD
			public WhereSelectArrayIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000162 RID: 354 RVA: 0x000088C4 File Offset: 0x00006AC4
			// (set) Token: 0x06000163 RID: 355 RVA: 0x000027E6 File Offset: 0x000009E6
			public unsafe Il2CppArrayBase<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					return Il2CppArrayBase<TSource>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000164 RID: 356 RVA: 0x000088EC File Offset: 0x00006AEC
			// (set) Token: 0x06000165 RID: 357 RVA: 0x00002805 File Offset: 0x00000A05
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000166 RID: 358 RVA: 0x0000891C File Offset: 0x00006B1C
			// (set) Token: 0x06000167 RID: 359 RVA: 0x00002824 File Offset: 0x00000A24
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000168 RID: 360 RVA: 0x0000894C File Offset: 0x00006B4C
			// (set) Token: 0x06000169 RID: 361 RVA: 0x00002843 File Offset: 0x00000A43
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectArrayIterator<TSource, TResult>.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000EA RID: 234
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x040000EB RID: 235
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040000EC RID: 236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppArrayBase_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x040000ED RID: 237
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x040000EE RID: 238
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000EF RID: 239
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x040000F0 RID: 240
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x0200004C RID: 76
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000253 RID: 595 RVA: 0x0000C1EC File Offset: 0x0000A3EC
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000253)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectArrayIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x04000186 RID: 390
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x02000019 RID: 25
		public class WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult>
		{
			// Token: 0x0600016A RID: 362 RVA: 0x00008974 File Offset: 0x00006B74
			// Note: this type is marked as 'beforefieldinit'.
			static WhereSelectListIterator()
			{
				Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "WhereSelectListIterator`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "predicate");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, "enumerator");
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663414);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663415);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663416);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663417);
				Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr, 100663418);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00008AA0 File Offset: 0x00006CA0
			[CallerCount(0)]
			public unsafe WhereSelectListIterator(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.WhereSelectListIterator<TSource, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00008B10 File Offset: 0x00006D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Enumerable.Iterator<TResult> Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enumerable.Iterator<TResult>>(intPtr3) : null;
			}

			// Token: 0x0600016D RID: 365 RVA: 0x00008B5C File Offset: 0x00006D5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58008, XrefRangeEnd = 58011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00008BA4 File Offset: 0x00006DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector)
			{
				/*
An exception occurred when decompiling this method (0600016E)

ICSharpCode.Decompiler.DecompilerException: Error decompiling Il2CppSystem.Collections.Generic.IEnumerable`1<TResult2> Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2::Select<TResult2>(Il2CppSystem.Func`2<TResult,TResult2>)

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 874
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 488
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00008C00 File Offset: 0x00006E00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58011, XrefRangeEnd = 58013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<TResult> Where(Func<TResult, bool> predicate)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(predicate);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Enumerable.WhereSelectListIterator<TSource, TResult>.NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x06000170 RID: 368 RVA: 0x0000285E File Offset: 0x00000A5E
			public WhereSelectListIterator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000171 RID: 369 RVA: 0x00008C5C File Offset: 0x00006E5C
			// (set) Token: 0x06000172 RID: 370 RVA: 0x00002867 File Offset: 0x00000A67
			public unsafe List<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000173 RID: 371 RVA: 0x00008C8C File Offset: 0x00006E8C
			// (set) Token: 0x06000174 RID: 372 RVA: 0x00002886 File Offset: 0x00000A86
			public unsafe Func<TSource, bool> predicate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_predicate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00008CBC File Offset: 0x00006EBC
			// (set) Token: 0x06000176 RID: 374 RVA: 0x000028A5 File Offset: 0x00000AA5
			public unsafe Func<TSource, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000177 RID: 375 RVA: 0x00008CEC File Offset: 0x00006EEC
			// (set) Token: 0x06000178 RID: 376 RVA: 0x000028C4 File Offset: 0x00000AC4
			public List<TSource>.Enumerator enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator);
					return new List<TSource>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.WhereSelectListIterator<TSource, TResult>.NativeFieldInfoPtr_enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<TSource>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000F2 RID: 242
			private static readonly IntPtr NativeFieldInfoPtr_predicate;

			// Token: 0x040000F3 RID: 243
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeFieldInfoPtr_enumerator;

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TSource_Func_2_TSource_Boolean_Func_2_TSource_TResult_0;

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Iterator_1_TResult_0;

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Boolean_0;

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0;

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeMethodInfoPtr_Where_Public_Virtual_IEnumerable_1_TResult_Func_2_TResult_Boolean_0;

			// Token: 0x0200004D RID: 77
			private sealed class MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0
			{
				// Token: 0x06000254 RID: 596 RVA: 0x0000C240 File Offset: 0x0000A440
				// Note: this type is marked as 'beforefieldinit'.
				static MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0()
				{
					/*
An exception occurred when decompiling this method (06000254)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Il2CppSystem.Linq.Enumerable/WhereSelectListIterator`2/MethodInfoStoreGeneric_Select_Public_Virtual_IEnumerable_1_TResult2_Func_2_TResult_TResult2_0`1::.cctor()

 ---> System.ArgumentOutOfRangeException: Non-negative number required. (Parameter 'count')
   at System.Collections.Generic.List`1.GetRange(Int32 index, Int32 count)
   at ICSharpCode.Decompiler.Ast.AstBuilder.ApplyTypeArgumentsTo(AstType baseType, List`1 typeArguments) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 947
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(TypeSig type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 712
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, IHasCustomAttribute typeAttributes, Int32& typeIndex, ConvertTypeOptions options, Int32 depth, StringBuilder sb) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 817
   at ICSharpCode.Decompiler.Ast.AstBuilder.ConvertType(ITypeDefOrRef type, StringBuilder sb, IHasCustomAttribute typeAttributes, ConvertTypeOptions options) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 666
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformByteCode(ILExpression byteCode) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 881
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformExpression(ILExpression expr) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 407
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformNode(ILNode node) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 268
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.TransformBlock(ILBlock block) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 252
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 150
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 88
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 92
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1686
*/;
				}

				// Token: 0x04000187 RID: 391
				internal static IntPtr Pointer;
			}
		}

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("System.Linq.Enumerable+<SelectIterator>d__5`2")]
		public sealed class _SelectIterator_d__5<TSource, TResult> : Object
		{
			// Token: 0x06000179 RID: 377 RVA: 0x00008D1C File Offset: 0x00006F1C
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectIterator_d__5()
			{
				Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<SelectIterator>d__5`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "source");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<index>5__1");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "selector");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>3__selector");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663419);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663420);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663421);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663422);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663423);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663424);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663425);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663426);
				Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr, 100663427);
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00008EFC File Offset: 0x000070FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58013, XrefRangeEnd = 58015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectIterator_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._SelectIterator_d__5<TSource, TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00008F44 File Offset: 0x00007144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58015, XrefRangeEnd = 58016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00008F78 File Offset: 0x00007178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58016, XrefRangeEnd = 58029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00008FB4 File Offset: 0x000071B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58029, XrefRangeEnd = 58032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600017E RID: 382 RVA: 0x00008FE8 File Offset: 0x000071E8
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x0600017F RID: 383 RVA: 0x00009024 File Offset: 0x00007224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58032, XrefRangeEnd = 58042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00009058 File Offset: 0x00007258
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000181 RID: 385 RVA: 0x00009098 File Offset: 0x00007298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58042, XrefRangeEnd = 58046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x06000182 RID: 386 RVA: 0x000090D8 File Offset: 0x000072D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58046, XrefRangeEnd = 58047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000183 RID: 387 RVA: 0x000028F2 File Offset: 0x00000AF2
			public _SelectIterator_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000184 RID: 388 RVA: 0x00009118 File Offset: 0x00007318
			// (set) Token: 0x06000185 RID: 389 RVA: 0x000028FB File Offset: 0x00000AFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000186 RID: 390 RVA: 0x00009140 File Offset: 0x00007340
			// (set) Token: 0x06000187 RID: 391 RVA: 0x00009168 File Offset: 0x00007368
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000188 RID: 392 RVA: 0x00009210 File Offset: 0x00007410
			// (set) Token: 0x06000189 RID: 393 RVA: 0x00002916 File Offset: 0x00000B16
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00009238 File Offset: 0x00007438
			// (set) Token: 0x0600018B RID: 395 RVA: 0x00002931 File Offset: 0x00000B31
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00009268 File Offset: 0x00007468
			// (set) Token: 0x0600018D RID: 397 RVA: 0x00002950 File Offset: 0x00000B50
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x0600018E RID: 398 RVA: 0x00009298 File Offset: 0x00007498
			// (set) Token: 0x0600018F RID: 399 RVA: 0x0000296F File Offset: 0x00000B6F
			public unsafe int _index_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr__index_5__1)) = value;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000190 RID: 400 RVA: 0x000092C0 File Offset: 0x000074C0
			// (set) Token: 0x06000191 RID: 401 RVA: 0x0000298A File Offset: 0x00000B8A
			public unsafe Func<TSource, int, TResult> selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000192 RID: 402 RVA: 0x000092F0 File Offset: 0x000074F0
			// (set) Token: 0x06000193 RID: 403 RVA: 0x000029A9 File Offset: 0x00000BA9
			public unsafe Func<TSource, int, TResult> __3__selector
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, int, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___3__selector), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00009320 File Offset: 0x00007520
			// (set) Token: 0x06000195 RID: 405 RVA: 0x000029C8 File Offset: 0x00000BC8
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._SelectIterator_d__5<TSource, TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000FC RID: 252
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeFieldInfoPtr__index_5__1;

			// Token: 0x04000100 RID: 256
			private static readonly IntPtr NativeFieldInfoPtr_selector;

			// Token: 0x04000101 RID: 257
			private static readonly IntPtr NativeFieldInfoPtr___3__selector;

			// Token: 0x04000102 RID: 258
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000103 RID: 259
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000104 RID: 260
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000105 RID: 261
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000106 RID: 262
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<TSource> : Object
		{
			// Token: 0x06000196 RID: 406 RVA: 0x00009350 File Offset: 0x00007550
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate1");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, "predicate2");
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663428);
				Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr, 100663429);
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00009408 File Offset: 0x00007608
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass6_0<TSource>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x00009444 File Offset: 0x00007644
			[CallerCount(0)]
			public unsafe bool _CombinePredicates_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass6_0<TSource>.NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06000199 RID: 409 RVA: 0x000029E7 File Offset: 0x00000BE7
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600019A RID: 410 RVA: 0x000094C8 File Offset: 0x000076C8
			// (set) Token: 0x0600019B RID: 411 RVA: 0x000029F0 File Offset: 0x00000BF0
			public unsafe Func<TSource, bool> predicate1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600019C RID: 412 RVA: 0x000094F8 File Offset: 0x000076F8
			// (set) Token: 0x0600019D RID: 413 RVA: 0x00002A0F File Offset: 0x00000C0F
			public unsafe Func<TSource, bool> predicate2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass6_0<TSource>.NativeFieldInfoPtr_predicate2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeFieldInfoPtr_predicate1;

			// Token: 0x0400010D RID: 269
			private static readonly IntPtr NativeFieldInfoPtr_predicate2;

			// Token: 0x0400010E RID: 270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400010F RID: 271
			private static readonly IntPtr NativeMethodInfoPtr__CombinePredicates_b__0_Internal_Boolean_TSource_0;
		}

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("System.Linq.Enumerable+<>c__DisplayClass7_0`3")]
		public sealed class __c__DisplayClass7_0<TSource, TMiddle, TResult> : Object
		{
			// Token: 0x0600019E RID: 414 RVA: 0x00009528 File Offset: 0x00007728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<>c__DisplayClass7_0`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector2");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, "selector1");
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663430);
				Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr, 100663431);
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00009604 File Offset: 0x00007804
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00009640 File Offset: 0x00007840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58047, XrefRangeEnd = 58048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TResult _CombineSelectors_b__0(TSource x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSource).IsValueType)
					{
						TSource tsource = x;
						intPtr = ((tsource is string) ? IL2CPP.ManagedStringToIl2Cpp(tsource as string) : IL2CPP.Il2CppObjectBaseToPtr(tsource as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref x;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
				}
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00002A2E File Offset: 0x00000C2E
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x000096C0 File Offset: 0x000078C0
			// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002A37 File Offset: 0x00000C37
			public unsafe Func<TMiddle, TResult> selector2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TMiddle, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001A4 RID: 420 RVA: 0x000096F0 File Offset: 0x000078F0
			// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002A56 File Offset: 0x00000C56
			public unsafe Func<TSource, TMiddle> selector1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSource, TMiddle>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable.__c__DisplayClass7_0<TSource, TMiddle, TResult>.NativeFieldInfoPtr_selector1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeFieldInfoPtr_selector2;

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeFieldInfoPtr_selector1;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeMethodInfoPtr__CombineSelectors_b__0_Internal_TResult_TSource_0;
		}

		// Token: 0x0200001D RID: 29
		[ObfuscatedName("System.Linq.Enumerable+<TakeIterator>d__25`1")]
		public sealed class _TakeIterator_d__25<TSource> : Object
		{
			// Token: 0x060001A6 RID: 422 RVA: 0x00009720 File Offset: 0x00007920
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeIterator_d__25()
			{
				Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<TakeIterator>d__25`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr);
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>1__state");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>2__current");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "count");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>3__count");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "source");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>3__source");
				Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663432);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663433);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663434);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663435);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663436);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663437);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663438);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663439);
				Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr, 100663440);
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x000098DC File Offset: 0x00007ADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeIterator_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._TakeIterator_d__25<TSource>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00009924 File Offset: 0x00007B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00009958 File Offset: 0x00007B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58048, XrefRangeEnd = 58059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00009994 File Offset: 0x00007B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58059, XrefRangeEnd = 58062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060001AB RID: 427 RVA: 0x000099C8 File Offset: 0x00007BC8
			public unsafe TSource System.Collections.Generic.IEnumerator<TSource>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, false, true);
				}
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00009A04 File Offset: 0x00007C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58062, XrefRangeEnd = 58067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060001AD RID: 429 RVA: 0x00009A38 File Offset: 0x00007C38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00009A78 File Offset: 0x00007C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58067, XrefRangeEnd = 58071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TSource> System_Collections_Generic_IEnumerable_TSource__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr3) : null;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00009AB8 File Offset: 0x00007CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58071, XrefRangeEnd = 58072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._TakeIterator_d__25<TSource>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00002A75 File Offset: 0x00000C75
			public _TakeIterator_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060001B1 RID: 433 RVA: 0x00009AF8 File Offset: 0x00007CF8
			// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002A7E File Offset: 0x00000C7E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060001B3 RID: 435 RVA: 0x00009B20 File Offset: 0x00007D20
			// (set) Token: 0x060001B4 RID: 436 RVA: 0x00009B48 File Offset: 0x00007D48
			public unsafe TSource __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TSource>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TSource);
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

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060001B5 RID: 437 RVA: 0x00009BF0 File Offset: 0x00007DF0
			// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002A99 File Offset: 0x00000C99
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060001B7 RID: 439 RVA: 0x00009C18 File Offset: 0x00007E18
			// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002AB4 File Offset: 0x00000CB4
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060001B9 RID: 441 RVA: 0x00009C40 File Offset: 0x00007E40
			// (set) Token: 0x060001BA RID: 442 RVA: 0x00002ACF File Offset: 0x00000CCF
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060001BB RID: 443 RVA: 0x00009C68 File Offset: 0x00007E68
			// (set) Token: 0x060001BC RID: 444 RVA: 0x00002AEA File Offset: 0x00000CEA
			public unsafe IEnumerable<TSource> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060001BD RID: 445 RVA: 0x00009C98 File Offset: 0x00007E98
			// (set) Token: 0x060001BE RID: 446 RVA: 0x00002B09 File Offset: 0x00000D09
			public unsafe IEnumerable<TSource> __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060001BF RID: 447 RVA: 0x00009CC8 File Offset: 0x00007EC8
			// (set) Token: 0x060001C0 RID: 448 RVA: 0x00002B28 File Offset: 0x00000D28
			public unsafe IEnumerator<TSource> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<TSource>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._TakeIterator_d__25<TSource>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TSource__get_Current_Private_Virtual_Final_New_get_TSource_0;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TSource__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TSource_0;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200001E RID: 30
		[ObfuscatedName("System.Linq.Enumerable+<CastIterator>d__99`1")]
		public sealed class _CastIterator_d__99<TResult> : Object
		{
			// Token: 0x060001C1 RID: 449 RVA: 0x00009CF8 File Offset: 0x00007EF8
			// Note: this type is marked as 'beforefieldinit'.
			static _CastIterator_d__99()
			{
				Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<CastIterator>d__99`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr);
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>3__source");
				Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, "<>7__wrap1");
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663441);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663442);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663443);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663444);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663445);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663446);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663447);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663448);
				Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr, 100663449);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00009E8C File Offset: 0x0000808C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CastIterator_d__99(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._CastIterator_d__99<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00009ED4 File Offset: 0x000080D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00009F08 File Offset: 0x00008108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58072, XrefRangeEnd = 58087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00009F44 File Offset: 0x00008144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58087, XrefRangeEnd = 58092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060001C6 RID: 454 RVA: 0x00009F78 File Offset: 0x00008178
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00009FB4 File Offset: 0x000081B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58092, XrefRangeEnd = 58097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060001C8 RID: 456 RVA: 0x00009FE8 File Offset: 0x000081E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x0000A028 File Offset: 0x00008228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58097, XrefRangeEnd = 58101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x0000A068 File Offset: 0x00008268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58101, XrefRangeEnd = 58102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._CastIterator_d__99<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00002B47 File Offset: 0x00000D47
			public _CastIterator_d__99(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x060001CC RID: 460 RVA: 0x0000A0A8 File Offset: 0x000082A8
			// (set) Token: 0x060001CD RID: 461 RVA: 0x00002B50 File Offset: 0x00000D50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001CE RID: 462 RVA: 0x0000A0D0 File Offset: 0x000082D0
			// (set) Token: 0x060001CF RID: 463 RVA: 0x0000A0F8 File Offset: 0x000082F8
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000A1A0 File Offset: 0x000083A0
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x00002B6B File Offset: 0x00000D6B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000A1C8 File Offset: 0x000083C8
			// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002B86 File Offset: 0x00000D86
			public unsafe IEnumerable source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000A1F8 File Offset: 0x000083F8
			// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002BA5 File Offset: 0x00000DA5
			public unsafe IEnumerable __3__source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___3__source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000A228 File Offset: 0x00008428
			// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002BC4 File Offset: 0x00000DC4
			public unsafe IEnumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._CastIterator_d__99<TResult>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeFieldInfoPtr___3__source;

			// Token: 0x0400012A RID: 298
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400012B RID: 299
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400012C RID: 300
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400012D RID: 301
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400012E RID: 302
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400012F RID: 303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000130 RID: 304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000131 RID: 305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000132 RID: 306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000133 RID: 307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200001F RID: 31
		[ObfuscatedName("System.Linq.Enumerable+<RepeatIterator>d__117`1")]
		public sealed class _RepeatIterator_d__117<TResult> : Object
		{
			// Token: 0x060001D8 RID: 472 RVA: 0x0000A258 File Offset: 0x00008458
			// Note: this type is marked as 'beforefieldinit'.
			static _RepeatIterator_d__117()
			{
				Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enumerable>.NativeClassPtr, "<RepeatIterator>d__117`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr);
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>1__state");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>2__current");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>l__initialThreadId");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "element");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>3__element");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<i>5__1");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "count");
				Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, "<>3__count");
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663450);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663451);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663452);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663453);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663454);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663455);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663456);
				Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr, 100663457);
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x0000A400 File Offset: 0x00008600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RepeatIterator_d__117(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerable._RepeatIterator_d__117<TResult>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0000A448 File Offset: 0x00008648
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001DB RID: 475 RVA: 0x0000A47C File Offset: 0x0000867C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58102, XrefRangeEnd = 58103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A4B8 File Offset: 0x000086B8
			public unsafe TResult System.Collections.Generic.IEnumerator<TResult>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
				}
			}

			// Token: 0x060001DD RID: 477 RVA: 0x0000A4F4 File Offset: 0x000086F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58103, XrefRangeEnd = 58108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001DE RID: 478 RVA: 0x0000A528 File Offset: 0x00008728
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0000A568 File Offset: 0x00008768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58108, XrefRangeEnd = 58112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TResult> System_Collections_Generic_IEnumerable_TResult__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TResult>>(intPtr3) : null;
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x0000A5A8 File Offset: 0x000087A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enumerable._RepeatIterator_d__117<TResult>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x00002BE3 File Offset: 0x00000DE3
			public _RepeatIterator_d__117(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000A5E8 File Offset: 0x000087E8
			// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002BEC File Offset: 0x00000DEC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000A610 File Offset: 0x00008810
			// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000A638 File Offset: 0x00008838
			public unsafe TResult __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000A6E0 File Offset: 0x000088E0
			// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002C07 File Offset: 0x00000E07
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000A708 File Offset: 0x00008908
			// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000A730 File Offset: 0x00008930
			public unsafe TResult element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_element);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001EA RID: 490 RVA: 0x0000A7D8 File Offset: 0x000089D8
			// (set) Token: 0x060001EB RID: 491 RVA: 0x0000A800 File Offset: 0x00008A00
			public unsafe TResult __3__element
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element);
					return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__element);
					Type typeFromHandle = typeof(TResult);
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

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x060001EC RID: 492 RVA: 0x0000A8A8 File Offset: 0x00008AA8
			// (set) Token: 0x060001ED RID: 493 RVA: 0x00002C22 File Offset: 0x00000E22
			public unsafe int _i_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr__i_5__1)) = value;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0000A8D0 File Offset: 0x00008AD0
			// (set) Token: 0x060001EF RID: 495 RVA: 0x00002C3D File Offset: 0x00000E3D
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000A8F8 File Offset: 0x00008AF8
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002C58 File Offset: 0x00000E58
			public unsafe int __3__count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enumerable._RepeatIterator_d__117<TResult>.NativeFieldInfoPtr___3__count)) = value;
				}
			}

			// Token: 0x04000134 RID: 308
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000135 RID: 309
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000136 RID: 310
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000137 RID: 311
			private static readonly IntPtr NativeFieldInfoPtr_element;

			// Token: 0x04000138 RID: 312
			private static readonly IntPtr NativeFieldInfoPtr___3__element;

			// Token: 0x04000139 RID: 313
			private static readonly IntPtr NativeFieldInfoPtr__i_5__1;

			// Token: 0x0400013A RID: 314
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x0400013B RID: 315
			private static readonly IntPtr NativeFieldInfoPtr___3__count;

			// Token: 0x0400013C RID: 316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400013D RID: 317
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TResult__get_Current_Private_Virtual_Final_New_get_TResult_0;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_TResult__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TResult_0;

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000144 RID: 324
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Where_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000021 RID: 33
		private sealed class MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0<TSource, TResult>
		{
			// Token: 0x04000145 RID: 325
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_2_TSource_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>
		{
			// Token: 0x04000146 RID: 326
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Select_Public_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000023 RID: 35
		private sealed class MethodInfoStoreGeneric_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0<TSource, TResult>
		{
			// Token: 0x04000147 RID: 327
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SelectIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_1_TSource_Func_3_TSource_Int32_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000024 RID: 36
		private sealed class MethodInfoStoreGeneric_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000148 RID: 328
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombinePredicates_Private_Static_Func_2_TSource_Boolean_Func_2_TSource_Boolean_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000025 RID: 37
		private sealed class MethodInfoStoreGeneric_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0<TSource, TMiddle, TResult>
		{
			// Token: 0x04000149 RID: 329
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CombineSelectors_Private_Static_Func_2_TSource_TResult_Func_2_TSource_TMiddle_Func_2_TMiddle_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMiddle>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000026 RID: 38
		private sealed class MethodInfoStoreGeneric_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x0400014A RID: 330
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Take_Public_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000027 RID: 39
		private sealed class MethodInfoStoreGeneric_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x0400014B RID: 331
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_TakeIterator_Private_Static_IEnumerable_1_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000028 RID: 40
		private sealed class MethodInfoStoreGeneric_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x0400014C RID: 332
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_OrderBy_Public_Static_IOrderedEnumerable_1_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000029 RID: 41
		private sealed class MethodInfoStoreGeneric_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x0400014D RID: 333
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ThenBy_Public_Static_IOrderedEnumerable_1_TSource_IOrderedEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200002A RID: 42
		private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x0400014E RID: 334
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002B RID: 43
		private sealed class MethodInfoStoreGeneric_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x0400014F RID: 335
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToList_Public_Static_List_1_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002C RID: 44
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0<TSource, TKey>
		{
			// Token: 0x04000150 RID: 336
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TSource_IEnumerable_1_TSource_Func_2_TSource_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200002D RID: 45
		private sealed class MethodInfoStoreGeneric_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0<TSource, TKey, TElement>
		{
			// Token: 0x04000151 RID: 337
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ToDictionary_Public_Static_Dictionary_2_TKey_TElement_IEnumerable_1_TSource_Func_2_TSource_TKey_Func_2_TSource_TElement_IEqualityComparer_1_TKey_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200002E RID: 46
		private sealed class MethodInfoStoreGeneric_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000152 RID: 338
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Cast_Public_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002F RID: 47
		private sealed class MethodInfoStoreGeneric_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0<TResult>
		{
			// Token: 0x04000153 RID: 339
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_CastIterator_Private_Static_IEnumerable_1_TResult_IEnumerable_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000030 RID: 48
		private sealed class MethodInfoStoreGeneric_First_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000154 RID: 340
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_First_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000031 RID: 49
		private sealed class MethodInfoStoreGeneric_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000155 RID: 341
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_FirstOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_Last_Public_Static_TSource_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x04000156 RID: 342
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Last_Public_Static_TSource_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x04000157 RID: 343
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_SingleOrDefault_Public_Static_TSource_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000034 RID: 52
		private sealed class MethodInfoStoreGeneric_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0<TSource>
		{
			// Token: 0x04000158 RID: 344
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_ElementAt_Public_Static_TSource_IEnumerable_1_TSource_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000035 RID: 53
		private sealed class MethodInfoStoreGeneric_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>
		{
			// Token: 0x04000159 RID: 345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Repeat_Public_Static_IEnumerable_1_TResult_TResult_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000036 RID: 54
		private sealed class MethodInfoStoreGeneric_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0<TResult>
		{
			// Token: 0x0400015A RID: 346
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_RepeatIterator_Private_Static_IEnumerable_1_TResult_TResult_Int32_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000037 RID: 55
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_IEnumerable_1_TResult_0<TResult>
		{
			// Token: 0x0400015B RID: 347
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Empty_Public_Static_IEnumerable_1_TResult_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000038 RID: 56
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x0400015C RID: 348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x02000039 RID: 57
		private sealed class MethodInfoStoreGeneric_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0<TSource>
		{
			// Token: 0x0400015D RID: 349
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Any_Public_Static_Boolean_IEnumerable_1_TSource_Func_2_TSource_Boolean_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003A RID: 58
		private sealed class MethodInfoStoreGeneric_Count_Public_Static_Int32_IEnumerable_1_TSource_0<TSource>
		{
			// Token: 0x0400015E RID: 350
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Count_Public_Static_Int32_IEnumerable_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003B RID: 59
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0<TSource>
		{
			// Token: 0x0400015F RID: 351
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0<TSource>
		{
			// Token: 0x04000160 RID: 352
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Contains_Public_Static_Boolean_IEnumerable_1_TSource_TSource_IEqualityComparer_1_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0<TSource>
		{
			// Token: 0x04000161 RID: 353
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Enumerable.NativeMethodInfoPtr_Aggregate_Public_Static_TSource_IEnumerable_1_TSource_Func_3_TSource_TSource_TSource_0, Il2CppClassPointerStore<Enumerable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSource>.NativeClassPtr)) }))));
		}
	}
}
