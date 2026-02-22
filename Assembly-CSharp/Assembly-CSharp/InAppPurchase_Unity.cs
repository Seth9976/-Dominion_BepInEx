using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing;

// Token: 0x02000075 RID: 117
public class InAppPurchase_Unity : InAppPurchaseInterface
{
	// Token: 0x06000EE3 RID: 3811 RVA: 0x00045754 File Offset: 0x00043954
	// Note: this type is marked as 'beforefieldinit'.
	static InAppPurchase_Unity()
	{
		Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppPurchase_Unity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr);
		InAppPurchase_Unity.NativeFieldInfoPtr_s_InAppPurchaseIDExtension_ios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "s_InAppPurchaseIDExtension_ios");
		InAppPurchase_Unity.NativeFieldInfoPtr_m_InAppPurchaseDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "m_InAppPurchaseDefinitions");
		InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "m_StoreController");
		InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "m_StoreExtensions");
		InAppPurchase_Unity.NativeFieldInfoPtr_m_bUpdateOwnership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "m_bUpdateOwnership");
		InAppPurchase_Unity.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664354);
		InAppPurchase_Unity.NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_IExtensionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664355);
		InAppPurchase_Unity.NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664356);
		InAppPurchase_Unity.NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664357);
		InAppPurchase_Unity.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664358);
		InAppPurchase_Unity.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664359);
		InAppPurchase_Unity.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664360);
		InAppPurchase_Unity.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664361);
		InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664362);
		InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664363);
		InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664364);
		InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664365);
		InAppPurchase_Unity.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664366);
		InAppPurchase_Unity.NativeMethodInfoPtr_RestorePurchases_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664367);
		InAppPurchase_Unity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, 100664368);
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00045914 File Offset: 0x00043B14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239969, XrefRangeEnd = 240032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00045948 File Offset: 0x00043B48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240032, XrefRangeEnd = 240057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_IExtensionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0004599C File Offset: 0x00043B9C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnInitializeFailed(InitializationFailureReason error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x000459DC File Offset: 0x00043BDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240057, XrefRangeEnd = 240108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00045A2C File Offset: 0x00043C2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240108, XrefRangeEnd = 240121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPurchaseFailed(Product i, PurchaseFailureReason p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00045A7C File Offset: 0x00043C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240121, XrefRangeEnd = 240125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool UpdateOwnership()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00045AC4 File Offset: 0x00043CC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240125, XrefRangeEnd = 240136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00045B1C File Offset: 0x00043D1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240136, XrefRangeEnd = 240150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsUnlockedPackage(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00045B74 File Offset: 0x00043D74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240150, XrefRangeEnd = 240165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPackageLocalizedName(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00045BC8 File Offset: 0x00043DC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240165, XrefRangeEnd = 240180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPackageLocalizedDescription(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00045C1C File Offset: 0x00043E1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240180, XrefRangeEnd = 240195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string GetPackageLocalizedPrice(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00045C70 File Offset: 0x00043E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240195, XrefRangeEnd = 240209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStringArray GetPackageContentList(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00045CCC File Offset: 0x00043ECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240209, XrefRangeEnd = 240224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PurchaseItem(string purchase_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(purchase_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00045D1C File Offset: 0x00043F1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240224, XrefRangeEnd = 240257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RestorePurchases()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchase_Unity.NativeMethodInfoPtr_RestorePurchases_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00045D58 File Offset: 0x00043F58
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppPurchase_Unity()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x0000A9D6 File Offset: 0x00008BD6
	public InAppPurchase_Unity(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00045D94 File Offset: 0x00043F94
	// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0000A9DF File Offset: 0x00008BDF
	public unsafe static string s_InAppPurchaseIDExtension_ios
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchase_Unity.NativeFieldInfoPtr_s_InAppPurchaseIDExtension_ios, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchase_Unity.NativeFieldInfoPtr_s_InAppPurchaseIDExtension_ios, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00045DB4 File Offset: 0x00043FB4
	// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0000A9F1 File Offset: 0x00008BF1
	public unsafe static Il2CppReferenceArray<UnityInAppPurchaseDefinition> m_InAppPurchaseDefinitions
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchase_Unity.NativeFieldInfoPtr_m_InAppPurchaseDefinitions, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityInAppPurchaseDefinition>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchase_Unity.NativeFieldInfoPtr_m_InAppPurchaseDefinitions, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00045DDC File Offset: 0x00043FDC
	// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0000AA03 File Offset: 0x00008C03
	public unsafe IStoreController m_StoreController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00045E0C File Offset: 0x0004400C
	// (set) Token: 0x06000EFB RID: 3835 RVA: 0x0000AA22 File Offset: 0x00008C22
	public unsafe IExtensionProvider m_StoreExtensions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreExtensions);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExtensionProvider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_StoreExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00045E3C File Offset: 0x0004403C
	// (set) Token: 0x06000EFD RID: 3837 RVA: 0x0000AA41 File Offset: 0x00008C41
	public unsafe bool m_bUpdateOwnership
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_bUpdateOwnership);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchase_Unity.NativeFieldInfoPtr_m_bUpdateOwnership)) = value;
		}
	}

	// Token: 0x04000A29 RID: 2601
	private static readonly IntPtr NativeFieldInfoPtr_s_InAppPurchaseIDExtension_ios;

	// Token: 0x04000A2A RID: 2602
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchaseDefinitions;

	// Token: 0x04000A2B RID: 2603
	private static readonly IntPtr NativeFieldInfoPtr_m_StoreController;

	// Token: 0x04000A2C RID: 2604
	private static readonly IntPtr NativeFieldInfoPtr_m_StoreExtensions;

	// Token: 0x04000A2D RID: 2605
	private static readonly IntPtr NativeFieldInfoPtr_m_bUpdateOwnership;

	// Token: 0x04000A2E RID: 2606
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000A2F RID: 2607
	private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Public_Virtual_Final_New_Void_IStoreController_IExtensionProvider_0;

	// Token: 0x04000A30 RID: 2608
	private static readonly IntPtr NativeMethodInfoPtr_OnInitializeFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0;

	// Token: 0x04000A31 RID: 2609
	private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchase_Public_Virtual_Final_New_PurchaseProcessingResult_PurchaseEventArgs_0;

	// Token: 0x04000A32 RID: 2610
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_Product_PurchaseFailureReason_0;

	// Token: 0x04000A33 RID: 2611
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_Boolean_0;

	// Token: 0x04000A34 RID: 2612
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_EUnlockedContent_String_0;

	// Token: 0x04000A35 RID: 2613
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_Boolean_String_0;

	// Token: 0x04000A36 RID: 2614
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_String_String_0;

	// Token: 0x04000A37 RID: 2615
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_String_String_0;

	// Token: 0x04000A38 RID: 2616
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_String_String_0;

	// Token: 0x04000A39 RID: 2617
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_Il2CppStringArray_String_0;

	// Token: 0x04000A3A RID: 2618
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseItem_Public_Virtual_Void_String_0;

	// Token: 0x04000A3B RID: 2619
	private static readonly IntPtr NativeMethodInfoPtr_RestorePurchases_Public_Virtual_Void_0;

	// Token: 0x04000A3C RID: 2620
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018C RID: 396
	[ObfuscatedName("InAppPurchase_Unity+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06002451 RID: 9297 RVA: 0x0008735C File Offset: 0x0008555C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InAppPurchase_Unity>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr);
			InAppPurchase_Unity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr, "<>9");
			InAppPurchase_Unity.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr, "<>9__18_0");
			InAppPurchase_Unity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr, 100666186);
			InAppPurchase_Unity.__c.NativeMethodInfoPtr__RestorePurchases_b__18_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr, 100666187);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x000873D8 File Offset: 0x000855D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchase_Unity.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00087414 File Offset: 0x00085614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239959, XrefRangeEnd = 239969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RestorePurchases_b__18_0(bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchase_Unity.__c.NativeMethodInfoPtr__RestorePurchases_b__18_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x000169B4 File Offset: 0x00014BB4
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x00087454 File Offset: 0x00085654
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x000169BD File Offset: 0x00014BBD
		public unsafe static InAppPurchase_Unity.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InAppPurchase_Unity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchase_Unity.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InAppPurchase_Unity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0008747C File Offset: 0x0008567C
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x000169CF File Offset: 0x00014BCF
		public unsafe static Action<bool> __9__18_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InAppPurchase_Unity.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InAppPurchase_Unity.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr__RestorePurchases_b__18_0_Internal_Void_Boolean_0;
	}
}
