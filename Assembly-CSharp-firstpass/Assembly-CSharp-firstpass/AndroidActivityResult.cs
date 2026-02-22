using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004E RID: 78
public class AndroidActivityResult : Object
{
	// Token: 0x06000680 RID: 1664 RVA: 0x0002D3AC File Offset: 0x0002B5AC
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidActivityResult()
	{
		Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidActivityResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr);
		AndroidActivityResult.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, "_code");
		AndroidActivityResult.NativeFieldInfoPtr__requestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, "_requestId");
		AndroidActivityResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, 100664084);
		AndroidActivityResult.NativeMethodInfoPtr_get_code_Public_get_AdroidActivityResultCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, 100664085);
		AndroidActivityResult.NativeMethodInfoPtr_get_requestId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, 100664086);
		AndroidActivityResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, 100664087);
		AndroidActivityResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr, 100664088);
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x0002D468 File Offset: 0x0002B668
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 166620, RefRangeEnd = 166626, XrefRangeStart = 166614, XrefRangeEnd = 166620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidActivityResult(string rId, string codeString)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidActivityResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(rId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(codeString);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidActivityResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06000682 RID: 1666 RVA: 0x0002D4C8 File Offset: 0x0002B6C8
	public unsafe AdroidActivityResultCodes code
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidActivityResult.NativeMethodInfoPtr_get_code_Public_get_AdroidActivityResultCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002D504 File Offset: 0x0002B704
	public unsafe int requestId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidActivityResult.NativeMethodInfoPtr_get_requestId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06000684 RID: 1668 RVA: 0x0002D540 File Offset: 0x0002B740
	public unsafe bool IsSucceeded
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166626, RefRangeEnd = 166631, XrefRangeStart = 166626, XrefRangeEnd = 166626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidActivityResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002D57C File Offset: 0x0002B77C
	public unsafe bool IsFailed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidActivityResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00004A8E File Offset: 0x00002C8E
	public AndroidActivityResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002D5B8 File Offset: 0x0002B7B8
	// (set) Token: 0x06000688 RID: 1672 RVA: 0x00004A97 File Offset: 0x00002C97
	public unsafe AdroidActivityResultCodes _code
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidActivityResult.NativeFieldInfoPtr__code);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidActivityResult.NativeFieldInfoPtr__code)) = value;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002D5E0 File Offset: 0x0002B7E0
	// (set) Token: 0x0600068A RID: 1674 RVA: 0x00004AB2 File Offset: 0x00002CB2
	public unsafe int _requestId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidActivityResult.NativeFieldInfoPtr__requestId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidActivityResult.NativeFieldInfoPtr__requestId)) = value;
		}
	}

	// Token: 0x0400054F RID: 1359
	private static readonly IntPtr NativeFieldInfoPtr__code;

	// Token: 0x04000550 RID: 1360
	private static readonly IntPtr NativeFieldInfoPtr__requestId;

	// Token: 0x04000551 RID: 1361
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x04000552 RID: 1362
	private static readonly IntPtr NativeMethodInfoPtr_get_code_Public_get_AdroidActivityResultCodes_0;

	// Token: 0x04000553 RID: 1363
	private static readonly IntPtr NativeMethodInfoPtr_get_requestId_Public_get_Int32_0;

	// Token: 0x04000554 RID: 1364
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

	// Token: 0x04000555 RID: 1365
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;
}
