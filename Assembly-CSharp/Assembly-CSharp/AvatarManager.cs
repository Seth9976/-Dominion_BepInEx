using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200009C RID: 156
public class AvatarManager : MonoBehaviour
{
	// Token: 0x0600128B RID: 4747 RVA: 0x00051F14 File Offset: 0x00050114
	// Note: this type is marked as 'beforefieldinit'.
	static AvatarManager()
	{
		Il2CppClassPointerStore<AvatarManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AvatarManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr);
		AvatarManager.NativeFieldInfoPtr_m_smallAvatarPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "m_smallAvatarPath");
		AvatarManager.NativeFieldInfoPtr_m_largeAvatarPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "m_largeAvatarPath");
		AvatarManager.NativeFieldInfoPtr_m_avatars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "m_avatars");
		AvatarManager.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "m_count");
		AvatarManager.NativeFieldInfoPtr_m_resourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "m_resourceManager");
		AvatarManager.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "_instance");
		AvatarManager.NativeMethodInfoPtr_get_instance_Public_Static_get_AvatarManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664749);
		AvatarManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664750);
		AvatarManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664751);
		AvatarManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664752);
		AvatarManager.NativeMethodInfoPtr_Count_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664753);
		AvatarManager.NativeMethodInfoPtr_RangeCheck_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664754);
		AvatarManager.NativeMethodInfoPtr_IsAvatarAvailable_Public_Boolean_UInt32_EAvatarRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664755);
		AvatarManager.NativeMethodInfoPtr_GetAvatarCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664756);
		AvatarManager.NativeMethodInfoPtr_GetAvatarString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664757);
		AvatarManager.NativeMethodInfoPtr_GetLargeAvatarString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664758);
		AvatarManager.NativeMethodInfoPtr_GetAvatar_Public_Sprite_UInt32_Avatar_UI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664759);
		AvatarManager.NativeMethodInfoPtr_ReleaseAvatar_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664760);
		AvatarManager.NativeMethodInfoPtr_GetAvatarLarge_Public_Sprite_UInt32_Avatar_UI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664761);
		AvatarManager.NativeMethodInfoPtr_ReleaseAvatarLarge_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664762);
		AvatarManager.NativeMethodInfoPtr_HandleResourceLoadCallback_Private_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664763);
		AvatarManager.NativeMethodInfoPtr_OutputManagerState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664764);
		AvatarManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, 100664765);
	}

	// Token: 0x170005F6 RID: 1526
	// (get) Token: 0x0600128C RID: 4748 RVA: 0x00052110 File Offset: 0x00050310
	public unsafe static AvatarManager instance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 243611, RefRangeEnd = 243615, XrefRangeStart = 243577, XrefRangeEnd = 243611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_get_instance_Public_Static_get_AvatarManager_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarManager>(intPtr3) : null;
		}
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00052144 File Offset: 0x00050344
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243615, XrefRangeEnd = 243627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00052178 File Offset: 0x00050378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243627, XrefRangeEnd = 243628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x000521AC File Offset: 0x000503AC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x000521E0 File Offset: 0x000503E0
	[CallerCount(0)]
	public unsafe int Count()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_Count_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0005221C File Offset: 0x0005041C
	[CallerCount(0)]
	public unsafe int RangeCheck(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_RangeCheck_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00052268 File Offset: 0x00050468
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243628, RefRangeEnd = 243629, XrefRangeStart = 243628, XrefRangeEnd = 243628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAvatarAvailable(uint index, AvatarManager.EAvatarRestriction restriction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restriction;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_IsAvatarAvailable_Public_Boolean_UInt32_EAvatarRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x000522C0 File Offset: 0x000504C0
	[CallerCount(0)]
	public unsafe int GetAvatarCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_GetAvatarCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x000522FC File Offset: 0x000504FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243629, XrefRangeEnd = 243630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetAvatarString(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_GetAvatarString_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00052340 File Offset: 0x00050540
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243630, XrefRangeEnd = 243631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLargeAvatarString(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_GetLargeAvatarString_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00052384 File Offset: 0x00050584
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243666, RefRangeEnd = 243667, XrefRangeStart = 243631, XrefRangeEnd = 243666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetAvatar(uint index, Avatar_UI avatarObj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(avatarObj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_GetAvatar_Public_Sprite_UInt32_Avatar_UI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x000523E4 File Offset: 0x000505E4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 243674, RefRangeEnd = 243678, XrefRangeStart = 243667, XrefRangeEnd = 243674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseAvatar(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_ReleaseAvatar_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00052424 File Offset: 0x00050624
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243727, RefRangeEnd = 243728, XrefRangeStart = 243678, XrefRangeEnd = 243727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite GetAvatarLarge(uint index, Avatar_UI avatarObj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(avatarObj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_GetAvatarLarge_Public_Sprite_UInt32_Avatar_UI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00052484 File Offset: 0x00050684
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243735, RefRangeEnd = 243736, XrefRangeStart = 243728, XrefRangeEnd = 243735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseAvatarLarge(uint index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_ReleaseAvatarLarge_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x000524C4 File Offset: 0x000506C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243736, XrefRangeEnd = 243745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleResourceLoadCallback(ResourceEntry resource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_HandleResourceLoadCallback_Private_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00052508 File Offset: 0x00050708
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243745, XrefRangeEnd = 243776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OutputManagerState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr_OutputManagerState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x0005253C File Offset: 0x0005073C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243776, XrefRangeEnd = 243781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AvatarManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x0000C513 File Offset: 0x0000A713
	public AvatarManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005F0 RID: 1520
	// (get) Token: 0x0600129E RID: 4766 RVA: 0x00052578 File Offset: 0x00050778
	// (set) Token: 0x0600129F RID: 4767 RVA: 0x0000C51C File Offset: 0x0000A71C
	public unsafe string m_smallAvatarPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_smallAvatarPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_smallAvatarPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005F1 RID: 1521
	// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000525A0 File Offset: 0x000507A0
	// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0000C53B File Offset: 0x0000A73B
	public unsafe string m_largeAvatarPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_largeAvatarPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_largeAvatarPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005F2 RID: 1522
	// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000525C8 File Offset: 0x000507C8
	// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000C55A File Offset: 0x0000A75A
	public unsafe Il2CppReferenceArray<AvatarManager.AvatarListing> m_avatars
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_avatars);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarManager.AvatarListing>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_avatars), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F3 RID: 1523
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000525F8 File Offset: 0x000507F8
	// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0000C579 File Offset: 0x0000A779
	public unsafe int m_count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_count)) = value;
		}
	}

	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00052620 File Offset: 0x00050820
	// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0000C594 File Offset: 0x0000A794
	public unsafe ResourceManager m_resourceManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_resourceManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.NativeFieldInfoPtr_m_resourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00052650 File Offset: 0x00050850
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0000C5B3 File Offset: 0x0000A7B3
	public unsafe static AvatarManager _instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AvatarManager.NativeFieldInfoPtr__instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AvatarManager.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CF9 RID: 3321
	private static readonly IntPtr NativeFieldInfoPtr_m_smallAvatarPath;

	// Token: 0x04000CFA RID: 3322
	private static readonly IntPtr NativeFieldInfoPtr_m_largeAvatarPath;

	// Token: 0x04000CFB RID: 3323
	private static readonly IntPtr NativeFieldInfoPtr_m_avatars;

	// Token: 0x04000CFC RID: 3324
	private static readonly IntPtr NativeFieldInfoPtr_m_count;

	// Token: 0x04000CFD RID: 3325
	private static readonly IntPtr NativeFieldInfoPtr_m_resourceManager;

	// Token: 0x04000CFE RID: 3326
	private static readonly IntPtr NativeFieldInfoPtr__instance;

	// Token: 0x04000CFF RID: 3327
	private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_AvatarManager_0;

	// Token: 0x04000D00 RID: 3328
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D01 RID: 3329
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000D02 RID: 3330
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000D03 RID: 3331
	private static readonly IntPtr NativeMethodInfoPtr_Count_Public_Int32_0;

	// Token: 0x04000D04 RID: 3332
	private static readonly IntPtr NativeMethodInfoPtr_RangeCheck_Public_Int32_Int32_0;

	// Token: 0x04000D05 RID: 3333
	private static readonly IntPtr NativeMethodInfoPtr_IsAvatarAvailable_Public_Boolean_UInt32_EAvatarRestriction_0;

	// Token: 0x04000D06 RID: 3334
	private static readonly IntPtr NativeMethodInfoPtr_GetAvatarCount_Public_Int32_0;

	// Token: 0x04000D07 RID: 3335
	private static readonly IntPtr NativeMethodInfoPtr_GetAvatarString_Public_String_UInt32_0;

	// Token: 0x04000D08 RID: 3336
	private static readonly IntPtr NativeMethodInfoPtr_GetLargeAvatarString_Public_String_UInt32_0;

	// Token: 0x04000D09 RID: 3337
	private static readonly IntPtr NativeMethodInfoPtr_GetAvatar_Public_Sprite_UInt32_Avatar_UI_0;

	// Token: 0x04000D0A RID: 3338
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseAvatar_Public_Void_UInt32_0;

	// Token: 0x04000D0B RID: 3339
	private static readonly IntPtr NativeMethodInfoPtr_GetAvatarLarge_Public_Sprite_UInt32_Avatar_UI_0;

	// Token: 0x04000D0C RID: 3340
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseAvatarLarge_Public_Void_UInt32_0;

	// Token: 0x04000D0D RID: 3341
	private static readonly IntPtr NativeMethodInfoPtr_HandleResourceLoadCallback_Private_Void_ResourceEntry_0;

	// Token: 0x04000D0E RID: 3342
	private static readonly IntPtr NativeMethodInfoPtr_OutputManagerState_Public_Void_0;

	// Token: 0x04000D0F RID: 3343
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001A1 RID: 417
	public enum EAvatarRestriction
	{
		// Token: 0x0400198A RID: 6538
		CotG,
		// Token: 0x0400198B RID: 6539
		ROTF,
		// Token: 0x0400198C RID: 6540
		SoS,
		// Token: 0x0400198D RID: 6541
		IH,
		// Token: 0x0400198E RID: 6542
		RoV,
		// Token: 0x0400198F RID: 6543
		DU,
		// Token: 0x04001990 RID: 6544
		RU,
		// Token: 0x04001991 RID: 6545
		DoC,
		// Token: 0x04001992 RID: 6546
		DS,
		// Token: 0x04001993 RID: 6547
		WoS,
		// Token: 0x04001994 RID: 6548
		GotE,
		// Token: 0x04001995 RID: 6549
		VotA,
		// Token: 0x04001996 RID: 6550
		Deli,
		// Token: 0x04001997 RID: 6551
		DLV,
		// Token: 0x04001998 RID: 6552
		CotG10,
		// Token: 0x04001999 RID: 6553
		NeverAvailable = 999
	}

	// Token: 0x020001A2 RID: 418
	public sealed class AvatarLoadCallback : MulticastDelegate
	{
		// Token: 0x060024DC RID: 9436 RVA: 0x00088DC4 File Offset: 0x00086FC4
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarLoadCallback()
		{
			Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "AvatarLoadCallback");
			AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr, 100666232);
			AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr, 100666233);
			AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Sprite_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr, 100666234);
			AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr, 100666235);
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x00088E38 File Offset: 0x00087038
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarLoadCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarManager.AvatarLoadCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00088E94 File Offset: 0x00087094
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Sprite avatarSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatarSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00088ED8 File Offset: 0x000870D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(Sprite avatarSprite, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatarSprite);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Sprite_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00088F4C File Offset: 0x0008714C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarManager.AvatarLoadCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00016D8F File Offset: 0x00014F8F
		public AvatarLoadCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00016D98 File Offset: 0x00014F98
		public static implicit operator AvatarManager.AvatarLoadCallback(Action<Sprite> A_0)
		{
			return DelegateSupport.ConvertDelegate<AvatarManager.AvatarLoadCallback>(A_0);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00016DA0 File Offset: 0x00014FA0
		public static AvatarManager.AvatarLoadCallback operator +(AvatarManager.AvatarLoadCallback A_0, AvatarManager.AvatarLoadCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AvatarManager.AvatarLoadCallback>();
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00016DAE File Offset: 0x00014FAE
		public static AvatarManager.AvatarLoadCallback operator -(AvatarManager.AvatarLoadCallback A_0, AvatarManager.AvatarLoadCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AvatarManager.AvatarLoadCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400199A RID: 6554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400199B RID: 6555
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Sprite_0;

		// Token: 0x0400199C RID: 6556
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Sprite_AsyncCallback_Object_0;

		// Token: 0x0400199D RID: 6557
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001A3 RID: 419
	[Serializable]
	public sealed class AvatarListing : ValueType
	{
		// Token: 0x060024E5 RID: 9445 RVA: 0x00088F90 File Offset: 0x00087190
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarListing()
		{
			Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarManager>.NativeClassPtr, "AvatarListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr);
			AvatarManager.AvatarListing.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "filename");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_filenameLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "filenameLarge");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "restriction");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "referenceCount");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "avatar");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCountLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "referenceCountLarge");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "avatarLarge");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "avatarResource");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResourceLarge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "avatarResourceLarge");
			AvatarManager.AvatarListing.NativeFieldInfoPtr_callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr, "callbacks");
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00016DBF File Offset: 0x00014FBF
		public AvatarListing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x00016DC8 File Offset: 0x00014FC8
		public AvatarListing()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarManager.AvatarListing>.NativeClassPtr))
		{
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x00089084 File Offset: 0x00087284
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00016DDA File Offset: 0x00014FDA
		public unsafe string filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000890AC File Offset: 0x000872AC
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x00016DF9 File Offset: 0x00014FF9
		public unsafe string filenameLarge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_filenameLarge);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_filenameLarge), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000890D4 File Offset: 0x000872D4
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00016E18 File Offset: 0x00015018
		public unsafe AvatarManager.EAvatarRestriction restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_restriction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_restriction)) = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000890FC File Offset: 0x000872FC
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x00016E33 File Offset: 0x00015033
		public unsafe uint referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCount)) = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00089124 File Offset: 0x00087324
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00016E4E File Offset: 0x0001504E
		public unsafe Sprite avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00089154 File Offset: 0x00087354
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00016E6D File Offset: 0x0001506D
		public unsafe uint referenceCountLarge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCountLarge);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_referenceCountLarge)) = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0008917C File Offset: 0x0008737C
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x00016E88 File Offset: 0x00015088
		public unsafe Sprite avatarLarge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarLarge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarLarge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x000891AC File Offset: 0x000873AC
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x00016EA7 File Offset: 0x000150A7
		public unsafe ResourceEntry avatarResource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x000891DC File Offset: 0x000873DC
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00016EC6 File Offset: 0x000150C6
		public unsafe ResourceEntry avatarResourceLarge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResourceLarge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_avatarResourceLarge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x0008920C File Offset: 0x0008740C
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x00016EE5 File Offset: 0x000150E5
		public unsafe AvatarManager.AvatarLoadCallback callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarManager.AvatarLoadCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarManager.AvatarListing.NativeFieldInfoPtr_callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeFieldInfoPtr_filename;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeFieldInfoPtr_filenameLarge;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeFieldInfoPtr_restriction;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeFieldInfoPtr_referenceCount;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeFieldInfoPtr_referenceCountLarge;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_avatarLarge;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeFieldInfoPtr_avatarResource;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeFieldInfoPtr_avatarResourceLarge;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeFieldInfoPtr_callbacks;
	}
}
