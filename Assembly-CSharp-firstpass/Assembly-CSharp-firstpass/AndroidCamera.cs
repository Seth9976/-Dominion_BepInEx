using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000D8 RID: 216
public class AndroidCamera : Singleton<AndroidCamera>
{
	// Token: 0x06000F44 RID: 3908 RVA: 0x0004C928 File Offset: 0x0004AB28
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidCamera()
	{
		Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidCamera");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr);
		AndroidCamera.NativeFieldInfoPtr_OnImagePicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "OnImagePicked");
		AndroidCamera.NativeFieldInfoPtr_OnImagesPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "OnImagesPicked");
		AndroidCamera.NativeFieldInfoPtr_OnVideoPicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "OnVideoPicked");
		AndroidCamera.NativeFieldInfoPtr_OnImageSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "OnImageSaved");
		AndroidCamera.NativeFieldInfoPtr__lastImageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "_lastImageName");
		AndroidCamera.NativeMethodInfoPtr_add_OnImagePicked_Public_add_Void_Action_1_AndroidImagePickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665170);
		AndroidCamera.NativeMethodInfoPtr_remove_OnImagePicked_Public_rem_Void_Action_1_AndroidImagePickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665171);
		AndroidCamera.NativeMethodInfoPtr_add_OnImagesPicked_Public_add_Void_Action_1_AndroidImagesPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665172);
		AndroidCamera.NativeMethodInfoPtr_remove_OnImagesPicked_Public_rem_Void_Action_1_AndroidImagesPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665173);
		AndroidCamera.NativeMethodInfoPtr_add_OnVideoPicked_Public_add_Void_Action_1_AndroidVideoPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665174);
		AndroidCamera.NativeMethodInfoPtr_remove_OnVideoPicked_Public_rem_Void_Action_1_AndroidVideoPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665175);
		AndroidCamera.NativeMethodInfoPtr_add_OnImageSaved_Public_add_Void_Action_1_GallerySaveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665176);
		AndroidCamera.NativeMethodInfoPtr_remove_OnImageSaved_Public_rem_Void_Action_1_GallerySaveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665177);
		AndroidCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665178);
		AndroidCamera.NativeMethodInfoPtr_SaveImageToGalalry_Public_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665179);
		AndroidCamera.NativeMethodInfoPtr_SaveImageToGallery_Public_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665180);
		AndroidCamera.NativeMethodInfoPtr_SaveScreenshotToGallery_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665181);
		AndroidCamera.NativeMethodInfoPtr_GetVideoFromGallery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665182);
		AndroidCamera.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665183);
		AndroidCamera.NativeMethodInfoPtr_GetImagesFromGallery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665184);
		AndroidCamera.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665185);
		AndroidCamera.NativeMethodInfoPtr_OnVideoPickedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665186);
		AndroidCamera.NativeMethodInfoPtr_OnImagePickedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665187);
		AndroidCamera.NativeMethodInfoPtr_ImagesPickedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665188);
		AndroidCamera.NativeMethodInfoPtr_OnImageSavedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665189);
		AndroidCamera.NativeMethodInfoPtr_OnImageSaveFailedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665190);
		AndroidCamera.NativeMethodInfoPtr_OnScreenshotReady_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665191);
		AndroidCamera.NativeMethodInfoPtr_GetRandomString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665192);
		AndroidCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, 100665193);
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x0004CB9C File Offset: 0x0004AD9C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 179324, RefRangeEnd = 179328, XrefRangeStart = 179320, XrefRangeEnd = 179324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnImagePicked(Action<AndroidImagePickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_add_OnImagePicked_Public_add_Void_Action_1_AndroidImagePickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x0004CBE0 File Offset: 0x0004ADE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179332, RefRangeEnd = 179333, XrefRangeStart = 179328, XrefRangeEnd = 179332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnImagePicked(Action<AndroidImagePickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_remove_OnImagePicked_Public_rem_Void_Action_1_AndroidImagePickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x0004CC24 File Offset: 0x0004AE24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179333, XrefRangeEnd = 179337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnImagesPicked(Action<AndroidImagesPickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_add_OnImagesPicked_Public_add_Void_Action_1_AndroidImagesPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x0004CC68 File Offset: 0x0004AE68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179337, XrefRangeEnd = 179341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnImagesPicked(Action<AndroidImagesPickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_remove_OnImagesPicked_Public_rem_Void_Action_1_AndroidImagesPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x0004CCAC File Offset: 0x0004AEAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179345, RefRangeEnd = 179346, XrefRangeStart = 179341, XrefRangeEnd = 179345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnVideoPicked(Action<AndroidVideoPickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_add_OnVideoPicked_Public_add_Void_Action_1_AndroidVideoPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179350, RefRangeEnd = 179351, XrefRangeStart = 179346, XrefRangeEnd = 179350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnVideoPicked(Action<AndroidVideoPickResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_remove_OnVideoPicked_Public_rem_Void_Action_1_AndroidVideoPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x0004CD34 File Offset: 0x0004AF34
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 179355, RefRangeEnd = 179359, XrefRangeStart = 179351, XrefRangeEnd = 179355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnImageSaved(Action<GallerySaveResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_add_OnImageSaved_Public_add_Void_Action_1_GallerySaveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x0004CD78 File Offset: 0x0004AF78
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179363, RefRangeEnd = 179364, XrefRangeStart = 179359, XrefRangeEnd = 179363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnImageSaved(Action<GallerySaveResult> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_remove_OnImageSaved_Public_rem_Void_Action_1_GallerySaveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0004CDBC File Offset: 0x0004AFBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179364, XrefRangeEnd = 179377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x0004CDF0 File Offset: 0x0004AFF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179377, XrefRangeEnd = 179378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveImageToGalalry(Texture2D image, string name = "Screenshot")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_SaveImageToGalalry_Public_Void_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x0004CE44 File Offset: 0x0004B044
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 179394, RefRangeEnd = 179398, XrefRangeStart = 179378, XrefRangeEnd = 179394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveImageToGallery(Texture2D image, string name = "Screenshot")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_SaveImageToGallery_Public_Void_Texture2D_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x0004CE98 File Offset: 0x0004B098
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179415, RefRangeEnd = 179416, XrefRangeStart = 179398, XrefRangeEnd = 179415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveScreenshotToGallery(string name = "Screenshot")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_SaveScreenshotToGallery_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x0004CEDC File Offset: 0x0004B0DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179417, RefRangeEnd = 179418, XrefRangeStart = 179416, XrefRangeEnd = 179417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVideoFromGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_GetVideoFromGallery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x0004CF10 File Offset: 0x0004B110
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179419, RefRangeEnd = 179420, XrefRangeStart = 179418, XrefRangeEnd = 179419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0004CF44 File Offset: 0x0004B144
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179420, XrefRangeEnd = 179421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImagesFromGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_GetImagesFromGallery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0004CF78 File Offset: 0x0004B178
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 179427, RefRangeEnd = 179428, XrefRangeStart = 179421, XrefRangeEnd = 179427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0004CFAC File Offset: 0x0004B1AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179428, XrefRangeEnd = 179452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVideoPickedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_OnVideoPickedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179452, XrefRangeEnd = 179481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImagePickedEvent(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_OnImagePickedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0004D034 File Offset: 0x0004B234
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179481, XrefRangeEnd = 179511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ImagesPickedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_ImagesPickedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0004D078 File Offset: 0x0004B278
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179511, XrefRangeEnd = 179519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImageSavedEvent(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_OnImageSavedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0004D0BC File Offset: 0x0004B2BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179519, XrefRangeEnd = 179527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImageSaveFailedEvent(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_OnImageSaveFailedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0004D100 File Offset: 0x0004B300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179527, XrefRangeEnd = 179532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScreenshotReady(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_OnScreenshotReady_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x0004D144 File Offset: 0x0004B344
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 179554, RefRangeEnd = 179558, XrefRangeStart = 179532, XrefRangeEnd = 179554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRandomString()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr_GetRandomString_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x0004D170 File Offset: 0x0004B370
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179558, XrefRangeEnd = 179622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidCamera()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00007D02 File Offset: 0x00005F02
	public AndroidCamera(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000488 RID: 1160
	// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0004D1AC File Offset: 0x0004B3AC
	// (set) Token: 0x06000F5F RID: 3935 RVA: 0x00007D0B File Offset: 0x00005F0B
	public unsafe Action<AndroidImagePickResult> OnImagePicked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImagePicked);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidImagePickResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImagePicked), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000489 RID: 1161
	// (get) Token: 0x06000F60 RID: 3936 RVA: 0x0004D1DC File Offset: 0x0004B3DC
	// (set) Token: 0x06000F61 RID: 3937 RVA: 0x00007D2A File Offset: 0x00005F2A
	public unsafe Action<AndroidImagesPickResult> OnImagesPicked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImagesPicked);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidImagesPickResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImagesPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700048A RID: 1162
	// (get) Token: 0x06000F62 RID: 3938 RVA: 0x0004D20C File Offset: 0x0004B40C
	// (set) Token: 0x06000F63 RID: 3939 RVA: 0x00007D49 File Offset: 0x00005F49
	public unsafe Action<AndroidVideoPickResult> OnVideoPicked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnVideoPicked);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidVideoPickResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnVideoPicked), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700048B RID: 1163
	// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0004D23C File Offset: 0x0004B43C
	// (set) Token: 0x06000F65 RID: 3941 RVA: 0x00007D68 File Offset: 0x00005F68
	public unsafe Action<GallerySaveResult> OnImageSaved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImageSaved);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GallerySaveResult>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidCamera.NativeFieldInfoPtr_OnImageSaved), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700048C RID: 1164
	// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0004D26C File Offset: 0x0004B46C
	// (set) Token: 0x06000F67 RID: 3943 RVA: 0x00007D87 File Offset: 0x00005F87
	public unsafe static string _lastImageName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidCamera.NativeFieldInfoPtr__lastImageName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidCamera.NativeFieldInfoPtr__lastImageName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000C13 RID: 3091
	private static readonly IntPtr NativeFieldInfoPtr_OnImagePicked;

	// Token: 0x04000C14 RID: 3092
	private static readonly IntPtr NativeFieldInfoPtr_OnImagesPicked;

	// Token: 0x04000C15 RID: 3093
	private static readonly IntPtr NativeFieldInfoPtr_OnVideoPicked;

	// Token: 0x04000C16 RID: 3094
	private static readonly IntPtr NativeFieldInfoPtr_OnImageSaved;

	// Token: 0x04000C17 RID: 3095
	private static readonly IntPtr NativeFieldInfoPtr__lastImageName;

	// Token: 0x04000C18 RID: 3096
	private static readonly IntPtr NativeMethodInfoPtr_add_OnImagePicked_Public_add_Void_Action_1_AndroidImagePickResult_0;

	// Token: 0x04000C19 RID: 3097
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnImagePicked_Public_rem_Void_Action_1_AndroidImagePickResult_0;

	// Token: 0x04000C1A RID: 3098
	private static readonly IntPtr NativeMethodInfoPtr_add_OnImagesPicked_Public_add_Void_Action_1_AndroidImagesPickResult_0;

	// Token: 0x04000C1B RID: 3099
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnImagesPicked_Public_rem_Void_Action_1_AndroidImagesPickResult_0;

	// Token: 0x04000C1C RID: 3100
	private static readonly IntPtr NativeMethodInfoPtr_add_OnVideoPicked_Public_add_Void_Action_1_AndroidVideoPickResult_0;

	// Token: 0x04000C1D RID: 3101
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnVideoPicked_Public_rem_Void_Action_1_AndroidVideoPickResult_0;

	// Token: 0x04000C1E RID: 3102
	private static readonly IntPtr NativeMethodInfoPtr_add_OnImageSaved_Public_add_Void_Action_1_GallerySaveResult_0;

	// Token: 0x04000C1F RID: 3103
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnImageSaved_Public_rem_Void_Action_1_GallerySaveResult_0;

	// Token: 0x04000C20 RID: 3104
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C21 RID: 3105
	private static readonly IntPtr NativeMethodInfoPtr_SaveImageToGalalry_Public_Void_Texture2D_String_0;

	// Token: 0x04000C22 RID: 3106
	private static readonly IntPtr NativeMethodInfoPtr_SaveImageToGallery_Public_Void_Texture2D_String_0;

	// Token: 0x04000C23 RID: 3107
	private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshotToGallery_Public_Void_String_0;

	// Token: 0x04000C24 RID: 3108
	private static readonly IntPtr NativeMethodInfoPtr_GetVideoFromGallery_Public_Void_0;

	// Token: 0x04000C25 RID: 3109
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0;

	// Token: 0x04000C26 RID: 3110
	private static readonly IntPtr NativeMethodInfoPtr_GetImagesFromGallery_Public_Void_0;

	// Token: 0x04000C27 RID: 3111
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0;

	// Token: 0x04000C28 RID: 3112
	private static readonly IntPtr NativeMethodInfoPtr_OnVideoPickedCallback_Private_Void_String_0;

	// Token: 0x04000C29 RID: 3113
	private static readonly IntPtr NativeMethodInfoPtr_OnImagePickedEvent_Private_Void_String_0;

	// Token: 0x04000C2A RID: 3114
	private static readonly IntPtr NativeMethodInfoPtr_ImagesPickedCallback_Private_Void_String_0;

	// Token: 0x04000C2B RID: 3115
	private static readonly IntPtr NativeMethodInfoPtr_OnImageSavedEvent_Private_Void_String_0;

	// Token: 0x04000C2C RID: 3116
	private static readonly IntPtr NativeMethodInfoPtr_OnImageSaveFailedEvent_Private_Void_String_0;

	// Token: 0x04000C2D RID: 3117
	private static readonly IntPtr NativeMethodInfoPtr_OnScreenshotReady_Private_Void_Texture2D_0;

	// Token: 0x04000C2E RID: 3118
	private static readonly IntPtr NativeMethodInfoPtr_GetRandomString_Public_Static_String_0;

	// Token: 0x04000C2F RID: 3119
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200038E RID: 910
	[ObfuscatedName("AndroidCamera+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003614 RID: 13844 RVA: 0x000DE454 File Offset: 0x000DC654
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidCamera>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr);
			AndroidCamera.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, "<>9");
			AndroidCamera.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, "<>9__28_0");
			AndroidCamera.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, "<>9__28_1");
			AndroidCamera.__c.NativeFieldInfoPtr___9__28_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, "<>9__28_2");
			AndroidCamera.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, "<>9__28_3");
			AndroidCamera.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, 100670185);
			AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_AndroidImagePickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, 100670186);
			AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_AndroidImagesPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, 100670187);
			AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_AndroidVideoPickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, 100670188);
			AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_3_Internal_Void_GallerySaveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr, 100670189);
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x000DE548 File Offset: 0x000DC748
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidCamera.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x000DE584 File Offset: 0x000DC784
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__28_0(AndroidImagePickResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_AndroidImagePickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x000DE5C8 File Offset: 0x000DC7C8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__28_1(AndroidImagesPickResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_AndroidImagesPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x000DE60C File Offset: 0x000DC80C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__28_2(AndroidVideoPickResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_AndroidVideoPickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x000DE650 File Offset: 0x000DC850
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__28_3(GallerySaveResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidCamera.__c.NativeMethodInfoPtr___ctor_b__28_3_Internal_Void_GallerySaveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00014F3D File Offset: 0x0001313D
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x000DE694 File Offset: 0x000DC894
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x00014F46 File Offset: 0x00013146
		public unsafe static AndroidCamera.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidCamera.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidCamera.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidCamera.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x000DE6BC File Offset: 0x000DC8BC
		// (set) Token: 0x0600361E RID: 13854 RVA: 0x00014F58 File Offset: 0x00013158
		public unsafe static Action<AndroidImagePickResult> __9__28_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidImagePickResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x000DE6E4 File Offset: 0x000DC8E4
		// (set) Token: 0x06003620 RID: 13856 RVA: 0x00014F6A File Offset: 0x0001316A
		public unsafe static Action<AndroidImagesPickResult> __9__28_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidImagesPickResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x000DE70C File Offset: 0x000DC90C
		// (set) Token: 0x06003622 RID: 13858 RVA: 0x00014F7C File Offset: 0x0001317C
		public unsafe static Action<AndroidVideoPickResult> __9__28_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidVideoPickResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000DE734 File Offset: 0x000DC934
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x00014F8E File Offset: 0x0001318E
		public unsafe static Action<GallerySaveResult> __9__28_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GallerySaveResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidCamera.__c.NativeFieldInfoPtr___9__28_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeFieldInfoPtr___9__28_2;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeFieldInfoPtr___9__28_3;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_0_Internal_Void_AndroidImagePickResult_0;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_1_Internal_Void_AndroidImagesPickResult_0;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_2_Internal_Void_AndroidVideoPickResult_0;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__28_3_Internal_Void_GallerySaveResult_0;
	}
}
