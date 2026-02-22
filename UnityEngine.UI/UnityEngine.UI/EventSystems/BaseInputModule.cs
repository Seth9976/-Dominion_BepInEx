using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000069 RID: 105
	public class BaseInputModule : UIBehaviour
	{
		// Token: 0x06000A54 RID: 2644 RVA: 0x0002EF80 File Offset: 0x0002D180
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInputModule()
		{
			Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseInputModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr);
			BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_RaycastResultCache");
			BaseInputModule.NativeFieldInfoPtr_m_AxisEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_AxisEventData");
			BaseInputModule.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_EventSystem");
			BaseInputModule.NativeFieldInfoPtr_m_BaseEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_BaseEventData");
			BaseInputModule.NativeFieldInfoPtr_m_InputOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_InputOverride");
			BaseInputModule.NativeFieldInfoPtr_m_DefaultInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, "m_DefaultInput");
			BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664810);
			BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664811);
			BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664812);
			BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664813);
			BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664814);
			BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664815);
			BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664816);
			BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664817);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664818);
			BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664819);
			BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664820);
			BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664821);
			BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664822);
			BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664823);
			BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664824);
			BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664825);
			BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664826);
			BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664827);
			BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664828);
			BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664829);
			BaseInputModule.NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664830);
			BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr, 100664831);
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002F1E0 File Offset: 0x0002D3E0
		public unsafe BaseInput input
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 122127, RefRangeEnd = 122169, XrefRangeStart = 122098, XrefRangeEnd = 122127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_input_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002F220 File Offset: 0x0002D420
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x0002F260 File Offset: 0x0002D460
		public unsafe BaseInput inputOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
		public unsafe EventSystem eventSystem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr3) : null;
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002F2E4 File Offset: 0x0002D4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122169, XrefRangeEnd = 122175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002F320 File Offset: 0x0002D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122175, XrefRangeEnd = 122178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002F35C File Offset: 0x0002D55C
		[CallerCount(0)]
		public unsafe virtual void Process()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002F398 File Offset: 0x0002D598
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122185, RefRangeEnd = 122187, XrefRangeStart = 122178, XrefRangeEnd = 122185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(candidates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122187, XrefRangeEnd = 122188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002F420 File Offset: 0x0002D620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122191, RefRangeEnd = 122193, XrefRangeStart = 122188, XrefRangeEnd = 122191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002F47C File Offset: 0x0002D67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122193, XrefRangeEnd = 122216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002F4D4 File Offset: 0x0002D6D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 122261, RefRangeEnd = 122269, XrefRangeStart = 122216, XrefRangeEnd = 122261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPointerData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEnterTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002F528 File Offset: 0x0002D728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122269, XrefRangeEnd = 122275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveDeadZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr3) : null;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002F59C File Offset: 0x0002D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122275, XrefRangeEnd = 122279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BaseEventData GetBaseEventData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr3) : null;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPointerOverGameObject(int pointerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002F63C File Offset: 0x0002D83C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122280, RefRangeEnd = 122282, XrefRangeStart = 122279, XrefRangeEnd = 122280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002F684 File Offset: 0x0002D884
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeactivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002F6C0 File Offset: 0x0002D8C0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002F6FC File Offset: 0x0002D8FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002F738 File Offset: 0x0002D938
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsModuleSupported()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002F780 File Offset: 0x0002D980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122282, XrefRangeEnd = 122286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourcePointerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInputModule.NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122293, RefRangeEnd = 122294, XrefRangeStart = 122286, XrefRangeEnd = 122293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInputModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInputModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInputModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00005AD6 File Offset: 0x00003CD6
		public BaseInputModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002F814 File Offset: 0x0002DA14
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00005ADF File Offset: 0x00003CDF
		public unsafe List<RaycastResult> m_RaycastResultCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_RaycastResultCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002F844 File Offset: 0x0002DA44
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00005AFE File Offset: 0x00003CFE
		public unsafe AxisEventData m_AxisEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxisEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_AxisEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002F874 File Offset: 0x0002DA74
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00005B1D File Offset: 0x00003D1D
		public unsafe EventSystem m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002F8A4 File Offset: 0x0002DAA4
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00005B3C File Offset: 0x00003D3C
		public unsafe BaseEventData m_BaseEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_BaseEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002F8D4 File Offset: 0x0002DAD4
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00005B5B File Offset: 0x00003D5B
		public unsafe BaseInput m_InputOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_InputOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0002F904 File Offset: 0x0002DB04
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005B7A File Offset: 0x00003D7A
		public unsafe BaseInput m_DefaultInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseInputModule.NativeFieldInfoPtr_m_DefaultInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResultCache;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_m_AxisEventData;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseEventData;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_m_InputOverride;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultInput;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_get_input_Public_get_BaseInput_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_inputOverride_Public_get_BaseInput_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_set_inputOverride_Public_set_Void_BaseInput_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_eventSystem_Protected_get_EventSystem_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstRaycast_Protected_Static_RaycastResult_List_1_RaycastResult_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Protected_Static_MoveDirection_Single_Single_Single_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_FindCommonRoot_Protected_Static_GameObject_GameObject_GameObject_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_HandlePointerExitAndEnter_Protected_Void_PointerEventData_GameObject_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisEventData_Protected_Virtual_New_AxisEventData_Single_Single_Single_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventData_Protected_Virtual_New_BaseEventData_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverGameObject_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_ShouldActivateModule_Public_Virtual_New_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_UpdateModule_Public_Virtual_New_Void_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_IsModuleSupported_Public_Virtual_New_Boolean_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_ConvertUIToolkitPointerId_Public_Virtual_New_Int32_PointerEventData_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
