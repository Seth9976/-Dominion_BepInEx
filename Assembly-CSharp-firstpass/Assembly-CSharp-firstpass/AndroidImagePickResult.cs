using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000F5 RID: 245
public class AndroidImagePickResult : AndroidActivityResult
{
	// Token: 0x0600113A RID: 4410 RVA: 0x00053384 File Offset: 0x00051584
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidImagePickResult()
	{
		Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidImagePickResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr);
		AndroidImagePickResult.NativeFieldInfoPtr__Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, "_Image");
		AndroidImagePickResult.NativeFieldInfoPtr__ImagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, "_ImagePath");
		AndroidImagePickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, 100665398);
		AndroidImagePickResult.NativeMethodInfoPtr_get_image_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, 100665399);
		AndroidImagePickResult.NativeMethodInfoPtr_get_Image_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, 100665400);
		AndroidImagePickResult.NativeMethodInfoPtr_get_ImagePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr, 100665401);
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x0005342C File Offset: 0x0005162C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181531, RefRangeEnd = 181532, XrefRangeStart = 181517, XrefRangeEnd = 181531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidImagePickResult(string codeString, string ImageData, string ImagePathInfo)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidImagePickResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(codeString);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ImageData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ImagePathInfo);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagePickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x0600113C RID: 4412 RVA: 0x0005349C File Offset: 0x0005169C
	public unsafe Texture2D image
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagePickResult.NativeMethodInfoPtr_get_image_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x0600113D RID: 4413 RVA: 0x000534DC File Offset: 0x000516DC
	public unsafe Texture2D Image
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagePickResult.NativeMethodInfoPtr_get_Image_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000521 RID: 1313
	// (get) Token: 0x0600113E RID: 4414 RVA: 0x0005351C File Offset: 0x0005171C
	public unsafe string ImagePath
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagePickResult.NativeMethodInfoPtr_get_ImagePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x000089C7 File Offset: 0x00006BC7
	public AndroidImagePickResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700051D RID: 1309
	// (get) Token: 0x06001140 RID: 4416 RVA: 0x00053554 File Offset: 0x00051754
	// (set) Token: 0x06001141 RID: 4417 RVA: 0x000089D0 File Offset: 0x00006BD0
	public unsafe Texture2D _Image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagePickResult.NativeFieldInfoPtr__Image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagePickResult.NativeFieldInfoPtr__Image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700051E RID: 1310
	// (get) Token: 0x06001142 RID: 4418 RVA: 0x00053584 File Offset: 0x00051784
	// (set) Token: 0x06001143 RID: 4419 RVA: 0x000089EF File Offset: 0x00006BEF
	public unsafe string _ImagePath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagePickResult.NativeFieldInfoPtr__ImagePath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagePickResult.NativeFieldInfoPtr__ImagePath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D63 RID: 3427
	private static readonly IntPtr NativeFieldInfoPtr__Image;

	// Token: 0x04000D64 RID: 3428
	private static readonly IntPtr NativeFieldInfoPtr__ImagePath;

	// Token: 0x04000D65 RID: 3429
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

	// Token: 0x04000D66 RID: 3430
	private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Texture2D_0;

	// Token: 0x04000D67 RID: 3431
	private static readonly IntPtr NativeMethodInfoPtr_get_Image_Public_get_Texture2D_0;

	// Token: 0x04000D68 RID: 3432
	private static readonly IntPtr NativeMethodInfoPtr_get_ImagePath_Public_get_String_0;
}
