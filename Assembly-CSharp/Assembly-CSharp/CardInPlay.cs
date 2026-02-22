using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000083 RID: 131
public class CardInPlay : MonoBehaviour
{
	// Token: 0x06001078 RID: 4216 RVA: 0x0004ABB0 File Offset: 0x00048DB0
	// Note: this type is marked as 'beforefieldinit'.
	static CardInPlay()
	{
		Il2CppClassPointerStore<CardInPlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardInPlay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr);
		CardInPlay.NativeFieldInfoPtr_m_CardInPlayInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, "m_CardInPlayInstanceID");
		CardInPlay.NativeFieldInfoPtr_m_SourceCardInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, "m_SourceCardInstanceID");
		CardInPlay.NativeFieldInfoPtr_m_SourceCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, "m_SourceCard");
		CardInPlay.NativeMethodInfoPtr_GetCardInPlayInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664507);
		CardInPlay.NativeMethodInfoPtr_SetCardInPlayInstanceID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664508);
		CardInPlay.NativeMethodInfoPtr_GetSourceCardInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664509);
		CardInPlay.NativeMethodInfoPtr_GetSourceCard_Public_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664510);
		CardInPlay.NativeMethodInfoPtr_SetSourceCard_Public_Virtual_New_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664511);
		CardInPlay.NativeMethodInfoPtr_SetSourceCardInstanceID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664512);
		CardInPlay.NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664513);
		CardInPlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr, 100664514);
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x0004ACBC File Offset: 0x00048EBC
	[CallerCount(0)]
	public unsafe int GetCardInPlayInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr_GetCardInPlayInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x0004ACF8 File Offset: 0x00048EF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardInPlayInstanceID(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr_SetCardInPlayInstanceID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600107B RID: 4219 RVA: 0x0004AD38 File Offset: 0x00048F38
	[CallerCount(0)]
	public unsafe int GetSourceCardInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr_GetSourceCardInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600107C RID: 4220 RVA: 0x0004AD74 File Offset: 0x00048F74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardObject GetSourceCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr_GetSourceCard_Public_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr3) : null;
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x0004ADB4 File Offset: 0x00048FB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241558, RefRangeEnd = 241559, XrefRangeStart = 241554, XrefRangeEnd = 241558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetSourceCard(CardObject sourceCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardInPlay.NativeMethodInfoPtr_SetSourceCard_Public_Virtual_New_Void_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x0004AE04 File Offset: 0x00049004
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241559, XrefRangeEnd = 241563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSourceCardInstanceID(int sourceCardInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref sourceCardInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr_SetSourceCardInstanceID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x0004AE44 File Offset: 0x00049044
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardInPlay.NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x0004AE90 File Offset: 0x00049090
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardInPlay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardInPlay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardInPlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x0000B67F File Offset: 0x0000987F
	public CardInPlay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x06001082 RID: 4226 RVA: 0x0004AECC File Offset: 0x000490CC
	// (set) Token: 0x06001083 RID: 4227 RVA: 0x0000B688 File Offset: 0x00009888
	public unsafe int m_CardInPlayInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_CardInPlayInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_CardInPlayInstanceID)) = value;
		}
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06001084 RID: 4228 RVA: 0x0004AEF4 File Offset: 0x000490F4
	// (set) Token: 0x06001085 RID: 4229 RVA: 0x0000B6A3 File Offset: 0x000098A3
	public unsafe int m_SourceCardInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_SourceCardInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_SourceCardInstanceID)) = value;
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06001086 RID: 4230 RVA: 0x0004AF1C File Offset: 0x0004911C
	// (set) Token: 0x06001087 RID: 4231 RVA: 0x0000B6BE File Offset: 0x000098BE
	public unsafe CardObject m_SourceCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_SourceCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlay.NativeFieldInfoPtr_m_SourceCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B86 RID: 2950
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInPlayInstanceID;

	// Token: 0x04000B87 RID: 2951
	private static readonly IntPtr NativeFieldInfoPtr_m_SourceCardInstanceID;

	// Token: 0x04000B88 RID: 2952
	private static readonly IntPtr NativeFieldInfoPtr_m_SourceCard;

	// Token: 0x04000B89 RID: 2953
	private static readonly IntPtr NativeMethodInfoPtr_GetCardInPlayInstanceID_Public_Int32_0;

	// Token: 0x04000B8A RID: 2954
	private static readonly IntPtr NativeMethodInfoPtr_SetCardInPlayInstanceID_Public_Void_Int32_0;

	// Token: 0x04000B8B RID: 2955
	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCardInstanceID_Public_Int32_0;

	// Token: 0x04000B8C RID: 2956
	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCard_Public_CardObject_0;

	// Token: 0x04000B8D RID: 2957
	private static readonly IntPtr NativeMethodInfoPtr_SetSourceCard_Public_Virtual_New_Void_CardObject_0;

	// Token: 0x04000B8E RID: 2958
	private static readonly IntPtr NativeMethodInfoPtr_SetSourceCardInstanceID_Public_Void_Int32_0;

	// Token: 0x04000B8F RID: 2959
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_New_Void_Boolean_0;

	// Token: 0x04000B90 RID: 2960
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
