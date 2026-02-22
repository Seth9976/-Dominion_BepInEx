using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks;

// Token: 0x02000071 RID: 113
public class SteamInAppPurchaseDefinition : Object
{
	// Token: 0x06000E86 RID: 3718 RVA: 0x00044344 File Offset: 0x00042544
	// Note: this type is marked as 'beforefieldinit'.
	static SteamInAppPurchaseDefinition()
	{
		Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SteamInAppPurchaseDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr);
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_PackageID");
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_PackageDisplayName");
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_AppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_AppID");
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_PackageDescription");
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_bOwned");
		SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, "m_PackageContentList");
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_AppId_t_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664312);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_UpdateOwnership_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664313);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664314);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664315);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664316);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664317);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageAppID_Public_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664318);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664319);
		SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr, 100664320);
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x000444A0 File Offset: 0x000426A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239678, XrefRangeEnd = 239679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SteamInAppPurchaseDefinition(string packageID, string name, AppId_t appID, string description, Il2CppStringArray contentList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamInAppPurchaseDefinition>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packageID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentList);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_AppId_t_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00044534 File Offset: 0x00042734
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239679, XrefRangeEnd = 239724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateOwnership()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_UpdateOwnership_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00044568 File Offset: 0x00042768
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239726, RefRangeEnd = 239727, XrefRangeStart = 239724, XrefRangeEnd = 239726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x000445B8 File Offset: 0x000427B8
	[CallerCount(0)]
	public unsafe bool GetPackageOwned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x000445F4 File Offset: 0x000427F4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0004462C File Offset: 0x0004282C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageDisplayName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00044664 File Offset: 0x00042864
	[CallerCount(0)]
	public unsafe AppId_t GetPackageAppID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageAppID_Public_AppId_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x000446A0 File Offset: 0x000428A0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x000446D8 File Offset: 0x000428D8
	[CallerCount(0)]
	public unsafe Il2CppStringArray GetPackageContentList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0000A753 File Offset: 0x00008953
	public SteamInAppPurchaseDefinition(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00044718 File Offset: 0x00042918
	// (set) Token: 0x06000E92 RID: 3730 RVA: 0x0000A75C File Offset: 0x0000895C
	public unsafe string m_PackageID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00044740 File Offset: 0x00042940
	// (set) Token: 0x06000E94 RID: 3732 RVA: 0x0000A77B File Offset: 0x0000897B
	public unsafe string m_PackageDisplayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDisplayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x06000E95 RID: 3733 RVA: 0x00044768 File Offset: 0x00042968
	// (set) Token: 0x06000E96 RID: 3734 RVA: 0x0000A79A File Offset: 0x0000899A
	public unsafe AppId_t m_AppID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_AppID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_AppID)) = value;
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x06000E97 RID: 3735 RVA: 0x00044790 File Offset: 0x00042990
	// (set) Token: 0x06000E98 RID: 3736 RVA: 0x0000A7B5 File Offset: 0x000089B5
	public unsafe string m_PackageDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000447B8 File Offset: 0x000429B8
	// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0000A7D4 File Offset: 0x000089D4
	public unsafe bool m_bOwned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned)) = value;
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000447E0 File Offset: 0x000429E0
	// (set) Token: 0x06000E9C RID: 3740 RVA: 0x0000A7EF File Offset: 0x000089EF
	public unsafe Il2CppStringArray m_PackageContentList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040009EA RID: 2538
	private static readonly IntPtr NativeFieldInfoPtr_m_PackageID;

	// Token: 0x040009EB RID: 2539
	private static readonly IntPtr NativeFieldInfoPtr_m_PackageDisplayName;

	// Token: 0x040009EC RID: 2540
	private static readonly IntPtr NativeFieldInfoPtr_m_AppID;

	// Token: 0x040009ED RID: 2541
	private static readonly IntPtr NativeFieldInfoPtr_m_PackageDescription;

	// Token: 0x040009EE RID: 2542
	private static readonly IntPtr NativeFieldInfoPtr_m_bOwned;

	// Token: 0x040009EF RID: 2543
	private static readonly IntPtr NativeFieldInfoPtr_m_PackageContentList;

	// Token: 0x040009F0 RID: 2544
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_AppId_t_String_Il2CppStringArray_0;

	// Token: 0x040009F1 RID: 2545
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_Void_0;

	// Token: 0x040009F2 RID: 2546
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0;

	// Token: 0x040009F3 RID: 2547
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0;

	// Token: 0x040009F4 RID: 2548
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageID_Public_String_0;

	// Token: 0x040009F5 RID: 2549
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0;

	// Token: 0x040009F6 RID: 2550
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageAppID_Public_AppId_t_0;

	// Token: 0x040009F7 RID: 2551
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageDescription_Public_String_0;

	// Token: 0x040009F8 RID: 2552
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0;
}
