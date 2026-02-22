using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000044 RID: 68
public class GooglePlayerTemplate : global::Il2CppSystem.Object
{
	// Token: 0x06000579 RID: 1401 RVA: 0x00029BB0 File Offset: 0x00027DB0
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayerTemplate()
	{
		Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayerTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr);
		GooglePlayerTemplate.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_id");
		GooglePlayerTemplate.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_name");
		GooglePlayerTemplate.NativeFieldInfoPtr__iconImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_iconImageUrl");
		GooglePlayerTemplate.NativeFieldInfoPtr__hiResImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_hiResImageUrl");
		GooglePlayerTemplate.NativeFieldInfoPtr__icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_icon");
		GooglePlayerTemplate.NativeFieldInfoPtr__image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_image");
		GooglePlayerTemplate.NativeFieldInfoPtr__hasIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_hasIconImage");
		GooglePlayerTemplate.NativeFieldInfoPtr__hasHiResImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "_hasHiResImage");
		GooglePlayerTemplate.NativeFieldInfoPtr_BigPhotoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "BigPhotoLoaded");
		GooglePlayerTemplate.NativeFieldInfoPtr_SmallPhotoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "SmallPhotoLoaded");
		GooglePlayerTemplate.NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663975);
		GooglePlayerTemplate.NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663976);
		GooglePlayerTemplate.NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663977);
		GooglePlayerTemplate.NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663978);
		GooglePlayerTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663979);
		GooglePlayerTemplate.NativeMethodInfoPtr_LoadImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663980);
		GooglePlayerTemplate.NativeMethodInfoPtr_LoadIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663981);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_playerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663982);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663983);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_hasIconImage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663984);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_hasHiResImage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663985);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_iconImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663986);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_hiResImageUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663987);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663988);
		GooglePlayerTemplate.NativeMethodInfoPtr_get_image_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663989);
		GooglePlayerTemplate.NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663990);
		GooglePlayerTemplate.NativeMethodInfoPtr_OnProfileIconLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, 100663991);
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x00029DFC File Offset: 0x00027FFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166110, XrefRangeEnd = 166114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_BigPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00029E40 File Offset: 0x00028040
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166114, XrefRangeEnd = 166118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_BigPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x00029E84 File Offset: 0x00028084
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166118, XrefRangeEnd = 166122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_SmallPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x00029EC8 File Offset: 0x000280C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166122, XrefRangeEnd = 166126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_SmallPhotoLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x00029F0C File Offset: 0x0002810C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 166197, RefRangeEnd = 166200, XrefRangeStart = 166126, XrefRangeEnd = 166197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayerTemplate(string pId, string pName, string iconUrl, string imageUrl, string pHasIconImage, string pHasHiResImage)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(iconUrl);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imageUrl);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pHasIconImage);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pHasHiResImage);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00029FB4 File Offset: 0x000281B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166200, XrefRangeEnd = 166217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_LoadImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x00029FE8 File Offset: 0x000281E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166217, XrefRangeEnd = 166234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadIcon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_LoadIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000581 RID: 1409 RVA: 0x0002A01C File Offset: 0x0002821C
	public unsafe string playerId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_playerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x06000582 RID: 1410 RVA: 0x0002A054 File Offset: 0x00028254
	public unsafe string name
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000583 RID: 1411 RVA: 0x0002A08C File Offset: 0x0002828C
	public unsafe bool hasIconImage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_hasIconImage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000584 RID: 1412 RVA: 0x0002A0C8 File Offset: 0x000282C8
	public unsafe bool hasHiResImage
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_hasHiResImage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000585 RID: 1413 RVA: 0x0002A104 File Offset: 0x00028304
	public unsafe string iconImageUrl
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_iconImageUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000586 RID: 1414 RVA: 0x0002A13C File Offset: 0x0002833C
	public unsafe string hiResImageUrl
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_hiResImageUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000587 RID: 1415 RVA: 0x0002A174 File Offset: 0x00028374
	public unsafe Texture2D icon
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000588 RID: 1416 RVA: 0x0002A1B4 File Offset: 0x000283B4
	public unsafe Texture2D image
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_get_image_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0002A1F4 File Offset: 0x000283F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166234, XrefRangeEnd = 166237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileImageLoaded(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0002A238 File Offset: 0x00028438
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166237, XrefRangeEnd = 166240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileIconLoaded(Texture2D tex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.NativeMethodInfoPtr_OnProfileIconLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0000426B File Offset: 0x0000246B
	public GooglePlayerTemplate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x0600058C RID: 1420 RVA: 0x0002A27C File Offset: 0x0002847C
	// (set) Token: 0x0600058D RID: 1421 RVA: 0x00004274 File Offset: 0x00002474
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x0600058E RID: 1422 RVA: 0x0002A2A4 File Offset: 0x000284A4
	// (set) Token: 0x0600058F RID: 1423 RVA: 0x00004293 File Offset: 0x00002493
	public unsafe string _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x06000590 RID: 1424 RVA: 0x0002A2CC File Offset: 0x000284CC
	// (set) Token: 0x06000591 RID: 1425 RVA: 0x000042B2 File Offset: 0x000024B2
	public unsafe string _iconImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__iconImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__iconImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002A2F4 File Offset: 0x000284F4
	// (set) Token: 0x06000593 RID: 1427 RVA: 0x000042D1 File Offset: 0x000024D1
	public unsafe string _hiResImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hiResImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hiResImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000594 RID: 1428 RVA: 0x0002A31C File Offset: 0x0002851C
	// (set) Token: 0x06000595 RID: 1429 RVA: 0x000042F0 File Offset: 0x000024F0
	public unsafe Texture2D _icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000596 RID: 1430 RVA: 0x0002A34C File Offset: 0x0002854C
	// (set) Token: 0x06000597 RID: 1431 RVA: 0x0000430F File Offset: 0x0000250F
	public unsafe Texture2D _image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000598 RID: 1432 RVA: 0x0002A37C File Offset: 0x0002857C
	// (set) Token: 0x06000599 RID: 1433 RVA: 0x0000432E File Offset: 0x0000252E
	public unsafe bool _hasIconImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hasIconImage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hasIconImage)) = value;
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x0600059A RID: 1434 RVA: 0x0002A3A4 File Offset: 0x000285A4
	// (set) Token: 0x0600059B RID: 1435 RVA: 0x00004349 File Offset: 0x00002549
	public unsafe bool _hasHiResImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hasHiResImage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr__hasHiResImage)) = value;
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x0600059C RID: 1436 RVA: 0x0002A3CC File Offset: 0x000285CC
	// (set) Token: 0x0600059D RID: 1437 RVA: 0x00004364 File Offset: 0x00002564
	public unsafe Action<Texture2D> BigPhotoLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr_BigPhotoLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr_BigPhotoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x0600059E RID: 1438 RVA: 0x0002A3FC File Offset: 0x000285FC
	// (set) Token: 0x0600059F RID: 1439 RVA: 0x00004383 File Offset: 0x00002583
	public unsafe Action<Texture2D> SmallPhotoLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr_SmallPhotoLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayerTemplate.NativeFieldInfoPtr_SmallPhotoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400049F RID: 1183
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x040004A0 RID: 1184
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x040004A1 RID: 1185
	private static readonly IntPtr NativeFieldInfoPtr__iconImageUrl;

	// Token: 0x040004A2 RID: 1186
	private static readonly IntPtr NativeFieldInfoPtr__hiResImageUrl;

	// Token: 0x040004A3 RID: 1187
	private static readonly IntPtr NativeFieldInfoPtr__icon;

	// Token: 0x040004A4 RID: 1188
	private static readonly IntPtr NativeFieldInfoPtr__image;

	// Token: 0x040004A5 RID: 1189
	private static readonly IntPtr NativeFieldInfoPtr__hasIconImage;

	// Token: 0x040004A6 RID: 1190
	private static readonly IntPtr NativeFieldInfoPtr__hasHiResImage;

	// Token: 0x040004A7 RID: 1191
	private static readonly IntPtr NativeFieldInfoPtr_BigPhotoLoaded;

	// Token: 0x040004A8 RID: 1192
	private static readonly IntPtr NativeFieldInfoPtr_SmallPhotoLoaded;

	// Token: 0x040004A9 RID: 1193
	private static readonly IntPtr NativeMethodInfoPtr_add_BigPhotoLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x040004AA RID: 1194
	private static readonly IntPtr NativeMethodInfoPtr_remove_BigPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x040004AB RID: 1195
	private static readonly IntPtr NativeMethodInfoPtr_add_SmallPhotoLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x040004AC RID: 1196
	private static readonly IntPtr NativeMethodInfoPtr_remove_SmallPhotoLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x040004AD RID: 1197
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_String_0;

	// Token: 0x040004AE RID: 1198
	private static readonly IntPtr NativeMethodInfoPtr_LoadImage_Public_Void_0;

	// Token: 0x040004AF RID: 1199
	private static readonly IntPtr NativeMethodInfoPtr_LoadIcon_Public_Void_0;

	// Token: 0x040004B0 RID: 1200
	private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_String_0;

	// Token: 0x040004B1 RID: 1201
	private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	// Token: 0x040004B2 RID: 1202
	private static readonly IntPtr NativeMethodInfoPtr_get_hasIconImage_Public_get_Boolean_0;

	// Token: 0x040004B3 RID: 1203
	private static readonly IntPtr NativeMethodInfoPtr_get_hasHiResImage_Public_get_Boolean_0;

	// Token: 0x040004B4 RID: 1204
	private static readonly IntPtr NativeMethodInfoPtr_get_iconImageUrl_Public_get_String_0;

	// Token: 0x040004B5 RID: 1205
	private static readonly IntPtr NativeMethodInfoPtr_get_hiResImageUrl_Public_get_String_0;

	// Token: 0x040004B6 RID: 1206
	private static readonly IntPtr NativeMethodInfoPtr_get_icon_Public_get_Texture2D_0;

	// Token: 0x040004B7 RID: 1207
	private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Texture2D_0;

	// Token: 0x040004B8 RID: 1208
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040004B9 RID: 1209
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileIconLoaded_Private_Void_Texture2D_0;

	// Token: 0x02000372 RID: 882
	[ObfuscatedName("GooglePlayerTemplate+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060034C8 RID: 13512 RVA: 0x000DA0E4 File Offset: 0x000D82E4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayerTemplate>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr);
			GooglePlayerTemplate.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, "<>9");
			GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, "<>9__14_0");
			GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, "<>9__14_1");
			GooglePlayerTemplate.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, 100670018);
			GooglePlayerTemplate.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, 100670019);
			GooglePlayerTemplate.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr, 100670020);
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x000DA188 File Offset: 0x000D8388
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayerTemplate.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x000DA1C4 File Offset: 0x000D83C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x000DA208 File Offset: 0x000D8408
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_1(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayerTemplate.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x000148F8 File Offset: 0x00012AF8
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x060034CD RID: 13517 RVA: 0x000DA24C File Offset: 0x000D844C
		// (set) Token: 0x060034CE RID: 13518 RVA: 0x00014901 File Offset: 0x00012B01
		public unsafe static GooglePlayerTemplate.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayerTemplate.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x060034CF RID: 13519 RVA: 0x000DA274 File Offset: 0x000D8474
		// (set) Token: 0x060034D0 RID: 13520 RVA: 0x00014913 File Offset: 0x00012B13
		public unsafe static Action<Texture2D> __9__14_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x000DA29C File Offset: 0x000D849C
		// (set) Token: 0x060034D2 RID: 13522 RVA: 0x00014925 File Offset: 0x00012B25
		public unsafe static Action<Texture2D> __9__14_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayerTemplate.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Internal_Void_Texture2D_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Internal_Void_Texture2D_0;
	}
}
