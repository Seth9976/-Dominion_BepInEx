using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000EC RID: 236
public class AN_RefreshTokenResult : Result
{
	// Token: 0x060010D9 RID: 4313 RVA: 0x00052358 File Offset: 0x00050558
	// Note: this type is marked as 'beforefieldinit'.
	static AN_RefreshTokenResult()
	{
		Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_RefreshTokenResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr);
		AN_RefreshTokenResult.NativeFieldInfoPtr__accessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, "_accessToken");
		AN_RefreshTokenResult.NativeFieldInfoPtr__refreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, "_refreshToken");
		AN_RefreshTokenResult.NativeFieldInfoPtr__tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, "_tokenType");
		AN_RefreshTokenResult.NativeFieldInfoPtr__expiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, "_expiresIn");
		AN_RefreshTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665375);
		AN_RefreshTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665376);
		AN_RefreshTokenResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665377);
		AN_RefreshTokenResult.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665378);
		AN_RefreshTokenResult.NativeMethodInfoPtr_get_TokenType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665379);
		AN_RefreshTokenResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr, 100665380);
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00052450 File Offset: 0x00050650
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 181450, RefRangeEnd = 181452, XrefRangeStart = 181441, XrefRangeEnd = 181450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_RefreshTokenResult(string errorMessage)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0005249C File Offset: 0x0005069C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181457, RefRangeEnd = 181458, XrefRangeStart = 181452, XrefRangeEnd = 181457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_RefreshTokenResult(string accessToken, string refreshToken, string tokenType, long expiresIn)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_RefreshTokenResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refreshToken);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenType);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiresIn;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x060010DC RID: 4316 RVA: 0x0005251C File Offset: 0x0005071C
	public unsafe string AccessToken
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x060010DD RID: 4317 RVA: 0x00052554 File Offset: 0x00050754
	public unsafe string RefreshToken
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005258C File Offset: 0x0005078C
	public unsafe string TokenType
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr_get_TokenType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x060010DF RID: 4319 RVA: 0x000525C4 File Offset: 0x000507C4
	public unsafe long ExpiresIn
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_RefreshTokenResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0000861A File Offset: 0x0000681A
	public AN_RefreshTokenResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00052600 File Offset: 0x00050800
	// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00008623 File Offset: 0x00006823
	public unsafe string _accessToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__accessToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__accessToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00052628 File Offset: 0x00050828
	// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00008642 File Offset: 0x00006842
	public unsafe string _refreshToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__refreshToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__refreshToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00052650 File Offset: 0x00050850
	// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00008661 File Offset: 0x00006861
	public unsafe string _tokenType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__tokenType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__tokenType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x060010E7 RID: 4327 RVA: 0x00052678 File Offset: 0x00050878
	// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00008680 File Offset: 0x00006880
	public unsafe long _expiresIn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__expiresIn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_RefreshTokenResult.NativeFieldInfoPtr__expiresIn)) = value;
		}
	}

	// Token: 0x04000D30 RID: 3376
	private static readonly IntPtr NativeFieldInfoPtr__accessToken;

	// Token: 0x04000D31 RID: 3377
	private static readonly IntPtr NativeFieldInfoPtr__refreshToken;

	// Token: 0x04000D32 RID: 3378
	private static readonly IntPtr NativeFieldInfoPtr__tokenType;

	// Token: 0x04000D33 RID: 3379
	private static readonly IntPtr NativeFieldInfoPtr__expiresIn;

	// Token: 0x04000D34 RID: 3380
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D35 RID: 3381
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int64_0;

	// Token: 0x04000D36 RID: 3382
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

	// Token: 0x04000D37 RID: 3383
	private static readonly IntPtr NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0;

	// Token: 0x04000D38 RID: 3384
	private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_get_String_0;

	// Token: 0x04000D39 RID: 3385
	private static readonly IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0;
}
