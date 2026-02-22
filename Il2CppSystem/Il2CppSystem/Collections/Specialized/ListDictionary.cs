using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public class ListDictionary : Object
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x000353D8 File Offset: 0x000335D8
		// Note: this type is marked as 'beforefieldinit'.
		static ListDictionary()
		{
			Il2CppClassPointerStore<ListDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "ListDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr);
			ListDictionary.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "head");
			ListDictionary.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "version");
			ListDictionary.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "count");
			ListDictionary.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "comparer");
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664604);
			ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664605);
			ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664606);
			ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664607);
			ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664608);
			ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664609);
			ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664610);
			ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664611);
			ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664612);
			ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664613);
			ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, 100664614);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00035534 File Offset: 0x00033734
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00035570 File Offset: 0x00033770
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 43871, RefRangeEnd = 43875, XrefRangeStart = 43870, XrefRangeEnd = 43871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionary(IComparer comparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr__ctor_Public_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002FF RID: 767
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43875, XrefRangeEnd = 43878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43887, RefRangeEnd = 43888, XrefRangeStart = 43878, XrefRangeEnd = 43887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x00035660 File Offset: 0x00033860
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0003569C File Offset: 0x0003389C
		public unsafe virtual ICollection Keys
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43892, RefRangeEnd = 43893, XrefRangeStart = 43888, XrefRangeEnd = 43892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000356DC File Offset: 0x000338DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43902, RefRangeEnd = 43903, XrefRangeStart = 43893, XrefRangeEnd = 43902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00035730 File Offset: 0x00033930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43903, XrefRangeEnd = 43907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00035780 File Offset: 0x00033980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43913, RefRangeEnd = 43914, XrefRangeStart = 43907, XrefRangeEnd = 43913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000357D0 File Offset: 0x000339D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43918, RefRangeEnd = 43921, XrefRangeStart = 43914, XrefRangeEnd = 43918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00035810 File Offset: 0x00033A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43921, XrefRangeEnd = 43925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00005F8D File Offset: 0x0000418D
		public ListDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00035850 File Offset: 0x00033A50
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00005F96 File Offset: 0x00004196
		public unsafe ListDictionary.DictionaryNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00035880 File Offset: 0x00033A80
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00005FB5 File Offset: 0x000041B5
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000358A8 File Offset: 0x00033AA8
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00005FD0 File Offset: 0x000041D0
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000358D0 File Offset: 0x00033AD0
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00005FEB File Offset: 0x000041EB
		public unsafe IComparer comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IComparer_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200019A RID: 410
		public class NodeEnumerator : Object
		{
			// Token: 0x06001779 RID: 6009 RVA: 0x000657E0 File Offset: 0x000639E0
			// Note: this type is marked as 'beforefieldinit'.
			static NodeEnumerator()
			{
				Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr);
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "list");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "current");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "version");
				ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, "start");
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664615);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664616);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664617);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664618);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664619);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664620);
				ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr, 100664621);
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x000658E8 File Offset: 0x00063AE8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43852, RefRangeEnd = 43856, XrefRangeStart = 43851, XrefRangeEnd = 43852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeEnumerator(ListDictionary list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000788 RID: 1928
			// (get) Token: 0x0600177B RID: 6011 RVA: 0x00065934 File Offset: 0x00063B34
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43856, XrefRangeEnd = 43860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000789 RID: 1929
			// (get) Token: 0x0600177C RID: 6012 RVA: 0x00065974 File Offset: 0x00063B74
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43860, XrefRangeEnd = 43861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x1700078A RID: 1930
			// (get) Token: 0x0600177D RID: 6013 RVA: 0x000659AC File Offset: 0x00063BAC
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700078B RID: 1931
			// (get) Token: 0x0600177E RID: 6014 RVA: 0x000659EC File Offset: 0x00063BEC
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600177F RID: 6015 RVA: 0x00065A2C File Offset: 0x00063C2C
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001780 RID: 6016 RVA: 0x00065A68 File Offset: 0x00063C68
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001781 RID: 6017 RVA: 0x0000C698 File Offset: 0x0000A898
			public NodeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000784 RID: 1924
			// (get) Token: 0x06001782 RID: 6018 RVA: 0x00065A9C File Offset: 0x00063C9C
			// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000C6A1 File Offset: 0x0000A8A1
			public unsafe ListDictionary list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000785 RID: 1925
			// (get) Token: 0x06001784 RID: 6020 RVA: 0x00065ACC File Offset: 0x00063CCC
			// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
			public unsafe ListDictionary.DictionaryNode current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000786 RID: 1926
			// (get) Token: 0x06001786 RID: 6022 RVA: 0x00065AFC File Offset: 0x00063CFC
			// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000C6DF File Offset: 0x0000A8DF
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x17000787 RID: 1927
			// (get) Token: 0x06001788 RID: 6024 RVA: 0x00065B24 File Offset: 0x00063D24
			// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000C6FA File Offset: 0x0000A8FA
			public unsafe bool start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeEnumerator.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040012BA RID: 4794
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x040012BB RID: 4795
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x040012BC RID: 4796
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x040012BD RID: 4797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_0;

			// Token: 0x040012BE RID: 4798
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040012BF RID: 4799
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x040012C0 RID: 4800
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040012C3 RID: 4803
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200019B RID: 411
		public class NodeKeyValueCollection : Object
		{
			// Token: 0x0600178A RID: 6026 RVA: 0x00065B4C File Offset: 0x00063D4C
			// Note: this type is marked as 'beforefieldinit'.
			static NodeKeyValueCollection()
			{
				Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "NodeKeyValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr);
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "list");
				ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "isKeys");
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664622);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664623);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664624);
				ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, 100664625);
			}

			// Token: 0x0600178B RID: 6027 RVA: 0x00065BF0 File Offset: 0x00063DF0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39185, RefRangeEnd = 39187, XrefRangeStart = 39185, XrefRangeEnd = 39187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeKeyValueCollection(ListDictionary list, bool isKeys)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600178C RID: 6028 RVA: 0x00065C4C File Offset: 0x00063E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43864, XrefRangeEnd = 43866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700078E RID: 1934
			// (get) Token: 0x0600178D RID: 6029 RVA: 0x00065C9C File Offset: 0x00063E9C
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600178E RID: 6030 RVA: 0x00065CD8 File Offset: 0x00063ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43866, XrefRangeEnd = 43870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600178F RID: 6031 RVA: 0x0000C715 File Offset: 0x0000A915
			public NodeKeyValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078C RID: 1932
			// (get) Token: 0x06001790 RID: 6032 RVA: 0x00065D18 File Offset: 0x00063F18
			// (set) Token: 0x06001791 RID: 6033 RVA: 0x0000C71E File Offset: 0x0000A91E
			public unsafe ListDictionary list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700078D RID: 1933
			// (get) Token: 0x06001792 RID: 6034 RVA: 0x00065D48 File Offset: 0x00063F48
			// (set) Token: 0x06001793 RID: 6035 RVA: 0x0000C73D File Offset: 0x0000A93D
			public unsafe bool isKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys)) = value;
				}
			}

			// Token: 0x040012C4 RID: 4804
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeFieldInfoPtr_isKeys;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x040012C9 RID: 4809
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x02000219 RID: 537
			public class NodeKeyValueEnumerator : Object
			{
				// Token: 0x06001CAA RID: 7338 RVA: 0x00073B24 File Offset: 0x00071D24
				// Note: this type is marked as 'beforefieldinit'.
				static NodeKeyValueEnumerator()
				{
					Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection>.NativeClassPtr, "NodeKeyValueEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "list");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "current");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "version");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "isKeys");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "start");
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664626);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664627);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664628);
					ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100664629);
				}

				// Token: 0x06001CAB RID: 7339 RVA: 0x00073C04 File Offset: 0x00071E04
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 43862, RefRangeEnd = 43864, XrefRangeStart = 43861, XrefRangeEnd = 43862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NodeKeyValueEnumerator(ListDictionary list, bool isKeys)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700091A RID: 2330
				// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00073C60 File Offset: 0x00071E60
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001CAD RID: 7341 RVA: 0x00073CA0 File Offset: 0x00071EA0
				[CallerCount(0)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001CAE RID: 7342 RVA: 0x00073CDC File Offset: 0x00071EDC
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001CAF RID: 7343 RVA: 0x00010513 File Offset: 0x0000E713
				public NodeKeyValueEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000915 RID: 2325
				// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00073D10 File Offset: 0x00071F10
				// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0001051C File Offset: 0x0000E71C
				public unsafe ListDictionary list
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000916 RID: 2326
				// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00073D40 File Offset: 0x00071F40
				// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0001053B File Offset: 0x0000E73B
				public unsafe ListDictionary.DictionaryNode current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000917 RID: 2327
				// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00073D70 File Offset: 0x00071F70
				// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0001055A File Offset: 0x0000E75A
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x17000918 RID: 2328
				// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00073D98 File Offset: 0x00071F98
				// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x00010575 File Offset: 0x0000E775
				public unsafe bool isKeys
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys)) = value;
					}
				}

				// Token: 0x17000919 RID: 2329
				// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00073DC0 File Offset: 0x00071FC0
				// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00010590 File Offset: 0x0000E790
				public unsafe bool start
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start)) = value;
					}
				}

				// Token: 0x04001598 RID: 5528
				private static readonly IntPtr NativeFieldInfoPtr_list;

				// Token: 0x04001599 RID: 5529
				private static readonly IntPtr NativeFieldInfoPtr_current;

				// Token: 0x0400159A RID: 5530
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x0400159B RID: 5531
				private static readonly IntPtr NativeFieldInfoPtr_isKeys;

				// Token: 0x0400159C RID: 5532
				private static readonly IntPtr NativeFieldInfoPtr_start;

				// Token: 0x0400159D RID: 5533
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionary_Boolean_0;

				// Token: 0x0400159E RID: 5534
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x0400159F RID: 5535
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x040015A0 RID: 5536
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x0200019C RID: 412
		[Serializable]
		public class DictionaryNode : Object
		{
			// Token: 0x06001794 RID: 6036 RVA: 0x00065D70 File Offset: 0x00063F70
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryNode()
			{
				Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionary>.NativeClassPtr, "DictionaryNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr);
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "key");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "value");
				ListDictionary.DictionaryNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, "next");
				ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr, 100664630);
			}

			// Token: 0x06001795 RID: 6037 RVA: 0x00065DEC File Offset: 0x00063FEC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionary.DictionaryNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionary.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001796 RID: 6038 RVA: 0x0000C758 File Offset: 0x0000A958
			public DictionaryNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700078F RID: 1935
			// (get) Token: 0x06001797 RID: 6039 RVA: 0x00065E28 File Offset: 0x00064028
			// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000C761 File Offset: 0x0000A961
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000790 RID: 1936
			// (get) Token: 0x06001799 RID: 6041 RVA: 0x00065E58 File Offset: 0x00064058
			// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000C780 File Offset: 0x0000A980
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000791 RID: 1937
			// (get) Token: 0x0600179B RID: 6043 RVA: 0x00065E88 File Offset: 0x00064088
			// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000C79F File Offset: 0x0000A99F
			public unsafe ListDictionary.DictionaryNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionary.DictionaryNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012CA RID: 4810
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x040012CB RID: 4811
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040012CC RID: 4812
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040012CD RID: 4813
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
