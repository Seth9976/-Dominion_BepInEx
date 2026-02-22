using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001C RID: 28
	public class BaseVisualElementPanel : Object
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00010C04 File Offset: 0x0000EE04
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVisualElementPanel()
		{
			Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseVisualElementPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr);
			BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "panelDisposed");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_Scale");
			BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "yogaConfig");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_PixelsPerPoint");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_SortingPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_SortingPriority");
			BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<clearSettings>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<duringLayoutPhase>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<repaintData>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<cursorManager>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<contextualMenuManager>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "<disposed>k__BackingField");
			BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "m_TopElementUnderPointers");
			BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "standardShaderChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "standardWorldSpaceShaderChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "atlasChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "updateMaterial");
			BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "hierarchyChanged");
			BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, "beforeUpdate");
			BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663409);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663410);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663411);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663412);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663413);
			BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663414);
			BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663415);
			BaseVisualElementPanel.NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663416);
			BaseVisualElementPanel.NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663417);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scale_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663418);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663419);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663420);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663421);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663422);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663423);
			BaseVisualElementPanel.NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663424);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663425);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663426);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663427);
			BaseVisualElementPanel.NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663428);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663429);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663430);
			BaseVisualElementPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663431);
			BaseVisualElementPanel.NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663432);
			BaseVisualElementPanel.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663433);
			BaseVisualElementPanel.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663434);
			BaseVisualElementPanel.NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Vector2_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663435);
			BaseVisualElementPanel.NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663436);
			BaseVisualElementPanel.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663437);
			BaseVisualElementPanel.NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVisualElementPanel>.NativeClassPtr, 100663438);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00010FF4 File Offset: 0x0000F1F4
		public unsafe virtual EventInterests IMGUIEventInterests
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0001103C File Offset: 0x0000F23C
		public unsafe virtual ScriptableObject ownerObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00011088 File Offset: 0x0000F288
		public unsafe virtual int IMGUIContainersCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000110D0 File Offset: 0x0000F2D0
		public unsafe virtual FocusController focusController
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001111C File Offset: 0x0000F31C
		public unsafe virtual IMGUIContainer rootIMGUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMGUIContainer>(intPtr3) : null;
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00011168 File Offset: 0x0000F368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91900, XrefRangeEnd = 91904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0001119C File Offset: 0x0000F39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91904, XrefRangeEnd = 91916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000111E8 File Offset: 0x0000F3E8
		[CallerCount(0)]
		public unsafe virtual void Repaint(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00011238 File Offset: 0x0000F438
		[CallerCount(0)]
		public unsafe virtual void ValidateLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00011274 File Offset: 0x0000F474
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00011B6C File Offset: 0x0000FD6C
		public unsafe float scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88829, RefRangeEnd = 88830, XrefRangeStart = 88829, XrefRangeEnd = 88830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_scale_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !Mathf.Approximately(this.m_Scale, value);
				if (flag)
				{
					this.m_Scale = value;
					this.visualTree.IncrementVersion(VersionChangeType.Layout);
					this.yogaConfig.PointScaleFactor = this.scaledPixelsPerPoint;
					this.visualTree.IncrementVersion(VersionChangeType.StyleSheet);
				}
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00011BC4 File Offset: 0x0000FDC4
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000112B0 File Offset: 0x0000F4B0
		public unsafe float pixelsPerPoint
		{
			get
			{
				return this.m_PixelsPerPoint;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91916, XrefRangeEnd = 91920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000112F0 File Offset: 0x0000F4F0
		public unsafe float scaledPixelsPerPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001132C File Offset: 0x0000F52C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00011BDC File Offset: 0x0000FDDC
		public unsafe float sortingPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = !Mathf.Approximately(this.m_SortingPriority, value);
				if (flag)
				{
					this.m_SortingPriority = value;
					bool flag2 = this.contextType == ContextType.Player;
					if (flag2)
					{
						UIElementsRuntimeUtility.SetPanelOrderingDirty();
					}
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00011368 File Offset: 0x0000F568
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002CA3 File Offset: 0x00000EA3
		public unsafe bool duringLayoutPhase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._duringLayoutPhase_k__BackingField = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000113A4 File Offset: 0x0000F5A4
		public unsafe virtual uint version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000113EC File Offset: 0x0000F5EC
		[CallerCount(0)]
		public unsafe virtual void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ele);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeTypeFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00011448 File Offset: 0x0000F648
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002CAC File Offset: 0x00000EAC
		public unsafe virtual RepaintData repaintData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RepaintData>(intPtr3) : null;
			}
			set
			{
				this._repaintData_k__BackingField = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00011494 File Offset: 0x0000F694
		public unsafe virtual VisualElement visualTree
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000114E0 File Offset: 0x0000F6E0
		public unsafe virtual EventDispatcher dispatcher
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001152C File Offset: 0x0000F72C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 91925, RefRangeEnd = 91940, XrefRangeStart = 91920, XrefRangeEnd = 91925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0001157C File Offset: 0x0000F77C
		public unsafe virtual IScheduler scheduler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public unsafe virtual ContextType contextType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00011610 File Offset: 0x0000F810
		[CallerCount(0)]
		public unsafe virtual VisualElement Pick(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVisualElementPanel.NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00011668 File Offset: 0x0000F868
		// (set) Token: 0x06000167 RID: 359 RVA: 0x000116A4 File Offset: 0x0000F8A4
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000116E4 File Offset: 0x0000F8E4
		[CallerCount(0)]
		public unsafe VisualElement GetTopElementUnderPointer(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00011730 File Offset: 0x0000F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91940, XrefRangeEnd = 91941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElement RecomputeTopElementUnderPointer(Vector2 pointerPos, EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Vector2_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00011790 File Offset: 0x0000F990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91941, XrefRangeEnd = 91942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCachedElementUnderPointer(EventBase triggerEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000117D4 File Offset: 0x0000F9D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91944, RefRangeEnd = 91946, XrefRangeStart = 91942, XrefRangeEnd = 91944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CommitElementUnderPointers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00011808 File Offset: 0x0000FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91946, XrefRangeEnd = 91949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeBeforeUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVisualElementPanel.NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002A59 File Offset: 0x00000C59
		public BaseVisualElementPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001183C File Offset: 0x0000FA3C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002A62 File Offset: 0x00000C62
		public unsafe Action<BaseVisualElementPanel> panelDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<BaseVisualElementPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_panelDisposed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001186C File Offset: 0x0000FA6C
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002A81 File Offset: 0x00000C81
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00011894 File Offset: 0x0000FA94
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002A9C File Offset: 0x00000C9C
		public unsafe YogaConfig yogaConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_yogaConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000118C4 File Offset: 0x0000FAC4
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002ABB File Offset: 0x00000CBB
		public unsafe float m_PixelsPerPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_PixelsPerPoint)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000118EC File Offset: 0x0000FAEC
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public unsafe float m_SortingPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_SortingPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_SortingPriority)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00011914 File Offset: 0x0000FB14
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002AF1 File Offset: 0x00000CF1
		public unsafe PanelClearSettings _clearSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__clearSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001193C File Offset: 0x0000FB3C
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002B0C File Offset: 0x00000D0C
		public unsafe bool _duringLayoutPhase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__duringLayoutPhase_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00011964 File Offset: 0x0000FB64
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002B27 File Offset: 0x00000D27
		public unsafe RepaintData _repaintData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RepaintData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__repaintData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00011994 File Offset: 0x0000FB94
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002B46 File Offset: 0x00000D46
		public unsafe ICursorManager _cursorManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICursorManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__cursorManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000119C4 File Offset: 0x0000FBC4
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002B65 File Offset: 0x00000D65
		public unsafe ContextualMenuManager _contextualMenuManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualMenuManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__contextualMenuManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000119F4 File Offset: 0x0000FBF4
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00002B84 File Offset: 0x00000D84
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00011A1C File Offset: 0x0000FC1C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002B9F File Offset: 0x00000D9F
		public unsafe ElementUnderPointer m_TopElementUnderPointers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ElementUnderPointer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_m_TopElementUnderPointers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00011A4C File Offset: 0x0000FC4C
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00002BBE File Offset: 0x00000DBE
		public unsafe Action standardShaderChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardShaderChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00011A7C File Offset: 0x0000FC7C
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002BDD File Offset: 0x00000DDD
		public unsafe Action standardWorldSpaceShaderChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_standardWorldSpaceShaderChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00011AAC File Offset: 0x0000FCAC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002BFC File Offset: 0x00000DFC
		public unsafe Action atlasChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_atlasChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00011ADC File Offset: 0x0000FCDC
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002C1B File Offset: 0x00000E1B
		public unsafe Action<Material> updateMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_updateMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00011B0C File Offset: 0x0000FD0C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002C3A File Offset: 0x00000E3A
		public unsafe HierarchyEvent hierarchyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HierarchyEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_hierarchyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00011B3C File Offset: 0x0000FD3C
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002C59 File Offset: 0x00000E59
		public unsafe Action<IPanel> beforeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseVisualElementPanel.NativeFieldInfoPtr_beforeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002C78 File Offset: 0x00000E78
		public void add_panelDisposed(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002C85 File Offset: 0x00000E85
		public void remove_panelDisposed(Action<BaseVisualElementPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00011C1C File Offset: 0x0000FE1C
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00011C5C File Offset: 0x0000FE5C
		public PanelClearFlags clearFlags
		{
			get
			{
				PanelClearFlags panelClearFlags = PanelClearFlags.None;
				bool clearColor = this.clearSettings.clearColor;
				if (clearColor)
				{
					panelClearFlags |= PanelClearFlags.Color;
				}
				bool clearDepthStencil = this.clearSettings.clearDepthStencil;
				if (clearDepthStencil)
				{
					panelClearFlags |= PanelClearFlags.Depth;
				}
				return panelClearFlags;
			}
			set
			{
				PanelClearSettings clearSettings = this.clearSettings;
				clearSettings.clearColor = (value & PanelClearFlags.Color) == PanelClearFlags.Color;
				clearSettings.clearDepthStencil = (value & PanelClearFlags.Depth) == PanelClearFlags.Depth;
				this.clearSettings = clearSettings;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00002C92 File Offset: 0x00000E92
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002C9A File Offset: 0x00000E9A
		public PanelClearSettings clearSettings
		{
			get
			{
				return this._clearSettings_k__BackingField;
			}
			set
			{
				this._clearSettings_k__BackingField = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00011C94 File Offset: 0x0000FE94
		public bool isDirty
		{
			get
			{
				return this.version != this.repaintVersion;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002CB5 File Offset: 0x00000EB5
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002CBD File Offset: 0x00000EBD
		public virtual ICursorManager cursorManager
		{
			get
			{
				return this._cursorManager_k__BackingField;
			}
			set
			{
				this._cursorManager_k__BackingField = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002CC6 File Offset: 0x00000EC6
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002CCE File Offset: 0x00000ECE
		public ContextualMenuManager contextualMenuManager
		{
			get
			{
				return this._contextualMenuManager_k__BackingField;
			}
			set
			{
				this._contextualMenuManager_k__BackingField = value;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
		{
			this.m_TopElementUnderPointers.SetElementUnderPointer(newElementUnderPointer, pointerId, pointerPos);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public virtual Shader standardWorldSpaceShader
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002CEC File Offset: 0x00000EEC
		public void InvokeStandardShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002CF9 File Offset: 0x00000EF9
		public void InvokeStandardWorldSpaceShaderChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002D06 File Offset: 0x00000F06
		public void InvokeAtlasChanged()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002D13 File Offset: 0x00000F13
		public void add_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002D20 File Offset: 0x00000F20
		public void remove_updateMaterial(Action<Material> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002D2D File Offset: 0x00000F2D
		public void InvokeUpdateMaterial(Material mat)
		{
			Action<Material> updateMaterial = this.updateMaterial;
			if (updateMaterial != null)
			{
				updateMaterial.Invoke(mat);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002D43 File Offset: 0x00000F43
		public void add_hierarchyChanged(HierarchyEvent value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002D50 File Offset: 0x00000F50
		public void remove_hierarchyChanged(HierarchyEvent value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00011CCC File Offset: 0x0000FECC
		public void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			bool flag = this.hierarchyChanged != null;
			if (flag)
			{
				this.hierarchyChanged.Invoke(ve, changeType);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002D5D File Offset: 0x00000F5D
		public void add_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002D6A File Offset: 0x00000F6A
		public void remove_beforeUpdate(Action<IPanel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002D77 File Offset: 0x00000F77
		public void UpdateElementUnderPointers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002D84 File Offset: 0x00000F84
		public virtual void Update()
		{
			this.scheduler.UpdateScheduledEvents();
			this.ValidateLayout();
			this.UpdateAnimations();
			this.UpdateBindings();
		}

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr_panelDisposed;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_yogaConfig;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_m_PixelsPerPoint;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingPriority;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__clearSettings_k__BackingField;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr__duringLayoutPhase_k__BackingField;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr__repaintData_k__BackingField;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr__cursorManager_k__BackingField;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr__contextualMenuManager_k__BackingField;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_m_TopElementUnderPointers;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_standardShaderChanged;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_standardWorldSpaceShaderChanged;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_atlasChanged;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_updateMaterial;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyChanged;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_beforeUpdate;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIEventInterests_Public_Abstract_Virtual_New_get_EventInterests_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_ownerObject_Public_Abstract_Virtual_New_get_ScriptableObject_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_get_IMGUIContainersCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Public_Abstract_Virtual_New_get_FocusController_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_rootIMGUIContainer_Public_Abstract_Virtual_New_get_IMGUIContainer_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Repaint_Public_Abstract_Virtual_New_Void_Event_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLayout_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Internal_get_Single_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelsPerPoint_Internal_set_Void_Single_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_get_scaledPixelsPerPoint_Public_get_Single_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingPriority_Public_get_Single_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_duringLayoutPhase_Internal_get_Boolean_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_version_Internal_Abstract_Virtual_New_get_UInt32_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Internal_Abstract_Virtual_New_Void_VisualElement_VersionChangeType_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_get_repaintData_Internal_Virtual_New_get_RepaintData_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Public_Abstract_Virtual_New_get_VisualElement_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatcher_Public_Abstract_Virtual_New_get_EventDispatcher_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Internal_Void_EventBase_DispatchMode_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_scheduler_Internal_Abstract_Virtual_New_get_IScheduler_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_contextType_Public_Abstract_Virtual_New_get_ContextType_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Pick_Public_Abstract_Virtual_New_VisualElement_Vector2_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Internal_get_Boolean_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElementUnderPointer_Internal_VisualElement_Int32_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_RecomputeTopElementUnderPointer_Internal_VisualElement_Vector2_EventBase_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_ClearCachedElementUnderPointer_Internal_Void_EventBase_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_CommitElementUnderPointers_Internal_Void_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_InvokeBeforeUpdate_Internal_Void_0;
	}
}
