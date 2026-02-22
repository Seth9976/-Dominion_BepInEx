using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200008D RID: 141
public class InAppPurchaseInterface : MonoBehaviour
{
	// Token: 0x06001167 RID: 4455 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
	// Note: this type is marked as 'beforefieldinit'.
	static InAppPurchaseInterface()
	{
		Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppPurchaseInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr);
		InAppPurchaseInterface.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664612);
		InAppPurchaseInterface.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_New_EUnlockedContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664613);
		InAppPurchaseInterface.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664614);
		InAppPurchaseInterface.NativeMethodInfoPtr_RestorePurchases_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664615);
		InAppPurchaseInterface.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664616);
		InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664617);
		InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664618);
		InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664619);
		InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664620);
		InAppPurchaseInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr, 100664621);
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x0004DFEC File Offset: 0x0004C1EC
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UpdateOwnership()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x0004E034 File Offset: 0x0004C234
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual EUnlockedContent IsUnlockedContent(string contentID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(contentID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_New_EUnlockedContent_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x0004E08C File Offset: 0x0004C28C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void PurchaseItem(string purchase_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(purchase_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_PurchaseItem_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x0004E0DC File Offset: 0x0004C2DC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RestorePurchases()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_RestorePurchases_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x0004E118 File Offset: 0x0004C318
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsUnlockedPackage(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x0004E170 File Offset: 0x0004C370
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242437, XrefRangeEnd = 242439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetPackageLocalizedName(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x0004E1C4 File Offset: 0x0004C3C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242439, XrefRangeEnd = 242441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetPackageLocalizedDescription(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x0004E218 File Offset: 0x0004C418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242441, XrefRangeEnd = 242443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string GetPackageLocalizedPrice(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x0004E26C File Offset: 0x0004C46C
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppStringArray GetPackageContentList(string iap_package_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iap_package_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InAppPurchaseInterface.NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x0004E2C8 File Offset: 0x0004C4C8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppPurchaseInterface()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchaseInterface>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x0000BD6F File Offset: 0x00009F6F
	public InAppPurchaseInterface(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000C28 RID: 3112
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_Virtual_New_Boolean_0;

	// Token: 0x04000C29 RID: 3113
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedContent_Public_Virtual_New_EUnlockedContent_String_0;

	// Token: 0x04000C2A RID: 3114
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseItem_Public_Virtual_New_Void_String_0;

	// Token: 0x04000C2B RID: 3115
	private static readonly IntPtr NativeMethodInfoPtr_RestorePurchases_Public_Virtual_New_Void_0;

	// Token: 0x04000C2C RID: 3116
	private static readonly IntPtr NativeMethodInfoPtr_IsUnlockedPackage_Public_Virtual_New_Boolean_String_0;

	// Token: 0x04000C2D RID: 3117
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedName_Public_Virtual_New_String_String_0;

	// Token: 0x04000C2E RID: 3118
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedDescription_Public_Virtual_New_String_String_0;

	// Token: 0x04000C2F RID: 3119
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageLocalizedPrice_Public_Virtual_New_String_String_0;

	// Token: 0x04000C30 RID: 3120
	private static readonly IntPtr NativeMethodInfoPtr_GetPackageContentList_Public_Virtual_New_Il2CppStringArray_String_0;

	// Token: 0x04000C31 RID: 3121
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
