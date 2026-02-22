using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000C RID: 12
	public class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00005528 File Offset: 0x00003728
		// Note: this type is marked as 'beforefieldinit'.
		static OrderedEnumerable()
		{
			Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "OrderedEnumerable`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr);
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "parent");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "keySelector");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "comparer");
			OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, "descending");
			OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, 100663475);
			OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr, 100663476);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005620 File Offset: 0x00003820
		[CallerCount(0)]
		public unsafe OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement, TKey>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000056A0 File Offset: 0x000038A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58513, XrefRangeEnd = 58516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderedEnumerable<TElement, TKey>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000224E File Offset: 0x0000044E
		public OrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002257 File Offset: 0x00000457
		public unsafe OrderedEnumerable<TElement> parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderedEnumerable<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000572C File Offset: 0x0000392C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002276 File Offset: 0x00000476
		public unsafe Func<TElement, TKey> keySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_keySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000575C File Offset: 0x0000395C
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002295 File Offset: 0x00000495
		public unsafe IComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000578C File Offset: 0x0000398C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000022B4 File Offset: 0x000004B4
		public unsafe bool descending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement, TKey>.NativeFieldInfoPtr_descending)) = value;
			}
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_keySelector;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_descending;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerableSorter_Internal_Virtual_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0;
	}
}
