using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000086 RID: 134
public class DragManager : MonoBehaviour
{
	// Token: 0x060010BD RID: 4285 RVA: 0x0004BC7C File Offset: 0x00049E7C
	// Note: this type is marked as 'beforefieldinit'.
	static DragManager()
	{
		Il2CppClassPointerStore<DragManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DragManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragManager>.NativeClassPtr);
		DragManager.NativeFieldInfoPtr_m_DraggingCardsLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_DraggingCardsLayer");
		DragManager.NativeFieldInfoPtr_m_DragTargetZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_DragTargetZones");
		DragManager.NativeFieldInfoPtr_m_OnBeginDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_OnBeginDragCallback");
		DragManager.NativeFieldInfoPtr_m_OnUpdateDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_OnUpdateDragCallback");
		DragManager.NativeFieldInfoPtr_m_OnEndDragCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_OnEndDragCallback");
		DragManager.NativeFieldInfoPtr_m_AdditionalDragTargetZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_AdditionalDragTargetZones");
		DragManager.NativeFieldInfoPtr_m_DraggingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "m_DraggingObject");
		DragManager.NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664542);
		DragManager.NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664543);
		DragManager.NativeMethodInfoPtr_AddOnUpdateDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664544);
		DragManager.NativeMethodInfoPtr_RemoveOnUpdateDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664545);
		DragManager.NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664546);
		DragManager.NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragManagerCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664547);
		DragManager.NativeMethodInfoPtr_AddAdditionalDragTargetZone_Public_Void_DragTargetZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664548);
		DragManager.NativeMethodInfoPtr_IsDraggingObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664549);
		DragManager.NativeMethodInfoPtr_GetDraggingObject_Public_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664550);
		DragManager.NativeMethodInfoPtr_BeginDrag_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664551);
		DragManager.NativeMethodInfoPtr_EndDrag_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664552);
		DragManager.NativeMethodInfoPtr_UpdateDrag_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664553);
		DragManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664554);
		DragManager.NativeMethodInfoPtr_OnApplicationFocus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664555);
		DragManager.NativeMethodInfoPtr_ClearDragTargetZones_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664556);
		DragManager.NativeMethodInfoPtr_SetDragTargetZones_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664557);
		DragManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100664558);
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0004BE8C File Offset: 0x0004A08C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241865, RefRangeEnd = 241867, XrefRangeStart = 241862, XrefRangeEnd = 241865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnBeginDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0004BED0 File Offset: 0x0004A0D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241870, RefRangeEnd = 241871, XrefRangeStart = 241867, XrefRangeEnd = 241870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnBeginDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0004BF14 File Offset: 0x0004A114
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241874, RefRangeEnd = 241875, XrefRangeStart = 241871, XrefRangeEnd = 241874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnUpdateDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_AddOnUpdateDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0004BF58 File Offset: 0x0004A158
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241878, RefRangeEnd = 241879, XrefRangeStart = 241875, XrefRangeEnd = 241878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnUpdateDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RemoveOnUpdateDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0004BF9C File Offset: 0x0004A19C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241882, RefRangeEnd = 241883, XrefRangeStart = 241879, XrefRangeEnd = 241882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnEndDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x0004BFE0 File Offset: 0x0004A1E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241883, XrefRangeEnd = 241886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnEndDragCallback(DragManager.DragManagerCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragManagerCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0004C024 File Offset: 0x0004A224
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241892, RefRangeEnd = 241893, XrefRangeStart = 241886, XrefRangeEnd = 241892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAdditionalDragTargetZone(DragTargetZone add_zone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(add_zone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_AddAdditionalDragTargetZone_Public_Void_DragTargetZone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x0004C068 File Offset: 0x0004A268
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 241897, RefRangeEnd = 241898, XrefRangeStart = 241893, XrefRangeEnd = 241897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDraggingObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_IsDraggingObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
	[CallerCount(0)]
	public unsafe DragObject GetDraggingObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_GetDraggingObject_Public_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragObject>(intPtr3) : null;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0004C0E4 File Offset: 0x0004A2E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241898, XrefRangeEnd = 241900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDrag(DragObject drag_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drag_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_BeginDrag_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0004C128 File Offset: 0x0004A328
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241900, XrefRangeEnd = 241906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDrag(DragObject drag_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drag_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_EndDrag_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0004C16C File Offset: 0x0004A36C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241906, XrefRangeEnd = 241907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDrag(DragObject drag_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drag_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_UpdateDrag_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x0004C1B0 File Offset: 0x0004A3B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241907, XrefRangeEnd = 241912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x0004C1E4 File Offset: 0x0004A3E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241912, XrefRangeEnd = 241918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationFocus(bool focusStatus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref focusStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_OnApplicationFocus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x0004C224 File Offset: 0x0004A424
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 241941, RefRangeEnd = 241944, XrefRangeStart = 241918, XrefRangeEnd = 241941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDragTargetZones()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_ClearDragTargetZones_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0004C258 File Offset: 0x0004A458
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 241999, RefRangeEnd = 242001, XrefRangeStart = 241944, XrefRangeEnd = 241999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragTargetZones(ushort selectionID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDragTargetZones_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x0004C298 File Offset: 0x0004A498
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242001, XrefRangeEnd = 242008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x0000B834 File Offset: 0x00009A34
	public DragManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0004C2D4 File Offset: 0x0004A4D4
	// (set) Token: 0x060010D1 RID: 4305 RVA: 0x0000B83D File Offset: 0x00009A3D
	public unsafe GameObject m_DraggingCardsLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DraggingCardsLayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DraggingCardsLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0004C304 File Offset: 0x0004A504
	// (set) Token: 0x060010D3 RID: 4307 RVA: 0x0000B85C File Offset: 0x00009A5C
	public unsafe Il2CppReferenceArray<DragTargetZone> m_DragTargetZones
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DragTargetZones);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DragTargetZone>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DragTargetZones), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0004C334 File Offset: 0x0004A534
	// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0000B87B File Offset: 0x00009A7B
	public unsafe DragManager.DragManagerCallback m_OnBeginDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnBeginDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager.DragManagerCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnBeginDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000584 RID: 1412
	// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0004C364 File Offset: 0x0004A564
	// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0000B89A File Offset: 0x00009A9A
	public unsafe DragManager.DragManagerCallback m_OnUpdateDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnUpdateDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager.DragManagerCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnUpdateDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000585 RID: 1413
	// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0004C394 File Offset: 0x0004A594
	// (set) Token: 0x060010D9 RID: 4313 RVA: 0x0000B8B9 File Offset: 0x00009AB9
	public unsafe DragManager.DragManagerCallback m_OnEndDragCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnEndDragCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager.DragManagerCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_OnEndDragCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x060010DA RID: 4314 RVA: 0x0004C3C4 File Offset: 0x0004A5C4
	// (set) Token: 0x060010DB RID: 4315 RVA: 0x0000B8D8 File Offset: 0x00009AD8
	public unsafe List<DragTargetZone> m_AdditionalDragTargetZones
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_AdditionalDragTargetZones);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DragTargetZone>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_AdditionalDragTargetZones), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x060010DC RID: 4316 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
	// (set) Token: 0x060010DD RID: 4317 RVA: 0x0000B8F7 File Offset: 0x00009AF7
	public unsafe DragObject m_DraggingObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DraggingObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_m_DraggingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000BB7 RID: 2999
	private static readonly IntPtr NativeFieldInfoPtr_m_DraggingCardsLayer;

	// Token: 0x04000BB8 RID: 3000
	private static readonly IntPtr NativeFieldInfoPtr_m_DragTargetZones;

	// Token: 0x04000BB9 RID: 3001
	private static readonly IntPtr NativeFieldInfoPtr_m_OnBeginDragCallback;

	// Token: 0x04000BBA RID: 3002
	private static readonly IntPtr NativeFieldInfoPtr_m_OnUpdateDragCallback;

	// Token: 0x04000BBB RID: 3003
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEndDragCallback;

	// Token: 0x04000BBC RID: 3004
	private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalDragTargetZones;

	// Token: 0x04000BBD RID: 3005
	private static readonly IntPtr NativeFieldInfoPtr_m_DraggingObject;

	// Token: 0x04000BBE RID: 3006
	private static readonly IntPtr NativeMethodInfoPtr_AddOnBeginDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BBF RID: 3007
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnBeginDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BC0 RID: 3008
	private static readonly IntPtr NativeMethodInfoPtr_AddOnUpdateDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BC1 RID: 3009
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnUpdateDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BC2 RID: 3010
	private static readonly IntPtr NativeMethodInfoPtr_AddOnEndDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BC3 RID: 3011
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnEndDragCallback_Public_Void_DragManagerCallback_0;

	// Token: 0x04000BC4 RID: 3012
	private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalDragTargetZone_Public_Void_DragTargetZone_0;

	// Token: 0x04000BC5 RID: 3013
	private static readonly IntPtr NativeMethodInfoPtr_IsDraggingObject_Public_Boolean_0;

	// Token: 0x04000BC6 RID: 3014
	private static readonly IntPtr NativeMethodInfoPtr_GetDraggingObject_Public_DragObject_0;

	// Token: 0x04000BC7 RID: 3015
	private static readonly IntPtr NativeMethodInfoPtr_BeginDrag_Public_Void_DragObject_0;

	// Token: 0x04000BC8 RID: 3016
	private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Public_Void_DragObject_0;

	// Token: 0x04000BC9 RID: 3017
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Public_Void_DragObject_0;

	// Token: 0x04000BCA RID: 3018
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000BCB RID: 3019
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Public_Void_Boolean_0;

	// Token: 0x04000BCC RID: 3020
	private static readonly IntPtr NativeMethodInfoPtr_ClearDragTargetZones_Public_Void_0;

	// Token: 0x04000BCD RID: 3021
	private static readonly IntPtr NativeMethodInfoPtr_SetDragTargetZones_Public_Void_UInt16_0;

	// Token: 0x04000BCE RID: 3022
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000192 RID: 402
	public sealed class DragManagerCallback : MulticastDelegate
	{
		// Token: 0x0600246D RID: 9325 RVA: 0x00087968 File Offset: 0x00085B68
		// Note: this type is marked as 'beforefieldinit'.
		static DragManagerCallback()
		{
			Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DragManagerCallback");
			DragManager.DragManagerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr, 100666196);
			DragManager.DragManagerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr, 100666197);
			DragManager.DragManagerCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr, 100666198);
			DragManager.DragManagerCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr, 100666199);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000879DC File Offset: 0x00085BDC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragManagerCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager.DragManagerCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.DragManagerCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00087A38 File Offset: 0x00085C38
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(DragObject dragObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.DragManagerCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x00087A7C File Offset: 0x00085C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(DragObject dragObject, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.DragManagerCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00087AF0 File Offset: 0x00085CF0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.DragManagerCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00016A53 File Offset: 0x00014C53
		public DragManagerCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00016A5C File Offset: 0x00014C5C
		public static implicit operator DragManager.DragManagerCallback(Action<DragObject> A_0)
		{
			return DelegateSupport.ConvertDelegate<DragManager.DragManagerCallback>(A_0);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00016A64 File Offset: 0x00014C64
		public static DragManager.DragManagerCallback operator +(DragManager.DragManagerCallback A_0, DragManager.DragManagerCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DragManager.DragManagerCallback>();
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00016A72 File Offset: 0x00014C72
		public static DragManager.DragManagerCallback operator -(DragManager.DragManagerCallback A_0, DragManager.DragManagerCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DragManager.DragManagerCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DragObject_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DragObject_AsyncCallback_Object_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
