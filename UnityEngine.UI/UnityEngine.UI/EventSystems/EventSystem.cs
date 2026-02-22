using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000064 RID: 100
	public class EventSystem : UIBehaviour
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x0002BD60 File Offset: 0x00029F60
		// Note: this type is marked as 'beforefieldinit'.
		static EventSystem()
		{
			Il2CppClassPointerStore<EventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "EventSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem>.NativeClassPtr);
			EventSystem.NativeFieldInfoPtr_m_SystemInputModules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SystemInputModules");
			EventSystem.NativeFieldInfoPtr_m_CurrentInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentInputModule");
			EventSystem.NativeFieldInfoPtr_m_EventSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_EventSystems");
			EventSystem.NativeFieldInfoPtr_m_FirstSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_FirstSelected");
			EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_sendNavigationEvents");
			EventSystem.NativeFieldInfoPtr_m_DragThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DragThreshold");
			EventSystem.NativeFieldInfoPtr_m_CurrentSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_CurrentSelected");
			EventSystem.NativeFieldInfoPtr_m_HasFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_HasFocus");
			EventSystem.NativeFieldInfoPtr_m_SelectionGuard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_SelectionGuard");
			EventSystem.NativeFieldInfoPtr_m_DummyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "m_DummyData");
			EventSystem.NativeFieldInfoPtr_s_RaycastComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "s_RaycastComparer");
			EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "s_UIToolkitOverride");
			EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664688);
			EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664689);
			EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664690);
			EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664691);
			EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664692);
			EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664693);
			EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664694);
			EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664695);
			EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664696);
			EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664697);
			EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664698);
			EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664699);
			EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664700);
			EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664701);
			EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664702);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664703);
			EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664704);
			EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664705);
			EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664706);
			EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664707);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664708);
			EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664709);
			EventSystem.NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664710);
			EventSystem.NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664711);
			EventSystem.NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664712);
			EventSystem.NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664713);
			EventSystem.NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664714);
			EventSystem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664715);
			EventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664716);
			EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664717);
			EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664718);
			EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664719);
			EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664720);
			EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664721);
			EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664722);
			EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, 100664723);
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x0002C150 File Offset: 0x0002A350
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0002C184 File Offset: 0x0002A384
		public unsafe static EventSystem current
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 121079, RefRangeEnd = 121114, XrefRangeStart = 121070, XrefRangeEnd = 121079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121114, XrefRangeEnd = 121131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x0002C1BC File Offset: 0x0002A3BC
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0002C1F8 File Offset: 0x0002A3F8
		public unsafe bool sendNavigationEvents
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x0002C238 File Offset: 0x0002A438
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0002C274 File Offset: 0x0002A474
		public unsafe int pixelDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0002C2B4 File Offset: 0x0002A4B4
		public unsafe BaseInputModule currentInputModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002C2F4 File Offset: 0x0002A4F4
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0002C334 File Offset: 0x0002A534
		public unsafe GameObject firstSelectedGameObject
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0002C378 File Offset: 0x0002A578
		public unsafe GameObject currentSelectedGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		public unsafe GameObject lastSelectedGameObject
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		public unsafe bool isFocused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002C434 File Offset: 0x0002A634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121131, XrefRangeEnd = 121138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002C470 File Offset: 0x0002A670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121153, RefRangeEnd = 121155, XrefRangeStart = 121138, XrefRangeEnd = 121153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_UpdateModules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		public unsafe bool alreadySelecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002C4E0 File Offset: 0x0002A6E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 121180, RefRangeEnd = 121188, XrefRangeStart = 121155, XrefRangeEnd = 121180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pointer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x0002C534 File Offset: 0x0002A734
		public unsafe BaseEventData baseEventDataCache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121188, XrefRangeEnd = 121192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002C574 File Offset: 0x0002A774
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 121197, RefRangeEnd = 121206, XrefRangeStart = 121192, XrefRangeEnd = 121197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedGameObject(GameObject selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121206, XrefRangeEnd = 121241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0002C618 File Offset: 0x0002A818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121267, RefRangeEnd = 121270, XrefRangeStart = 121241, XrefRangeEnd = 121267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastResults);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0002C66C File Offset: 0x0002A86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121270, XrefRangeEnd = 121274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002C6A8 File Offset: 0x0002A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121274, XrefRangeEnd = 121278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		public unsafe bool isUIToolkitActiveEventSystem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 121286, RefRangeEnd = 121288, XrefRangeStart = 121278, XrefRangeEnd = 121286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0002C730 File Offset: 0x0002A930
		public unsafe bool sendUIToolkitEvents
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121288, XrefRangeEnd = 121292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0002C76C File Offset: 0x0002A96C
		public unsafe bool createUIToolkitPanelGameObjectsOnStart
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121292, XrefRangeEnd = 121296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121296, XrefRangeEnd = 121321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeEventSystem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendEvents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createPanelGameObjectsOnStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002C7FC File Offset: 0x0002A9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121321, XrefRangeEnd = 121359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002C840 File Offset: 0x0002AA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121359, XrefRangeEnd = 121435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0002C87C File Offset: 0x0002AA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121435, XrefRangeEnd = 121448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0002C8B8 File Offset: 0x0002AAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121448, XrefRangeEnd = 121465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121465, XrefRangeEnd = 121482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002C930 File Offset: 0x0002AB30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 121491, RefRangeEnd = 121493, XrefRangeStart = 121482, XrefRangeEnd = 121491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TickModules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_TickModules_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002C964 File Offset: 0x0002AB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121493, XrefRangeEnd = 121494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnApplicationFocus(bool hasFocus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasFocus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002C9B0 File Offset: 0x0002ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121494, XrefRangeEnd = 121513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002C9EC File Offset: 0x0002ABEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121513, XrefRangeEnd = 121523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeEventModule(BaseInputModule module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002CA30 File Offset: 0x0002AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121523, XrefRangeEnd = 121543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000057FB File Offset: 0x000039FB
		public EventSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0002CA74 File Offset: 0x0002AC74
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00005804 File Offset: 0x00003A04
		public unsafe List<BaseInputModule> m_SystemInputModules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInputModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SystemInputModules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00005823 File Offset: 0x00003A23
		public unsafe BaseInputModule m_CurrentInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0002CAD4 File Offset: 0x0002ACD4
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00005842 File Offset: 0x00003A42
		public unsafe static List<EventSystem> m_EventSystems
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventSystem>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_m_EventSystems, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0002CAFC File Offset: 0x0002ACFC
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x00005854 File Offset: 0x00003A54
		public unsafe GameObject m_FirstSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_FirstSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002CB2C File Offset: 0x0002AD2C
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x00005873 File Offset: 0x00003A73
		public unsafe bool m_sendNavigationEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_sendNavigationEvents)) = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002CB54 File Offset: 0x0002AD54
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0000588E File Offset: 0x00003A8E
		public unsafe int m_DragThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DragThreshold)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x000058A9 File Offset: 0x00003AA9
		public unsafe GameObject m_CurrentSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_CurrentSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x000058C8 File Offset: 0x00003AC8
		public unsafe bool m_HasFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_HasFocus)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x0002CBD4 File Offset: 0x0002ADD4
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x000058E3 File Offset: 0x00003AE3
		public unsafe bool m_SelectionGuard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_SelectionGuard)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002CBFC File Offset: 0x0002ADFC
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x000058FE File Offset: 0x00003AFE
		public unsafe BaseEventData m_DummyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.NativeFieldInfoPtr_m_DummyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002CC2C File Offset: 0x0002AE2C
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000591D File Offset: 0x00003B1D
		public unsafe static Comparison<RaycastResult> s_RaycastComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_s_RaycastComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0002CC54 File Offset: 0x0002AE54
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000592F File Offset: 0x00003B2F
		public unsafe static EventSystem.UIToolkitOverrideConfig s_UIToolkitOverride
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride, intPtr);
				return new EventSystem.UIToolkitOverrideConfig(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventSystem.NativeFieldInfoPtr_s_UIToolkitOverride, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_m_SystemInputModules;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentInputModule;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystems;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeFieldInfoPtr_m_FirstSelected;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_m_sendNavigationEvents;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_m_DragThreshold;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSelected;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_m_HasFocus;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectionGuard;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_m_DummyData;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_s_RaycastComparer;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeFieldInfoPtr_s_UIToolkitOverride;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_EventSystem_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_set_current_Public_Static_set_Void_EventSystem_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_get_sendNavigationEvents_Public_get_Boolean_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_set_sendNavigationEvents_Public_set_Void_Boolean_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelDragThreshold_Public_get_Int32_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelDragThreshold_Public_set_Void_Int32_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_get_firstSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_set_firstSelectedGameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_get_currentSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_get_lastSelectedGameObject_Public_get_GameObject_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_get_isFocused_Public_get_Boolean_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModules_Public_Void_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_get_alreadySelecting_Public_get_Boolean_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_BaseEventData_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_get_baseEventDataCache_Private_get_BaseEventData_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedGameObject_Public_Void_GameObject_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_RaycastComparer_Private_Static_Int32_RaycastResult_RaycastResult_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Boolean_Int32_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_get_isUIToolkitActiveEventSystem_Private_get_Boolean_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_get_sendUIToolkitEvents_Private_get_Boolean_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_get_createUIToolkitPanelGameObjectsOnStart_Private_get_Boolean_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_SetUITookitEventSystemOverride_Public_Static_Void_EventSystem_Boolean_Boolean_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIToolkitPanelGameObject_Private_Void_BaseRuntimePanel_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_TickModules_Private_Void_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationFocus_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_ChangeEventModule_Private_Void_BaseInputModule_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000C3 RID: 195
		public sealed class UIToolkitOverrideConfig : ValueType
		{
			// Token: 0x06000D2C RID: 3372 RVA: 0x00038858 File Offset: 0x00036A58
			// Note: this type is marked as 'beforefieldinit'.
			static UIToolkitOverrideConfig()
			{
				Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "UIToolkitOverrideConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr);
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "activeEventSystem");
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "sendEvents");
				EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr, "createPanelGameObjectsOnStart");
			}

			// Token: 0x06000D2D RID: 3373 RVA: 0x00006F7C File Offset: 0x0000517C
			public UIToolkitOverrideConfig(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00006F85 File Offset: 0x00005185
			public UIToolkitOverrideConfig()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem.UIToolkitOverrideConfig>.NativeClassPtr))
			{
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000388C0 File Offset: 0x00036AC0
			// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00006F97 File Offset: 0x00005197
			public unsafe EventSystem activeEventSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_activeEventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000388F0 File Offset: 0x00036AF0
			// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00006FB6 File Offset: 0x000051B6
			public unsafe bool sendEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_sendEvents)) = value;
				}
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06000D33 RID: 3379 RVA: 0x00038918 File Offset: 0x00036B18
			// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00006FD1 File Offset: 0x000051D1
			public unsafe bool createPanelGameObjectsOnStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.UIToolkitOverrideConfig.NativeFieldInfoPtr_createPanelGameObjectsOnStart)) = value;
				}
			}

			// Token: 0x04000A4D RID: 2637
			private static readonly IntPtr NativeFieldInfoPtr_activeEventSystem;

			// Token: 0x04000A4E RID: 2638
			private static readonly IntPtr NativeFieldInfoPtr_sendEvents;

			// Token: 0x04000A4F RID: 2639
			private static readonly IntPtr NativeFieldInfoPtr_createPanelGameObjectsOnStart;
		}

		// Token: 0x020000C4 RID: 196
		[ObfuscatedName("UnityEngine.EventSystems.EventSystem+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Object
		{
			// Token: 0x06000D35 RID: 3381 RVA: 0x00038940 File Offset: 0x00036B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventSystem>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr);
				EventSystem.__c__DisplayClass52_0.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr, "go");
				EventSystem.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr, 100665128);
				EventSystem.__c__DisplayClass52_0.NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr, 100665129);
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x000389A8 File Offset: 0x00036BA8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSystem.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x000389E4 File Offset: 0x00036BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121066, XrefRangeEnd = 121070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUIToolkitPanelGameObject_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSystem.__c__DisplayClass52_0.NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x00006FEC File Offset: 0x000051EC
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00038A18 File Offset: 0x00036C18
			// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00006FF5 File Offset: 0x000051F5
			public unsafe GameObject go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.__c__DisplayClass52_0.NativeFieldInfoPtr_go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSystem.__c__DisplayClass52_0.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A50 RID: 2640
			private static readonly IntPtr NativeFieldInfoPtr_go;

			// Token: 0x04000A51 RID: 2641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A52 RID: 2642
			private static readonly IntPtr NativeMethodInfoPtr__CreateUIToolkitPanelGameObject_b__0_Internal_Void_0;
		}
	}
}
