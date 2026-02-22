using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Resources;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000521 RID: 1313
	public class ManifestBuilder : Object
	{
		// Token: 0x06004BDD RID: 19421 RVA: 0x0015A2E4 File Offset: 0x001584E4
		// Note: this type is marked as 'beforefieldinit'.
		static ManifestBuilder()
		{
			Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "ManifestBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr);
			ManifestBuilder.NativeFieldInfoPtr_opcodeTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "opcodeTab");
			ManifestBuilder.NativeFieldInfoPtr_taskTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "taskTab");
			ManifestBuilder.NativeFieldInfoPtr_keywordTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "keywordTab");
			ManifestBuilder.NativeFieldInfoPtr_mapsTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "mapsTab");
			ManifestBuilder.NativeFieldInfoPtr_stringTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "stringTab");
			ManifestBuilder.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "sb");
			ManifestBuilder.NativeFieldInfoPtr_events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "events");
			ManifestBuilder.NativeFieldInfoPtr_templates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "templates");
			ManifestBuilder.NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "resources");
			ManifestBuilder.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "flags");
			ManifestBuilder.NativeFieldInfoPtr_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "errors");
			ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "perEventByteArrayArgIndices");
			ManifestBuilder.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "eventName");
			ManifestBuilder.NativeFieldInfoPtr_numParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "numParams");
			ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "byteArrArgIndices");
			ManifestBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674513);
			ManifestBuilder.NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674514);
			ManifestBuilder.NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674515);
			ManifestBuilder.NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674516);
			ManifestBuilder.NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674517);
			ManifestBuilder.NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674518);
			ManifestBuilder.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674519);
			ManifestBuilder.NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674520);
			ManifestBuilder.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674521);
			ManifestBuilder.NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674522);
			ManifestBuilder.NativeMethodInfoPtr_CreateManifestString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674523);
			ManifestBuilder.NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674524);
			ManifestBuilder.NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674525);
			ManifestBuilder.NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674526);
			ManifestBuilder.NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674527);
			ManifestBuilder.NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674528);
			ManifestBuilder.NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674529);
			ManifestBuilder.NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674530);
			ManifestBuilder.NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674531);
			ManifestBuilder.NativeMethodInfoPtr_GetTypeName_Private_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674532);
			ManifestBuilder.NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674533);
			ManifestBuilder.NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674534);
			ManifestBuilder.NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, 100674535);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x0015A60C File Offset: 0x0015880C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373985, RefRangeEnd = 373986, XrefRangeStart = 373903, XrefRangeEnd = 373985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManifestBuilder(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref providerGuid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dllName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resources);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x0015A698 File Offset: 0x00158898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373986, XrefRangeEnd = 374020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOpcode(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x0015A6E8 File Offset: 0x001588E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374020, XrefRangeEnd = 374060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTask(string name, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE1 RID: 19425 RVA: 0x0015A738 File Offset: 0x00158938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374130, RefRangeEnd = 374131, XrefRangeStart = 374060, XrefRangeEnd = 374130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyword(string name, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x0015A788 File Offset: 0x00158988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374207, RefRangeEnd = 374208, XrefRangeStart = 374131, XrefRangeEnd = 374207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEvent(string eventName, EventAttribute eventAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventAttribute);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x0015A7DC File Offset: 0x001589DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374309, RefRangeEnd = 374310, XrefRangeStart = 374208, XrefRangeEnd = 374309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventParameter(Type type, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x0015A830 File Offset: 0x00158A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374340, RefRangeEnd = 374341, XrefRangeStart = 374310, XrefRangeEnd = 374340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x0015A864 File Offset: 0x00158A64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374344, RefRangeEnd = 374345, XrefRangeStart = 374341, XrefRangeEnd = 374344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> CreateManifest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x0015A8A4 File Offset: 0x00158AA4
		public unsafe IList<string> Errors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BE7 RID: 19431 RVA: 0x0015A8E4 File Offset: 0x00158AE4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 374349, RefRangeEnd = 374357, XrefRangeStart = 374345, XrefRangeEnd = 374349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManifestError(string msg, bool runtimeCritical = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runtimeCritical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BE8 RID: 19432 RVA: 0x0015A934 File Offset: 0x00158B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374728, RefRangeEnd = 374729, XrefRangeStart = 374357, XrefRangeEnd = 374728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateManifestString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_CreateManifestString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BE9 RID: 19433 RVA: 0x0015A96C File Offset: 0x00158B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 374737, RefRangeEnd = 374739, XrefRangeStart = 374729, XrefRangeEnd = 374737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEA RID: 19434 RVA: 0x0015A9D4 File Offset: 0x00158BD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 374766, RefRangeEnd = 374770, XrefRangeStart = 374739, XrefRangeEnd = 374766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x0015AA50 File Offset: 0x00158C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374780, RefRangeEnd = 374781, XrefRangeStart = 374770, XrefRangeEnd = 374780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ci);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x0015AAB8 File Offset: 0x00158CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374807, RefRangeEnd = 374808, XrefRangeStart = 374781, XrefRangeEnd = 374807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<CultureInfo> GetSupportedCultures(ResourceManager resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CultureInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x0015AAFC File Offset: 0x00158CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374808, XrefRangeEnd = 374817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLevelName(EventLevel level)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x0015AB34 File Offset: 0x00158D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374817, XrefRangeEnd = 374831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTaskName(EventTask task, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref task;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x0015AB8C File Offset: 0x00158D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374847, RefRangeEnd = 374848, XrefRangeStart = 374831, XrefRangeEnd = 374847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetOpcodeName(EventOpcode opcode, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opcode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x0015ABE4 File Offset: 0x00158DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374879, RefRangeEnd = 374880, XrefRangeStart = 374848, XrefRangeEnd = 374879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKeywords(ulong keywords, string eventName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keywords;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x0015AC3C File Offset: 0x00158E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 374908, RefRangeEnd = 374909, XrefRangeStart = 374880, XrefRangeEnd = 374908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_GetTypeName_Private_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x0015AC84 File Offset: 0x00158E84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 374915, RefRangeEnd = 374920, XrefRangeStart = 374909, XrefRangeEnd = 374915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateStringBuilder(ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(stringBuilder);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(eventMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			stringBuilder = ((intPtr4 == 0) ? null : new StringBuilder(intPtr4));
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x0015AD00 File Offset: 0x00158F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 375026, RefRangeEnd = 375028, XrefRangeStart = 374920, XrefRangeEnd = 375026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TranslateToManifestConvention(string eventMessage, string evtName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(eventMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(evtName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BF4 RID: 19444 RVA: 0x0015AD5C File Offset: 0x00158F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 375045, RefRangeEnd = 375046, XrefRangeStart = 375028, XrefRangeEnd = 375045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TranslateIndexToManifestConvention(int idx, string evtName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(evtName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x0001C93F File Offset: 0x0001AB3F
		public ManifestBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06004BF6 RID: 19446 RVA: 0x0015ADB8 File Offset: 0x00158FB8
		// (set) Token: 0x06004BF7 RID: 19447 RVA: 0x0001C948 File Offset: 0x0001AB48
		public unsafe Dictionary<int, string> opcodeTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_opcodeTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_opcodeTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x0015ADE8 File Offset: 0x00158FE8
		// (set) Token: 0x06004BF9 RID: 19449 RVA: 0x0001C967 File Offset: 0x0001AB67
		public unsafe Dictionary<int, string> taskTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_taskTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_taskTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06004BFA RID: 19450 RVA: 0x0015AE18 File Offset: 0x00159018
		// (set) Token: 0x06004BFB RID: 19451 RVA: 0x0001C986 File Offset: 0x0001AB86
		public unsafe Dictionary<ulong, string> keywordTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_keywordTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_keywordTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0015AE48 File Offset: 0x00159048
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x0001C9A5 File Offset: 0x0001ABA5
		public unsafe Dictionary<string, Type> mapsTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_mapsTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_mapsTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06004BFE RID: 19454 RVA: 0x0015AE78 File Offset: 0x00159078
		// (set) Token: 0x06004BFF RID: 19455 RVA: 0x0001C9C4 File Offset: 0x0001ABC4
		public unsafe Dictionary<string, string> stringTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_stringTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_stringTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06004C00 RID: 19456 RVA: 0x0015AEA8 File Offset: 0x001590A8
		// (set) Token: 0x06004C01 RID: 19457 RVA: 0x0001C9E3 File Offset: 0x0001ABE3
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x0015AED8 File Offset: 0x001590D8
		// (set) Token: 0x06004C03 RID: 19459 RVA: 0x0001CA02 File Offset: 0x0001AC02
		public unsafe StringBuilder events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x0015AF08 File Offset: 0x00159108
		// (set) Token: 0x06004C05 RID: 19461 RVA: 0x0001CA21 File Offset: 0x0001AC21
		public unsafe StringBuilder templates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_templates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_templates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x0015AF38 File Offset: 0x00159138
		// (set) Token: 0x06004C07 RID: 19463 RVA: 0x0001CA40 File Offset: 0x0001AC40
		public unsafe ResourceManager resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0015AF68 File Offset: 0x00159168
		// (set) Token: 0x06004C09 RID: 19465 RVA: 0x0001CA5F File Offset: 0x0001AC5F
		public unsafe EventManifestOptions flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x0015AF90 File Offset: 0x00159190
		// (set) Token: 0x06004C0B RID: 19467 RVA: 0x0001CA7A File Offset: 0x0001AC7A
		public unsafe IList<string> errors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_errors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_errors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x0015AFC0 File Offset: 0x001591C0
		// (set) Token: 0x06004C0D RID: 19469 RVA: 0x0001CA99 File Offset: 0x0001AC99
		public unsafe Dictionary<string, List<int>> perEventByteArrayArgIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_perEventByteArrayArgIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x0015AFF0 File Offset: 0x001591F0
		// (set) Token: 0x06004C0F RID: 19471 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		public unsafe string eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x0015B018 File Offset: 0x00159218
		// (set) Token: 0x06004C11 RID: 19473 RVA: 0x0001CAD7 File Offset: 0x0001ACD7
		public unsafe int numParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_numParams);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_numParams)) = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x0015B040 File Offset: 0x00159240
		// (set) Token: 0x06004C13 RID: 19475 RVA: 0x0001CAF2 File Offset: 0x0001ACF2
		public unsafe List<int> byteArrArgIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.NativeFieldInfoPtr_byteArrArgIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeFieldInfoPtr_opcodeTab;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeFieldInfoPtr_taskTab;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeFieldInfoPtr_keywordTab;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeFieldInfoPtr_mapsTab;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeFieldInfoPtr_stringTab;

		// Token: 0x04003D3E RID: 15678
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x04003D3F RID: 15679
		private static readonly IntPtr NativeFieldInfoPtr_events;

		// Token: 0x04003D40 RID: 15680
		private static readonly IntPtr NativeFieldInfoPtr_templates;

		// Token: 0x04003D41 RID: 15681
		private static readonly IntPtr NativeFieldInfoPtr_resources;

		// Token: 0x04003D42 RID: 15682
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04003D43 RID: 15683
		private static readonly IntPtr NativeFieldInfoPtr_errors;

		// Token: 0x04003D44 RID: 15684
		private static readonly IntPtr NativeFieldInfoPtr_perEventByteArrayArgIndices;

		// Token: 0x04003D45 RID: 15685
		private static readonly IntPtr NativeFieldInfoPtr_eventName;

		// Token: 0x04003D46 RID: 15686
		private static readonly IntPtr NativeFieldInfoPtr_numParams;

		// Token: 0x04003D47 RID: 15687
		private static readonly IntPtr NativeFieldInfoPtr_byteArrArgIndices;

		// Token: 0x04003D48 RID: 15688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Guid_String_ResourceManager_EventManifestOptions_0;

		// Token: 0x04003D49 RID: 15689
		private static readonly IntPtr NativeMethodInfoPtr_AddOpcode_Public_Void_String_Int32_0;

		// Token: 0x04003D4A RID: 15690
		private static readonly IntPtr NativeMethodInfoPtr_AddTask_Public_Void_String_Int32_0;

		// Token: 0x04003D4B RID: 15691
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyword_Public_Void_String_UInt64_0;

		// Token: 0x04003D4C RID: 15692
		private static readonly IntPtr NativeMethodInfoPtr_StartEvent_Public_Void_String_EventAttribute_0;

		// Token: 0x04003D4D RID: 15693
		private static readonly IntPtr NativeMethodInfoPtr_AddEventParameter_Public_Void_Type_String_0;

		// Token: 0x04003D4E RID: 15694
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x04003D4F RID: 15695
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifest_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003D50 RID: 15696
		private static readonly IntPtr NativeMethodInfoPtr_get_Errors_Public_get_IList_1_String_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly IntPtr NativeMethodInfoPtr_ManifestError_Public_Void_String_Boolean_0;

		// Token: 0x04003D52 RID: 15698
		private static readonly IntPtr NativeMethodInfoPtr_CreateManifestString_Private_String_0;

		// Token: 0x04003D53 RID: 15699
		private static readonly IntPtr NativeMethodInfoPtr_WriteNameAndMessageAttribs_Private_Void_StringBuilder_String_String_0;

		// Token: 0x04003D54 RID: 15700
		private static readonly IntPtr NativeMethodInfoPtr_WriteMessageAttrib_Private_Void_StringBuilder_String_String_String_0;

		// Token: 0x04003D55 RID: 15701
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedMessage_Internal_String_String_CultureInfo_Boolean_0;

		// Token: 0x04003D56 RID: 15702
		private static readonly IntPtr NativeMethodInfoPtr_GetSupportedCultures_Private_Static_List_1_CultureInfo_ResourceManager_0;

		// Token: 0x04003D57 RID: 15703
		private static readonly IntPtr NativeMethodInfoPtr_GetLevelName_Private_Static_String_EventLevel_0;

		// Token: 0x04003D58 RID: 15704
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskName_Private_String_EventTask_String_0;

		// Token: 0x04003D59 RID: 15705
		private static readonly IntPtr NativeMethodInfoPtr_GetOpcodeName_Private_String_EventOpcode_String_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly IntPtr NativeMethodInfoPtr_GetKeywords_Private_String_UInt64_String_0;

		// Token: 0x04003D5B RID: 15707
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Private_String_Type_0;

		// Token: 0x04003D5C RID: 15708
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStringBuilder_Private_Static_Void_byref_StringBuilder_String_Int32_Int32_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly IntPtr NativeMethodInfoPtr_TranslateToManifestConvention_Private_String_String_String_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly IntPtr NativeMethodInfoPtr_TranslateIndexToManifestConvention_Private_Int32_Int32_String_0;

		// Token: 0x02000686 RID: 1670
		[ObfuscatedName("System.Diagnostics.Tracing.ManifestBuilder+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x0600574E RID: 22350 RVA: 0x00180084 File Offset: 0x0017E284
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr);
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "stringBuilder");
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "eventMessage");
				ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, "writtenSoFar");
				ManifestBuilder.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr, 100674536);
			}

			// Token: 0x0600574F RID: 22351 RVA: 0x00180100 File Offset: 0x0017E300
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005750 RID: 22352 RVA: 0x00021D58 File Offset: 0x0001FF58
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001678 RID: 5752
			// (get) Token: 0x06005751 RID: 22353 RVA: 0x0018013C File Offset: 0x0017E33C
			// (set) Token: 0x06005752 RID: 22354 RVA: 0x00021D61 File Offset: 0x0001FF61
			public unsafe StringBuilder stringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001679 RID: 5753
			// (get) Token: 0x06005753 RID: 22355 RVA: 0x0018016C File Offset: 0x0017E36C
			// (set) Token: 0x06005754 RID: 22356 RVA: 0x00021D80 File Offset: 0x0001FF80
			public unsafe string eventMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_eventMessage), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700167A RID: 5754
			// (get) Token: 0x06005755 RID: 22357 RVA: 0x00180194 File Offset: 0x0017E394
			// (set) Token: 0x06005756 RID: 22358 RVA: 0x00021D9F File Offset: 0x0001FF9F
			public unsafe int writtenSoFar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_0.NativeFieldInfoPtr_writtenSoFar)) = value;
				}
			}

			// Token: 0x040045DF RID: 17887
			private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

			// Token: 0x040045E0 RID: 17888
			private static readonly IntPtr NativeFieldInfoPtr_eventMessage;

			// Token: 0x040045E1 RID: 17889
			private static readonly IntPtr NativeFieldInfoPtr_writtenSoFar;

			// Token: 0x040045E2 RID: 17890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000687 RID: 1671
		[ObfuscatedName("System.Diagnostics.Tracing.ManifestBuilder+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Object
		{
			// Token: 0x06005757 RID: 22359 RVA: 0x001801BC File Offset: 0x0017E3BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManifestBuilder>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr);
				ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, "i");
				ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, "CS$<>8__locals1");
				ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, 100674537);
				ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr, 100674538);
			}

			// Token: 0x06005758 RID: 22360 RVA: 0x00180238 File Offset: 0x0017E438
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManifestBuilder.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005759 RID: 22361 RVA: 0x00180274 File Offset: 0x0017E474
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373901, XrefRangeEnd = 373903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TranslateToManifestConvention_b__0(char ch, string escape)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(escape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManifestBuilder.__c__DisplayClass22_1.NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600575A RID: 22362 RVA: 0x00021DBA File Offset: 0x0001FFBA
			public __c__DisplayClass22_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700167B RID: 5755
			// (get) Token: 0x0600575B RID: 22363 RVA: 0x001802C4 File Offset: 0x0017E4C4
			// (set) Token: 0x0600575C RID: 22364 RVA: 0x00021DC3 File Offset: 0x0001FFC3
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700167C RID: 5756
			// (get) Token: 0x0600575D RID: 22365 RVA: 0x001802EC File Offset: 0x0017E4EC
			// (set) Token: 0x0600575E RID: 22366 RVA: 0x00021DDE File Offset: 0x0001FFDE
			public unsafe ManifestBuilder.__c__DisplayClass22_0 field_Public___c__DisplayClass22_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManifestBuilder.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManifestBuilder.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040045E3 RID: 17891
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040045E4 RID: 17892
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0;

			// Token: 0x040045E5 RID: 17893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040045E6 RID: 17894
			private static readonly IntPtr NativeMethodInfoPtr__TranslateToManifestConvention_b__0_Internal_Void_Char_String_0;
		}
	}
}
