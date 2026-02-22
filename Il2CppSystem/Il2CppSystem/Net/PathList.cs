using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class PathList : Object
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x000454D4 File Offset: 0x000436D4
		// Note: this type is marked as 'beforefieldinit'.
		static PathList()
		{
			Il2CppClassPointerStore<PathList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "PathList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathList>.NativeClassPtr);
			PathList.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathList>.NativeClassPtr, "m_list");
			PathList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665275);
			PathList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665276);
			PathList.NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665277);
			PathList.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665278);
			PathList.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665279);
			PathList.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665280);
			PathList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665281);
			PathList.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList>.NativeClassPtr, 100665282);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000455B8 File Offset: 0x000437B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48847, RefRangeEnd = 48848, XrefRangeStart = 48835, XrefRangeEnd = 48847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000455F4 File Offset: 0x000437F4
		public unsafe int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48849, RefRangeEnd = 48852, XrefRangeStart = 48848, XrefRangeEnd = 48849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00045630 File Offset: 0x00043830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48878, RefRangeEnd = 48879, XrefRangeStart = 48852, XrefRangeEnd = 48878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookiesCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0004566C File Offset: 0x0004386C
		public unsafe ICollection Values
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12035, RefRangeEnd = 12037, XrefRangeStart = 12035, XrefRangeEnd = 12037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700044F RID: 1103
		public unsafe Object this[string s]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48880, RefRangeEnd = 48882, XrefRangeStart = 48879, XrefRangeEnd = 48880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48885, RefRangeEnd = 48886, XrefRangeStart = 48882, XrefRangeEnd = 48885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00045750 File Offset: 0x00043950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48887, RefRangeEnd = 48888, XrefRangeStart = 48886, XrefRangeEnd = 48887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00045790 File Offset: 0x00043990
		public unsafe Object SyncRoot
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12038, RefRangeEnd = 12046, XrefRangeStart = 12038, XrefRangeEnd = 12046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x000078E5 File Offset: 0x00005AE5
		public PathList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x000457D0 File Offset: 0x000439D0
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x000078EE File Offset: 0x00005AEE
		public unsafe SortedList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathList.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathList.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_GetCookiesCount_Public_Int32_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ICollection_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_Object_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_get_Object_0;

		// Token: 0x020001BA RID: 442
		[Serializable]
		public class PathListComparer : Object
		{
			// Token: 0x060018D0 RID: 6352 RVA: 0x0006A380 File Offset: 0x00068580
			// Note: this type is marked as 'beforefieldinit'.
			static PathListComparer()
			{
				Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathList>.NativeClassPtr, "PathListComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr);
				PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, "StaticInstance");
				PathList.PathListComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, 100665283);
				PathList.PathListComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr, 100665284);
			}

			// Token: 0x060018D1 RID: 6353 RVA: 0x0006A3E8 File Offset: 0x000685E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48824, XrefRangeEnd = 48835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Collections_IComparer_Compare(Object ol, Object or)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ol);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.PathListComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018D2 RID: 6354 RVA: 0x0006A448 File Offset: 0x00068648
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathListComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathList.PathListComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathList.PathListComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018D3 RID: 6355 RVA: 0x0000D035 File Offset: 0x0000B235
			public PathListComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0006A484 File Offset: 0x00068684
			// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0000D03E File Offset: 0x0000B23E
			public unsafe static PathList.PathListComparer StaticInstance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathList.PathListComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathList.PathListComparer.NativeFieldInfoPtr_StaticInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001395 RID: 5013
			private static readonly IntPtr NativeFieldInfoPtr_StaticInstance;

			// Token: 0x04001396 RID: 5014
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x04001397 RID: 5015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
