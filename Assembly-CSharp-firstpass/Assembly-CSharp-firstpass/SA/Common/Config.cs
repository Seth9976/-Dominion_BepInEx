using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Common
{
	// Token: 0x0200030D RID: 781
	public class Config : Object
	{
		// Token: 0x06002CED RID: 11501 RVA: 0x000C0478 File Offset: 0x000BE678
		// Note: this type is marked as 'beforefieldinit'.
		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common", "Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
			Config.NativeFieldInfoPtr_LIB_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "LIB_VERSION");
			Config.NativeFieldInfoPtr_VERSION_UNDEFINED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "VERSION_UNDEFINED");
			Config.NativeFieldInfoPtr_VERSION_UNDEFINED_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "VERSION_UNDEFINED_STRING");
			Config.NativeFieldInfoPtr_SUPPORT_EMAIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "SUPPORT_EMAIL");
			Config.NativeFieldInfoPtr_WEBSITE_ROOT_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "WEBSITE_ROOT_URL");
			Config.NativeFieldInfoPtr_BUNDLES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "BUNDLES_PATH");
			Config.NativeFieldInfoPtr_MODULS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "MODULS_PATH");
			Config.NativeFieldInfoPtr_SUPPORT_MODULS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "SUPPORT_MODULS_PATH");
			Config.NativeFieldInfoPtr_COMMON_LIB_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "COMMON_LIB_PATH");
			Config.NativeFieldInfoPtr_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_NATIVE_LIBRARIES_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "NATIVE_LIBRARIES_PATH");
			Config.NativeFieldInfoPtr_EDITOR_TESTING_LIB_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "EDITOR_TESTING_LIB_PATH");
			Config.NativeFieldInfoPtr_SETTINGS_REMOVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "SETTINGS_REMOVE_PATH");
			Config.NativeFieldInfoPtr_SETTINGS_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "SETTINGS_PATH");
			Config.NativeFieldInfoPtr_ANDROID_DESTANATION_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ANDROID_DESTANATION_PATH");
			Config.NativeFieldInfoPtr_ANDROID_SOURCE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ANDROID_SOURCE_PATH");
			Config.NativeFieldInfoPtr_IOS_DESTANATION_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "IOS_DESTANATION_PATH");
			Config.NativeFieldInfoPtr_IOS_SOURCE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "IOS_SOURCE_PATH");
			Config.NativeFieldInfoPtr_SPOTIFY_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "SPOTIFY_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_AN_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "AN_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_UM_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "UM_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_GMA_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "GMA_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_MSP_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "MSP_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_ISN_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "ISN_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_MNP_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "MNP_VERSION_INFO_PATH");
			Config.NativeFieldInfoPtr_AMN_VERSION_INFO_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "AMN_VERSION_INFO_PATH");
			Config.NativeMethodInfoPtr_get_FB_SDK_VersionCode_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100669186);
			Config.NativeMethodInfoPtr_get_FB_SDK_MajorVersionCode_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100669187);
			Config.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Config>.NativeClassPtr, 100669188);
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000C06EC File Offset: 0x000BE8EC
		public unsafe static string FB_SDK_VersionCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 211586, RefRangeEnd = 211587, XrefRangeStart = 211529, XrefRangeEnd = 211586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_FB_SDK_VersionCode_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000C0718 File Offset: 0x000BE918
		public unsafe static int FB_SDK_MajorVersionCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211587, XrefRangeEnd = 211607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr_get_FB_SDK_MajorVersionCode_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000C0748 File Offset: 0x000BE948
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Config()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Config.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0001170A File Offset: 0x0000F90A
		public Config(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x000C0784 File Offset: 0x000BE984
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x00011713 File Offset: 0x0000F913
		public unsafe static string LIB_VERSION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_LIB_VERSION, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_LIB_VERSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000C07A4 File Offset: 0x000BE9A4
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x00011725 File Offset: 0x0000F925
		public unsafe static int VERSION_UNDEFINED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_VERSION_UNDEFINED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_VERSION_UNDEFINED, (void*)(&value));
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002CF6 RID: 11510 RVA: 0x000C07C0 File Offset: 0x000BE9C0
		// (set) Token: 0x06002CF7 RID: 11511 RVA: 0x00011733 File Offset: 0x0000F933
		public unsafe static string VERSION_UNDEFINED_STRING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_VERSION_UNDEFINED_STRING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_VERSION_UNDEFINED_STRING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000C07E0 File Offset: 0x000BE9E0
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x00011745 File Offset: 0x0000F945
		public unsafe static string SUPPORT_EMAIL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_SUPPORT_EMAIL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_SUPPORT_EMAIL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000C0800 File Offset: 0x000BEA00
		// (set) Token: 0x06002CFB RID: 11515 RVA: 0x00011757 File Offset: 0x0000F957
		public unsafe static string WEBSITE_ROOT_URL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_WEBSITE_ROOT_URL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_WEBSITE_ROOT_URL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002CFC RID: 11516 RVA: 0x000C0820 File Offset: 0x000BEA20
		// (set) Token: 0x06002CFD RID: 11517 RVA: 0x00011769 File Offset: 0x0000F969
		public unsafe static string BUNDLES_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_BUNDLES_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_BUNDLES_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x000C0840 File Offset: 0x000BEA40
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x0001177B File Offset: 0x0000F97B
		public unsafe static string MODULS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_MODULS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_MODULS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000C0860 File Offset: 0x000BEA60
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x0001178D File Offset: 0x0000F98D
		public unsafe static string SUPPORT_MODULS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_SUPPORT_MODULS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_SUPPORT_MODULS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000C0880 File Offset: 0x000BEA80
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x0001179F File Offset: 0x0000F99F
		public unsafe static string COMMON_LIB_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_COMMON_LIB_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_COMMON_LIB_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000C08A0 File Offset: 0x000BEAA0
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000117B1 File Offset: 0x0000F9B1
		public unsafe static string VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000C08C0 File Offset: 0x000BEAC0
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000117C3 File Offset: 0x0000F9C3
		public unsafe static string NATIVE_LIBRARIES_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_NATIVE_LIBRARIES_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_NATIVE_LIBRARIES_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000C08E0 File Offset: 0x000BEAE0
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x000117D5 File Offset: 0x0000F9D5
		public unsafe static string EDITOR_TESTING_LIB_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_EDITOR_TESTING_LIB_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_EDITOR_TESTING_LIB_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000C0900 File Offset: 0x000BEB00
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x000117E7 File Offset: 0x0000F9E7
		public unsafe static string SETTINGS_REMOVE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_SETTINGS_REMOVE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_SETTINGS_REMOVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000C0920 File Offset: 0x000BEB20
		// (set) Token: 0x06002D0D RID: 11533 RVA: 0x000117F9 File Offset: 0x0000F9F9
		public unsafe static string SETTINGS_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_SETTINGS_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_SETTINGS_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000C0940 File Offset: 0x000BEB40
		// (set) Token: 0x06002D0F RID: 11535 RVA: 0x0001180B File Offset: 0x0000FA0B
		public unsafe static string ANDROID_DESTANATION_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ANDROID_DESTANATION_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ANDROID_DESTANATION_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000C0960 File Offset: 0x000BEB60
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x0001181D File Offset: 0x0000FA1D
		public unsafe static string ANDROID_SOURCE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ANDROID_SOURCE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ANDROID_SOURCE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000C0980 File Offset: 0x000BEB80
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x0001182F File Offset: 0x0000FA2F
		public unsafe static string IOS_DESTANATION_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_IOS_DESTANATION_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_IOS_DESTANATION_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000C09A0 File Offset: 0x000BEBA0
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00011841 File Offset: 0x0000FA41
		public unsafe static string IOS_SOURCE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_IOS_SOURCE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_IOS_SOURCE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000C09C0 File Offset: 0x000BEBC0
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00011853 File Offset: 0x0000FA53
		public unsafe static string SPOTIFY_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_SPOTIFY_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_SPOTIFY_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x000C09E0 File Offset: 0x000BEBE0
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x00011865 File Offset: 0x0000FA65
		public unsafe static string AN_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_AN_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_AN_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000C0A00 File Offset: 0x000BEC00
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00011877 File Offset: 0x0000FA77
		public unsafe static string UM_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_UM_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_UM_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x000C0A20 File Offset: 0x000BEC20
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x00011889 File Offset: 0x0000FA89
		public unsafe static string GMA_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_GMA_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_GMA_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x000C0A40 File Offset: 0x000BEC40
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x0001189B File Offset: 0x0000FA9B
		public unsafe static string MSP_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_MSP_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_MSP_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000C0A60 File Offset: 0x000BEC60
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x000118AD File Offset: 0x0000FAAD
		public unsafe static string ISN_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_ISN_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_ISN_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x000C0A80 File Offset: 0x000BEC80
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x000118BF File Offset: 0x0000FABF
		public unsafe static string MNP_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_MNP_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_MNP_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x000C0AA0 File Offset: 0x000BECA0
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x000118D1 File Offset: 0x0000FAD1
		public unsafe static string AMN_VERSION_INFO_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Config.NativeFieldInfoPtr_AMN_VERSION_INFO_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Config.NativeFieldInfoPtr_AMN_VERSION_INFO_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeFieldInfoPtr_LIB_VERSION;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeFieldInfoPtr_VERSION_UNDEFINED;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeFieldInfoPtr_VERSION_UNDEFINED_STRING;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeFieldInfoPtr_SUPPORT_EMAIL;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeFieldInfoPtr_WEBSITE_ROOT_URL;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeFieldInfoPtr_BUNDLES_PATH;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeFieldInfoPtr_MODULS_PATH;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeFieldInfoPtr_SUPPORT_MODULS_PATH;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeFieldInfoPtr_COMMON_LIB_PATH;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeFieldInfoPtr_VERSION_INFO_PATH;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeFieldInfoPtr_NATIVE_LIBRARIES_PATH;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeFieldInfoPtr_EDITOR_TESTING_LIB_PATH;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeFieldInfoPtr_SETTINGS_REMOVE_PATH;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeFieldInfoPtr_SETTINGS_PATH;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeFieldInfoPtr_ANDROID_DESTANATION_PATH;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeFieldInfoPtr_ANDROID_SOURCE_PATH;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeFieldInfoPtr_IOS_DESTANATION_PATH;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeFieldInfoPtr_IOS_SOURCE_PATH;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeFieldInfoPtr_SPOTIFY_VERSION_INFO_PATH;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeFieldInfoPtr_AN_VERSION_INFO_PATH;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeFieldInfoPtr_UM_VERSION_INFO_PATH;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeFieldInfoPtr_GMA_VERSION_INFO_PATH;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeFieldInfoPtr_MSP_VERSION_INFO_PATH;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeFieldInfoPtr_ISN_VERSION_INFO_PATH;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeFieldInfoPtr_MNP_VERSION_INFO_PATH;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeFieldInfoPtr_AMN_VERSION_INFO_PATH;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_get_FB_SDK_VersionCode_Public_Static_get_String_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_get_FB_SDK_MajorVersionCode_Public_Static_get_Int32_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
