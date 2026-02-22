using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class AscensionAnimationLocatorResolveCards : AscensionAnimationLocator
{
	// Token: 0x06000199 RID: 409 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationLocatorResolveCards()
	{
		Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationLocatorResolveCards");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr);
		AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, "m_ResolveEventEntryList");
		AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, "m_ResolveEventEntryListCapacity");
		AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, "m_ResolveEventEntryListCount");
		AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_DefaultResolveEventEntryListCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, "m_DefaultResolveEventEntryListCapacity");
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663427);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_ResetResolveCardEntryList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663428);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_RebuildResolveCardEntryList_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663429);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_AddResolveCardEntry_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663430);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_RemoveResolveCardEntry_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663431);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_UpdateResolveCardFromFlags_Private_Void_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663432);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_UpdateAllResolveCardsFromFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663433);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663434);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663435);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663436);
		AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, 100663437);
	}

	// Token: 0x0600019A RID: 410 RVA: 0x0001F834 File Offset: 0x0001DA34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225071, XrefRangeEnd = 225075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019B RID: 411 RVA: 0x0001F868 File Offset: 0x0001DA68
	[CallerCount(0)]
	public unsafe void ResetResolveCardEntryList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_ResetResolveCardEntryList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019C RID: 412 RVA: 0x0001F89C File Offset: 0x0001DA9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225082, RefRangeEnd = 225083, XrefRangeStart = 225075, XrefRangeEnd = 225082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildResolveCardEntryList(int resolve_card_count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolve_card_count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_RebuildResolveCardEntryList_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x0001F8DC File Offset: 0x0001DADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225083, XrefRangeEnd = 225086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddResolveCardEntry(int addInstanceID, int addFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref addInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_AddResolveCardEntry_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x0001F928 File Offset: 0x0001DB28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225086, RefRangeEnd = 225087, XrefRangeStart = 225086, XrefRangeEnd = 225086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveResolveCardEntry(int removeIndex, int removeInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref removeIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_RemoveResolveCardEntry_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600019F RID: 415 RVA: 0x0001F974 File Offset: 0x0001DB74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225092, RefRangeEnd = 225093, XrefRangeStart = 225087, XrefRangeEnd = 225092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateResolveCardFromFlags(AscensionCard ascension_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ascension_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_UpdateResolveCardFromFlags_Private_Void_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225109, RefRangeEnd = 225110, XrefRangeStart = 225093, XrefRangeEnd = 225109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAllResolveCardsFromFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_UpdateAllResolveCardsFromFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x0001F9EC File Offset: 0x0001DBEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225128, RefRangeEnd = 225129, XrefRangeStart = 225110, XrefRangeEnd = 225128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateInsertSiblingIndex(GameObject insert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(insert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x0001FA3C File Offset: 0x0001DC3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225129, XrefRangeEnd = 225162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetPlaceholderParent(GameObject placeholderObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholderObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x0001FA8C File Offset: 0x0001DC8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225162, XrefRangeEnd = 225167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PlaceAnimateObject(AnimateObject animate_object, bool bSetPosition = false, bool bSetRotation = false, bool bIgnoreOverride = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreOverride;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x0001FB04 File Offset: 0x0001DD04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocatorResolveCards()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorResolveCards.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00002E4C File Offset: 0x0000104C
	public AscensionAnimationLocatorResolveCards(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001FB40 File Offset: 0x0001DD40
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002E55 File Offset: 0x00001055
	public unsafe Il2CppStructArray<AscensionAnimationLocatorResolveCards.ResolveCardEntry> m_ResolveEventEntryList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AscensionAnimationLocatorResolveCards.ResolveCardEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001FB70 File Offset: 0x0001DD70
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002E74 File Offset: 0x00001074
	public unsafe int m_ResolveEventEntryListCapacity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCapacity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCapacity)) = value;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060001AA RID: 426 RVA: 0x0001FB98 File Offset: 0x0001DD98
	// (set) Token: 0x060001AB RID: 427 RVA: 0x00002E8F File Offset: 0x0000108F
	public unsafe int m_ResolveEventEntryListCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_ResolveEventEntryListCount)) = value;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060001AC RID: 428 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
	// (set) Token: 0x060001AD RID: 429 RVA: 0x00002EAA File Offset: 0x000010AA
	public unsafe static int m_DefaultResolveEventEntryListCapacity
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_DefaultResolveEventEntryListCapacity, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorResolveCards.NativeFieldInfoPtr_m_DefaultResolveEventEntryListCapacity, (void*)(&value));
		}
	}

	// Token: 0x04000103 RID: 259
	private static readonly IntPtr NativeFieldInfoPtr_m_ResolveEventEntryList;

	// Token: 0x04000104 RID: 260
	private static readonly IntPtr NativeFieldInfoPtr_m_ResolveEventEntryListCapacity;

	// Token: 0x04000105 RID: 261
	private static readonly IntPtr NativeFieldInfoPtr_m_ResolveEventEntryListCount;

	// Token: 0x04000106 RID: 262
	private static readonly IntPtr NativeFieldInfoPtr_m_DefaultResolveEventEntryListCapacity;

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeMethodInfoPtr_ResetResolveCardEntryList_Public_Void_0;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeMethodInfoPtr_RebuildResolveCardEntryList_Public_Void_Int32_0;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeMethodInfoPtr_AddResolveCardEntry_Public_Void_Int32_Int32_0;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeMethodInfoPtr_RemoveResolveCardEntry_Public_Void_Int32_Int32_0;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeMethodInfoPtr_UpdateResolveCardFromFlags_Private_Void_AscensionCard_0;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAllResolveCardsFromFlags_Public_Void_0;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000167 RID: 359
	[StructLayout(2)]
	public struct ResolveCardEntry
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x000820B0 File Offset: 0x000802B0
		// Note: this type is marked as 'beforefieldinit'.
		static ResolveCardEntry()
		{
			Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards.ResolveCardEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards>.NativeClassPtr, "ResolveCardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards.ResolveCardEntry>.NativeClassPtr);
			AscensionAnimationLocatorResolveCards.ResolveCardEntry.NativeFieldInfoPtr_resolveCardInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards.ResolveCardEntry>.NativeClassPtr, "resolveCardInstanceID");
			AscensionAnimationLocatorResolveCards.ResolveCardEntry.NativeFieldInfoPtr_resolveCardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards.ResolveCardEntry>.NativeClassPtr, "resolveCardType");
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00015D0F File Offset: 0x00013F0F
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AscensionAnimationLocatorResolveCards.ResolveCardEntry>.NativeClassPtr, ref this));
		}

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr_resolveCardInstanceID;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr_resolveCardType;

		// Token: 0x04001813 RID: 6163
		[FieldOffset(0)]
		public int resolveCardInstanceID;

		// Token: 0x04001814 RID: 6164
		[FieldOffset(4)]
		public int resolveCardType;
	}
}
