using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000095 RID: 149
public class FB_PermissionResult : FB_Result
{
	// Token: 0x06000AD4 RID: 2772 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
	// Note: this type is marked as 'beforefieldinit'.
	static FB_PermissionResult()
	{
		Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_PermissionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr);
		FB_PermissionResult.NativeFieldInfoPtr__Permissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr, "_Permissions");
		FB_PermissionResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr, 100664616);
		FB_PermissionResult.NativeMethodInfoPtr_SetPermissions_Public_Void_Dictionary_2_String_FB_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr, 100664617);
		FB_PermissionResult.NativeMethodInfoPtr_get_Permissions_Public_get_Dictionary_2_String_FB_Permission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr, 100664618);
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x0003D244 File Offset: 0x0003B444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173630, XrefRangeEnd = 173631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_PermissionResult(string RawData, string Error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_PermissionResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RawData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PermissionResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x0003D2A4 File Offset: 0x0003B4A4
	[CallerCount(0)]
	public unsafe void SetPermissions(Dictionary<string, FB_Permission> permissions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(permissions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PermissionResult.NativeMethodInfoPtr_SetPermissions_Public_Void_Dictionary_2_String_FB_Permission_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0003D2E8 File Offset: 0x0003B4E8
	public unsafe Dictionary<string, FB_Permission> Permissions
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173631, XrefRangeEnd = 173637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PermissionResult.NativeMethodInfoPtr_get_Permissions_Public_get_Dictionary_2_String_FB_Permission_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Permission>>(intPtr3) : null;
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00006434 File Offset: 0x00004634
	public FB_PermissionResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700036A RID: 874
	// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0003D328 File Offset: 0x0003B528
	// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0000643D File Offset: 0x0000463D
	public unsafe Dictionary<string, FB_Permission> _Permissions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PermissionResult.NativeFieldInfoPtr__Permissions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Permission>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PermissionResult.NativeFieldInfoPtr__Permissions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040008A1 RID: 2209
	private static readonly IntPtr NativeFieldInfoPtr__Permissions;

	// Token: 0x040008A2 RID: 2210
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x040008A3 RID: 2211
	private static readonly IntPtr NativeMethodInfoPtr_SetPermissions_Public_Void_Dictionary_2_String_FB_Permission_0;

	// Token: 0x040008A4 RID: 2212
	private static readonly IntPtr NativeMethodInfoPtr_get_Permissions_Public_get_Dictionary_2_String_FB_Permission_0;
}
