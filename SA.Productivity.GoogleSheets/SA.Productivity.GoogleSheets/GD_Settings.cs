using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Foundation.Patterns;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000005 RID: 5
	public class GD_Settings : SA_ScriptableSingleton<GD_Settings>
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00003CD0 File Offset: 0x00001ED0
		// Note: this type is marked as 'beforefieldinit'.
		static GD_Settings()
		{
			Il2CppClassPointerStore<GD_Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr);
			GD_Settings.NativeFieldInfoPtr_PLUGIN_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "PLUGIN_NAME");
			GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "PLUGIN_FOLDER");
			GD_Settings.NativeFieldInfoPtr_DOCUMENTATION_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "DOCUMENTATION_URL");
			GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "GOOGLEDOC_URL_START");
			GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "GOOGLEDOC_URL_END");
			GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "SPREADSHEET_URL_START");
			GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "SPREADSHEET_URL_END");
			GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "SCRIPT_URL_START");
			GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_PARAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "SCRIPT_URL_PARAM");
			GD_Settings.NativeFieldInfoPtr_DOCS_CACHE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "DOCS_CACHE_PATH");
			GD_Settings.NativeFieldInfoPtr_Documents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "Documents");
			GD_Settings.NativeFieldInfoPtr_LocalizationDocKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "LocalizationDocKey");
			GD_Settings.NativeFieldInfoPtr_LOCALIZATION_LOG_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "LOCALIZATION_LOG_PREFIX");
			GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "PLUGIN_FOLDER_PATH");
			GD_Settings.NativeFieldInfoPtr_LOCALIZATION_ENUMS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, "LOCALIZATION_ENUMS_PATH");
			GD_Settings.NativeMethodInfoPtr_get_LocalizationDoc_Public_get_GD_DocTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663340);
			GD_Settings.NativeMethodInfoPtr_GetCachePath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663341);
			GD_Settings.NativeMethodInfoPtr_GetCachePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663342);
			GD_Settings.NativeMethodInfoPtr_GetRelativeCachePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663343);
			GD_Settings.NativeMethodInfoPtr_AddDoc_Public_Void_GD_DocTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663344);
			GD_Settings.NativeMethodInfoPtr_RemoveDoc_Public_Void_GD_DocTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663345);
			GD_Settings.NativeMethodInfoPtr_GetDocIndexByName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663346);
			GD_Settings.NativeMethodInfoPtr_GetDocIndexByKey_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663347);
			GD_Settings.NativeMethodInfoPtr_GetDocByName_Public_GD_DocTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663348);
			GD_Settings.NativeMethodInfoPtr_GetDocByKey_Public_GD_DocTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663349);
			GD_Settings.NativeMethodInfoPtr_GetDocByIndex_Public_GD_DocTemplate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663350);
			GD_Settings.NativeMethodInfoPtr_GetDocNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663351);
			GD_Settings.NativeMethodInfoPtr_OpenDocURL_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663352);
			GD_Settings.NativeMethodInfoPtr_get_BasePath_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663353);
			GD_Settings.NativeMethodInfoPtr_get_PluginName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663354);
			GD_Settings.NativeMethodInfoPtr_get_DocumentationURL_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663355);
			GD_Settings.NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663356);
			GD_Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr, 100663357);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003F94 File Offset: 0x00002194
		public unsafe GD_DocTemplate LocalizationDoc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125852, XrefRangeEnd = 125853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_get_LocalizationDoc_Public_get_GD_DocTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_DocTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003FD4 File Offset: 0x000021D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125853, XrefRangeEnd = 125866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCachePath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetCachePath_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004000 File Offset: 0x00002200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125886, RefRangeEnd = 125888, XrefRangeStart = 125866, XrefRangeEnd = 125886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCachePath(string docName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetCachePath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000403C File Offset: 0x0000223C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125888, XrefRangeEnd = 125898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetRelativeCachePath(string docName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetRelativeCachePath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004078 File Offset: 0x00002278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125898, XrefRangeEnd = 125902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDoc(GD_DocTemplate tpl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_AddDoc_Public_Void_GD_DocTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000040BC File Offset: 0x000022BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125902, XrefRangeEnd = 125946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDoc(GD_DocTemplate tpl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_RemoveDoc_Public_Void_GD_DocTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004100 File Offset: 0x00002300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125946, XrefRangeEnd = 125966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDocIndexByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocIndexByName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004150 File Offset: 0x00002350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125966, XrefRangeEnd = 125986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDocIndexByKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocIndexByKey_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000041A0 File Offset: 0x000023A0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 126003, RefRangeEnd = 126021, XrefRangeStart = 125986, XrefRangeEnd = 126003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_DocTemplate GetDocByName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocByName_Public_GD_DocTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_DocTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000041F0 File Offset: 0x000023F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 126038, RefRangeEnd = 126042, XrefRangeStart = 126021, XrefRangeEnd = 126038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_DocTemplate GetDocByKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocByKey_Public_GD_DocTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_DocTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004240 File Offset: 0x00002440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126042, XrefRangeEnd = 126045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_DocTemplate GetDocByIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocByIndex_Public_GD_DocTemplate_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_DocTemplate>(intPtr3) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000428C File Offset: 0x0000248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126045, XrefRangeEnd = 126075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetDocNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_GetDocNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000042CC File Offset: 0x000024CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126075, XrefRangeEnd = 126082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenDocURL(GD_DocTemplate doc, GD_WorksheetTemplate worksheet = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worksheet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr_OpenDocURL_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00004314 File Offset: 0x00002514
		public unsafe override string BasePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126082, XrefRangeEnd = 126084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GD_Settings.NativeMethodInfoPtr_get_BasePath_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004358 File Offset: 0x00002558
		public unsafe override string PluginName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126084, XrefRangeEnd = 126086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GD_Settings.NativeMethodInfoPtr_get_PluginName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000439C File Offset: 0x0000259C
		public unsafe override string DocumentationURL
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126086, XrefRangeEnd = 126088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GD_Settings.NativeMethodInfoPtr_get_DocumentationURL_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000043E0 File Offset: 0x000025E0
		public unsafe override string SettingsUIMenuItem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126088, XrefRangeEnd = 126090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GD_Settings.NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004424 File Offset: 0x00002624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126090, XrefRangeEnd = 126104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000213E File Offset: 0x0000033E
		public GD_Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004460 File Offset: 0x00002660
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002147 File Offset: 0x00000347
		public unsafe static string PLUGIN_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004480 File Offset: 0x00002680
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002159 File Offset: 0x00000359
		public unsafe static string PLUGIN_FOLDER
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000216B File Offset: 0x0000036B
		public unsafe static string DOCUMENTATION_URL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_DOCUMENTATION_URL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_DOCUMENTATION_URL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000044C0 File Offset: 0x000026C0
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000217D File Offset: 0x0000037D
		public unsafe static string GOOGLEDOC_URL_START
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_START, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_START, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000061 RID: 97 RVA: 0x000044E0 File Offset: 0x000026E0
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000218F File Offset: 0x0000038F
		public unsafe static string GOOGLEDOC_URL_END
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_END, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_GOOGLEDOC_URL_END, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00004500 File Offset: 0x00002700
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000021A1 File Offset: 0x000003A1
		public unsafe static string SPREADSHEET_URL_START
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_START, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_START, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004520 File Offset: 0x00002720
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000021B3 File Offset: 0x000003B3
		public unsafe static string SPREADSHEET_URL_END
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_END, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_SPREADSHEET_URL_END, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004540 File Offset: 0x00002740
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000021C5 File Offset: 0x000003C5
		public unsafe static string SCRIPT_URL_START
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_START, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_START, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021D7 File Offset: 0x000003D7
		public unsafe static string SCRIPT_URL_PARAM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_PARAM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_SCRIPT_URL_PARAM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004580 File Offset: 0x00002780
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000021E9 File Offset: 0x000003E9
		public unsafe static string DOCS_CACHE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_DOCS_CACHE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_DOCS_CACHE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000045A0 File Offset: 0x000027A0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000021FB File Offset: 0x000003FB
		public unsafe List<GD_DocTemplate> Documents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Settings.NativeFieldInfoPtr_Documents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GD_DocTemplate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Settings.NativeFieldInfoPtr_Documents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000045D0 File Offset: 0x000027D0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000221A File Offset: 0x0000041A
		public unsafe string LocalizationDocKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Settings.NativeFieldInfoPtr_LocalizationDocKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GD_Settings.NativeFieldInfoPtr_LocalizationDocKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000045F8 File Offset: 0x000027F8
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002239 File Offset: 0x00000439
		public unsafe static string LOCALIZATION_LOG_PREFIX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_LOCALIZATION_LOG_PREFIX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_LOCALIZATION_LOG_PREFIX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004618 File Offset: 0x00002818
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000224B File Offset: 0x0000044B
		public unsafe static string PLUGIN_FOLDER_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_PLUGIN_FOLDER_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004638 File Offset: 0x00002838
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000225D File Offset: 0x0000045D
		public unsafe static string LOCALIZATION_ENUMS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Settings.NativeFieldInfoPtr_LOCALIZATION_ENUMS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Settings.NativeFieldInfoPtr_LOCALIZATION_ENUMS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_PLUGIN_NAME;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_PLUGIN_FOLDER;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_DOCUMENTATION_URL;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_GOOGLEDOC_URL_START;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_GOOGLEDOC_URL_END;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_SPREADSHEET_URL_START;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_SPREADSHEET_URL_END;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_SCRIPT_URL_START;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_SCRIPT_URL_PARAM;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_DOCS_CACHE_PATH;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_Documents;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_LocalizationDocKey;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_LOCALIZATION_LOG_PREFIX;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_PLUGIN_FOLDER_PATH;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_LOCALIZATION_ENUMS_PATH;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalizationDoc_Public_get_GD_DocTemplate_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetCachePath_Public_Static_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetCachePath_Public_Static_String_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeCachePath_Public_Static_String_String_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_AddDoc_Public_Void_GD_DocTemplate_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDoc_Public_Void_GD_DocTemplate_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetDocIndexByName_Public_Int32_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_GetDocIndexByKey_Public_Int32_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_GetDocByName_Public_GD_DocTemplate_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetDocByKey_Public_GD_DocTemplate_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_GetDocByIndex_Public_GD_DocTemplate_Int32_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_GetDocNames_Public_Il2CppStringArray_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_OpenDocURL_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePath_Protected_Virtual_get_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_PluginName_Public_Virtual_get_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentationURL_Public_Virtual_get_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_SettingsUIMenuItem_Public_Virtual_get_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
