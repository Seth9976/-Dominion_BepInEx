using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000051 RID: 81
public class GooglePlayConnectionResult : Object
{
	// Token: 0x06000696 RID: 1686 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayConnectionResult()
	{
		Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayConnectionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr);
		GooglePlayConnectionResult.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr, "code");
		GooglePlayConnectionResult.NativeFieldInfoPtr_HasResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr, "HasResolution");
		GooglePlayConnectionResult.NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr, 100664092);
		GooglePlayConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr, 100664093);
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06000697 RID: 1687 RVA: 0x0002D860 File Offset: 0x0002BA60
	public unsafe bool IsSuccess
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 162234, RefRangeEnd = 162266, XrefRangeStart = 162234, XrefRangeEnd = 162266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnectionResult.NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x0002D89C File Offset: 0x0002BA9C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayConnectionResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayConnectionResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayConnectionResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00004B15 File Offset: 0x00002D15
	public GooglePlayConnectionResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x0600069A RID: 1690 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
	// (set) Token: 0x0600069B RID: 1691 RVA: 0x00004B1E File Offset: 0x00002D1E
	public unsafe GP_ConnectionResultCode code
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnectionResult.NativeFieldInfoPtr_code);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnectionResult.NativeFieldInfoPtr_code)) = value;
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x0600069C RID: 1692 RVA: 0x0002D900 File Offset: 0x0002BB00
	// (set) Token: 0x0600069D RID: 1693 RVA: 0x00004B39 File Offset: 0x00002D39
	public unsafe bool HasResolution
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnectionResult.NativeFieldInfoPtr_HasResolution);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayConnectionResult.NativeFieldInfoPtr_HasResolution)) = value;
		}
	}

	// Token: 0x0400055B RID: 1371
	private static readonly IntPtr NativeFieldInfoPtr_code;

	// Token: 0x0400055C RID: 1372
	private static readonly IntPtr NativeFieldInfoPtr_HasResolution;

	// Token: 0x0400055D RID: 1373
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0;

	// Token: 0x0400055E RID: 1374
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
