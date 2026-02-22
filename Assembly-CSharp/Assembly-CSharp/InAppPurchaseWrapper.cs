using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000091 RID: 145
public class InAppPurchaseWrapper : MonoBehaviour
{
	// Token: 0x0600118B RID: 4491 RVA: 0x0004E7C0 File Offset: 0x0004C9C0
	// Note: this type is marked as 'beforefieldinit'.
	static InAppPurchaseWrapper()
	{
		Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppPurchaseWrapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr);
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_InAppPurchaseItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_InAppPurchaseItems");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_PlatformManagers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_PlatformManagers");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_ActiveManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_ActiveManager");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableCardSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_AvailableCardSetFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailablePromoPackFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_AvailablePromoPackFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableAvatarFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_AvailableAvatarFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardUnlockCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_RewardUnlockCode");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardCardSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_RewardCardSetFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardPromoPackFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_RewardPromoPackFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardAvatarFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_RewardAvatarFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedCardSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_UnlockedCardSetFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedPromoPackFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_UnlockedPromoPackFlags");
		InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedAvatarFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, "m_UnlockedAvatarFlags");
		InAppPurchaseWrapper.NativeMethodInfoPtr_SelectActiveManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664630);
		InAppPurchaseWrapper.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664631);
		InAppPurchaseWrapper.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664632);
		InAppPurchaseWrapper.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664633);
		InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateOwnership_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664634);
		InAppPurchaseWrapper.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664635);
		InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateAvailableFlags_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664636);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetAvailableCardSetFlags_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664637);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetAvailablePromoPackFlags_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664638);
		InAppPurchaseWrapper.NativeMethodInfoPtr_SetRewardUnlockCode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664639);
		InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateRewardUnlockCode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664640);
		InAppPurchaseWrapper.NativeMethodInfoPtr_PurchaseItem_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664641);
		InAppPurchaseWrapper.NativeMethodInfoPtr_RestorePurchases_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664642);
		InAppPurchaseWrapper.NativeMethodInfoPtr_IsPartiallyOwned_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664643);
		InAppPurchaseWrapper.NativeMethodInfoPtr_IsUnlockedPackage_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664644);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664645);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664646);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664647);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664648);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetContentLocalizedName_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664649);
		InAppPurchaseWrapper.NativeMethodInfoPtr_GetContentIconIndex_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664650);
		InAppPurchaseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr, 100664651);
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x0004EAAC File Offset: 0x0004CCAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242460, RefRangeEnd = 242461, XrefRangeStart = 242445, XrefRangeEnd = 242460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectActiveManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_SelectActiveManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x0004EAE0 File Offset: 0x0004CCE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242461, XrefRangeEnd = 242467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x0004EB14 File Offset: 0x0004CD14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242467, XrefRangeEnd = 242512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x0004EB48 File Offset: 0x0004CD48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242512, XrefRangeEnd = 242519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x0004EB7C File Offset: 0x0004CD7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242519, XrefRangeEnd = 242523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateOwnership()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateOwnership_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242554, RefRangeEnd = 242558, XrefRangeStart = 242523, XrefRangeEnd = 242554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x0004EC08 File Offset: 0x0004CE08
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242590, RefRangeEnd = 242594, XrefRangeStart = 242558, XrefRangeEnd = 242590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateAvailableFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateAvailableFlags_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x0004EC44 File Offset: 0x0004CE44
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetAvailableCardSetFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetAvailableCardSetFlags_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x0004EC80 File Offset: 0x0004CE80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetAvailablePromoPackFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetAvailablePromoPackFlags_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x0004ECBC File Offset: 0x0004CEBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242614, RefRangeEnd = 242615, XrefRangeStart = 242594, XrefRangeEnd = 242614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRewardUnlockCode(int unlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref unlock;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_SetRewardUnlockCode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x0004ECFC File Offset: 0x0004CEFC
	[CallerCount(0)]
	public unsafe void UpdateRewardUnlockCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_UpdateRewardUnlockCode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x0004ED30 File Offset: 0x0004CF30
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242619, RefRangeEnd = 242621, XrefRangeStart = 242615, XrefRangeEnd = 242619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurchaseItem(string purchase_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(purchase_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_PurchaseItem_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x0004ED74 File Offset: 0x0004CF74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242625, RefRangeEnd = 242626, XrefRangeStart = 242621, XrefRangeEnd = 242625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestorePurchases()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_RestorePurchases_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x0004EDA8 File Offset: 0x0004CFA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242626, XrefRangeEnd = 242642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPartiallyOwned(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_IsPartiallyOwned_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 242649, RefRangeEnd = 242652, XrefRangeStart = 242642, XrefRangeEnd = 242649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUnlockedPackage(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_IsUnlockedPackage_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x0004EE48 File Offset: 0x0004D048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242652, XrefRangeEnd = 242662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageLocalizedName(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x0004EE90 File Offset: 0x0004D090
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242662, XrefRangeEnd = 242668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageLocalizedPrice(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x0004EED8 File Offset: 0x0004D0D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242668, XrefRangeEnd = 242677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetPackageLocalizedDescription(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x0004EF20 File Offset: 0x0004D120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242677, XrefRangeEnd = 242681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppStringArray GetPackageContentList(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseWrapper.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x0004EF7C File Offset: 0x0004D17C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242681, XrefRangeEnd = 242696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetContentLocalizedName(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetContentLocalizedName_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x0004EFC4 File Offset: 0x0004D1C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242696, XrefRangeEnd = 242710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetContentIconIndex(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr_GetContentIconIndex_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x0004F014 File Offset: 0x0004D214
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppPurchaseWrapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchaseWrapper>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x0000BE46 File Offset: 0x0000A046
	public InAppPurchaseWrapper(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0004F050 File Offset: 0x0004D250
	// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0000BE4F File Offset: 0x0000A04F
	public unsafe static Il2CppReferenceArray<InAppPurchaseItem> m_InAppPurchaseItems
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_InAppPurchaseItems, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InAppPurchaseItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_InAppPurchaseItems, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0004F078 File Offset: 0x0004D278
	// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0000BE61 File Offset: 0x0000A061
	public unsafe Il2CppReferenceArray<InAppPurchaseInterface> m_PlatformManagers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_PlatformManagers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InAppPurchaseInterface>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_PlatformManagers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B5 RID: 1461
	// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0004F0A8 File Offset: 0x0004D2A8
	// (set) Token: 0x060011A8 RID: 4520 RVA: 0x0000BE80 File Offset: 0x0000A080
	public unsafe InAppPurchaseInterface m_ActiveManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_ActiveManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseInterface>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_ActiveManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005B6 RID: 1462
	// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0004F0D8 File Offset: 0x0004D2D8
	// (set) Token: 0x060011AA RID: 4522 RVA: 0x0000BE9F File Offset: 0x0000A09F
	public unsafe uint m_AvailableCardSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableCardSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableCardSetFlags)) = value;
		}
	}

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x060011AB RID: 4523 RVA: 0x0004F100 File Offset: 0x0004D300
	// (set) Token: 0x060011AC RID: 4524 RVA: 0x0000BEBA File Offset: 0x0000A0BA
	public unsafe uint m_AvailablePromoPackFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailablePromoPackFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailablePromoPackFlags)) = value;
		}
	}

	// Token: 0x170005B8 RID: 1464
	// (get) Token: 0x060011AD RID: 4525 RVA: 0x0004F128 File Offset: 0x0004D328
	// (set) Token: 0x060011AE RID: 4526 RVA: 0x0000BED5 File Offset: 0x0000A0D5
	public unsafe uint m_AvailableAvatarFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableAvatarFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_AvailableAvatarFlags)) = value;
		}
	}

	// Token: 0x170005B9 RID: 1465
	// (get) Token: 0x060011AF RID: 4527 RVA: 0x0004F150 File Offset: 0x0004D350
	// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0000BEF0 File Offset: 0x0000A0F0
	public unsafe int m_RewardUnlockCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardUnlockCode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardUnlockCode)) = value;
		}
	}

	// Token: 0x170005BA RID: 1466
	// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0004F178 File Offset: 0x0004D378
	// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0000BF0B File Offset: 0x0000A10B
	public unsafe uint m_RewardCardSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardCardSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardCardSetFlags)) = value;
		}
	}

	// Token: 0x170005BB RID: 1467
	// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
	// (set) Token: 0x060011B4 RID: 4532 RVA: 0x0000BF26 File Offset: 0x0000A126
	public unsafe uint m_RewardPromoPackFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardPromoPackFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardPromoPackFlags)) = value;
		}
	}

	// Token: 0x170005BC RID: 1468
	// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0004F1C8 File Offset: 0x0004D3C8
	// (set) Token: 0x060011B6 RID: 4534 RVA: 0x0000BF41 File Offset: 0x0000A141
	public unsafe uint m_RewardAvatarFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardAvatarFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseWrapper.NativeFieldInfoPtr_m_RewardAvatarFlags)) = value;
		}
	}

	// Token: 0x170005BD RID: 1469
	// (get) Token: 0x060011B7 RID: 4535 RVA: 0x0004F1F0 File Offset: 0x0004D3F0
	// (set) Token: 0x060011B8 RID: 4536 RVA: 0x0000BF5C File Offset: 0x0000A15C
	public unsafe static uint m_UnlockedCardSetFlags
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedCardSetFlags, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedCardSetFlags, (void*)(&value));
		}
	}

	// Token: 0x170005BE RID: 1470
	// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0004F20C File Offset: 0x0004D40C
	// (set) Token: 0x060011BA RID: 4538 RVA: 0x0000BF6A File Offset: 0x0000A16A
	public unsafe static uint m_UnlockedPromoPackFlags
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedPromoPackFlags, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedPromoPackFlags, (void*)(&value));
		}
	}

	// Token: 0x170005BF RID: 1471
	// (get) Token: 0x060011BB RID: 4539 RVA: 0x0004F228 File Offset: 0x0004D428
	// (set) Token: 0x060011BC RID: 4540 RVA: 0x0000BF78 File Offset: 0x0000A178
	public unsafe static uint m_UnlockedAvatarFlags
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedAvatarFlags, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InAppPurchaseWrapper.NativeFieldInfoPtr_m_UnlockedAvatarFlags, (void*)(&value));
		}
	}

	// Token: 0x04000C4A RID: 3146
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchaseItems;

	// Token: 0x04000C4B RID: 3147
	private static readonly IntPtr NativeFieldInfoPtr_m_PlatformManagers;

	// Token: 0x04000C4C RID: 3148
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveManager;

	// Token: 0x04000C4D RID: 3149
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailableCardSetFlags;

	// Token: 0x04000C4E RID: 3150
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailablePromoPackFlags;

	// Token: 0x04000C4F RID: 3151
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailableAvatarFlags;

	// Token: 0x04000C50 RID: 3152
	private static readonly IntPtr NativeFieldInfoPtr_m_RewardUnlockCode;

	// Token: 0x04000C51 RID: 3153
	private static readonly IntPtr NativeFieldInfoPtr_m_RewardCardSetFlags;

	// Token: 0x04000C52 RID: 3154
	private static readonly IntPtr NativeFieldInfoPtr_m_RewardPromoPackFlags;

	// Token: 0x04000C53 RID: 3155
	private static readonly IntPtr NativeFieldInfoPtr_m_RewardAvatarFlags;

	// Token: 0x04000C54 RID: 3156
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockedCardSetFlags;

	// Token: 0x04000C55 RID: 3157
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockedPromoPackFlags;

	// Token: 0x04000C56 RID: 3158
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockedAvatarFlags;

	// Token: 0x04000C57 RID: 3159
	private static readonly IntPtr NativeMethodInfoPtr_SelectActiveManager_Private_Void_0;

	// Token: 0x04000C58 RID: 3160
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C59 RID: 3161
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000C5A RID: 3162
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000C5B RID: 3163
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_Boolean_0;

	// Token: 0x04000C5C RID: 3164
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_EUnlockedContent_String_0;

	// Token: 0x04000C5D RID: 3165
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailableFlags_Public_Boolean_0;

	// Token: 0x04000C5E RID: 3166
	private static readonly IntPtr NativeMethodInfoPtr_GetAvailableCardSetFlags_Public_UInt32_0;

	// Token: 0x04000C5F RID: 3167
	private static readonly IntPtr NativeMethodInfoPtr_GetAvailablePromoPackFlags_Public_UInt32_0;

	// Token: 0x04000C60 RID: 3168
	private static readonly IntPtr NativeMethodInfoPtr_SetRewardUnlockCode_Public_Void_Int32_0;

	// Token: 0x04000C61 RID: 3169
	private static readonly IntPtr NativeMethodInfoPtr_UpdateRewardUnlockCode_Private_Void_0;

	// Token: 0x04000C62 RID: 3170
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseItem_Public_Void_String_0;

	// Token: 0x04000C63 RID: 3171
	private static readonly IntPtr NativeMethodInfoPtr_RestorePurchases_Public_Void_0;

	// Token: 0x04000C64 RID: 3172
	private static readonly IntPtr NativeMethodInfoPtr_IsPartiallyOwned_Public_Boolean_String_0;

	// Token: 0x04000C65 RID: 3173
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedPackage_Public_Boolean_String_0;

	// Token: 0x04000C66 RID: 3174
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedName_Public_String_String_0;

	// Token: 0x04000C67 RID: 3175
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_String_String_0;

	// Token: 0x04000C68 RID: 3176
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_String_String_0;

	// Token: 0x04000C69 RID: 3177
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0;

	// Token: 0x04000C6A RID: 3178
	private static readonly IntPtr NativeMethodInfoPtr_GetContentLocalizedName_Public_String_String_0;

	// Token: 0x04000C6B RID: 3179
	private static readonly IntPtr NativeMethodInfoPtr_GetContentIconIndex_Public_Int32_String_0;

	// Token: 0x04000C6C RID: 3180
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
