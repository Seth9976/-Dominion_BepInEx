using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000004 RID: 4
	public class GD_Reader : Object
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00003724 File Offset: 0x00001924
		// Note: this type is marked as 'beforefieldinit'.
		static GD_Reader()
		{
			Il2CppClassPointerStore<GD_Reader>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_Reader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr);
			GD_Reader.NativeFieldInfoPtr_sheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "sheets");
			GD_Reader.NativeFieldInfoPtr_s_requestedDoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "s_requestedDoc");
			GD_Reader.NativeFieldInfoPtr_s_worksheetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "s_worksheetIndex");
			GD_Reader.NativeFieldInfoPtr_s_finishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "s_finishCallback");
			GD_Reader.NativeFieldInfoPtr_s_drawProgressBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "s_drawProgressBar");
			GD_Reader.NativeFieldInfoPtr_DocsCacheData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "DocsCacheData");
			GD_Reader.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663328);
			GD_Reader.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663329);
			GD_Reader.NativeMethodInfoPtr_RunNextRetrieveRequest_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663330);
			GD_Reader.NativeMethodInfoPtr_CompleteRetrieve_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663331);
			GD_Reader.NativeMethodInfoPtr_StartRetrievePublicSheetData_Private_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663332);
			GD_Reader.NativeMethodInfoPtr_LoadSheetData_Public_Static_Void_GD_SpreadsheetData_Int32_GD_DocTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663333);
			GD_Reader.NativeMethodInfoPtr_RetiveSheetDataLocal_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663334);
			GD_Reader.NativeMethodInfoPtr_GetDocCache_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663335);
			GD_Reader.NativeMethodInfoPtr_SetDocCache_Public_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663336);
			GD_Reader.NativeMethodInfoPtr_FillSpreadsheetWithData_Private_Static_Void_GD_SpreadsheetData_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663337);
			GD_Reader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, 100663338);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000038A8 File Offset: 0x00001AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125545, RefRangeEnd = 125546, XrefRangeStart = 125520, XrefRangeEnd = 125545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetrievePublicSheetData(GD_DocTemplate doc, bool drawProgressBar = true, Action finish = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003900 File Offset: 0x00001B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125546, XrefRangeEnd = 125565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetrievePublicSheetData(GD_DocTemplate doc, GD_WorksheetTemplate worksheet, bool drawProgressBar = true, Action finish = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worksheet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003968 File Offset: 0x00001B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125565, XrefRangeEnd = 125583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunNextRetrieveRequest()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_RunNextRetrieveRequest_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003990 File Offset: 0x00001B90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125591, RefRangeEnd = 125592, XrefRangeStart = 125583, XrefRangeEnd = 125591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CompleteRetrieve()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_CompleteRetrieve_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartRetrievePublicSheetData(GD_DocTemplate doc, GD_WorksheetTemplate worksheet, bool drawProgressBar = true, Action finish = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worksheet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_StartRetrievePublicSheetData_Private_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003A20 File Offset: 0x00001C20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadSheetData(GD_SpreadsheetData spreadsheetData, int tableListId, GD_DocTemplate doc, bool drawProgressBar, Action finish)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spreadsheetData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tableListId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_LoadSheetData_Public_Static_Void_GD_SpreadsheetData_Int32_GD_DocTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003A98 File Offset: 0x00001C98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125619, RefRangeEnd = 125621, XrefRangeStart = 125592, XrefRangeEnd = 125619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetiveSheetDataLocal(string docName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_RetiveSheetDataLocal_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003AD0 File Offset: 0x00001CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125652, RefRangeEnd = 125653, XrefRangeStart = 125621, XrefRangeEnd = 125652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDocCache(string docName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_GetDocCache_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003B0C File Offset: 0x00001D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125653, XrefRangeEnd = 125711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDocCache(string docName, int tableListId, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tableListId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_SetDocCache_Public_Static_Void_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B64 File Offset: 0x00001D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125851, RefRangeEnd = 125852, XrefRangeStart = 125711, XrefRangeEnd = 125851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillSpreadsheetWithData(GD_SpreadsheetData spreadsheet, int tableListId, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spreadsheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tableListId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr_FillSpreadsheetWithData_Private_Static_Void_GD_SpreadsheetData_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003BBC File Offset: 0x00001DBC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Reader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020D1 File Offset: 0x000002D1
		public GD_Reader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000020DA File Offset: 0x000002DA
		public unsafe static Dictionary<string, GD_SpreadsheetData> sheets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_sheets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GD_SpreadsheetData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_sheets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003C20 File Offset: 0x00001E20
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000020EC File Offset: 0x000002EC
		public unsafe static GD_DocTemplate s_requestedDoc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_s_requestedDoc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_DocTemplate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_s_requestedDoc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003C48 File Offset: 0x00001E48
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000020FE File Offset: 0x000002FE
		public unsafe static int s_worksheetIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_s_worksheetIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_s_worksheetIndex, (void*)(&value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003C64 File Offset: 0x00001E64
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000210C File Offset: 0x0000030C
		public unsafe static Action s_finishCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_s_finishCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_s_finishCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003C8C File Offset: 0x00001E8C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000211E File Offset: 0x0000031E
		public unsafe static bool s_drawProgressBar
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_s_drawProgressBar, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_s_drawProgressBar, (void*)(&value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003CA8 File Offset: 0x00001EA8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000212C File Offset: 0x0000032C
		public unsafe static Dictionary<string, string> DocsCacheData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Reader.NativeFieldInfoPtr_DocsCacheData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Reader.NativeFieldInfoPtr_DocsCacheData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_sheets;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_s_requestedDoc;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_s_worksheetIndex;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_s_finishCallback;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_s_drawProgressBar;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_DocsCacheData;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_RunNextRetrieveRequest_Private_Static_Void_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_CompleteRetrieve_Private_Static_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_StartRetrievePublicSheetData_Private_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_LoadSheetData_Public_Static_Void_GD_SpreadsheetData_Int32_GD_DocTemplate_Boolean_Action_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_RetiveSheetDataLocal_Public_Static_Void_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_GetDocCache_Private_Static_String_String_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_SetDocCache_Public_Static_Void_String_Int32_String_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_FillSpreadsheetWithData_Private_Static_Void_GD_SpreadsheetData_Int32_String_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("SA.Productivity.GoogleSheets.GD_Reader+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000132 RID: 306 RVA: 0x00006F98 File Offset: 0x00005198
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GD_Reader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr);
				GD_Reader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr, "<>9");
				GD_Reader.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr, "<>9__6_0");
				GD_Reader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr, 100663442);
				GD_Reader.__c.NativeMethodInfoPtr__RetrievePublicSheetData_b__6_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr, 100663443);
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00007014 File Offset: 0x00005214
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Reader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00007050 File Offset: 0x00005250
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125511, XrefRangeEnd = 125520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RetrievePublicSheetData_b__6_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Reader.__c.NativeMethodInfoPtr__RetrievePublicSheetData_b__6_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000135 RID: 309 RVA: 0x000026AA File Offset: 0x000008AA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000136 RID: 310 RVA: 0x00007084 File Offset: 0x00005284
			// (set) Token: 0x06000137 RID: 311 RVA: 0x000026B3 File Offset: 0x000008B3
			public unsafe static GD_Reader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_Reader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_Reader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_Reader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000138 RID: 312 RVA: 0x000070AC File Offset: 0x000052AC
			// (set) Token: 0x06000139 RID: 313 RVA: 0x000026C5 File Offset: 0x000008C5
			public unsafe static Action __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_Reader.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_Reader.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000EF RID: 239
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000F0 RID: 240
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000F2 RID: 242
			private static readonly IntPtr NativeMethodInfoPtr__RetrievePublicSheetData_b__6_0_Internal_Void_0;
		}
	}
}
