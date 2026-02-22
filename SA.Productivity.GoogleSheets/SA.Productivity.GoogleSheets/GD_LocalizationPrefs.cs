using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000011 RID: 17
	public class GD_LocalizationPrefs : Object
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00006444 File Offset: 0x00004644
		// Note: this type is marked as 'beforefieldinit'.
		static GD_LocalizationPrefs()
		{
			Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_LocalizationPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr);
			GD_LocalizationPrefs.NativeFieldInfoPtr_PREFS_LANG_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr, "PREFS_LANG_KEY");
			GD_LocalizationPrefs.NativeMethodInfoPtr_SaveLocalizationChose_Public_Static_Void_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr, 100663425);
			GD_LocalizationPrefs.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr, 100663426);
			GD_LocalizationPrefs.NativeMethodInfoPtr_get_HasSavedLocalization_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr, 100663427);
			GD_LocalizationPrefs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr, 100663428);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000064D8 File Offset: 0x000046D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126912, XrefRangeEnd = 126915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveLocalizationChose(GD_LangCode lang)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lang;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationPrefs.NativeMethodInfoPtr_SaveLocalizationChose_Public_Static_Void_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000650C File Offset: 0x0000470C
		public unsafe static GD_LangCode CurrentLanguage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126915, XrefRangeEnd = 126922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationPrefs.NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000653C File Offset: 0x0000473C
		public unsafe static bool HasSavedLocalization
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126922, XrefRangeEnd = 126925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationPrefs.NativeMethodInfoPtr_get_HasSavedLocalization_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000656C File Offset: 0x0000476C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GD_LocalizationPrefs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_LocalizationPrefs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_LocalizationPrefs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002568 File Offset: 0x00000768
		public GD_LocalizationPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000065A8 File Offset: 0x000047A8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002571 File Offset: 0x00000771
		public unsafe static string PREFS_LANG_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_LocalizationPrefs.NativeFieldInfoPtr_PREFS_LANG_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_LocalizationPrefs.NativeFieldInfoPtr_PREFS_LANG_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_PREFS_LANG_KEY;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_SaveLocalizationChose_Public_Static_Void_GD_LangCode_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLanguage_Public_Static_get_GD_LangCode_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSavedLocalization_Private_Static_get_Boolean_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
