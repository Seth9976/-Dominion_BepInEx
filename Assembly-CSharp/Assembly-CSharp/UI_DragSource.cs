using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020000BE RID: 190
public class UI_DragSource : MonoBehaviour
{
	// Token: 0x060016F1 RID: 5873 RVA: 0x0005F4F4 File Offset: 0x0005D6F4
	// Note: this type is marked as 'beforefieldinit'.
	static UI_DragSource()
	{
		Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_DragSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr);
		UI_DragSource.NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "restriction");
		UI_DragSource.NativeFieldInfoPtr_cloneOnDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "cloneOnDrag");
		UI_DragSource.NativeFieldInfoPtr_dragFromObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "dragFromObject");
		UI_DragSource.NativeFieldInfoPtr_forceCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "forceCanvas");
		UI_DragSource.NativeFieldInfoPtr_m_bDragHandled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_bDragHandled");
		UI_DragSource.NativeFieldInfoPtr_pressAndHoldDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "pressAndHoldDelay");
		UI_DragSource.NativeFieldInfoPtr_m_DragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_DragStart");
		UI_DragSource.NativeFieldInfoPtr_m_DragContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_DragContinue");
		UI_DragSource.NativeFieldInfoPtr_m_DragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_DragEnd");
		UI_DragSource.NativeFieldInfoPtr_m_DraggingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_DraggingObject");
		UI_DragSource.NativeFieldInfoPtr_m_DraggingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_DraggingPlane");
		UI_DragSource.NativeFieldInfoPtr_mParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "mParent");
		UI_DragSource.NativeFieldInfoPtr_mCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "mCanvas");
		UI_DragSource.NativeFieldInfoPtr_m_isDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_isDragging");
		UI_DragSource.NativeFieldInfoPtr_m_startDragPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_startDragPos");
		UI_DragSource.NativeFieldInfoPtr_m_startDragTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_startDragTime");
		UI_DragSource.NativeFieldInfoPtr_m_isStartRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_isStartRestriction");
		UI_DragSource.NativeFieldInfoPtr_m_restrictCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_restrictCam");
		UI_DragSource.NativeFieldInfoPtr_m_restrictPosDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_restrictPosDelta");
		UI_DragSource.NativeFieldInfoPtr_m_bEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_bEnabled");
		UI_DragSource.NativeFieldInfoPtr_m_restrictPressHoldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "m_restrictPressHoldState");
		UI_DragSource.NativeMethodInfoPtr_add_m_DragStart_Public_add_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665126);
		UI_DragSource.NativeMethodInfoPtr_remove_m_DragStart_Public_rem_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665127);
		UI_DragSource.NativeMethodInfoPtr_add_m_DragContinue_Public_add_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665128);
		UI_DragSource.NativeMethodInfoPtr_remove_m_DragContinue_Public_rem_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665129);
		UI_DragSource.NativeMethodInfoPtr_add_m_DragEnd_Public_add_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665130);
		UI_DragSource.NativeMethodInfoPtr_remove_m_DragEnd_Public_rem_Void_DragEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665131);
		UI_DragSource.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665132);
		UI_DragSource.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665133);
		UI_DragSource.NativeMethodInfoPtr_GetIsEnabled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665134);
		UI_DragSource.NativeMethodInfoPtr_GetIsDragging_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665135);
		UI_DragSource.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665136);
		UI_DragSource.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665137);
		UI_DragSource.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665138);
		UI_DragSource.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665139);
		UI_DragSource.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665140);
		UI_DragSource.NativeMethodInfoPtr_StartDragging_Private_Void_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665141);
		UI_DragSource.NativeMethodInfoPtr_SetDraggedPosition_Private_Void_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665142);
		UI_DragSource.NativeMethodInfoPtr_SetDraggedPosition_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665143);
		UI_DragSource.NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665144);
		UI_DragSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, 100665145);
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x0005F858 File Offset: 0x0005DA58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247912, RefRangeEnd = 247914, XrefRangeStart = 247908, XrefRangeEnd = 247912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_m_DragStart(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_add_m_DragStart_Public_add_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x0005F89C File Offset: 0x0005DA9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247914, XrefRangeEnd = 247918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_m_DragStart(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_remove_m_DragStart_Public_rem_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x0005F8E0 File Offset: 0x0005DAE0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247922, RefRangeEnd = 247924, XrefRangeStart = 247918, XrefRangeEnd = 247922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_m_DragContinue(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_add_m_DragContinue_Public_add_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0005F924 File Offset: 0x0005DB24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247924, XrefRangeEnd = 247928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_m_DragContinue(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_remove_m_DragContinue_Public_rem_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0005F968 File Offset: 0x0005DB68
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247932, RefRangeEnd = 247934, XrefRangeStart = 247928, XrefRangeEnd = 247932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_m_DragEnd(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_add_m_DragEnd_Public_add_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x0005F9AC File Offset: 0x0005DBAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247934, XrefRangeEnd = 247938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_m_DragEnd(UI_DragSource.DragEventHandler value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_remove_m_DragEnd_Public_rem_Void_DragEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247938, XrefRangeEnd = 247940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_DragSource.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0005FA2C File Offset: 0x0005DC2C
	[CallerCount(0)]
	public unsafe void SetEnabled(bool bEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0005FA6C File Offset: 0x0005DC6C
	[CallerCount(0)]
	public unsafe bool GetIsEnabled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_GetIsEnabled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
	[CallerCount(0)]
	public unsafe bool GetIsDragging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_GetIsDragging_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247940, XrefRangeEnd = 247943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerDown(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x0005FB28 File Offset: 0x0005DD28
	[CallerCount(0)]
	public unsafe virtual void OnPointerUp(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x0005FB6C File Offset: 0x0005DD6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247943, XrefRangeEnd = 247947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeginDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x0005FBB0 File Offset: 0x0005DDB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247947, XrefRangeEnd = 248001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrag(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x0005FBF4 File Offset: 0x0005DDF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248001, XrefRangeEnd = 248020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEndDrag(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x0005FC38 File Offset: 0x0005DE38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248084, RefRangeEnd = 248085, XrefRangeStart = 248020, XrefRangeEnd = 248084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartDragging(Vector2 position, Camera eventCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref position;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_StartDragging_Private_Void_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x0005FC88 File Offset: 0x0005DE88
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 248095, RefRangeEnd = 248098, XrefRangeStart = 248085, XrefRangeEnd = 248095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDraggedPosition(Vector2 position, Camera eventCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref position;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_SetDraggedPosition_Private_Void_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x0005FCD8 File Offset: 0x0005DED8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248098, XrefRangeEnd = 248101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDraggedPosition(PointerEventData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr_SetDraggedPosition_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x0005FD1C File Offset: 0x0005DF1C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 248118, RefRangeEnd = 248119, XrefRangeStart = 248101, XrefRangeEnd = 248118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindInParents<T>(GameObject go) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.MethodInfoStoreGeneric_FindInParents_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x0005FD5C File Offset: 0x0005DF5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248119, XrefRangeEnd = 248120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_DragSource()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x0000ED65 File Offset: 0x0000CF65
	public UI_DragSource(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700074E RID: 1870
	// (get) Token: 0x06001707 RID: 5895 RVA: 0x0005FD98 File Offset: 0x0005DF98
	// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000ED6E File Offset: 0x0000CF6E
	public unsafe UI_DragSource.Restriction restriction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_restriction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_restriction)) = value;
		}
	}

	// Token: 0x1700074F RID: 1871
	// (get) Token: 0x06001709 RID: 5897 RVA: 0x0005FDC0 File Offset: 0x0005DFC0
	// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000ED89 File Offset: 0x0000CF89
	public unsafe bool cloneOnDrag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_cloneOnDrag);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_cloneOnDrag)) = value;
		}
	}

	// Token: 0x17000750 RID: 1872
	// (get) Token: 0x0600170B RID: 5899 RVA: 0x0005FDE8 File Offset: 0x0005DFE8
	// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
	public unsafe GameObject dragFromObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_dragFromObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_dragFromObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x0005FE18 File Offset: 0x0005E018
	// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000EDC3 File Offset: 0x0000CFC3
	public unsafe Canvas forceCanvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_forceCanvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_forceCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x0600170F RID: 5903 RVA: 0x0005FE48 File Offset: 0x0005E048
	// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000EDE2 File Offset: 0x0000CFE2
	public unsafe bool m_bDragHandled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_bDragHandled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_bDragHandled)) = value;
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06001711 RID: 5905 RVA: 0x0005FE70 File Offset: 0x0005E070
	// (set) Token: 0x06001712 RID: 5906 RVA: 0x0000EDFD File Offset: 0x0000CFFD
	public unsafe float pressAndHoldDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_pressAndHoldDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_pressAndHoldDelay)) = value;
		}
	}

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06001713 RID: 5907 RVA: 0x0005FE98 File Offset: 0x0005E098
	// (set) Token: 0x06001714 RID: 5908 RVA: 0x0000EE18 File Offset: 0x0000D018
	public unsafe UI_DragSource.DragEventHandler m_DragStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragStart);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DragSource.DragEventHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06001715 RID: 5909 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
	// (set) Token: 0x06001716 RID: 5910 RVA: 0x0000EE37 File Offset: 0x0000D037
	public unsafe UI_DragSource.DragEventHandler m_DragContinue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragContinue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DragSource.DragEventHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragContinue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x06001717 RID: 5911 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
	// (set) Token: 0x06001718 RID: 5912 RVA: 0x0000EE56 File Offset: 0x0000D056
	public unsafe UI_DragSource.DragEventHandler m_DragEnd
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragEnd);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_DragSource.DragEventHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x06001719 RID: 5913 RVA: 0x0005FF28 File Offset: 0x0005E128
	// (set) Token: 0x0600171A RID: 5914 RVA: 0x0000EE75 File Offset: 0x0000D075
	public unsafe GameObject m_DraggingObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DraggingObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DraggingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x0600171B RID: 5915 RVA: 0x0005FF58 File Offset: 0x0005E158
	// (set) Token: 0x0600171C RID: 5916 RVA: 0x0000EE94 File Offset: 0x0000D094
	public unsafe RectTransform m_DraggingPlane
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DraggingPlane);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_DraggingPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x0600171D RID: 5917 RVA: 0x0005FF88 File Offset: 0x0005E188
	// (set) Token: 0x0600171E RID: 5918 RVA: 0x0000EEB3 File Offset: 0x0000D0B3
	public unsafe Transform mParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_mParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_mParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700075A RID: 1882
	// (get) Token: 0x0600171F RID: 5919 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
	// (set) Token: 0x06001720 RID: 5920 RVA: 0x0000EED2 File Offset: 0x0000D0D2
	public unsafe Transform mCanvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_mCanvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_mCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700075B RID: 1883
	// (get) Token: 0x06001721 RID: 5921 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
	// (set) Token: 0x06001722 RID: 5922 RVA: 0x0000EEF1 File Offset: 0x0000D0F1
	public unsafe bool m_isDragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_isDragging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_isDragging)) = value;
		}
	}

	// Token: 0x1700075C RID: 1884
	// (get) Token: 0x06001723 RID: 5923 RVA: 0x00060010 File Offset: 0x0005E210
	// (set) Token: 0x06001724 RID: 5924 RVA: 0x0000EF0C File Offset: 0x0000D10C
	public unsafe Vector2 m_startDragPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_startDragPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_startDragPos)) = value;
		}
	}

	// Token: 0x1700075D RID: 1885
	// (get) Token: 0x06001725 RID: 5925 RVA: 0x00060038 File Offset: 0x0005E238
	// (set) Token: 0x06001726 RID: 5926 RVA: 0x0000EF27 File Offset: 0x0000D127
	public unsafe float m_startDragTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_startDragTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_startDragTime)) = value;
		}
	}

	// Token: 0x1700075E RID: 1886
	// (get) Token: 0x06001727 RID: 5927 RVA: 0x00060060 File Offset: 0x0005E260
	// (set) Token: 0x06001728 RID: 5928 RVA: 0x0000EF42 File Offset: 0x0000D142
	public unsafe bool m_isStartRestriction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_isStartRestriction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_isStartRestriction)) = value;
		}
	}

	// Token: 0x1700075F RID: 1887
	// (get) Token: 0x06001729 RID: 5929 RVA: 0x00060088 File Offset: 0x0005E288
	// (set) Token: 0x0600172A RID: 5930 RVA: 0x0000EF5D File Offset: 0x0000D15D
	public unsafe Camera m_restrictCam
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictCam);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictCam), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000760 RID: 1888
	// (get) Token: 0x0600172B RID: 5931 RVA: 0x000600B8 File Offset: 0x0005E2B8
	// (set) Token: 0x0600172C RID: 5932 RVA: 0x0000EF7C File Offset: 0x0000D17C
	public unsafe Vector2 m_restrictPosDelta
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictPosDelta);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictPosDelta)) = value;
		}
	}

	// Token: 0x17000761 RID: 1889
	// (get) Token: 0x0600172D RID: 5933 RVA: 0x000600E0 File Offset: 0x0005E2E0
	// (set) Token: 0x0600172E RID: 5934 RVA: 0x0000EF97 File Offset: 0x0000D197
	public unsafe bool m_bEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_bEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_bEnabled)) = value;
		}
	}

	// Token: 0x17000762 RID: 1890
	// (get) Token: 0x0600172F RID: 5935 RVA: 0x00060108 File Offset: 0x0005E308
	// (set) Token: 0x06001730 RID: 5936 RVA: 0x0000EFB2 File Offset: 0x0000D1B2
	public unsafe UI_DragSource.PressAndHoldState m_restrictPressHoldState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictPressHoldState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_DragSource.NativeFieldInfoPtr_m_restrictPressHoldState)) = value;
		}
	}

	// Token: 0x04000FC9 RID: 4041
	private static readonly IntPtr NativeFieldInfoPtr_restriction;

	// Token: 0x04000FCA RID: 4042
	private static readonly IntPtr NativeFieldInfoPtr_cloneOnDrag;

	// Token: 0x04000FCB RID: 4043
	private static readonly IntPtr NativeFieldInfoPtr_dragFromObject;

	// Token: 0x04000FCC RID: 4044
	private static readonly IntPtr NativeFieldInfoPtr_forceCanvas;

	// Token: 0x04000FCD RID: 4045
	private static readonly IntPtr NativeFieldInfoPtr_m_bDragHandled;

	// Token: 0x04000FCE RID: 4046
	private static readonly IntPtr NativeFieldInfoPtr_pressAndHoldDelay;

	// Token: 0x04000FCF RID: 4047
	private static readonly IntPtr NativeFieldInfoPtr_m_DragStart;

	// Token: 0x04000FD0 RID: 4048
	private static readonly IntPtr NativeFieldInfoPtr_m_DragContinue;

	// Token: 0x04000FD1 RID: 4049
	private static readonly IntPtr NativeFieldInfoPtr_m_DragEnd;

	// Token: 0x04000FD2 RID: 4050
	private static readonly IntPtr NativeFieldInfoPtr_m_DraggingObject;

	// Token: 0x04000FD3 RID: 4051
	private static readonly IntPtr NativeFieldInfoPtr_m_DraggingPlane;

	// Token: 0x04000FD4 RID: 4052
	private static readonly IntPtr NativeFieldInfoPtr_mParent;

	// Token: 0x04000FD5 RID: 4053
	private static readonly IntPtr NativeFieldInfoPtr_mCanvas;

	// Token: 0x04000FD6 RID: 4054
	private static readonly IntPtr NativeFieldInfoPtr_m_isDragging;

	// Token: 0x04000FD7 RID: 4055
	private static readonly IntPtr NativeFieldInfoPtr_m_startDragPos;

	// Token: 0x04000FD8 RID: 4056
	private static readonly IntPtr NativeFieldInfoPtr_m_startDragTime;

	// Token: 0x04000FD9 RID: 4057
	private static readonly IntPtr NativeFieldInfoPtr_m_isStartRestriction;

	// Token: 0x04000FDA RID: 4058
	private static readonly IntPtr NativeFieldInfoPtr_m_restrictCam;

	// Token: 0x04000FDB RID: 4059
	private static readonly IntPtr NativeFieldInfoPtr_m_restrictPosDelta;

	// Token: 0x04000FDC RID: 4060
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnabled;

	// Token: 0x04000FDD RID: 4061
	private static readonly IntPtr NativeFieldInfoPtr_m_restrictPressHoldState;

	// Token: 0x04000FDE RID: 4062
	private static readonly IntPtr NativeMethodInfoPtr_add_m_DragStart_Public_add_Void_DragEventHandler_0;

	// Token: 0x04000FDF RID: 4063
	private static readonly IntPtr NativeMethodInfoPtr_remove_m_DragStart_Public_rem_Void_DragEventHandler_0;

	// Token: 0x04000FE0 RID: 4064
	private static readonly IntPtr NativeMethodInfoPtr_add_m_DragContinue_Public_add_Void_DragEventHandler_0;

	// Token: 0x04000FE1 RID: 4065
	private static readonly IntPtr NativeMethodInfoPtr_remove_m_DragContinue_Public_rem_Void_DragEventHandler_0;

	// Token: 0x04000FE2 RID: 4066
	private static readonly IntPtr NativeMethodInfoPtr_add_m_DragEnd_Public_add_Void_DragEventHandler_0;

	// Token: 0x04000FE3 RID: 4067
	private static readonly IntPtr NativeMethodInfoPtr_remove_m_DragEnd_Public_rem_Void_DragEventHandler_0;

	// Token: 0x04000FE4 RID: 4068
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	// Token: 0x04000FE5 RID: 4069
	private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

	// Token: 0x04000FE6 RID: 4070
	private static readonly IntPtr NativeMethodInfoPtr_GetIsEnabled_Public_Boolean_0;

	// Token: 0x04000FE7 RID: 4071
	private static readonly IntPtr NativeMethodInfoPtr_GetIsDragging_Public_Boolean_0;

	// Token: 0x04000FE8 RID: 4072
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FE9 RID: 4073
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FEA RID: 4074
	private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FEB RID: 4075
	private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FEC RID: 4076
	private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000FED RID: 4077
	private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Private_Void_Vector2_Camera_0;

	// Token: 0x04000FEE RID: 4078
	private static readonly IntPtr NativeMethodInfoPtr_SetDraggedPosition_Private_Void_Vector2_Camera_0;

	// Token: 0x04000FEF RID: 4079
	private static readonly IntPtr NativeMethodInfoPtr_SetDraggedPosition_Private_Void_PointerEventData_0;

	// Token: 0x04000FF0 RID: 4080
	private static readonly IntPtr NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0;

	// Token: 0x04000FF1 RID: 4081
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001D7 RID: 471
	public enum Restriction
	{
		// Token: 0x04001AD7 RID: 6871
		None,
		// Token: 0x04001AD8 RID: 6872
		Horizontal,
		// Token: 0x04001AD9 RID: 6873
		Vertical,
		// Token: 0x04001ADA RID: 6874
		PressAndHold,
		// Token: 0x04001ADB RID: 6875
		DragFromMarkedObject
	}

	// Token: 0x020001D8 RID: 472
	public sealed class DragEventHandler : MulticastDelegate
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x0008E6DC File Offset: 0x0008C8DC
		// Note: this type is marked as 'beforefieldinit'.
		static DragEventHandler()
		{
			Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr, "DragEventHandler");
			UI_DragSource.DragEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr, 100666378);
			UI_DragSource.DragEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UI_DragSource_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr, 100666379);
			UI_DragSource.DragEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UI_DragSource_PointerEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr, 100666380);
			UI_DragSource.DragEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr, 100666381);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x0008E750 File Offset: 0x0008C950
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragEventHandler(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_DragSource.DragEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.DragEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x0008E7AC File Offset: 0x0008C9AC
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UI_DragSource e, PointerEventData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.DragEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UI_DragSource_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0008E800 File Offset: 0x0008CA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UI_DragSource e, PointerEventData a, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.DragEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UI_DragSource_PointerEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0008E888 File Offset: 0x0008CA88
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_DragSource.DragEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00017FEB File Offset: 0x000161EB
		public DragEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00017FF4 File Offset: 0x000161F4
		public static implicit operator UI_DragSource.DragEventHandler(Action<UI_DragSource, PointerEventData> A_0)
		{
			return DelegateSupport.ConvertDelegate<UI_DragSource.DragEventHandler>(A_0);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00017FFC File Offset: 0x000161FC
		public static UI_DragSource.DragEventHandler operator +(UI_DragSource.DragEventHandler A_0, UI_DragSource.DragEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UI_DragSource.DragEventHandler>();
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0001800A File Offset: 0x0001620A
		public static UI_DragSource.DragEventHandler operator -(UI_DragSource.DragEventHandler A_0, UI_DragSource.DragEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UI_DragSource.DragEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04001ADC RID: 6876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001ADD RID: 6877
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UI_DragSource_PointerEventData_0;

		// Token: 0x04001ADE RID: 6878
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UI_DragSource_PointerEventData_AsyncCallback_Object_0;

		// Token: 0x04001ADF RID: 6879
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001D9 RID: 473
	public enum PressAndHoldState
	{
		// Token: 0x04001AE1 RID: 6881
		None,
		// Token: 0x04001AE2 RID: 6882
		Ok,
		// Token: 0x04001AE3 RID: 6883
		Failed,
		// Token: 0x04001AE4 RID: 6884
		Checking
	}

	// Token: 0x020001DA RID: 474
	private sealed class MethodInfoStoreGeneric_FindInParents_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001AE5 RID: 6885
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UI_DragSource.NativeMethodInfoPtr_FindInParents_Public_Static_T_GameObject_0, Il2CppClassPointerStore<UI_DragSource>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
