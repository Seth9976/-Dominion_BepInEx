using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000124 RID: 292
public class PermissionsAPIExample : MonoBehaviour
{
	// Token: 0x0600142B RID: 5163 RVA: 0x0005CDA8 File Offset: 0x0005AFA8
	// Note: this type is marked as 'beforefieldinit'.
	static PermissionsAPIExample()
	{
		Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PermissionsAPIExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr);
		PermissionsAPIExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665752);
		PermissionsAPIExample.NativeMethodInfoPtr_CheckPermission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665753);
		PermissionsAPIExample.NativeMethodInfoPtr_RequestPermission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665754);
		PermissionsAPIExample.NativeMethodInfoPtr_CheckShouldRequestPermission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665755);
		PermissionsAPIExample.NativeMethodInfoPtr_HandleActionPermissionsRequestCompleted_Private_Void_AN_GrantPermissionsResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665756);
		PermissionsAPIExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr, 100665757);
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x0005CE50 File Offset: 0x0005B050
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186869, XrefRangeEnd = 186892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x0005CE84 File Offset: 0x0005B084
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186892, XrefRangeEnd = 186927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckPermission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr_CheckPermission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186927, XrefRangeEnd = 186942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestPermission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr_RequestPermission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x0005CEEC File Offset: 0x0005B0EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186942, XrefRangeEnd = 186953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckShouldRequestPermission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr_CheckShouldRequestPermission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x0005CF20 File Offset: 0x0005B120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186953, XrefRangeEnd = 186986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionPermissionsRequestCompleted(AN_GrantPermissionsResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr_HandleActionPermissionsRequestCompleted_Private_Void_AN_GrantPermissionsResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x0005CF64 File Offset: 0x0005B164
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PermissionsAPIExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionsAPIExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionsAPIExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00009D2D File Offset: 0x00007F2D
	public PermissionsAPIExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000F66 RID: 3942
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000F67 RID: 3943
	private static readonly IntPtr NativeMethodInfoPtr_CheckPermission_Public_Void_0;

	// Token: 0x04000F68 RID: 3944
	private static readonly IntPtr NativeMethodInfoPtr_RequestPermission_Public_Void_0;

	// Token: 0x04000F69 RID: 3945
	private static readonly IntPtr NativeMethodInfoPtr_CheckShouldRequestPermission_Public_Void_0;

	// Token: 0x04000F6A RID: 3946
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionPermissionsRequestCompleted_Private_Void_AN_GrantPermissionsResult_0;

	// Token: 0x04000F6B RID: 3947
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
