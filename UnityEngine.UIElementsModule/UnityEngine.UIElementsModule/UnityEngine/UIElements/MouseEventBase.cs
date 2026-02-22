using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000078 RID: 120
	public class MouseEventBase<T> : EventBase<T> where T : MouseEventBase<T>, new()
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00021D6C File Offset: 0x0001FF6C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseEventBase()
		{
			Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "MouseEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr);
			MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<mousePosition>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<localMousePosition>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<mouseDelta>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<clickCount>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<button>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<pressedButtons>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField");
			MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField");
			MouseEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663910);
			MouseEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663911);
			MouseEventBase<T>.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663912);
			MouseEventBase<T>.NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663913);
			MouseEventBase<T>.NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663914);
			MouseEventBase<T>.NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663915);
			MouseEventBase<T>.NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663916);
			MouseEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663917);
			MouseEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663918);
			MouseEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663919);
			MouseEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663920);
			MouseEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663921);
			MouseEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663922);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663923);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663924);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663925);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663926);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663927);
			MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663928);
			MouseEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663929);
			MouseEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663930);
			MouseEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663931);
			MouseEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663932);
			MouseEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663933);
			MouseEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663934);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663935);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663936);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663937);
			MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663938);
			MouseEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr, 100663939);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000220F8 File Offset: 0x000202F8
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00022134 File Offset: 0x00020334
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00022174 File Offset: 0x00020374
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x000221B0 File Offset: 0x000203B0
		public unsafe virtual Vector2 mousePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000050AD File Offset: 0x000032AD
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x000221F0 File Offset: 0x000203F0
		public unsafe Vector2 localMousePosition
		{
			get
			{
				return this._localMousePosition_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00022230 File Offset: 0x00020430
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x0002226C File Offset: 0x0002046C
		public unsafe virtual Vector2 mouseDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x000222AC File Offset: 0x000204AC
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000222E8 File Offset: 0x000204E8
		public unsafe virtual int clickCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20877, RefRangeEnd = 20878, XrefRangeStart = 20877, XrefRangeEnd = 20878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00022328 File Offset: 0x00020528
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00022364 File Offset: 0x00020564
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000223A4 File Offset: 0x000205A4
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x000223E0 File Offset: 0x000205E0
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00022420 File Offset: 0x00020620
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0002245C File Offset: 0x0002065C
		public unsafe virtual bool UnityEngine.UIElements.IMouseEventInternal.triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002249C File Offset: 0x0002069C
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x000224D8 File Offset: 0x000206D8
		public unsafe virtual bool UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00022518 File Offset: 0x00020718
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00022558 File Offset: 0x00020758
		public unsafe virtual IPointerEvent UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002259C File Offset: 0x0002079C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x000225D8 File Offset: 0x000207D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95091, XrefRangeEnd = 95102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002260C File Offset: 0x0002080C
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00022658 File Offset: 0x00020858
		public unsafe override IEventHandler currentTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95102, XrefRangeEnd = 95104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95104, XrefRangeEnd = 95108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000226A8 File Offset: 0x000208A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95108, XrefRangeEnd = 95120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000226F8 File Offset: 0x000208F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95146, RefRangeEnd = 95148, XrefRangeStart = 95120, XrefRangeEnd = 95146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MouseEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00022748 File Offset: 0x00020948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95199, RefRangeEnd = 95202, XrefRangeStart = 95148, XrefRangeEnd = 95199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00022788 File Offset: 0x00020988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95225, RefRangeEnd = 95227, XrefRangeStart = 95202, XrefRangeEnd = 95225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recomputeTopElementUnderMouse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000227E4 File Offset: 0x000209E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95227, XrefRangeEnd = 95285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IMouseEvent triggerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00022824 File Offset: 0x00020A24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 95368, RefRangeEnd = 95372, XrefRangeStart = 95285, XrefRangeEnd = 95368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent pointerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00022864 File Offset: 0x00020A64
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 95377, RefRangeEnd = 95388, XrefRangeStart = 95372, XrefRangeEnd = 95377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00004F92 File Offset: 0x00003192
		public MouseEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x000228A0 File Offset: 0x00020AA0
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004F9B File Offset: 0x0000319B
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000228C8 File Offset: 0x00020AC8
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004FB6 File Offset: 0x000031B6
		public unsafe Vector2 _mousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000228F0 File Offset: 0x00020AF0
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00004FD1 File Offset: 0x000031D1
		public unsafe Vector2 _localMousePosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__localMousePosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00022918 File Offset: 0x00020B18
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00004FEC File Offset: 0x000031EC
		public unsafe Vector2 _mouseDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__mouseDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00022940 File Offset: 0x00020B40
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00005007 File Offset: 0x00003207
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00022968 File Offset: 0x00020B68
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00005022 File Offset: 0x00003222
		public unsafe int _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00022990 File Offset: 0x00020B90
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x0000503D File Offset: 0x0000323D
		public unsafe int _pressedButtons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000229B8 File Offset: 0x00020BB8
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00005058 File Offset: 0x00003258
		public unsafe bool _UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField)) = value;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x000229E0 File Offset: 0x00020BE0
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00005073 File Offset: 0x00003273
		public unsafe bool _UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00022A08 File Offset: 0x00020C08
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x0000508E File Offset: 0x0000328E
		public unsafe IPointerEvent _UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPointerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MouseEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00022A38 File Offset: 0x00020C38
		public bool shiftKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) > EventModifiers.None;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00022A58 File Offset: 0x00020C58
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00022A78 File Offset: 0x00020C78
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00022A98 File Offset: 0x00020C98
		public bool altKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) > EventModifiers.None;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00022AB8 File Offset: 0x00020CB8
		public bool actionKey
		{
			get
			{
				bool flag = Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer;
				bool flag2;
				if (flag)
				{
					flag2 = this.commandKey;
				}
				else
				{
					flag2 = this.ctrlKey;
				}
				return flag2;
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00022AF4 File Offset: 0x00020CF4
		public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, [Optional] EventModifiers modifiers)
		{
			return MouseEventBase<T>.GetPooled(position, button, clickCount, delta, modifiers, false);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00022B14 File Offset: 0x00020D14
		public static T GetPooled(Vector2 position, int button, int clickCount, Vector2 delta, EventModifiers modifiers, bool fromOS)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.modifiers = modifiers;
			pooled.mousePosition = position;
			pooled.localMousePosition = position;
			pooled.mouseDelta = delta;
			pooled.button = button;
			pooled.pressedButtons = PointerDeviceState.GetPressedButtons(PointerId.mousePointerId);
			pooled.clickCount = clickCount;
			pooled.triggeredByOS = fromOS;
			pooled.recomputeTopElementUnderMouse = true;
			return pooled;
		}

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeFieldInfoPtr__mousePosition_k__BackingField;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr__localMousePosition_k__BackingField;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr__mouseDelta_k__BackingField;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_triggeredByOS_k__BackingField;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_recomputeTopElementUnderMouse_k__BackingField;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IMouseEventInternal_sourcePointerEvent_k__BackingField;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_set_mousePosition_Protected_set_Void_Vector2_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_set_localMousePosition_Internal_set_Void_Vector2_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_get_mouseDelta_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_set_mouseDelta_Protected_set_Void_Vector2_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_recomputeTopElementUnderMouse_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_recomputeTopElementUnderMouse_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_get_sourcePointerEvent_Private_Virtual_Final_New_get_IPointerEvent_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IMouseEventInternal_set_sourcePointerEvent_Private_Virtual_Final_New_set_Void_IPointerEvent_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_IMouseEvent_Vector2_Boolean_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IMouseEvent_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Protected_Static_T_IPointerEvent_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
