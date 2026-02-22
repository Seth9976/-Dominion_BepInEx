using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000032 RID: 50
	public class Scrollbar : Selectable
	{
		// Token: 0x06000585 RID: 1413 RVA: 0x0001C344 File Offset: 0x0001A544
		// Note: this type is marked as 'beforefieldinit'.
		static Scrollbar()
		{
			Il2CppClassPointerStore<Scrollbar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Scrollbar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr);
			Scrollbar.NativeFieldInfoPtr_m_HandleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_HandleRect");
			Scrollbar.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Direction");
			Scrollbar.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Value");
			Scrollbar.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Size");
			Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_NumberOfSteps");
			Scrollbar.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_OnValueChanged");
			Scrollbar.NativeFieldInfoPtr_m_ContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_ContainerRect");
			Scrollbar.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Offset");
			Scrollbar.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_Tracker");
			Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_PointerDownRepeat");
			Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "isPointerDownAndNotDragging");
			Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "m_DelayedUpdateVisuals");
			Scrollbar.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664100);
			Scrollbar.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664101);
			Scrollbar.NativeMethodInfoPtr_get_direction_Public_get_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664102);
			Scrollbar.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664103);
			Scrollbar.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664104);
			Scrollbar.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664105);
			Scrollbar.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664106);
			Scrollbar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664107);
			Scrollbar.NativeMethodInfoPtr_get_size_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664108);
			Scrollbar.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664109);
			Scrollbar.NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664110);
			Scrollbar.NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664111);
			Scrollbar.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664112);
			Scrollbar.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664113);
			Scrollbar.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664114);
			Scrollbar.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664115);
			Scrollbar.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664116);
			Scrollbar.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664117);
			Scrollbar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664118);
			Scrollbar.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664119);
			Scrollbar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664120);
			Scrollbar.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664121);
			Scrollbar.NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664122);
			Scrollbar.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664123);
			Scrollbar.NativeMethodInfoPtr_get_axis_Private_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664124);
			Scrollbar.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664125);
			Scrollbar.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664126);
			Scrollbar.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664127);
			Scrollbar.NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664128);
			Scrollbar.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664129);
			Scrollbar.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664130);
			Scrollbar.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664131);
			Scrollbar.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664132);
			Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664133);
			Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664134);
			Scrollbar.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664135);
			Scrollbar.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664136);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664137);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664138);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664139);
			Scrollbar.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664140);
			Scrollbar.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664141);
			Scrollbar.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664142);
			Scrollbar.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, 100664143);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0001C814 File Offset: 0x0001AA14
		public unsafe RectTransform handleRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 116823, RefRangeEnd = 116825, XrefRangeStart = 116818, XrefRangeEnd = 116823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001C858 File Offset: 0x0001AA58
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001C894 File Offset: 0x0001AA94
		public unsafe Scrollbar.Direction direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_direction_Public_get_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116825, XrefRangeEnd = 116829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0001C8D4 File Offset: 0x0001AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116829, XrefRangeEnd = 116852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scrollbar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0001C910 File Offset: 0x0001AB10
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0001C94C File Offset: 0x0001AB4C
		public unsafe float value
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 116859, RefRangeEnd = 116873, XrefRangeStart = 116852, XrefRangeEnd = 116859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 116874, RefRangeEnd = 116879, XrefRangeStart = 116873, XrefRangeEnd = 116874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001C98C File Offset: 0x0001AB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116879, XrefRangeEnd = 116883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueWithoutNotify(float input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001C9D8 File Offset: 0x0001ABD8
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0001CA14 File Offset: 0x0001AC14
		public unsafe float size
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_size_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 116888, RefRangeEnd = 116892, XrefRangeStart = 116883, XrefRangeEnd = 116888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_size_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001CA54 File Offset: 0x0001AC54
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0001CA90 File Offset: 0x0001AC90
		public unsafe int numberOfSteps
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116892, XrefRangeEnd = 116905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0001CB10 File Offset: 0x0001AD10
		public unsafe Scrollbar.ScrollEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar.ScrollEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001CB54 File Offset: 0x0001AD54
		public unsafe float stepSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001CB90 File Offset: 0x0001AD90
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001CC18 File Offset: 0x0001AE18
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001CC54 File Offset: 0x0001AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116905, XrefRangeEnd = 116912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001CC90 File Offset: 0x0001AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116912, XrefRangeEnd = 116914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001CCCC File Offset: 0x0001AECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116914, XrefRangeEnd = 116915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001CD08 File Offset: 0x0001AF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116927, RefRangeEnd = 116929, XrefRangeStart = 116915, XrefRangeEnd = 116927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001CD3C File Offset: 0x0001AF3C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 116938, RefRangeEnd = 116945, XrefRangeStart = 116929, XrefRangeEnd = 116938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float input, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001CD88 File Offset: 0x0001AF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116945, XrefRangeEnd = 116947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		public unsafe Scrollbar.Axis axis
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116947, RefRangeEnd = 116948, XrefRangeStart = 116947, XrefRangeEnd = 116947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_axis_Private_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x0001CE00 File Offset: 0x0001B000
		public unsafe bool reverseValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116948, RefRangeEnd = 116949, XrefRangeStart = 116948, XrefRangeEnd = 116948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001CE3C File Offset: 0x0001B03C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 116965, RefRangeEnd = 116977, XrefRangeStart = 116949, XrefRangeEnd = 116965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001CE70 File Offset: 0x0001B070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117007, RefRangeEnd = 117008, XrefRangeStart = 116977, XrefRangeEnd = 117007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001CEB4 File Offset: 0x0001B0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117008, XrefRangeEnd = 117013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdateDrag(Vector2 handleCorner, float remainingSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleCorner;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001CF00 File Offset: 0x0001B100
		[CallerCount(0)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001CF50 File Offset: 0x0001B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117013, XrefRangeEnd = 117029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001CFA0 File Offset: 0x0001B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117029, XrefRangeEnd = 117034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117034, XrefRangeEnd = 117038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001D040 File Offset: 0x0001B240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117038, XrefRangeEnd = 117041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClickRepeat(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001D090 File Offset: 0x0001B290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117045, RefRangeEnd = 117047, XrefRangeStart = 117041, XrefRangeEnd = 117045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117047, XrefRangeEnd = 117048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001D140 File Offset: 0x0001B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117048, XrefRangeEnd = 117080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001D190 File Offset: 0x0001B390
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001D228 File Offset: 0x0001B428
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001D274 File Offset: 0x0001B474
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001D2C0 File Offset: 0x0001B4C0
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Scrollbar.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001D310 File Offset: 0x0001B510
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117098, RefRangeEnd = 117101, XrefRangeStart = 117080, XrefRangeEnd = 117098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeRectLayouts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0001D35C File Offset: 0x0001B55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00003EA7 File Offset: 0x000020A7
		public Scrollbar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001D39C File Offset: 0x0001B59C
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00003EB0 File Offset: 0x000020B0
		public unsafe RectTransform m_HandleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_HandleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_HandleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00003ECF File Offset: 0x000020CF
		public unsafe Scrollbar.Direction m_Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Direction)) = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001D3F4 File Offset: 0x0001B5F4
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00003EEA File Offset: 0x000020EA
		public unsafe float m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001D41C File Offset: 0x0001B61C
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00003F05 File Offset: 0x00002105
		public unsafe float m_Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Size)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001D444 File Offset: 0x0001B644
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00003F20 File Offset: 0x00002120
		public unsafe int m_NumberOfSteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_NumberOfSteps)) = value;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001D46C File Offset: 0x0001B66C
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00003F3B File Offset: 0x0000213B
		public unsafe Scrollbar.ScrollEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar.ScrollEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0001D49C File Offset: 0x0001B69C
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00003F5A File Offset: 0x0000215A
		public unsafe RectTransform m_ContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_ContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_ContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001D4CC File Offset: 0x0001B6CC
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00003F79 File Offset: 0x00002179
		public unsafe Vector2 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001D4F4 File Offset: 0x0001B6F4
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00003F94 File Offset: 0x00002194
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001D51C File Offset: 0x0001B71C
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00003FAF File Offset: 0x000021AF
		public unsafe Coroutine m_PointerDownRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_PointerDownRepeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001D54C File Offset: 0x0001B74C
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00003FCE File Offset: 0x000021CE
		public unsafe bool isPointerDownAndNotDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_isPointerDownAndNotDragging)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001D574 File Offset: 0x0001B774
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00003FE9 File Offset: 0x000021E9
		public unsafe bool m_DelayedUpdateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar.NativeFieldInfoPtr_m_DelayedUpdateVisuals)) = value;
			}
		}

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_m_HandleRect;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberOfSteps;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_m_ContainerRect;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerDownRepeat;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_isPointerDownAndNotDragging;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedUpdateVisuals;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Direction_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Single_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Single_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_numberOfSteps_Public_get_Int32_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_numberOfSteps_Public_set_Void_Int32_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollEvent_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollEvent_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_stepSize_Private_get_Single_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_Single_Boolean_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_axis_Private_get_Axis_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdateDrag_Private_Void_Vector2_Single_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_PointerEventData_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_ClickRepeat_Protected_IEnumerator_Vector2_Camera_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000A3 RID: 163
		public enum Direction
		{
			// Token: 0x04000992 RID: 2450
			LeftToRight,
			// Token: 0x04000993 RID: 2451
			RightToLeft,
			// Token: 0x04000994 RID: 2452
			BottomToTop,
			// Token: 0x04000995 RID: 2453
			TopToBottom
		}

		// Token: 0x020000A4 RID: 164
		[Serializable]
		public class ScrollEvent : UnityEvent<float>
		{
			// Token: 0x06000C4C RID: 3148 RVA: 0x000068B8 File Offset: 0x00004AB8
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollEvent()
			{
				Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "ScrollEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr);
				Scrollbar.ScrollEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr, 100665036);
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x000359B8 File Offset: 0x00033BB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116796, RefRangeEnd = 116797, XrefRangeStart = 116793, XrefRangeEnd = 116796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar.ScrollEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar.ScrollEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x000068EC File Offset: 0x00004AEC
			public ScrollEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000996 RID: 2454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000A5 RID: 165
		public enum Axis
		{
			// Token: 0x04000998 RID: 2456
			Horizontal,
			// Token: 0x04000999 RID: 2457
			Vertical
		}

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("UnityEngine.UI.Scrollbar+<ClickRepeat>d__58")]
		public sealed class _ClickRepeat_d__58 : Object
		{
			// Token: 0x06000C4F RID: 3151 RVA: 0x000359F4 File Offset: 0x00033BF4
			// Note: this type is marked as 'beforefieldinit'.
			static _ClickRepeat_d__58()
			{
				Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scrollbar>.NativeClassPtr, "<ClickRepeat>d__58");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr);
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>1__state");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>2__current");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "<>4__this");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "screenPosition");
				Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, "camera");
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665037);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665038);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665039);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665040);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665041);
				Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr, 100665042);
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x00035AFC File Offset: 0x00033CFC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClickRepeat_d__58(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scrollbar._ClickRepeat_d__58>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x00035B44 File Offset: 0x00033D44
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x00035B78 File Offset: 0x00033D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116797, XrefRangeEnd = 116813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00035BB4 File Offset: 0x00033DB4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x00035BF4 File Offset: 0x00033DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116813, XrefRangeEnd = 116818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00035C28 File Offset: 0x00033E28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scrollbar._ClickRepeat_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C56 RID: 3158 RVA: 0x000068F5 File Offset: 0x00004AF5
			public _ClickRepeat_d__58(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00035C68 File Offset: 0x00033E68
			// (set) Token: 0x06000C58 RID: 3160 RVA: 0x000068FE File Offset: 0x00004AFE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00035C90 File Offset: 0x00033E90
			// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00006919 File Offset: 0x00004B19
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00035CC0 File Offset: 0x00033EC0
			// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00006938 File Offset: 0x00004B38
			public unsafe Scrollbar __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00035CF0 File Offset: 0x00033EF0
			// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00006957 File Offset: 0x00004B57
			public unsafe Vector2 screenPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_screenPosition)) = value;
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00035D18 File Offset: 0x00033F18
			// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00006972 File Offset: 0x00004B72
			public unsafe Camera camera
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scrollbar._ClickRepeat_d__58.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400099A RID: 2458
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400099B RID: 2459
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400099C RID: 2460
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400099D RID: 2461
			private static readonly IntPtr NativeFieldInfoPtr_screenPosition;

			// Token: 0x0400099E RID: 2462
			private static readonly IntPtr NativeFieldInfoPtr_camera;

			// Token: 0x0400099F RID: 2463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009A0 RID: 2464
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009A1 RID: 2465
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009A2 RID: 2466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009A3 RID: 2467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009A4 RID: 2468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
