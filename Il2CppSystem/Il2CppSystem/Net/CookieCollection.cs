using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class CookieCollection : Object
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x0004463C File Offset: 0x0004283C
		// Note: this type is marked as 'beforefieldinit'.
		static CookieCollection()
		{
			Il2CppClassPointerStore<CookieCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr);
			CookieCollection.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_version");
			CookieCollection.NativeFieldInfoPtr_m_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_list");
			CookieCollection.NativeFieldInfoPtr_m_TimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_TimeStamp");
			CookieCollection.NativeFieldInfoPtr_m_has_other_versions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_has_other_versions");
			CookieCollection.NativeFieldInfoPtr_m_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "m_IsReadOnly");
			CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665243);
			CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665244);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665245);
			CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665246);
			CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665247);
			CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665248);
			CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665249);
			CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665250);
			CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665251);
			CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665252);
			CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665253);
			CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, 100665254);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000447C0 File Offset: 0x000429C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48265, RefRangeEnd = 48268, XrefRangeStart = 48256, XrefRangeEnd = 48265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700043E RID: 1086
		public unsafe Cookie this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 48270, RefRangeEnd = 48273, XrefRangeStart = 48268, XrefRangeEnd = 48270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cookie>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00044848 File Offset: 0x00042A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48273, XrefRangeEnd = 48281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0004488C File Offset: 0x00042A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48303, RefRangeEnd = 48304, XrefRangeStart = 48281, XrefRangeEnd = 48303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(CookieCollection cookies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x000448D0 File Offset: 0x00042AD0
		public unsafe virtual int Count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44239, RefRangeEnd = 44242, XrefRangeStart = 44239, XrefRangeEnd = 44242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0004490C File Offset: 0x00042B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48304, XrefRangeEnd = 48305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0004495C File Offset: 0x00042B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48305, XrefRangeEnd = 48309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime TimeStamp(CookieCollection.Stamp how)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref how;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x000449A8 File Offset: 0x00042BA8
		public unsafe bool IsOtherVersionSeen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000449E4 File Offset: 0x00042BE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48335, RefRangeEnd = 48338, XrefRangeStart = 48309, XrefRangeEnd = 48335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalAdd(Cookie cookie, bool isStrict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStrict;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00044A40 File Offset: 0x00042C40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48363, RefRangeEnd = 48366, XrefRangeStart = 48338, XrefRangeEnd = 48363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(Cookie cookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00044A90 File Offset: 0x00042C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48366, XrefRangeEnd = 48367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00044AD0 File Offset: 0x00042CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48367, XrefRangeEnd = 48371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00007737 File Offset: 0x00005937
		public CookieCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00044B10 File Offset: 0x00042D10
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00007740 File Offset: 0x00005940
		public unsafe int m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_version)) = value;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00044B38 File Offset: 0x00042D38
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x0000775B File Offset: 0x0000595B
		public unsafe ArrayList m_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00044B68 File Offset: 0x00042D68
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x0000777A File Offset: 0x0000597A
		public unsafe DateTime m_TimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_TimeStamp)) = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00044B90 File Offset: 0x00042D90
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x00007795 File Offset: 0x00005995
		public unsafe bool m_has_other_versions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_has_other_versions)) = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x00044BB8 File Offset: 0x00042DB8
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x000077B0 File Offset: 0x000059B0
		public unsafe bool m_IsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.NativeFieldInfoPtr_m_IsReadOnly)) = value;
			}
		}

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr_m_list;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeStamp;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeFieldInfoPtr_m_has_other_versions;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeFieldInfoPtr_m_IsReadOnly;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Cookie_Int32_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Cookie_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_CookieCollection_0;

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeMethodInfoPtr_TimeStamp_Internal_DateTime_Stamp_0;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOtherVersionSeen_Internal_get_Boolean_0;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeMethodInfoPtr_InternalAdd_Internal_Int32_Cookie_Boolean_0;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Int32_Cookie_0;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Internal_Void_Int32_0;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020001B8 RID: 440
		public enum Stamp
		{
			// Token: 0x04001389 RID: 5001
			Check,
			// Token: 0x0400138A RID: 5002
			Set,
			// Token: 0x0400138B RID: 5003
			SetToUnused,
			// Token: 0x0400138C RID: 5004
			SetToMaxUsed
		}

		// Token: 0x020001B9 RID: 441
		public class CookieCollectionEnumerator : Object
		{
			// Token: 0x060018C2 RID: 6338 RVA: 0x0006A110 File Offset: 0x00068310
			// Note: this type is marked as 'beforefieldinit'.
			static CookieCollectionEnumerator()
			{
				Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookieCollection>.NativeClassPtr, "CookieCollectionEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr);
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_cookies");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_count");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_index");
				CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, "m_version");
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665255);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665256);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665257);
				CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr, 100665258);
			}

			// Token: 0x060018C3 RID: 6339 RVA: 0x0006A1DC File Offset: 0x000683DC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 48236, RefRangeEnd = 48240, XrefRangeStart = 48234, XrefRangeEnd = 48236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookieCollectionEnumerator(CookieCollection cookies)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieCollection.CookieCollectionEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookies);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0006A228 File Offset: 0x00068428
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48240, XrefRangeEnd = 48256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018C5 RID: 6341 RVA: 0x0006A268 File Offset: 0x00068468
			[CallerCount(0)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060018C6 RID: 6342 RVA: 0x0006A2A4 File Offset: 0x000684A4
			[CallerCount(0)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieCollection.CookieCollectionEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018C7 RID: 6343 RVA: 0x0000CFBC File Offset: 0x0000B1BC
			public CookieCollectionEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0006A2D8 File Offset: 0x000684D8
			// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000CFC5 File Offset: 0x0000B1C5
			public unsafe CookieCollection m_cookies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_cookies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x060018CA RID: 6346 RVA: 0x0006A308 File Offset: 0x00068508
			// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
			public unsafe int m_count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_count)) = value;
				}
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x060018CC RID: 6348 RVA: 0x0006A330 File Offset: 0x00068530
			// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000CFFF File Offset: 0x0000B1FF
			public unsafe int m_index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_index)) = value;
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x060018CE RID: 6350 RVA: 0x0006A358 File Offset: 0x00068558
			// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000D01A File Offset: 0x0000B21A
			public unsafe int m_version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieCollection.CookieCollectionEnumerator.NativeFieldInfoPtr_m_version)) = value;
				}
			}

			// Token: 0x0400138D RID: 5005
			private static readonly IntPtr NativeFieldInfoPtr_m_cookies;

			// Token: 0x0400138E RID: 5006
			private static readonly IntPtr NativeFieldInfoPtr_m_count;

			// Token: 0x0400138F RID: 5007
			private static readonly IntPtr NativeFieldInfoPtr_m_index;

			// Token: 0x04001390 RID: 5008
			private static readonly IntPtr NativeFieldInfoPtr_m_version;

			// Token: 0x04001391 RID: 5009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CookieCollection_0;

			// Token: 0x04001392 RID: 5010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001393 RID: 5011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001394 RID: 5012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
