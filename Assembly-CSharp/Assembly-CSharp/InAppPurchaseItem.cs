using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000090 RID: 144
public class InAppPurchaseItem : Object
{
	// Token: 0x06001173 RID: 4467 RVA: 0x0004E304 File Offset: 0x0004C504
	// Note: this type is marked as 'beforefieldinit'.
	static InAppPurchaseItem()
	{
		Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InAppPurchaseItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr);
		InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_InAppPurchaseName");
		InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_InAppPurchaseID");
		InAppPurchaseItem.NativeFieldInfoPtr_m_IconIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_IconIndex");
		InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_UnlockFlagType");
		InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_UnlockFlags");
		InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_UnlockFlags2");
		InAppPurchaseItem.NativeFieldInfoPtr_m_bOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, "m_bOwned");
		InAppPurchaseItem.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_EUnlockFlagType_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664622);
		InAppPurchaseItem.NativeMethodInfoPtr_UpdateOwnership_Public_EUnlockedContent_InAppPurchaseWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664623);
		InAppPurchaseItem.NativeMethodInfoPtr_GetInAppPurchaseName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664624);
		InAppPurchaseItem.NativeMethodInfoPtr_GetInAppPurchaseID_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664625);
		InAppPurchaseItem.NativeMethodInfoPtr_GetIconIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664626);
		InAppPurchaseItem.NativeMethodInfoPtr_GetUnlockFlagType_Public_EUnlockFlagType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664627);
		InAppPurchaseItem.NativeMethodInfoPtr_GetUnlockFlags_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664628);
		InAppPurchaseItem.NativeMethodInfoPtr_GetSecondaryUnlockFlags_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr, 100664629);
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x0004E460 File Offset: 0x0004C660
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242443, XrefRangeEnd = 242444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InAppPurchaseItem(string name, string id, int icon_index, EUnlockFlagType unlockFlagType, uint unlockFlags, uint unlockFlags2 = 0U)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InAppPurchaseItem>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icon_index;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockFlagType;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockFlags;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockFlags2;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_EUnlockFlagType_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242444, XrefRangeEnd = 242445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EUnlockedContent UpdateOwnership(InAppPurchaseWrapper in_app_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(in_app_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_UpdateOwnership_Public_EUnlockedContent_InAppPurchaseWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0004E548 File Offset: 0x0004C748
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInAppPurchaseName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetInAppPurchaseName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x0004E580 File Offset: 0x0004C780
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetInAppPurchaseID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetInAppPurchaseID_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0004E5B8 File Offset: 0x0004C7B8
	[CallerCount(0)]
	public unsafe int GetIconIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetIconIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x0004E5F4 File Offset: 0x0004C7F4
	[CallerCount(0)]
	public unsafe EUnlockFlagType GetUnlockFlagType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetUnlockFlagType_Public_EUnlockFlagType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x0004E630 File Offset: 0x0004C830
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetUnlockFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetUnlockFlags_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x0004E66C File Offset: 0x0004C86C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint GetSecondaryUnlockFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InAppPurchaseItem.NativeMethodInfoPtr_GetSecondaryUnlockFlags_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x0000BD78 File Offset: 0x00009F78
	public InAppPurchaseItem(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x0600117D RID: 4477 RVA: 0x0004E6A8 File Offset: 0x0004C8A8
	// (set) Token: 0x0600117E RID: 4478 RVA: 0x0000BD81 File Offset: 0x00009F81
	public unsafe string m_InAppPurchaseName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x0600117F RID: 4479 RVA: 0x0004E6D0 File Offset: 0x0004C8D0
	// (set) Token: 0x06001180 RID: 4480 RVA: 0x0000BDA0 File Offset: 0x00009FA0
	public unsafe string m_InAppPurchaseID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_InAppPurchaseID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x06001181 RID: 4481 RVA: 0x0004E6F8 File Offset: 0x0004C8F8
	// (set) Token: 0x06001182 RID: 4482 RVA: 0x0000BDBF File Offset: 0x00009FBF
	public unsafe int m_IconIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_IconIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_IconIndex)) = value;
		}
	}

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x06001183 RID: 4483 RVA: 0x0004E720 File Offset: 0x0004C920
	// (set) Token: 0x06001184 RID: 4484 RVA: 0x0000BDDA File Offset: 0x00009FDA
	public unsafe EUnlockFlagType m_UnlockFlagType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlagType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlagType)) = value;
		}
	}

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x06001185 RID: 4485 RVA: 0x0004E748 File Offset: 0x0004C948
	// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000BDF5 File Offset: 0x00009FF5
	public unsafe uint m_UnlockFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags)) = value;
		}
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x06001187 RID: 4487 RVA: 0x0004E770 File Offset: 0x0004C970
	// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000BE10 File Offset: 0x0000A010
	public unsafe uint m_UnlockFlags2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags2);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_UnlockFlags2)) = value;
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x06001189 RID: 4489 RVA: 0x0004E798 File Offset: 0x0004C998
	// (set) Token: 0x0600118A RID: 4490 RVA: 0x0000BE2B File Offset: 0x0000A02B
	public unsafe EUnlockedContent m_bOwned
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_bOwned);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InAppPurchaseItem.NativeFieldInfoPtr_m_bOwned)) = value;
		}
	}

	// Token: 0x04000C3B RID: 3131
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchaseName;

	// Token: 0x04000C3C RID: 3132
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchaseID;

	// Token: 0x04000C3D RID: 3133
	private static readonly IntPtr NativeFieldInfoPtr_m_IconIndex;

	// Token: 0x04000C3E RID: 3134
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockFlagType;

	// Token: 0x04000C3F RID: 3135
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockFlags;

	// Token: 0x04000C40 RID: 3136
	private static readonly IntPtr NativeFieldInfoPtr_m_UnlockFlags2;

	// Token: 0x04000C41 RID: 3137
	private static readonly IntPtr NativeFieldInfoPtr_m_bOwned;

	// Token: 0x04000C42 RID: 3138
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_EUnlockFlagType_UInt32_UInt32_0;

	// Token: 0x04000C43 RID: 3139
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOwnership_Public_EUnlockedContent_InAppPurchaseWrapper_0;

	// Token: 0x04000C44 RID: 3140
	private static readonly IntPtr NativeMethodInfoPtr_GetInAppPurchaseName_Public_String_0;

	// Token: 0x04000C45 RID: 3141
	private static readonly IntPtr NativeMethodInfoPtr_GetInAppPurchaseID_Public_String_0;

	// Token: 0x04000C46 RID: 3142
	private static readonly IntPtr NativeMethodInfoPtr_GetIconIndex_Public_Int32_0;

	// Token: 0x04000C47 RID: 3143
	private static readonly IntPtr NativeMethodInfoPtr_GetUnlockFlagType_Public_EUnlockFlagType_0;

	// Token: 0x04000C48 RID: 3144
	private static readonly IntPtr NativeMethodInfoPtr_GetUnlockFlags_Public_UInt32_0;

	// Token: 0x04000C49 RID: 3145
	private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryUnlockFlags_Public_UInt32_0;
}
