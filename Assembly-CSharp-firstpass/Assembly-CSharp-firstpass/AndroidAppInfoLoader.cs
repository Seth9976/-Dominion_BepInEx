using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x020000D7 RID: 215
public class AndroidAppInfoLoader : Singleton<AndroidAppInfoLoader>
{
	// Token: 0x06000F39 RID: 3897 RVA: 0x0004C6F0 File Offset: 0x0004A8F0
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidAppInfoLoader()
	{
		Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidAppInfoLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr);
		AndroidAppInfoLoader.NativeFieldInfoPtr_ActionPacakgeInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, "ActionPacakgeInfoLoaded");
		AndroidAppInfoLoader.NativeFieldInfoPtr_PacakgeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, "PacakgeInfo");
		AndroidAppInfoLoader.NativeMethodInfoPtr_add_ActionPacakgeInfoLoaded_Public_Static_add_Void_Action_1_PackageAppInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, 100665164);
		AndroidAppInfoLoader.NativeMethodInfoPtr_remove_ActionPacakgeInfoLoaded_Public_Static_rem_Void_Action_1_PackageAppInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, 100665165);
		AndroidAppInfoLoader.NativeMethodInfoPtr_LoadPackageInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, 100665166);
		AndroidAppInfoLoader.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, 100665167);
		AndroidAppInfoLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, 100665168);
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0004C7AC File Offset: 0x0004A9AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179248, RefRangeEnd = 179249, XrefRangeStart = 179237, XrefRangeEnd = 179248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPacakgeInfoLoaded(Action<PackageAppInfo> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.NativeMethodInfoPtr_add_ActionPacakgeInfoLoaded_Public_Static_add_Void_Action_1_PackageAppInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x0004C7E4 File Offset: 0x0004A9E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179260, RefRangeEnd = 179261, XrefRangeStart = 179249, XrefRangeEnd = 179260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPacakgeInfoLoaded(Action<PackageAppInfo> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.NativeMethodInfoPtr_remove_ActionPacakgeInfoLoaded_Public_Static_rem_Void_Action_1_PackageAppInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x0004C81C File Offset: 0x0004AA1C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179262, RefRangeEnd = 179263, XrefRangeStart = 179261, XrefRangeEnd = 179262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPackageInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.NativeMethodInfoPtr_LoadPackageInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0004C850 File Offset: 0x0004AA50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179263, XrefRangeEnd = 179310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackageInfoLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x0004C894 File Offset: 0x0004AA94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179310, XrefRangeEnd = 179320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidAppInfoLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00007CC8 File Offset: 0x00005EC8
	public AndroidAppInfoLoader(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000486 RID: 1158
	// (get) Token: 0x06000F40 RID: 3904 RVA: 0x0004C8D0 File Offset: 0x0004AAD0
	// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00007CD1 File Offset: 0x00005ED1
	public unsafe static Action<PackageAppInfo> ActionPacakgeInfoLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidAppInfoLoader.NativeFieldInfoPtr_ActionPacakgeInfoLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PackageAppInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidAppInfoLoader.NativeFieldInfoPtr_ActionPacakgeInfoLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000487 RID: 1159
	// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004C8F8 File Offset: 0x0004AAF8
	// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00007CE3 File Offset: 0x00005EE3
	public unsafe PackageAppInfo PacakgeInfo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAppInfoLoader.NativeFieldInfoPtr_PacakgeInfo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackageAppInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAppInfoLoader.NativeFieldInfoPtr_PacakgeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C0C RID: 3084
	private static readonly IntPtr NativeFieldInfoPtr_ActionPacakgeInfoLoaded;

	// Token: 0x04000C0D RID: 3085
	private static readonly IntPtr NativeFieldInfoPtr_PacakgeInfo;

	// Token: 0x04000C0E RID: 3086
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPacakgeInfoLoaded_Public_Static_add_Void_Action_1_PackageAppInfo_0;

	// Token: 0x04000C0F RID: 3087
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPacakgeInfoLoaded_Public_Static_rem_Void_Action_1_PackageAppInfo_0;

	// Token: 0x04000C10 RID: 3088
	private static readonly IntPtr NativeMethodInfoPtr_LoadPackageInfo_Public_Void_0;

	// Token: 0x04000C11 RID: 3089
	private static readonly IntPtr NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_String_0;

	// Token: 0x04000C12 RID: 3090
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200038D RID: 909
	[ObfuscatedName("AndroidAppInfoLoader+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x0600360E RID: 13838 RVA: 0x000DE344 File Offset: 0x000DC544
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidAppInfoLoader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr);
			AndroidAppInfoLoader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr, "<>9");
			AndroidAppInfoLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr, 100670182);
			AndroidAppInfoLoader.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_PackageAppInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr, 100670183);
		}

		// Token: 0x0600360F RID: 13839 RVA: 0x000DE3AC File Offset: 0x000DC5AC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAppInfoLoader.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003610 RID: 13840 RVA: 0x000DE3E8 File Offset: 0x000DC5E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__7_0(PackageAppInfo <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAppInfoLoader.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_PackageAppInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003611 RID: 13841 RVA: 0x00014F22 File Offset: 0x00013122
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x000DE42C File Offset: 0x000DC62C
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x00014F2B File Offset: 0x0001312B
		public unsafe static AndroidAppInfoLoader.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAppInfoLoader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidAppInfoLoader.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAppInfoLoader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003190 RID: 12688
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003191 RID: 12689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003192 RID: 12690
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_Void_PackageAppInfo_0;
	}
}
