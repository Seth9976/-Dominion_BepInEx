using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000094 RID: 148
public class FB_Permission : Object
{
	// Token: 0x06000ACB RID: 2763 RVA: 0x0003D010 File Offset: 0x0003B210
	// Note: this type is marked as 'beforefieldinit'.
	static FB_Permission()
	{
		Il2CppClassPointerStore<FB_Permission>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_Permission");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr);
		FB_Permission.NativeFieldInfoPtr__Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr, "_Name");
		FB_Permission.NativeFieldInfoPtr__Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr, "_Status");
		FB_Permission.NativeMethodInfoPtr__ctor_Public_Void_String_FB_PermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr, 100664613);
		FB_Permission.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr, 100664614);
		FB_Permission.NativeMethodInfoPtr_get_Status_Public_get_FB_PermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr, 100664615);
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0003D0A4 File Offset: 0x0003B2A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173627, XrefRangeEnd = 173630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Permission(string permission, FB_PermissionStatus status)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_Permission>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(permission);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Permission.NativeMethodInfoPtr__ctor_Public_Void_String_FB_PermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0003D100 File Offset: 0x0003B300
	public unsafe string Name
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Permission.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000369 RID: 873
	// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0003D138 File Offset: 0x0003B338
	public unsafe FB_PermissionStatus Status
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Permission.NativeMethodInfoPtr_get_Status_Public_get_FB_PermissionStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x000063F1 File Offset: 0x000045F1
	public FB_Permission(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0003D174 File Offset: 0x0003B374
	// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x000063FA File Offset: 0x000045FA
	public unsafe string _Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Permission.NativeFieldInfoPtr__Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Permission.NativeFieldInfoPtr__Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0003D19C File Offset: 0x0003B39C
	// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00006419 File Offset: 0x00004619
	public unsafe FB_PermissionStatus _Status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Permission.NativeFieldInfoPtr__Status);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Permission.NativeFieldInfoPtr__Status)) = value;
		}
	}

	// Token: 0x0400089C RID: 2204
	private static readonly IntPtr NativeFieldInfoPtr__Name;

	// Token: 0x0400089D RID: 2205
	private static readonly IntPtr NativeFieldInfoPtr__Status;

	// Token: 0x0400089E RID: 2206
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FB_PermissionStatus_0;

	// Token: 0x0400089F RID: 2207
	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	// Token: 0x040008A0 RID: 2208
	private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_FB_PermissionStatus_0;
}
