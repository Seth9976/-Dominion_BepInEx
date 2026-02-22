using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000033 RID: 51
	public class ScrollRect : UIBehaviour
	{
		// Token: 0x060005CB RID: 1483 RVA: 0x0001D59C File Offset: 0x0001B79C
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRect()
		{
			Il2CppClassPointerStore<ScrollRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ScrollRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr);
			ScrollRect.NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Content");
			ScrollRect.NativeFieldInfoPtr_m_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Horizontal");
			ScrollRect.NativeFieldInfoPtr_m_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Vertical");
			ScrollRect.NativeFieldInfoPtr_m_MovementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_MovementType");
			ScrollRect.NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Elasticity");
			ScrollRect.NativeFieldInfoPtr_m_Inertia = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Inertia");
			ScrollRect.NativeFieldInfoPtr_m_DecelerationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_DecelerationRate");
			ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ScrollSensitivity");
			ScrollRect.NativeFieldInfoPtr_m_Viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Viewport");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbar");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarVisibility");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarSpacing");
			ScrollRect.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_OnValueChanged");
			ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PointerStartLocalCursor");
			ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentStartPosition");
			ScrollRect.NativeFieldInfoPtr_m_ViewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewRect");
			ScrollRect.NativeFieldInfoPtr_m_ContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_ViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_ViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Velocity");
			ScrollRect.NativeFieldInfoPtr_m_Dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Dragging");
			ScrollRect.NativeFieldInfoPtr_m_Scrolling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Scrolling");
			ScrollRect.NativeFieldInfoPtr_m_PrevPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevPosition");
			ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevContentBounds");
			ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_PrevViewBounds");
			ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HasRebuiltLayout");
			ScrollRect.NativeFieldInfoPtr_m_HSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_VSliderExpand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderExpand");
			ScrollRect.NativeFieldInfoPtr_m_HSliderHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HSliderHeight");
			ScrollRect.NativeFieldInfoPtr_m_VSliderWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VSliderWidth");
			ScrollRect.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Rect");
			ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_HorizontalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_VerticalScrollbarRect");
			ScrollRect.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Tracker");
			ScrollRect.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "m_Corners");
			ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664144);
			ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664145);
			ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664146);
			ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664147);
			ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664148);
			ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664149);
			ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664150);
			ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664151);
			ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664152);
			ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664153);
			ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664154);
			ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664155);
			ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664156);
			ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664157);
			ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664158);
			ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664159);
			ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664160);
			ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664161);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664162);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664163);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664164);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664165);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664166);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664167);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664168);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664169);
			ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664170);
			ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664171);
			ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664172);
			ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664173);
			ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664174);
			ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664175);
			ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664176);
			ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664177);
			ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664178);
			ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664179);
			ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664180);
			ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664181);
			ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664182);
			ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664183);
			ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664184);
			ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664185);
			ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664186);
			ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664187);
			ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664188);
			ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664189);
			ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664190);
			ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664191);
			ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664192);
			ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664193);
			ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664194);
			ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664195);
			ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664196);
			ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664197);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664198);
			ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664199);
			ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664200);
			ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664201);
			ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664202);
			ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664203);
			ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664204);
			ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664205);
			ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664206);
			ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664207);
			ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664208);
			ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664209);
			ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664210);
			ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664211);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664212);
			ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664213);
			ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664214);
			ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664215);
			ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664216);
			ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664217);
			ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664218);
			ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664219);
			ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664220);
			ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664221);
			ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664222);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664223);
			ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664224);
			ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664225);
			ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664226);
			ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664227);
			ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664228);
			ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664229);
			ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664230);
			ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664231);
			ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664232);
			ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664233);
			ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, 100664234);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001DFCC File Offset: 0x0001C1CC
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x0001E00C File Offset: 0x0001C20C
		public unsafe RectTransform content
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_content_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001E050 File Offset: 0x0001C250
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0001E08C File Offset: 0x0001C28C
		public unsafe bool horizontal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001E0CC File Offset: 0x0001C2CC
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0001E108 File Offset: 0x0001C308
		public unsafe bool vertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001E148 File Offset: 0x0001C348
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x0001E184 File Offset: 0x0001C384
		public unsafe ScrollRect.MovementType movementType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0001E200 File Offset: 0x0001C400
		public unsafe float elasticity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_elasticity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88914, RefRangeEnd = 88916, XrefRangeStart = 88914, XrefRangeEnd = 88916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001E240 File Offset: 0x0001C440
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0001E27C File Offset: 0x0001C47C
		public unsafe bool inertia
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001E2BC File Offset: 0x0001C4BC
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0001E2F8 File Offset: 0x0001C4F8
		public unsafe float decelerationRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88924, RefRangeEnd = 88925, XrefRangeStart = 88924, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001E338 File Offset: 0x0001C538
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x0001E374 File Offset: 0x0001C574
		public unsafe float scrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88925, RefRangeEnd = 88926, XrefRangeStart = 88925, XrefRangeEnd = 88926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001E3B4 File Offset: 0x0001C5B4
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		public unsafe RectTransform viewport
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117106, RefRangeEnd = 117109, XrefRangeStart = 117105, XrefRangeEnd = 117106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001E438 File Offset: 0x0001C638
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x0001E478 File Offset: 0x0001C678
		public unsafe Scrollbar horizontalScrollbar
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117137, RefRangeEnd = 117138, XrefRangeStart = 117109, XrefRangeEnd = 117137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001E4BC File Offset: 0x0001C6BC
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x0001E4FC File Offset: 0x0001C6FC
		public unsafe Scrollbar verticalScrollbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117166, RefRangeEnd = 117169, XrefRangeStart = 117138, XrefRangeEnd = 117166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001E540 File Offset: 0x0001C740
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0001E57C File Offset: 0x0001C77C
		public unsafe ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117170, RefRangeEnd = 117171, XrefRangeStart = 117169, XrefRangeEnd = 117170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001E5BC File Offset: 0x0001C7BC
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
		public unsafe ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117172, RefRangeEnd = 117175, XrefRangeStart = 117171, XrefRangeEnd = 117172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x0001E638 File Offset: 0x0001C838
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0001E674 File Offset: 0x0001C874
		public unsafe float horizontalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117176, RefRangeEnd = 117177, XrefRangeStart = 117175, XrefRangeEnd = 117176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x0001E6B4 File Offset: 0x0001C8B4
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		public unsafe float verticalScrollbarSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117178, RefRangeEnd = 117181, XrefRangeStart = 117177, XrefRangeEnd = 117178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001E730 File Offset: 0x0001C930
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0001E770 File Offset: 0x0001C970
		public unsafe ScrollRect.ScrollRectEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		public unsafe RectTransform viewRect
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 117191, RefRangeEnd = 117218, XrefRangeStart = 117181, XrefRangeEnd = 117191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001E7F4 File Offset: 0x0001C9F4
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0001E830 File Offset: 0x0001CA30
		public unsafe Vector2 velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001E870 File Offset: 0x0001CA70
		public unsafe RectTransform rectTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117225, RefRangeEnd = 117228, XrefRangeStart = 117218, XrefRangeEnd = 117225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117239, RefRangeEnd = 117240, XrefRangeStart = 117228, XrefRangeEnd = 117239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117240, XrefRangeEnd = 117245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001E938 File Offset: 0x0001CB38
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001E974 File Offset: 0x0001CB74
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117297, RefRangeEnd = 117299, XrefRangeStart = 117245, XrefRangeEnd = 117297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateCachedData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001E9E4 File Offset: 0x0001CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117299, XrefRangeEnd = 117332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001EA20 File Offset: 0x0001CC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117332, XrefRangeEnd = 117371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0001EA5C File Offset: 0x0001CC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117371, XrefRangeEnd = 117373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117378, RefRangeEnd = 117380, XrefRangeStart = 117373, XrefRangeEnd = 117378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureLayoutHasRebuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001EAD8 File Offset: 0x0001CCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117380, XrefRangeEnd = 117381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001EB14 File Offset: 0x0001CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117381, XrefRangeEnd = 117389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0001EB64 File Offset: 0x0001CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117390, RefRangeEnd = 117391, XrefRangeStart = 117389, XrefRangeEnd = 117390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117391, XrefRangeEnd = 117400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeginDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0001EC04 File Offset: 0x0001CE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117400, RefRangeEnd = 117401, XrefRangeStart = 117400, XrefRangeEnd = 117400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0001EC54 File Offset: 0x0001CE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117414, RefRangeEnd = 117415, XrefRangeStart = 117401, XrefRangeEnd = 117414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001ECA4 File Offset: 0x0001CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117415, XrefRangeEnd = 117422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentAnchoredPosition(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117422, XrefRangeEnd = 117480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001ED2C File Offset: 0x0001CF2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117487, RefRangeEnd = 117489, XrefRangeStart = 117480, XrefRangeEnd = 117487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrevData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001ED60 File Offset: 0x0001CF60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117511, RefRangeEnd = 117513, XrefRangeStart = 117489, XrefRangeEnd = 117511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbars(Vector2 offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0001EDDC File Offset: 0x0001CFDC
		public unsafe Vector2 normalizedPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117513, XrefRangeEnd = 117515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001EE1C File Offset: 0x0001D01C
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0001EE58 File Offset: 0x0001D058
		public unsafe float horizontalNormalizedPosition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117525, RefRangeEnd = 117528, XrefRangeStart = 117515, XrefRangeEnd = 117525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 117528, RefRangeEnd = 117532, XrefRangeStart = 117528, XrefRangeEnd = 117528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001EE98 File Offset: 0x0001D098
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0001EED4 File Offset: 0x0001D0D4
		public unsafe float verticalNormalizedPosition
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 117545, RefRangeEnd = 117550, XrefRangeStart = 117532, XrefRangeEnd = 117545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 117550, RefRangeEnd = 117556, XrefRangeStart = 117550, XrefRangeEnd = 117550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0001EF14 File Offset: 0x0001D114
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117528, RefRangeEnd = 117532, XrefRangeStart = 117528, XrefRangeEnd = 117532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHorizontalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0001EF54 File Offset: 0x0001D154
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 117550, RefRangeEnd = 117556, XrefRangeStart = 117550, XrefRangeEnd = 117556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerticalNormalizedPosition(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0001EF94 File Offset: 0x0001D194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117556, XrefRangeEnd = 117578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedPosition(float value, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001EFEC File Offset: 0x0001D1EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117579, RefRangeEnd = 117581, XrefRangeStart = 117578, XrefRangeEnd = 117579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float RubberDelta(float overStretching, float viewSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref overStretching;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref viewSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001F038 File Offset: 0x0001D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117581, XrefRangeEnd = 117582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001F074 File Offset: 0x0001D274
		public unsafe bool hScrollingNeeded
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 117583, RefRangeEnd = 117585, XrefRangeStart = 117582, XrefRangeEnd = 117583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		public unsafe bool vScrollingNeeded
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 117586, RefRangeEnd = 117590, XrefRangeStart = 117585, XrefRangeEnd = 117586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001F0EC File Offset: 0x0001D2EC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001F128 File Offset: 0x0001D328
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001F164 File Offset: 0x0001D364
		public unsafe virtual float minWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001F1F4 File Offset: 0x0001D3F4
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001F23C File Offset: 0x0001D43C
		public unsafe virtual float minHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001F284 File Offset: 0x0001D484
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001F2CC File Offset: 0x0001D4CC
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001F314 File Offset: 0x0001D514
		public unsafe virtual int layoutPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001F35C File Offset: 0x0001D55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117590, XrefRangeEnd = 117656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001F398 File Offset: 0x0001D598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117656, XrefRangeEnd = 117665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScrollRect.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001F3D4 File Offset: 0x0001D5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117665, XrefRangeEnd = 117672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001F408 File Offset: 0x0001D608
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117680, RefRangeEnd = 117684, XrefRangeStart = 117672, XrefRangeEnd = 117680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xScrollingNeeded;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xAxisEnabled;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollbarVisibility;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scrollbar);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0001F468 File Offset: 0x0001D668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117713, RefRangeEnd = 117714, XrefRangeStart = 117684, XrefRangeEnd = 117713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbarLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0001F49C File Offset: 0x0001D69C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 117781, RefRangeEnd = 117792, XrefRangeStart = 117714, XrefRangeEnd = 117781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UpdateBounds_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117792, XrefRangeEnd = 117795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPivot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001F52C File Offset: 0x0001D72C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 117812, RefRangeEnd = 117817, XrefRangeStart = 117795, XrefRangeEnd = 117812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds GetBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_GetBounds_Private_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001F568 File Offset: 0x0001D768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117817, XrefRangeEnd = 117827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Bounds InternalGetBounds(Il2CppStructArray<Vector3> corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(corners);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewWorldToLocalMatrix;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001F5B8 File Offset: 0x0001D7B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117836, RefRangeEnd = 117840, XrefRangeStart = 117827, XrefRangeEnd = 117836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateOffset(Vector2 delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001F604 File Offset: 0x0001D804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117840, XrefRangeEnd = 117849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &viewBounds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &contentBounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref horizontal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vertical;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref movementType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001F688 File Offset: 0x0001D888
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117854, RefRangeEnd = 117858, XrefRangeStart = 117849, XrefRangeEnd = 117854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001F6BC File Offset: 0x0001D8BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 117867, RefRangeEnd = 117872, XrefRangeStart = 117858, XrefRangeEnd = 117867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirtyCaching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001F6F0 File Offset: 0x0001D8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00004004 File Offset: 0x00002204
		public ScrollRect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001F730 File Offset: 0x0001D930
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0000400D File Offset: 0x0000220D
		public unsafe RectTransform m_Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001F760 File Offset: 0x0001D960
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0000402C File Offset: 0x0000222C
		public unsafe bool m_Horizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Horizontal)) = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001F788 File Offset: 0x0001D988
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00004047 File Offset: 0x00002247
		public unsafe bool m_Vertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Vertical)) = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0001F7B0 File Offset: 0x0001D9B0
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00004062 File Offset: 0x00002262
		public unsafe ScrollRect.MovementType m_MovementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_MovementType)) = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x0000407D File Offset: 0x0000227D
		public unsafe float m_Elasticity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Elasticity)) = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001F800 File Offset: 0x0001DA00
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00004098 File Offset: 0x00002298
		public unsafe bool m_Inertia
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Inertia)) = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001F828 File Offset: 0x0001DA28
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x000040B3 File Offset: 0x000022B3
		public unsafe float m_DecelerationRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_DecelerationRate)) = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001F850 File Offset: 0x0001DA50
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x000040CE File Offset: 0x000022CE
		public unsafe float m_ScrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ScrollSensitivity)) = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0001F878 File Offset: 0x0001DA78
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x000040E9 File Offset: 0x000022E9
		public unsafe RectTransform m_Viewport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Viewport), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00004108 File Offset: 0x00002308
		public unsafe Scrollbar m_HorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00004127 File Offset: 0x00002327
		public unsafe Scrollbar m_VerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0001F908 File Offset: 0x0001DB08
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00004146 File Offset: 0x00002346
		public unsafe ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001F930 File Offset: 0x0001DB30
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00004161 File Offset: 0x00002361
		public unsafe ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarVisibility)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001F958 File Offset: 0x0001DB58
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x0000417C File Offset: 0x0000237C
		public unsafe float m_HorizontalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001F980 File Offset: 0x0001DB80
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00004197 File Offset: 0x00002397
		public unsafe float m_VerticalScrollbarSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarSpacing)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001F9A8 File Offset: 0x0001DBA8
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000041B2 File Offset: 0x000023B2
		public unsafe ScrollRect.ScrollRectEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect.ScrollRectEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000041D1 File Offset: 0x000023D1
		public unsafe Vector2 m_PointerStartLocalCursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PointerStartLocalCursor)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001FA00 File Offset: 0x0001DC00
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x000041EC File Offset: 0x000023EC
		public unsafe Vector2 m_ContentStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentStartPosition)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001FA28 File Offset: 0x0001DC28
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00004207 File Offset: 0x00002407
		public unsafe RectTransform m_ViewRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001FA58 File Offset: 0x0001DC58
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00004226 File Offset: 0x00002426
		public unsafe Bounds m_ContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ContentBounds)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001FA80 File Offset: 0x0001DC80
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00004241 File Offset: 0x00002441
		public unsafe Bounds m_ViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_ViewBounds)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x0000425C File Offset: 0x0000245C
		public unsafe Vector2 m_Velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Velocity)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00004277 File Offset: 0x00002477
		public unsafe bool m_Dragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Dragging)) = value;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001FAF8 File Offset: 0x0001DCF8
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00004292 File Offset: 0x00002492
		public unsafe bool m_Scrolling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Scrolling)) = value;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001FB20 File Offset: 0x0001DD20
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x000042AD File Offset: 0x000024AD
		public unsafe Vector2 m_PrevPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevPosition)) = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001FB48 File Offset: 0x0001DD48
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x000042C8 File Offset: 0x000024C8
		public unsafe Bounds m_PrevContentBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevContentBounds)) = value;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001FB70 File Offset: 0x0001DD70
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x000042E3 File Offset: 0x000024E3
		public unsafe Bounds m_PrevViewBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_PrevViewBounds)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001FB98 File Offset: 0x0001DD98
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x000042FE File Offset: 0x000024FE
		public unsafe bool m_HasRebuiltLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HasRebuiltLayout)) = value;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00004319 File Offset: 0x00002519
		public unsafe bool m_HSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderExpand)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe bool m_VSliderExpand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderExpand)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001FC10 File Offset: 0x0001DE10
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0000434F File Offset: 0x0000254F
		public unsafe float m_HSliderHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HSliderHeight)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0001FC38 File Offset: 0x0001DE38
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x0000436A File Offset: 0x0000256A
		public unsafe float m_VSliderWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VSliderWidth)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0001FC60 File Offset: 0x0001DE60
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00004385 File Offset: 0x00002585
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001FC90 File Offset: 0x0001DE90
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000043A4 File Offset: 0x000025A4
		public unsafe RectTransform m_HorizontalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_HorizontalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001FCC0 File Offset: 0x0001DEC0
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000043C3 File Offset: 0x000025C3
		public unsafe RectTransform m_VerticalScrollbarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_VerticalScrollbarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000043E2 File Offset: 0x000025E2
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001FD18 File Offset: 0x0001DF18
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000043FD File Offset: 0x000025FD
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRect.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_m_Content;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_m_Horizontal;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_m_Vertical;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_m_MovementType;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_m_Elasticity;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_m_Inertia;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_m_DecelerationRate;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_m_ScrollSensitivity;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_m_Viewport;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbar;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbar;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarVisibility;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarVisibility;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarSpacing;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarSpacing;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerStartLocalCursor;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentStartPosition;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewRect;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentBounds;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewBounds;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_m_Dragging;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_m_Scrolling;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevPosition;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevContentBounds;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevViewBounds;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_m_HasRebuiltLayout;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderExpand;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderExpand;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_m_HSliderHeight;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_m_VSliderWidth;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalScrollbarRect;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalScrollbarRect;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_content_Public_get_RectTransform_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_set_content_Public_set_Void_RectTransform_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Boolean_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontal_Public_set_Void_Boolean_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Boolean_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_set_vertical_Public_set_Void_Boolean_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_get_movementType_Public_get_MovementType_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_set_movementType_Public_set_Void_MovementType_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_get_elasticity_Public_get_Single_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_set_elasticity_Public_set_Void_Single_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_get_inertia_Public_get_Boolean_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_set_inertia_Public_set_Void_Boolean_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_get_decelerationRate_Public_get_Single_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_set_decelerationRate_Public_set_Void_Single_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollSensitivity_Public_get_Single_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_get_viewport_Public_get_RectTransform_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_set_viewport_Public_set_Void_RectTransform_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbar_Public_get_Scrollbar_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbar_Public_set_Void_Scrollbar_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarVisibility_Public_get_ScrollbarVisibility_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarVisibility_Public_set_Void_ScrollbarVisibility_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalScrollbarSpacing_Public_get_Single_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalScrollbarSpacing_Public_set_Void_Single_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_ScrollRectEvent_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_ScrollRectEvent_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_get_viewRect_Protected_get_RectTransform_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedData_Private_Void_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Boolean_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLayoutHasRebuilt_Private_Void_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_StopMovement_Public_Virtual_New_Void_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_OnEndDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_SetContentAnchoredPosition_Protected_Virtual_New_Void_Vector2_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrevData_Protected_Void_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbars_Private_Void_Vector2_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedPosition_Public_get_Vector2_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_set_normalizedPosition_Public_set_Void_Vector2_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalNormalizedPosition_Public_get_Single_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalNormalizedPosition_Public_get_Single_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalNormalizedPosition_Public_set_Void_Single_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticalNormalizedPosition_Private_Void_Single_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedPosition_Protected_Virtual_New_Void_Single_Int32_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr_RubberDelta_Private_Static_Single_Single_Single_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr_get_hScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_get_vScrollingNeeded_Private_get_Boolean_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarVisibility_Private_Void_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOneScrollbarVisibility_Private_Static_Void_Boolean_Boolean_ScrollbarVisibility_Scrollbar_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbarLayout_Private_Void_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBounds_Protected_Void_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBounds_Internal_Static_Void_byref_Bounds_byref_Vector2_byref_Vector3_byref_Vector3_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_GetBounds_Private_Bounds_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetBounds_Internal_Static_Bounds_Il2CppStructArray_1_Vector3_byref_Matrix4x4_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOffset_Private_Vector2_Vector2_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_InternalCalculateOffset_Internal_Static_Vector2_byref_Bounds_byref_Bounds_Boolean_Boolean_MovementType_byref_Vector2_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_SetDirtyCaching_Protected_Void_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000A7 RID: 167
		public enum MovementType
		{
			// Token: 0x040009A6 RID: 2470
			Unrestricted,
			// Token: 0x040009A7 RID: 2471
			Elastic,
			// Token: 0x040009A8 RID: 2472
			Clamped
		}

		// Token: 0x020000A8 RID: 168
		public enum ScrollbarVisibility
		{
			// Token: 0x040009AA RID: 2474
			Permanent,
			// Token: 0x040009AB RID: 2475
			AutoHide,
			// Token: 0x040009AC RID: 2476
			AutoHideAndExpandViewport
		}

		// Token: 0x020000A9 RID: 169
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x06000C61 RID: 3169 RVA: 0x00006991 File Offset: 0x00004B91
			// Note: this type is marked as 'beforefieldinit'.
			static ScrollRectEvent()
			{
				Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRect>.NativeClassPtr, "ScrollRectEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr);
				ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr, 100665043);
			}

			// Token: 0x06000C62 RID: 3170 RVA: 0x00035D48 File Offset: 0x00033F48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117104, RefRangeEnd = 117105, XrefRangeStart = 117101, XrefRangeEnd = 117104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScrollRectEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRect.ScrollRectEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRect.ScrollRectEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C63 RID: 3171 RVA: 0x000069C5 File Offset: 0x00004BC5
			public ScrollRectEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009AD RID: 2477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
