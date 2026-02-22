using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000A RID: 10
	[Serializable]
	public class GD_Cell : Object
	{
		// Token: 0x06000080 RID: 128 RVA: 0x000048C0 File Offset: 0x00002AC0
		// Note: this type is marked as 'beforefieldinit'.
		static GD_Cell()
		{
			Il2CppClassPointerStore<GD_Cell>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_Cell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr);
			GD_Cell.NativeFieldInfoPtr_m_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, "m_col");
			GD_Cell.NativeFieldInfoPtr_m_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, "m_row");
			GD_Cell.NativeFieldInfoPtr_m_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, "m_key");
			GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663364);
			GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663365);
			GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663366);
			GD_Cell.NativeMethodInfoPtr_get_row_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663367);
			GD_Cell.NativeMethodInfoPtr_set_row_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663368);
			GD_Cell.NativeMethodInfoPtr_get_col_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663369);
			GD_Cell.NativeMethodInfoPtr_set_col_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663370);
			GD_Cell.NativeMethodInfoPtr_get_key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663371);
			GD_Cell.NativeMethodInfoPtr_set_key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663372);
			GD_Cell.NativeMethodInfoPtr_Copy_Public_GD_Cell_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663373);
			GD_Cell.NativeMethodInfoPtr_GenerateKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr, 100663374);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004A08 File Offset: 0x00002C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126163, XrefRangeEnd = 126166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Cell()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004A44 File Offset: 0x00002C44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 126172, RefRangeEnd = 126183, XrefRangeStart = 126166, XrefRangeEnd = 126172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Cell(int colIndex, int rowIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref colIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004A9C File Offset: 0x00002C9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126187, RefRangeEnd = 126191, XrefRangeStart = 126183, XrefRangeEnd = 126187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Cell(string CellKey)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Cell>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(CellKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00004AE8 File Offset: 0x00002CE8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00004B24 File Offset: 0x00002D24
		public unsafe int row
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_get_row_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 126194, RefRangeEnd = 126198, XrefRangeStart = 126191, XrefRangeEnd = 126194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_set_row_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004B64 File Offset: 0x00002D64
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00004BA0 File Offset: 0x00002DA0
		public unsafe int col
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_get_col_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 126201, RefRangeEnd = 126207, XrefRangeStart = 126198, XrefRangeEnd = 126201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_set_col_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004BE0 File Offset: 0x00002DE0
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00004C18 File Offset: 0x00002E18
		public unsafe string key
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_get_key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 126219, RefRangeEnd = 126223, XrefRangeStart = 126207, XrefRangeEnd = 126219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_set_key_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004C5C File Offset: 0x00002E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126223, XrefRangeEnd = 126227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Cell Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_Copy_Public_GD_Cell_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004C9C File Offset: 0x00002E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126227, XrefRangeEnd = 126230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Cell.NativeMethodInfoPtr_GenerateKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002297 File Offset: 0x00000497
		public GD_Cell(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004CD0 File Offset: 0x00002ED0
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000022A0 File Offset: 0x000004A0
		public unsafe int m_col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_col)) = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004CF8 File Offset: 0x00002EF8
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022BB File Offset: 0x000004BB
		public unsafe int m_row
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_row);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_row)) = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004D20 File Offset: 0x00002F20
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022D6 File Offset: 0x000004D6
		public unsafe string m_key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Cell.NativeFieldInfoPtr_m_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_col;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_row;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_key;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_row_Public_get_Int32_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_row_Public_set_Void_Int32_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_col_Public_get_Int32_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_col_Public_set_Void_Int32_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_key_Public_get_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_key_Public_set_Void_String_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_GD_Cell_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Private_Void_0;
	}
}
