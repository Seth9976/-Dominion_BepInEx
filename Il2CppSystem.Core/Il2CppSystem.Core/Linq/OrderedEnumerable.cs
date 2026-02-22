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
	// Token: 0x0200000B RID: 11
	public class OrderedEnumerable<TElement> : Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000528C File Offset: 0x0000348C
		// Note: this type is marked as 'beforefieldinit'.
		static OrderedEnumerable()
		{
			Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "OrderedEnumerable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr);
			OrderedEnumerable<TElement>.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "source");
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663464);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663465);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663466);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663467);
			OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, 100663468);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005370 File Offset: 0x00003570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58508, XrefRangeEnd = 58510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<TElement> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000053B0 File Offset: 0x000035B0
		[CallerCount(0)]
		public unsafe virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrderedEnumerable<TElement>.NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr3) : null;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000540C File Offset: 0x0000360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58510, XrefRangeEnd = 58511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000544C File Offset: 0x0000364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58511, XrefRangeEnd = 58513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IOrderedEnumerable<TElement> System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TKey>.MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOrderedEnumerable<TElement>>(intPtr3) : null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000054BC File Offset: 0x000036BC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrderedEnumerable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002226 File Offset: 0x00000426
		public OrderedEnumerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000054F8 File Offset: 0x000036F8
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000222F File Offset: 0x0000042F
		public unsafe IEnumerable<TElement> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_TElement_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerableSorter_Internal_Abstract_Virtual_New_EnumerableSorter_1_TElement_EnumerableSorter_1_TElement_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000040 RID: 64
		[ObfuscatedName("System.Linq.OrderedEnumerable`1+<GetEnumerator>d__1")]
		public sealed class _GetEnumerator_d__1 : Object
		{
			// Token: 0x06000219 RID: 537 RVA: 0x0000B5B8 File Offset: 0x000097B8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__1()
			{
				Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OrderedEnumerable<TElement>>.NativeClassPtr, "<GetEnumerator>d__1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>1__state");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>2__current");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<>4__this");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<buffer>5__1");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<map>5__2");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, "<i>5__3");
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663469);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663470);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663471);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663472);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663473);
				OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr, 100663474);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x0000B710 File Offset: 0x00009910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58500, XrefRangeEnd = 58501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrderedEnumerable<TElement>._GetEnumerator_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600021B RID: 539 RVA: 0x0000B758 File Offset: 0x00009958
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x0000B78C File Offset: 0x0000998C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58501, XrefRangeEnd = 58503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x0600021D RID: 541 RVA: 0x0000B7C8 File Offset: 0x000099C8
			public unsafe TElement System.Collections.Generic.IEnumerator<TElement>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, false, true);
				}
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0000B804 File Offset: 0x00009A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58503, XrefRangeEnd = 58508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x0600021F RID: 543 RVA: 0x0000B838 File Offset: 0x00009A38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000220 RID: 544 RVA: 0x00002CA0 File Offset: 0x00000EA0
			public _GetEnumerator_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000221 RID: 545 RVA: 0x0000B878 File Offset: 0x00009A78
			// (set) Token: 0x06000222 RID: 546 RVA: 0x00002CA9 File Offset: 0x00000EA9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000223 RID: 547 RVA: 0x0000B8A0 File Offset: 0x00009AA0
			// (set) Token: 0x06000224 RID: 548 RVA: 0x0000B8C8 File Offset: 0x00009AC8
			public unsafe TElement __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(TElement);
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

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000225 RID: 549 RVA: 0x0000B970 File Offset: 0x00009B70
			// (set) Token: 0x06000226 RID: 550 RVA: 0x00002CC4 File Offset: 0x00000EC4
			public unsafe OrderedEnumerable<TElement> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrderedEnumerable<TElement>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000227 RID: 551 RVA: 0x0000B9A0 File Offset: 0x00009BA0
			// (set) Token: 0x06000228 RID: 552 RVA: 0x00002CE3 File Offset: 0x00000EE3
			public Buffer<TElement> _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1);
					return new Buffer<TElement>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__buffer_5__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Buffer<TElement>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000229 RID: 553 RVA: 0x0000B9D0 File Offset: 0x00009BD0
			// (set) Token: 0x0600022A RID: 554 RVA: 0x00002D11 File Offset: 0x00000F11
			public unsafe Il2CppStructArray<int> _map_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__map_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600022B RID: 555 RVA: 0x0000BA00 File Offset: 0x00009C00
			// (set) Token: 0x0600022C RID: 556 RVA: 0x00002D30 File Offset: 0x00000F30
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrderedEnumerable<TElement>._GetEnumerator_d__1.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04000167 RID: 359
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000168 RID: 360
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000169 RID: 361
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400016A RID: 362
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x0400016B RID: 363
			private static readonly IntPtr NativeFieldInfoPtr__map_5__2;

			// Token: 0x0400016C RID: 364
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400016E RID: 366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400016F RID: 367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000170 RID: 368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_TElement__get_Current_Private_Virtual_Final_New_get_TElement_0;

			// Token: 0x04000171 RID: 369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000172 RID: 370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0
		{
			// Token: 0x04000173 RID: 371
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OrderedEnumerable<TKey>.NativeMethodInfoPtr_System_Linq_IOrderedEnumerable_TElement__CreateOrderedEnumerable_Private_Virtual_Final_New_IOrderedEnumerable_1_TElement_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_0, Il2CppClassPointerStore<OrderedEnumerable<TKey>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)) }))));
		}
	}
}
