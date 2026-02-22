using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000E9 RID: 233
public class AN_DeviceCodeResult : Result
{
	// Token: 0x060010B9 RID: 4281 RVA: 0x00051CB0 File Offset: 0x0004FEB0
	// Note: this type is marked as 'beforefieldinit'.
	static AN_DeviceCodeResult()
	{
		Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_DeviceCodeResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr);
		AN_DeviceCodeResult.NativeFieldInfoPtr__deviceCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, "_deviceCode");
		AN_DeviceCodeResult.NativeFieldInfoPtr__userCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, "_userCode");
		AN_DeviceCodeResult.NativeFieldInfoPtr__verificationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, "_verificationUrl");
		AN_DeviceCodeResult.NativeFieldInfoPtr__expiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, "_expiresIn");
		AN_DeviceCodeResult.NativeFieldInfoPtr__interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, "_interval");
		AN_DeviceCodeResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665363);
		AN_DeviceCodeResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665364);
		AN_DeviceCodeResult.NativeMethodInfoPtr_get_DeviceCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665365);
		AN_DeviceCodeResult.NativeMethodInfoPtr_get_UserCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665366);
		AN_DeviceCodeResult.NativeMethodInfoPtr_get_VerificationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665367);
		AN_DeviceCodeResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665368);
		AN_DeviceCodeResult.NativeMethodInfoPtr_get_Interval_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr, 100665369);
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00051DD0 File Offset: 0x0004FFD0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181412, RefRangeEnd = 181413, XrefRangeStart = 181403, XrefRangeEnd = 181412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_DeviceCodeResult(string errorMessage)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00051E1C File Offset: 0x0005001C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181418, RefRangeEnd = 181419, XrefRangeStart = 181413, XrefRangeEnd = 181418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_DeviceCodeResult(string deviceCode, string userCode, string verificationUrl, long expiresIn, long interval)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_DeviceCodeResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceCode);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userCode);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(verificationUrl);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiresIn;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interval;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x060010BC RID: 4284 RVA: 0x00051EA8 File Offset: 0x000500A8
	public unsafe string DeviceCode
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr_get_DeviceCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x060010BD RID: 4285 RVA: 0x00051EE0 File Offset: 0x000500E0
	public unsafe string UserCode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr_get_UserCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x060010BE RID: 4286 RVA: 0x00051F18 File Offset: 0x00050118
	public unsafe string VerificationUrl
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr_get_VerificationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x060010BF RID: 4287 RVA: 0x00051F50 File Offset: 0x00050150
	public unsafe long ExpiresIn
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00051F8C File Offset: 0x0005018C
	public unsafe long Interval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_DeviceCodeResult.NativeMethodInfoPtr_get_Interval_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0000852E File Offset: 0x0000672E
	public AN_DeviceCodeResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00051FC8 File Offset: 0x000501C8
	// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00008537 File Offset: 0x00006737
	public unsafe string _deviceCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__deviceCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__deviceCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00051FF0 File Offset: 0x000501F0
	// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00008556 File Offset: 0x00006756
	public unsafe string _userCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__userCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__userCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x060010C6 RID: 4294 RVA: 0x00052018 File Offset: 0x00050218
	// (set) Token: 0x060010C7 RID: 4295 RVA: 0x00008575 File Offset: 0x00006775
	public unsafe string _verificationUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__verificationUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__verificationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x060010C8 RID: 4296 RVA: 0x00052040 File Offset: 0x00050240
	// (set) Token: 0x060010C9 RID: 4297 RVA: 0x00008594 File Offset: 0x00006794
	public unsafe long _expiresIn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__expiresIn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__expiresIn)) = value;
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x060010CA RID: 4298 RVA: 0x00052068 File Offset: 0x00050268
	// (set) Token: 0x060010CB RID: 4299 RVA: 0x000085AF File Offset: 0x000067AF
	public unsafe long _interval
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__interval);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_DeviceCodeResult.NativeFieldInfoPtr__interval)) = value;
		}
	}

	// Token: 0x04000D1D RID: 3357
	private static readonly IntPtr NativeFieldInfoPtr__deviceCode;

	// Token: 0x04000D1E RID: 3358
	private static readonly IntPtr NativeFieldInfoPtr__userCode;

	// Token: 0x04000D1F RID: 3359
	private static readonly IntPtr NativeFieldInfoPtr__verificationUrl;

	// Token: 0x04000D20 RID: 3360
	private static readonly IntPtr NativeFieldInfoPtr__expiresIn;

	// Token: 0x04000D21 RID: 3361
	private static readonly IntPtr NativeFieldInfoPtr__interval;

	// Token: 0x04000D22 RID: 3362
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D23 RID: 3363
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_Int64_0;

	// Token: 0x04000D24 RID: 3364
	private static readonly IntPtr NativeMethodInfoPtr_get_DeviceCode_Public_get_String_0;

	// Token: 0x04000D25 RID: 3365
	private static readonly IntPtr NativeMethodInfoPtr_get_UserCode_Public_get_String_0;

	// Token: 0x04000D26 RID: 3366
	private static readonly IntPtr NativeMethodInfoPtr_get_VerificationUrl_Public_get_String_0;

	// Token: 0x04000D27 RID: 3367
	private static readonly IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0;

	// Token: 0x04000D28 RID: 3368
	private static readonly IntPtr NativeMethodInfoPtr_get_Interval_Public_get_Int64_0;
}
