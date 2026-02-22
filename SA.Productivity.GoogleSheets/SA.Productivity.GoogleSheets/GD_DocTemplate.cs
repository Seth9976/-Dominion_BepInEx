using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000D RID: 13
	[Serializable]
	public class GD_DocTemplate : Object
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00005200 File Offset: 0x00003400
		// Note: this type is marked as 'beforefieldinit'.
		static GD_DocTemplate()
		{
			Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_DocTemplate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr);
			GD_DocTemplate.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "Key");
			GD_DocTemplate.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "Name");
			GD_DocTemplate.NativeFieldInfoPtr_DocName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "DocName");
			GD_DocTemplate.NativeFieldInfoPtr_DocIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "DocIndex");
			GD_DocTemplate.NativeFieldInfoPtr_SelectedWorksheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "SelectedWorksheet");
			GD_DocTemplate.NativeFieldInfoPtr_m_creationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "m_creationTime");
			GD_DocTemplate.NativeFieldInfoPtr_m_worksheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, "m_worksheets");
			GD_DocTemplate.NativeMethodInfoPtr_InitDoc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663382);
			GD_DocTemplate.NativeMethodInfoPtr_AddNewWorksheet_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663383);
			GD_DocTemplate.NativeMethodInfoPtr_RemoveWorksheet_Public_Void_GD_WorksheetTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663384);
			GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetId_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663385);
			GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663386);
			GD_DocTemplate.NativeMethodInfoPtr_WorksheetExist_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663387);
			GD_DocTemplate.NativeMethodInfoPtr_WorksheetExist_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663388);
			GD_DocTemplate.NativeMethodInfoPtr_UpdateTime_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663389);
			GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663390);
			GD_DocTemplate.NativeMethodInfoPtr_get_Worksheets_Public_get_List_1_GD_WorksheetTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663391);
			GD_DocTemplate.NativeMethodInfoPtr_get_HasCache_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663392);
			GD_DocTemplate.NativeMethodInfoPtr_get_CreationTime_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663393);
			GD_DocTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr, 100663394);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000053C0 File Offset: 0x000035C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126274, XrefRangeEnd = 126297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDoc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_InitDoc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000053F4 File Offset: 0x000035F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126297, XrefRangeEnd = 126309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNewWorksheet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_AddNewWorksheet_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005428 File Offset: 0x00003628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126309, XrefRangeEnd = 126313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveWorksheet(GD_WorksheetTemplate list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_RemoveWorksheet_Public_Void_GD_WorksheetTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000546C File Offset: 0x0000366C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126330, RefRangeEnd = 126332, XrefRangeStart = 126313, XrefRangeEnd = 126330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetWorksheetId(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetId_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000054BC File Offset: 0x000036BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126349, RefRangeEnd = 126350, XrefRangeStart = 126332, XrefRangeEnd = 126349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetWorksheetName(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005500 File Offset: 0x00003700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126350, XrefRangeEnd = 126365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WorksheetExist(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_WorksheetExist_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005550 File Offset: 0x00003750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126365, XrefRangeEnd = 126379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WorksheetExist(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_WorksheetExist_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000559C File Offset: 0x0000379C
		[CallerCount(0)]
		public unsafe void UpdateTime(string timeStr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(timeStr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_UpdateTime_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000055E0 File Offset: 0x000037E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126379, XrefRangeEnd = 126405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetWorksheetNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_GetWorksheetNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005620 File Offset: 0x00003820
		public unsafe List<GD_WorksheetTemplate> Worksheets
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_get_Worksheets_Public_get_List_1_GD_WorksheetTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GD_WorksheetTemplate>>(intPtr3) : null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005660 File Offset: 0x00003860
		public unsafe bool HasCache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126405, XrefRangeEnd = 126410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_get_HasCache_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000569C File Offset: 0x0000389C
		public unsafe string CreationTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126410, XrefRangeEnd = 126420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr_get_CreationTime_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126420, XrefRangeEnd = 126431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_DocTemplate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_DocTemplate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000023CC File Offset: 0x000005CC
		public GD_DocTemplate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005710 File Offset: 0x00003910
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000023D5 File Offset: 0x000005D5
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00005738 File Offset: 0x00003938
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000023F4 File Offset: 0x000005F4
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00005760 File Offset: 0x00003960
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002413 File Offset: 0x00000613
		public unsafe string DocName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_DocName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_DocName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005788 File Offset: 0x00003988
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002432 File Offset: 0x00000632
		public unsafe int DocIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_DocIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_DocIndex)) = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x000057B0 File Offset: 0x000039B0
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe int SelectedWorksheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_SelectedWorksheet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_SelectedWorksheet)) = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000057D8 File Offset: 0x000039D8
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe string m_creationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_m_creationTime);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_m_creationTime), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00005800 File Offset: 0x00003A00
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe List<GD_WorksheetTemplate> m_worksheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_m_worksheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GD_WorksheetTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_DocTemplate.NativeFieldInfoPtr_m_worksheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_DocName;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_DocIndex;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_SelectedWorksheet;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_creationTime;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_worksheets;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_InitDoc_Public_Void_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_AddNewWorksheet_Public_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_RemoveWorksheet_Public_Void_GD_WorksheetTemplate_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetWorksheetId_Public_Int32_String_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_GetWorksheetName_Public_String_Int32_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_WorksheetExist_Public_Boolean_String_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_WorksheetExist_Public_Boolean_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTime_Public_Void_String_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_GetWorksheetNames_Public_Il2CppStringArray_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_Worksheets_Public_get_List_1_GD_WorksheetTemplate_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_HasCache_Public_get_Boolean_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_get_CreationTime_Public_get_String_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
