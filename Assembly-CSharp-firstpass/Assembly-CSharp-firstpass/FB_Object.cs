using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000093 RID: 147
public class FB_Object : Object
{
	// Token: 0x06000ABA RID: 2746 RVA: 0x0003CD70 File Offset: 0x0003AF70
	// Note: this type is marked as 'beforefieldinit'.
	static FB_Object()
	{
		Il2CppClassPointerStore<FB_Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_Object");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_Object>.NativeClassPtr);
		FB_Object.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "Id");
		FB_Object.NativeFieldInfoPtr_ImageUrls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "ImageUrls");
		FB_Object.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "Title");
		FB_Object.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "Type");
		FB_Object.NativeFieldInfoPtr_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "CreatedTime");
		FB_Object.NativeFieldInfoPtr_CreatedTimeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, "CreatedTimeString");
		FB_Object.NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, 100664610);
		FB_Object.NativeMethodInfoPtr_AddImageUrl_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, 100664611);
		FB_Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Object>.NativeClassPtr, 100664612);
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x0003CE54 File Offset: 0x0003B054
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173613, RefRangeEnd = 173614, XrefRangeStart = 173609, XrefRangeEnd = 173613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCreatedTime(string time_string)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(time_string);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Object.NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x0003CE98 File Offset: 0x0003B098
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173618, RefRangeEnd = 173619, XrefRangeStart = 173614, XrefRangeEnd = 173618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddImageUrl(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Object.NativeMethodInfoPtr_AddImageUrl_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x0003CEDC File Offset: 0x0003B0DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173626, RefRangeEnd = 173627, XrefRangeStart = 173619, XrefRangeEnd = 173626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Object()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_Object>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000ABE RID: 2750 RVA: 0x00006332 File Offset: 0x00004532
	public FB_Object(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0003CF18 File Offset: 0x0003B118
	// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x0000633B File Offset: 0x0000453B
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0003CF40 File Offset: 0x0003B140
	// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0000635A File Offset: 0x0000455A
	public unsafe List<string> ImageUrls
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_ImageUrls);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_ImageUrls), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0003CF70 File Offset: 0x0003B170
	// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x00006379 File Offset: 0x00004579
	public unsafe string Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0003CF98 File Offset: 0x0003B198
	// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x00006398 File Offset: 0x00004598
	public unsafe string Type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Type);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_Type), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0003CFC0 File Offset: 0x0003B1C0
	// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x000063B7 File Offset: 0x000045B7
	public unsafe DateTime CreatedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_CreatedTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_CreatedTime)) = value;
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0003CFE8 File Offset: 0x0003B1E8
	// (set) Token: 0x06000ACA RID: 2762 RVA: 0x000063D2 File Offset: 0x000045D2
	public unsafe string CreatedTimeString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_CreatedTimeString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Object.NativeFieldInfoPtr_CreatedTimeString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000893 RID: 2195
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x04000894 RID: 2196
	private static readonly IntPtr NativeFieldInfoPtr_ImageUrls;

	// Token: 0x04000895 RID: 2197
	private static readonly IntPtr NativeFieldInfoPtr_Title;

	// Token: 0x04000896 RID: 2198
	private static readonly IntPtr NativeFieldInfoPtr_Type;

	// Token: 0x04000897 RID: 2199
	private static readonly IntPtr NativeFieldInfoPtr_CreatedTime;

	// Token: 0x04000898 RID: 2200
	private static readonly IntPtr NativeFieldInfoPtr_CreatedTimeString;

	// Token: 0x04000899 RID: 2201
	private static readonly IntPtr NativeMethodInfoPtr_SetCreatedTime_Public_Void_String_0;

	// Token: 0x0400089A RID: 2202
	private static readonly IntPtr NativeMethodInfoPtr_AddImageUrl_Public_Void_String_0;

	// Token: 0x0400089B RID: 2203
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
