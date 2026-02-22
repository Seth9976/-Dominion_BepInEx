using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000E8 RID: 232
public class AN_AccessTokenResult : Result
{
	// Token: 0x060010AC RID: 4268 RVA: 0x00051A04 File Offset: 0x0004FC04
	// Note: this type is marked as 'beforefieldinit'.
	static AN_AccessTokenResult()
	{
		Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_AccessTokenResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr);
		AN_AccessTokenResult.NativeFieldInfoPtr__accessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, "_accessToken");
		AN_AccessTokenResult.NativeFieldInfoPtr__tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, "_tokenType");
		AN_AccessTokenResult.NativeFieldInfoPtr__expiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, "_expiresIn");
		AN_AccessTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, 100665358);
		AN_AccessTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, 100665359);
		AN_AccessTokenResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, 100665360);
		AN_AccessTokenResult.NativeMethodInfoPtr_get_TokenType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, 100665361);
		AN_AccessTokenResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr, 100665362);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00051AD4 File Offset: 0x0004FCD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181397, RefRangeEnd = 181398, XrefRangeStart = 181389, XrefRangeEnd = 181397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_AccessTokenResult(string errorMessage)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AccessTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00051B20 File Offset: 0x0004FD20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181402, RefRangeEnd = 181403, XrefRangeStart = 181398, XrefRangeEnd = 181402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_AccessTokenResult(string accessToken, string tokenType, long expiresIn)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_AccessTokenResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tokenType);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiresIn;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AccessTokenResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x060010AF RID: 4271 RVA: 0x00051B8C File Offset: 0x0004FD8C
	public unsafe string AccessToken
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AccessTokenResult.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00051BC4 File Offset: 0x0004FDC4
	public unsafe string TokenType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AccessTokenResult.NativeMethodInfoPtr_get_TokenType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00051BFC File Offset: 0x0004FDFC
	public unsafe long ExpiresIn
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AccessTokenResult.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x000084CC File Offset: 0x000066CC
	public AN_AccessTokenResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00051C38 File Offset: 0x0004FE38
	// (set) Token: 0x060010B4 RID: 4276 RVA: 0x000084D5 File Offset: 0x000066D5
	public unsafe string _accessToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__accessToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__accessToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00051C60 File Offset: 0x0004FE60
	// (set) Token: 0x060010B6 RID: 4278 RVA: 0x000084F4 File Offset: 0x000066F4
	public unsafe string _tokenType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__tokenType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__tokenType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x060010B7 RID: 4279 RVA: 0x00051C88 File Offset: 0x0004FE88
	// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00008513 File Offset: 0x00006713
	public unsafe long _expiresIn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__expiresIn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_AccessTokenResult.NativeFieldInfoPtr__expiresIn)) = value;
		}
	}

	// Token: 0x04000D15 RID: 3349
	private static readonly IntPtr NativeFieldInfoPtr__accessToken;

	// Token: 0x04000D16 RID: 3350
	private static readonly IntPtr NativeFieldInfoPtr__tokenType;

	// Token: 0x04000D17 RID: 3351
	private static readonly IntPtr NativeFieldInfoPtr__expiresIn;

	// Token: 0x04000D18 RID: 3352
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D19 RID: 3353
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int64_0;

	// Token: 0x04000D1A RID: 3354
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

	// Token: 0x04000D1B RID: 3355
	private static readonly IntPtr NativeMethodInfoPtr_get_TokenType_Public_get_String_0;

	// Token: 0x04000D1C RID: 3356
	private static readonly IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int64_0;
}
