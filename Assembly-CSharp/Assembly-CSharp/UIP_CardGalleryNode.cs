using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[Serializable]
public class UIP_CardGalleryNode : MonoBehaviour
{
	// Token: 0x0600156C RID: 5484 RVA: 0x0005B024 File Offset: 0x00059224
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_CardGalleryNode()
	{
		Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_CardGalleryNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr);
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_moveLeft");
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_moveRight");
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_forceMoveTrigger");
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_forceMoveValue");
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_flipCard");
		UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCardH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "s_flipCardH");
		UIP_CardGalleryNode.NativeFieldInfoPtr_m_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "m_animator");
		UIP_CardGalleryNode.NativeFieldInfoPtr_m_limbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "m_limbo");
		UIP_CardGalleryNode.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "m_index");
		UIP_CardGalleryNode.NativeFieldInfoPtr_m_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "m_card");
		UIP_CardGalleryNode.NativeFieldInfoPtr_m_flipCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "m_flipCard");
		UIP_CardGalleryNode.NativeFieldInfoPtr_bFlipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, "bFlipped");
		UIP_CardGalleryNode.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665020);
		UIP_CardGalleryNode.NativeMethodInfoPtr_SetCard_Public_Void_GameObject_GameObject_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665021);
		UIP_CardGalleryNode.NativeMethodInfoPtr_ClearCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665022);
		UIP_CardGalleryNode.NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665023);
		UIP_CardGalleryNode.NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665024);
		UIP_CardGalleryNode.NativeMethodInfoPtr_FlipCard_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665025);
		UIP_CardGalleryNode.NativeMethodInfoPtr_ForceMove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665026);
		UIP_CardGalleryNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr, 100665027);
	}

	// Token: 0x0600156D RID: 5485 RVA: 0x0005B1E4 File Offset: 0x000593E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247005, XrefRangeEnd = 247013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600156E RID: 5486 RVA: 0x0005B218 File Offset: 0x00059418
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247027, RefRangeEnd = 247029, XrefRangeStart = 247013, XrefRangeEnd = 247027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCard(GameObject card, GameObject flipCard, int index, float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flipCard);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_SetCard_Public_Void_GameObject_GameObject_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600156F RID: 5487 RVA: 0x0005B288 File Offset: 0x00059488
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 247039, RefRangeEnd = 247043, XrefRangeStart = 247029, XrefRangeEnd = 247039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_ClearCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001570 RID: 5488 RVA: 0x0005B2BC File Offset: 0x000594BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247043, XrefRangeEnd = 247051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001571 RID: 5489 RVA: 0x0005B2F0 File Offset: 0x000594F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247051, XrefRangeEnd = 247059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001572 RID: 5490 RVA: 0x0005B324 File Offset: 0x00059524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247059, XrefRangeEnd = 247076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlipCard(bool bIsHorizontal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsHorizontal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_FlipCard_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x0005B364 File Offset: 0x00059564
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247076, XrefRangeEnd = 247083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceMove(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr_ForceMove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x0005B3A4 File Offset: 0x000595A4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_CardGalleryNode()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_CardGalleryNode>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_CardGalleryNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001575 RID: 5493 RVA: 0x0000DDD5 File Offset: 0x0000BFD5
	public UIP_CardGalleryNode(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006C7 RID: 1735
	// (get) Token: 0x06001576 RID: 5494 RVA: 0x0005B3E0 File Offset: 0x000595E0
	// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000DDDE File Offset: 0x0000BFDE
	public unsafe static string s_moveLeft
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveLeft, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveLeft, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006C8 RID: 1736
	// (get) Token: 0x06001578 RID: 5496 RVA: 0x0005B400 File Offset: 0x00059600
	// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
	public unsafe static string s_moveRight
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveRight, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_moveRight, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006C9 RID: 1737
	// (get) Token: 0x0600157A RID: 5498 RVA: 0x0005B420 File Offset: 0x00059620
	// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000DE02 File Offset: 0x0000C002
	public unsafe static string s_forceMoveTrigger
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveTrigger, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveTrigger, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006CA RID: 1738
	// (get) Token: 0x0600157C RID: 5500 RVA: 0x0005B440 File Offset: 0x00059640
	// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000DE14 File Offset: 0x0000C014
	public unsafe static string s_forceMoveValue
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveValue, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_forceMoveValue, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006CB RID: 1739
	// (get) Token: 0x0600157E RID: 5502 RVA: 0x0005B460 File Offset: 0x00059660
	// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000DE26 File Offset: 0x0000C026
	public unsafe static string s_flipCard
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCard, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCard, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006CC RID: 1740
	// (get) Token: 0x06001580 RID: 5504 RVA: 0x0005B480 File Offset: 0x00059680
	// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000DE38 File Offset: 0x0000C038
	public unsafe static string s_flipCardH
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCardH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIP_CardGalleryNode.NativeFieldInfoPtr_s_flipCardH, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006CD RID: 1741
	// (get) Token: 0x06001582 RID: 5506 RVA: 0x0005B4A0 File Offset: 0x000596A0
	// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000DE4A File Offset: 0x0000C04A
	public unsafe Animator m_animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006CE RID: 1742
	// (get) Token: 0x06001584 RID: 5508 RVA: 0x0005B4D0 File Offset: 0x000596D0
	// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000DE69 File Offset: 0x0000C069
	public unsafe GameObject m_limbo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_limbo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_limbo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006CF RID: 1743
	// (get) Token: 0x06001586 RID: 5510 RVA: 0x0005B500 File Offset: 0x00059700
	// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000DE88 File Offset: 0x0000C088
	public unsafe int m_index
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_index);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_index)) = value;
		}
	}

	// Token: 0x170006D0 RID: 1744
	// (get) Token: 0x06001588 RID: 5512 RVA: 0x0005B528 File Offset: 0x00059728
	// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000DEA3 File Offset: 0x0000C0A3
	public unsafe GameObject m_card
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_card);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_card), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D1 RID: 1745
	// (get) Token: 0x0600158A RID: 5514 RVA: 0x0005B558 File Offset: 0x00059758
	// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000DEC2 File Offset: 0x0000C0C2
	public unsafe GameObject m_flipCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_flipCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_m_flipCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D2 RID: 1746
	// (get) Token: 0x0600158C RID: 5516 RVA: 0x0005B588 File Offset: 0x00059788
	// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000DEE1 File Offset: 0x0000C0E1
	public unsafe bool bFlipped
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_bFlipped);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_CardGalleryNode.NativeFieldInfoPtr_bFlipped)) = value;
		}
	}

	// Token: 0x04000EDB RID: 3803
	private static readonly IntPtr NativeFieldInfoPtr_s_moveLeft;

	// Token: 0x04000EDC RID: 3804
	private static readonly IntPtr NativeFieldInfoPtr_s_moveRight;

	// Token: 0x04000EDD RID: 3805
	private static readonly IntPtr NativeFieldInfoPtr_s_forceMoveTrigger;

	// Token: 0x04000EDE RID: 3806
	private static readonly IntPtr NativeFieldInfoPtr_s_forceMoveValue;

	// Token: 0x04000EDF RID: 3807
	private static readonly IntPtr NativeFieldInfoPtr_s_flipCard;

	// Token: 0x04000EE0 RID: 3808
	private static readonly IntPtr NativeFieldInfoPtr_s_flipCardH;

	// Token: 0x04000EE1 RID: 3809
	private static readonly IntPtr NativeFieldInfoPtr_m_animator;

	// Token: 0x04000EE2 RID: 3810
	private static readonly IntPtr NativeFieldInfoPtr_m_limbo;

	// Token: 0x04000EE3 RID: 3811
	private static readonly IntPtr NativeFieldInfoPtr_m_index;

	// Token: 0x04000EE4 RID: 3812
	private static readonly IntPtr NativeFieldInfoPtr_m_card;

	// Token: 0x04000EE5 RID: 3813
	private static readonly IntPtr NativeFieldInfoPtr_m_flipCard;

	// Token: 0x04000EE6 RID: 3814
	private static readonly IntPtr NativeFieldInfoPtr_bFlipped;

	// Token: 0x04000EE7 RID: 3815
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x04000EE8 RID: 3816
	private static readonly IntPtr NativeMethodInfoPtr_SetCard_Public_Void_GameObject_GameObject_Int32_Single_0;

	// Token: 0x04000EE9 RID: 3817
	private static readonly IntPtr NativeMethodInfoPtr_ClearCard_Public_Void_0;

	// Token: 0x04000EEA RID: 3818
	private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

	// Token: 0x04000EEB RID: 3819
	private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

	// Token: 0x04000EEC RID: 3820
	private static readonly IntPtr NativeMethodInfoPtr_FlipCard_Public_Void_Boolean_0;

	// Token: 0x04000EED RID: 3821
	private static readonly IntPtr NativeMethodInfoPtr_ForceMove_Public_Void_Int32_0;

	// Token: 0x04000EEE RID: 3822
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
