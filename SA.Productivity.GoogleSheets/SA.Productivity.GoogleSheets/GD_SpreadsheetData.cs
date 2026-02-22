using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000006 RID: 6
	public class GD_SpreadsheetData : Object
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00004658 File Offset: 0x00002858
		// Note: this type is marked as 'beforefieldinit'.
		static GD_SpreadsheetData()
		{
			Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_SpreadsheetData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr);
			GD_SpreadsheetData.NativeFieldInfoPtr_m_worksheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, "m_worksheets");
			GD_SpreadsheetData.NativeMethodInfoPtr_SetData_Public_Void_Int32_UInt32_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, 100663359);
			GD_SpreadsheetData.NativeMethodInfoPtr_GetData_Public_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, 100663360);
			GD_SpreadsheetData.NativeMethodInfoPtr_get_worksheets_Public_get_Dictionary_2_Int32_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, 100663361);
			GD_SpreadsheetData.NativeMethodInfoPtr_set_worksheets_Public_set_Void_Dictionary_2_Int32_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, 100663362);
			GD_SpreadsheetData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr, 100663363);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004700 File Offset: 0x00002900
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126132, RefRangeEnd = 126135, XrefRangeStart = 126104, XrefRangeEnd = 126132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(int worksheetIndex, uint row, uint col, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worksheetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_SpreadsheetData.NativeMethodInfoPtr_SetData_Public_Void_Int32_UInt32_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004770 File Offset: 0x00002970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126153, RefRangeEnd = 126155, XrefRangeStart = 126135, XrefRangeEnd = 126153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetData(int worksheetIndex, int row, int col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worksheetIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_SpreadsheetData.NativeMethodInfoPtr_GetData_Public_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000047D0 File Offset: 0x000029D0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00004810 File Offset: 0x00002A10
		public unsafe Dictionary<int, Dictionary<string, string>> worksheets
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_SpreadsheetData.NativeMethodInfoPtr_get_worksheets_Public_get_Dictionary_2_Int32_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<string, string>>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_SpreadsheetData.NativeMethodInfoPtr_set_worksheets_Public_set_Void_Dictionary_2_Int32_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004854 File Offset: 0x00002A54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126162, RefRangeEnd = 126163, XrefRangeStart = 126155, XrefRangeEnd = 126162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_SpreadsheetData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_SpreadsheetData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_SpreadsheetData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000226F File Offset: 0x0000046F
		public GD_SpreadsheetData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002278 File Offset: 0x00000478
		public unsafe Dictionary<int, Dictionary<string, string>> m_worksheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_SpreadsheetData.NativeFieldInfoPtr_m_worksheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Dictionary<string, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_SpreadsheetData.NativeFieldInfoPtr_m_worksheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_m_worksheets;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_Int32_UInt32_UInt32_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_String_Int32_Int32_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_worksheets_Public_get_Dictionary_2_Int32_Dictionary_2_String_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_worksheets_Public_set_Void_Dictionary_2_Int32_Dictionary_2_String_String_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
