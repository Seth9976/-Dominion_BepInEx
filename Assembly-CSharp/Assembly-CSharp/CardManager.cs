using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000084 RID: 132
public class CardManager : MonoBehaviour
{
	// Token: 0x06001088 RID: 4232 RVA: 0x0004AF4C File Offset: 0x0004914C
	// Note: this type is marked as 'beforefieldinit'.
	static CardManager()
	{
		Il2CppClassPointerStore<CardManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardManager>.NativeClassPtr);
		CardManager.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "m_AnimationManager");
		CardManager.NativeFieldInfoPtr_m_DragManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "m_DragManager");
		CardManager.NativeFieldInfoPtr_m_MagnifyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "m_MagnifyManager");
		CardManager.NativeFieldInfoPtr_m_MasterCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "m_MasterCardList");
		CardManager.NativeFieldInfoPtr_m_UpdateCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardManager>.NativeClassPtr, "m_UpdateCardList");
		CardManager.NativeMethodInfoPtr_GetMagnifyManager_Public_MagnifyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664515);
		CardManager.NativeMethodInfoPtr_FinishCreateCard_Protected_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664516);
		CardManager.NativeMethodInfoPtr_CreateCard_Public_Virtual_New_GameObject_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664517);
		CardManager.NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_New_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664518);
		CardManager.NativeMethodInfoPtr_GetCardFromInstanceID_Public_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664519);
		CardManager.NativeMethodInfoPtr_CreateTemporaryCardFromInstanceID_Public_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664520);
		CardManager.NativeMethodInfoPtr_DestroyCard_Public_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664521);
		CardManager.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664522);
		CardManager.NativeMethodInfoPtr_AddUpdateCardList_Public_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664523);
		CardManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664524);
		CardManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardManager>.NativeClassPtr, 100664525);
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x0004B0BC File Offset: 0x000492BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MagnifyManager GetMagnifyManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_GetMagnifyManager_Public_MagnifyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<MagnifyManager>(intPtr3) : null;
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x0004B0FC File Offset: 0x000492FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241597, RefRangeEnd = 241598, XrefRangeStart = 241563, XrefRangeEnd = 241597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishCreateCard(GameObject cardObject, int cardInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_FinishCreateCard_Protected_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x0004B14C File Offset: 0x0004934C
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject CreateCard(int cardInstanceID, string cardName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardManager.NativeMethodInfoPtr_CreateCard_Public_Virtual_New_GameObject_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x0004B1B8 File Offset: 0x000493B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241598, XrefRangeEnd = 241609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GameObject CreateCardFromInstanceID(int instanceID, bool bAddToMasterList = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAddToMasterList;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardManager.NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_New_GameObject_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x0004B220 File Offset: 0x00049420
	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 241618, RefRangeEnd = 241655, XrefRangeStart = 241609, XrefRangeEnd = 241618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetCardFromInstanceID(int instanceID, bool bCreateIfNecessary = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCreateIfNecessary;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_GetCardFromInstanceID_Public_GameObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x0004B27C File Offset: 0x0004947C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 241664, RefRangeEnd = 241672, XrefRangeStart = 241655, XrefRangeEnd = 241664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateTemporaryCardFromInstanceID(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_CreateTemporaryCardFromInstanceID_Public_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x0004B2C8 File Offset: 0x000494C8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 241701, RefRangeEnd = 241705, XrefRangeStart = 241672, XrefRangeEnd = 241701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyCard(CardObject destroyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destroyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_DestroyCard_Public_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x0004B30C File Offset: 0x0004950C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241730, RefRangeEnd = 241731, XrefRangeStart = 241705, XrefRangeEnd = 241730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x0004B358 File Offset: 0x00049558
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241737, RefRangeEnd = 241738, XrefRangeStart = 241731, XrefRangeEnd = 241737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddUpdateCardList(CardObject card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_AddUpdateCardList_Public_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x0004B39C File Offset: 0x0004959C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241738, XrefRangeEnd = 241751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x0004B3D0 File Offset: 0x000495D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241762, RefRangeEnd = 241763, XrefRangeStart = 241751, XrefRangeEnd = 241762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x0000B6DD File Offset: 0x000098DD
	public CardManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06001095 RID: 4245 RVA: 0x0004B40C File Offset: 0x0004960C
	// (set) Token: 0x06001096 RID: 4246 RVA: 0x0000B6E6 File Offset: 0x000098E6
	public unsafe AnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x06001097 RID: 4247 RVA: 0x0004B43C File Offset: 0x0004963C
	// (set) Token: 0x06001098 RID: 4248 RVA: 0x0000B705 File Offset: 0x00009905
	public unsafe DragManager m_DragManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_DragManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_DragManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004B46C File Offset: 0x0004966C
	// (set) Token: 0x0600109A RID: 4250 RVA: 0x0000B724 File Offset: 0x00009924
	public unsafe MagnifyManager m_MagnifyManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_MagnifyManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MagnifyManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_MagnifyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x0600109B RID: 4251 RVA: 0x0004B49C File Offset: 0x0004969C
	// (set) Token: 0x0600109C RID: 4252 RVA: 0x0000B743 File Offset: 0x00009943
	public unsafe Hashtable m_MasterCardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_MasterCardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_MasterCardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x0600109D RID: 4253 RVA: 0x0004B4CC File Offset: 0x000496CC
	// (set) Token: 0x0600109E RID: 4254 RVA: 0x0000B762 File Offset: 0x00009962
	public unsafe List<CardObject> m_UpdateCardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_UpdateCardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardManager.NativeFieldInfoPtr_m_UpdateCardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B91 RID: 2961
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000B92 RID: 2962
	private static readonly IntPtr NativeFieldInfoPtr_m_DragManager;

	// Token: 0x04000B93 RID: 2963
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyManager;

	// Token: 0x04000B94 RID: 2964
	private static readonly IntPtr NativeFieldInfoPtr_m_MasterCardList;

	// Token: 0x04000B95 RID: 2965
	private static readonly IntPtr NativeFieldInfoPtr_m_UpdateCardList;

	// Token: 0x04000B96 RID: 2966
	private static readonly IntPtr NativeMethodInfoPtr_GetMagnifyManager_Public_MagnifyManager_0;

	// Token: 0x04000B97 RID: 2967
	private static readonly IntPtr NativeMethodInfoPtr_FinishCreateCard_Protected_Void_GameObject_Int32_0;

	// Token: 0x04000B98 RID: 2968
	private static readonly IntPtr NativeMethodInfoPtr_CreateCard_Public_Virtual_New_GameObject_Int32_String_0;

	// Token: 0x04000B99 RID: 2969
	private static readonly IntPtr NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_New_GameObject_Int32_Boolean_0;

	// Token: 0x04000B9A RID: 2970
	private static readonly IntPtr NativeMethodInfoPtr_GetCardFromInstanceID_Public_GameObject_Int32_Boolean_0;

	// Token: 0x04000B9B RID: 2971
	private static readonly IntPtr NativeMethodInfoPtr_CreateTemporaryCardFromInstanceID_Public_GameObject_Int32_0;

	// Token: 0x04000B9C RID: 2972
	private static readonly IntPtr NativeMethodInfoPtr_DestroyCard_Public_Void_CardObject_0;

	// Token: 0x04000B9D RID: 2973
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0;

	// Token: 0x04000B9E RID: 2974
	private static readonly IntPtr NativeMethodInfoPtr_AddUpdateCardList_Public_Void_CardObject_0;

	// Token: 0x04000B9F RID: 2975
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000BA0 RID: 2976
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
