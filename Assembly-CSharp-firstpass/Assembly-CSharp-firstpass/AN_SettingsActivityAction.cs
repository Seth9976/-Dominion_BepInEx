using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000D5 RID: 213
public class AN_SettingsActivityAction : Object
{
	// Token: 0x06000EAA RID: 3754 RVA: 0x0004B570 File Offset: 0x00049770
	// Note: this type is marked as 'beforefieldinit'.
	static AN_SettingsActivityAction()
	{
		Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_SettingsActivityAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr);
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APN_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APN_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCATION_SOURCE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_LOCATION_SOURCE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIRELESS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_WIRELESS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_AIRPLANE_MODE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_AIRPLANE_MODE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ACCESSIBILITY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_ACCESSIBILITY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USAGE_ACCESS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_USAGE_ACCESS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SECURITY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SECURITY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_TRUSTED_CREDENTIALS_USER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_TRUSTED_CREDENTIALS_USER");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MONITORING_CERT_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_MONITORING_CERT_INFO");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRIVACY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_PRIVACY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_WIFI_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_IP_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_WIFI_IP_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BLUETOOTH_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_BLUETOOTH_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_DISPLAY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_WIFI_DISPLAY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAST_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_CAST_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_DATE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SOUND_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SOUND_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DISPLAY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_DISPLAY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCALE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_LOCALE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_VOICE_INPUT_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_VOICE_INPUT_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_INPUT_METHOD_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SUBTYPE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_INPUT_METHOD_SUBTYPE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_INPUT_METHOD_PICKER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SHOW_INPUT_METHOD_PICKER");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_USER_DICTIONARY_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_INSERT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_USER_DICTIONARY_INSERT");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APPLICATION_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DEVELOPMENT_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APPLICATION_DEVELOPMENT_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_QUICK_LAUNCH_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_QUICK_LAUNCH_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_APPLICATIONS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_MANAGE_APPLICATIONS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DETAILS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APPLICATION_DETAILS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_OPS_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APP_OPS_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYSTEM_UPDATE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SYSTEM_UPDATE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYNC_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SYNC_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ADD_ACCOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_ADD_ACCOUNT");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NETWORK_OPERATOR_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NETWORK_OPERATOR_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATA_ROAMING_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_DATA_ROAMING_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INTERNAL_STORAGE_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_INTERNAL_STORAGE_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MEMORY_CARD_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_MEMORY_CARD_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SEARCH_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SEARCH_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DEVICE_INFO_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_DEVICE_INFO_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NFC_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFCSHARING_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NFCSHARING_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_PAYMENT_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NFC_PAYMENT_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DREAM_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_DREAM_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_LISTENER_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NOTIFICATION_LISTENER_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAPTIONING_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_CAPTIONING_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRINT_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_PRINT_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_REGULATORY_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_SHOW_REGULATORY_INFO");
		AN_SettingsActivityAction.NativeFieldInfoPtr_DEVICE_NAME_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "DEVICE_NAME_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PAIRING_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_PAIRING_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BATTERY_SAVER_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_BATTERY_SAVER_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_HOME_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_HOME_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_NOTIFICATION_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_SETTINGS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APP_NOTIFICATION_SETTINGS");
		AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_REDACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, "ACTION_APP_NOTIFICATION_REDACTION");
		AN_SettingsActivityAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr, 100665150);
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0004BA28 File Offset: 0x00049C28
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_SettingsActivityAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_SettingsActivityAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SettingsActivityAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00007843 File Offset: 0x00005A43
	public AN_SettingsActivityAction(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000445 RID: 1093
	// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0004BA64 File Offset: 0x00049C64
	// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0000784C File Offset: 0x00005A4C
	public unsafe static string ACTION_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000446 RID: 1094
	// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0004BA84 File Offset: 0x00049C84
	// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0000785E File Offset: 0x00005A5E
	public unsafe static string ACTION_APN_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APN_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APN_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000447 RID: 1095
	// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0004BAA4 File Offset: 0x00049CA4
	// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x00007870 File Offset: 0x00005A70
	public unsafe static string ACTION_LOCATION_SOURCE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCATION_SOURCE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCATION_SOURCE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000448 RID: 1096
	// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0004BAC4 File Offset: 0x00049CC4
	// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00007882 File Offset: 0x00005A82
	public unsafe static string ACTION_WIRELESS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIRELESS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIRELESS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000449 RID: 1097
	// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0004BAE4 File Offset: 0x00049CE4
	// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00007894 File Offset: 0x00005A94
	public unsafe static string ACTION_AIRPLANE_MODE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_AIRPLANE_MODE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_AIRPLANE_MODE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044A RID: 1098
	// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0004BB04 File Offset: 0x00049D04
	// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x000078A6 File Offset: 0x00005AA6
	public unsafe static string ACTION_ACCESSIBILITY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ACCESSIBILITY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ACCESSIBILITY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044B RID: 1099
	// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0004BB24 File Offset: 0x00049D24
	// (set) Token: 0x06000EBA RID: 3770 RVA: 0x000078B8 File Offset: 0x00005AB8
	public unsafe static string ACTION_USAGE_ACCESS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USAGE_ACCESS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USAGE_ACCESS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044C RID: 1100
	// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0004BB44 File Offset: 0x00049D44
	// (set) Token: 0x06000EBC RID: 3772 RVA: 0x000078CA File Offset: 0x00005ACA
	public unsafe static string ACTION_SECURITY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SECURITY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SECURITY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044D RID: 1101
	// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0004BB64 File Offset: 0x00049D64
	// (set) Token: 0x06000EBE RID: 3774 RVA: 0x000078DC File Offset: 0x00005ADC
	public unsafe static string ACTION_TRUSTED_CREDENTIALS_USER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_TRUSTED_CREDENTIALS_USER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_TRUSTED_CREDENTIALS_USER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0004BB84 File Offset: 0x00049D84
	// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x000078EE File Offset: 0x00005AEE
	public unsafe static string ACTION_MONITORING_CERT_INFO
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MONITORING_CERT_INFO, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MONITORING_CERT_INFO, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0004BBA4 File Offset: 0x00049DA4
	// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00007900 File Offset: 0x00005B00
	public unsafe static string ACTION_PRIVACY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRIVACY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRIVACY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0004BBC4 File Offset: 0x00049DC4
	// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x00007912 File Offset: 0x00005B12
	public unsafe static string ACTION_WIFI_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0004BBE4 File Offset: 0x00049DE4
	// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x00007924 File Offset: 0x00005B24
	public unsafe static string ACTION_WIFI_IP_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_IP_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_IP_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0004BC04 File Offset: 0x00049E04
	// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00007936 File Offset: 0x00005B36
	public unsafe static string ACTION_BLUETOOTH_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BLUETOOTH_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BLUETOOTH_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0004BC24 File Offset: 0x00049E24
	// (set) Token: 0x06000ECA RID: 3786 RVA: 0x00007948 File Offset: 0x00005B48
	public unsafe static string ACTION_WIFI_DISPLAY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_DISPLAY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_WIFI_DISPLAY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0004BC44 File Offset: 0x00049E44
	// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0000795A File Offset: 0x00005B5A
	public unsafe static string ACTION_CAST_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAST_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAST_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0004BC64 File Offset: 0x00049E64
	// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0000796C File Offset: 0x00005B6C
	public unsafe static string ACTION_DATE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0004BC84 File Offset: 0x00049E84
	// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x0000797E File Offset: 0x00005B7E
	public unsafe static string ACTION_SOUND_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SOUND_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SOUND_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0004BCA4 File Offset: 0x00049EA4
	// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x00007990 File Offset: 0x00005B90
	public unsafe static string ACTION_DISPLAY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DISPLAY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DISPLAY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0004BCC4 File Offset: 0x00049EC4
	// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x000079A2 File Offset: 0x00005BA2
	public unsafe static string ACTION_LOCALE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCALE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_LOCALE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004BCE4 File Offset: 0x00049EE4
	// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x000079B4 File Offset: 0x00005BB4
	public unsafe static string ACTION_VOICE_INPUT_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_VOICE_INPUT_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_VOICE_INPUT_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0004BD04 File Offset: 0x00049F04
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x000079C6 File Offset: 0x00005BC6
	public unsafe static string ACTION_INPUT_METHOD_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0004BD24 File Offset: 0x00049F24
	// (set) Token: 0x06000EDA RID: 3802 RVA: 0x000079D8 File Offset: 0x00005BD8
	public unsafe static string ACTION_INPUT_METHOD_SUBTYPE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SUBTYPE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INPUT_METHOD_SUBTYPE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045C RID: 1116
	// (get) Token: 0x06000EDB RID: 3803 RVA: 0x0004BD44 File Offset: 0x00049F44
	// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000079EA File Offset: 0x00005BEA
	public unsafe static string ACTION_SHOW_INPUT_METHOD_PICKER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_INPUT_METHOD_PICKER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_INPUT_METHOD_PICKER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045D RID: 1117
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x0004BD64 File Offset: 0x00049F64
	// (set) Token: 0x06000EDE RID: 3806 RVA: 0x000079FC File Offset: 0x00005BFC
	public unsafe static string ACTION_USER_DICTIONARY_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045E RID: 1118
	// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0004BD84 File Offset: 0x00049F84
	// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00007A0E File Offset: 0x00005C0E
	public unsafe static string ACTION_USER_DICTIONARY_INSERT
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_INSERT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_USER_DICTIONARY_INSERT, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700045F RID: 1119
	// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x0004BDA4 File Offset: 0x00049FA4
	// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x00007A20 File Offset: 0x00005C20
	public unsafe static string ACTION_APPLICATION_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000460 RID: 1120
	// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0004BDC4 File Offset: 0x00049FC4
	// (set) Token: 0x06000EE4 RID: 3812 RVA: 0x00007A32 File Offset: 0x00005C32
	public unsafe static string ACTION_APPLICATION_DEVELOPMENT_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DEVELOPMENT_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DEVELOPMENT_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000461 RID: 1121
	// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0004BDE4 File Offset: 0x00049FE4
	// (set) Token: 0x06000EE6 RID: 3814 RVA: 0x00007A44 File Offset: 0x00005C44
	public unsafe static string ACTION_QUICK_LAUNCH_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_QUICK_LAUNCH_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_QUICK_LAUNCH_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000462 RID: 1122
	// (get) Token: 0x06000EE7 RID: 3815 RVA: 0x0004BE04 File Offset: 0x0004A004
	// (set) Token: 0x06000EE8 RID: 3816 RVA: 0x00007A56 File Offset: 0x00005C56
	public unsafe static string ACTION_MANAGE_APPLICATIONS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_APPLICATIONS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_APPLICATIONS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000463 RID: 1123
	// (get) Token: 0x06000EE9 RID: 3817 RVA: 0x0004BE24 File Offset: 0x0004A024
	// (set) Token: 0x06000EEA RID: 3818 RVA: 0x00007A68 File Offset: 0x00005C68
	public unsafe static string ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000464 RID: 1124
	// (get) Token: 0x06000EEB RID: 3819 RVA: 0x0004BE44 File Offset: 0x0004A044
	// (set) Token: 0x06000EEC RID: 3820 RVA: 0x00007A7A File Offset: 0x00005C7A
	public unsafe static string ACTION_APPLICATION_DETAILS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DETAILS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APPLICATION_DETAILS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000465 RID: 1125
	// (get) Token: 0x06000EED RID: 3821 RVA: 0x0004BE64 File Offset: 0x0004A064
	// (set) Token: 0x06000EEE RID: 3822 RVA: 0x00007A8C File Offset: 0x00005C8C
	public unsafe static string ACTION_APP_OPS_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_OPS_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_OPS_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000466 RID: 1126
	// (get) Token: 0x06000EEF RID: 3823 RVA: 0x0004BE84 File Offset: 0x0004A084
	// (set) Token: 0x06000EF0 RID: 3824 RVA: 0x00007A9E File Offset: 0x00005C9E
	public unsafe static string ACTION_SYSTEM_UPDATE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYSTEM_UPDATE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYSTEM_UPDATE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000467 RID: 1127
	// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
	// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00007AB0 File Offset: 0x00005CB0
	public unsafe static string ACTION_SYNC_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYNC_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SYNC_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000468 RID: 1128
	// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x0004BEC4 File Offset: 0x0004A0C4
	// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00007AC2 File Offset: 0x00005CC2
	public unsafe static string ACTION_ADD_ACCOUNT
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ADD_ACCOUNT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_ADD_ACCOUNT, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000469 RID: 1129
	// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
	// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00007AD4 File Offset: 0x00005CD4
	public unsafe static string ACTION_NETWORK_OPERATOR_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NETWORK_OPERATOR_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NETWORK_OPERATOR_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046A RID: 1130
	// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x0004BF04 File Offset: 0x0004A104
	// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00007AE6 File Offset: 0x00005CE6
	public unsafe static string ACTION_DATA_ROAMING_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATA_ROAMING_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DATA_ROAMING_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046B RID: 1131
	// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0004BF24 File Offset: 0x0004A124
	// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00007AF8 File Offset: 0x00005CF8
	public unsafe static string ACTION_INTERNAL_STORAGE_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INTERNAL_STORAGE_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_INTERNAL_STORAGE_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046C RID: 1132
	// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0004BF44 File Offset: 0x0004A144
	// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00007B0A File Offset: 0x00005D0A
	public unsafe static string ACTION_MEMORY_CARD_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MEMORY_CARD_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_MEMORY_CARD_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046D RID: 1133
	// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0004BF64 File Offset: 0x0004A164
	// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00007B1C File Offset: 0x00005D1C
	public unsafe static string ACTION_SEARCH_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SEARCH_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SEARCH_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046E RID: 1134
	// (get) Token: 0x06000EFF RID: 3839 RVA: 0x0004BF84 File Offset: 0x0004A184
	// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00007B2E File Offset: 0x00005D2E
	public unsafe static string ACTION_DEVICE_INFO_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DEVICE_INFO_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DEVICE_INFO_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700046F RID: 1135
	// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0004BFA4 File Offset: 0x0004A1A4
	// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00007B40 File Offset: 0x00005D40
	public unsafe static string ACTION_NFC_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0004BFC4 File Offset: 0x0004A1C4
	// (set) Token: 0x06000F04 RID: 3844 RVA: 0x00007B52 File Offset: 0x00005D52
	public unsafe static string ACTION_NFCSHARING_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFCSHARING_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFCSHARING_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06000F05 RID: 3845 RVA: 0x0004BFE4 File Offset: 0x0004A1E4
	// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00007B64 File Offset: 0x00005D64
	public unsafe static string ACTION_NFC_PAYMENT_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_PAYMENT_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NFC_PAYMENT_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000472 RID: 1138
	// (get) Token: 0x06000F07 RID: 3847 RVA: 0x0004C004 File Offset: 0x0004A204
	// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00007B76 File Offset: 0x00005D76
	public unsafe static string ACTION_DREAM_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DREAM_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_DREAM_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000473 RID: 1139
	// (get) Token: 0x06000F09 RID: 3849 RVA: 0x0004C024 File Offset: 0x0004A224
	// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00007B88 File Offset: 0x00005D88
	public unsafe static string ACTION_NOTIFICATION_LISTENER_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_LISTENER_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_LISTENER_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000474 RID: 1140
	// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0004C044 File Offset: 0x0004A244
	// (set) Token: 0x06000F0C RID: 3852 RVA: 0x00007B9A File Offset: 0x00005D9A
	public unsafe static string ACTION_CAPTIONING_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAPTIONING_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_CAPTIONING_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000475 RID: 1141
	// (get) Token: 0x06000F0D RID: 3853 RVA: 0x0004C064 File Offset: 0x0004A264
	// (set) Token: 0x06000F0E RID: 3854 RVA: 0x00007BAC File Offset: 0x00005DAC
	public unsafe static string ACTION_PRINT_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRINT_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PRINT_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000476 RID: 1142
	// (get) Token: 0x06000F0F RID: 3855 RVA: 0x0004C084 File Offset: 0x0004A284
	// (set) Token: 0x06000F10 RID: 3856 RVA: 0x00007BBE File Offset: 0x00005DBE
	public unsafe static string ACTION_SHOW_REGULATORY_INFO
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_REGULATORY_INFO, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_SHOW_REGULATORY_INFO, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000477 RID: 1143
	// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
	// (set) Token: 0x06000F12 RID: 3858 RVA: 0x00007BD0 File Offset: 0x00005DD0
	public unsafe static string DEVICE_NAME_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_DEVICE_NAME_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_DEVICE_NAME_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000478 RID: 1144
	// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0004C0C4 File Offset: 0x0004A2C4
	// (set) Token: 0x06000F14 RID: 3860 RVA: 0x00007BE2 File Offset: 0x00005DE2
	public unsafe static string ACTION_PAIRING_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PAIRING_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_PAIRING_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000479 RID: 1145
	// (get) Token: 0x06000F15 RID: 3861 RVA: 0x0004C0E4 File Offset: 0x0004A2E4
	// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00007BF4 File Offset: 0x00005DF4
	public unsafe static string ACTION_BATTERY_SAVER_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BATTERY_SAVER_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_BATTERY_SAVER_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700047A RID: 1146
	// (get) Token: 0x06000F17 RID: 3863 RVA: 0x0004C104 File Offset: 0x0004A304
	// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00007C06 File Offset: 0x00005E06
	public unsafe static string ACTION_HOME_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_HOME_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_HOME_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700047B RID: 1147
	// (get) Token: 0x06000F19 RID: 3865 RVA: 0x0004C124 File Offset: 0x0004A324
	// (set) Token: 0x06000F1A RID: 3866 RVA: 0x00007C18 File Offset: 0x00005E18
	public unsafe static string ACTION_NOTIFICATION_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_NOTIFICATION_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700047C RID: 1148
	// (get) Token: 0x06000F1B RID: 3867 RVA: 0x0004C144 File Offset: 0x0004A344
	// (set) Token: 0x06000F1C RID: 3868 RVA: 0x00007C2A File Offset: 0x00005E2A
	public unsafe static string ACTION_APP_NOTIFICATION_SETTINGS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_SETTINGS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_SETTINGS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700047D RID: 1149
	// (get) Token: 0x06000F1D RID: 3869 RVA: 0x0004C164 File Offset: 0x0004A364
	// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00007C3C File Offset: 0x00005E3C
	public unsafe static string ACTION_APP_NOTIFICATION_REDACTION
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_REDACTION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SettingsActivityAction.NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_REDACTION, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000BC0 RID: 3008
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SETTINGS;

	// Token: 0x04000BC1 RID: 3009
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APN_SETTINGS;

	// Token: 0x04000BC2 RID: 3010
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_LOCATION_SOURCE_SETTINGS;

	// Token: 0x04000BC3 RID: 3011
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_WIRELESS_SETTINGS;

	// Token: 0x04000BC4 RID: 3012
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_AIRPLANE_MODE_SETTINGS;

	// Token: 0x04000BC5 RID: 3013
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_ACCESSIBILITY_SETTINGS;

	// Token: 0x04000BC6 RID: 3014
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_USAGE_ACCESS_SETTINGS;

	// Token: 0x04000BC7 RID: 3015
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SECURITY_SETTINGS;

	// Token: 0x04000BC8 RID: 3016
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_TRUSTED_CREDENTIALS_USER;

	// Token: 0x04000BC9 RID: 3017
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_MONITORING_CERT_INFO;

	// Token: 0x04000BCA RID: 3018
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_PRIVACY_SETTINGS;

	// Token: 0x04000BCB RID: 3019
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_WIFI_SETTINGS;

	// Token: 0x04000BCC RID: 3020
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_WIFI_IP_SETTINGS;

	// Token: 0x04000BCD RID: 3021
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_BLUETOOTH_SETTINGS;

	// Token: 0x04000BCE RID: 3022
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_WIFI_DISPLAY_SETTINGS;

	// Token: 0x04000BCF RID: 3023
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_CAST_SETTINGS;

	// Token: 0x04000BD0 RID: 3024
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_DATE_SETTINGS;

	// Token: 0x04000BD1 RID: 3025
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SOUND_SETTINGS;

	// Token: 0x04000BD2 RID: 3026
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_DISPLAY_SETTINGS;

	// Token: 0x04000BD3 RID: 3027
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_LOCALE_SETTINGS;

	// Token: 0x04000BD4 RID: 3028
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_VOICE_INPUT_SETTINGS;

	// Token: 0x04000BD5 RID: 3029
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_INPUT_METHOD_SETTINGS;

	// Token: 0x04000BD6 RID: 3030
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_INPUT_METHOD_SUBTYPE_SETTINGS;

	// Token: 0x04000BD7 RID: 3031
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SHOW_INPUT_METHOD_PICKER;

	// Token: 0x04000BD8 RID: 3032
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_USER_DICTIONARY_SETTINGS;

	// Token: 0x04000BD9 RID: 3033
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_USER_DICTIONARY_INSERT;

	// Token: 0x04000BDA RID: 3034
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APPLICATION_SETTINGS;

	// Token: 0x04000BDB RID: 3035
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APPLICATION_DEVELOPMENT_SETTINGS;

	// Token: 0x04000BDC RID: 3036
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_QUICK_LAUNCH_SETTINGS;

	// Token: 0x04000BDD RID: 3037
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_MANAGE_APPLICATIONS_SETTINGS;

	// Token: 0x04000BDE RID: 3038
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_MANAGE_ALL_APPLICATIONS_SETTINGS;

	// Token: 0x04000BDF RID: 3039
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APPLICATION_DETAILS_SETTINGS;

	// Token: 0x04000BE0 RID: 3040
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APP_OPS_SETTINGS;

	// Token: 0x04000BE1 RID: 3041
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SYSTEM_UPDATE_SETTINGS;

	// Token: 0x04000BE2 RID: 3042
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SYNC_SETTINGS;

	// Token: 0x04000BE3 RID: 3043
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_ADD_ACCOUNT;

	// Token: 0x04000BE4 RID: 3044
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NETWORK_OPERATOR_SETTINGS;

	// Token: 0x04000BE5 RID: 3045
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_DATA_ROAMING_SETTINGS;

	// Token: 0x04000BE6 RID: 3046
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_INTERNAL_STORAGE_SETTINGS;

	// Token: 0x04000BE7 RID: 3047
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_MEMORY_CARD_SETTINGS;

	// Token: 0x04000BE8 RID: 3048
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SEARCH_SETTINGS;

	// Token: 0x04000BE9 RID: 3049
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_DEVICE_INFO_SETTINGS;

	// Token: 0x04000BEA RID: 3050
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NFC_SETTINGS;

	// Token: 0x04000BEB RID: 3051
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NFCSHARING_SETTINGS;

	// Token: 0x04000BEC RID: 3052
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NFC_PAYMENT_SETTINGS;

	// Token: 0x04000BED RID: 3053
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_DREAM_SETTINGS;

	// Token: 0x04000BEE RID: 3054
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NOTIFICATION_LISTENER_SETTINGS;

	// Token: 0x04000BEF RID: 3055
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_CAPTIONING_SETTINGS;

	// Token: 0x04000BF0 RID: 3056
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_PRINT_SETTINGS;

	// Token: 0x04000BF1 RID: 3057
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_SHOW_REGULATORY_INFO;

	// Token: 0x04000BF2 RID: 3058
	private static readonly IntPtr NativeFieldInfoPtr_DEVICE_NAME_SETTINGS;

	// Token: 0x04000BF3 RID: 3059
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_PAIRING_SETTINGS;

	// Token: 0x04000BF4 RID: 3060
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_BATTERY_SAVER_SETTINGS;

	// Token: 0x04000BF5 RID: 3061
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_HOME_SETTINGS;

	// Token: 0x04000BF6 RID: 3062
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_NOTIFICATION_SETTINGS;

	// Token: 0x04000BF7 RID: 3063
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_SETTINGS;

	// Token: 0x04000BF8 RID: 3064
	private static readonly IntPtr NativeFieldInfoPtr_ACTION_APP_NOTIFICATION_REDACTION;

	// Token: 0x04000BF9 RID: 3065
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
