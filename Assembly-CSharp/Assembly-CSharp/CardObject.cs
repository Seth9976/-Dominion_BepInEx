using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000085 RID: 133
public class CardObject : MonoBehaviour
{
	// Token: 0x0600109F RID: 4255 RVA: 0x0004B4FC File Offset: 0x000496FC
	// Note: this type is marked as 'beforefieldinit'.
	static CardObject()
	{
		Il2CppClassPointerStore<CardObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardObject>.NativeClassPtr);
		CardObject.NativeFieldInfoPtr_m_CardHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_CardHighlight");
		CardObject.NativeFieldInfoPtr_m_CardInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_CardInstanceID");
		CardObject.NativeFieldInfoPtr_m_bSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_bSelectable");
		CardObject.NativeFieldInfoPtr_m_bMagnified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_bMagnified");
		CardObject.NativeFieldInfoPtr_m_bMagnifying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_bMagnifying");
		CardObject.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardObject>.NativeClassPtr, "m_CardManager");
		CardObject.NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_New_Void_CardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664526);
		CardObject.NativeMethodInfoPtr_UpdateCard_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664527);
		CardObject.NativeMethodInfoPtr_GetCardInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664528);
		CardObject.NativeMethodInfoPtr_SetCardInstanceID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664529);
		CardObject.NativeMethodInfoPtr_IsSelectable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664530);
		CardObject.NativeMethodInfoPtr_SetSelectable_Public_Virtual_New_Void_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664531);
		CardObject.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664532);
		CardObject.NativeMethodInfoPtr_IsMagnified_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664533);
		CardObject.NativeMethodInfoPtr_IsMagnifying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664534);
		CardObject.NativeMethodInfoPtr_CanMagnify_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664535);
		CardObject.NativeMethodInfoPtr_FinishMagnify_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664536);
		CardObject.NativeMethodInfoPtr_Magnify_Public_Virtual_New_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664537);
		CardObject.NativeMethodInfoPtr_MagnifyWithExistingPlaceholder_Public_Virtual_New_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664538);
		CardObject.NativeMethodInfoPtr_FinishUnmagnify_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664539);
		CardObject.NativeMethodInfoPtr_Unmagnify_Public_Virtual_New_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664540);
		CardObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardObject>.NativeClassPtr, 100664541);
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x0004B6E4 File Offset: 0x000498E4
	[CallerCount(0)]
	public unsafe virtual void SetupCallbacks(CardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_New_Void_CardManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x0004B734 File Offset: 0x00049934
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UpdateCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_UpdateCard_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x0004B77C File Offset: 0x0004997C
	[CallerCount(0)]
	public unsafe int GetCardInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_GetCardInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0004B7B8 File Offset: 0x000499B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241763, XrefRangeEnd = 241770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardInstanceID(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_SetCardInstanceID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x0004B7F8 File Offset: 0x000499F8
	[CallerCount(0)]
	public unsafe bool IsSelectable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_IsSelectable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x0004B834 File Offset: 0x00049A34
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241776, RefRangeEnd = 241777, XrefRangeStart = 241770, XrefRangeEnd = 241776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetSelectable(bool bSelectable, Color highlightColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSelectable;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_SetSelectable_Public_Virtual_New_Void_Boolean_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x0004B88C File Offset: 0x00049A8C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 241806, RefRangeEnd = 241811, XrefRangeStart = 241777, XrefRangeEnd = 241806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight, bool bExcludeIfAnimating = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bExcludeIfAnimating;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x0004B8D8 File Offset: 0x00049AD8
	[CallerCount(0)]
	public unsafe bool IsMagnified()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_IsMagnified_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0004B914 File Offset: 0x00049B14
	[CallerCount(0)]
	public unsafe bool IsMagnifying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_IsMagnifying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x0004B950 File Offset: 0x00049B50
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool CanMagnify(bool bAllowShowingCardBack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAllowShowingCardBack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_CanMagnify_Public_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0004B9A4 File Offset: 0x00049BA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241811, RefRangeEnd = 241812, XrefRangeStart = 241811, XrefRangeEnd = 241811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishMagnify()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr_FinishMagnify_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x0004B9D8 File Offset: 0x00049BD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241812, XrefRangeEnd = 241842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Magnify(bool bAllowShowingCardBack, bool bTutorialMagnify)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAllowShowingCardBack;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTutorialMagnify;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_Magnify_Public_Virtual_New_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0004BA3C File Offset: 0x00049C3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241842, XrefRangeEnd = 241855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool MagnifyWithExistingPlaceholder(bool bAllowShowingCardBack, bool bTutorialMagnify)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAllowShowingCardBack;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bTutorialMagnify;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_MagnifyWithExistingPlaceholder_Public_Virtual_New_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x0004BAA0 File Offset: 0x00049CA0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241811, RefRangeEnd = 241812, XrefRangeStart = 241811, XrefRangeEnd = 241812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void FinishUnmagnify()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_FinishUnmagnify_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x0004BADC File Offset: 0x00049CDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241855, XrefRangeEnd = 241862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Unmagnify(bool bTutorialUnmagnify, bool bAllowCancelOption = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bTutorialUnmagnify;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowCancelOption;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardObject.NativeMethodInfoPtr_Unmagnify_Public_Virtual_New_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x0004BB40 File Offset: 0x00049D40
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x0000B781 File Offset: 0x00009981
	public CardObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0004BB7C File Offset: 0x00049D7C
	// (set) Token: 0x060010B2 RID: 4274 RVA: 0x0000B78A File Offset: 0x0000998A
	public unsafe GameObject m_CardHighlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardHighlight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x060010B3 RID: 4275 RVA: 0x0004BBAC File Offset: 0x00049DAC
	// (set) Token: 0x060010B4 RID: 4276 RVA: 0x0000B7A9 File Offset: 0x000099A9
	public unsafe int m_CardInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardInstanceID)) = value;
		}
	}

	// Token: 0x1700057D RID: 1405
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0004BBD4 File Offset: 0x00049DD4
	// (set) Token: 0x060010B6 RID: 4278 RVA: 0x0000B7C4 File Offset: 0x000099C4
	public unsafe bool m_bSelectable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bSelectable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bSelectable)) = value;
		}
	}

	// Token: 0x1700057E RID: 1406
	// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0004BBFC File Offset: 0x00049DFC
	// (set) Token: 0x060010B8 RID: 4280 RVA: 0x0000B7DF File Offset: 0x000099DF
	public unsafe bool m_bMagnified
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bMagnified);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bMagnified)) = value;
		}
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0004BC24 File Offset: 0x00049E24
	// (set) Token: 0x060010BA RID: 4282 RVA: 0x0000B7FA File Offset: 0x000099FA
	public unsafe bool m_bMagnifying
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bMagnifying);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_bMagnifying)) = value;
		}
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x060010BB RID: 4283 RVA: 0x0004BC4C File Offset: 0x00049E4C
	// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000B815 File Offset: 0x00009A15
	public unsafe CardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardObject.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000BA1 RID: 2977
	private static readonly IntPtr NativeFieldInfoPtr_m_CardHighlight;

	// Token: 0x04000BA2 RID: 2978
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInstanceID;

	// Token: 0x04000BA3 RID: 2979
	private static readonly IntPtr NativeFieldInfoPtr_m_bSelectable;

	// Token: 0x04000BA4 RID: 2980
	private static readonly IntPtr NativeFieldInfoPtr_m_bMagnified;

	// Token: 0x04000BA5 RID: 2981
	private static readonly IntPtr NativeFieldInfoPtr_m_bMagnifying;

	// Token: 0x04000BA6 RID: 2982
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000BA7 RID: 2983
	private static readonly IntPtr NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_New_Void_CardManager_0;

	// Token: 0x04000BA8 RID: 2984
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCard_Public_Virtual_New_Boolean_0;

	// Token: 0x04000BA9 RID: 2985
	private static readonly IntPtr NativeMethodInfoPtr_GetCardInstanceID_Public_Int32_0;

	// Token: 0x04000BAA RID: 2986
	private static readonly IntPtr NativeMethodInfoPtr_SetCardInstanceID_Public_Void_Int32_0;

	// Token: 0x04000BAB RID: 2987
	private static readonly IntPtr NativeMethodInfoPtr_IsSelectable_Public_Boolean_0;

	// Token: 0x04000BAC RID: 2988
	private static readonly IntPtr NativeMethodInfoPtr_SetSelectable_Public_Virtual_New_Void_Boolean_Color_0;

	// Token: 0x04000BAD RID: 2989
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0;

	// Token: 0x04000BAE RID: 2990
	private static readonly IntPtr NativeMethodInfoPtr_IsMagnified_Public_Boolean_0;

	// Token: 0x04000BAF RID: 2991
	private static readonly IntPtr NativeMethodInfoPtr_IsMagnifying_Public_Boolean_0;

	// Token: 0x04000BB0 RID: 2992
	private static readonly IntPtr NativeMethodInfoPtr_CanMagnify_Public_Virtual_New_Boolean_Boolean_0;

	// Token: 0x04000BB1 RID: 2993
	private static readonly IntPtr NativeMethodInfoPtr_FinishMagnify_Public_Void_0;

	// Token: 0x04000BB2 RID: 2994
	private static readonly IntPtr NativeMethodInfoPtr_Magnify_Public_Virtual_New_Boolean_Boolean_Boolean_0;

	// Token: 0x04000BB3 RID: 2995
	private static readonly IntPtr NativeMethodInfoPtr_MagnifyWithExistingPlaceholder_Public_Virtual_New_Boolean_Boolean_Boolean_0;

	// Token: 0x04000BB4 RID: 2996
	private static readonly IntPtr NativeMethodInfoPtr_FinishUnmagnify_Public_Virtual_New_Void_0;

	// Token: 0x04000BB5 RID: 2997
	private static readonly IntPtr NativeMethodInfoPtr_Unmagnify_Public_Virtual_New_Boolean_Boolean_Boolean_0;

	// Token: 0x04000BB6 RID: 2998
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
