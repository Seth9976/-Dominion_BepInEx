using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004A RID: 74
	public class PanelEventHandler : UIBehaviour
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00028508 File Offset: 0x00026708
		// Note: this type is marked as 'beforefieldinit'.
		static PanelEventHandler()
		{
			Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UIElements", "PanelEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr);
			PanelEventHandler.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Panel");
			PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_PointerEvent");
			PanelEventHandler.NativeFieldInfoPtr_m_Selecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Selecting");
			PanelEventHandler.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "m_Event");
			PanelEventHandler.NativeFieldInfoPtr_s_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "s_Modifiers");
			PanelEventHandler.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664549);
			PanelEventHandler.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664550);
			PanelEventHandler.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664551);
			PanelEventHandler.NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664552);
			PanelEventHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664553);
			PanelEventHandler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664554);
			PanelEventHandler.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664555);
			PanelEventHandler.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664556);
			PanelEventHandler.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664557);
			PanelEventHandler.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664558);
			PanelEventHandler.NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664559);
			PanelEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664560);
			PanelEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664561);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664562);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664563);
			PanelEventHandler.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664564);
			PanelEventHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664565);
			PanelEventHandler.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664566);
			PanelEventHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664567);
			PanelEventHandler.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664568);
			PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664569);
			PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664570);
			PanelEventHandler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664571);
			PanelEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664572);
			PanelEventHandler.NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664573);
			PanelEventHandler.NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664574);
			PanelEventHandler.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664575);
			PanelEventHandler.NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664576);
			PanelEventHandler.NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_KeyCode_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664577);
			PanelEventHandler.NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_KeyCode_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664578);
			PanelEventHandler.NativeMethodInfoPtr_SendTextEvent_Private_Void_Event_Char_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664579);
			PanelEventHandler.NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664580);
			PanelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, 100664581);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00028830 File Offset: 0x00026A30
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00028870 File Offset: 0x00026A70
		public unsafe virtual IPanel panel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120537, XrefRangeEnd = 120541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000288B4 File Offset: 0x00026AB4
		public unsafe GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000288F4 File Offset: 0x00026AF4
		public unsafe EventSystem eventSystem
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 120550, RefRangeEnd = 120559, XrefRangeStart = 120541, XrefRangeEnd = 120550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00028934 File Offset: 0x00026B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120559, XrefRangeEnd = 120561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelEventHandler.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00028970 File Offset: 0x00026B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120561, XrefRangeEnd = 120563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelEventHandler.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000289AC File Offset: 0x00026BAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120592, RefRangeEnd = 120595, XrefRangeStart = 120563, XrefRangeEnd = 120592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000289E0 File Offset: 0x00026BE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120624, RefRangeEnd = 120627, XrefRangeStart = 120595, XrefRangeEnd = 120624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00028A14 File Offset: 0x00026C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120627, XrefRangeEnd = 120630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00028A48 File Offset: 0x00026C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120630, XrefRangeEnd = 120637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementFocus(FocusEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00028A8C File Offset: 0x00026C8C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementBlur(BlurEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00028AD0 File Offset: 0x00026CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120637, XrefRangeEnd = 120640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00028B14 File Offset: 0x00026D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120640, XrefRangeEnd = 120641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00028B58 File Offset: 0x00026D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120641, XrefRangeEnd = 120651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerMove(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00028B9C File Offset: 0x00026D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120651, XrefRangeEnd = 120661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00028BE0 File Offset: 0x00026DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120661, XrefRangeEnd = 120679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00028C24 File Offset: 0x00026E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120679, XrefRangeEnd = 120691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00028C68 File Offset: 0x00026E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120691, XrefRangeEnd = 120703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00028CAC File Offset: 0x00026EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120703, XrefRangeEnd = 120710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00028CF0 File Offset: 0x00026EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120710, XrefRangeEnd = 120718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnScroll(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00028D34 File Offset: 0x00026F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120718, XrefRangeEnd = 120720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, BaseEventData sourceEventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00028D88 File Offset: 0x00026F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120720, XrefRangeEnd = 120723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendEvent(EventBase e, Event sourceEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00028DDC File Offset: 0x00026FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120723, XrefRangeEnd = 120734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00028E10 File Offset: 0x00027010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120734, XrefRangeEnd = 120735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00028E44 File Offset: 0x00027044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120756, RefRangeEnd = 120758, XrefRangeStart = 120735, XrefRangeEnd = 120756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessImguiEvents(bool isSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isSelected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00028E84 File Offset: 0x00027084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120764, RefRangeEnd = 120765, XrefRangeStart = 120758, XrefRangeEnd = 120764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessKeyboardEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00028EC8 File Offset: 0x000270C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120765, XrefRangeEnd = 120769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTabEvent(Event e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00028F0C File Offset: 0x0002710C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120777, RefRangeEnd = 120779, XrefRangeStart = 120769, XrefRangeEnd = 120777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTabEvent(Event e, int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00028F5C File Offset: 0x0002715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120779, XrefRangeEnd = 120789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendKeyUpEvent(Event e, KeyCode keyCode, EventModifiers modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_KeyCode_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00028FBC File Offset: 0x000271BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120789, XrefRangeEnd = 120799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendKeyDownEvent(Event e, KeyCode keyCode, EventModifiers modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_KeyCode_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0002901C File Offset: 0x0002721C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120809, RefRangeEnd = 120810, XrefRangeStart = 120799, XrefRangeEnd = 120809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTextEvent(Event e, char c, EventModifiers modifiers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modifiers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_SendTextEvent_Private_Void_Event_Char_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002907C File Offset: 0x0002727C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120823, RefRangeEnd = 120827, XrefRangeStart = 120810, XrefRangeEnd = 120823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, bool isMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000290EC File Offset: 0x000272EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120827, XrefRangeEnd = 120836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelEventHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00004F4B File Offset: 0x0000314B
		public PanelEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00029128 File Offset: 0x00027328
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x00004F54 File Offset: 0x00003154
		public unsafe BaseRuntimePanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x00029158 File Offset: 0x00027358
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00004F73 File Offset: 0x00003173
		public unsafe PanelEventHandler.PointerEvent m_PointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelEventHandler.PointerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_PointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00029188 File Offset: 0x00027388
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x00004F92 File Offset: 0x00003192
		public unsafe bool m_Selecting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Selecting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Selecting)) = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000291B0 File Offset: 0x000273B0
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00004FAD File Offset: 0x000031AD
		public unsafe Event m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x000291E0 File Offset: 0x000273E0
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00004FCC File Offset: 0x000031CC
		public unsafe static EventModifiers s_Modifiers
		{
			get
			{
				EventModifiers eventModifiers;
				IL2CPP.il2cpp_field_static_get_value(PanelEventHandler.NativeFieldInfoPtr_s_Modifiers, (void*)(&eventModifiers));
				return eventModifiers;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelEventHandler.NativeFieldInfoPtr_s_Modifiers, (void*)(&value));
			}
		}

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerEvent;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr_m_Selecting;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_s_Modifiers;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_eventSystem_Private_get_EventSystem_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_OnElementFocus_Private_Void_FocusEvent_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_OnElementBlur_Private_Void_BlurEvent_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Final_New_Void_AxisEventData_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_OnScroll_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_BaseEventData_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Private_Void_EventBase_Event_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_ProcessImguiEvents_Private_Void_Boolean_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_ProcessKeyboardEvent_Private_Void_Event_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTabEvent_Private_Void_Event_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_SendTabEvent_Private_Void_Event_Int32_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_SendKeyUpEvent_Private_Void_Event_KeyCode_EventModifiers_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_SendKeyDownEvent_Private_Void_Event_KeyCode_EventModifiers_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_SendTextEvent_Private_Void_Event_Char_EventModifiers_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_ReadPointerData_Private_Boolean_PointerEvent_PointerEventData_Boolean_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000BF RID: 191
		public class PointerEvent : Object
		{
			// Token: 0x06000CD7 RID: 3287 RVA: 0x000374F0 File Offset: 0x000356F0
			// Note: this type is marked as 'beforefieldinit'.
			static PointerEvent()
			{
				Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PanelEventHandler>.NativeClassPtr, "PointerEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr);
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pointerId>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pointerType>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<isPrimary>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<button>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pressedButtons>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<position>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<localPosition>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<deltaPosition>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<deltaTime>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<clickCount>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<pressure>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<tangentialPressure>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<altitudeAngle>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<azimuthAngle>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<twist>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<radius>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<radiusVariance>k__BackingField");
				PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, "<modifiers>k__BackingField");
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665083);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665084);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665085);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665086);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665087);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665088);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665089);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665090);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665091);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665092);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665093);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665094);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665095);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665096);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665097);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665098);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665099);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665100);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665101);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665102);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665103);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665104);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665105);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665106);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665107);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665108);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665109);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665110);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665111);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665112);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665113);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665114);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665115);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665116);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665117);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665118);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665119);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665120);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665121);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665122);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665123);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665124);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665125);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665126);
				PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr, 100665127);
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00037A08 File Offset: 0x00035C08
			// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00037A44 File Offset: 0x00035C44
			public unsafe virtual int pointerId
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700043E RID: 1086
			// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00037A84 File Offset: 0x00035C84
			// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00037ABC File Offset: 0x00035CBC
			public unsafe virtual string pointerType
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700043F RID: 1087
			// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00037B00 File Offset: 0x00035D00
			// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00037B3C File Offset: 0x00035D3C
			public unsafe virtual bool isPrimary
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000440 RID: 1088
			// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00037B7C File Offset: 0x00035D7C
			// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00037BB8 File Offset: 0x00035DB8
			public unsafe virtual int button
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00037BF8 File Offset: 0x00035DF8
			// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00037C34 File Offset: 0x00035E34
			public unsafe virtual int pressedButtons
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00037C74 File Offset: 0x00035E74
			// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00037CB0 File Offset: 0x00035EB0
			public unsafe virtual Vector3 position
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00037CF0 File Offset: 0x00035EF0
			// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00037D2C File Offset: 0x00035F2C
			public unsafe virtual Vector3 localPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000444 RID: 1092
			// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00037D6C File Offset: 0x00035F6C
			// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00037DA8 File Offset: 0x00035FA8
			public unsafe virtual Vector3 deltaPosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000445 RID: 1093
			// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00037DE8 File Offset: 0x00035FE8
			// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00037E24 File Offset: 0x00036024
			public unsafe virtual float deltaTime
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 88942, RefRangeEnd = 88944, XrefRangeStart = 88942, XrefRangeEnd = 88944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000446 RID: 1094
			// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00037E64 File Offset: 0x00036064
			// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00037EA0 File Offset: 0x000360A0
			public unsafe virtual int clickCount
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000447 RID: 1095
			// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00037EE0 File Offset: 0x000360E0
			// (set) Token: 0x06000CED RID: 3309 RVA: 0x00037F1C File Offset: 0x0003611C
			public unsafe virtual float pressure
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 88948, RefRangeEnd = 88949, XrefRangeStart = 88948, XrefRangeEnd = 88949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000448 RID: 1096
			// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00037F5C File Offset: 0x0003615C
			// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00037F98 File Offset: 0x00036198
			public unsafe virtual float tangentialPressure
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000449 RID: 1097
			// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00037FD8 File Offset: 0x000361D8
			// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00038014 File Offset: 0x00036214
			public unsafe virtual float altitudeAngle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044A RID: 1098
			// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00038054 File Offset: 0x00036254
			// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00038090 File Offset: 0x00036290
			public unsafe virtual float azimuthAngle
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044B RID: 1099
			// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000380D0 File Offset: 0x000362D0
			// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x0003810C File Offset: 0x0003630C
			public unsafe virtual float twist
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044C RID: 1100
			// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0003814C File Offset: 0x0003634C
			// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00038188 File Offset: 0x00036388
			public unsafe virtual Vector2 radius
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044D RID: 1101
			// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x000381C8 File Offset: 0x000363C8
			// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00038204 File Offset: 0x00036404
			public unsafe virtual Vector2 radiusVariance
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044E RID: 1102
			// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00038244 File Offset: 0x00036444
			// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00038280 File Offset: 0x00036480
			public unsafe virtual EventModifiers modifiers
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700044F RID: 1103
			// (get) Token: 0x06000CFC RID: 3324 RVA: 0x000382C0 File Offset: 0x000364C0
			public unsafe virtual bool shiftKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000CFD RID: 3325 RVA: 0x000382FC File Offset: 0x000364FC
			public unsafe virtual bool ctrlKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00038338 File Offset: 0x00036538
			public unsafe virtual bool commandKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00038374 File Offset: 0x00036574
			public unsafe virtual bool altKey
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000383B0 File Offset: 0x000365B0
			public unsafe virtual bool actionKey
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120483, XrefRangeEnd = 120485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000D01 RID: 3329 RVA: 0x000383EC File Offset: 0x000365EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 120535, RefRangeEnd = 120536, XrefRangeStart = 120485, XrefRangeEnd = 120535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Read(PanelEventHandler self, PointerEventData eventData, bool isMove)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMove;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D02 RID: 3330 RVA: 0x00038450 File Offset: 0x00036650
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 120536, RefRangeEnd = 120537, XrefRangeStart = 120536, XrefRangeEnd = 120536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetPosition(Vector3 positionOverride, Vector3 deltaOverride)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref positionOverride;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaOverride;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x0003849C File Offset: 0x0003669C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PointerEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelEventHandler.PointerEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D04 RID: 3332 RVA: 0x000384D8 File Offset: 0x000366D8
			[CallerCount(0)]
			public unsafe static bool Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0(int i, int start, int count)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelEventHandler.PointerEvent.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x00006D77 File Offset: 0x00004F77
			public PointerEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00038534 File Offset: 0x00036734
			// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00006D80 File Offset: 0x00004F80
			public unsafe int _pointerId_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0003855C File Offset: 0x0003675C
			// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00006D9B File Offset: 0x00004F9B
			public unsafe string _pointerType_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pointerType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00038584 File Offset: 0x00036784
			// (set) Token: 0x06000D0B RID: 3339 RVA: 0x00006DBA File Offset: 0x00004FBA
			public unsafe bool _isPrimary_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__isPrimary_k__BackingField)) = value;
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000D0C RID: 3340 RVA: 0x000385AC File Offset: 0x000367AC
			// (set) Token: 0x06000D0D RID: 3341 RVA: 0x00006DD5 File Offset: 0x00004FD5
			public unsafe int _button_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__button_k__BackingField)) = value;
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000D0E RID: 3342 RVA: 0x000385D4 File Offset: 0x000367D4
			// (set) Token: 0x06000D0F RID: 3343 RVA: 0x00006DF0 File Offset: 0x00004FF0
			public unsafe int _pressedButtons_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000D10 RID: 3344 RVA: 0x000385FC File Offset: 0x000367FC
			// (set) Token: 0x06000D11 RID: 3345 RVA: 0x00006E0B File Offset: 0x0000500B
			public unsafe Vector3 _position_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__position_k__BackingField)) = value;
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000D12 RID: 3346 RVA: 0x00038624 File Offset: 0x00036824
			// (set) Token: 0x06000D13 RID: 3347 RVA: 0x00006E26 File Offset: 0x00005026
			public unsafe Vector3 _localPosition_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__localPosition_k__BackingField)) = value;
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0003864C File Offset: 0x0003684C
			// (set) Token: 0x06000D15 RID: 3349 RVA: 0x00006E41 File Offset: 0x00005041
			public unsafe Vector3 _deltaPosition_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaPosition_k__BackingField)) = value;
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00038674 File Offset: 0x00036874
			// (set) Token: 0x06000D17 RID: 3351 RVA: 0x00006E5C File Offset: 0x0000505C
			public unsafe float _deltaTime_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__deltaTime_k__BackingField)) = value;
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0003869C File Offset: 0x0003689C
			// (set) Token: 0x06000D19 RID: 3353 RVA: 0x00006E77 File Offset: 0x00005077
			public unsafe int _clickCount_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
				}
			}

			// Token: 0x17000435 RID: 1077
			// (get) Token: 0x06000D1A RID: 3354 RVA: 0x000386C4 File Offset: 0x000368C4
			// (set) Token: 0x06000D1B RID: 3355 RVA: 0x00006E92 File Offset: 0x00005092
			public unsafe float _pressure_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
				}
			}

			// Token: 0x17000436 RID: 1078
			// (get) Token: 0x06000D1C RID: 3356 RVA: 0x000386EC File Offset: 0x000368EC
			// (set) Token: 0x06000D1D RID: 3357 RVA: 0x00006EAD File Offset: 0x000050AD
			public unsafe float _tangentialPressure_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
				}
			}

			// Token: 0x17000437 RID: 1079
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00038714 File Offset: 0x00036914
			// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00006EC8 File Offset: 0x000050C8
			public unsafe float _altitudeAngle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__altitudeAngle_k__BackingField)) = value;
				}
			}

			// Token: 0x17000438 RID: 1080
			// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0003873C File Offset: 0x0003693C
			// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00006EE3 File Offset: 0x000050E3
			public unsafe float _azimuthAngle_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__azimuthAngle_k__BackingField)) = value;
				}
			}

			// Token: 0x17000439 RID: 1081
			// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00038764 File Offset: 0x00036964
			// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00006EFE File Offset: 0x000050FE
			public unsafe float _twist_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__twist_k__BackingField)) = value;
				}
			}

			// Token: 0x1700043A RID: 1082
			// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003878C File Offset: 0x0003698C
			// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00006F19 File Offset: 0x00005119
			public unsafe Vector2 _radius_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radius_k__BackingField)) = value;
				}
			}

			// Token: 0x1700043B RID: 1083
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x000387B4 File Offset: 0x000369B4
			// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00006F34 File Offset: 0x00005134
			public unsafe Vector2 _radiusVariance_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
				}
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000D28 RID: 3368 RVA: 0x000387DC File Offset: 0x000369DC
			// (set) Token: 0x06000D29 RID: 3369 RVA: 0x00006F4F File Offset: 0x0000514F
			public unsafe EventModifiers _modifiers_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelEventHandler.PointerEvent.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
				}
			}

			// Token: 0x04000A01 RID: 2561
			private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

			// Token: 0x04000A02 RID: 2562
			private static readonly IntPtr NativeFieldInfoPtr__pointerType_k__BackingField;

			// Token: 0x04000A03 RID: 2563
			private static readonly IntPtr NativeFieldInfoPtr__isPrimary_k__BackingField;

			// Token: 0x04000A04 RID: 2564
			private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

			// Token: 0x04000A05 RID: 2565
			private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

			// Token: 0x04000A06 RID: 2566
			private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

			// Token: 0x04000A07 RID: 2567
			private static readonly IntPtr NativeFieldInfoPtr__localPosition_k__BackingField;

			// Token: 0x04000A08 RID: 2568
			private static readonly IntPtr NativeFieldInfoPtr__deltaPosition_k__BackingField;

			// Token: 0x04000A09 RID: 2569
			private static readonly IntPtr NativeFieldInfoPtr__deltaTime_k__BackingField;

			// Token: 0x04000A0A RID: 2570
			private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

			// Token: 0x04000A0B RID: 2571
			private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

			// Token: 0x04000A0C RID: 2572
			private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

			// Token: 0x04000A0D RID: 2573
			private static readonly IntPtr NativeFieldInfoPtr__altitudeAngle_k__BackingField;

			// Token: 0x04000A0E RID: 2574
			private static readonly IntPtr NativeFieldInfoPtr__azimuthAngle_k__BackingField;

			// Token: 0x04000A0F RID: 2575
			private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

			// Token: 0x04000A10 RID: 2576
			private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

			// Token: 0x04000A11 RID: 2577
			private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

			// Token: 0x04000A12 RID: 2578
			private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

			// Token: 0x04000A13 RID: 2579
			private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A14 RID: 2580
			private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Private_set_Void_Int32_0;

			// Token: 0x04000A15 RID: 2581
			private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0;

			// Token: 0x04000A16 RID: 2582
			private static readonly IntPtr NativeMethodInfoPtr_set_pointerType_Private_set_Void_String_0;

			// Token: 0x04000A17 RID: 2583
			private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A18 RID: 2584
			private static readonly IntPtr NativeMethodInfoPtr_set_isPrimary_Private_set_Void_Boolean_0;

			// Token: 0x04000A19 RID: 2585
			private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A1A RID: 2586
			private static readonly IntPtr NativeMethodInfoPtr_set_button_Private_set_Void_Int32_0;

			// Token: 0x04000A1B RID: 2587
			private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A1C RID: 2588
			private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Private_set_Void_Int32_0;

			// Token: 0x04000A1D RID: 2589
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A1E RID: 2590
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Private_set_Void_Vector3_0;

			// Token: 0x04000A1F RID: 2591
			private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A20 RID: 2592
			private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Private_set_Void_Vector3_0;

			// Token: 0x04000A21 RID: 2593
			private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04000A22 RID: 2594
			private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosition_Private_set_Void_Vector3_0;

			// Token: 0x04000A23 RID: 2595
			private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A24 RID: 2596
			private static readonly IntPtr NativeMethodInfoPtr_set_deltaTime_Private_set_Void_Single_0;

			// Token: 0x04000A25 RID: 2597
			private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000A26 RID: 2598
			private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Private_set_Void_Int32_0;

			// Token: 0x04000A27 RID: 2599
			private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A28 RID: 2600
			private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Private_set_Void_Single_0;

			// Token: 0x04000A29 RID: 2601
			private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A2A RID: 2602
			private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Private_set_Void_Single_0;

			// Token: 0x04000A2B RID: 2603
			private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A2C RID: 2604
			private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Private_set_Void_Single_0;

			// Token: 0x04000A2D RID: 2605
			private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A2E RID: 2606
			private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Private_set_Void_Single_0;

			// Token: 0x04000A2F RID: 2607
			private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0;

			// Token: 0x04000A30 RID: 2608
			private static readonly IntPtr NativeMethodInfoPtr_set_twist_Private_set_Void_Single_0;

			// Token: 0x04000A31 RID: 2609
			private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04000A32 RID: 2610
			private static readonly IntPtr NativeMethodInfoPtr_set_radius_Private_set_Void_Vector2_0;

			// Token: 0x04000A33 RID: 2611
			private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0;

			// Token: 0x04000A34 RID: 2612
			private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Private_set_Void_Vector2_0;

			// Token: 0x04000A35 RID: 2613
			private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

			// Token: 0x04000A36 RID: 2614
			private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Private_set_Void_EventModifiers_0;

			// Token: 0x04000A37 RID: 2615
			private static readonly IntPtr NativeMethodInfoPtr_get_shiftKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A38 RID: 2616
			private static readonly IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A39 RID: 2617
			private static readonly IntPtr NativeMethodInfoPtr_get_commandKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A3A RID: 2618
			private static readonly IntPtr NativeMethodInfoPtr_get_altKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A3B RID: 2619
			private static readonly IntPtr NativeMethodInfoPtr_get_actionKey_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000A3C RID: 2620
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void_PanelEventHandler_PointerEventData_Boolean_0;

			// Token: 0x04000A3D RID: 2621
			private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_Vector3_0;

			// Token: 0x04000A3E RID: 2622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A3F RID: 2623
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_Int32_Int32_PDM_0;
		}
	}
}
