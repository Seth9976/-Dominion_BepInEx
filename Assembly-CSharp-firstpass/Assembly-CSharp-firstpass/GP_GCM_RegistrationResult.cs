using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000023 RID: 35
public class GP_GCM_RegistrationResult : GooglePlayResult
{
	// Token: 0x06000401 RID: 1025 RVA: 0x000241D8 File Offset: 0x000223D8
	// Note: this type is marked as 'beforefieldinit'.
	static GP_GCM_RegistrationResult()
	{
		Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_GCM_RegistrationResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr);
		GP_GCM_RegistrationResult.NativeFieldInfoPtr__RegistrationDeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr, "_RegistrationDeviceId");
		GP_GCM_RegistrationResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr, 100663746);
		GP_GCM_RegistrationResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr, 100663747);
		GP_GCM_RegistrationResult.NativeMethodInfoPtr_get_RegistrationDeviceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr, 100663748);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00024258 File Offset: 0x00022458
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163167, XrefRangeEnd = 163170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_GCM_RegistrationResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_GCM_RegistrationResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00024294 File Offset: 0x00022494
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163170, XrefRangeEnd = 163173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_GCM_RegistrationResult(string id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_GCM_RegistrationResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_GCM_RegistrationResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x000242E0 File Offset: 0x000224E0
	public unsafe string RegistrationDeviceId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_GCM_RegistrationResult.NativeMethodInfoPtr_get_RegistrationDeviceId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00003C55 File Offset: 0x00001E55
	public GP_GCM_RegistrationResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00024318 File Offset: 0x00022518
	// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003C5E File Offset: 0x00001E5E
	public unsafe string _RegistrationDeviceId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_GCM_RegistrationResult.NativeFieldInfoPtr__RegistrationDeviceId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_GCM_RegistrationResult.NativeFieldInfoPtr__RegistrationDeviceId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040002FE RID: 766
	private static readonly IntPtr NativeFieldInfoPtr__RegistrationDeviceId;

	// Token: 0x040002FF RID: 767
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000300 RID: 768
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000301 RID: 769
	private static readonly IntPtr NativeMethodInfoPtr_get_RegistrationDeviceId_Public_get_String_0;
}
