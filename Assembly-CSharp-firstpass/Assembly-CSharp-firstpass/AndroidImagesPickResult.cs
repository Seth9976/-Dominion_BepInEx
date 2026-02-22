using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000F6 RID: 246
public class AndroidImagesPickResult : AndroidActivityResult
{
	// Token: 0x06001144 RID: 4420 RVA: 0x000535AC File Offset: 0x000517AC
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidImagesPickResult()
	{
		Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidImagesPickResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr);
		AndroidImagesPickResult.NativeFieldInfoPtr__Images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr, "_Images");
		AndroidImagesPickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr, 100665402);
		AndroidImagesPickResult.NativeMethodInfoPtr_get_Images_Public_get_Dictionary_2_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr, 100665403);
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00053618 File Offset: 0x00051818
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181565, RefRangeEnd = 181566, XrefRangeStart = 181532, XrefRangeEnd = 181565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidImagesPickResult(string resultCode, string imagesData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidImagesPickResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resultCode);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imagesData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagesPickResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000523 RID: 1315
	// (get) Token: 0x06001146 RID: 4422 RVA: 0x00053678 File Offset: 0x00051878
	public unsafe Dictionary<string, Texture2D> Images
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidImagesPickResult.NativeMethodInfoPtr_get_Images_Public_get_Dictionary_2_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Texture2D>>(intPtr3) : null;
		}
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00008A0E File Offset: 0x00006C0E
	public AndroidImagesPickResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000522 RID: 1314
	// (get) Token: 0x06001148 RID: 4424 RVA: 0x000536B8 File Offset: 0x000518B8
	// (set) Token: 0x06001149 RID: 4425 RVA: 0x00008A17 File Offset: 0x00006C17
	public unsafe Dictionary<string, Texture2D> _Images
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagesPickResult.NativeFieldInfoPtr__Images);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidImagesPickResult.NativeFieldInfoPtr__Images), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D69 RID: 3433
	private static readonly IntPtr NativeFieldInfoPtr__Images;

	// Token: 0x04000D6A RID: 3434
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x04000D6B RID: 3435
	private static readonly IntPtr NativeMethodInfoPtr_get_Images_Public_get_Dictionary_2_String_Texture2D_0;
}
