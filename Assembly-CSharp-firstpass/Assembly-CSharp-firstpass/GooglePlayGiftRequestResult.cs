using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000052 RID: 82
public class GooglePlayGiftRequestResult : Object
{
	// Token: 0x0600069E RID: 1694 RVA: 0x0002D928 File Offset: 0x0002BB28
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayGiftRequestResult()
	{
		Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayGiftRequestResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr);
		GooglePlayGiftRequestResult.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr, "_code");
		GooglePlayGiftRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr, 100664094);
		GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_code_Public_get_GP_GamesActivityResultCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr, 100664095);
		GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr, 100664096);
		GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr, 100664097);
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x0002D9BC File Offset: 0x0002BBBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166637, XrefRangeEnd = 166642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayGiftRequestResult(string r_code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayGiftRequestResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(r_code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayGiftRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0002DA08 File Offset: 0x0002BC08
	public unsafe GP_GamesActivityResultCodes code
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_code_Public_get_GP_GamesActivityResultCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0002DA44 File Offset: 0x0002BC44
	public unsafe bool isSuccess
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166626, RefRangeEnd = 166631, XrefRangeStart = 166626, XrefRangeEnd = 166631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0002DA80 File Offset: 0x0002BC80
	public unsafe bool isFailure
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayGiftRequestResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006A3 RID: 1699 RVA: 0x00004B54 File Offset: 0x00002D54
	public GooglePlayGiftRequestResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0002DABC File Offset: 0x0002BCBC
	// (set) Token: 0x060006A5 RID: 1701 RVA: 0x00004B5D File Offset: 0x00002D5D
	public unsafe GP_GamesActivityResultCodes _code
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayGiftRequestResult.NativeFieldInfoPtr__code);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayGiftRequestResult.NativeFieldInfoPtr__code)) = value;
		}
	}

	// Token: 0x0400055F RID: 1375
	private static readonly IntPtr NativeFieldInfoPtr__code;

	// Token: 0x04000560 RID: 1376
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000561 RID: 1377
	private static readonly IntPtr NativeMethodInfoPtr_get_code_Public_get_GP_GamesActivityResultCodes_0;

	// Token: 0x04000562 RID: 1378
	private static readonly IntPtr NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0;

	// Token: 0x04000563 RID: 1379
	private static readonly IntPtr NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0;
}
