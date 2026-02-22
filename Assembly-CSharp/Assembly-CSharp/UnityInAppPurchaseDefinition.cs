using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing;

// Token: 0x02000074 RID: 116
public class UnityInAppPurchaseDefinition : Object
{
	// Token: 0x06000EC2 RID: 3778 RVA: 0x00045010 File Offset: 0x00043210
	// Note: this type is marked as 'beforefieldinit'.
	static UnityInAppPurchaseDefinition()
	{
		Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnityInAppPurchaseDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr);
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_ProductID");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_ProductType");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_UnityProductIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_UnityProductIDs");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_ProductLocalizedTitle");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_ProductLocalizedDescription");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_ProductLocalizedPrice");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_bOwned");
		UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, "m_PackageContentList");
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_IDs_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664339);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetProductID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664340);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_AppendProductIDs_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664341);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_AddToConfigurationBuilder_Public_Void_ConfigurationBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664342);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetOwned_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664343);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664344);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664345);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedDescription_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664346);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedPrice_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664347);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664348);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664349);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664350);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDescription_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664351);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackagePrice_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664352);
		UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr, 100664353);
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x0004520C File Offset: 0x0004340C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239924, XrefRangeEnd = 239928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityInAppPurchaseDefinition(string id, ProductType productType, IDs productIDs, Il2CppStringArray contentList)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInAppPurchaseDefinition>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productIDs);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentList);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_IDs_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x0004528C File Offset: 0x0004348C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProductID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetProductID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x000452C4 File Offset: 0x000434C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239928, XrefRangeEnd = 239954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppendProductIDs(string append_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(append_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_AppendProductIDs_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00045308 File Offset: 0x00043508
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239955, RefRangeEnd = 239956, XrefRangeStart = 239954, XrefRangeEnd = 239955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToConfigurationBuilder(ConfigurationBuilder builder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_AddToConfigurationBuilder_Public_Void_ConfigurationBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x0004534C File Offset: 0x0004354C
	[CallerCount(0)]
	public unsafe void SetOwned(bool bOwned)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetOwned_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x0004538C File Offset: 0x0004358C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 239958, RefRangeEnd = 239959, XrefRangeStart = 239956, XrefRangeEnd = 239958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x000453DC File Offset: 0x000435DC
	[CallerCount(0)]
	public unsafe void SetProductLocalizedTitle(string title)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00045420 File Offset: 0x00043620
	[CallerCount(0)]
	public unsafe void SetProductLocalizedDescription(string description)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedDescription_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00045464 File Offset: 0x00043664
	[CallerCount(0)]
	public unsafe void SetProductLocalizedPrice(string price)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(price);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_SetProductLocalizedPrice_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x000454A8 File Offset: 0x000436A8
	[CallerCount(0)]
	public unsafe bool GetPackageOwned()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x000454E4 File Offset: 0x000436E4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0004551C File Offset: 0x0004371C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageDisplayName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00045554 File Offset: 0x00043754
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageDescription_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x0004558C File Offset: 0x0004378C
	[CallerCount(0)]
	public unsafe string GetPackagePrice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackagePrice_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x000455C4 File Offset: 0x000437C4
	[CallerCount(0)]
	public unsafe Il2CppStringArray GetPackageContentList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityInAppPurchaseDefinition.NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x0000A8DD File Offset: 0x00008ADD
	public UnityInAppPurchaseDefinition(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x00045604 File Offset: 0x00043804
	// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x0000A8E6 File Offset: 0x00008AE6
	public unsafe string m_ProductID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004562C File Offset: 0x0004382C
	// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x0000A905 File Offset: 0x00008B05
	public unsafe ProductType m_ProductType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductType)) = value;
		}
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x00045654 File Offset: 0x00043854
	// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x0000A920 File Offset: 0x00008B20
	public unsafe IDs m_UnityProductIDs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_UnityProductIDs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDs>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_UnityProductIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x00045684 File Offset: 0x00043884
	// (set) Token: 0x06000EDA RID: 3802 RVA: 0x0000A93F File Offset: 0x00008B3F
	public unsafe string m_ProductLocalizedTitle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedTitle);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedTitle), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000456AC File Offset: 0x000438AC
	// (set) Token: 0x06000EDC RID: 3804 RVA: 0x0000A95E File Offset: 0x00008B5E
	public unsafe string m_ProductLocalizedDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000456D4 File Offset: 0x000438D4
	// (set) Token: 0x06000EDE RID: 3806 RVA: 0x0000A97D File Offset: 0x00008B7D
	public unsafe string m_ProductLocalizedPrice
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedPrice);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_ProductLocalizedPrice), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06000EDF RID: 3807 RVA: 0x000456FC File Offset: 0x000438FC
	// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0000A99C File Offset: 0x00008B9C
	public unsafe bool m_bOwned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_bOwned)) = value;
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x00045724 File Offset: 0x00043924
	// (set) Token: 0x06000EE2 RID: 3810 RVA: 0x0000A9B7 File Offset: 0x00008BB7
	public unsafe Il2CppStringArray m_PackageContentList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityInAppPurchaseDefinition.NativeFieldInfoPtr_m_PackageContentList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000A12 RID: 2578
	private static readonly IntPtr NativeFieldInfoPtr_m_ProductID;

	// Token: 0x04000A13 RID: 2579
	private static readonly IntPtr NativeFieldInfoPtr_m_ProductType;

	// Token: 0x04000A14 RID: 2580
	private static readonly IntPtr NativeFieldInfoPtr_m_UnityProductIDs;

	// Token: 0x04000A15 RID: 2581
	private static readonly IntPtr NativeFieldInfoPtr_m_ProductLocalizedTitle;

	// Token: 0x04000A16 RID: 2582
	private static readonly IntPtr NativeFieldInfoPtr_m_ProductLocalizedDescription;

	// Token: 0x04000A17 RID: 2583
	private static readonly IntPtr NativeFieldInfoPtr_m_ProductLocalizedPrice;

	// Token: 0x04000A18 RID: 2584
	private static readonly IntPtr NativeFieldInfoPtr_m_bOwned;

	// Token: 0x04000A19 RID: 2585
	private static readonly IntPtr NativeFieldInfoPtr_m_PackageContentList;

	// Token: 0x04000A1A RID: 2586
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_IDs_Il2CppStringArray_0;

	// Token: 0x04000A1B RID: 2587
	private static readonly IntPtr NativeMethodInfoPtr_GetProductID_Public_String_0;

	// Token: 0x04000A1C RID: 2588
	private static readonly IntPtr NativeMethodInfoPtr_AppendProductIDs_Public_Void_String_0;

	// Token: 0x04000A1D RID: 2589
	private static readonly IntPtr NativeMethodInfoPtr_AddToConfigurationBuilder_Public_Void_ConfigurationBuilder_0;

	// Token: 0x04000A1E RID: 2590
	private static readonly IntPtr NativeMethodInfoPtr_SetOwned_Public_Void_Boolean_0;

	// Token: 0x04000A1F RID: 2591
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0;

	// Token: 0x04000A20 RID: 2592
	private static readonly IntPtr NativeMethodInfoPtr_SetProductLocalizedTitle_Public_Void_String_0;

	// Token: 0x04000A21 RID: 2593
	private static readonly IntPtr NativeMethodInfoPtr_SetProductLocalizedDescription_Public_Void_String_0;

	// Token: 0x04000A22 RID: 2594
	private static readonly IntPtr NativeMethodInfoPtr_SetProductLocalizedPrice_Public_Void_String_0;

	// Token: 0x04000A23 RID: 2595
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageOwned_Public_Boolean_0;

	// Token: 0x04000A24 RID: 2596
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageID_Public_String_0;

	// Token: 0x04000A25 RID: 2597
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageDisplayName_Public_String_0;

	// Token: 0x04000A26 RID: 2598
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageDescription_Public_String_0;

	// Token: 0x04000A27 RID: 2599
	private static readonly IntPtr NativeMethodInfoPtr_GetPackagePrice_Public_String_0;

	// Token: 0x04000A28 RID: 2600
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Il2CppStringArray_0;
}
