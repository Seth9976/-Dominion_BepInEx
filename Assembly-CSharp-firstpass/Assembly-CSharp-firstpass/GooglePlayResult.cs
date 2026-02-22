using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000053 RID: 83
public class GooglePlayResult : Object
{
	// Token: 0x060006A6 RID: 1702 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayResult()
	{
		Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr);
		GooglePlayResult.NativeFieldInfoPtr__response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, "_response");
		GooglePlayResult.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, "_message");
		GooglePlayResult.NativeMethodInfoPtr__ctor_Public_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664098);
		GooglePlayResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664099);
		GooglePlayResult.NativeMethodInfoPtr_SetCode_Private_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664100);
		GooglePlayResult.NativeMethodInfoPtr_get_response_Public_get_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664101);
		GooglePlayResult.NativeMethodInfoPtr_get_Response_Public_get_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664102);
		GooglePlayResult.NativeMethodInfoPtr_get_message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664103);
		GooglePlayResult.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664104);
		GooglePlayResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664105);
		GooglePlayResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664106);
		GooglePlayResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664107);
		GooglePlayResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr, 100664108);
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x0002DC18 File Offset: 0x0002BE18
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 166644, RefRangeEnd = 166652, XrefRangeStart = 166642, XrefRangeEnd = 166644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayResult(GP_GamesStatusCodes code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr__ctor_Public_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x0002DC60 File Offset: 0x0002BE60
	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 166658, RefRangeEnd = 166686, XrefRangeStart = 166652, XrefRangeEnd = 166658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x0002DCAC File Offset: 0x0002BEAC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 166690, RefRangeEnd = 166693, XrefRangeStart = 166686, XrefRangeEnd = 166690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCode(GP_GamesStatusCodes code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_SetCode_Private_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x060006AA RID: 1706 RVA: 0x0002DCEC File Offset: 0x0002BEEC
	public unsafe GP_GamesStatusCodes response
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_response_Public_get_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002DD28 File Offset: 0x0002BF28
	public unsafe GP_GamesStatusCodes Response
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_Response_Public_get_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x060006AC RID: 1708 RVA: 0x0002DD64 File Offset: 0x0002BF64
	public unsafe string message
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002DD9C File Offset: 0x0002BF9C
	public unsafe string Message
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x060006AE RID: 1710 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
	public unsafe bool isSuccess
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 162234, RefRangeEnd = 162266, XrefRangeStart = 162234, XrefRangeEnd = 162266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x060006AF RID: 1711 RVA: 0x0002DE10 File Offset: 0x0002C010
	public unsafe bool IsSucceeded
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 162234, RefRangeEnd = 162266, XrefRangeStart = 162234, XrefRangeEnd = 162266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0002DE4C File Offset: 0x0002C04C
	public unsafe bool isFailure
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002DE88 File Offset: 0x0002C088
	public unsafe bool IsFailed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00004B78 File Offset: 0x00002D78
	public GooglePlayResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
	// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00004B81 File Offset: 0x00002D81
	public unsafe GP_GamesStatusCodes _response
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayResult.NativeFieldInfoPtr__response);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayResult.NativeFieldInfoPtr__response)) = value;
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0002DEEC File Offset: 0x0002C0EC
	// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00004B9C File Offset: 0x00002D9C
	public unsafe string _message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayResult.NativeFieldInfoPtr__message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayResult.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000564 RID: 1380
	private static readonly IntPtr NativeFieldInfoPtr__response;

	// Token: 0x04000565 RID: 1381
	private static readonly IntPtr NativeFieldInfoPtr__message;

	// Token: 0x04000566 RID: 1382
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GP_GamesStatusCodes_0;

	// Token: 0x04000567 RID: 1383
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000568 RID: 1384
	private static readonly IntPtr NativeMethodInfoPtr_SetCode_Private_Void_GP_GamesStatusCodes_0;

	// Token: 0x04000569 RID: 1385
	private static readonly IntPtr NativeMethodInfoPtr_get_response_Public_get_GP_GamesStatusCodes_0;

	// Token: 0x0400056A RID: 1386
	private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_GP_GamesStatusCodes_0;

	// Token: 0x0400056B RID: 1387
	private static readonly IntPtr NativeMethodInfoPtr_get_message_Public_get_String_0;

	// Token: 0x0400056C RID: 1388
	private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

	// Token: 0x0400056D RID: 1389
	private static readonly IntPtr NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0;

	// Token: 0x0400056E RID: 1390
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

	// Token: 0x0400056F RID: 1391
	private static readonly IntPtr NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0;

	// Token: 0x04000570 RID: 1392
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;
}
