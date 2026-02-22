using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000CD RID: 205
public class AN_LicenseRequestResult : Object
{
	// Token: 0x06000E9C RID: 3740 RVA: 0x0004B29C File Offset: 0x0004949C
	// Note: this type is marked as 'beforefieldinit'.
	static AN_LicenseRequestResult()
	{
		Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_LicenseRequestResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr);
		AN_LicenseRequestResult.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, "_status");
		AN_LicenseRequestResult.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, "_error");
		AN_LicenseRequestResult.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, 100665144);
		AN_LicenseRequestResult.NativeMethodInfoPtr__ctor_Public_Void_AN_LicenseStatusCode_AN_LicenseErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, 100665145);
		AN_LicenseRequestResult.NativeMethodInfoPtr_get_Status_Public_get_AN_LicenseStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, 100665146);
		AN_LicenseRequestResult.NativeMethodInfoPtr_get_Error_Public_get_AN_LicenseErrorCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr, 100665147);
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x0004B344 File Offset: 0x00049544
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_LicenseRequestResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseRequestResult.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0004B380 File Offset: 0x00049580
	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 178992, RefRangeEnd = 179019, XrefRangeStart = 178991, XrefRangeEnd = 178992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_LicenseRequestResult(AN_LicenseStatusCode status, AN_LicenseErrorCode error = AN_LicenseErrorCode.ERROR_NONE)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_LicenseRequestResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref status;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseRequestResult.NativeMethodInfoPtr__ctor_Public_Void_AN_LicenseStatusCode_AN_LicenseErrorCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000443 RID: 1091
	// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0004B3D8 File Offset: 0x000495D8
	public unsafe AN_LicenseStatusCode Status
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseRequestResult.NativeMethodInfoPtr_get_Status_Public_get_AN_LicenseStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000444 RID: 1092
	// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0004B414 File Offset: 0x00049614
	public unsafe AN_LicenseErrorCode Error
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseRequestResult.NativeMethodInfoPtr_get_Error_Public_get_AN_LicenseErrorCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x000077FB File Offset: 0x000059FB
	public AN_LicenseRequestResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000441 RID: 1089
	// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0004B450 File Offset: 0x00049650
	// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00007804 File Offset: 0x00005A04
	public unsafe AN_LicenseStatusCode _status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_LicenseRequestResult.NativeFieldInfoPtr__status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_LicenseRequestResult.NativeFieldInfoPtr__status)) = value;
		}
	}

	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0004B478 File Offset: 0x00049678
	// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0000781F File Offset: 0x00005A1F
	public unsafe AN_LicenseErrorCode _error
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_LicenseRequestResult.NativeFieldInfoPtr__error);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_LicenseRequestResult.NativeFieldInfoPtr__error)) = value;
		}
	}

	// Token: 0x04000B60 RID: 2912
	private static readonly IntPtr NativeFieldInfoPtr__status;

	// Token: 0x04000B61 RID: 2913
	private static readonly IntPtr NativeFieldInfoPtr__error;

	// Token: 0x04000B62 RID: 2914
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	// Token: 0x04000B63 RID: 2915
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AN_LicenseStatusCode_AN_LicenseErrorCode_0;

	// Token: 0x04000B64 RID: 2916
	private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_AN_LicenseStatusCode_0;

	// Token: 0x04000B65 RID: 2917
	private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_AN_LicenseErrorCode_0;
}
