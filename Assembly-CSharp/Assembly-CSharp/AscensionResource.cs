using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000026 RID: 38
public class AscensionResource : DragObject
{
	// Token: 0x0600087E RID: 2174 RVA: 0x00032CD4 File Offset: 0x00030ED4
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionResource()
	{
		Il2CppClassPointerStore<AscensionResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionResource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr);
		AscensionResource.NativeFieldInfoPtr_m_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_Highlight");
		AscensionResource.NativeFieldInfoPtr_m_HighlightAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_HighlightAnimator");
		AscensionResource.NativeFieldInfoPtr_m_ResourceCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_ResourceCountText");
		AscensionResource.NativeFieldInfoPtr_m_OnResourceClickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_OnResourceClickCallback");
		AscensionResource.NativeFieldInfoPtr_m_OnResourceDropCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_OnResourceDropCallback");
		AscensionResource.NativeFieldInfoPtr_m_GameOptionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_GameOptionIndex");
		AscensionResource.NativeFieldInfoPtr_m_DisplayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_DisplayCount");
		AscensionResource.NativeFieldInfoPtr_m_DragPilePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_DragPilePrefab");
		AscensionResource.NativeFieldInfoPtr_m_bActiveHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_bActiveHighlight");
		AscensionResource.NativeFieldInfoPtr_m_bCurrentlyDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_bCurrentlyDragging");
		AscensionResource.NativeFieldInfoPtr_m_bWasDragToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_bWasDragToTarget");
		AscensionResource.NativeFieldInfoPtr_m_ResourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_ResourceType");
		AscensionResource.NativeFieldInfoPtr_m_ResourceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "m_ResourceValue");
		AscensionResource.NativeMethodInfoPtr_WasDragToTarget_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663854);
		AscensionResource.NativeMethodInfoPtr_GetResourceType_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663855);
		AscensionResource.NativeMethodInfoPtr_GetResourceValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663856);
		AscensionResource.NativeMethodInfoPtr_SetResourceValue_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663857);
		AscensionResource.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663858);
		AscensionResource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663859);
		AscensionResource.NativeMethodInfoPtr_UpdateHighlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663860);
		AscensionResource.NativeMethodInfoPtr_ActivateHighlight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663861);
		AscensionResource.NativeMethodInfoPtr_GetGameOptionIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663862);
		AscensionResource.NativeMethodInfoPtr_SetGameOptionIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663863);
		AscensionResource.NativeMethodInfoPtr_SetDisplayCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663864);
		AscensionResource.NativeMethodInfoPtr_GetDragPilePrefab_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663865);
		AscensionResource.NativeMethodInfoPtr_SetDragPilePrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663866);
		AscensionResource.NativeMethodInfoPtr_AddOnResourceClickCallback_Public_Void_ResourceClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663867);
		AscensionResource.NativeMethodInfoPtr_RemoveOnResourceClickCallback_Public_Void_ResourceClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663868);
		AscensionResource.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663869);
		AscensionResource.NativeMethodInfoPtr_AddOnResourceDropCallback_Public_Void_ResourceDropCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663870);
		AscensionResource.NativeMethodInfoPtr_RemoveOnResourceDropCallback_Public_Void_ResourceDropCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663871);
		AscensionResource.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663872);
		AscensionResource.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663873);
		AscensionResource.NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663874);
		AscensionResource.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663875);
		AscensionResource.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663876);
		AscensionResource.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663877);
		AscensionResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, 100663878);
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00032FFC File Offset: 0x000311FC
	[CallerCount(0)]
	public unsafe bool WasDragToTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_WasDragToTarget_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00033038 File Offset: 0x00031238
	[CallerCount(0)]
	public unsafe int GetResourceType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_GetResourceType_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00033074 File Offset: 0x00031274
	[CallerCount(0)]
	public unsafe int GetResourceValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_GetResourceValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x000330B0 File Offset: 0x000312B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235059, RefRangeEnd = 235060, XrefRangeStart = 235059, XrefRangeEnd = 235059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResourceValue(int resType, int resValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_SetResourceValue_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x000330FC File Offset: 0x000312FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235060, XrefRangeEnd = 235085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00033130 File Offset: 0x00031330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235085, XrefRangeEnd = 235086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00033164 File Offset: 0x00031364
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 235098, RefRangeEnd = 235102, XrefRangeStart = 235086, XrefRangeEnd = 235098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHighlight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_UpdateHighlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00033198 File Offset: 0x00031398
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 235103, RefRangeEnd = 235107, XrefRangeStart = 235102, XrefRangeEnd = 235103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateHighlight(bool bActiveHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActiveHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_ActivateHighlight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x000331D8 File Offset: 0x000313D8
	[CallerCount(0)]
	public unsafe int GetGameOptionIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_GetGameOptionIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00033214 File Offset: 0x00031414
	[CallerCount(0)]
	public unsafe void SetGameOptionIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_SetGameOptionIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00033254 File Offset: 0x00031454
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235115, RefRangeEnd = 235118, XrefRangeStart = 235107, XrefRangeEnd = 235115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDisplayCount(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_SetDisplayCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00033294 File Offset: 0x00031494
	[CallerCount(0)]
	public unsafe GameObject GetDragPilePrefab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_GetDragPilePrefab_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x000332D4 File Offset: 0x000314D4
	[CallerCount(0)]
	public unsafe void SetDragPilePrefab(GameObject dragPilePrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragPilePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_SetDragPilePrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00033318 File Offset: 0x00031518
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235118, XrefRangeEnd = 235121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnResourceClickCallback(AscensionResource.ResourceClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_AddOnResourceClickCallback_Public_Void_ResourceClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x0003335C File Offset: 0x0003155C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235121, XrefRangeEnd = 235124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnResourceClickCallback(AscensionResource.ResourceClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_RemoveOnResourceClickCallback_Public_Void_ResourceClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x000333A0 File Offset: 0x000315A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235124, XrefRangeEnd = 235125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x000333E4 File Offset: 0x000315E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235125, XrefRangeEnd = 235128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnResourceDropCallback(AscensionResource.ResourceDropCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_AddOnResourceDropCallback_Public_Void_ResourceDropCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00033428 File Offset: 0x00031628
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235128, XrefRangeEnd = 235131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnResourceDropCallback(AscensionResource.ResourceDropCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_RemoveOnResourceDropCallback_Public_Void_ResourceDropCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0003346C File Offset: 0x0003166C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235131, XrefRangeEnd = 235140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDragCallback(DragObject dragObject, PointerEventData eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x000334C0 File Offset: 0x000316C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235140, XrefRangeEnd = 235152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDragCallback(DragObject dragObject, PointerEventData eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00033514 File Offset: 0x00031714
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235152, XrefRangeEnd = 235161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DragHintCallback(DragObject dragObject, PointerEventData eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x00033568 File Offset: 0x00031768
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerEnter(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x000335AC File Offset: 0x000317AC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerExit(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000335F0 File Offset: 0x000317F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235161, XrefRangeEnd = 235181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrop(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00033634 File Offset: 0x00031834
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235181, XrefRangeEnd = 235184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionResource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00007548 File Offset: 0x00005748
	public AscensionResource(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x06000899 RID: 2201 RVA: 0x00033670 File Offset: 0x00031870
	// (set) Token: 0x0600089A RID: 2202 RVA: 0x00007551 File Offset: 0x00005751
	public unsafe GameObject m_Highlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_Highlight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x0600089B RID: 2203 RVA: 0x000336A0 File Offset: 0x000318A0
	// (set) Token: 0x0600089C RID: 2204 RVA: 0x00007570 File Offset: 0x00005770
	public unsafe Animator m_HighlightAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_HighlightAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_HighlightAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x0600089D RID: 2205 RVA: 0x000336D0 File Offset: 0x000318D0
	// (set) Token: 0x0600089E RID: 2206 RVA: 0x0000758F File Offset: 0x0000578F
	public unsafe TextMeshProUGUI m_ResourceCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x0600089F RID: 2207 RVA: 0x00033700 File Offset: 0x00031900
	// (set) Token: 0x060008A0 RID: 2208 RVA: 0x000075AE File Offset: 0x000057AE
	public unsafe AscensionResource.ResourceClickCallback m_OnResourceClickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_OnResourceClickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionResource.ResourceClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_OnResourceClickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00033730 File Offset: 0x00031930
	// (set) Token: 0x060008A2 RID: 2210 RVA: 0x000075CD File Offset: 0x000057CD
	public unsafe AscensionResource.ResourceDropCallback m_OnResourceDropCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_OnResourceDropCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionResource.ResourceDropCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_OnResourceDropCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x060008A3 RID: 2211 RVA: 0x00033760 File Offset: 0x00031960
	// (set) Token: 0x060008A4 RID: 2212 RVA: 0x000075EC File Offset: 0x000057EC
	public unsafe int m_GameOptionIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_GameOptionIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_GameOptionIndex)) = value;
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00033788 File Offset: 0x00031988
	// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00007607 File Offset: 0x00005807
	public unsafe int m_DisplayCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_DisplayCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_DisplayCount)) = value;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x060008A7 RID: 2215 RVA: 0x000337B0 File Offset: 0x000319B0
	// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00007622 File Offset: 0x00005822
	public unsafe GameObject m_DragPilePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_DragPilePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_DragPilePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x060008A9 RID: 2217 RVA: 0x000337E0 File Offset: 0x000319E0
	// (set) Token: 0x060008AA RID: 2218 RVA: 0x00007641 File Offset: 0x00005841
	public unsafe bool m_bActiveHighlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bActiveHighlight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bActiveHighlight)) = value;
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x060008AB RID: 2219 RVA: 0x00033808 File Offset: 0x00031A08
	// (set) Token: 0x060008AC RID: 2220 RVA: 0x0000765C File Offset: 0x0000585C
	public unsafe bool m_bCurrentlyDragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bCurrentlyDragging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bCurrentlyDragging)) = value;
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x060008AD RID: 2221 RVA: 0x00033830 File Offset: 0x00031A30
	// (set) Token: 0x060008AE RID: 2222 RVA: 0x00007677 File Offset: 0x00005877
	public unsafe bool m_bWasDragToTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bWasDragToTarget);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_bWasDragToTarget)) = value;
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x060008AF RID: 2223 RVA: 0x00033858 File Offset: 0x00031A58
	// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00007692 File Offset: 0x00005892
	public unsafe int m_ResourceType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceType)) = value;
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00033880 File Offset: 0x00031A80
	// (set) Token: 0x060008B2 RID: 2226 RVA: 0x000076AD File Offset: 0x000058AD
	public unsafe int m_ResourceValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionResource.NativeFieldInfoPtr_m_ResourceValue)) = value;
		}
	}

	// Token: 0x04000547 RID: 1351
	private static readonly IntPtr NativeFieldInfoPtr_m_Highlight;

	// Token: 0x04000548 RID: 1352
	private static readonly IntPtr NativeFieldInfoPtr_m_HighlightAnimator;

	// Token: 0x04000549 RID: 1353
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceCountText;

	// Token: 0x0400054A RID: 1354
	private static readonly IntPtr NativeFieldInfoPtr_m_OnResourceClickCallback;

	// Token: 0x0400054B RID: 1355
	private static readonly IntPtr NativeFieldInfoPtr_m_OnResourceDropCallback;

	// Token: 0x0400054C RID: 1356
	private static readonly IntPtr NativeFieldInfoPtr_m_GameOptionIndex;

	// Token: 0x0400054D RID: 1357
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayCount;

	// Token: 0x0400054E RID: 1358
	private static readonly IntPtr NativeFieldInfoPtr_m_DragPilePrefab;

	// Token: 0x0400054F RID: 1359
	private static readonly IntPtr NativeFieldInfoPtr_m_bActiveHighlight;

	// Token: 0x04000550 RID: 1360
	private static readonly IntPtr NativeFieldInfoPtr_m_bCurrentlyDragging;

	// Token: 0x04000551 RID: 1361
	private static readonly IntPtr NativeFieldInfoPtr_m_bWasDragToTarget;

	// Token: 0x04000552 RID: 1362
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceType;

	// Token: 0x04000553 RID: 1363
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceValue;

	// Token: 0x04000554 RID: 1364
	private static readonly IntPtr NativeMethodInfoPtr_WasDragToTarget_Public_Boolean_0;

	// Token: 0x04000555 RID: 1365
	private static readonly IntPtr NativeMethodInfoPtr_GetResourceType_Public_Int32_0;

	// Token: 0x04000556 RID: 1366
	private static readonly IntPtr NativeMethodInfoPtr_GetResourceValue_Public_Int32_0;

	// Token: 0x04000557 RID: 1367
	private static readonly IntPtr NativeMethodInfoPtr_SetResourceValue_Public_Void_Int32_Int32_0;

	// Token: 0x04000558 RID: 1368
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000559 RID: 1369
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400055A RID: 1370
	private static readonly IntPtr NativeMethodInfoPtr_UpdateHighlight_Private_Void_0;

	// Token: 0x0400055B RID: 1371
	private static readonly IntPtr NativeMethodInfoPtr_ActivateHighlight_Public_Void_Boolean_0;

	// Token: 0x0400055C RID: 1372
	private static readonly IntPtr NativeMethodInfoPtr_GetGameOptionIndex_Public_Int32_0;

	// Token: 0x0400055D RID: 1373
	private static readonly IntPtr NativeMethodInfoPtr_SetGameOptionIndex_Public_Void_Int32_0;

	// Token: 0x0400055E RID: 1374
	private static readonly IntPtr NativeMethodInfoPtr_SetDisplayCount_Public_Void_Int32_0;

	// Token: 0x0400055F RID: 1375
	private static readonly IntPtr NativeMethodInfoPtr_GetDragPilePrefab_Public_GameObject_0;

	// Token: 0x04000560 RID: 1376
	private static readonly IntPtr NativeMethodInfoPtr_SetDragPilePrefab_Public_Void_GameObject_0;

	// Token: 0x04000561 RID: 1377
	private static readonly IntPtr NativeMethodInfoPtr_AddOnResourceClickCallback_Public_Void_ResourceClickCallback_0;

	// Token: 0x04000562 RID: 1378
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnResourceClickCallback_Public_Void_ResourceClickCallback_0;

	// Token: 0x04000563 RID: 1379
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000564 RID: 1380
	private static readonly IntPtr NativeMethodInfoPtr_AddOnResourceDropCallback_Public_Void_ResourceDropCallback_0;

	// Token: 0x04000565 RID: 1381
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnResourceDropCallback_Public_Void_ResourceDropCallback_0;

	// Token: 0x04000566 RID: 1382
	private static readonly IntPtr NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000567 RID: 1383
	private static readonly IntPtr NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000568 RID: 1384
	private static readonly IntPtr NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000569 RID: 1385
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x0400056A RID: 1386
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x0400056B RID: 1387
	private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x0400056C RID: 1388
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000176 RID: 374
	public sealed class ResourceClickCallback : MulticastDelegate
	{
		// Token: 0x06002366 RID: 9062 RVA: 0x0008467C File Offset: 0x0008287C
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceClickCallback()
		{
			Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "ResourceClickCallback");
			AscensionResource.ResourceClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr, 100666100);
			AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr, 100666101);
			AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr, 100666102);
			AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr, 100666103);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x000846F0 File Offset: 0x000828F0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionResource.ResourceClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0008474C File Offset: 0x0008294C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(AscensionResource resource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00084790 File Offset: 0x00082990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AscensionResource resource, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00084804 File Offset: 0x00082A04
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x0001629C File Offset: 0x0001449C
		public ResourceClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x000162A5 File Offset: 0x000144A5
		public static implicit operator AscensionResource.ResourceClickCallback(Action<AscensionResource> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionResource.ResourceClickCallback>(A_0);
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x000162AD File Offset: 0x000144AD
		public static AscensionResource.ResourceClickCallback operator +(AscensionResource.ResourceClickCallback A_0, AscensionResource.ResourceClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionResource.ResourceClickCallback>();
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x000162BB File Offset: 0x000144BB
		public static AscensionResource.ResourceClickCallback operator -(AscensionResource.ResourceClickCallback A_0, AscensionResource.ResourceClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionResource.ResourceClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AsyncCallback_Object_0;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x02000177 RID: 375
	public sealed class ResourceDropCallback : MulticastDelegate
	{
		// Token: 0x0600236F RID: 9071 RVA: 0x00084848 File Offset: 0x00082A48
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceDropCallback()
		{
			Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionResource>.NativeClassPtr, "ResourceDropCallback");
			AscensionResource.ResourceDropCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr, 100666104);
			AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_AscensionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr, 100666105);
			AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AscensionResource_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr, 100666106);
			AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr, 100666107);
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x000848BC File Offset: 0x00082ABC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceDropCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionResource.ResourceDropCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceDropCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00084918 File Offset: 0x00082B18
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(AscensionResource dropResource, AscensionResource dragResource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropResource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragResource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_AscensionResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x0008496C File Offset: 0x00082B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AscensionResource dropResource, AscensionResource dragResource, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dropResource);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragResource);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AscensionResource_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x000849F4 File Offset: 0x00082BF4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionResource.ResourceDropCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x000162CC File Offset: 0x000144CC
		public ResourceDropCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x000162D5 File Offset: 0x000144D5
		public static implicit operator AscensionResource.ResourceDropCallback(Action<AscensionResource, AscensionResource> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionResource.ResourceDropCallback>(A_0);
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x000162DD File Offset: 0x000144DD
		public static AscensionResource.ResourceDropCallback operator +(AscensionResource.ResourceDropCallback A_0, AscensionResource.ResourceDropCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionResource.ResourceDropCallback>();
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x000162EB File Offset: 0x000144EB
		public static AscensionResource.ResourceDropCallback operator -(AscensionResource.ResourceDropCallback A_0, AscensionResource.ResourceDropCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionResource.ResourceDropCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionResource_AscensionResource_0;

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionResource_AscensionResource_AsyncCallback_Object_0;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
