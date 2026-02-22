using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000ED RID: 237
public class GallerySaveResult : Result
{
	// Token: 0x060010E9 RID: 4329 RVA: 0x000526A0 File Offset: 0x000508A0
	// Note: this type is marked as 'beforefieldinit'.
	static GallerySaveResult()
	{
		Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GallerySaveResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr);
		GallerySaveResult.NativeFieldInfoPtr__imagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr, "_imagePath");
		GallerySaveResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr, 100665381);
		GallerySaveResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr, 100665382);
		GallerySaveResult.NativeMethodInfoPtr_get_imagePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr, 100665383);
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00052720 File Offset: 0x00050920
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40954, RefRangeEnd = 40956, XrefRangeStart = 40954, XrefRangeEnd = 40956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GallerySaveResult(string path)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GallerySaveResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x0005276C File Offset: 0x0005096C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181463, RefRangeEnd = 181464, XrefRangeStart = 181458, XrefRangeEnd = 181463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GallerySaveResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GallerySaveResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GallerySaveResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x060010EC RID: 4332 RVA: 0x000527A8 File Offset: 0x000509A8
	public unsafe string imagePath
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GallerySaveResult.NativeMethodInfoPtr_get_imagePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x0000869B File Offset: 0x0000689B
	public GallerySaveResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x060010EE RID: 4334 RVA: 0x000527E0 File Offset: 0x000509E0
	// (set) Token: 0x060010EF RID: 4335 RVA: 0x000086A4 File Offset: 0x000068A4
	public unsafe string _imagePath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GallerySaveResult.NativeFieldInfoPtr__imagePath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GallerySaveResult.NativeFieldInfoPtr__imagePath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D3A RID: 3386
	private static readonly IntPtr NativeFieldInfoPtr__imagePath;

	// Token: 0x04000D3B RID: 3387
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000D3C RID: 3388
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000D3D RID: 3389
	private static readonly IntPtr NativeMethodInfoPtr_get_imagePath_Public_get_String_0;
}
