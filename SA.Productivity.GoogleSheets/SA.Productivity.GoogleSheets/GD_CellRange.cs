using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class GD_CellRange : Object
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00004FB8 File Offset: 0x000031B8
		// Note: this type is marked as 'beforefieldinit'.
		static GD_CellRange()
		{
			Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_CellRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr);
			GD_CellRange.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, "Direction");
			GD_CellRange.NativeFieldInfoPtr_StartCell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, "StartCell");
			GD_CellRange.NativeFieldInfoPtr_UseLinebreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, "UseLinebreak");
			GD_CellRange.NativeFieldInfoPtr_LineLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, "LineLength");
			GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, 100663379);
			GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, 100663380);
			GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_String_GD_RanageDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr, 100663381);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005074 File Offset: 0x00003274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126258, RefRangeEnd = 126259, XrefRangeStart = 126255, XrefRangeEnd = 126258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellRange()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000050B0 File Offset: 0x000032B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126259, XrefRangeEnd = 126260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellRange(string StartCellKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(StartCellKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000050FC File Offset: 0x000032FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 126268, RefRangeEnd = 126274, XrefRangeStart = 126260, XrefRangeEnd = 126268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_CellRange(string StartCellKey, GD_RanageDirection rangeDirection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_CellRange>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(StartCellKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rangeDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_CellRange.NativeMethodInfoPtr__ctor_Public_Void_String_GD_RanageDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002353 File Offset: 0x00000553
		public GD_CellRange(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005158 File Offset: 0x00003358
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000235C File Offset: 0x0000055C
		public unsafe GD_RanageDirection Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_Direction)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005180 File Offset: 0x00003380
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002377 File Offset: 0x00000577
		public unsafe GD_Cell StartCell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_StartCell);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_StartCell), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000051B0 File Offset: 0x000033B0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002396 File Offset: 0x00000596
		public unsafe bool UseLinebreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_UseLinebreak);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_UseLinebreak)) = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000051D8 File Offset: 0x000033D8
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023B1 File Offset: 0x000005B1
		public unsafe int LineLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_LineLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_CellRange.NativeFieldInfoPtr_LineLength)) = value;
			}
		}

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_Direction;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_StartCell;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_UseLinebreak;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_LineLength;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_GD_RanageDirection_0;
	}
}
