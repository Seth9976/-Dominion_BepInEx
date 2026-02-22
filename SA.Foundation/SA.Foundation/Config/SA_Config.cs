using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Config
{
	// Token: 0x0200003E RID: 62
	public class SA_Config : Object
	{
		// Token: 0x06000332 RID: 818 RVA: 0x00011510 File Offset: 0x0000F710
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Config()
		{
			Il2CppClassPointerStore<SA_Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Config", "SA_Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Config>.NativeClassPtr);
			SA_Config.NativeFieldInfoPtr_k_StansAssetsSupportEmail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "k_StansAssetsSupportEmail");
			SA_Config.NativeFieldInfoPtr_k_StansAssetsCeoEMail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "k_StansAssetsCeoEMail");
			SA_Config.NativeFieldInfoPtr_k_StansAssetsWebsiteRootUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "k_StansAssetsWebsiteRootUrl");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_THIRD_PARTY_NOTICES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_THIRD_PARTY_NOTICES");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_NATIVE_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_NATIVE_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SERVICES_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_SERVICES_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_API_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_API_MODULES_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_ROOT_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_SETTINGS_ROOT_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CACHE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_CACHE_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_SETTINGS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_SETTINGS_PATH");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH");
			SA_Config.NativeFieldInfoPtr_UNITY_IOS_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "UNITY_IOS_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_UNITY_ANDROID_PLUGINS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "UNITY_ANDROID_PLUGINS_PATH");
			SA_Config.NativeFieldInfoPtr_EDITOR_MENU_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "EDITOR_MENU_ROOT");
			SA_Config.NativeFieldInfoPtr_k_EditorFoundationLibMenuRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "k_EditorFoundationLibMenuRoot");
			SA_Config.NativeFieldInfoPtr_EDITOR_ANALYTICS_MENU_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "EDITOR_ANALYTICS_MENU_ROOT");
			SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_MENU_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "EDITOR_PRODUCTIVITY_MENU_ROOT");
			SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT");
			SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_MENU_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "PRODUCTIVITY_MENU_INDEX");
			SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX");
			SA_Config.NativeFieldInfoPtr_k_FoundationMenuIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "k_FoundationMenuIndex");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ART = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_ART");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ICONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_ICONS");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_FONTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_FONTS");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_CONTENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_CONTENT");
			SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_GRAPHIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "STANS_ASSETS_EDITOR_GRAPHIC");
			SA_Config.NativeFieldInfoPtr_s_foundationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, "s_foundationVersion");
			SA_Config.NativeMethodInfoPtr_get_FoundationVersion_Public_Static_get_PluginVersionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, 100663838);
			SA_Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Config>.NativeClassPtr, 100663839);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00011838 File Offset: 0x0000FA38
		public unsafe static PluginVersionHandler FoundationVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107573, XrefRangeEnd = 107586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Config.NativeMethodInfoPtr_get_FoundationVersion_Public_Static_get_PluginVersionHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluginVersionHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001186C File Offset: 0x0000FA6C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Config>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002C1D File Offset: 0x00000E1D
		public SA_Config(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000336 RID: 822 RVA: 0x000118A8 File Offset: 0x0000FAA8
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00002C26 File Offset: 0x00000E26
		public unsafe static string k_StansAssetsSupportEmail
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsSupportEmail, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsSupportEmail, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000118C8 File Offset: 0x0000FAC8
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002C38 File Offset: 0x00000E38
		public unsafe static string k_StansAssetsCeoEMail
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsCeoEMail, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsCeoEMail, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000118E8 File Offset: 0x0000FAE8
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002C4A File Offset: 0x00000E4A
		public unsafe static string k_StansAssetsWebsiteRootUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsWebsiteRootUrl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_k_StansAssetsWebsiteRootUrl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00011908 File Offset: 0x0000FB08
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002C5C File Offset: 0x00000E5C
		public unsafe static string STANS_ASSETS_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00011928 File Offset: 0x0000FB28
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00002C6E File Offset: 0x00000E6E
		public unsafe static string STANS_ASSETS_THIRD_PARTY_NOTICES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_THIRD_PARTY_NOTICES, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_THIRD_PARTY_NOTICES, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00011948 File Offset: 0x0000FB48
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00002C80 File Offset: 0x00000E80
		public unsafe static string STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00011968 File Offset: 0x0000FB68
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00002C92 File Offset: 0x00000E92
		public unsafe static string STANS_ASSETS_NATIVE_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_NATIVE_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_NATIVE_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00011988 File Offset: 0x0000FB88
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public unsafe static string STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000119A8 File Offset: 0x0000FBA8
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00002CB6 File Offset: 0x00000EB6
		public unsafe static string STANS_ASSETS_SERVICES_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SERVICES_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SERVICES_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000119C8 File Offset: 0x0000FBC8
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public unsafe static string STANS_ASSETS_FOUNDATION_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000119E8 File Offset: 0x0000FBE8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00002CDA File Offset: 0x00000EDA
		public unsafe static string STANS_ASSETS_FOUNDATION_API_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00011A08 File Offset: 0x0000FC08
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00002CEC File Offset: 0x00000EEC
		public unsafe static string STANS_ASSETS_FOUNDATION_API_MODULES_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00011A28 File Offset: 0x0000FC28
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00002CFE File Offset: 0x00000EFE
		public unsafe static string STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00011A48 File Offset: 0x0000FC48
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00002D10 File Offset: 0x00000F10
		public unsafe static string STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00011A68 File Offset: 0x0000FC68
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00002D22 File Offset: 0x00000F22
		public unsafe static string STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00011A88 File Offset: 0x0000FC88
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00002D34 File Offset: 0x00000F34
		public unsafe static string STANS_ASSETS_SETTINGS_ROOT_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_ROOT_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_ROOT_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00002D46 File Offset: 0x00000F46
		public unsafe static string STANS_ASSETS_CACHE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CACHE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_CACHE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002D58 File Offset: 0x00000F58
		public unsafe static string STANS_ASSETS_SETTINGS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00002D6A File Offset: 0x00000F6A
		public unsafe static string STANS_ASSETS_EDITOR_SETTINGS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00011B08 File Offset: 0x0000FD08
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00002D7C File Offset: 0x00000F7C
		public unsafe static string STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00011B28 File Offset: 0x0000FD28
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00002D8E File Offset: 0x00000F8E
		public unsafe static string UNITY_IOS_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_UNITY_IOS_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_UNITY_IOS_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00011B48 File Offset: 0x0000FD48
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00002DA0 File Offset: 0x00000FA0
		public unsafe static string UNITY_ANDROID_PLUGINS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_UNITY_ANDROID_PLUGINS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_UNITY_ANDROID_PLUGINS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00011B68 File Offset: 0x0000FD68
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002DB2 File Offset: 0x00000FB2
		public unsafe static string EDITOR_MENU_ROOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_EDITOR_MENU_ROOT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_EDITOR_MENU_ROOT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00011B88 File Offset: 0x0000FD88
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002DC4 File Offset: 0x00000FC4
		public unsafe static string k_EditorFoundationLibMenuRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_k_EditorFoundationLibMenuRoot, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_k_EditorFoundationLibMenuRoot, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002DD6 File Offset: 0x00000FD6
		public unsafe static string EDITOR_ANALYTICS_MENU_ROOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_EDITOR_ANALYTICS_MENU_ROOT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_EDITOR_ANALYTICS_MENU_ROOT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00002DE8 File Offset: 0x00000FE8
		public unsafe static string EDITOR_PRODUCTIVITY_MENU_ROOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_MENU_ROOT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_MENU_ROOT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00011BE8 File Offset: 0x0000FDE8
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00002DFA File Offset: 0x00000FFA
		public unsafe static string EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00011C08 File Offset: 0x0000FE08
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00002E0C File Offset: 0x0000100C
		public unsafe static int PRODUCTIVITY_MENU_INDEX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_MENU_INDEX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_MENU_INDEX, (void*)(&value));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00011C24 File Offset: 0x0000FE24
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00002E1A File Offset: 0x0000101A
		public unsafe static int PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX, (void*)(&value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00011C40 File Offset: 0x0000FE40
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00002E28 File Offset: 0x00001028
		public unsafe static int k_FoundationMenuIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_k_FoundationMenuIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_k_FoundationMenuIndex, (void*)(&value));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00011C5C File Offset: 0x0000FE5C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00002E36 File Offset: 0x00001036
		public unsafe static string STANS_ASSETS_EDITOR_ART
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ART, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ART, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00011C7C File Offset: 0x0000FE7C
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00002E48 File Offset: 0x00001048
		public unsafe static string STANS_ASSETS_EDITOR_ICONS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ICONS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ICONS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00011C9C File Offset: 0x0000FE9C
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00002E5A File Offset: 0x0000105A
		public unsafe static string STANS_ASSETS_EDITOR_FONTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_FONTS, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_FONTS, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00011CBC File Offset: 0x0000FEBC
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00002E6C File Offset: 0x0000106C
		public unsafe static string STANS_ASSETS_EDITOR_CONTENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_CONTENT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_CONTENT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00011CDC File Offset: 0x0000FEDC
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00002E7E File Offset: 0x0000107E
		public unsafe static string STANS_ASSETS_EDITOR_GRAPHIC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_GRAPHIC, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_STANS_ASSETS_EDITOR_GRAPHIC, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00011CFC File Offset: 0x0000FEFC
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00002E90 File Offset: 0x00001090
		public unsafe static PluginVersionHandler s_foundationVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Config.NativeFieldInfoPtr_s_foundationVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluginVersionHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Config.NativeFieldInfoPtr_s_foundationVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_k_StansAssetsSupportEmail;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_k_StansAssetsCeoEMail;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_k_StansAssetsWebsiteRootUrl;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_PLUGINS_PATH;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_THIRD_PARTY_NOTICES;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_CROSS_PLATFORM_PLUGINS_PATH;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_NATIVE_PLUGINS_PATH;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_PRODUCTIVITY_PLUGINS_PATH;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_SERVICES_PLUGINS_PATH;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_PATH;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_PATH;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PUBLIC;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_PRIVATE;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_FOUNDATION_API_MODULES_PATH_THIRD_PARTY;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_ROOT_PATH;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_CACHE_PATH;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_SETTINGS_PATH;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_PATH;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_SETTINGS_RESOURCES_PATH;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_UNITY_IOS_PLUGINS_PATH;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_UNITY_ANDROID_PLUGINS_PATH;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_EDITOR_MENU_ROOT;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_k_EditorFoundationLibMenuRoot;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_EDITOR_ANALYTICS_MENU_ROOT;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_MENU_ROOT;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_EDITOR_PRODUCTIVITY_NATIVE_UTILITY_MENU_ROOT;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCTIVITY_MENU_INDEX;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCTIVITY_NATIVE_UTILITY_MENU_INDEX;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_k_FoundationMenuIndex;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ART;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_ICONS;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_FONTS;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_CONTENT;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_STANS_ASSETS_EDITOR_GRAPHIC;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_s_foundationVersion;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_FoundationVersion_Public_Static_get_PluginVersionHandler_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
