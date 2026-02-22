using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006B RID: 107
	public class StandaloneInputModule : PointerInputModule
	{
		// Token: 0x06000A96 RID: 2710 RVA: 0x00030108 File Offset: 0x0002E308
		// Note: this type is marked as 'beforefieldinit'.
		static StandaloneInputModule()
		{
			Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "StandaloneInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr);
			StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_PrevActionTime");
			StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_LastMoveVector");
			StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_ConsecutiveMoveCount");
			StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_LastMousePosition");
			StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_MousePosition");
			StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_CurrentFocusedGameObject");
			StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_InputPointerEvent");
			StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_HorizontalAxis");
			StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_VerticalAxis");
			StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_SubmitButton");
			StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_CancelButton");
			StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_InputActionsPerSecond");
			StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_RepeatDelay");
			StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, "m_ForceModuleActive");
			StandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664848);
			StandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664849);
			StandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664850);
			StandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664851);
			StandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664852);
			StandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664853);
			StandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664854);
			StandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664855);
			StandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664856);
			StandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664857);
			StandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664858);
			StandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664859);
			StandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664860);
			StandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664861);
			StandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664862);
			StandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664863);
			StandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664864);
			StandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664865);
			StandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664866);
			StandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664867);
			StandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664868);
			StandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664869);
			StandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664870);
			StandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664871);
			StandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664872);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664873);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664874);
			StandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664875);
			StandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664876);
			StandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664877);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664878);
			StandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664879);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664880);
			StandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664881);
			StandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664882);
			StandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr, 100664883);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00030520 File Offset: 0x0002E720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122553, RefRangeEnd = 122554, XrefRangeStart = 122544, XrefRangeEnd = 122553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandaloneInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandaloneInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0003055C File Offset: 0x0002E75C
		public unsafe StandaloneInputModule.InputMode inputMode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00030598 File Offset: 0x0002E798
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x000305D4 File Offset: 0x0002E7D4
		public unsafe bool allowActivationOnMobileDevice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00030614 File Offset: 0x0002E814
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00030650 File Offset: 0x0002E850
		public unsafe bool forceModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00030690 File Offset: 0x0002E890
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x000306CC File Offset: 0x0002E8CC
		public unsafe float inputActionsPerSecond
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0003070C File Offset: 0x0002E90C
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00030748 File Offset: 0x0002E948
		public unsafe float repeatDelay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00030788 File Offset: 0x0002E988
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x000307C0 File Offset: 0x0002E9C0
		public unsafe string horizontalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00030804 File Offset: 0x0002EA04
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0003083C File Offset: 0x0002EA3C
		public unsafe string verticalAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00030880 File Offset: 0x0002EA80
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x000308B8 File Offset: 0x0002EAB8
		public unsafe string submitButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_submitButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x000308FC File Offset: 0x0002EAFC
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x00030934 File Offset: 0x0002EB34
		public unsafe string cancelButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_get_cancelButton_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00030978 File Offset: 0x0002EB78
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldIgnoreEventsOnNoFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000309B4 File Offset: 0x0002EBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122554, XrefRangeEnd = 122556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000309F0 File Offset: 0x0002EBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122604, RefRangeEnd = 122605, XrefRangeStart = 122556, XrefRangeEnd = 122604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentOverGo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00030A44 File Offset: 0x0002EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122605, XrefRangeEnd = 122615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122615, XrefRangeEnd = 122623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122623, XrefRangeEnd = 122625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00030B04 File Offset: 0x0002ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122625, XrefRangeEnd = 122646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00030B40 File Offset: 0x0002ED40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122750, RefRangeEnd = 122751, XrefRangeStart = 122646, XrefRangeEnd = 122750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ProcessTouchEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00030B7C File Offset: 0x0002ED7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122751, XrefRangeEnd = 122846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref released;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00030BDC File Offset: 0x0002EDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122873, RefRangeEnd = 122874, XrefRangeStart = 122846, XrefRangeEnd = 122873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendSubmitEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00030C18 File Offset: 0x0002EE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122874, XrefRangeEnd = 122881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRawMoveVector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00030C54 File Offset: 0x0002EE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122893, RefRangeEnd = 122894, XrefRangeStart = 122881, XrefRangeEnd = 122893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendMoveEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00030C90 File Offset: 0x0002EE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122894, XrefRangeEnd = 122895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00030CC4 File Offset: 0x0002EEC4
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ForceAutoSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandaloneInputModule.NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00030D0C File Offset: 0x0002EF0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122918, RefRangeEnd = 122920, XrefRangeStart = 122895, XrefRangeEnd = 122918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMouseEvent(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00030D4C File Offset: 0x0002EF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122920, XrefRangeEnd = 122935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SendUpdateEventToSelectedObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00030D88 File Offset: 0x0002EF88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 122977, RefRangeEnd = 122980, XrefRangeStart = 122935, XrefRangeEnd = 122977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00030DCC File Offset: 0x0002EFCC
		[CallerCount(0)]
		public unsafe GameObject GetCurrentFocusedGameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandaloneInputModule.NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00005C18 File Offset: 0x00003E18
		public StandaloneInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00030E0C File Offset: 0x0002F00C
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00005C21 File Offset: 0x00003E21
		public unsafe float m_PrevActionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_PrevActionTime)) = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x00030E34 File Offset: 0x0002F034
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x00005C3C File Offset: 0x00003E3C
		public unsafe Vector2 m_LastMoveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMoveVector)) = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x00030E5C File Offset: 0x0002F05C
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00005C57 File Offset: 0x00003E57
		public unsafe int m_ConsecutiveMoveCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ConsecutiveMoveCount)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x00030E84 File Offset: 0x0002F084
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00005C72 File Offset: 0x00003E72
		public unsafe Vector2 m_LastMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_LastMousePosition)) = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x00030EAC File Offset: 0x0002F0AC
		// (set) Token: 0x06000AC5 RID: 2757 RVA: 0x00005C8D File Offset: 0x00003E8D
		public unsafe Vector2 m_MousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_MousePosition)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public unsafe GameObject m_CurrentFocusedGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CurrentFocusedGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00030F04 File Offset: 0x0002F104
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00005CC7 File Offset: 0x00003EC7
		public unsafe PointerEventData m_InputPointerEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputPointerEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x00030F34 File Offset: 0x0002F134
		// (set) Token: 0x06000ACB RID: 2763 RVA: 0x00005CE6 File Offset: 0x00003EE6
		public unsafe string m_HorizontalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_HorizontalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x00030F5C File Offset: 0x0002F15C
		// (set) Token: 0x06000ACD RID: 2765 RVA: 0x00005D05 File Offset: 0x00003F05
		public unsafe string m_VerticalAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_VerticalAxis), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00030F84 File Offset: 0x0002F184
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x00005D24 File Offset: 0x00003F24
		public unsafe string m_SubmitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_SubmitButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00030FAC File Offset: 0x0002F1AC
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00005D43 File Offset: 0x00003F43
		public unsafe string m_CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_CancelButton), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00030FD4 File Offset: 0x0002F1D4
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00005D62 File Offset: 0x00003F62
		public unsafe float m_InputActionsPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_InputActionsPerSecond)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00030FFC File Offset: 0x0002F1FC
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00005D7D File Offset: 0x00003F7D
		public unsafe float m_RepeatDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_RepeatDelay)) = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x00031024 File Offset: 0x0002F224
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x00005D98 File Offset: 0x00003F98
		public unsafe bool m_ForceModuleActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandaloneInputModule.NativeFieldInfoPtr_m_ForceModuleActive)) = value;
			}
		}

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevActionTime;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMoveVector;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeFieldInfoPtr_m_ConsecutiveMoveCount;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMousePosition;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeFieldInfoPtr_m_MousePosition;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFocusedGameObject;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_m_InputPointerEvent;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAxis;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalAxis;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeFieldInfoPtr_m_SubmitButton;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeFieldInfoPtr_m_CancelButton;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeFieldInfoPtr_m_InputActionsPerSecond;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeFieldInfoPtr_m_RepeatDelay;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_m_ForceModuleActive;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_get_inputMode_Public_get_InputMode_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_get_allowActivationOnMobileDevice_Public_get_Boolean_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_set_allowActivationOnMobileDevice_Public_set_Void_Boolean_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_get_forceModuleActive_Public_get_Boolean_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_set_forceModuleActive_Public_set_Void_Boolean_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_get_inputActionsPerSecond_Public_get_Single_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_set_inputActionsPerSecond_Public_set_Void_Single_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_get_repeatDelay_Public_get_Single_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_set_repeatDelay_Public_set_Void_Single_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAxis_Public_get_String_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalAxis_Public_set_Void_String_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalAxis_Public_get_String_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalAxis_Public_set_Void_String_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_get_submitButton_Public_get_String_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_set_submitButton_Public_set_Void_String_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_get_cancelButton_Public_get_String_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_set_cancelButton_Public_set_Void_String_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnoreEventsOnNoFocus_Private_Boolean_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_Void_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseMouse_Private_Void_PointerEventData_GameObject_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_Boolean_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_Void_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchEvents_Private_Boolean_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTouchPress_Protected_Void_PointerEventData_Boolean_Boolean_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_SendSubmitEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_GetRawMoveVector_Private_Vector2_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_SendMoveEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_ForceAutoSelect_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMouseEvent_Protected_Void_Int32_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_SendUpdateEventToSelectedObject_Protected_Boolean_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMousePress_Protected_Void_MouseButtonEventData_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentFocusedGameObject_Protected_GameObject_0;

		// Token: 0x020000D2 RID: 210
		public enum InputMode
		{
			// Token: 0x04000A75 RID: 2677
			Mouse,
			// Token: 0x04000A76 RID: 2678
			Buttons
		}
	}
}
