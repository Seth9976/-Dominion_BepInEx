using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000072 RID: 114
public class InAppPurchase_Steam : InAppPurchaseInterface
{
	// Token: 0x06000E9D RID: 3741 RVA: 0x00044810 File Offset: 0x00042A10
	// Note: this type is marked as 'beforefieldinit'.
	static InAppPurchase_Steam()
	{
		Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppPurchase_Steam");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr);
		InAppPurchase_Steam.NativeFieldInfoPtr_m_InAppPurchaseDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, "m_InAppPurchaseDefinitions");
		InAppPurchase_Steam.NativeFieldInfoPtr_m_bUpdateOwnership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, "m_bUpdateOwnership");
		InAppPurchase_Steam.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664321);
		InAppPurchase_Steam.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664322);
		InAppPurchase_Steam.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664323);
		InAppPurchase_Steam.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664324);
		InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664325);
		InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664326);
		InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664327);
		InAppPurchase_Steam.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664328);
		InAppPurchase_Steam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr, 100664329);
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x0004491C File Offset: 0x00042B1C
	[CallerCount(0)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Steam.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00044950 File Offset: 0x00042B50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239727, XrefRangeEnd = 239732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool UpdateOwnership()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00044998 File Offset: 0x00042B98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239732, XrefRangeEnd = 239743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x000449F0 File Offset: 0x00042BF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239743, XrefRangeEnd = 239757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsUnlockedPackage(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00044A48 File Offset: 0x00042C48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239757, XrefRangeEnd = 239772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPackageLocalizedName(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00044A9C File Offset: 0x00042C9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239772, XrefRangeEnd = 239787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPackageLocalizedDescription(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00044AF0 File Offset: 0x00042CF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239787, XrefRangeEnd = 239801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStringArray GetPackageContentList(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00044B4C File Offset: 0x00042D4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239801, XrefRangeEnd = 239822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PurchaseItem(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Steam.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00044B9C File Offset: 0x00042D9C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppPurchase_Steam()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchase_Steam>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Steam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x0000A80E File Offset: 0x00008A0E
	public InAppPurchase_Steam(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00044BD8 File Offset: 0x00042DD8
	// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x0000A817 File Offset: 0x00008A17
	public unsafe static Il2CppReferenceArray<SteamInAppPurchaseDefinition> m_InAppPurchaseDefinitions
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchase_Steam.NativeFieldInfoPtr_m_InAppPurchaseDefinitions, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SteamInAppPurchaseDefinition>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchase_Steam.NativeFieldInfoPtr_m_InAppPurchaseDefinitions, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00044C00 File Offset: 0x00042E00
	// (set) Token: 0x06000EAB RID: 3755 RVA: 0x0000A829 File Offset: 0x00008A29
	public unsafe bool m_bUpdateOwnership
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Steam.NativeFieldInfoPtr_m_bUpdateOwnership);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Steam.NativeFieldInfoPtr_m_bUpdateOwnership)) = value;
		}
	}

	// Token: 0x040009F9 RID: 2553
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchaseDefinitions;

	// Token: 0x040009FA RID: 2554
	private static readonly IntPtr NativeFieldInfoPtr_m_bUpdateOwnership;

	// Token: 0x040009FB RID: 2555
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040009FC RID: 2556
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0;

	// Token: 0x040009FD RID: 2557
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0;

	// Token: 0x040009FE RID: 2558
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0;

	// Token: 0x040009FF RID: 2559
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0;

	// Token: 0x04000A00 RID: 2560
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0;

	// Token: 0x04000A01 RID: 2561
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0;

	// Token: 0x04000A02 RID: 2562
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0;

	// Token: 0x04000A03 RID: 2563
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
