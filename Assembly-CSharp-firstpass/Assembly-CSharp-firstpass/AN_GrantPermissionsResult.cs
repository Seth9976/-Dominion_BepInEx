using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.Common.Models;

// Token: 0x020000EA RID: 234
public class AN_GrantPermissionsResult : Result
{
	// Token: 0x060010CC RID: 4300 RVA: 0x00052090 File Offset: 0x00050290
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GrantPermissionsResult()
	{
		Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GrantPermissionsResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr);
		AN_GrantPermissionsResult.NativeFieldInfoPtr__RequestedPermissionsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr, "_RequestedPermissionsState");
		AN_GrantPermissionsResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr, 100665370);
		AN_GrantPermissionsResult.NativeMethodInfoPtr_get_RequestedPermissionsState_Public_get_Dictionary_2_AN_Permission_AN_PermissionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr, 100665371);
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x000520FC File Offset: 0x000502FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181438, RefRangeEnd = 181439, XrefRangeStart = 181419, XrefRangeEnd = 181438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GrantPermissionsResult(Il2CppStringArray permissionsList, Il2CppStringArray resultsList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GrantPermissionsResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(permissionsList);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultsList);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GrantPermissionsResult.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x060010CE RID: 4302 RVA: 0x0005215C File Offset: 0x0005035C
	public unsafe Dictionary<AN_Permission, AN_PermissionState> RequestedPermissionsState
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GrantPermissionsResult.NativeMethodInfoPtr_get_RequestedPermissionsState_Public_get_Dictionary_2_AN_Permission_AN_PermissionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AN_Permission, AN_PermissionState>>(intPtr3) : null;
		}
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x000085CA File Offset: 0x000067CA
	public AN_GrantPermissionsResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0005219C File Offset: 0x0005039C
	// (set) Token: 0x060010D1 RID: 4305 RVA: 0x000085D3 File Offset: 0x000067D3
	public unsafe Dictionary<AN_Permission, AN_PermissionState> _RequestedPermissionsState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_GrantPermissionsResult.NativeFieldInfoPtr__RequestedPermissionsState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AN_Permission, AN_PermissionState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AN_GrantPermissionsResult.NativeFieldInfoPtr__RequestedPermissionsState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000D29 RID: 3369
	private static readonly IntPtr NativeFieldInfoPtr__RequestedPermissionsState;

	// Token: 0x04000D2A RID: 3370
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_0;

	// Token: 0x04000D2B RID: 3371
	private static readonly IntPtr NativeMethodInfoPtr_get_RequestedPermissionsState_Public_get_Dictionary_2_AN_Permission_AN_PermissionState_0;
}
