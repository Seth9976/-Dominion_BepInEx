using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x020000A4 RID: 164
	[Serializable]
	public class HybridDictionary : Object
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x00034EB0 File Offset: 0x000330B0
		// Note: this type is marked as 'beforefieldinit'.
		static HybridDictionary()
		{
			Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "HybridDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr);
			HybridDictionary.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, "list");
			HybridDictionary.NativeFieldInfoPtr_hashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, "hashtable");
			HybridDictionary.NativeFieldInfoPtr_caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, "caseInsensitive");
			HybridDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664592);
			HybridDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664593);
			HybridDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664594);
			HybridDictionary.NativeMethodInfoPtr_get_List_Private_get_ListDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664595);
			HybridDictionary.NativeMethodInfoPtr_ChangeOver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664596);
			HybridDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664597);
			HybridDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664598);
			HybridDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664599);
			HybridDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664600);
			HybridDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664601);
			HybridDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664602);
			HybridDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr, 100664603);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0003500C File Offset: 0x0003320C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HybridDictionary()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F7 RID: 759
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43767, RefRangeEnd = 43768, XrefRangeStart = 43767, XrefRangeEnd = 43767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43768, XrefRangeEnd = 43778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000350EC File Offset: 0x000332EC
		public unsafe ListDictionary List
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 43787, RefRangeEnd = 43789, XrefRangeStart = 43778, XrefRangeEnd = 43787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_get_List_Private_get_ListDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0003512C File Offset: 0x0003332C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43789, XrefRangeEnd = 43818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_ChangeOver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00035160 File Offset: 0x00033360
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43818, RefRangeEnd = 43819, XrefRangeStart = 43818, XrefRangeEnd = 43818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0003519C File Offset: 0x0003339C
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43819, XrefRangeEnd = 43822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000351DC File Offset: 0x000333DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43825, RefRangeEnd = 43826, XrefRangeStart = 43822, XrefRangeEnd = 43825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00035230 File Offset: 0x00033430
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00035280 File Offset: 0x00033480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43826, XrefRangeEnd = 43829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000352D0 File Offset: 0x000334D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43829, XrefRangeEnd = 43840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00035310 File Offset: 0x00033510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43840, XrefRangeEnd = 43851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HybridDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00005F2B File Offset: 0x0000412B
		public HybridDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00035350 File Offset: 0x00033550
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x00005F34 File Offset: 0x00004134
		public unsafe ListDictionary list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00035380 File Offset: 0x00033580
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00005F53 File Offset: 0x00004153
		public unsafe Hashtable hashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_hashtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_hashtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000353B0 File Offset: 0x000335B0
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00005F72 File Offset: 0x00004172
		public unsafe bool caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HybridDictionary.NativeFieldInfoPtr_caseInsensitive)) = value;
			}
		}

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeFieldInfoPtr_hashtable;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeFieldInfoPtr_caseInsensitive;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_get_List_Private_get_ListDictionary_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_ChangeOver_Private_Void_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
	}
}
