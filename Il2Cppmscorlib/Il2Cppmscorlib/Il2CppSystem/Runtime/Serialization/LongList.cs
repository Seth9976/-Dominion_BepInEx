using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000337 RID: 823
	[Serializable]
	public class LongList : Object
	{
		// Token: 0x06003533 RID: 13619 RVA: 0x00103D64 File Offset: 0x00101F64
		// Note: this type is marked as 'beforefieldinit'.
		static LongList()
		{
			Il2CppClassPointerStore<LongList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "LongList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LongList>.NativeClassPtr);
			LongList.NativeFieldInfoPtr_m_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_values");
			LongList.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_count");
			LongList.NativeFieldInfoPtr_m_totalItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_totalItems");
			LongList.NativeFieldInfoPtr_m_currentItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LongList>.NativeClassPtr, "m_currentItem");
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671532);
			LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671533);
			LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671534);
			LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671535);
			LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671536);
			LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671537);
			LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671538);
			LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671539);
			LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LongList>.NativeClassPtr, 100671540);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00103E98 File Offset: 0x00102098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343338, RefRangeEnd = 343340, XrefRangeStart = 343334, XrefRangeEnd = 343338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x00103ED4 File Offset: 0x001020D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343340, XrefRangeEnd = 343344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LongList(int startingSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LongList>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003536 RID: 13622 RVA: 0x00103F1C File Offset: 0x0010211C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343348, RefRangeEnd = 343350, XrefRangeStart = 343344, XrefRangeEnd = 343348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_Add_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06003537 RID: 13623 RVA: 0x00103F5C File Offset: 0x0010215C
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003538 RID: 13624 RVA: 0x00103F98 File Offset: 0x00102198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343350, RefRangeEnd = 343351, XrefRangeStart = 343350, XrefRangeEnd = 343350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEnumeration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_StartEnumeration_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003539 RID: 13625 RVA: 0x00103FCC File Offset: 0x001021CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343351, RefRangeEnd = 343352, XrefRangeStart = 343351, XrefRangeEnd = 343351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_MoveNext_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x00104008 File Offset: 0x00102208
		public unsafe long Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 343352, RefRangeEnd = 343353, XrefRangeStart = 343352, XrefRangeEnd = 343352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_get_Current_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600353B RID: 13627 RVA: 0x00104044 File Offset: 0x00102244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343353, RefRangeEnd = 343356, XrefRangeStart = 343353, XrefRangeEnd = 343353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveElement(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x00104090 File Offset: 0x00102290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343356, XrefRangeEnd = 343360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnlargeArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LongList.NativeMethodInfoPtr_EnlargeArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x0001302B File Offset: 0x0001122B
		public LongList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x001040C4 File Offset: 0x001022C4
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x00013034 File Offset: 0x00011234
		public unsafe Il2CppStructArray<long> m_values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x001040F4 File Offset: 0x001022F4
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x00013053 File Offset: 0x00011253
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x0010411C File Offset: 0x0010231C
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x0001306E File Offset: 0x0001126E
		public unsafe int m_totalItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_totalItems)) = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x00104144 File Offset: 0x00102344
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x00013089 File Offset: 0x00011289
		public unsafe int m_currentItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LongList.NativeFieldInfoPtr_m_currentItem)) = value;
			}
		}

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeFieldInfoPtr_m_values;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeFieldInfoPtr_m_totalItems;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeFieldInfoPtr_m_currentItem;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Int64_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_StartEnumeration_Internal_Void_0;

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Internal_Boolean_0;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Int64_0;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElement_Internal_Boolean_Int64_0;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr_EnlargeArray_Private_Void_0;
	}
}
