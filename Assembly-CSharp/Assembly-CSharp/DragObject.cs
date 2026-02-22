using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000087 RID: 135
public class DragObject : AnimateObject
{
	// Token: 0x060010DE RID: 4318 RVA: 0x0004C424 File Offset: 0x0004A624
	// Note: this type is marked as 'beforefieldinit'.
	static DragObject()
	{
		Il2CppClassPointerStore<DragObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DragObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragObject>.NativeClassPtr);
		DragObject.NativeFieldInfoPtr_m_DragManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragManager");
		DragObject.NativeFieldInfoPtr_m_DragSelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragSelectionID");
		DragObject.NativeFieldInfoPtr_m_DragSelectionOverrideID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragSelectionOverrideID");
		DragObject.NativeFieldInfoPtr_m_DragSelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragSelectionHint");
		DragObject.NativeFieldInfoPtr_m_ReturnPlaceholder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_ReturnPlaceholder");
		DragObject.NativeFieldInfoPtr_m_bReturnToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bReturnToParent");
		DragObject.NativeFieldInfoPtr_m_DragReturnToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragReturnToParent");
		DragObject.NativeFieldInfoPtr_m_DragCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragCanvas");
		DragObject.NativeFieldInfoPtr_m_DragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_DragOffset");
		DragObject.NativeFieldInfoPtr_m_bTargetDragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bTargetDragOffset");
		DragObject.NativeFieldInfoPtr_m_TargetDragOffsetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_TargetDragOffsetTime");
		DragObject.NativeFieldInfoPtr_m_TargetDragOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_TargetDragOffset");
		DragObject.NativeFieldInfoPtr_m_OverrideDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_OverrideDragCallback");
		DragObject.NativeFieldInfoPtr_m_OnBeginDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_OnBeginDragCallback");
		DragObject.NativeFieldInfoPtr_m_OnEndDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_OnEndDragCallback");
		DragObject.NativeFieldInfoPtr_m_OnDragHintCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_OnDragHintCallback");
		DragObject.NativeFieldInfoPtr_m_bIsDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bIsDraggable");
		DragObject.NativeFieldInfoPtr_m_bSendHorizontalDragToParentScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bSendHorizontalDragToParentScrollRect");
		DragObject.NativeFieldInfoPtr_m_bSendVerticalDragToParentScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bSendVerticalDragToParentScrollRect");
		DragObject.NativeFieldInfoPtr_m_bIsDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "m_bIsDragging");
		DragObject.NativeFieldInfoPtr_k_SendDragToParentScrollRectThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "k_SendDragToParentScrollRectThreshold");
		DragObject.NativeMethodInfoPtr_SetDragManager_Public_Void_DragManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664559);
		DragObject.NativeMethodInfoPtr_GetDragManager_Public_DragManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664560);
		DragObject.NativeMethodInfoPtr_GetDragSelectionID_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664561);
		DragObject.NativeMethodInfoPtr_SetDragSelectionID_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664562);
		DragObject.NativeMethodInfoPtr_SetDragSelectionOverrideID_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664563);
		DragObject.NativeMethodInfoPtr_GetDragSelectionHint_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664564);
		DragObject.NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664565);
		DragObject.NativeMethodInfoPtr_SetIsDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664566);
		DragObject.NativeMethodInfoPtr_SetSendHorizontalDragToParentScrollRect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664567);
		DragObject.NativeMethodInfoPtr_SetSendVerticalDragToParentScrollRect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664568);
		DragObject.NativeMethodInfoPtr_GetReturnPlaceholder_Public_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664569);
		DragObject.NativeMethodInfoPtr_DestroyReturnPlaceholder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664570);
		DragObject.NativeMethodInfoPtr_UpdateReturnPlaceholder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664571);
		DragObject.NativeMethodInfoPtr_GetReturnToParent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664572);
		DragObject.NativeMethodInfoPtr_ClearReturnToParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664573);
		DragObject.NativeMethodInfoPtr_AnimateToReturnPlaceholder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664574);
		DragObject.NativeMethodInfoPtr_AssignToReturnPlaceholder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664575);
		DragObject.NativeMethodInfoPtr_AddOverrideDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664576);
		DragObject.NativeMethodInfoPtr_RemoveOverrideDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664577);
		DragObject.NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664578);
		DragObject.NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664579);
		DragObject.NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664580);
		DragObject.NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664581);
		DragObject.NativeMethodInfoPtr_AddOnDragHintCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664582);
		DragObject.NativeMethodInfoPtr_RemoveOnDragHintCallback_Public_Void_DragObjectCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664583);
		DragObject.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664584);
		DragObject.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664585);
		DragObject.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664586);
		DragObject.NativeMethodInfoPtr_OnCancelDrag_Public_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664587);
		DragObject.NativeMethodInfoPtr_UpdateDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664588);
		DragObject.NativeMethodInfoPtr_ClearDragReturnParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664589);
		DragObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject>.NativeClassPtr, 100664590);
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x0004C878 File Offset: 0x0004AA78
	[CallerCount(0)]
	public unsafe void SetDragManager(DragManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetDragManager_Public_Void_DragManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0004C8BC File Offset: 0x0004AABC
	[CallerCount(0)]
	public unsafe DragManager GetDragManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_GetDragManager_Public_DragManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr3) : null;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x0004C8FC File Offset: 0x0004AAFC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 242008, RefRangeEnd = 242013, XrefRangeStart = 242008, XrefRangeEnd = 242008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort GetDragSelectionID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_GetDragSelectionID_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0004C938 File Offset: 0x0004AB38
	[CallerCount(0)]
	public unsafe void SetDragSelectionID(ushort selection_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selection_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetDragSelectionID_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0004C978 File Offset: 0x0004AB78
	[CallerCount(0)]
	public unsafe void SetDragSelectionOverrideID(ushort selection_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selection_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetDragSelectionOverrideID_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0004C9B8 File Offset: 0x0004ABB8
	[CallerCount(0)]
	public unsafe ushort GetDragSelectionHint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_GetDragSelectionHint_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0004C9F4 File Offset: 0x0004ABF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242013, XrefRangeEnd = 242014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragSelectionHint(ushort selection_hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selection_hint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0004CA34 File Offset: 0x0004AC34
	[CallerCount(0)]
	public unsafe void SetIsDraggable(bool bDraggable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bDraggable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetIsDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0004CA74 File Offset: 0x0004AC74
	[CallerCount(0)]
	public unsafe void SetSendHorizontalDragToParentScrollRect(bool bSend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetSendHorizontalDragToParentScrollRect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
	[CallerCount(0)]
	public unsafe void SetSendVerticalDragToParentScrollRect(bool bSend)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_SetSendVerticalDragToParentScrollRect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x0004CAF4 File Offset: 0x0004ACF4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242039, RefRangeEnd = 242041, XrefRangeStart = 242014, XrefRangeEnd = 242039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetReturnPlaceholder(bool bCreateIfNecessary = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bCreateIfNecessary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_GetReturnPlaceholder_Public_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x0004CB40 File Offset: 0x0004AD40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242048, RefRangeEnd = 242050, XrefRangeStart = 242041, XrefRangeEnd = 242048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyReturnPlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_DestroyReturnPlaceholder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x0004CB74 File Offset: 0x0004AD74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242082, RefRangeEnd = 242083, XrefRangeStart = 242050, XrefRangeEnd = 242082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateReturnPlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_UpdateReturnPlaceholder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
	[CallerCount(0)]
	public unsafe bool GetReturnToParent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_GetReturnToParent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x0004CBE4 File Offset: 0x0004ADE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242083, RefRangeEnd = 242084, XrefRangeStart = 242083, XrefRangeEnd = 242083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearReturnToParent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_ClearReturnToParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x0004CC18 File Offset: 0x0004AE18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242092, RefRangeEnd = 242093, XrefRangeStart = 242084, XrefRangeEnd = 242092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimateToReturnPlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AnimateToReturnPlaceholder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0004CC4C File Offset: 0x0004AE4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242093, XrefRangeEnd = 242109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignToReturnPlaceholder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AssignToReturnPlaceholder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x0004CC80 File Offset: 0x0004AE80
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242112, RefRangeEnd = 242116, XrefRangeStart = 242109, XrefRangeEnd = 242112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOverrideDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AddOverrideDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x0004CCC4 File Offset: 0x0004AEC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242116, XrefRangeEnd = 242119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOverrideDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_RemoveOverrideDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0004CD08 File Offset: 0x0004AF08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242122, RefRangeEnd = 242123, XrefRangeStart = 242119, XrefRangeEnd = 242122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnBeginDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x0004CD4C File Offset: 0x0004AF4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242123, XrefRangeEnd = 242126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnBeginDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x0004CD90 File Offset: 0x0004AF90
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242129, RefRangeEnd = 242133, XrefRangeStart = 242126, XrefRangeEnd = 242129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnEndDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242136, RefRangeEnd = 242137, XrefRangeStart = 242133, XrefRangeEnd = 242136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnEndDragCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x0004CE18 File Offset: 0x0004B018
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242140, RefRangeEnd = 242141, XrefRangeStart = 242137, XrefRangeEnd = 242140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnDragHintCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_AddOnDragHintCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x0004CE5C File Offset: 0x0004B05C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242141, XrefRangeEnd = 242144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnDragHintCallback(DragObject.DragObjectCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_RemoveOnDragHintCallback_Public_Void_DragObjectCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 242174, RefRangeEnd = 242178, XrefRangeStart = 242144, XrefRangeEnd = 242174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeginDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x0004CEE4 File Offset: 0x0004B0E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242199, RefRangeEnd = 242201, XrefRangeStart = 242178, XrefRangeEnd = 242199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEndDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x0004CF28 File Offset: 0x0004B128
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242201, XrefRangeEnd = 242232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x0004CF6C File Offset: 0x0004B16C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242232, XrefRangeEnd = 242234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCancelDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_OnCancelDrag_Public_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242239, RefRangeEnd = 242240, XrefRangeStart = 242234, XrefRangeEnd = 242239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_UpdateDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x0004CFE4 File Offset: 0x0004B1E4
	[CallerCount(0)]
	public unsafe void ClearDragReturnParent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr_ClearDragReturnParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x0004D018 File Offset: 0x0004B218
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 242243, RefRangeEnd = 242245, XrefRangeStart = 242240, XrefRangeEnd = 242243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x0000B916 File Offset: 0x00009B16
	public DragObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x06001100 RID: 4352 RVA: 0x0004D054 File Offset: 0x0004B254
	// (set) Token: 0x06001101 RID: 4353 RVA: 0x0000B91F File Offset: 0x00009B1F
	public unsafe DragManager m_DragManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x06001102 RID: 4354 RVA: 0x0004D084 File Offset: 0x0004B284
	// (set) Token: 0x06001103 RID: 4355 RVA: 0x0000B93E File Offset: 0x00009B3E
	public unsafe ushort m_DragSelectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionID)) = value;
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x06001104 RID: 4356 RVA: 0x0004D0AC File Offset: 0x0004B2AC
	// (set) Token: 0x06001105 RID: 4357 RVA: 0x0000B959 File Offset: 0x00009B59
	public unsafe ushort m_DragSelectionOverrideID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionOverrideID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionOverrideID)) = value;
		}
	}

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x06001106 RID: 4358 RVA: 0x0004D0D4 File Offset: 0x0004B2D4
	// (set) Token: 0x06001107 RID: 4359 RVA: 0x0000B974 File Offset: 0x00009B74
	public unsafe ushort m_DragSelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragSelectionHint)) = value;
		}
	}

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x06001108 RID: 4360 RVA: 0x0004D0FC File Offset: 0x0004B2FC
	// (set) Token: 0x06001109 RID: 4361 RVA: 0x0000B98F File Offset: 0x00009B8F
	public unsafe GameObject m_ReturnPlaceholder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_ReturnPlaceholder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_ReturnPlaceholder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x0600110A RID: 4362 RVA: 0x0004D12C File Offset: 0x0004B32C
	// (set) Token: 0x0600110B RID: 4363 RVA: 0x0000B9AE File Offset: 0x00009BAE
	public unsafe bool m_bReturnToParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bReturnToParent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bReturnToParent)) = value;
		}
	}

	// Token: 0x1700058E RID: 1422
	// (get) Token: 0x0600110C RID: 4364 RVA: 0x0004D154 File Offset: 0x0004B354
	// (set) Token: 0x0600110D RID: 4365 RVA: 0x0000B9C9 File Offset: 0x00009BC9
	public unsafe Transform m_DragReturnToParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragReturnToParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragReturnToParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700058F RID: 1423
	// (get) Token: 0x0600110E RID: 4366 RVA: 0x0004D184 File Offset: 0x0004B384
	// (set) Token: 0x0600110F RID: 4367 RVA: 0x0000B9E8 File Offset: 0x00009BE8
	public unsafe Canvas m_DragCanvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragCanvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x06001110 RID: 4368 RVA: 0x0004D1B4 File Offset: 0x0004B3B4
	// (set) Token: 0x06001111 RID: 4369 RVA: 0x0000BA07 File Offset: 0x00009C07
	public unsafe Vector3 m_DragOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_DragOffset)) = value;
		}
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x06001112 RID: 4370 RVA: 0x0004D1DC File Offset: 0x0004B3DC
	// (set) Token: 0x06001113 RID: 4371 RVA: 0x0000BA22 File Offset: 0x00009C22
	public unsafe bool m_bTargetDragOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bTargetDragOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bTargetDragOffset)) = value;
		}
	}

	// Token: 0x17000592 RID: 1426
	// (get) Token: 0x06001114 RID: 4372 RVA: 0x0004D204 File Offset: 0x0004B404
	// (set) Token: 0x06001115 RID: 4373 RVA: 0x0000BA3D File Offset: 0x00009C3D
	public unsafe float m_TargetDragOffsetTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_TargetDragOffsetTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_TargetDragOffsetTime)) = value;
		}
	}

	// Token: 0x17000593 RID: 1427
	// (get) Token: 0x06001116 RID: 4374 RVA: 0x0004D22C File Offset: 0x0004B42C
	// (set) Token: 0x06001117 RID: 4375 RVA: 0x0000BA58 File Offset: 0x00009C58
	public unsafe Vector3 m_TargetDragOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_TargetDragOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_TargetDragOffset)) = value;
		}
	}

	// Token: 0x17000594 RID: 1428
	// (get) Token: 0x06001118 RID: 4376 RVA: 0x0004D254 File Offset: 0x0004B454
	// (set) Token: 0x06001119 RID: 4377 RVA: 0x0000BA73 File Offset: 0x00009C73
	public unsafe DragObject.DragObjectCallback m_OverrideDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OverrideDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragObject.DragObjectCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OverrideDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000595 RID: 1429
	// (get) Token: 0x0600111A RID: 4378 RVA: 0x0004D284 File Offset: 0x0004B484
	// (set) Token: 0x0600111B RID: 4379 RVA: 0x0000BA92 File Offset: 0x00009C92
	public unsafe DragObject.DragObjectCallback m_OnBeginDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnBeginDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragObject.DragObjectCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnBeginDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000596 RID: 1430
	// (get) Token: 0x0600111C RID: 4380 RVA: 0x0004D2B4 File Offset: 0x0004B4B4
	// (set) Token: 0x0600111D RID: 4381 RVA: 0x0000BAB1 File Offset: 0x00009CB1
	public unsafe DragObject.DragObjectCallback m_OnEndDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnEndDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragObject.DragObjectCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnEndDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000597 RID: 1431
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x0004D2E4 File Offset: 0x0004B4E4
	// (set) Token: 0x0600111F RID: 4383 RVA: 0x0000BAD0 File Offset: 0x00009CD0
	public unsafe DragObject.DragObjectCallback m_OnDragHintCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnDragHintCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragObject.DragObjectCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_OnDragHintCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000598 RID: 1432
	// (get) Token: 0x06001120 RID: 4384 RVA: 0x0004D314 File Offset: 0x0004B514
	// (set) Token: 0x06001121 RID: 4385 RVA: 0x0000BAEF File Offset: 0x00009CEF
	public unsafe bool m_bIsDraggable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bIsDraggable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bIsDraggable)) = value;
		}
	}

	// Token: 0x17000599 RID: 1433
	// (get) Token: 0x06001122 RID: 4386 RVA: 0x0004D33C File Offset: 0x0004B53C
	// (set) Token: 0x06001123 RID: 4387 RVA: 0x0000BB0A File Offset: 0x00009D0A
	public unsafe bool m_bSendHorizontalDragToParentScrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bSendHorizontalDragToParentScrollRect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bSendHorizontalDragToParentScrollRect)) = value;
		}
	}

	// Token: 0x1700059A RID: 1434
	// (get) Token: 0x06001124 RID: 4388 RVA: 0x0004D364 File Offset: 0x0004B564
	// (set) Token: 0x06001125 RID: 4389 RVA: 0x0000BB25 File Offset: 0x00009D25
	public unsafe bool m_bSendVerticalDragToParentScrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bSendVerticalDragToParentScrollRect);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bSendVerticalDragToParentScrollRect)) = value;
		}
	}

	// Token: 0x1700059B RID: 1435
	// (get) Token: 0x06001126 RID: 4390 RVA: 0x0004D38C File Offset: 0x0004B58C
	// (set) Token: 0x06001127 RID: 4391 RVA: 0x0000BB40 File Offset: 0x00009D40
	public unsafe bool m_bIsDragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bIsDragging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragObject.NativeFieldInfoPtr_m_bIsDragging)) = value;
		}
	}

	// Token: 0x1700059C RID: 1436
	// (get) Token: 0x06001128 RID: 4392 RVA: 0x0004D3B4 File Offset: 0x0004B5B4
	// (set) Token: 0x06001129 RID: 4393 RVA: 0x0000BB5B File Offset: 0x00009D5B
	public unsafe static float k_SendDragToParentScrollRectThreshold
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(DragObject.NativeFieldInfoPtr_k_SendDragToParentScrollRectThreshold, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(DragObject.NativeFieldInfoPtr_k_SendDragToParentScrollRectThreshold, (void*)(&value));
		}
	}

	// Token: 0x04000BCF RID: 3023
	private static readonly IntPtr NativeFieldInfoPtr_m_DragManager;

	// Token: 0x04000BD0 RID: 3024
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionID;

	// Token: 0x04000BD1 RID: 3025
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionOverrideID;

	// Token: 0x04000BD2 RID: 3026
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionHint;

	// Token: 0x04000BD3 RID: 3027
	private static readonly IntPtr NativeFieldInfoPtr_m_ReturnPlaceholder;

	// Token: 0x04000BD4 RID: 3028
	private static readonly IntPtr NativeFieldInfoPtr_m_bReturnToParent;

	// Token: 0x04000BD5 RID: 3029
	private static readonly IntPtr NativeFieldInfoPtr_m_DragReturnToParent;

	// Token: 0x04000BD6 RID: 3030
	private static readonly IntPtr NativeFieldInfoPtr_m_DragCanvas;

	// Token: 0x04000BD7 RID: 3031
	private static readonly IntPtr NativeFieldInfoPtr_m_DragOffset;

	// Token: 0x04000BD8 RID: 3032
	private static readonly IntPtr NativeFieldInfoPtr_m_bTargetDragOffset;

	// Token: 0x04000BD9 RID: 3033
	private static readonly IntPtr NativeFieldInfoPtr_m_TargetDragOffsetTime;

	// Token: 0x04000BDA RID: 3034
	private static readonly IntPtr NativeFieldInfoPtr_m_TargetDragOffset;

	// Token: 0x04000BDB RID: 3035
	private static readonly IntPtr NativeFieldInfoPtr_m_OverrideDragCallback;

	// Token: 0x04000BDC RID: 3036
	private static readonly IntPtr NativeFieldInfoPtr_m_OnBeginDragCallback;

	// Token: 0x04000BDD RID: 3037
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEndDragCallback;

	// Token: 0x04000BDE RID: 3038
	private static readonly IntPtr NativeFieldInfoPtr_m_OnDragHintCallback;

	// Token: 0x04000BDF RID: 3039
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsDraggable;

	// Token: 0x04000BE0 RID: 3040
	private static readonly IntPtr NativeFieldInfoPtr_m_bSendHorizontalDragToParentScrollRect;

	// Token: 0x04000BE1 RID: 3041
	private static readonly IntPtr NativeFieldInfoPtr_m_bSendVerticalDragToParentScrollRect;

	// Token: 0x04000BE2 RID: 3042
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsDragging;

	// Token: 0x04000BE3 RID: 3043
	private static readonly IntPtr NativeFieldInfoPtr_k_SendDragToParentScrollRectThreshold;

	// Token: 0x04000BE4 RID: 3044
	private static readonly IntPtr NativeMethodInfoPtr_SetDragManager_Public_Void_DragManager_0;

	// Token: 0x04000BE5 RID: 3045
	private static readonly IntPtr NativeMethodInfoPtr_GetDragManager_Public_DragManager_0;

	// Token: 0x04000BE6 RID: 3046
	private static readonly IntPtr NativeMethodInfoPtr_GetDragSelectionID_Public_UInt16_0;

	// Token: 0x04000BE7 RID: 3047
	private static readonly IntPtr NativeMethodInfoPtr_SetDragSelectionID_Public_Void_UInt16_0;

	// Token: 0x04000BE8 RID: 3048
	private static readonly IntPtr NativeMethodInfoPtr_SetDragSelectionOverrideID_Public_Void_UInt16_0;

	// Token: 0x04000BE9 RID: 3049
	private static readonly IntPtr NativeMethodInfoPtr_GetDragSelectionHint_Public_UInt16_0;

	// Token: 0x04000BEA RID: 3050
	private static readonly IntPtr NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_0;

	// Token: 0x04000BEB RID: 3051
	private static readonly IntPtr NativeMethodInfoPtr_SetIsDraggable_Public_Void_Boolean_0;

	// Token: 0x04000BEC RID: 3052
	private static readonly IntPtr NativeMethodInfoPtr_SetSendHorizontalDragToParentScrollRect_Public_Void_Boolean_0;

	// Token: 0x04000BED RID: 3053
	private static readonly IntPtr NativeMethodInfoPtr_SetSendVerticalDragToParentScrollRect_Public_Void_Boolean_0;

	// Token: 0x04000BEE RID: 3054
	private static readonly IntPtr NativeMethodInfoPtr_GetReturnPlaceholder_Public_GameObject_Boolean_0;

	// Token: 0x04000BEF RID: 3055
	private static readonly IntPtr NativeMethodInfoPtr_DestroyReturnPlaceholder_Private_Void_0;

	// Token: 0x04000BF0 RID: 3056
	private static readonly IntPtr NativeMethodInfoPtr_UpdateReturnPlaceholder_Private_Void_0;

	// Token: 0x04000BF1 RID: 3057
	private static readonly IntPtr NativeMethodInfoPtr_GetReturnToParent_Public_Boolean_0;

	// Token: 0x04000BF2 RID: 3058
	private static readonly IntPtr NativeMethodInfoPtr_ClearReturnToParent_Public_Void_0;

	// Token: 0x04000BF3 RID: 3059
	private static readonly IntPtr NativeMethodInfoPtr_AnimateToReturnPlaceholder_Public_Void_0;

	// Token: 0x04000BF4 RID: 3060
	private static readonly IntPtr NativeMethodInfoPtr_AssignToReturnPlaceholder_Public_Void_0;

	// Token: 0x04000BF5 RID: 3061
	private static readonly IntPtr NativeMethodInfoPtr_AddOverrideDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BF6 RID: 3062
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOverrideDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BF7 RID: 3063
	private static readonly IntPtr NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BF8 RID: 3064
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BF9 RID: 3065
	private static readonly IntPtr NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BFA RID: 3066
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BFB RID: 3067
	private static readonly IntPtr NativeMethodInfoPtr_AddOnDragHintCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BFC RID: 3068
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnDragHintCallback_Public_Void_DragObjectCallback_0;

	// Token: 0x04000BFD RID: 3069
	private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000BFE RID: 3070
	private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000BFF RID: 3071
	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000C00 RID: 3072
	private static readonly IntPtr NativeMethodInfoPtr_OnCancelDrag_Public_Void_PointerEventData_0;

	// Token: 0x04000C01 RID: 3073
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Void_0;

	// Token: 0x04000C02 RID: 3074
	private static readonly IntPtr NativeMethodInfoPtr_ClearDragReturnParent_Public_Void_0;

	// Token: 0x04000C03 RID: 3075
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000193 RID: 403
	public sealed class DragObjectCallback : MulticastDelegate
	{
		// Token: 0x06002476 RID: 9334 RVA: 0x00087B34 File Offset: 0x00085D34
		// Note: this type is marked as 'beforefieldinit'.
		static DragObjectCallback()
		{
			Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DragObject>.NativeClassPtr, "DragObjectCallback");
			DragObject.DragObjectCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr, 100666200);
			DragObject.DragObjectCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr, 100666201);
			DragObject.DragObjectCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_PointerEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr, 100666202);
			DragObject.DragObjectCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr, 100666203);
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00087BA8 File Offset: 0x00085DA8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragObjectCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragObject.DragObjectCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.DragObjectCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00087C04 File Offset: 0x00085E04
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 226438, RefRangeEnd = 226449, XrefRangeStart = 226438, XrefRangeEnd = 226449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(DragObject dragObject, PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.DragObjectCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00087C58 File Offset: 0x00085E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(DragObject dragObject, PointerEventData eventData, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.DragObjectCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_PointerEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00087CE0 File Offset: 0x00085EE0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragObject.DragObjectCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00016A83 File Offset: 0x00014C83
		public DragObjectCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00016A8C File Offset: 0x00014C8C
		public static implicit operator DragObject.DragObjectCallback(Action<DragObject, PointerEventData> A_0)
		{
			return DelegateSupport.ConvertDelegate<DragObject.DragObjectCallback>(A_0);
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00016A94 File Offset: 0x00014C94
		public static DragObject.DragObjectCallback operator +(DragObject.DragObjectCallback A_0, DragObject.DragObjectCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DragObject.DragObjectCallback>();
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00016AA2 File Offset: 0x00014CA2
		public static DragObject.DragObjectCallback operator -(DragObject.DragObjectCallback A_0, DragObject.DragObjectCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DragObject.DragObjectCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_PointerEventData_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_PointerEventData_AsyncCallback_Object_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
