using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000E2 RID: 226
public class PackageAppInfo : MonoBehaviour
{
	// Token: 0x06001023 RID: 4131 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
	// Note: this type is marked as 'beforefieldinit'.
	static PackageAppInfo()
	{
		Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PackageAppInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr);
		PackageAppInfo.NativeFieldInfoPtr_versionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "versionName");
		PackageAppInfo.NativeFieldInfoPtr_versionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "versionCode");
		PackageAppInfo.NativeFieldInfoPtr_packageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "packageName");
		PackageAppInfo.NativeFieldInfoPtr_sharedUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "sharedUserId");
		PackageAppInfo.NativeFieldInfoPtr_sharedUserLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "sharedUserLabel");
		PackageAppInfo.NativeFieldInfoPtr_lastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, "lastUpdateTime");
		PackageAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr, 100665302);
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0004FF74 File Offset: 0x0004E174
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PackageAppInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackageAppInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackageAppInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00008113 File Offset: 0x00006313
	public PackageAppInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
	// (set) Token: 0x06001027 RID: 4135 RVA: 0x0000811C File Offset: 0x0000631C
	public unsafe string versionName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_versionName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_versionName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004FFD8 File Offset: 0x0004E1D8
	// (set) Token: 0x06001029 RID: 4137 RVA: 0x0000813B File Offset: 0x0000633B
	public unsafe string versionCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_versionCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_versionCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B2 RID: 1202
	// (get) Token: 0x0600102A RID: 4138 RVA: 0x00050000 File Offset: 0x0004E200
	// (set) Token: 0x0600102B RID: 4139 RVA: 0x0000815A File Offset: 0x0000635A
	public unsafe string packageName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_packageName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_packageName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x0600102C RID: 4140 RVA: 0x00050028 File Offset: 0x0004E228
	// (set) Token: 0x0600102D RID: 4141 RVA: 0x00008179 File Offset: 0x00006379
	public unsafe string sharedUserId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_sharedUserId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_sharedUserId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x0600102E RID: 4142 RVA: 0x00050050 File Offset: 0x0004E250
	// (set) Token: 0x0600102F RID: 4143 RVA: 0x00008198 File Offset: 0x00006398
	public unsafe string sharedUserLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_sharedUserLabel);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_sharedUserLabel), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004B5 RID: 1205
	// (get) Token: 0x06001030 RID: 4144 RVA: 0x00050078 File Offset: 0x0004E278
	// (set) Token: 0x06001031 RID: 4145 RVA: 0x000081B7 File Offset: 0x000063B7
	public unsafe long lastUpdateTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_lastUpdateTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackageAppInfo.NativeFieldInfoPtr_lastUpdateTime)) = value;
		}
	}

	// Token: 0x04000CBB RID: 3259
	private static readonly IntPtr NativeFieldInfoPtr_versionName;

	// Token: 0x04000CBC RID: 3260
	private static readonly IntPtr NativeFieldInfoPtr_versionCode;

	// Token: 0x04000CBD RID: 3261
	private static readonly IntPtr NativeFieldInfoPtr_packageName;

	// Token: 0x04000CBE RID: 3262
	private static readonly IntPtr NativeFieldInfoPtr_sharedUserId;

	// Token: 0x04000CBF RID: 3263
	private static readonly IntPtr NativeFieldInfoPtr_sharedUserLabel;

	// Token: 0x04000CC0 RID: 3264
	private static readonly IntPtr NativeFieldInfoPtr_lastUpdateTime;

	// Token: 0x04000CC1 RID: 3265
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
