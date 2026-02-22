using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class GD_CellDictionaryRange : Object
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00004D48 File Offset: 0x00002F48
		// Note: this type is marked as 'beforefieldinit'.
		static GD_CellDictionaryRange()
		{
			Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_CellDictionaryRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr);
			GD_CellDictionaryRange.NativeFieldInfoPtr_CellRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, "CellRange");
			GD_CellDictionaryRange.NativeFieldInfoPtr_RowShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, "RowShift");
			GD_CellDictionaryRange.NativeFieldInfoPtr_ColumnShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, "ColumnShift");
			GD_CellDictionaryRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, 100663375);
			GD_CellDictionaryRange.NativeMethodInfoPtr__ctor_Public_Void_GD_CellRange_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, 100663376);
			GD_CellDictionaryRange.NativeMethodInfoPtr_GetValueCellForKey_Public_GD_Cell_GD_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, 100663377);
			GD_CellDictionaryRange.NativeMethodInfoPtr_GetCellRangeWithOffset_Public_GD_CellRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004E04 File Offset: 0x00003004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126230, XrefRangeEnd = 126237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellDictionaryRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellDictionaryRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004E40 File Offset: 0x00003040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126237, XrefRangeEnd = 126238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellDictionaryRange(GD_CellRange range, int colShiftValue, int rowShiftValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_CellDictionaryRange>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(range);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colShiftValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowShiftValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellDictionaryRange.NativeMethodInfoPtr__ctor_Public_Void_GD_CellRange_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00004EA8 File Offset: 0x000030A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126242, RefRangeEnd = 126243, XrefRangeStart = 126238, XrefRangeEnd = 126242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Cell GetValueCellForKey(GD_Cell key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellDictionaryRange.NativeMethodInfoPtr_GetValueCellForKey_Public_GD_Cell_GD_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004EF8 File Offset: 0x000030F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126243, XrefRangeEnd = 126255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellRange GetCellRangeWithOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellDictionaryRange.NativeMethodInfoPtr_GetCellRangeWithOffset_Public_GD_CellRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_CellRange>(intPtr3) : null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000022F5 File Offset: 0x000004F5
		public GD_CellDictionaryRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000022FE File Offset: 0x000004FE
		public unsafe GD_CellRange CellRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_CellRange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_CellRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_CellRange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000231D File Offset: 0x0000051D
		public unsafe int RowShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_RowShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_RowShift)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004F90 File Offset: 0x00003190
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002338 File Offset: 0x00000538
		public unsafe int ColumnShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_ColumnShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellDictionaryRange.NativeFieldInfoPtr_ColumnShift)) = value;
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_CellRange;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_RowShift;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_ColumnShift;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GD_CellRange_Int32_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetValueCellForKey_Public_GD_Cell_GD_Cell_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetCellRangeWithOffset_Public_GD_CellRange_0;
	}
}
