using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000481 RID: 1153
	[Serializable]
	public class ListDictionaryInternal : Object
	{
		// Token: 0x060044C1 RID: 17601 RVA: 0x0013A2CC File Offset: 0x001384CC
		// Note: this type is marked as 'beforefieldinit'.
		static ListDictionaryInternal()
		{
			Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ListDictionaryInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr);
			ListDictionaryInternal.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "head");
			ListDictionaryInternal.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "version");
			ListDictionaryInternal.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "count");
			ListDictionaryInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673313);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673314);
			ListDictionaryInternal.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673315);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673316);
			ListDictionaryInternal.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673317);
			ListDictionaryInternal.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673318);
			ListDictionaryInternal.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673319);
			ListDictionaryInternal.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673320);
			ListDictionaryInternal.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, 100673321);
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x0013A3EC File Offset: 0x001385EC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListDictionaryInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001184 RID: 4484
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360402, XrefRangeEnd = 360409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060044C5 RID: 17605 RVA: 0x0013A4CC File Offset: 0x001386CC
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060044C6 RID: 17606 RVA: 0x0013A508 File Offset: 0x00138708
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360409, XrefRangeEnd = 360413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x0013A548 File Offset: 0x00138748
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x0013A598 File Offset: 0x00138798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360413, XrefRangeEnd = 360420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x0013A5E8 File Offset: 0x001387E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360420, XrefRangeEnd = 360424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0013A628 File Offset: 0x00138828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360424, XrefRangeEnd = 360428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x0001A566 File Offset: 0x00018766
		public ListDictionaryInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060044CC RID: 17612 RVA: 0x0013A668 File Offset: 0x00138868
		// (set) Token: 0x060044CD RID: 17613 RVA: 0x0001A56F File Offset: 0x0001876F
		public unsafe ListDictionaryInternal.DictionaryNode head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060044CE RID: 17614 RVA: 0x0013A698 File Offset: 0x00138898
		// (set) Token: 0x060044CF RID: 17615 RVA: 0x0001A58E File Offset: 0x0001878E
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x0013A6C0 File Offset: 0x001388C0
		// (set) Token: 0x060044D1 RID: 17617 RVA: 0x0001A5A9 File Offset: 0x000187A9
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000653 RID: 1619
		public class NodeEnumerator : Object
		{
			// Token: 0x06005550 RID: 21840 RVA: 0x00178EC8 File Offset: 0x001770C8
			// Note: this type is marked as 'beforefieldinit'.
			static NodeEnumerator()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "NodeEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr);
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "list");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "current");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "version");
				ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, "start");
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673322);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673323);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673324);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673325);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673326);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673327);
				ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr, 100673328);
			}

			// Token: 0x06005551 RID: 21841 RVA: 0x00178FD0 File Offset: 0x001771D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43852, RefRangeEnd = 43856, XrefRangeStart = 43852, XrefRangeEnd = 43856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeEnumerator(ListDictionaryInternal list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170015E2 RID: 5602
			// (get) Token: 0x06005552 RID: 21842 RVA: 0x0017901C File Offset: 0x0017721C
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360389, XrefRangeEnd = 360393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015E3 RID: 5603
			// (get) Token: 0x06005553 RID: 21843 RVA: 0x0017905C File Offset: 0x0017725C
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360393, XrefRangeEnd = 360394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170015E4 RID: 5604
			// (get) Token: 0x06005554 RID: 21844 RVA: 0x00179094 File Offset: 0x00177294
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170015E5 RID: 5605
			// (get) Token: 0x06005555 RID: 21845 RVA: 0x001790D4 File Offset: 0x001772D4
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005556 RID: 21846 RVA: 0x00179114 File Offset: 0x00177314
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005557 RID: 21847 RVA: 0x00179150 File Offset: 0x00177350
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005558 RID: 21848 RVA: 0x00020E9F File Offset: 0x0001F09F
			public NodeEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015DE RID: 5598
			// (get) Token: 0x06005559 RID: 21849 RVA: 0x00179184 File Offset: 0x00177384
			// (set) Token: 0x0600555A RID: 21850 RVA: 0x00020EA8 File Offset: 0x0001F0A8
			public unsafe ListDictionaryInternal list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015DF RID: 5599
			// (get) Token: 0x0600555B RID: 21851 RVA: 0x001791B4 File Offset: 0x001773B4
			// (set) Token: 0x0600555C RID: 21852 RVA: 0x00020EC7 File Offset: 0x0001F0C7
			public unsafe ListDictionaryInternal.DictionaryNode current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E0 RID: 5600
			// (get) Token: 0x0600555D RID: 21853 RVA: 0x001791E4 File Offset: 0x001773E4
			// (set) Token: 0x0600555E RID: 21854 RVA: 0x00020EE6 File Offset: 0x0001F0E6
			public unsafe int version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_version)) = value;
				}
			}

			// Token: 0x170015E1 RID: 5601
			// (get) Token: 0x0600555F RID: 21855 RVA: 0x0017920C File Offset: 0x0017740C
			// (set) Token: 0x06005560 RID: 21856 RVA: 0x00020F01 File Offset: 0x0001F101
			public unsafe bool start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeEnumerator.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x0400448A RID: 17546
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x0400448B RID: 17547
			private static readonly IntPtr NativeFieldInfoPtr_current;

			// Token: 0x0400448C RID: 17548
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x0400448D RID: 17549
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x0400448E RID: 17550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_0;

			// Token: 0x0400448F RID: 17551
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004490 RID: 17552
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004491 RID: 17553
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004492 RID: 17554
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004493 RID: 17555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004494 RID: 17556
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000654 RID: 1620
		public class NodeKeyValueCollection : Object
		{
			// Token: 0x06005561 RID: 21857 RVA: 0x00179234 File Offset: 0x00177434
			// Note: this type is marked as 'beforefieldinit'.
			static NodeKeyValueCollection()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "NodeKeyValueCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr);
				ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "list");
				ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "isKeys");
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100673329);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100673330);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100673331);
				ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, 100673332);
			}

			// Token: 0x06005562 RID: 21858 RVA: 0x001792D8 File Offset: 0x001774D8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 39185, RefRangeEnd = 39187, XrefRangeStart = 39185, XrefRangeEnd = 39187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeKeyValueCollection(ListDictionaryInternal list, bool isKeys)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005563 RID: 21859 RVA: 0x00179334 File Offset: 0x00177534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360394, XrefRangeEnd = 360398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170015E8 RID: 5608
			// (get) Token: 0x06005564 RID: 21860 RVA: 0x00179384 File Offset: 0x00177584
			public unsafe virtual int System.Collections.ICollection.Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005565 RID: 21861 RVA: 0x001793C0 File Offset: 0x001775C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360398, XrefRangeEnd = 360402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005566 RID: 21862 RVA: 0x00020F1C File Offset: 0x0001F11C
			public NodeKeyValueCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015E6 RID: 5606
			// (get) Token: 0x06005567 RID: 21863 RVA: 0x00179400 File Offset: 0x00177600
			// (set) Token: 0x06005568 RID: 21864 RVA: 0x00020F25 File Offset: 0x0001F125
			public unsafe ListDictionaryInternal list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015E7 RID: 5607
			// (get) Token: 0x06005569 RID: 21865 RVA: 0x00179430 File Offset: 0x00177630
			// (set) Token: 0x0600556A RID: 21866 RVA: 0x00020F44 File Offset: 0x0001F144
			public unsafe bool isKeys
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NativeFieldInfoPtr_isKeys)) = value;
				}
			}

			// Token: 0x04004495 RID: 17557
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x04004496 RID: 17558
			private static readonly IntPtr NativeFieldInfoPtr_isKeys;

			// Token: 0x04004497 RID: 17559
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0;

			// Token: 0x04004498 RID: 17560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04004499 RID: 17561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x0400449A RID: 17562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x020006C6 RID: 1734
			public class NodeKeyValueEnumerator : Object
			{
				// Token: 0x060057E0 RID: 22496 RVA: 0x00180800 File Offset: 0x0017EA00
				// Note: this type is marked as 'beforefieldinit'.
				static NodeKeyValueEnumerator()
				{
					Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection>.NativeClassPtr, "NodeKeyValueEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "list");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "current");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "version");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "isKeys");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, "start");
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100673333);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100673334);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100673335);
					ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr, 100673336);
				}

				// Token: 0x060057E1 RID: 22497 RVA: 0x001808E0 File Offset: 0x0017EAE0
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 43862, RefRangeEnd = 43864, XrefRangeStart = 43862, XrefRangeEnd = 43864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NodeKeyValueEnumerator(ListDictionaryInternal list, bool isKeys)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isKeys;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17001684 RID: 5764
				// (get) Token: 0x060057E2 RID: 22498 RVA: 0x0018093C File Offset: 0x0017EB3C
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060057E3 RID: 22499 RVA: 0x0018097C File Offset: 0x0017EB7C
				[CallerCount(0)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060057E4 RID: 22500 RVA: 0x001809B8 File Offset: 0x0017EBB8
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057E5 RID: 22501 RVA: 0x0002271F File Offset: 0x0002091F
				public NodeKeyValueEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700167F RID: 5759
				// (get) Token: 0x060057E6 RID: 22502 RVA: 0x001809EC File Offset: 0x0017EBEC
				// (set) Token: 0x060057E7 RID: 22503 RVA: 0x00022728 File Offset: 0x00020928
				public unsafe ListDictionaryInternal list
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001680 RID: 5760
				// (get) Token: 0x060057E8 RID: 22504 RVA: 0x00180A1C File Offset: 0x0017EC1C
				// (set) Token: 0x060057E9 RID: 22505 RVA: 0x00022747 File Offset: 0x00020947
				public unsafe ListDictionaryInternal.DictionaryNode current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17001681 RID: 5761
				// (get) Token: 0x060057EA RID: 22506 RVA: 0x00180A4C File Offset: 0x0017EC4C
				// (set) Token: 0x060057EB RID: 22507 RVA: 0x00022766 File Offset: 0x00020966
				public unsafe int version
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_version)) = value;
					}
				}

				// Token: 0x17001682 RID: 5762
				// (get) Token: 0x060057EC RID: 22508 RVA: 0x00180A74 File Offset: 0x0017EC74
				// (set) Token: 0x060057ED RID: 22509 RVA: 0x00022781 File Offset: 0x00020981
				public unsafe bool isKeys
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_isKeys)) = value;
					}
				}

				// Token: 0x17001683 RID: 5763
				// (get) Token: 0x060057EE RID: 22510 RVA: 0x00180A9C File Offset: 0x0017EC9C
				// (set) Token: 0x060057EF RID: 22511 RVA: 0x0002279C File Offset: 0x0002099C
				public unsafe bool start
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator.NativeFieldInfoPtr_start)) = value;
					}
				}

				// Token: 0x04004623 RID: 17955
				private static readonly IntPtr NativeFieldInfoPtr_list;

				// Token: 0x04004624 RID: 17956
				private static readonly IntPtr NativeFieldInfoPtr_current;

				// Token: 0x04004625 RID: 17957
				private static readonly IntPtr NativeFieldInfoPtr_version;

				// Token: 0x04004626 RID: 17958
				private static readonly IntPtr NativeFieldInfoPtr_isKeys;

				// Token: 0x04004627 RID: 17959
				private static readonly IntPtr NativeFieldInfoPtr_start;

				// Token: 0x04004628 RID: 17960
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ListDictionaryInternal_Boolean_0;

				// Token: 0x04004629 RID: 17961
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x0400462A RID: 17962
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x0400462B RID: 17963
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}

		// Token: 0x02000655 RID: 1621
		[Serializable]
		public class DictionaryNode : Object
		{
			// Token: 0x0600556B RID: 21867 RVA: 0x00179458 File Offset: 0x00177658
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryNode()
			{
				Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ListDictionaryInternal>.NativeClassPtr, "DictionaryNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr);
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "key");
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "value");
				ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, "next");
				ListDictionaryInternal.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr, 100673337);
			}

			// Token: 0x0600556C RID: 21868 RVA: 0x001794D4 File Offset: 0x001776D4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListDictionaryInternal.DictionaryNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListDictionaryInternal.DictionaryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600556D RID: 21869 RVA: 0x00020F5F File Offset: 0x0001F15F
			public DictionaryNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015E9 RID: 5609
			// (get) Token: 0x0600556E RID: 21870 RVA: 0x00179510 File Offset: 0x00177710
			// (set) Token: 0x0600556F RID: 21871 RVA: 0x00020F68 File Offset: 0x0001F168
			public unsafe Object key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EA RID: 5610
			// (get) Token: 0x06005570 RID: 21872 RVA: 0x00179540 File Offset: 0x00177740
			// (set) Token: 0x06005571 RID: 21873 RVA: 0x00020F87 File Offset: 0x0001F187
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015EB RID: 5611
			// (get) Token: 0x06005572 RID: 21874 RVA: 0x00179570 File Offset: 0x00177770
			// (set) Token: 0x06005573 RID: 21875 RVA: 0x00020FA6 File Offset: 0x0001F1A6
			public unsafe ListDictionaryInternal.DictionaryNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionaryInternal.DictionaryNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListDictionaryInternal.DictionaryNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400449B RID: 17563
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400449C RID: 17564
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400449D RID: 17565
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x0400449E RID: 17566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
