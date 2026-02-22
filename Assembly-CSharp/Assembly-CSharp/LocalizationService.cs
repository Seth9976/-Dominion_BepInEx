using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

// Token: 0x02000004 RID: 4
public class LocalizationService : Object
{
	// Token: 0x0600000E RID: 14 RVA: 0x0001AEBC File Offset: 0x000190BC
	// Note: this type is marked as 'beforefieldinit'.
	static LocalizationService()
	{
		Il2CppClassPointerStore<LocalizationService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LocalizationService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr);
		LocalizationService.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "s_Instance");
		LocalizationService.NativeFieldInfoPtr_DefaultLocalizationLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "DefaultLocalizationLanguage");
		LocalizationService.NativeFieldInfoPtr_LocalizationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "LocalizationPath");
		LocalizationService.NativeFieldInfoPtr_OnChangeLocalization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "OnChangeLocalization");
		LocalizationService.NativeFieldInfoPtr_s_localizationLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "s_localizationLanguage");
		LocalizationService.NativeFieldInfoPtr_s_LocalizationLibrary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "s_LocalizationLibrary");
		LocalizationService.NativeFieldInfoPtr_m_StringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, "m_StringBuilder");
		LocalizationService.NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663302);
		LocalizationService.NativeMethodInfoPtr_get_LocalizationLanguage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663303);
		LocalizationService.NativeMethodInfoPtr_set_LocalizationLanguage_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663304);
		LocalizationService.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663305);
		LocalizationService.NativeMethodInfoPtr_ParseLocalizeFile_Private_Static_Void_Dictionary_2_String_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663306);
		LocalizationService.NativeMethodInfoPtr_GetTextByKey_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663307);
		LocalizationService.NativeMethodInfoPtr_GetLocalizationLanguage_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663308);
		LocalizationService.NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663309);
		LocalizationService.NativeMethodInfoPtr_LoadLocalizationTextFromGoogleSheet_Private_Void_Dictionary_2_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663310);
		LocalizationService.NativeMethodInfoPtr_LoadLocalizationTextFromFile_Private_Void_Dictionary_2_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663311);
		LocalizationService.NativeMethodInfoPtr_LoadLocalizeFileHelper_Public_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663312);
		LocalizationService.NativeMethodInfoPtr_LoadDefault_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663313);
		LocalizationService.NativeMethodInfoPtr_ConvertLocalizationKeys_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663314);
		LocalizationService.NativeMethodInfoPtr_AppendStringToStringBuilder_Private_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663315);
		LocalizationService.NativeMethodInfoPtr_ConvertLocalizationKeysWithStringBuilder_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663316);
		LocalizationService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr, 100663317);
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600000F RID: 15 RVA: 0x0001B0B8 File Offset: 0x000192B8
	public unsafe static LocalizationService Instance
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 223855, RefRangeEnd = 223871, XrefRangeStart = 223835, XrefRangeEnd = 223855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationService_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizationService>(intPtr3) : null;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000010 RID: 16 RVA: 0x0001B0EC File Offset: 0x000192EC
	// (set) Token: 0x06000011 RID: 17 RVA: 0x0001B124 File Offset: 0x00019324
	public unsafe string LocalizationLanguage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223871, XrefRangeEnd = 223875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_get_LocalizationLanguage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 223881, RefRangeEnd = 223884, XrefRangeStart = 223875, XrefRangeEnd = 223881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_set_LocalizationLanguage_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0001B168 File Offset: 0x00019368
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223884, XrefRangeEnd = 223887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0001B19C File Offset: 0x0001939C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 223908, RefRangeEnd = 223909, XrefRangeStart = 223887, XrefRangeEnd = 223908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseLocalizeFile(Dictionary<string, string> dictionary, Il2CppStructArray<byte> csv_bytes)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(csv_bytes);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_ParseLocalizeFile_Private_Static_Void_Dictionary_2_String_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0001B1E4 File Offset: 0x000193E4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 223915, RefRangeEnd = 223918, XrefRangeStart = 223909, XrefRangeEnd = 223915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTextByKey(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_GetTextByKey_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0001B22C File Offset: 0x0001942C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 223920, RefRangeEnd = 223922, XrefRangeStart = 223918, XrefRangeEnd = 223920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLocalizationLanguage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_GetLocalizationLanguage_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0001B264 File Offset: 0x00019464
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalizationLanguage(string localize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(localize);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0001B2A8 File Offset: 0x000194A8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 223970, RefRangeEnd = 223972, XrefRangeStart = 223922, XrefRangeEnd = 223970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLocalizationTextFromGoogleSheet(Dictionary<string, string> dictionary, string document_name, string sheet_name, string find_language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(document_name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sheet_name);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(find_language);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_LoadLocalizationTextFromGoogleSheet_Private_Void_Dictionary_2_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0001B324 File Offset: 0x00019524
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 223992, RefRangeEnd = 223994, XrefRangeStart = 223972, XrefRangeEnd = 223992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLocalizationTextFromFile(Dictionary<string, string> dictionary, string filepath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filepath);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_LoadLocalizationTextFromFile_Private_Void_Dictionary_2_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0001B378 File Offset: 0x00019578
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224047, RefRangeEnd = 224048, XrefRangeStart = 223994, XrefRangeEnd = 224047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, string> LoadLocalizeFileHelper()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_LoadLocalizeFileHelper_Public_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0001B3B8 File Offset: 0x000195B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224048, XrefRangeEnd = 224051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadDefault()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_LoadDefault_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0001B3EC File Offset: 0x000195EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224051, XrefRangeEnd = 224062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ConvertLocalizationKeys(string input_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_ConvertLocalizationKeys_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0001B434 File Offset: 0x00019634
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224074, RefRangeEnd = 224076, XrefRangeStart = 224062, XrefRangeEnd = 224074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppendStringToStringBuilder(StringBuilder builder, string append_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(append_text);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_AppendStringToStringBuilder_Private_Void_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0001B488 File Offset: 0x00019688
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 224080, RefRangeEnd = 224090, XrefRangeStart = 224076, XrefRangeEnd = 224080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ConvertLocalizationKeysWithStringBuilder(string input_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr_ConvertLocalizationKeysWithStringBuilder_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0001B4D0 File Offset: 0x000196D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224090, XrefRangeEnd = 224095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalizationService()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationService>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000209C File Offset: 0x0000029C
	public LocalizationService(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000020 RID: 32 RVA: 0x0001B50C File Offset: 0x0001970C
	// (set) Token: 0x06000021 RID: 33 RVA: 0x000020A5 File Offset: 0x000002A5
	public unsafe static LocalizationService s_Instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LocalizationService.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationService>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalizationService.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000022 RID: 34 RVA: 0x0001B534 File Offset: 0x00019734
	// (set) Token: 0x06000023 RID: 35 RVA: 0x000020B7 File Offset: 0x000002B7
	public unsafe static string DefaultLocalizationLanguage
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LocalizationService.NativeFieldInfoPtr_DefaultLocalizationLanguage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalizationService.NativeFieldInfoPtr_DefaultLocalizationLanguage, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000024 RID: 36 RVA: 0x0001B554 File Offset: 0x00019754
	// (set) Token: 0x06000025 RID: 37 RVA: 0x000020C9 File Offset: 0x000002C9
	public unsafe static string LocalizationPath
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LocalizationService.NativeFieldInfoPtr_LocalizationPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalizationService.NativeFieldInfoPtr_LocalizationPath, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000026 RID: 38 RVA: 0x0001B574 File Offset: 0x00019774
	// (set) Token: 0x06000027 RID: 39 RVA: 0x000020DB File Offset: 0x000002DB
	public unsafe Action OnChangeLocalization
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_OnChangeLocalization);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_OnChangeLocalization), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000028 RID: 40 RVA: 0x0001B5A4 File Offset: 0x000197A4
	// (set) Token: 0x06000029 RID: 41 RVA: 0x000020FA File Offset: 0x000002FA
	public unsafe static string s_localizationLanguage
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(LocalizationService.NativeFieldInfoPtr_s_localizationLanguage, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalizationService.NativeFieldInfoPtr_s_localizationLanguage, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600002A RID: 42 RVA: 0x0001B5C4 File Offset: 0x000197C4
	// (set) Token: 0x0600002B RID: 43 RVA: 0x0000210C File Offset: 0x0000030C
	public unsafe Dictionary<string, string> s_LocalizationLibrary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_s_LocalizationLibrary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_s_LocalizationLibrary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002C RID: 44 RVA: 0x0001B5F4 File Offset: 0x000197F4
	// (set) Token: 0x0600002D RID: 45 RVA: 0x0000212B File Offset: 0x0000032B
	public unsafe StringBuilder m_StringBuilder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_m_StringBuilder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationService.NativeFieldInfoPtr_m_StringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_DefaultLocalizationLanguage;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_LocalizationPath;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_OnChangeLocalization;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr_s_localizationLanguage;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr_s_LocalizationLibrary;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeFieldInfoPtr_m_StringBuilder;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_LocalizationService_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_get_LocalizationLanguage_Public_get_String_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_set_LocalizationLanguage_Public_set_Void_String_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_ParseLocalizeFile_Private_Static_Void_Dictionary_2_String_String_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_GetTextByKey_Public_String_String_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalizationLanguage_Public_String_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocalizationTextFromGoogleSheet_Private_Void_Dictionary_2_String_String_String_String_String_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocalizationTextFromFile_Private_Void_Dictionary_2_String_String_String_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocalizeFileHelper_Public_Dictionary_2_String_String_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_LoadDefault_Private_Void_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_ConvertLocalizationKeys_Public_String_String_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr_AppendStringToStringBuilder_Private_Void_StringBuilder_String_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_ConvertLocalizationKeysWithStringBuilder_Public_String_String_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
