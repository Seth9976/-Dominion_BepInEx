using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000E0 RID: 224
public class AN_Locale : Object
{
	// Token: 0x06001007 RID: 4103 RVA: 0x0004FB24 File Offset: 0x0004DD24
	// Note: this type is marked as 'beforefieldinit'.
	static AN_Locale()
	{
		Il2CppClassPointerStore<AN_Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_Locale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr);
		AN_Locale.NativeFieldInfoPtr_CountryCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr, "CountryCode");
		AN_Locale.NativeFieldInfoPtr_DisplayCountry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr, "DisplayCountry");
		AN_Locale.NativeFieldInfoPtr_LanguageCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr, "LanguageCode");
		AN_Locale.NativeFieldInfoPtr_DisplayLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr, "DisplayLanguage");
		AN_Locale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr, 100665300);
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_Locale()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_Locale>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_Locale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00007FB4 File Offset: 0x000061B4
	public AN_Locale(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x0600100A RID: 4106 RVA: 0x0004FBF4 File Offset: 0x0004DDF4
	// (set) Token: 0x0600100B RID: 4107 RVA: 0x00007FBD File Offset: 0x000061BD
	public unsafe string CountryCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_CountryCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_CountryCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004A6 RID: 1190
	// (get) Token: 0x0600100C RID: 4108 RVA: 0x0004FC1C File Offset: 0x0004DE1C
	// (set) Token: 0x0600100D RID: 4109 RVA: 0x00007FDC File Offset: 0x000061DC
	public unsafe string DisplayCountry
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_DisplayCountry);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_DisplayCountry), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004A7 RID: 1191
	// (get) Token: 0x0600100E RID: 4110 RVA: 0x0004FC44 File Offset: 0x0004DE44
	// (set) Token: 0x0600100F RID: 4111 RVA: 0x00007FFB File Offset: 0x000061FB
	public unsafe string LanguageCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_LanguageCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_LanguageCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004A8 RID: 1192
	// (get) Token: 0x06001010 RID: 4112 RVA: 0x0004FC6C File Offset: 0x0004DE6C
	// (set) Token: 0x06001011 RID: 4113 RVA: 0x0000801A File Offset: 0x0000621A
	public unsafe string DisplayLanguage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_DisplayLanguage);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_Locale.NativeFieldInfoPtr_DisplayLanguage), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000CAE RID: 3246
	private static readonly IntPtr NativeFieldInfoPtr_CountryCode;

	// Token: 0x04000CAF RID: 3247
	private static readonly IntPtr NativeFieldInfoPtr_DisplayCountry;

	// Token: 0x04000CB0 RID: 3248
	private static readonly IntPtr NativeFieldInfoPtr_LanguageCode;

	// Token: 0x04000CB1 RID: 3249
	private static readonly IntPtr NativeFieldInfoPtr_DisplayLanguage;

	// Token: 0x04000CB2 RID: 3250
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
