using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000041 RID: 65
	public class VisualElement : Focusable
	{
		// Token: 0x06000347 RID: 839 RVA: 0x000164AC File Offset: 0x000146AC
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElement()
		{
			Il2CppClassPointerStore<VisualElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement>.NativeClassPtr);
			VisualElement.NativeFieldInfoPtr_s_NextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_NextId");
			VisualElement.NativeFieldInfoPtr_s_EmptyClassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_EmptyClassList");
			VisualElement.NativeFieldInfoPtr_userDataPropertyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "userDataPropertyKey");
			VisualElement.NativeFieldInfoPtr_disabledUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "disabledUssClassName");
			VisualElement.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Name");
			VisualElement.NativeFieldInfoPtr_m_ClassList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_ClassList");
			VisualElement.NativeFieldInfoPtr_m_PropertyBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_PropertyBag");
			VisualElement.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Flags");
			VisualElement.NativeFieldInfoPtr_m_ViewDataKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_ViewDataKey");
			VisualElement.NativeFieldInfoPtr_m_RenderHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_RenderHints");
			VisualElement.NativeFieldInfoPtr_lastLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "lastLayout");
			VisualElement.NativeFieldInfoPtr_lastPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "lastPadding");
			VisualElement.NativeFieldInfoPtr_renderChainData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "renderChainData");
			VisualElement.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Position");
			VisualElement.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Rotation");
			VisualElement.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Scale");
			VisualElement.NativeFieldInfoPtr_m_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Layout");
			VisualElement.NativeFieldInfoPtr_m_BoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_BoundingBox");
			VisualElement.NativeFieldInfoPtr_m_WorldBoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_WorldBoundingBox");
			VisualElement.NativeFieldInfoPtr_m_WorldTransformCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_WorldTransformCache");
			VisualElement.NativeFieldInfoPtr_m_WorldTransformInverseCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_WorldTransformInverseCache");
			VisualElement.NativeFieldInfoPtr_m_WorldClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_WorldClip");
			VisualElement.NativeFieldInfoPtr_m_WorldClipMinusGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_WorldClipMinusGroup");
			VisualElement.NativeFieldInfoPtr_s_InfiniteRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_InfiniteRect");
			VisualElement.NativeFieldInfoPtr_triggerPseudoMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "triggerPseudoMask");
			VisualElement.NativeFieldInfoPtr_dependencyPseudoMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "dependencyPseudoMask");
			VisualElement.NativeFieldInfoPtr_m_PseudoStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_PseudoStates");
			VisualElement.NativeFieldInfoPtr__pickingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<pickingMode>k__BackingField");
			VisualElement.NativeFieldInfoPtr__yogaNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<yogaNode>k__BackingField");
			VisualElement.NativeFieldInfoPtr_m_SharedStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_SharedStyle");
			VisualElement.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Style");
			VisualElement.NativeFieldInfoPtr_variableContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "variableContext");
			VisualElement.NativeFieldInfoPtr_inheritedStylesHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "inheritedStylesHash");
			VisualElement.NativeFieldInfoPtr_controlid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "controlid");
			VisualElement.NativeFieldInfoPtr_imguiContainerDescendantCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "imguiContainerDescendantCount");
			VisualElement.NativeFieldInfoPtr__enabledSelf_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<enabledSelf>k__BackingField");
			VisualElement.NativeFieldInfoPtr__generateVisualContent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<generateVisualContent>k__BackingField");
			VisualElement.NativeFieldInfoPtr_m_SubRenderTargetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_SubRenderTargetMode");
			VisualElement.NativeFieldInfoPtr_s_runtimeMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_runtimeMaterial");
			VisualElement.NativeFieldInfoPtr_m_defaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_defaultMaterial");
			VisualElement.NativeFieldInfoPtr_m_RunningAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_RunningAnimations");
			VisualElement.NativeFieldInfoPtr_k_RootVisualContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "k_RootVisualContainerName");
			VisualElement.NativeFieldInfoPtr__hierarchy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<hierarchy>k__BackingField");
			VisualElement.NativeFieldInfoPtr__isRootVisualContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<isRootVisualContainer>k__BackingField");
			VisualElement.NativeFieldInfoPtr__cacheAsBitmap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<cacheAsBitmap>k__BackingField");
			VisualElement.NativeFieldInfoPtr_m_PhysicalParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_PhysicalParent");
			VisualElement.NativeFieldInfoPtr_m_LogicalParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_LogicalParent");
			VisualElement.NativeFieldInfoPtr_s_EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_EmptyList");
			VisualElement.NativeFieldInfoPtr_m_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_Children");
			VisualElement.NativeFieldInfoPtr__elementPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "<elementPanel>k__BackingField");
			VisualElement.NativeFieldInfoPtr_inlineStyleAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "inlineStyleAccess");
			VisualElement.NativeFieldInfoPtr_styleSheetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "styleSheetList");
			VisualElement.NativeFieldInfoPtr_s_InternalStyleSheetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_InternalStyleSheetPath");
			VisualElement.NativeFieldInfoPtr_tooltipPropertyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "tooltipPropertyKey");
			VisualElement.NativeFieldInfoPtr_s_TypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "s_TypeData");
			VisualElement.NativeFieldInfoPtr_m_TypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "m_TypeData");
			VisualElement.NativeMethodInfoPtr_get_isCompositeRoot_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663586);
			VisualElement.NativeMethodInfoPtr_get_focusController_Public_Virtual_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663587);
			VisualElement.NativeMethodInfoPtr_get_isLayoutManual_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663588);
			VisualElement.NativeMethodInfoPtr_get_layout_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663589);
			VisualElement.NativeMethodInfoPtr_get_isBoundingBoxDirty_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663590);
			VisualElement.NativeMethodInfoPtr_set_isBoundingBoxDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663591);
			VisualElement.NativeMethodInfoPtr_get_isWorldBoundingBoxDirty_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663592);
			VisualElement.NativeMethodInfoPtr_set_isWorldBoundingBoxDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663593);
			VisualElement.NativeMethodInfoPtr_get_boundingBox_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663594);
			VisualElement.NativeMethodInfoPtr_get_worldBoundingBox_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663595);
			VisualElement.NativeMethodInfoPtr_get_boundingBoxInParentSpace_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663596);
			VisualElement.NativeMethodInfoPtr_UpdateBoundingBox_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663597);
			VisualElement.NativeMethodInfoPtr_UpdateWorldBoundingBox_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663598);
			VisualElement.NativeMethodInfoPtr_get_worldBound_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663599);
			VisualElement.NativeMethodInfoPtr_get_rect_Internal_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663600);
			VisualElement.NativeMethodInfoPtr_get_isWorldTransformDirty_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663601);
			VisualElement.NativeMethodInfoPtr_set_isWorldTransformDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663602);
			VisualElement.NativeMethodInfoPtr_get_isWorldTransformInverseDirty_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663603);
			VisualElement.NativeMethodInfoPtr_set_isWorldTransformInverseDirty_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663604);
			VisualElement.NativeMethodInfoPtr_get_worldTransform_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663605);
			VisualElement.NativeMethodInfoPtr_get_worldTransformRef_Internal_get_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663606);
			VisualElement.NativeMethodInfoPtr_get_worldTransformInverse_Internal_get_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663607);
			VisualElement.NativeMethodInfoPtr_UpdateWorldTransform_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663608);
			VisualElement.NativeMethodInfoPtr_UpdateWorldTransformInverse_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663609);
			VisualElement.NativeMethodInfoPtr_get_pseudoStates_Internal_get_PseudoStates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663610);
			VisualElement.NativeMethodInfoPtr_get_pickingMode_Public_get_PickingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663611);
			VisualElement.NativeMethodInfoPtr_get_yogaNode_Internal_get_YogaNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663612);
			VisualElement.NativeMethodInfoPtr_get_computedStyle_Internal_get_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663613);
			VisualElement.NativeMethodInfoPtr_SendEvent_Public_Virtual_Final_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663614);
			VisualElement.NativeMethodInfoPtr_IncrementVersion_Internal_Void_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663615);
			VisualElement.NativeMethodInfoPtr_get_enabledInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663616);
			VisualElement.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663617);
			VisualElement.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663618);
			VisualElement.NativeMethodInfoPtr_get_hierarchy_Public_get_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663619);
			VisualElement.NativeMethodInfoPtr_get_disableClipping_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663620);
			VisualElement.NativeMethodInfoPtr_ShouldClip_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663621);
			VisualElement.NativeMethodInfoPtr_get_elementPanel_Internal_get_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663622);
			VisualElement.NativeMethodInfoPtr_get_panel_Public_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663623);
			VisualElement.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663624);
			VisualElement.NativeMethodInfoPtr_FindCommonAncestor_Public_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663625);
			VisualElement.NativeMethodInfoPtr_RetargetElement_Internal_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663626);
			VisualElement.NativeMethodInfoPtr_get_positionWithLayout_Private_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663627);
			VisualElement.NativeMethodInfoPtr_get_matrixWithLayout_Private_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663628);
			VisualElement.NativeMethodInfoPtr_TransformAlignedRect_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663629);
			VisualElement.NativeMethodInfoPtr_TransformAlignedRect_Internal_Static_Void_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663630);
			VisualElement.NativeMethodInfoPtr_OrderMinMaxRect_Internal_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663631);
			VisualElement.NativeMethodInfoPtr_MultiplyMatrix44Point2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663632);
			VisualElement.NativeMethodInfoPtr_MultiplyVector2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663633);
			VisualElement.NativeMethodInfoPtr_MultiplyMatrix34_Internal_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663634);
			VisualElement.NativeMethodInfoPtr_get_schedule_Public_get_IVisualElementScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663635);
			VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IVisualElementScheduler_Execute_Private_Virtual_Final_New_IVisualElementScheduledItem_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663636);
			VisualElement.NativeMethodInfoPtr_get_resolvedStyle_Public_get_IResolvedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663637);
			VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_display_Private_Virtual_Final_New_get_DisplayStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663638);
			VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_visibility_Private_Virtual_Final_New_get_Visibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, 100663639);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00016D74 File Offset: 0x00014F74
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003EA8 File Offset: 0x000020A8
		public unsafe bool isCompositeRoot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 93172, RefRangeEnd = 93175, XrefRangeStart = 93172, XrefRangeEnd = 93172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isCompositeRoot_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.CompositeRoot) : (this.m_Flags & ~VisualElementFlags.CompositeRoot));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00016DB0 File Offset: 0x00014FB0
		public unsafe override FocusController focusController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93175, XrefRangeEnd = 93178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElement.NativeMethodInfoPtr_get_focusController_Public_Virtual_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00016DFC File Offset: 0x00014FFC
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00003F11 File Offset: 0x00002111
		public unsafe bool isLayoutManual
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isLayoutManual_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.LayoutManual) : (this.m_Flags & ~VisualElementFlags.LayoutManual));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00016E38 File Offset: 0x00015038
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00003F30 File Offset: 0x00002130
		public unsafe Rect layout
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 93186, RefRangeEnd = 93201, XrefRangeStart = 93178, XrefRangeEnd = 93186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_layout_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00016E74 File Offset: 0x00015074
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00016EB0 File Offset: 0x000150B0
		public unsafe bool isBoundingBoxDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isBoundingBoxDirty_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_set_isBoundingBoxDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00016EF0 File Offset: 0x000150F0
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00016F2C File Offset: 0x0001512C
		public unsafe bool isWorldBoundingBoxDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isWorldBoundingBoxDirty_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_set_isWorldBoundingBoxDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00016F6C File Offset: 0x0001516C
		public unsafe Rect boundingBox
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93202, RefRangeEnd = 93204, XrefRangeStart = 93201, XrefRangeEnd = 93202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_boundingBox_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00016FA8 File Offset: 0x000151A8
		public unsafe Rect worldBoundingBox
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93210, RefRangeEnd = 93211, XrefRangeStart = 93204, XrefRangeEnd = 93210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_worldBoundingBox_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00016FE4 File Offset: 0x000151E4
		public unsafe Rect boundingBoxInParentSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93211, XrefRangeEnd = 93217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_boundingBoxInParentSpace_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00017020 File Offset: 0x00015220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93276, RefRangeEnd = 93279, XrefRangeStart = 93217, XrefRangeEnd = 93276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBoundingBox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UpdateBoundingBox_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00017054 File Offset: 0x00015254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93279, XrefRangeEnd = 93285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWorldBoundingBox()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UpdateWorldBoundingBox_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00017088 File Offset: 0x00015288
		public unsafe Rect worldBound
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 93294, RefRangeEnd = 93300, XrefRangeStart = 93285, XrefRangeEnd = 93294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_worldBound_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000170C4 File Offset: 0x000152C4
		public unsafe Rect rect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93300, XrefRangeEnd = 93304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_rect_Internal_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00017100 File Offset: 0x00015300
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0001713C File Offset: 0x0001533C
		public unsafe bool isWorldTransformDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isWorldTransformDirty_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_set_isWorldTransformDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0001717C File Offset: 0x0001537C
		// (set) Token: 0x0600035A RID: 858 RVA: 0x000171B8 File Offset: 0x000153B8
		public unsafe bool isWorldTransformInverseDirty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_isWorldTransformInverseDirty_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_set_isWorldTransformInverseDirty_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600035B RID: 859 RVA: 0x000171F8 File Offset: 0x000153F8
		public unsafe Matrix4x4 worldTransform
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 93305, RefRangeEnd = 93311, XrefRangeStart = 93304, XrefRangeEnd = 93305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_worldTransform_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00017234 File Offset: 0x00015434
		public unsafe ref Matrix4x4 worldTransformRef
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93311, XrefRangeEnd = 93312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_worldTransformRef_Internal_get_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00017268 File Offset: 0x00015468
		public unsafe ref Matrix4x4 worldTransformInverse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_worldTransformInverse_Internal_get_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001729C File Offset: 0x0001549C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 93314, RefRangeEnd = 93321, XrefRangeStart = 93312, XrefRangeEnd = 93314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWorldTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UpdateWorldTransform_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x000172D0 File Offset: 0x000154D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93321, XrefRangeEnd = 93323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWorldTransformInverse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UpdateWorldTransformInverse_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00017304 File Offset: 0x00015504
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00018AE0 File Offset: 0x00016CE0
		public unsafe PseudoStates pseudoStates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_pseudoStates_Internal_get_PseudoStates_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				PseudoStates pseudoStates = this.m_PseudoStates ^ value;
				bool flag = pseudoStates > (PseudoStates)0;
				if (flag)
				{
					this.m_PseudoStates = value;
					bool flag2 = (this.m_PseudoStates & PseudoStates.Root) == PseudoStates.Root;
					if (flag2)
					{
						this.isRootVisualContainer = true;
					}
					bool flag3 = pseudoStates == PseudoStates.Root;
					if (!flag3)
					{
						bool flag4 = (this.triggerPseudoMask & this.m_PseudoStates) != (PseudoStates)0 || (this.dependencyPseudoMask & ~this.m_PseudoStates) > (PseudoStates)0;
						if (flag4)
						{
							this.IncrementVersion(VersionChangeType.StyleSheet);
						}
					}
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00017340 File Offset: 0x00015540
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003F8F File Offset: 0x0000218F
		public unsafe PickingMode pickingMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_pickingMode_Public_get_PickingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._pickingMode_k__BackingField = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001737C File Offset: 0x0001557C
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003FB2 File Offset: 0x000021B2
		public unsafe YogaNode yogaNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_yogaNode_Internal_get_YogaNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<YogaNode>(intPtr3) : null;
			}
			set
			{
				this._yogaNode_k__BackingField = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000173BC File Offset: 0x000155BC
		public unsafe ComputedStyle computedStyle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_computedStyle_Internal_get_ComputedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputedStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000173FC File Offset: 0x000155FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93323, XrefRangeEnd = 93324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_SendEvent_Public_Virtual_Final_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00017440 File Offset: 0x00015640
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 93324, RefRangeEnd = 93332, XrefRangeStart = 93324, XrefRangeEnd = 93324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementVersion(VersionChangeType changeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_IncrementVersion_Internal_Void_VersionChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00017480 File Offset: 0x00015680
		public unsafe bool enabledInHierarchy
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93332, RefRangeEnd = 93334, XrefRangeStart = 93332, XrefRangeEnd = 93332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_enabledInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000367 RID: 871 RVA: 0x000174BC File Offset: 0x000156BC
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0000400B File Offset: 0x0000220B
		public unsafe bool visible
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93337, RefRangeEnd = 93339, XrefRangeStart = 93334, XrefRangeEnd = 93337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_visible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000174F8 File Offset: 0x000156F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93339, XrefRangeEnd = 93344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsPoint(Vector2 localPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localPoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElement.NativeMethodInfoPtr_ContainsPoint_Public_Virtual_New_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0001754C File Offset: 0x0001574C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x000040C7 File Offset: 0x000022C7
		public unsafe VisualElement.Hierarchy hierarchy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_hierarchy_Public_get_Hierarchy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new VisualElement.Hierarchy(intPtr);
			}
			set
			{
				this._hierarchy_k__BackingField = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00017584 File Offset: 0x00015784
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000040F2 File Offset: 0x000022F2
		public unsafe bool disableClipping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_disableClipping_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.DisableClipping) : (this.m_Flags & ~VisualElementFlags.DisableClipping));
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000175C0 File Offset: 0x000157C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93345, RefRangeEnd = 93346, XrefRangeStart = 93344, XrefRangeEnd = 93345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_ShouldClip_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600036C RID: 876 RVA: 0x000175FC File Offset: 0x000157FC
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00004117 File Offset: 0x00002317
		public unsafe BaseVisualElementPanel elementPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_elementPanel_Internal_get_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr3) : null;
			}
			set
			{
				this._elementPanel_k__BackingField = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0001763C File Offset: 0x0001583C
		public unsafe IPanel panel
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 93346, RefRangeEnd = 93368, XrefRangeStart = 93346, XrefRangeEnd = 93346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_panel_Public_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0001767C File Offset: 0x0001587C
		public unsafe virtual VisualElement contentContainer
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElement.NativeMethodInfoPtr_get_contentContainer_Public_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000176C8 File Offset: 0x000158C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93368, RefRangeEnd = 93369, XrefRangeStart = 93368, XrefRangeEnd = 93368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement FindCommonAncestor(VisualElement other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_FindCommonAncestor_Public_VisualElement_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00017718 File Offset: 0x00015918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93371, RefRangeEnd = 93373, XrefRangeStart = 93369, XrefRangeEnd = 93371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement RetargetElement(VisualElement retargetAgainst)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retargetAgainst);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_RetargetElement_Internal_VisualElement_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00017768 File Offset: 0x00015968
		public unsafe Vector3 positionWithLayout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93373, XrefRangeEnd = 93375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_positionWithLayout_Private_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000177A4 File Offset: 0x000159A4
		public unsafe Matrix4x4 matrixWithLayout
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93378, RefRangeEnd = 93379, XrefRangeStart = 93375, XrefRangeEnd = 93378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_matrixWithLayout_Private_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000177E0 File Offset: 0x000159E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93389, RefRangeEnd = 93391, XrefRangeStart = 93379, XrefRangeEnd = 93389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformAlignedRect(ref Rect r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &r;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_TransformAlignedRect_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00017820 File Offset: 0x00015A20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93398, RefRangeEnd = 93401, XrefRangeStart = 93391, XrefRangeEnd = 93398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &matrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_TransformAlignedRect_Internal_Static_Void_byref_Matrix4x4_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00017860 File Offset: 0x00015A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93413, RefRangeEnd = 93415, XrefRangeStart = 93401, XrefRangeEnd = 93413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OrderMinMaxRect(ref Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_OrderMinMaxRect_Internal_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00017894 File Offset: 0x00015A94
		[CallerCount(0)]
		public unsafe static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_MultiplyMatrix44Point2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000178E0 File Offset: 0x00015AE0
		[CallerCount(0)]
		public unsafe static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_MultiplyVector2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001792C File Offset: 0x00015B2C
		[CallerCount(0)]
		public unsafe static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rhs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_MultiplyMatrix34_Internal_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001797C File Offset: 0x00015B7C
		public unsafe IVisualElementScheduler schedule
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 71983, RefRangeEnd = 72005, XrefRangeStart = 71983, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_schedule_Public_get_IVisualElementScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000179BC File Offset: 0x00015BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93415, XrefRangeEnd = 93426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IVisualElementScheduledItem UnityEngine_UIElements_IVisualElementScheduler_Execute(Action updateEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updateEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IVisualElementScheduler_Execute_Private_Virtual_Final_New_IVisualElementScheduledItem_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVisualElementScheduledItem>(intPtr3) : null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00017A0C File Offset: 0x00015C0C
		public unsafe IResolvedStyle resolvedStyle
		{
			[CallerCount(734)]
			[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_get_resolvedStyle_Public_get_IResolvedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResolvedStyle>(intPtr3) : null;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00017A4C File Offset: 0x00015C4C
		public unsafe virtual DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93426, XrefRangeEnd = 93428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_display_Private_Virtual_Final_New_get_DisplayStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00017A88 File Offset: 0x00015C88
		public unsafe virtual Visibility UnityEngine.UIElements.IResolvedStyle.visibility
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93428, XrefRangeEnd = 93430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_visibility_Private_Virtual_Final_New_get_Visibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000038BC File Offset: 0x00001ABC
		public VisualElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00017AC4 File Offset: 0x00015CC4
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000038C5 File Offset: 0x00001AC5
		public unsafe static uint s_NextId
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_NextId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_NextId, (void*)(&value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00017AE0 File Offset: 0x00015CE0
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000038D3 File Offset: 0x00001AD3
		public unsafe static List<string> s_EmptyClassList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_EmptyClassList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_EmptyClassList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00017B08 File Offset: 0x00015D08
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000038E5 File Offset: 0x00001AE5
		public unsafe static PropertyName userDataPropertyKey
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_userDataPropertyKey, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_userDataPropertyKey, (void*)(&value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00017B24 File Offset: 0x00015D24
		// (set) Token: 0x06000386 RID: 902 RVA: 0x000038F3 File Offset: 0x00001AF3
		public unsafe static string disabledUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_disabledUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_disabledUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00017B44 File Offset: 0x00015D44
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003905 File Offset: 0x00001B05
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00017B6C File Offset: 0x00015D6C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003924 File Offset: 0x00001B24
		public unsafe List<string> m_ClassList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_ClassList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_ClassList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00017B9C File Offset: 0x00015D9C
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00003943 File Offset: 0x00001B43
		public unsafe List<KeyValuePair<PropertyName, Object>> m_PropertyBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PropertyBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<PropertyName, Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PropertyBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00017BCC File Offset: 0x00015DCC
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00003962 File Offset: 0x00001B62
		public unsafe VisualElementFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00017BF4 File Offset: 0x00015DF4
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0000397D File Offset: 0x00001B7D
		public unsafe string m_ViewDataKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_ViewDataKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_ViewDataKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00017C1C File Offset: 0x00015E1C
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0000399C File Offset: 0x00001B9C
		public unsafe RenderHints m_RenderHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_RenderHints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_RenderHints)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00017C44 File Offset: 0x00015E44
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000039B7 File Offset: 0x00001BB7
		public unsafe Rect lastLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_lastLayout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_lastLayout)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00017C6C File Offset: 0x00015E6C
		// (set) Token: 0x06000396 RID: 918 RVA: 0x000039D2 File Offset: 0x00001BD2
		public unsafe Rect lastPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_lastPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_lastPadding)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00017C94 File Offset: 0x00015E94
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000039ED File Offset: 0x00001BED
		public UnityEngine.UIElements.UIR.RenderChainVEData renderChainData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_renderChainData);
				return new UnityEngine.UIElements.UIR.RenderChainVEData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityEngine.UIElements.UIR.RenderChainVEData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_renderChainData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityEngine.UIElements.UIR.RenderChainVEData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00017CC4 File Offset: 0x00015EC4
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00003A1B File Offset: 0x00001C1B
		public unsafe Vector3 m_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Position)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00017CEC File Offset: 0x00015EEC
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00003A36 File Offset: 0x00001C36
		public unsafe Quaternion m_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Rotation)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00017D14 File Offset: 0x00015F14
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003A51 File Offset: 0x00001C51
		public unsafe Vector3 m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00017D3C File Offset: 0x00015F3C
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003A6C File Offset: 0x00001C6C
		public unsafe Rect m_Layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Layout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Layout)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00017D64 File Offset: 0x00015F64
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003A87 File Offset: 0x00001C87
		public unsafe Rect m_BoundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_BoundingBox);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_BoundingBox)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00017D8C File Offset: 0x00015F8C
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003AA2 File Offset: 0x00001CA2
		public unsafe Rect m_WorldBoundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldBoundingBox);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldBoundingBox)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00017DB4 File Offset: 0x00015FB4
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003ABD File Offset: 0x00001CBD
		public unsafe Matrix4x4 m_WorldTransformCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldTransformCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldTransformCache)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00017DDC File Offset: 0x00015FDC
		// (set) Token: 0x060003A8 RID: 936 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public unsafe Matrix4x4 m_WorldTransformInverseCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldTransformInverseCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldTransformInverseCache)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00017E04 File Offset: 0x00016004
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003AF3 File Offset: 0x00001CF3
		public unsafe Rect m_WorldClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldClip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldClip)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00017E2C File Offset: 0x0001602C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003B0E File Offset: 0x00001D0E
		public unsafe Rect m_WorldClipMinusGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldClipMinusGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_WorldClipMinusGroup)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00017E54 File Offset: 0x00016054
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003B29 File Offset: 0x00001D29
		public unsafe static Rect s_InfiniteRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_InfiniteRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_InfiniteRect, (void*)(&value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00017E70 File Offset: 0x00016070
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003B37 File Offset: 0x00001D37
		public unsafe PseudoStates triggerPseudoMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_triggerPseudoMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_triggerPseudoMask)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00017E98 File Offset: 0x00016098
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003B52 File Offset: 0x00001D52
		public unsafe PseudoStates dependencyPseudoMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_dependencyPseudoMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_dependencyPseudoMask)) = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00017EC0 File Offset: 0x000160C0
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003B6D File Offset: 0x00001D6D
		public unsafe PseudoStates m_PseudoStates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PseudoStates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PseudoStates)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00017EE8 File Offset: 0x000160E8
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003B88 File Offset: 0x00001D88
		public unsafe PickingMode _pickingMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__pickingMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__pickingMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00017F10 File Offset: 0x00016110
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public unsafe YogaNode _yogaNode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__yogaNode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__yogaNode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00017F40 File Offset: 0x00016140
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00003BC2 File Offset: 0x00001DC2
		public unsafe ComputedStyle m_SharedStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_SharedStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputedStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_SharedStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00017F70 File Offset: 0x00016170
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00003BE1 File Offset: 0x00001DE1
		public unsafe ComputedStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputedStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00017FA0 File Offset: 0x000161A0
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00003C00 File Offset: 0x00001E00
		public unsafe StyleVariableContext variableContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_variableContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_variableContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00017FD0 File Offset: 0x000161D0
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003C1F File Offset: 0x00001E1F
		public unsafe int inheritedStylesHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_inheritedStylesHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_inheritedStylesHash)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00017FF8 File Offset: 0x000161F8
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003C3A File Offset: 0x00001E3A
		public unsafe uint controlid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_controlid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_controlid)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00018020 File Offset: 0x00016220
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003C55 File Offset: 0x00001E55
		public unsafe int imguiContainerDescendantCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_imguiContainerDescendantCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_imguiContainerDescendantCount)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00018048 File Offset: 0x00016248
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003C70 File Offset: 0x00001E70
		public unsafe bool _enabledSelf_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__enabledSelf_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__enabledSelf_k__BackingField)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00018070 File Offset: 0x00016270
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003C8B File Offset: 0x00001E8B
		public unsafe Action<MeshGenerationContext> _generateVisualContent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__generateVisualContent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<MeshGenerationContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__generateVisualContent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000180A0 File Offset: 0x000162A0
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003CAA File Offset: 0x00001EAA
		public unsafe VisualElement.RenderTargetMode m_SubRenderTargetMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_SubRenderTargetMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_SubRenderTargetMode)) = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000180C8 File Offset: 0x000162C8
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003CC5 File Offset: 0x00001EC5
		public unsafe static Material s_runtimeMaterial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_runtimeMaterial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_runtimeMaterial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000180F0 File Offset: 0x000162F0
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00003CD7 File Offset: 0x00001ED7
		public unsafe Material m_defaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_defaultMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_defaultMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00018120 File Offset: 0x00016320
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003CF6 File Offset: 0x00001EF6
		public unsafe List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_RunningAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_RunningAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00018150 File Offset: 0x00016350
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003D15 File Offset: 0x00001F15
		public unsafe static string k_RootVisualContainerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_k_RootVisualContainerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_k_RootVisualContainerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00018170 File Offset: 0x00016370
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003D27 File Offset: 0x00001F27
		public VisualElement.Hierarchy _hierarchy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__hierarchy_k__BackingField);
				return new VisualElement.Hierarchy(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__hierarchy_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000181A0 File Offset: 0x000163A0
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00003D55 File Offset: 0x00001F55
		public unsafe bool _isRootVisualContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__isRootVisualContainer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__isRootVisualContainer_k__BackingField)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000181C8 File Offset: 0x000163C8
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00003D70 File Offset: 0x00001F70
		public unsafe bool _cacheAsBitmap_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__cacheAsBitmap_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__cacheAsBitmap_k__BackingField)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000181F0 File Offset: 0x000163F0
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00003D8B File Offset: 0x00001F8B
		public unsafe VisualElement m_PhysicalParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PhysicalParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_PhysicalParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00018220 File Offset: 0x00016420
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00003DAA File Offset: 0x00001FAA
		public unsafe VisualElement m_LogicalParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_LogicalParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_LogicalParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00018250 File Offset: 0x00016450
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00003DC9 File Offset: 0x00001FC9
		public unsafe static List<VisualElement> s_EmptyList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_EmptyList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_EmptyList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00018278 File Offset: 0x00016478
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003DDB File Offset: 0x00001FDB
		public unsafe List<VisualElement> m_Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000182A8 File Offset: 0x000164A8
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003DFA File Offset: 0x00001FFA
		public unsafe BaseVisualElementPanel _elementPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__elementPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr__elementPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000182D8 File Offset: 0x000164D8
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003E19 File Offset: 0x00002019
		public unsafe InlineStyleAccess inlineStyleAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_inlineStyleAccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InlineStyleAccess>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_inlineStyleAccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00018308 File Offset: 0x00016508
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00003E38 File Offset: 0x00002038
		public unsafe List<StyleSheet> styleSheetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_styleSheetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_styleSheetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00018338 File Offset: 0x00016538
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00003E57 File Offset: 0x00002057
		public unsafe static Regex s_InternalStyleSheetPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_InternalStyleSheetPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_InternalStyleSheetPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00018360 File Offset: 0x00016560
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00003E69 File Offset: 0x00002069
		public unsafe static PropertyName tooltipPropertyKey
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_tooltipPropertyKey, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_tooltipPropertyKey, (void*)(&value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001837C File Offset: 0x0001657C
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00003E77 File Offset: 0x00002077
		public unsafe static Dictionary<Type, VisualElement.TypeData> s_TypeData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElement.NativeFieldInfoPtr_s_TypeData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, VisualElement.TypeData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElement.NativeFieldInfoPtr_s_TypeData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000183A4 File Offset: 0x000165A4
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003E89 File Offset: 0x00002089
		public unsafe VisualElement.TypeData m_TypeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_TypeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement.TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.NativeFieldInfoPtr_m_TypeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000183D4 File Offset: 0x000165D4
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000183EC File Offset: 0x000165EC
		public string viewDataKey
		{
			get
			{
				return this.m_ViewDataKey;
			}
			set
			{
				bool flag = this.m_ViewDataKey != value;
				if (flag)
				{
					this.m_ViewDataKey = value;
					bool flag2 = !String.IsNullOrEmpty(value);
					if (flag2)
					{
						this.IncrementVersion(VersionChangeType.ViewData);
					}
				}
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00003EC7 File Offset: 0x000020C7
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003EDC File Offset: 0x000020DC
		public bool enableViewDataPersistence
		{
			get
			{
				return (this.m_Flags & VisualElementFlags.EnableViewDataPersistence) == VisualElementFlags.EnableViewDataPersistence;
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.EnableViewDataPersistence) : (this.m_Flags & ~VisualElementFlags.EnableViewDataPersistence));
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00018428 File Offset: 0x00016628
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003F01 File Offset: 0x00002101
		public Object userData
		{
			get
			{
				Object @object;
				this.TryGetPropertyInternal(VisualElement.userDataPropertyKey, out @object);
				return @object;
			}
			set
			{
				this.SetPropertyInternal(VisualElement.userDataPropertyKey, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001844C File Offset: 0x0001664C
		public override bool canGrabFocus
		{
			get
			{
				bool flag = false;
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				for (VisualElement visualElement = hierarchy.parent; visualElement != null; visualElement = visualElement.parent)
				{
					bool isCompositeRoot = visualElement.isCompositeRoot;
					if (isCompositeRoot)
					{
						flag |= !visualElement.canGrabFocus;
						break;
					}
				}
				return !flag && this.visible && this.resolvedStyle.display != DisplayStyle.None && this.enabledInHierarchy && base.canGrabFocus;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000184CC File Offset: 0x000166CC
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x000184FC File Offset: 0x000166FC
		public UsageHints usageHints
		{
			get
			{
				return (((this.m_RenderHints & RenderHints.GroupTransform) != RenderHints.None) ? UsageHints.GroupTransform : UsageHints.None) | (((this.m_RenderHints & RenderHints.BoneTransform) != RenderHints.None) ? UsageHints.DynamicTransform : UsageHints.None);
			}
			set
			{
				bool flag = this.panel != null;
				if (flag)
				{
					throw new InvalidOperationException("usageHints cannot be changed once the VisualElement is part of an active visual tree");
				}
				bool flag2 = (value & UsageHints.GroupTransform) > UsageHints.None;
				if (flag2)
				{
					this.m_RenderHints |= RenderHints.GroupTransform;
				}
				else
				{
					this.m_RenderHints &= ~RenderHints.GroupTransform;
				}
				bool flag3 = (value & UsageHints.DynamicTransform) > UsageHints.None;
				if (flag3)
				{
					this.m_RenderHints |= RenderHints.BoneTransform;
				}
				else
				{
					this.m_RenderHints &= ~RenderHints.BoneTransform;
				}
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00018574 File Offset: 0x00016774
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0001858C File Offset: 0x0001678C
		public RenderHints renderHints
		{
			get
			{
				return this.m_RenderHints;
			}
			set
			{
				bool flag = this.panel != null;
				if (flag)
				{
					throw new InvalidOperationException("renderHints cannot be changed once the VisualElement is part of an active visual tree");
				}
				this.m_RenderHints = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000185BC File Offset: 0x000167BC
		public ITransform transform
		{
			get
			{
				return this;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x000185D0 File Offset: 0x000167D0
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x000185E8 File Offset: 0x000167E8
		public Vector3 UnityEngine.UIElements.ITransform.position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				bool flag = this.m_Position == value;
				if (!flag)
				{
					this.m_Position = value;
					this.IncrementVersion(VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001861C File Offset: 0x0001681C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00018634 File Offset: 0x00016834
		public Quaternion UnityEngine.UIElements.ITransform.rotation
		{
			get
			{
				return this.m_Rotation;
			}
			set
			{
				bool flag = this.m_Rotation == value;
				if (!flag)
				{
					this.m_Rotation = value;
					this.IncrementVersion(VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00018668 File Offset: 0x00016868
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00018680 File Offset: 0x00016880
		public Vector3 UnityEngine.UIElements.ITransform.scale
		{
			get
			{
				return this.m_Scale;
			}
			set
			{
				bool flag = this.m_Scale == value;
				if (!flag)
				{
					this.m_Scale = value;
					this.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000186B4 File Offset: 0x000168B4
		public Vector3 ComputeGlobalScale()
		{
			Vector3 scale = this.m_Scale;
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			for (VisualElement visualElement = hierarchy.parent; visualElement != null; visualElement = hierarchy.parent)
			{
				scale.Scale(visualElement.m_Scale);
				hierarchy = visualElement.hierarchy;
			}
			return scale;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00018708 File Offset: 0x00016908
		public Matrix4x4 UnityEngine.UIElements.ITransform.matrix
		{
			get
			{
				return Matrix4x4.TRS(this.m_Position, this.m_Rotation, this.m_Scale);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00018734 File Offset: 0x00016934
		public float scaledPixelsPerPoint
		{
			get
			{
				return (this.panel == null) ? GUIUtility.pixelsPerPoint : this.panel.TryCast<BaseVisualElementPanel>().scaledPixelsPerPoint;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00003F3D File Offset: 0x0000213D
		public Rect contentRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00003F4A File Offset: 0x0000214A
		public Rect paddingRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00018768 File Offset: 0x00016968
		public Rect localBound
		{
			get
			{
				Rect layout = this.layout;
				this.TransformAlignedRect(ref layout);
				return layout;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00003F57 File Offset: 0x00002157
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003F64 File Offset: 0x00002164
		public bool isWorldClipDirty
		{
			get
			{
				return (this.m_Flags & VisualElementFlags.WorldClipDirty) == VisualElementFlags.WorldClipDirty;
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.WorldClipDirty) : (this.m_Flags & ~VisualElementFlags.WorldClipDirty));
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001878C File Offset: 0x0001698C
		public Rect worldClip
		{
			get
			{
				bool isWorldClipDirty = this.isWorldClipDirty;
				if (isWorldClipDirty)
				{
					this.UpdateWorldClip();
					this.isWorldClipDirty = false;
				}
				return this.m_WorldClip;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x000187C0 File Offset: 0x000169C0
		public Rect worldClipMinusGroup
		{
			get
			{
				bool isWorldClipDirty = this.isWorldClipDirty;
				if (isWorldClipDirty)
				{
					this.UpdateWorldClip();
					this.isWorldClipDirty = false;
				}
				return this.m_WorldClipMinusGroup;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000187F4 File Offset: 0x000169F4
		public void EnsureWorldTransformAndClipUpToDate()
		{
			bool isWorldTransformDirty = this.isWorldTransformDirty;
			if (isWorldTransformDirty)
			{
				this.UpdateWorldTransform();
			}
			bool isWorldClipDirty = this.isWorldClipDirty;
			if (isWorldClipDirty)
			{
				this.UpdateWorldClip();
				this.isWorldClipDirty = false;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003F82 File Offset: 0x00002182
		public void UpdateWorldClip()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00018830 File Offset: 0x00016A30
		public Rect SubstractBorderPadding(Rect worldRect)
		{
			float m = this.worldTransform.m00;
			float m2 = this.worldTransform.m11;
			worldRect.x += this.resolvedStyle.borderLeftWidth * m;
			worldRect.y += this.resolvedStyle.borderTopWidth * m2;
			worldRect.width -= (this.resolvedStyle.borderLeftWidth + this.resolvedStyle.borderRightWidth) * m;
			worldRect.height -= (this.resolvedStyle.borderTopWidth + this.resolvedStyle.borderBottomWidth) * m2;
			bool flag = this.computedStyle.unityOverflowClipBox == OverflowClipBox.ContentBox;
			if (flag)
			{
				worldRect.x += this.resolvedStyle.paddingLeft * m;
				worldRect.y += this.resolvedStyle.paddingTop * m2;
				worldRect.width -= (this.resolvedStyle.paddingLeft + this.resolvedStyle.paddingRight) * m;
				worldRect.height -= (this.resolvedStyle.paddingTop + this.resolvedStyle.paddingBottom) * m2;
			}
			return worldRect;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00018984 File Offset: 0x00016B84
		public static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
		{
			Rect rect = position;
			Vector3 vector = mat.MultiplyPoint3x4(new Vector3(rect.x, rect.y, 0f));
			Vector3 vector2 = mat.MultiplyPoint3x4(new Vector3(rect.x + rect.width, rect.y, 0f));
			Vector3 vector3 = mat.MultiplyPoint3x4(new Vector3(rect.x, rect.y + rect.height, 0f));
			Vector3 vector4 = mat.MultiplyPoint3x4(new Vector3(rect.x + rect.width, rect.y + rect.height, 0f));
			return Rect.MinMaxRect(Mathf.Min(vector.x, Mathf.Min(vector2.x, Mathf.Min(vector3.x, vector4.x))), Mathf.Min(vector.y, Mathf.Min(vector2.y, Mathf.Min(vector3.y, vector4.y))), Mathf.Max(vector.x, Mathf.Max(vector2.x, Mathf.Max(vector3.x, vector4.x))), Mathf.Max(vector.y, Mathf.Max(vector2.y, Mathf.Max(vector3.y, vector4.y))));
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00018B6C File Offset: 0x00016D6C
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00018B84 File Offset: 0x00016D84
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				bool flag = this.m_Name == value;
				if (!flag)
				{
					this.m_Name = value;
					this.IncrementVersion(VersionChangeType.StyleSheet);
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00018BB4 File Offset: 0x00016DB4
		public List<string> classList
		{
			get
			{
				bool flag = this.m_ClassList == VisualElement.s_EmptyClassList;
				if (flag)
				{
					this.m_ClassList = ObjectListPool<string>.Get();
				}
				return this.m_ClassList;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00003F98 File Offset: 0x00002198
		public string fullTypeName
		{
			get
			{
				return this.typeData.fullTypeName;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00003FA5 File Offset: 0x000021A5
		public string typeName
		{
			get
			{
				return this.typeData.typeName;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00003FBB File Offset: 0x000021BB
		public ComputedStyle sharedStyle
		{
			get
			{
				return this.m_SharedStyle;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00003FC3 File Offset: 0x000021C3
		public bool hasInlineStyle
		{
			get
			{
				return this.m_Style != this.m_SharedStyle;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00018BEC File Offset: 0x00016DEC
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003FD6 File Offset: 0x000021D6
		public float opacity
		{
			get
			{
				return this.resolvedStyle.opacity;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00018C0C File Offset: 0x00016E0C
		public void ChangeIMGUIContainerCount(int delta)
		{
			VisualElement.Hierarchy hierarchy;
			for (VisualElement visualElement = this; visualElement != null; visualElement = hierarchy.parent)
			{
				visualElement.imguiContainerDescendantCount += delta;
				hierarchy = visualElement.hierarchy;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00018C48 File Offset: 0x00016E48
		public override void ExecuteDefaultAction(EventBase evt)
		{
			base.ExecuteDefaultAction(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.eventTypeId == EventBase<MouseOverEvent>.TypeId() || evt.eventTypeId == EventBase<MouseOutEvent>.TypeId();
				if (flag2)
				{
					this.UpdateCursorStyle(evt.eventTypeId);
				}
				else
				{
					bool flag3 = evt.eventTypeId == EventBase<MouseEnterEvent>.TypeId();
					if (flag3)
					{
						IPanel panel = this.panel;
						IEventHandler eventHandler = ((panel != null) ? panel.GetCapturingElement(PointerId.mousePointerId) : null);
						bool flag4 = eventHandler == null || eventHandler == this;
						if (flag4)
						{
							this.pseudoStates |= PseudoStates.Hover;
						}
					}
					else
					{
						bool flag5 = evt.eventTypeId == EventBase<MouseLeaveEvent>.TypeId();
						if (flag5)
						{
							this.pseudoStates &= ~PseudoStates.Hover;
						}
						else
						{
							bool flag6 = evt.eventTypeId == EventBase<BlurEvent>.TypeId();
							if (flag6)
							{
								this.pseudoStates &= ~PseudoStates.Focus;
							}
							else
							{
								bool flag7 = evt.eventTypeId == EventBase<FocusEvent>.TypeId();
								if (flag7)
								{
									this.pseudoStates |= PseudoStates.Focus;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00018D60 File Offset: 0x00016F60
		public sealed override void Focus()
		{
			bool flag;
			if (!this.canGrabFocus)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				flag = hierarchy.parent != null;
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				hierarchy.parent.Focus();
			}
			else
			{
				base.Focus();
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public void SetPanel(BaseVisualElementPanel p)
		{
			bool flag = this.panel == p;
			if (!flag)
			{
				List<VisualElement> list = VisualElementListPool.Get(0);
				try
				{
					list.Add(this);
					this.GatherAllChildren(list);
					Nullable<EventDispatcherGate> nullable = null;
					bool flag2 = ((p != null) ? p.dispatcher : null) != null;
					if (flag2)
					{
						nullable..ctor(new EventDispatcherGate(p.dispatcher));
					}
					Nullable<EventDispatcherGate> nullable2 = null;
					IPanel panel = this.panel;
					bool flag3 = ((panel != null) ? panel.dispatcher : null) != null && this.panel.dispatcher != ((p != null) ? p.dispatcher : null);
					if (flag3)
					{
						nullable2..ctor(new EventDispatcherGate(this.panel.dispatcher));
					}
					BaseVisualElementPanel elementPanel = this.elementPanel;
					uint num = ((elementPanel != null) ? elementPanel.hierarchyVersion : 0U);
					Nullable<EventDispatcherGate> nullable3 = nullable;
					try
					{
						Nullable<EventDispatcherGate> nullable4 = nullable2;
						try
						{
							List<VisualElement>.Enumerator enumerator = list.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									VisualElement visualElement = enumerator.Current;
									visualElement.WillChangePanel(p);
								}
							}
							finally
							{
								enumerator.Dispose();
							}
							uint num2 = ((elementPanel != null) ? elementPanel.hierarchyVersion : 0U);
							bool flag4 = num != num2;
							if (flag4)
							{
								list.Clear();
								list.Add(this);
								this.GatherAllChildren(list);
							}
							VisualElementFlags visualElementFlags = ((p != null) ? VisualElementFlags.NeedsAttachToPanelEvent : ((VisualElementFlags)0));
							List<VisualElement>.Enumerator enumerator2 = list.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									VisualElement visualElement2 = enumerator2.Current;
									visualElement2.elementPanel = p;
									visualElement2.m_Flags |= visualElementFlags;
								}
							}
							finally
							{
								enumerator2.Dispose();
							}
							List<VisualElement>.Enumerator enumerator3 = list.GetEnumerator();
							try
							{
								while (enumerator3.MoveNext())
								{
									VisualElement visualElement3 = enumerator3.Current;
									visualElement3.HasChangedPanel(elementPanel);
								}
							}
							finally
							{
								enumerator3.Dispose();
							}
						}
						finally
						{
							if (nullable4.HasValue)
							{
								EventDispatcherGate eventDispatcherGate = nullable4.GetValueOrDefault();
								eventDispatcherGate.Dispose();
							}
						}
					}
					finally
					{
						if (nullable3.HasValue)
						{
							EventDispatcherGate eventDispatcherGate = nullable3.GetValueOrDefault();
							eventDispatcherGate.Dispose();
						}
					}
				}
				finally
				{
					VisualElementListPool.Release(list);
				}
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001907C File Offset: 0x0001727C
		public void WillChangePanel(BaseVisualElementPanel destinationPanel)
		{
			bool flag = this.panel != null;
			if (flag)
			{
				bool flag2 = (this.m_Flags & VisualElementFlags.NeedsAttachToPanelEvent) == (VisualElementFlags)0;
				if (flag2)
				{
					using (DetachFromPanelEvent pooled = PanelChangedEventBase<DetachFromPanelEvent>.GetPooled(this.panel, destinationPanel))
					{
						pooled.target = this;
						this.elementPanel.SendEvent(pooled, DispatchMode.Immediate);
					}
				}
				this.UnregisterRunningAnimations();
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000190F8 File Offset: 0x000172F8
		public void HasChangedPanel(BaseVisualElementPanel prevPanel)
		{
			bool flag = this.panel != null;
			if (flag)
			{
				this.yogaNode.Config = this.elementPanel.yogaConfig;
				this.RegisterRunningAnimations();
				bool flag2 = (this.m_Flags & VisualElementFlags.NeedsAttachToPanelEvent) == VisualElementFlags.NeedsAttachToPanelEvent;
				if (flag2)
				{
					using (AttachToPanelEvent pooled = PanelChangedEventBase<AttachToPanelEvent>.GetPooled(prevPanel, this.panel))
					{
						pooled.target = this;
						this.elementPanel.SendEvent(pooled, DispatchMode.Immediate);
					}
					this.m_Flags &= ~VisualElementFlags.NeedsAttachToPanelEvent;
				}
			}
			else
			{
				this.yogaNode.Config = YogaConfig.Default;
			}
			this.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Transform);
			bool flag3 = !String.IsNullOrEmpty(this.viewDataKey);
			if (flag3)
			{
				this.IncrementVersion(VersionChangeType.ViewData);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003FE3 File Offset: 0x000021E3
		public void InvokeHierarchyChanged(HierarchyChangeType changeType)
		{
			BaseVisualElementPanel elementPanel = this.elementPanel;
			if (elementPanel != null)
			{
				elementPanel.InvokeHierarchyChanged(this, changeType);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000191DC File Offset: 0x000173DC
		public bool SetEnabledFromHierarchy(bool state)
		{
			return this.SetEnabledFromHierarchyPrivate(state);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000191F8 File Offset: 0x000173F8
		public bool SetEnabledFromHierarchyPrivate(bool state)
		{
			bool enabledInHierarchy = this.enabledInHierarchy;
			if (state)
			{
				bool isParentEnabledInHierarchy = this.isParentEnabledInHierarchy;
				if (isParentEnabledInHierarchy)
				{
					bool enabledSelf = this.enabledSelf;
					if (enabledSelf)
					{
						this.pseudoStates &= ~PseudoStates.Disabled;
						this.RemoveFromClassList(VisualElement.disabledUssClassName);
					}
					else
					{
						this.pseudoStates |= PseudoStates.Disabled;
						this.AddToClassList(VisualElement.disabledUssClassName);
					}
				}
				else
				{
					this.pseudoStates |= PseudoStates.Disabled;
					this.RemoveFromClassList(VisualElement.disabledUssClassName);
				}
			}
			else
			{
				this.pseudoStates |= PseudoStates.Disabled;
				this.EnableInClassList(VisualElement.disabledUssClassName, this.isParentEnabledInHierarchy);
			}
			return enabledInHierarchy != this.enabledInHierarchy;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000192C0 File Offset: 0x000174C0
		public bool isParentEnabledInHierarchy
		{
			get
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				bool flag;
				if (hierarchy.parent != null)
				{
					hierarchy = this.hierarchy;
					flag = hierarchy.parent.enabledInHierarchy;
				}
				else
				{
					flag = true;
				}
				return flag;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00003FFA File Offset: 0x000021FA
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00004002 File Offset: 0x00002202
		public bool enabledSelf
		{
			get
			{
				return this._enabledSelf_k__BackingField;
			}
			set
			{
				this._enabledSelf_k__BackingField = value;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000192F8 File Offset: 0x000174F8
		public void SetEnabled(bool value)
		{
			bool flag = this.enabledSelf == value;
			if (!flag)
			{
				this.enabledSelf = value;
				this.PropagateEnabledToChildren(value);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00019328 File Offset: 0x00017528
		public void PropagateEnabledToChildren(bool value)
		{
			bool flag = this.SetEnabledFromHierarchyPrivate(value);
			if (flag)
			{
				int count = this.m_Children.Count;
				for (int i = 0; i < count; i++)
				{
					this.m_Children[i].PropagateEnabledToChildren(value);
				}
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00004018 File Offset: 0x00002218
		public void MarkDirtyRepaint()
		{
			this.IncrementVersion(VersionChangeType.Repaint);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004027 File Offset: 0x00002227
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000402F File Offset: 0x0000222F
		public Action<MeshGenerationContext> generateVisualContent
		{
			get
			{
				return this._generateVisualContent_k__BackingField;
			}
			set
			{
				this._generateVisualContent_k__BackingField = value;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00004038 File Offset: 0x00002238
		public void InvokeGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00019374 File Offset: 0x00017574
		public void GetFullHierarchicalViewDataKey(StringBuilder key)
		{
			bool flag = this.parent != null;
			if (flag)
			{
				this.parent.GetFullHierarchicalViewDataKey(key);
			}
			bool flag2 = !String.IsNullOrEmpty(this.viewDataKey);
			if (flag2)
			{
				key.Append("__");
				key.Append(this.viewDataKey);
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000193CC File Offset: 0x000175CC
		public string GetFullHierarchicalViewDataKey()
		{
			StringBuilder stringBuilder = new StringBuilder();
			this.GetFullHierarchicalViewDataKey(stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000193F4 File Offset: 0x000175F4
		public T GetOrCreateViewData<T>(Object existing, string key) where T : class, new()
		{
			Debug.Assert(this.elementPanel != null, "VisualElement.elementPanel is null! Cannot load persistent data.");
			ISerializableJsonDictionary serializableJsonDictionary = ((this.elementPanel == null || this.elementPanel.getViewDataDictionary == null) ? null : this.elementPanel.getViewDataDictionary.Invoke());
			bool flag = serializableJsonDictionary == null || String.IsNullOrEmpty(this.viewDataKey) || !this.enableViewDataPersistence;
			T t;
			if (flag)
			{
				bool flag2 = existing != null;
				if (flag2)
				{
					t = existing.TryCast<T>().Cast<T>();
				}
				else
				{
					t = Activator.CreateInstance<T>();
				}
			}
			else
			{
				string text = "__";
				Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
				string text2 = String.Concat(key, text, (typeFromHandle != null) ? typeFromHandle.ToString() : null);
				bool flag3 = !serializableJsonDictionary.ContainsKey(text2);
				if (flag3)
				{
					serializableJsonDictionary.Set<T>(text2, Activator.CreateInstance<T>());
				}
				t = serializableJsonDictionary.Get<T>(text2);
			}
			return t;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000194CC File Offset: 0x000176CC
		public T GetOrCreateViewData<T>(ScriptableObject existing, string key) where T : ScriptableObject
		{
			Debug.Assert(this.elementPanel != null, "VisualElement.elementPanel is null! Cannot load view data.");
			ISerializableJsonDictionary serializableJsonDictionary = ((this.elementPanel == null || this.elementPanel.getViewDataDictionary == null) ? null : this.elementPanel.getViewDataDictionary.Invoke());
			bool flag = serializableJsonDictionary == null || String.IsNullOrEmpty(this.viewDataKey) || !this.enableViewDataPersistence;
			T t;
			if (flag)
			{
				bool flag2 = existing != null;
				if (flag2)
				{
					t = existing.TryCast<T>().Cast<T>();
				}
				else
				{
					t = ScriptableObject.CreateInstance<T>();
				}
			}
			else
			{
				string text = "__";
				Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
				string text2 = String.Concat(key, text, (typeFromHandle != null) ? typeFromHandle.ToString() : null);
				bool flag3 = !serializableJsonDictionary.ContainsKey(text2);
				if (flag3)
				{
					serializableJsonDictionary.Set<T>(text2, ScriptableObject.CreateInstance<T>());
				}
				t = serializableJsonDictionary.GetScriptable<T>(text2);
			}
			return t;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000195A8 File Offset: 0x000177A8
		public void OverwriteFromViewData(Object obj, string key)
		{
			bool flag = obj == null;
			if (flag)
			{
				throw new ArgumentNullException("obj");
			}
			Debug.Assert(this.elementPanel != null, "VisualElement.elementPanel is null! Cannot load view data.");
			ISerializableJsonDictionary serializableJsonDictionary = ((this.elementPanel == null || this.elementPanel.getViewDataDictionary == null) ? null : this.elementPanel.getViewDataDictionary.Invoke());
			bool flag2 = serializableJsonDictionary == null || String.IsNullOrEmpty(this.viewDataKey) || !this.enableViewDataPersistence;
			if (!flag2)
			{
				string text = "__";
				Type type = obj.GetType();
				string text2 = String.Concat(key, text, (type != null) ? type.ToString() : null);
				bool flag3 = !serializableJsonDictionary.ContainsKey(text2);
				if (flag3)
				{
					serializableJsonDictionary.Set<Object>(text2, obj);
				}
				else
				{
					serializableJsonDictionary.Overwrite(obj, text2);
				}
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00019670 File Offset: 0x00017870
		public void SaveViewData()
		{
			bool flag = this.elementPanel != null && this.elementPanel.saveViewData != null && !String.IsNullOrEmpty(this.viewDataKey) && this.enableViewDataPersistence;
			if (flag)
			{
				this.elementPanel.saveViewData.Invoke();
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000196C0 File Offset: 0x000178C0
		public bool IsViewDataPersitenceSupportedOnChildren(bool existingState)
		{
			bool flag = existingState;
			bool flag2 = String.IsNullOrEmpty(this.viewDataKey) && this != this.contentContainer;
			if (flag2)
			{
				flag = false;
			}
			bool flag3 = this.parent != null && this == this.parent.contentContainer;
			if (flag3)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00004045 File Offset: 0x00002245
		public void OnViewDataReady(bool enablePersistence)
		{
			this.enableViewDataPersistence = enablePersistence;
			this.OnViewDataReady();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00004057 File Offset: 0x00002257
		public virtual void OnViewDataReady()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00019718 File Offset: 0x00017918
		public virtual bool Overlaps(Rect rectangle)
		{
			return this.rect.Overlaps(rectangle, true);
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000405A File Offset: 0x0000225A
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0001973C File Offset: 0x0001793C
		public bool requireMeasureFunction
		{
			get
			{
				return (this.m_Flags & VisualElementFlags.RequireMeasureFunction) == VisualElementFlags.RequireMeasureFunction;
			}
			set
			{
				this.m_Flags = (value ? (this.m_Flags | VisualElementFlags.RequireMeasureFunction) : (this.m_Flags & ~VisualElementFlags.RequireMeasureFunction));
				bool flag = value && !this.yogaNode.IsMeasureDefined;
				if (flag)
				{
					this.AssignMeasureFunction();
				}
				else
				{
					bool flag2 = !value && this.yogaNode.IsMeasureDefined;
					if (flag2)
					{
						this.RemoveMeasureFunction();
					}
				}
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000406F File Offset: 0x0000226F
		public void AssignMeasureFunction()
		{
			this.yogaNode.SetMeasureFunction(new MeasureFunction(this.<AssignMeasureFunction>b__203_0));
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000408A File Offset: 0x0000228A
		public void RemoveMeasureFunction()
		{
			this.yogaNode.SetMeasureFunction(null);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000197B0 File Offset: 0x000179B0
		public virtual Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return new Vector2(float.NaN, float.NaN);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000197D4 File Offset: 0x000179D4
		public YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			Debug.Assert(node == this.yogaNode, "YogaNode instance mismatch");
			Vector2 vector = this.DoMeasure(width, (VisualElement.MeasureMode)widthMode, height, (VisualElement.MeasureMode)heightMode);
			float scaledPixelsPerPoint = this.scaledPixelsPerPoint;
			return MeasureOutput.Make(AlignmentUtils.RoundToPixelGrid(vector.x, scaledPixelsPerPoint, 0.02f), AlignmentUtils.RoundToPixelGrid(vector.y, scaledPixelsPerPoint, 0.02f));
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00019838 File Offset: 0x00017A38
		public void SetSize(Vector2 size)
		{
			Rect layout = this.layout;
			layout.width = size.x;
			layout.height = size.y;
			this.layout = layout;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00019874 File Offset: 0x00017A74
		public void FinalizeLayout()
		{
			bool hasInlineStyle = this.hasInlineStyle;
			if (hasInlineStyle)
			{
				this.computedStyle.SyncWithLayout(this.yogaNode);
			}
			else
			{
				this.yogaNode.CopyStyle(this.computedStyle.yogaNode);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000198BC File Offset: 0x00017ABC
		public void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
			bool flag = this.inlineStyleAccess == null;
			if (flag)
			{
				this.inlineStyleAccess = new InlineStyleAccess(this);
			}
			this.inlineStyleAccess.SetInlineRule(sheet, rule);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000198F4 File Offset: 0x00017AF4
		public void SetSharedStyles(ComputedStyle sharedStyle)
		{
			Debug.Assert(sharedStyle.isShared);
			bool flag = sharedStyle == this.m_SharedStyle;
			if (!flag)
			{
				OverflowInternal overflow = this.m_Style.overflow;
				Length borderBottomLeftRadius = this.m_Style.borderBottomLeftRadius;
				Length borderBottomRightRadius = this.m_Style.borderBottomRightRadius;
				Length borderTopLeftRadius = this.m_Style.borderTopLeftRadius;
				Length borderTopRightRadius = this.m_Style.borderTopRightRadius;
				float borderLeftWidth = this.m_Style.borderLeftWidth;
				float borderTopWidth = this.m_Style.borderTopWidth;
				float borderRightWidth = this.m_Style.borderRightWidth;
				float borderBottomWidth = this.m_Style.borderBottomWidth;
				float opacity = this.m_Style.opacity;
				bool hasInlineStyle = this.hasInlineStyle;
				if (hasInlineStyle)
				{
					this.inlineStyleAccess.ApplyInlineStyles(sharedStyle);
				}
				else
				{
					this.m_Style = sharedStyle;
				}
				this.m_SharedStyle = sharedStyle;
				this.FinalizeLayout();
				VersionChangeType versionChangeType = VersionChangeType.Layout | VersionChangeType.Styles | VersionChangeType.Repaint;
				bool flag2 = this.m_Style.overflow != overflow;
				if (flag2)
				{
					versionChangeType |= VersionChangeType.Overflow;
				}
				bool flag3 = borderBottomLeftRadius != this.m_Style.borderBottomLeftRadius || borderBottomRightRadius != this.m_Style.borderBottomRightRadius || borderTopLeftRadius != this.m_Style.borderTopLeftRadius || borderTopRightRadius != this.m_Style.borderTopRightRadius;
				if (flag3)
				{
					versionChangeType |= VersionChangeType.BorderRadius;
				}
				bool flag4 = borderLeftWidth != this.m_Style.borderLeftWidth || borderTopWidth != this.m_Style.borderTopWidth || borderRightWidth != this.m_Style.borderRightWidth || borderBottomWidth != this.m_Style.borderBottomWidth;
				if (flag4)
				{
					versionChangeType |= VersionChangeType.BorderWidth;
				}
				bool flag5 = this.m_Style.opacity != opacity;
				if (flag5)
				{
					versionChangeType |= VersionChangeType.Opacity;
				}
				this.IncrementVersion(versionChangeType);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000409A File Offset: 0x0000229A
		public void ResetPositionProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000040A7 File Offset: 0x000022A7
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00019ADC File Offset: 0x00017CDC
		public IEnumerable<string> GetClasses()
		{
			return this.m_ClassList;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00019AF4 File Offset: 0x00017CF4
		public List<string> GetClassesForIteration()
		{
			return this.m_ClassList;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00019B0C File Offset: 0x00017D0C
		public void ClearClassList()
		{
			bool flag = this.m_ClassList.Count > 0;
			if (flag)
			{
				ObjectListPool<string>.Release(this.m_ClassList);
				this.m_ClassList = VisualElement.s_EmptyClassList;
				this.IncrementVersion(VersionChangeType.StyleSheet);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00019B50 File Offset: 0x00017D50
		public void AddToClassList(string className)
		{
			bool flag = this.m_ClassList == VisualElement.s_EmptyClassList;
			if (flag)
			{
				this.m_ClassList = ObjectListPool<string>.Get();
			}
			else
			{
				bool flag2 = this.m_ClassList.Contains(className);
				if (flag2)
				{
					return;
				}
				bool flag3 = this.m_ClassList.Capacity == this.m_ClassList.Count;
				if (flag3)
				{
					this.m_ClassList.Capacity++;
				}
			}
			this.m_ClassList.Add(className);
			this.IncrementVersion(VersionChangeType.StyleSheet);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00019BDC File Offset: 0x00017DDC
		public void RemoveFromClassList(string className)
		{
			bool flag = this.m_ClassList.Remove(className);
			if (flag)
			{
				bool flag2 = this.m_ClassList.Count == 0;
				if (flag2)
				{
					ObjectListPool<string>.Release(this.m_ClassList);
					this.m_ClassList = VisualElement.s_EmptyClassList;
				}
				this.IncrementVersion(VersionChangeType.StyleSheet);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00019C30 File Offset: 0x00017E30
		public void ToggleInClassList(string className)
		{
			bool flag = this.ClassListContains(className);
			if (flag)
			{
				this.RemoveFromClassList(className);
			}
			else
			{
				this.AddToClassList(className);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00019C5C File Offset: 0x00017E5C
		public void EnableInClassList(string className, bool enable)
		{
			if (enable)
			{
				this.AddToClassList(className);
			}
			else
			{
				this.RemoveFromClassList(className);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00019C84 File Offset: 0x00017E84
		public bool ClassListContains(string cls)
		{
			for (int i = 0; i < this.m_ClassList.Count; i++)
			{
				bool flag = this.m_ClassList[i] == cls;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00019CD0 File Offset: 0x00017ED0
		public Object FindAncestorUserData()
		{
			for (VisualElement visualElement = this.parent; visualElement != null; visualElement = visualElement.parent)
			{
				bool flag = visualElement.userData != null;
				if (flag)
				{
					return visualElement.userData;
				}
			}
			return null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00019D14 File Offset: 0x00017F14
		public Object GetProperty(PropertyName key)
		{
			VisualElement.CheckUserKeyArgument(key);
			Object @object;
			this.TryGetPropertyInternal(key, out @object);
			return @object;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000040B4 File Offset: 0x000022B4
		public void SetProperty(PropertyName key, Object value)
		{
			VisualElement.CheckUserKeyArgument(key);
			this.SetPropertyInternal(key, value);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00019D38 File Offset: 0x00017F38
		public bool HasProperty(PropertyName key)
		{
			VisualElement.CheckUserKeyArgument(key);
			Object @object;
			return this.TryGetPropertyInternal(key, out @object);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00019D5C File Offset: 0x00017F5C
		public bool TryGetPropertyInternal(PropertyName key, out Object value)
		{
			value = null;
			bool flag = this.m_PropertyBag != null;
			if (flag)
			{
				for (int i = 0; i < this.m_PropertyBag.Count; i++)
				{
					KeyValuePair<PropertyName, Object> keyValuePair = this.m_PropertyBag[i];
					bool flag2 = keyValuePair.Key == key;
					if (flag2)
					{
						keyValuePair = this.m_PropertyBag[i];
						value = keyValuePair.Value;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00019DDC File Offset: 0x00017FDC
		public static void CheckUserKeyArgument(PropertyName key)
		{
			bool flag = PropertyName.IsNullOrEmpty(key);
			if (flag)
			{
				throw new ArgumentNullException("key");
			}
			bool flag2 = key == VisualElement.userDataPropertyKey;
			if (flag2)
			{
				throw new InvalidOperationException(String.Format("The {0} key is reserved by the system", VisualElement.userDataPropertyKey));
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00019E28 File Offset: 0x00018028
		public void SetPropertyInternal(PropertyName key, Object value)
		{
			KeyValuePair<PropertyName, Object> keyValuePair;
			keyValuePair..ctor(key, value);
			bool flag = this.m_PropertyBag == null;
			if (flag)
			{
				this.m_PropertyBag = new List<KeyValuePair<PropertyName, Object>>(1);
				this.m_PropertyBag.Add(keyValuePair);
			}
			else
			{
				for (int i = 0; i < this.m_PropertyBag.Count; i++)
				{
					KeyValuePair<PropertyName, Object> keyValuePair2 = this.m_PropertyBag[i];
					bool flag2 = keyValuePair2.Key == key;
					if (flag2)
					{
						this.m_PropertyBag[i] = keyValuePair;
						return;
					}
				}
				bool flag3 = this.m_PropertyBag.Capacity == this.m_PropertyBag.Count;
				if (flag3)
				{
					this.m_PropertyBag.Capacity++;
				}
				this.m_PropertyBag.Add(keyValuePair);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00019F00 File Offset: 0x00018100
		public void UpdateCursorStyle(long eventType)
		{
			bool flag = this.elementPanel != null;
			if (flag)
			{
				bool flag2 = eventType == EventBase<MouseOverEvent>.TypeId() && this.elementPanel.GetTopElementUnderPointer(PointerId.mousePointerId) == this;
				if (flag2)
				{
					this.elementPanel.cursorManager.SetCursor(this.computedStyle.cursor);
				}
				else
				{
					bool flag3 = eventType == EventBase<MouseOutEvent>.TypeId();
					if (flag3)
					{
						this.elementPanel.cursorManager.ResetCursor();
					}
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00019F80 File Offset: 0x00018180
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00019F98 File Offset: 0x00018198
		public VisualElement.RenderTargetMode subRenderTargetMode
		{
			get
			{
				return this.m_SubRenderTargetMode;
			}
			set
			{
				bool flag = this.m_SubRenderTargetMode == value;
				if (!flag)
				{
					Debug.Assert(Application.isEditor, "subRenderTargetMode is not supported on runtime yet");
					this.m_SubRenderTargetMode = value;
					this.IncrementVersion(VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00019FD8 File Offset: 0x000181D8
		public Material getRuntimeMaterial()
		{
			bool flag = VisualElement.s_runtimeMaterial != null;
			Material material;
			if (flag)
			{
				material = VisualElement.s_runtimeMaterial;
			}
			else
			{
				Shader shader = Shader.Find(UIRUtility.k_DefaultShaderName);
				Debug.Assert(shader != null, "Failed to load UIElements default shader");
				bool flag2 = shader != null;
				if (flag2)
				{
					shader.hideFlags |= HideFlags.DontSaveInEditor;
					Material material2 = new Material(shader);
					material2.hideFlags |= HideFlags.DontSaveInEditor;
					material = (VisualElement.s_runtimeMaterial = material2);
				}
				else
				{
					material = null;
				}
			}
			return material;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001A060 File Offset: 0x00018260
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0001A078 File Offset: 0x00018278
		public Material defaultMaterial
		{
			get
			{
				return this.m_defaultMaterial;
			}
			set
			{
				bool flag = this.m_defaultMaterial == value;
				if (!flag)
				{
					this.m_defaultMaterial = value;
					this.IncrementVersion(VersionChangeType.Layout | VersionChangeType.Repaint);
				}
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001A0AC File Offset: 0x000182AC
		public VisualElementAnimationSystem GetAnimationSystem()
		{
			bool flag = this.elementPanel != null;
			VisualElementAnimationSystem visualElementAnimationSystem;
			if (flag)
			{
				visualElementAnimationSystem = this.elementPanel.GetUpdater(VisualTreeUpdatePhase.Animation).TryCast<VisualElementAnimationSystem>();
			}
			else
			{
				visualElementAnimationSystem = null;
			}
			return visualElementAnimationSystem;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001A0E4 File Offset: 0x000182E4
		public void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			bool flag = this.m_RunningAnimations == null;
			if (flag)
			{
				this.m_RunningAnimations = new List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>();
			}
			this.m_RunningAnimations.Add(anim);
			VisualElementAnimationSystem animationSystem = this.GetAnimationSystem();
			bool flag2 = animationSystem != null;
			if (flag2)
			{
				animationSystem.RegisterAnimation(anim);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001A134 File Offset: 0x00018334
		public void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			bool flag = this.m_RunningAnimations != null;
			if (flag)
			{
				this.m_RunningAnimations.Remove(anim);
			}
			VisualElementAnimationSystem animationSystem = this.GetAnimationSystem();
			bool flag2 = animationSystem != null;
			if (flag2)
			{
				animationSystem.UnregisterAnimation(anim);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001A178 File Offset: 0x00018378
		public void UnregisterRunningAnimations()
		{
			bool flag = this.m_RunningAnimations != null && this.m_RunningAnimations.Count > 0;
			if (flag)
			{
				VisualElementAnimationSystem animationSystem = this.GetAnimationSystem();
				bool flag2 = animationSystem != null;
				if (flag2)
				{
					animationSystem.UnregisterAnimations(this.m_RunningAnimations);
				}
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001A1C4 File Offset: 0x000183C4
		public void RegisterRunningAnimations()
		{
			bool flag = this.m_RunningAnimations != null && this.m_RunningAnimations.Count > 0;
			if (flag)
			{
				VisualElementAnimationSystem animationSystem = this.GetAnimationSystem();
				bool flag2 = animationSystem != null;
				if (flag2)
				{
					animationSystem.RegisterAnimations(this.m_RunningAnimations);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0001A210 File Offset: 0x00018410
		public IExperimentalFeatures experimental
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001A224 File Offset: 0x00018424
		public UnityEngine.UIElements.Experimental.ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000040D0 File Offset: 0x000022D0
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x000040D8 File Offset: 0x000022D8
		public bool isRootVisualContainer
		{
			get
			{
				return this._isRootVisualContainer_k__BackingField;
			}
			set
			{
				this._isRootVisualContainer_k__BackingField = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x000040E1 File Offset: 0x000022E1
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x000040E9 File Offset: 0x000022E9
		public bool cacheAsBitmap
		{
			get
			{
				return this._cacheAsBitmap_k__BackingField;
			}
			set
			{
				this._cacheAsBitmap_k__BackingField = value;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0001A238 File Offset: 0x00018438
		public VisualElement parent
		{
			get
			{
				return this.m_LogicalParent;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001A250 File Offset: 0x00018450
		public void Add(VisualElement child)
		{
			bool flag = child == null;
			if (!flag)
			{
				VisualElement contentContainer = this.contentContainer;
				bool flag2 = contentContainer == null;
				if (flag2)
				{
					throw new InvalidOperationException("You can't add directly to this VisualElement. Use hierarchy.Add() if you know what you're doing.");
				}
				bool flag3 = contentContainer == this;
				if (flag3)
				{
					VisualElement.Hierarchy hierarchy = this.hierarchy;
					hierarchy.Add(child);
				}
				else if (contentContainer != null)
				{
					contentContainer.Add(child);
				}
				child.m_LogicalParent = this;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001A2B8 File Offset: 0x000184B8
		public void Insert(int index, VisualElement element)
		{
			bool flag = element == null;
			if (!flag)
			{
				bool flag2 = this.contentContainer == this;
				if (flag2)
				{
					VisualElement.Hierarchy hierarchy = this.hierarchy;
					hierarchy.Insert(index, element);
				}
				else
				{
					VisualElement contentContainer = this.contentContainer;
					if (contentContainer != null)
					{
						contentContainer.Insert(index, element);
					}
				}
				element.m_LogicalParent = this;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0001A310 File Offset: 0x00018510
		public void Remove(VisualElement element)
		{
			bool flag = this.contentContainer == this;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				hierarchy.Remove(element);
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				if (contentContainer != null)
				{
					contentContainer.Remove(element);
				}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001A354 File Offset: 0x00018554
		public void RemoveAt(int index)
		{
			bool flag = this.contentContainer == this;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				hierarchy.RemoveAt(index);
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				if (contentContainer != null)
				{
					contentContainer.RemoveAt(index);
				}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0001A398 File Offset: 0x00018598
		public void Clear()
		{
			bool flag = this.contentContainer == this;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				hierarchy.Clear();
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				if (contentContainer != null)
				{
					contentContainer.Clear();
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001A3DC File Offset: 0x000185DC
		public VisualElement ElementAt(int index)
		{
			return this[index];
		}

		// Token: 0x1700017A RID: 378
		public VisualElement this[int key]
		{
			get
			{
				bool flag = this.contentContainer == this;
				VisualElement visualElement;
				if (flag)
				{
					VisualElement.Hierarchy hierarchy = this.hierarchy;
					visualElement = hierarchy[key];
				}
				else
				{
					VisualElement contentContainer = this.contentContainer;
					visualElement = ((contentContainer != null) ? contentContainer[key] : null);
				}
				return visualElement;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001A440 File Offset: 0x00018640
		public int childCount
		{
			get
			{
				bool flag = this.contentContainer == this;
				int num;
				if (flag)
				{
					VisualElement.Hierarchy hierarchy = this.hierarchy;
					num = hierarchy.childCount;
				}
				else
				{
					VisualElement contentContainer = this.contentContainer;
					num = ((contentContainer != null) ? contentContainer.childCount : 0);
				}
				return num;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0001A484 File Offset: 0x00018684
		public int IndexOf(VisualElement element)
		{
			bool flag = this.contentContainer == this;
			int num;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				num = hierarchy.IndexOf(element);
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				num = ((contentContainer != null) ? contentContainer.IndexOf(element) : (-1));
			}
			return num;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0001A4CC File Offset: 0x000186CC
		public VisualElement ElementAtTreePath(List<int> childIndexes)
		{
			VisualElement visualElement = this;
			List<int>.Enumerator enumerator = childIndexes.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					int num = enumerator.Current;
					VisualElement.Hierarchy hierarchy;
					bool flag;
					if (num >= 0)
					{
						int num2 = num;
						hierarchy = visualElement.hierarchy;
						flag = num2 < hierarchy.childCount;
					}
					else
					{
						flag = false;
					}
					bool flag2 = flag;
					if (!flag2)
					{
						return null;
					}
					hierarchy = visualElement.hierarchy;
					visualElement = hierarchy[num];
				}
			}
			finally
			{
				enumerator.Dispose();
			}
			return visualElement;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001A55C File Offset: 0x0001875C
		public bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
		{
			VisualElement visualElement = element;
			VisualElement.Hierarchy hierarchy = visualElement.hierarchy;
			for (VisualElement visualElement2 = hierarchy.parent; visualElement2 != null; visualElement2 = hierarchy.parent)
			{
				int num = 0;
				hierarchy = visualElement2.hierarchy;
				outChildIndexes.Insert(num, hierarchy.IndexOf(visualElement));
				bool flag = visualElement2 == this;
				if (flag)
				{
					return true;
				}
				visualElement = visualElement2;
				hierarchy = visualElement2.hierarchy;
			}
			outChildIndexes.Clear();
			return false;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001A5D0 File Offset: 0x000187D0
		public IEnumerable<VisualElement> Children()
		{
			bool flag = this.contentContainer == this;
			IEnumerable<VisualElement> enumerable;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				enumerable = hierarchy.Children();
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				enumerable = ((contentContainer != null) ? contentContainer.Children() : null) ?? VisualElement.s_EmptyList;
			}
			return enumerable;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001A61C File Offset: 0x0001881C
		public void Sort(Comparison<VisualElement> comp)
		{
			bool flag = this.contentContainer == this;
			if (flag)
			{
				VisualElement.Hierarchy hierarchy = this.hierarchy;
				hierarchy.Sort(comp);
			}
			else
			{
				VisualElement contentContainer = this.contentContainer;
				if (contentContainer != null)
				{
					contentContainer.Sort(comp);
				}
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001A660 File Offset: 0x00018860
		public void BringToFront()
		{
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			bool flag = hierarchy.parent == null;
			if (!flag)
			{
				hierarchy = this.hierarchy;
				hierarchy = hierarchy.parent.hierarchy;
				hierarchy.BringToFront(this);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public void SendToBack()
		{
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			bool flag = hierarchy.parent == null;
			if (!flag)
			{
				hierarchy = this.hierarchy;
				hierarchy = hierarchy.parent.hierarchy;
				hierarchy.SendToBack(this);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001A6E8 File Offset: 0x000188E8
		public void PlaceBehind(VisualElement sibling)
		{
			bool flag = sibling == null;
			if (flag)
			{
				throw new ArgumentNullException("sibling");
			}
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			bool flag2;
			if (hierarchy.parent != null)
			{
				hierarchy = sibling.hierarchy;
				VisualElement parent = hierarchy.parent;
				hierarchy = this.hierarchy;
				flag2 = parent != hierarchy.parent;
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			if (flag3)
			{
				throw new ArgumentException("VisualElements are not siblings");
			}
			hierarchy = this.hierarchy;
			hierarchy = hierarchy.parent.hierarchy;
			hierarchy.PlaceBehind(this, sibling);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001A76C File Offset: 0x0001896C
		public void PlaceInFront(VisualElement sibling)
		{
			bool flag = sibling == null;
			if (flag)
			{
				throw new ArgumentNullException("sibling");
			}
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			bool flag2;
			if (hierarchy.parent != null)
			{
				hierarchy = sibling.hierarchy;
				VisualElement parent = hierarchy.parent;
				hierarchy = this.hierarchy;
				flag2 = parent != hierarchy.parent;
			}
			else
			{
				flag2 = true;
			}
			bool flag3 = flag2;
			if (flag3)
			{
				throw new ArgumentException("VisualElements are not siblings");
			}
			hierarchy = this.hierarchy;
			hierarchy = hierarchy.parent.hierarchy;
			hierarchy.PlaceInFront(this, sibling);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001A7F0 File Offset: 0x000189F0
		public void RemoveFromHierarchy()
		{
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			bool flag = hierarchy.parent != null;
			if (flag)
			{
				hierarchy = this.hierarchy;
				hierarchy = hierarchy.parent.hierarchy;
				hierarchy.Remove(this);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001A834 File Offset: 0x00018A34
		public T GetFirstOfType<T>() where T : class
		{
			T t = base.TryCast<T>().Cast<T>();
			bool flag = t != null;
			T t2;
			if (flag)
			{
				t2 = t;
			}
			else
			{
				t2 = this.GetFirstAncestorOfType<T>();
			}
			return t2;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001A86C File Offset: 0x00018A6C
		public T GetFirstAncestorOfType<T>() where T : class
		{
			VisualElement.Hierarchy hierarchy = this.hierarchy;
			for (VisualElement visualElement = hierarchy.parent; visualElement != null; visualElement = hierarchy.parent)
			{
				T t = visualElement.TryCast<T>().Cast<T>();
				bool flag = t != null;
				if (flag)
				{
					return t;
				}
				hierarchy = visualElement.hierarchy;
			}
			return default(T);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public bool Contains(VisualElement child)
		{
			while (child != null)
			{
				VisualElement.Hierarchy hierarchy = child.hierarchy;
				bool flag = hierarchy.parent == this;
				if (flag)
				{
					return true;
				}
				hierarchy = child.hierarchy;
				child = hierarchy.parent;
			}
			return false;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001A924 File Offset: 0x00018B24
		public void GatherAllChildren(List<VisualElement> elements)
		{
			bool flag = this.m_Children.Count > 0;
			if (flag)
			{
				int i = elements.Count;
				elements.AddRange(this.m_Children);
				while (i < elements.Count)
				{
					VisualElement visualElement = elements[i];
					elements.AddRange(visualElement.m_Children);
					i++;
				}
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001A984 File Offset: 0x00018B84
		public VisualElement GetRoot()
		{
			bool flag = this.panel != null;
			VisualElement visualElement;
			if (flag)
			{
				visualElement = this.panel.visualTree;
			}
			else
			{
				VisualElement visualElement2 = this;
				while (visualElement2.m_PhysicalParent != null)
				{
					visualElement2 = visualElement2.m_PhysicalParent;
				}
				visualElement = visualElement2;
			}
			return visualElement;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		public VisualElement GetRootVisualContainer()
		{
			VisualElement.Hierarchy hierarchy;
			for (VisualElement visualElement = this; visualElement != null; visualElement = hierarchy.parent)
			{
				bool isRootVisualContainer = visualElement.isRootVisualContainer;
				if (isRootVisualContainer)
				{
					return visualElement;
				}
				hierarchy = visualElement.hierarchy;
			}
			return null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001AA14 File Offset: 0x00018C14
		public VisualElement GetNextElementDepthFirst()
		{
			bool flag = this.m_Children.Count > 0;
			VisualElement visualElement;
			if (flag)
			{
				visualElement = this.m_Children[0];
			}
			else
			{
				VisualElement visualElement2 = this.m_PhysicalParent;
				VisualElement visualElement3 = this;
				while (visualElement2 != null)
				{
					int i;
					for (i = 0; i < visualElement2.m_Children.Count; i++)
					{
						bool flag2 = visualElement2.m_Children[i] == visualElement3;
						if (flag2)
						{
							break;
						}
					}
					bool flag3 = i < visualElement2.m_Children.Count - 1;
					if (flag3)
					{
						return visualElement2.m_Children[i + 1];
					}
					visualElement3 = visualElement2;
					visualElement2 = visualElement2.m_PhysicalParent;
				}
				visualElement = null;
			}
			return visualElement;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001AAD4 File Offset: 0x00018CD4
		public VisualElement GetPreviousElementDepthFirst()
		{
			bool flag = this.m_PhysicalParent != null;
			VisualElement visualElement2;
			if (flag)
			{
				int i;
				for (i = 0; i < this.m_PhysicalParent.m_Children.Count; i++)
				{
					bool flag2 = this.m_PhysicalParent.m_Children[i] == this;
					if (flag2)
					{
						break;
					}
				}
				bool flag3 = i > 0;
				if (flag3)
				{
					VisualElement visualElement = this.m_PhysicalParent.m_Children[i - 1];
					while (visualElement.m_Children.Count > 0)
					{
						visualElement = visualElement.m_Children[visualElement.m_Children.Count - 1];
					}
					visualElement2 = visualElement;
				}
				else
				{
					visualElement2 = this.m_PhysicalParent;
				}
			}
			else
			{
				visualElement2 = null;
			}
			return visualElement2;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001AB9C File Offset: 0x00018D9C
		public static Rect MultiplyMatrix44Rect2(ref Matrix4x4 lhs, Rect r)
		{
			r.position = VisualElement.MultiplyMatrix44Point2(ref lhs, r.position);
			r.size = VisualElement.MultiplyVector2(ref lhs, r.size);
			return r;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001ABDC File Offset: 0x00018DDC
		public IStyle style
		{
			get
			{
				bool flag = this.inlineStyleAccess == null;
				if (flag)
				{
					this.inlineStyleAccess = new InlineStyleAccess(this);
				}
				return this.inlineStyleAccess;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00004120 File Offset: 0x00002320
		public ICustomStyle customStyle
		{
			get
			{
				return this.computedStyle;
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00004128 File Offset: 0x00002328
		public void AddStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00004135 File Offset: 0x00002335
		public bool HasStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00004142 File Offset: 0x00002342
		public void RemoveStyleSheetPath(string sheetPath)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0001AC10 File Offset: 0x00018E10
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000414F File Offset: 0x0000234F
		public string tooltip
		{
			get
			{
				string text = this.GetProperty(VisualElement.tooltipPropertyKey).TryCast<string>();
				return text ?? String.Empty;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001AC40 File Offset: 0x00018E40
		public static void OnTooltip(TooltipEvent e)
		{
			VisualElement visualElement = e.currentTarget.TryCast<VisualElement>();
			bool flag = visualElement != null && !String.IsNullOrEmpty(visualElement.tooltip);
			if (flag)
			{
				e.rect = visualElement.worldBound;
				e.tooltip = visualElement.tooltip;
				e.StopImmediatePropagation();
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000415C File Offset: 0x0000235C
		public VisualElement.TypeData typeData
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00004169 File Offset: 0x00002369
		public Align UnityEngine.UIElements.IResolvedStyle.alignContent
		{
			get
			{
				return this.computedStyle.alignContent;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00004176 File Offset: 0x00002376
		public Align UnityEngine.UIElements.IResolvedStyle.alignItems
		{
			get
			{
				return this.computedStyle.alignItems;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00004183 File Offset: 0x00002383
		public Align UnityEngine.UIElements.IResolvedStyle.alignSelf
		{
			get
			{
				return this.computedStyle.alignSelf;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00004190 File Offset: 0x00002390
		public Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
		{
			get
			{
				return this.computedStyle.backgroundColor;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0000419D File Offset: 0x0000239D
		public Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
		{
			get
			{
				return this.computedStyle.backgroundImage;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x000041AA File Offset: 0x000023AA
		public Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
		{
			get
			{
				return this.computedStyle.borderBottomColor;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001AC98 File Offset: 0x00018E98
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
		{
			get
			{
				return this.computedStyle.borderBottomLeftRadius.value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
		{
			get
			{
				return this.computedStyle.borderBottomRightRadius.value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000041B7 File Offset: 0x000023B7
		public float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
		{
			get
			{
				return this.computedStyle.borderBottomWidth;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x000041C4 File Offset: 0x000023C4
		public Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
		{
			get
			{
				return this.computedStyle.borderLeftColor;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x000041D1 File Offset: 0x000023D1
		public float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
		{
			get
			{
				return this.computedStyle.borderLeftWidth;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x000041DE File Offset: 0x000023DE
		public Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
		{
			get
			{
				return this.computedStyle.borderRightColor;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000041EB File Offset: 0x000023EB
		public float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
		{
			get
			{
				return this.computedStyle.borderRightWidth;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000041F8 File Offset: 0x000023F8
		public Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
		{
			get
			{
				return this.computedStyle.borderTopColor;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		public float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
		{
			get
			{
				return this.computedStyle.borderTopLeftRadius.value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001ACF8 File Offset: 0x00018EF8
		public float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
		{
			get
			{
				return this.computedStyle.borderTopRightRadius.value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00004205 File Offset: 0x00002405
		public float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
		{
			get
			{
				return this.computedStyle.borderTopWidth;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00004212 File Offset: 0x00002412
		public float UnityEngine.UIElements.IResolvedStyle.bottom
		{
			get
			{
				return this.yogaNode.LayoutBottom;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000421F File Offset: 0x0000241F
		public Color UnityEngine.UIElements.IResolvedStyle.color
		{
			get
			{
				return this.computedStyle.color;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000422C File Offset: 0x0000242C
		public FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
		{
			get
			{
				return this.computedStyle.flexDirection;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00004239 File Offset: 0x00002439
		public float UnityEngine.UIElements.IResolvedStyle.flexGrow
		{
			get
			{
				return this.computedStyle.flexGrow;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00004246 File Offset: 0x00002446
		public float UnityEngine.UIElements.IResolvedStyle.flexShrink
		{
			get
			{
				return this.computedStyle.flexShrink;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00004253 File Offset: 0x00002453
		public Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
		{
			get
			{
				return this.computedStyle.flexWrap;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001AD18 File Offset: 0x00018F18
		public float UnityEngine.UIElements.IResolvedStyle.fontSize
		{
			get
			{
				return this.computedStyle.fontSize.value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00004260 File Offset: 0x00002460
		public float UnityEngine.UIElements.IResolvedStyle.height
		{
			get
			{
				return this.yogaNode.LayoutHeight;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000426D File Offset: 0x0000246D
		public Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
		{
			get
			{
				return this.computedStyle.justifyContent;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x0000427A File Offset: 0x0000247A
		public float UnityEngine.UIElements.IResolvedStyle.left
		{
			get
			{
				return this.yogaNode.LayoutX;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00004287 File Offset: 0x00002487
		public float UnityEngine.UIElements.IResolvedStyle.marginBottom
		{
			get
			{
				return this.yogaNode.LayoutMarginBottom;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00004294 File Offset: 0x00002494
		public float UnityEngine.UIElements.IResolvedStyle.marginLeft
		{
			get
			{
				return this.yogaNode.LayoutMarginLeft;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x000042A1 File Offset: 0x000024A1
		public float UnityEngine.UIElements.IResolvedStyle.marginRight
		{
			get
			{
				return this.yogaNode.LayoutMarginRight;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x000042AE File Offset: 0x000024AE
		public float UnityEngine.UIElements.IResolvedStyle.marginTop
		{
			get
			{
				return this.yogaNode.LayoutMarginTop;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x000042BB File Offset: 0x000024BB
		public float UnityEngine.UIElements.IResolvedStyle.opacity
		{
			get
			{
				return this.computedStyle.opacity;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000042C8 File Offset: 0x000024C8
		public float UnityEngine.UIElements.IResolvedStyle.paddingBottom
		{
			get
			{
				return this.yogaNode.LayoutPaddingBottom;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000042D5 File Offset: 0x000024D5
		public float UnityEngine.UIElements.IResolvedStyle.paddingLeft
		{
			get
			{
				return this.yogaNode.LayoutPaddingLeft;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x000042E2 File Offset: 0x000024E2
		public float UnityEngine.UIElements.IResolvedStyle.paddingRight
		{
			get
			{
				return this.yogaNode.LayoutPaddingRight;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000042EF File Offset: 0x000024EF
		public float UnityEngine.UIElements.IResolvedStyle.paddingTop
		{
			get
			{
				return this.yogaNode.LayoutPaddingTop;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000042FC File Offset: 0x000024FC
		public Position UnityEngine.UIElements.IResolvedStyle.position
		{
			get
			{
				return this.computedStyle.position;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00004309 File Offset: 0x00002509
		public float UnityEngine.UIElements.IResolvedStyle.right
		{
			get
			{
				return this.yogaNode.LayoutRight;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x00004316 File Offset: 0x00002516
		public TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
		{
			get
			{
				return this.computedStyle.textOverflow;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00004323 File Offset: 0x00002523
		public float UnityEngine.UIElements.IResolvedStyle.top
		{
			get
			{
				return this.yogaNode.LayoutY;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00004330 File Offset: 0x00002530
		public Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
		{
			get
			{
				return this.computedStyle.unityBackgroundImageTintColor;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x0000433D File Offset: 0x0000253D
		public ScaleMode UnityEngine.UIElements.IResolvedStyle.unityBackgroundScaleMode
		{
			get
			{
				return this.computedStyle.unityBackgroundScaleMode;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0000434A File Offset: 0x0000254A
		public Font UnityEngine.UIElements.IResolvedStyle.unityFont
		{
			get
			{
				return this.computedStyle.unityFont;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00004357 File Offset: 0x00002557
		public FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
		{
			get
			{
				return this.computedStyle.unityFontStyleAndWeight;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00004364 File Offset: 0x00002564
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
		{
			get
			{
				return this.computedStyle.unitySliceBottom;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00004371 File Offset: 0x00002571
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
		{
			get
			{
				return this.computedStyle.unitySliceLeft;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000437E File Offset: 0x0000257E
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
		{
			get
			{
				return this.computedStyle.unitySliceRight;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000438B File Offset: 0x0000258B
		public int UnityEngine.UIElements.IResolvedStyle.unitySliceTop
		{
			get
			{
				return this.computedStyle.unitySliceTop;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00004398 File Offset: 0x00002598
		public TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
		{
			get
			{
				return this.computedStyle.unityTextAlign;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000043A5 File Offset: 0x000025A5
		public TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
		{
			get
			{
				return this.computedStyle.unityTextOverflowPosition;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x000043B2 File Offset: 0x000025B2
		public WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
		{
			get
			{
				return this.computedStyle.whiteSpace;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000043BF File Offset: 0x000025BF
		public float UnityEngine.UIElements.IResolvedStyle.width
		{
			get
			{
				return this.yogaNode.LayoutWidth;
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000043CC File Offset: 0x000025CC
		public YogaSize <AssignMeasureFunction>b__203_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode)
		{
			return this.Measure(node, f, mode, f1, heightMode);
		}

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_s_NextId;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyClassList;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_userDataPropertyKey;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_disabledUssClassName;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_m_ClassList;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyBag;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewDataKey;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderHints;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_lastLayout;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_lastPadding;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_renderChainData;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_m_Layout;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_m_BoundingBox;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldBoundingBox;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldTransformCache;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldTransformInverseCache;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldClip;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldClipMinusGroup;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_s_InfiniteRect;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_triggerPseudoMask;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_dependencyPseudoMask;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_m_PseudoStates;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr__pickingMode_k__BackingField;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr__yogaNode_k__BackingField;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_m_SharedStyle;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_variableContext;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_inheritedStylesHash;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_controlid;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_imguiContainerDescendantCount;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr__enabledSelf_k__BackingField;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr__generateVisualContent_k__BackingField;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_m_SubRenderTargetMode;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_s_runtimeMaterial;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultMaterial;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_m_RunningAnimations;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_k_RootVisualContainerName;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr__hierarchy_k__BackingField;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr__isRootVisualContainer_k__BackingField;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr__cacheAsBitmap_k__BackingField;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_m_PhysicalParent;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_m_LogicalParent;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyList;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_m_Children;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr__elementPanel_k__BackingField;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_inlineStyleAccess;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_styleSheetList;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalStyleSheetPath;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_tooltipPropertyKey;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeData;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_m_TypeData;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_get_isCompositeRoot_Internal_get_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Virtual_get_FocusController_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_get_isLayoutManual_Internal_get_Boolean_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_layout_Public_get_Rect_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_get_isBoundingBoxDirty_Internal_get_Boolean_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_set_isBoundingBoxDirty_Internal_set_Void_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldBoundingBoxDirty_Internal_get_Boolean_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldBoundingBoxDirty_Internal_set_Void_Boolean_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBox_Internal_get_Rect_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_get_worldBoundingBox_Internal_get_Rect_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_get_boundingBoxInParentSpace_Private_get_Rect_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBoundingBox_Internal_Void_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldBoundingBox_Internal_Void_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_worldBound_Public_get_Rect_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Internal_get_Rect_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldTransformDirty_Internal_get_Boolean_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldTransformDirty_Internal_set_Void_Boolean_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_get_isWorldTransformInverseDirty_Internal_get_Boolean_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_set_isWorldTransformInverseDirty_Internal_set_Void_Boolean_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_worldTransform_Public_get_Matrix4x4_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_worldTransformRef_Internal_get_byref_Matrix4x4_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_get_worldTransformInverse_Internal_get_byref_Matrix4x4_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldTransform_Internal_Void_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldTransformInverse_Internal_Void_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_pseudoStates_Internal_get_PseudoStates_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_get_pickingMode_Public_get_PickingMode_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_yogaNode_Internal_get_YogaNode_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_computedStyle_Internal_get_ComputedStyle_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Virtual_Final_Void_EventBase_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_IncrementVersion_Internal_Void_VersionChangeType_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_enabledInHierarchy_Public_get_Boolean_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Public_get_Boolean_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_ContainsPoint_Public_Virtual_New_Boolean_Vector2_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_get_hierarchy_Public_get_Hierarchy_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_get_disableClipping_Internal_get_Boolean_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_ShouldClip_Internal_Boolean_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_elementPanel_Internal_get_BaseVisualElementPanel_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_get_IPanel_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_contentContainer_Public_Virtual_New_get_VisualElement_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_FindCommonAncestor_Public_VisualElement_VisualElement_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_RetargetElement_Internal_VisualElement_VisualElement_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_get_positionWithLayout_Private_get_Vector3_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_get_matrixWithLayout_Private_get_Matrix4x4_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_TransformAlignedRect_Private_Void_byref_Rect_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_TransformAlignedRect_Internal_Static_Void_byref_Matrix4x4_byref_Rect_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_OrderMinMaxRect_Internal_Static_Void_byref_Rect_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyMatrix44Point2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyVector2_Internal_Static_Vector2_byref_Matrix4x4_Vector2_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyMatrix34_Internal_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_schedule_Public_get_IVisualElementScheduler_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IVisualElementScheduler_Execute_Private_Virtual_Final_New_IVisualElementScheduledItem_Action_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_resolvedStyle_Public_get_IResolvedStyle_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_display_Private_Virtual_Final_New_get_DisplayStyle_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IResolvedStyle_get_visibility_Private_Virtual_Final_New_get_Visibility_0;

		// Token: 0x020001F8 RID: 504
		public enum RenderTargetMode
		{
			// Token: 0x0400087C RID: 2172
			None,
			// Token: 0x0400087D RID: 2173
			NoColorConversion,
			// Token: 0x0400087E RID: 2174
			LinearToGamma,
			// Token: 0x0400087F RID: 2175
			GammaToLinear
		}

		// Token: 0x020001F9 RID: 505
		public sealed class Hierarchy : ValueType
		{
			// Token: 0x0600136F RID: 4975 RVA: 0x0003B734 File Offset: 0x00039934
			// Note: this type is marked as 'beforefieldinit'.
			static Hierarchy()
			{
				Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "Hierarchy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr);
				VisualElement.Hierarchy.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, "m_Owner");
				VisualElement.Hierarchy.NativeMethodInfoPtr_get_parent_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663641);
				VisualElement.Hierarchy.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663642);
				VisualElement.Hierarchy.NativeMethodInfoPtr_get_Item_Public_get_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663643);
				VisualElement.Hierarchy.NativeMethodInfoPtr_Equals_Public_Boolean_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663644);
				VisualElement.Hierarchy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663645);
				VisualElement.Hierarchy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663646);
				VisualElement.Hierarchy.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hierarchy_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr, 100663647);
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001370 RID: 4976 RVA: 0x0003B800 File Offset: 0x00039A00
			public unsafe VisualElement parent
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 93099, RefRangeEnd = 93123, XrefRangeStart = 93099, XrefRangeEnd = 93099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_get_parent_Public_get_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001371 RID: 4977 RVA: 0x0003B844 File Offset: 0x00039A44
			public unsafe int childCount
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 93124, RefRangeEnd = 93128, XrefRangeStart = 93123, XrefRangeEnd = 93124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700060D RID: 1549
			public unsafe VisualElement this[int key]
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 93130, RefRangeEnd = 93133, XrefRangeStart = 93128, XrefRangeEnd = 93130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref key;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_get_Item_Public_get_VisualElement_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06001373 RID: 4979 RVA: 0x0003B8DC File Offset: 0x00039ADC
			[CallerCount(0)]
			public unsafe bool Equals(VisualElement.Hierarchy other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_Equals_Public_Boolean_Hierarchy_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001374 RID: 4980 RVA: 0x0003B934 File Offset: 0x00039B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93133, XrefRangeEnd = 93136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001375 RID: 4981 RVA: 0x0003B988 File Offset: 0x00039B88
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001376 RID: 4982 RVA: 0x0003B9CC File Offset: 0x00039BCC
			[CallerCount(0)]
			public unsafe static bool operator ==(VisualElement.Hierarchy x, VisualElement.Hierarchy y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.Hierarchy.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hierarchy_Hierarchy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001377 RID: 4983 RVA: 0x0000C7CB File Offset: 0x0000A9CB
			public Hierarchy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001378 RID: 4984 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
			public Hierarchy()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElement.Hierarchy>.NativeClassPtr))
			{
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001379 RID: 4985 RVA: 0x0003BA2C File Offset: 0x00039C2C
			// (set) Token: 0x0600137A RID: 4986 RVA: 0x0000C7E6 File Offset: 0x0000A9E6
			public unsafe VisualElement m_Owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.Hierarchy.NativeFieldInfoPtr_m_Owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.Hierarchy.NativeFieldInfoPtr_m_Owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000880 RID: 2176
			private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

			// Token: 0x04000881 RID: 2177
			private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_VisualElement_0;

			// Token: 0x04000882 RID: 2178
			private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

			// Token: 0x04000883 RID: 2179
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_VisualElement_Int32_0;

			// Token: 0x04000884 RID: 2180
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Hierarchy_0;

			// Token: 0x04000885 RID: 2181
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04000886 RID: 2182
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04000887 RID: 2183
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hierarchy_Hierarchy_0;
		}

		// Token: 0x020001FA RID: 506
		public class BaseVisualElementScheduledItem : ScheduledItem
		{
			// Token: 0x0600137B RID: 4987 RVA: 0x0003BA5C File Offset: 0x00039C5C
			// Note: this type is marked as 'beforefieldinit'.
			static BaseVisualElementScheduledItem()
			{
				Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "BaseVisualElementScheduledItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr);
				VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr__element_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, "<element>k__BackingField");
				VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_isScheduled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, "isScheduled");
				VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_m_Activator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, "m_Activator");
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_get_element_Public_Virtual_Final_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663648);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_set_element_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663649);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr__ctor_Protected_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663650);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663651);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_Resume_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663652);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnPanelActivate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663653);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnPanelDeactivate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663654);
				VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_CanBeActivated_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr, 100663655);
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x0600137C RID: 4988 RVA: 0x0003BB64 File Offset: 0x00039D64
			// (set) Token: 0x0600137D RID: 4989 RVA: 0x0003BBA4 File Offset: 0x00039DA4
			public unsafe virtual VisualElement element
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_get_element_Public_Virtual_Final_New_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_set_element_Private_set_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600137E RID: 4990 RVA: 0x0003BBE8 File Offset: 0x00039DE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93152, RefRangeEnd = 93153, XrefRangeStart = 93136, XrefRangeEnd = 93152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseVisualElementScheduledItem(VisualElement handler)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElement.BaseVisualElementScheduledItem>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr__ctor_Protected_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600137F RID: 4991 RVA: 0x0003BC34 File Offset: 0x00039E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93153, XrefRangeEnd = 93154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnItemUnscheduled()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001380 RID: 4992 RVA: 0x0003BC70 File Offset: 0x00039E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93154, XrefRangeEnd = 93156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Resume()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_Resume_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001381 RID: 4993 RVA: 0x0003BCA4 File Offset: 0x00039EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93156, XrefRangeEnd = 93163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPanelActivate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnPanelActivate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001382 RID: 4994 RVA: 0x0003BCD8 File Offset: 0x00039ED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93163, XrefRangeEnd = 93166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void OnPanelDeactivate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_OnPanelDeactivate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001383 RID: 4995 RVA: 0x0003BD0C File Offset: 0x00039F0C
			[CallerCount(0)]
			public unsafe virtual bool CanBeActivated()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.BaseVisualElementScheduledItem.NativeMethodInfoPtr_CanBeActivated_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001384 RID: 4996 RVA: 0x0000C805 File Offset: 0x0000AA05
			public BaseVisualElementScheduledItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001385 RID: 4997 RVA: 0x0003BD48 File Offset: 0x00039F48
			// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000C80E File Offset: 0x0000AA0E
			public unsafe VisualElement _element_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr__element_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr__element_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003BD78 File Offset: 0x00039F78
			// (set) Token: 0x06001388 RID: 5000 RVA: 0x0000C82D File Offset: 0x0000AA2D
			public unsafe bool isScheduled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_isScheduled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_isScheduled)) = value;
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003BDA0 File Offset: 0x00039FA0
			// (set) Token: 0x0600138A RID: 5002 RVA: 0x0000C848 File Offset: 0x0000AA48
			public unsafe VisualElementPanelActivator m_Activator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_m_Activator);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementPanelActivator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.BaseVisualElementScheduledItem.NativeFieldInfoPtr_m_Activator), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000888 RID: 2184
			private static readonly IntPtr NativeFieldInfoPtr__element_k__BackingField;

			// Token: 0x04000889 RID: 2185
			private static readonly IntPtr NativeFieldInfoPtr_isScheduled;

			// Token: 0x0400088A RID: 2186
			private static readonly IntPtr NativeFieldInfoPtr_m_Activator;

			// Token: 0x0400088B RID: 2187
			private static readonly IntPtr NativeMethodInfoPtr_get_element_Public_Virtual_Final_New_get_VisualElement_0;

			// Token: 0x0400088C RID: 2188
			private static readonly IntPtr NativeMethodInfoPtr_set_element_Private_set_Void_VisualElement_0;

			// Token: 0x0400088D RID: 2189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_VisualElement_0;

			// Token: 0x0400088E RID: 2190
			private static readonly IntPtr NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_Void_0;

			// Token: 0x0400088F RID: 2191
			private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000890 RID: 2192
			private static readonly IntPtr NativeMethodInfoPtr_OnPanelActivate_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000891 RID: 2193
			private static readonly IntPtr NativeMethodInfoPtr_OnPanelDeactivate_Public_Virtual_Final_New_Void_0;

			// Token: 0x04000892 RID: 2194
			private static readonly IntPtr NativeMethodInfoPtr_CanBeActivated_Public_Virtual_Final_New_Boolean_0;
		}

		// Token: 0x020001FB RID: 507
		public class VisualElementScheduledItem<ActionType> : VisualElement.BaseVisualElementScheduledItem
		{
			// Token: 0x0600138B RID: 5003 RVA: 0x0003BDD0 File Offset: 0x00039FD0
			// Note: this type is marked as 'beforefieldinit'.
			static VisualElementScheduledItem()
			{
				Il2CppClassPointerStore<VisualElement.VisualElementScheduledItem<ActionType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "VisualElementScheduledItem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ActionType>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement.VisualElementScheduledItem<ActionType>>.NativeClassPtr);
				VisualElement.VisualElementScheduledItem<ActionType>.NativeFieldInfoPtr_updateEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.VisualElementScheduledItem<ActionType>>.NativeClassPtr, "updateEvent");
				VisualElement.VisualElementScheduledItem<ActionType>.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.VisualElementScheduledItem<ActionType>>.NativeClassPtr, 100663656);
			}

			// Token: 0x0600138C RID: 5004 RVA: 0x0003BE60 File Offset: 0x0003A060
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93167, RefRangeEnd = 93169, XrefRangeStart = 93166, XrefRangeEnd = 93167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VisualElementScheduledItem(VisualElement handler, ActionType upEvent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElement.VisualElementScheduledItem<ActionType>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(ActionType).IsValueType)
				{
					ActionType actionType = upEvent;
					intPtr = ((actionType is string) ? IL2CPP.ManagedStringToIl2Cpp(actionType as string) : IL2CPP.Il2CppObjectBaseToPtr(actionType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref upEvent;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VisualElement.VisualElementScheduledItem<ActionType>.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600138D RID: 5005 RVA: 0x0000C867 File Offset: 0x0000AA67
			public VisualElementScheduledItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x0600138E RID: 5006 RVA: 0x0003BEF4 File Offset: 0x0003A0F4
			// (set) Token: 0x0600138F RID: 5007 RVA: 0x0003BF1C File Offset: 0x0003A11C
			public unsafe ActionType updateEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.VisualElementScheduledItem<ActionType>.NativeFieldInfoPtr_updateEvent);
					return IL2CPP.PointerToValueGeneric<ActionType>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.VisualElementScheduledItem<ActionType>.NativeFieldInfoPtr_updateEvent);
					Type typeFromHandle = typeof(ActionType);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000893 RID: 2195
			private static readonly IntPtr NativeFieldInfoPtr_updateEvent;

			// Token: 0x04000894 RID: 2196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_ActionType_0;
		}

		// Token: 0x020001FC RID: 508
		public class SimpleScheduledItem : VisualElement.VisualElementScheduledItem<Action>
		{
			// Token: 0x06001390 RID: 5008 RVA: 0x0000C870 File Offset: 0x0000AA70
			// Note: this type is marked as 'beforefieldinit'.
			static SimpleScheduledItem()
			{
				Il2CppClassPointerStore<VisualElement.SimpleScheduledItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "SimpleScheduledItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement.SimpleScheduledItem>.NativeClassPtr);
				VisualElement.SimpleScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElement.SimpleScheduledItem>.NativeClassPtr, 100663657);
			}

			// Token: 0x06001391 RID: 5009 RVA: 0x0003BFC4 File Offset: 0x0003A1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93169, XrefRangeEnd = 93172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SimpleScheduledItem(VisualElement handler, Action updateEvent)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElement.SimpleScheduledItem>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElement.SimpleScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001392 RID: 5010 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
			public SimpleScheduledItem(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000895 RID: 2197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_Action_0;
		}

		// Token: 0x020001FD RID: 509
		public class TypeData : Object
		{
			// Token: 0x06001393 RID: 5011 RVA: 0x0003C024 File Offset: 0x0003A224
			// Note: this type is marked as 'beforefieldinit'.
			static TypeData()
			{
				Il2CppClassPointerStore<VisualElement.TypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElement>.NativeClassPtr, "TypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElement.TypeData>.NativeClassPtr);
				VisualElement.TypeData.NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.TypeData>.NativeClassPtr, "<type>k__BackingField");
				VisualElement.TypeData.NativeFieldInfoPtr_m_FullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.TypeData>.NativeClassPtr, "m_FullTypeName");
				VisualElement.TypeData.NativeFieldInfoPtr_m_TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElement.TypeData>.NativeClassPtr, "m_TypeName");
			}

			// Token: 0x06001394 RID: 5012 RVA: 0x0000C8AD File Offset: 0x0000AAAD
			public TypeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001395 RID: 5013 RVA: 0x0003C08C File Offset: 0x0003A28C
			// (set) Token: 0x06001396 RID: 5014 RVA: 0x0000C8B6 File Offset: 0x0000AAB6
			public unsafe Type _type_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr__type_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr__type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001397 RID: 5015 RVA: 0x0003C0BC File Offset: 0x0003A2BC
			// (set) Token: 0x06001398 RID: 5016 RVA: 0x0000C8D5 File Offset: 0x0000AAD5
			public unsafe string m_FullTypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr_m_FullTypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr_m_FullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001399 RID: 5017 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
			// (set) Token: 0x0600139A RID: 5018 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
			public unsafe string m_TypeName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr_m_TypeName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElement.TypeData.NativeFieldInfoPtr_m_TypeName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000896 RID: 2198
			private static readonly IntPtr NativeFieldInfoPtr__type_k__BackingField;

			// Token: 0x04000897 RID: 2199
			private static readonly IntPtr NativeFieldInfoPtr_m_FullTypeName;

			// Token: 0x04000898 RID: 2200
			private static readonly IntPtr NativeFieldInfoPtr_m_TypeName;
		}

		// Token: 0x020001FE RID: 510
		public class UxmlFactory : UxmlFactory<VisualElement, VisualElement.UxmlTraits>
		{
		}

		// Token: 0x020001FF RID: 511
		public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
		{
			// Token: 0x0200029F RID: 671
			public sealed class <get_uxmlChildElementsDescription>d__18
			{
			}
		}

		// Token: 0x02000200 RID: 512
		public enum MeasureMode
		{
			// Token: 0x0400089A RID: 2202
			Undefined,
			// Token: 0x0400089B RID: 2203
			Exactly,
			// Token: 0x0400089C RID: 2204
			AtMost
		}

		// Token: 0x02000201 RID: 513
		public class TimerStateScheduledItem : VisualElement.VisualElementScheduledItem<Action<TimerState>>
		{
		}

		// Token: 0x02000202 RID: 514
		public sealed class <>c__DisplayClass246_0
		{
		}

		// Token: 0x02000203 RID: 515
		public sealed class <>c__DisplayClass247_0
		{
		}

		// Token: 0x02000204 RID: 516
		public sealed class <>c__DisplayClass248_0
		{
		}

		// Token: 0x02000205 RID: 517
		public sealed class <>c__DisplayClass249_0
		{
		}

		// Token: 0x02000206 RID: 518
		public sealed class <>c__DisplayClass250_0
		{
		}

		// Token: 0x02000207 RID: 519
		public sealed class <>c__DisplayClass251_0
		{
		}

		// Token: 0x02000208 RID: 520
		public sealed class <>c__DisplayClass252_0
		{
		}

		// Token: 0x02000209 RID: 521
		public sealed class <>c__DisplayClass262_0
		{
		}

		// Token: 0x0200020A RID: 522
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
