using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010A RID: 266
	[Serializable]
	public sealed class AppDomainSetup : Object
	{
		// Token: 0x060013A7 RID: 5031 RVA: 0x0007CC14 File Offset: 0x0007AE14
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainSetup()
		{
			Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr);
			AppDomainSetup.NativeFieldInfoPtr_application_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_base");
			AppDomainSetup.NativeFieldInfoPtr_application_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_name");
			AppDomainSetup.NativeFieldInfoPtr_cache_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "cache_path");
			AppDomainSetup.NativeFieldInfoPtr_configuration_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_file");
			AppDomainSetup.NativeFieldInfoPtr_dynamic_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "dynamic_base");
			AppDomainSetup.NativeFieldInfoPtr_license_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "license_file");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path_probe");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_directories");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_files");
			AppDomainSetup.NativeFieldInfoPtr_publisher_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "publisher_policy");
			AppDomainSetup.NativeFieldInfoPtr_path_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "path_changed");
			AppDomainSetup.NativeFieldInfoPtr_loader_optimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "loader_optimization");
			AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_binding_redirects");
			AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_code_downloads");
			AppDomainSetup.NativeFieldInfoPtr__activationArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "_activationArguments");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer");
			AppDomainSetup.NativeFieldInfoPtr_application_trust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_trust");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer_args");
			AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_appbase_probe");
			AppDomainSetup.NativeFieldInfoPtr_configuration_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_bytes");
			AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "serialized_non_primitives");
			AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "<TargetFrameworkName>k__BackingField");
			AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, 100666702);
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x0007CE24 File Offset: 0x0007B024
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00006C42 File Offset: 0x00004E42
		public AppDomainSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0007CE60 File Offset: 0x0007B060
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00006C4B File Offset: 0x00004E4B
		public unsafe string application_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0007CE88 File Offset: 0x0007B088
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x00006C6A File Offset: 0x00004E6A
		public unsafe string application_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0007CEB0 File Offset: 0x0007B0B0
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x00006C89 File Offset: 0x00004E89
		public unsafe string cache_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0007CED8 File Offset: 0x0007B0D8
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public unsafe string configuration_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0007CF00 File Offset: 0x0007B100
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x00006CC7 File Offset: 0x00004EC7
		public unsafe string dynamic_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0007CF28 File Offset: 0x0007B128
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x00006CE6 File Offset: 0x00004EE6
		public unsafe string license_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x0007CF50 File Offset: 0x0007B150
		// (set) Token: 0x060013B7 RID: 5047 RVA: 0x00006D05 File Offset: 0x00004F05
		public unsafe string private_bin_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x0007CF78 File Offset: 0x0007B178
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00006D24 File Offset: 0x00004F24
		public unsafe string private_bin_path_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x0007CFA0 File Offset: 0x0007B1A0
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x00006D43 File Offset: 0x00004F43
		public unsafe string shadow_copy_directories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x0007CFC8 File Offset: 0x0007B1C8
		// (set) Token: 0x060013BD RID: 5053 RVA: 0x00006D62 File Offset: 0x00004F62
		public unsafe string shadow_copy_files
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060013BE RID: 5054 RVA: 0x0007CFF0 File Offset: 0x0007B1F0
		// (set) Token: 0x060013BF RID: 5055 RVA: 0x00006D81 File Offset: 0x00004F81
		public unsafe bool publisher_policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x0007D018 File Offset: 0x0007B218
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x00006D9C File Offset: 0x00004F9C
		public unsafe bool path_changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x0007D040 File Offset: 0x0007B240
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x00006DB7 File Offset: 0x00004FB7
		public unsafe int loader_optimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0007D068 File Offset: 0x0007B268
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00006DD2 File Offset: 0x00004FD2
		public unsafe bool disallow_binding_redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0007D090 File Offset: 0x0007B290
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00006DED File Offset: 0x00004FED
		public unsafe bool disallow_code_downloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0007D0B8 File Offset: 0x0007B2B8
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x00006E08 File Offset: 0x00005008
		public unsafe Object _activationArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x0007D0E8 File Offset: 0x0007B2E8
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00006E27 File Offset: 0x00005027
		public unsafe Object domain_initializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x0007D118 File Offset: 0x0007B318
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x00006E46 File Offset: 0x00005046
		public unsafe Object application_trust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x0007D148 File Offset: 0x0007B348
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x00006E65 File Offset: 0x00005065
		public unsafe Il2CppStringArray domain_initializer_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x0007D178 File Offset: 0x0007B378
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x00006E84 File Offset: 0x00005084
		public unsafe bool disallow_appbase_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe)) = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0007D1A0 File Offset: 0x0007B3A0
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x00006E9F File Offset: 0x0000509F
		public unsafe Il2CppStructArray<byte> configuration_bytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0007D1D0 File Offset: 0x0007B3D0
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x00006EBE File Offset: 0x000050BE
		public unsafe Il2CppStructArray<byte> serialized_non_primitives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0007D200 File Offset: 0x0007B400
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x00006EDD File Offset: 0x000050DD
		public unsafe string _TargetFrameworkName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeFieldInfoPtr_application_base;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeFieldInfoPtr_application_name;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_cache_path;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_configuration_file;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeFieldInfoPtr_dynamic_base;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeFieldInfoPtr_license_file;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path_probe;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_directories;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_files;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeFieldInfoPtr_publisher_policy;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeFieldInfoPtr_path_changed;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeFieldInfoPtr_loader_optimization;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeFieldInfoPtr_disallow_binding_redirects;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeFieldInfoPtr_disallow_code_downloads;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeFieldInfoPtr__activationArguments;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeFieldInfoPtr_application_trust;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer_args;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeFieldInfoPtr_disallow_appbase_probe;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeFieldInfoPtr_configuration_bytes;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr_serialized_non_primitives;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr__TargetFrameworkName_k__BackingField;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
