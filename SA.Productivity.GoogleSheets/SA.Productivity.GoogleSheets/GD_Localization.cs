using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x0200000F RID: 15
	public class GD_Localization : Object
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x00005948 File Offset: 0x00003B48
		// Note: this type is marked as 'beforefieldinit'.
		static GD_Localization()
		{
			Il2CppClassPointerStore<GD_Localization>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_Localization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr);
			GD_Localization.NativeFieldInfoPtr_OnLanguageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, "OnLanguageChanged");
			GD_Localization.NativeFieldInfoPtr__Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, "_Client");
			GD_Localization.NativeMethodInfoPtr_add_OnLanguageChanged_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663396);
			GD_Localization.NativeMethodInfoPtr_remove_OnLanguageChanged_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663397);
			GD_Localization.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663398);
			GD_Localization.NativeMethodInfoPtr_SetLanguage_Public_Static_Void_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663399);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663400);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663401);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663402);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663403);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663404);
			GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663405);
			GD_Localization.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663406);
			GD_Localization.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663407);
			GD_Localization.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663408);
			GD_Localization.NativeMethodInfoPtr_get_DefaultLanguage_Public_Static_get_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663409);
			GD_Localization.NativeMethodInfoPtr_get_DefaultSection_Public_Static_get_GD_LangSection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663410);
			GD_Localization.NativeMethodInfoPtr_get_Client_Private_Static_get_GD_LocalizationClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663411);
			GD_Localization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005AF4 File Offset: 0x00003CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126444, RefRangeEnd = 126445, XrefRangeStart = 126433, XrefRangeEnd = 126444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLanguageChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_add_OnLanguageChanged_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005B2C File Offset: 0x00003D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126445, XrefRangeEnd = 126456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLanguageChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_remove_OnLanguageChanged_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00005B64 File Offset: 0x00003D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126460, RefRangeEnd = 126461, XrefRangeStart = 126456, XrefRangeEnd = 126460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005B8C File Offset: 0x00003D8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126485, RefRangeEnd = 126486, XrefRangeStart = 126461, XrefRangeEnd = 126485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLanguage(GD_LangCode lang)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_SetLanguage_Public_Static_Void_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005BC0 File Offset: 0x00003DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126494, RefRangeEnd = 126495, XrefRangeStart = 126486, XrefRangeEnd = 126494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005BFC File Offset: 0x00003DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126495, XrefRangeEnd = 126500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token, GD_TextType textType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005C48 File Offset: 0x00003E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126500, XrefRangeEnd = 126505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token, GD_LangSection section)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005C94 File Offset: 0x00003E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126505, XrefRangeEnd = 126510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token, GD_TextType textType, GD_LangSection section)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_GD_LangSection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00005CEC File Offset: 0x00003EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126510, XrefRangeEnd = 126516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token, GD_LangSection section, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005D58 File Offset: 0x00003F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126521, RefRangeEnd = 126522, XrefRangeStart = 126516, XrefRangeEnd = 126521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLocalizedString(string token, GD_LangSection section, GD_LangCode lang)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref section;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lang;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005DB0 File Offset: 0x00003FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126544, RefRangeEnd = 126545, XrefRangeStart = 126522, XrefRangeEnd = 126544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> GetFullSectionLocalization()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00005DE4 File Offset: 0x00003FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126545, XrefRangeEnd = 126563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, string> GetFullSectionLocalization(GD_LangSection section)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref section;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_GD_LangSection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005E24 File Offset: 0x00004024
		public unsafe static GD_LangCode CurrentLanguage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126567, RefRangeEnd = 126568, XrefRangeStart = 126563, XrefRangeEnd = 126567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005E54 File Offset: 0x00004054
		public unsafe static GD_LangCode DefaultLanguage
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_get_DefaultLanguage_Public_Static_get_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00005E84 File Offset: 0x00004084
		public unsafe static GD_LangSection DefaultSection
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_get_DefaultSection_Public_Static_get_GD_LangSection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005EB4 File Offset: 0x000040B4
		public unsafe static GD_LocalizationClient Client
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 126582, RefRangeEnd = 126595, XrefRangeStart = 126568, XrefRangeEnd = 126582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr_get_Client_Private_Static_get_GD_LocalizationClient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_LocalizationClient>(intPtr3) : null;
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005EE8 File Offset: 0x000040E8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_Localization()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000024E9 File Offset: 0x000006E9
		public static string GetLocalizedString(string token, GD_LangSection section, params Object[] args)
		{
			return GD_Localization.GetLocalizedString(token, section, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000024F8 File Offset: 0x000006F8
		public GD_Localization(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005F24 File Offset: 0x00004124
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002501 File Offset: 0x00000701
		public unsafe static Action OnLanguageChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Localization.NativeFieldInfoPtr_OnLanguageChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Localization.NativeFieldInfoPtr_OnLanguageChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005F4C File Offset: 0x0000414C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe static GD_LocalizationClient _Client
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_Localization.NativeFieldInfoPtr__Client, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_LocalizationClient>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_Localization.NativeFieldInfoPtr__Client, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_OnLanguageChanged;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr__Client;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLanguageChanged_Public_Static_add_Void_Action_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLanguageChanged_Public_Static_rem_Void_Action_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_SetLanguage_Public_Static_Void_GD_LangCode_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_TextType_GD_LangSection_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedString_Public_Static_String_String_GD_LangSection_GD_LangCode_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_GetFullSectionLocalization_Public_Static_Dictionary_2_String_String_GD_LangSection_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultLanguage_Public_Static_get_GD_LangCode_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultSection_Public_Static_get_GD_LangSection_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_get_Client_Private_Static_get_GD_LocalizationClient_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000023 RID: 35
		[ObfuscatedName("SA.Productivity.GoogleSheets.GD_Localization+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600013A RID: 314 RVA: 0x000070D4 File Offset: 0x000052D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GD_Localization>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr);
				GD_Localization.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr, "<>9");
				GD_Localization.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr, 100663445);
				GD_Localization.__c.NativeMethodInfoPtr___cctor_b__23_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr, 100663446);
			}

			// Token: 0x0600013B RID: 315 RVA: 0x0000713C File Offset: 0x0000533C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_Localization.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00007178 File Offset: 0x00005378
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__23_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_Localization.__c.NativeMethodInfoPtr___cctor_b__23_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600013D RID: 317 RVA: 0x000026D7 File Offset: 0x000008D7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600013E RID: 318 RVA: 0x000071AC File Offset: 0x000053AC
			// (set) Token: 0x0600013F RID: 319 RVA: 0x000026E0 File Offset: 0x000008E0
			public unsafe static GD_Localization.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GD_Localization.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GD_Localization.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GD_Localization.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F3 RID: 243
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__23_0_Internal_Void_0;
		}
	}
}
