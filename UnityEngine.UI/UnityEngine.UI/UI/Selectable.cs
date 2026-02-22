using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000034 RID: 52
	public class Selectable : UIBehaviour
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x0001FD48 File Offset: 0x0001DF48
		// Note: this type is marked as 'beforefieldinit'.
		static Selectable()
		{
			Il2CppClassPointerStore<Selectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Selectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selectable>.NativeClassPtr);
			Selectable.NativeFieldInfoPtr_s_Selectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_Selectables");
			Selectable.NativeFieldInfoPtr_s_SelectableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "s_SelectableCount");
			Selectable.NativeFieldInfoPtr_m_EnableCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_EnableCalled");
			Selectable.NativeFieldInfoPtr_m_Navigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Navigation");
			Selectable.NativeFieldInfoPtr_m_Transition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Transition");
			Selectable.NativeFieldInfoPtr_m_Colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Colors");
			Selectable.NativeFieldInfoPtr_m_SpriteState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_SpriteState");
			Selectable.NativeFieldInfoPtr_m_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_AnimationTriggers");
			Selectable.NativeFieldInfoPtr_m_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_Interactable");
			Selectable.NativeFieldInfoPtr_m_TargetGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_TargetGraphic");
			Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_GroupsAllowInteraction");
			Selectable.NativeFieldInfoPtr_m_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CurrentIndex");
			Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerInside>k__BackingField");
			Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<isPointerDown>k__BackingField");
			Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "<hasSelection>k__BackingField");
			Selectable.NativeFieldInfoPtr_m_CanvasGroupCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selectable>.NativeClassPtr, "m_CanvasGroupCache");
			Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664235);
			Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664236);
			Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664237);
			Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664238);
			Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664239);
			Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664240);
			Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664241);
			Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664242);
			Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664243);
			Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664244);
			Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664245);
			Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664246);
			Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664247);
			Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664248);
			Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664249);
			Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664250);
			Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664251);
			Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664252);
			Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664253);
			Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664254);
			Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664255);
			Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664256);
			Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664257);
			Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664258);
			Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664259);
			Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664260);
			Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664261);
			Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664262);
			Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664263);
			Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664264);
			Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664265);
			Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664266);
			Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664267);
			Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664268);
			Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664269);
			Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664270);
			Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664271);
			Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664272);
			Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664273);
			Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664274);
			Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664275);
			Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664276);
			Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664277);
			Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664278);
			Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664279);
			Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664280);
			Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664281);
			Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664282);
			Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664283);
			Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664284);
			Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664285);
			Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664286);
			Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664287);
			Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664288);
			Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664289);
			Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664290);
			Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664291);
			Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664292);
			Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664293);
			Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selectable>.NativeClassPtr, 100664294);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00020368 File Offset: 0x0001E568
		public unsafe static Il2CppReferenceArray<Selectable> allSelectablesArray
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117872, XrefRangeEnd = 117881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x0002039C File Offset: 0x0001E59C
		public unsafe static int allSelectableCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117881, XrefRangeEnd = 117885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x000203CC File Offset: 0x0001E5CC
		public unsafe static List<Selectable> allSelectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117885, XrefRangeEnd = 117904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00020400 File Offset: 0x0001E600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117904, XrefRangeEnd = 117913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AllSelectablesNoAlloc(Il2CppReferenceArray<Selectable> selectables)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectables);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00020444 File Offset: 0x0001E644
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x0002047C File Offset: 0x0001E67C
		public unsafe Navigation navigation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 117917, RefRangeEnd = 117921, XrefRangeStart = 117913, XrefRangeEnd = 117917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000204C4 File Offset: 0x0001E6C4
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00020500 File Offset: 0x0001E700
		public unsafe Selectable.Transition transition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_transition_Public_get_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117921, XrefRangeEnd = 117925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00020540 File Offset: 0x0001E740
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0002057C File Offset: 0x0001E77C
		public unsafe ColorBlock colors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 117929, RefRangeEnd = 117937, XrefRangeStart = 117925, XrefRangeEnd = 117929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000205BC File Offset: 0x0001E7BC
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x000205F4 File Offset: 0x0001E7F4
		public unsafe SpriteState spriteState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SpriteState(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117937, XrefRangeEnd = 117941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002063C File Offset: 0x0001E83C
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0002067C File Offset: 0x0001E87C
		public unsafe AnimationTriggers animationTriggers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117941, XrefRangeEnd = 117945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000206C0 File Offset: 0x0001E8C0
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00020700 File Offset: 0x0001E900
		public unsafe Graphic targetGraphic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 117949, RefRangeEnd = 117957, XrefRangeStart = 117945, XrefRangeEnd = 117949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00020744 File Offset: 0x0001E944
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00020780 File Offset: 0x0001E980
		public unsafe bool interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 117980, RefRangeEnd = 118073, XrefRangeStart = 117957, XrefRangeEnd = 117980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x000207C0 File Offset: 0x0001E9C0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x000207FC File Offset: 0x0001E9FC
		public unsafe bool isPointerInside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002083C File Offset: 0x0001EA3C
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00020878 File Offset: 0x0001EA78
		public unsafe bool isPointerDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000208B8 File Offset: 0x0001EAB8
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x000208F4 File Offset: 0x0001EAF4
		public unsafe bool hasSelection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00020934 File Offset: 0x0001EB34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 118088, RefRangeEnd = 118095, XrefRangeStart = 118073, XrefRangeEnd = 118088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selectable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00020970 File Offset: 0x0001EB70
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000209B0 File Offset: 0x0001EBB0
		public unsafe Image image
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 118096, RefRangeEnd = 118098, XrefRangeStart = 118095, XrefRangeEnd = 118096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_image_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_set_image_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x000209F4 File Offset: 0x0001EBF4
		public unsafe Animator animator
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118101, RefRangeEnd = 118107, XrefRangeStart = 118098, XrefRangeEnd = 118101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00020A34 File Offset: 0x0001EC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118107, XrefRangeEnd = 118114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00020A70 File Offset: 0x0001EC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118114, XrefRangeEnd = 118134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasGroupChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00020AAC File Offset: 0x0001ECAC
		[CallerCount(0)]
		public unsafe virtual bool IsInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00020AF4 File Offset: 0x0001ECF4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 118137, RefRangeEnd = 118146, XrefRangeStart = 118134, XrefRangeEnd = 118137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00020B30 File Offset: 0x0001ED30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118168, RefRangeEnd = 118173, XrefRangeStart = 118146, XrefRangeEnd = 118168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00020B6C File Offset: 0x0001ED6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118173, XrefRangeEnd = 118174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00020BA8 File Offset: 0x0001EDA8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 118137, RefRangeEnd = 118146, XrefRangeStart = 118137, XrefRangeEnd = 118146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSetProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_OnSetProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00020BDC File Offset: 0x0001EDDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 118183, RefRangeEnd = 118190, XrefRangeStart = 118174, XrefRangeEnd = 118183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00020C18 File Offset: 0x0001EE18
		public unsafe Selectable.SelectionState currentSelectionState
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 118190, RefRangeEnd = 118199, XrefRangeStart = 118190, XrefRangeEnd = 118190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00020C54 File Offset: 0x0001EE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118199, XrefRangeEnd = 118200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00020C90 File Offset: 0x0001EE90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 118211, RefRangeEnd = 118215, XrefRangeStart = 118200, XrefRangeEnd = 118211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118215, XrefRangeEnd = 118258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Selectable FindSelectable(Vector3 dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dir;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00020D34 File Offset: 0x0001EF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118268, RefRangeEnd = 118269, XrefRangeStart = 118258, XrefRangeEnd = 118268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00020D84 File Offset: 0x0001EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118269, XrefRangeEnd = 118275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate(AxisEventData eventData, Selectable sel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00020E24 File Offset: 0x0001F024
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00020E70 File Offset: 0x0001F070
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00020EBC File Offset: 0x0001F0BC
		[CallerCount(0)]
		public unsafe virtual Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00020F08 File Offset: 0x0001F108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118281, RefRangeEnd = 118283, XrefRangeStart = 118275, XrefRangeEnd = 118281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00020F58 File Offset: 0x0001F158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118283, XrefRangeEnd = 118288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartColorTween(Color targetColor, bool instant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instant;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00020FA4 File Offset: 0x0001F1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118288, XrefRangeEnd = 118295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSpriteSwap(Sprite newSprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSprite);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118323, RefRangeEnd = 118325, XrefRangeStart = 118295, XrefRangeEnd = 118323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerAnimation(string triggername)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(triggername);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0002102C File Offset: 0x0001F22C
		[CallerCount(0)]
		public unsafe bool IsHighlighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00021068 File Offset: 0x0001F268
		[CallerCount(0)]
		public unsafe bool IsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_IsPressed_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000210A4 File Offset: 0x0001F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118325, XrefRangeEnd = 118326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateAndTransitionToSelectionState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Selectable.NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 118340, RefRangeEnd = 118344, XrefRangeStart = 118326, XrefRangeEnd = 118340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00021128 File Offset: 0x0001F328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118344, XrefRangeEnd = 118345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00021178 File Offset: 0x0001F378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118345, XrefRangeEnd = 118346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118346, XrefRangeEnd = 118347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00021218 File Offset: 0x0001F418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118348, RefRangeEnd = 118350, XrefRangeStart = 118347, XrefRangeEnd = 118348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00021268 File Offset: 0x0001F468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118351, RefRangeEnd = 118353, XrefRangeStart = 118350, XrefRangeEnd = 118351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118353, XrefRangeEnd = 118369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Selectable.NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000441C File Offset: 0x0000261C
		public Selectable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x000212F4 File Offset: 0x0001F4F4
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00004425 File Offset: 0x00002625
		public unsafe static Il2CppReferenceArray<Selectable> s_Selectables
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_Selectables, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_Selectables, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0002131C File Offset: 0x0001F51C
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x00004437 File Offset: 0x00002637
		public unsafe static int s_SelectableCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Selectable.NativeFieldInfoPtr_s_SelectableCount, (void*)(&value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00021338 File Offset: 0x0001F538
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00004445 File Offset: 0x00002645
		public unsafe bool m_EnableCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_EnableCalled)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x00021360 File Offset: 0x0001F560
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00004460 File Offset: 0x00002660
		public Navigation m_Navigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation);
				return new Navigation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Navigation>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Navigation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Navigation>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00021390 File Offset: 0x0001F590
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0000448E File Offset: 0x0000268E
		public unsafe Selectable.Transition m_Transition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Transition)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000213B8 File Offset: 0x0001F5B8
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x000044A9 File Offset: 0x000026A9
		public unsafe ColorBlock m_Colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Colors)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000213E0 File Offset: 0x0001F5E0
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x000044C4 File Offset: 0x000026C4
		public SpriteState m_SpriteState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState);
				return new SpriteState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_SpriteState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpriteState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00021410 File Offset: 0x0001F610
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x000044F2 File Offset: 0x000026F2
		public unsafe AnimationTriggers m_AnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationTriggers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00021440 File Offset: 0x0001F640
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00004511 File Offset: 0x00002711
		public unsafe bool m_Interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_Interactable)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00021468 File Offset: 0x0001F668
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0000452C File Offset: 0x0000272C
		public unsafe Graphic m_TargetGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_TargetGraphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00021498 File Offset: 0x0001F698
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0000454B File Offset: 0x0000274B
		public unsafe bool m_GroupsAllowInteraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_GroupsAllowInteraction)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000214C0 File Offset: 0x0001F6C0
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00004566 File Offset: 0x00002766
		public unsafe int m_CurrentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CurrentIndex)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000214E8 File Offset: 0x0001F6E8
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00004581 File Offset: 0x00002781
		public unsafe bool _isPointerInside_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerInside_k__BackingField)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00021510 File Offset: 0x0001F710
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0000459C File Offset: 0x0000279C
		public unsafe bool _isPointerDown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__isPointerDown_k__BackingField)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00021538 File Offset: 0x0001F738
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000045B7 File Offset: 0x000027B7
		public unsafe bool _hasSelection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr__hasSelection_k__BackingField)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00021560 File Offset: 0x0001F760
		// (set) Token: 0x060006CF RID: 1743 RVA: 0x000045D2 File Offset: 0x000027D2
		public unsafe List<CanvasGroup> m_CanvasGroupCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Selectable.NativeFieldInfoPtr_m_CanvasGroupCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeFieldInfoPtr_s_Selectables;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeFieldInfoPtr_s_SelectableCount;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeFieldInfoPtr_m_EnableCalled;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeFieldInfoPtr_m_Navigation;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeFieldInfoPtr_m_Transition;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeFieldInfoPtr_m_Colors;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteState;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimationTriggers;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_m_Interactable;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetGraphic;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupsAllowInteraction;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentIndex;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeFieldInfoPtr__isPointerInside_k__BackingField;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeFieldInfoPtr__isPointerDown_k__BackingField;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr__hasSelection_k__BackingField;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasGroupCache;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectablesArray_Public_Static_get_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectableCount_Public_Static_get_Int32_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_get_allSelectables_Public_Static_get_List_1_Selectable_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_AllSelectablesNoAlloc_Public_Static_Int32_Il2CppReferenceArray_1_Selectable_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_get_navigation_Public_get_Navigation_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_set_navigation_Public_set_Void_Navigation_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_get_transition_Public_get_Transition_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_set_transition_Public_set_Void_Transition_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_get_colors_Public_get_ColorBlock_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_set_colors_Public_set_Void_ColorBlock_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteState_Public_get_SpriteState_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteState_Public_set_Void_SpriteState_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_get_animationTriggers_Public_get_AnimationTriggers_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_set_animationTriggers_Public_set_Void_AnimationTriggers_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_targetGraphic_Public_get_Graphic_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_set_targetGraphic_Public_set_Void_Graphic_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_interactable_Public_get_Boolean_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_set_interactable_Public_set_Void_Boolean_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerInside_Private_get_Boolean_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerInside_Private_set_Void_Boolean_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_get_isPointerDown_Private_get_Boolean_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_set_isPointerDown_Private_set_Void_Boolean_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_set_hasSelection_Private_set_Void_Boolean_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_get_image_Public_get_Image_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Image_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_get_animator_Public_get_Animator_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_IsInteractable_Public_Virtual_New_Boolean_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_OnSetProperty_Private_Void_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectionState_Protected_get_SelectionState_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_InstantClearState_Protected_Virtual_New_Void_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_New_Void_SelectionState_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectable_Public_Selectable_Vector3_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Private_Static_Vector3_RectTransform_Vector2_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Void_AxisEventData_Selectable_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_New_Selectable_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_New_Selectable_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_New_Selectable_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_New_Selectable_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_New_Void_AxisEventData_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_IsHighlighted_Protected_Boolean_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_IsPressed_Protected_Boolean_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateAndTransitionToSelectionState_Private_Void_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_New_Void_0;

		// Token: 0x020000AA RID: 170
		public enum Transition
		{
			// Token: 0x040009AF RID: 2479
			None,
			// Token: 0x040009B0 RID: 2480
			ColorTint,
			// Token: 0x040009B1 RID: 2481
			SpriteSwap,
			// Token: 0x040009B2 RID: 2482
			Animation
		}

		// Token: 0x020000AB RID: 171
		public enum SelectionState
		{
			// Token: 0x040009B4 RID: 2484
			Normal,
			// Token: 0x040009B5 RID: 2485
			Highlighted,
			// Token: 0x040009B6 RID: 2486
			Pressed,
			// Token: 0x040009B7 RID: 2487
			Selected,
			// Token: 0x040009B8 RID: 2488
			Disabled
		}
	}
}
