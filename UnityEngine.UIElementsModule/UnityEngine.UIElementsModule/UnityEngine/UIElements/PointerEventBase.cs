using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000095 RID: 149
	public class PointerEventBase<T> : EventBase<T> where T : PointerEventBase<T>, new()
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x000257F0 File Offset: 0x000239F0
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventBase()
		{
			Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr);
			PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pointerType>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<isPrimary>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<button>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pressedButtons>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<position>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<localPosition>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<deltaPosition>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<deltaTime>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<clickCount>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<pressure>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<tangentialPressure>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__altitudeAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<altitudeAngle>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__azimuthAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<azimuthAngle>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<twist>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<radius>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<radiusVariance>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<modifiers>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField");
			PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, "<UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField");
			PointerEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664045);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664046);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664047);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664048);
			PointerEventBase<T>.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664049);
			PointerEventBase<T>.NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664050);
			PointerEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664051);
			PointerEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664052);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664053);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664054);
			PointerEventBase<T>.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664055);
			PointerEventBase<T>.NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664056);
			PointerEventBase<T>.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664057);
			PointerEventBase<T>.NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664058);
			PointerEventBase<T>.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664059);
			PointerEventBase<T>.NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664060);
			PointerEventBase<T>.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664061);
			PointerEventBase<T>.NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664062);
			PointerEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664063);
			PointerEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664064);
			PointerEventBase<T>.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664065);
			PointerEventBase<T>.NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664066);
			PointerEventBase<T>.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664067);
			PointerEventBase<T>.NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664068);
			PointerEventBase<T>.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664069);
			PointerEventBase<T>.NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664070);
			PointerEventBase<T>.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664071);
			PointerEventBase<T>.NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664072);
			PointerEventBase<T>.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664073);
			PointerEventBase<T>.NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664074);
			PointerEventBase<T>.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664075);
			PointerEventBase<T>.NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664076);
			PointerEventBase<T>.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664077);
			PointerEventBase<T>.NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664078);
			PointerEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664079);
			PointerEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664080);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664081);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664082);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664083);
			PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664084);
			PointerEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664085);
			PointerEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664086);
			PointerEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664087);
			PointerEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664088);
			PointerEventBase<T>.NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664089);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664090);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664091);
			PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664092);
			PointerEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664093);
			PointerEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664094);
			PointerEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr, 100664095);
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00025DE8 File Offset: 0x00023FE8
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00025E24 File Offset: 0x00024024
		public unsafe virtual int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00025E64 File Offset: 0x00024064
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00025E9C File Offset: 0x0002409C
		public unsafe virtual string pointerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00025EE0 File Offset: 0x000240E0
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00025F1C File Offset: 0x0002411C
		public unsafe virtual bool isPrimary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00025F5C File Offset: 0x0002415C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00025F98 File Offset: 0x00024198
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00025FD8 File Offset: 0x000241D8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00026014 File Offset: 0x00024214
		public unsafe virtual int pressedButtons
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20876, RefRangeEnd = 20877, XrefRangeStart = 20876, XrefRangeEnd = 20877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00026054 File Offset: 0x00024254
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00026090 File Offset: 0x00024290
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x000260D0 File Offset: 0x000242D0
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0002610C File Offset: 0x0002430C
		public unsafe virtual Vector3 localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0002614C File Offset: 0x0002434C
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00026188 File Offset: 0x00024388
		public unsafe virtual Vector3 deltaPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x000261C8 File Offset: 0x000243C8
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00026204 File Offset: 0x00024404
		public unsafe virtual float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00026244 File Offset: 0x00024444
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00026280 File Offset: 0x00024480
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000262C0 File Offset: 0x000244C0
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000262FC File Offset: 0x000244FC
		public unsafe virtual float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0002633C File Offset: 0x0002453C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00026378 File Offset: 0x00024578
		public unsafe virtual float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000263B8 File Offset: 0x000245B8
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x000263F4 File Offset: 0x000245F4
		public unsafe virtual float altitudeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x00026434 File Offset: 0x00024634
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00026470 File Offset: 0x00024670
		public unsafe virtual float azimuthAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000264B0 File Offset: 0x000246B0
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000264EC File Offset: 0x000246EC
		public unsafe virtual float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x0002652C File Offset: 0x0002472C
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00026568 File Offset: 0x00024768
		public unsafe virtual Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000265A8 File Offset: 0x000247A8
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x000265E4 File Offset: 0x000247E4
		public unsafe virtual Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x00026624 File Offset: 0x00024824
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00026660 File Offset: 0x00024860
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000266A0 File Offset: 0x000248A0
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x000266DC File Offset: 0x000248DC
		public unsafe virtual bool UnityEngine.UIElements.IPointerEventInternal.triggeredByOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x0002671C File Offset: 0x0002491C
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x00026758 File Offset: 0x00024958
		public unsafe virtual bool UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00026798 File Offset: 0x00024998
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000267D4 File Offset: 0x000249D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95890, XrefRangeEnd = 95906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00026808 File Offset: 0x00024A08
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00026854 File Offset: 0x00024A54
		public unsafe override IEventHandler currentTarget
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEventHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95906, XrefRangeEnd = 95910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000268A4 File Offset: 0x00024AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95910, XrefRangeEnd = 95911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMouse(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000268E8 File Offset: 0x00024AE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96080, RefRangeEnd = 96084, XrefRangeStart = 95911, XrefRangeEnd = 96080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00026928 File Offset: 0x00024B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96114, RefRangeEnd = 96116, XrefRangeStart = 96084, XrefRangeEnd = 96114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00026984 File Offset: 0x00024B84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 96225, RefRangeEnd = 96230, XrefRangeStart = 96116, XrefRangeEnd = 96225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(IPointerEvent triggerEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(triggerEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000269C4 File Offset: 0x00024BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96230, XrefRangeEnd = 96238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PreDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00026A14 File Offset: 0x00024C14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96255, RefRangeEnd = 96259, XrefRangeStart = 96238, XrefRangeEnd = 96255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDispatch(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventBase<T>.NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00026A64 File Offset: 0x00024C64
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 96264, RefRangeEnd = 96274, XrefRangeStart = 96259, XrefRangeEnd = 96264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00005526 File Offset: 0x00003726
		public PointerEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00026AA0 File Offset: 0x00024CA0
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0000552F File Offset: 0x0000372F
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00026AC8 File Offset: 0x00024CC8
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x0000554A File Offset: 0x0000374A
		public unsafe string _pointerType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pointerType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00026AF0 File Offset: 0x00024CF0
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00005569 File Offset: 0x00003769
		public unsafe bool _isPrimary_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__isPrimary_k__BackingField)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00026B18 File Offset: 0x00024D18
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00005584 File Offset: 0x00003784
		public unsafe int _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00026B40 File Offset: 0x00024D40
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000559F File Offset: 0x0000379F
		public unsafe int _pressedButtons_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressedButtons_k__BackingField)) = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00026B68 File Offset: 0x00024D68
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x000055BA File Offset: 0x000037BA
		public unsafe Vector3 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00026B90 File Offset: 0x00024D90
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x000055D5 File Offset: 0x000037D5
		public unsafe Vector3 _localPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__localPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00026BB8 File Offset: 0x00024DB8
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x000055F0 File Offset: 0x000037F0
		public unsafe Vector3 _deltaPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00026BE0 File Offset: 0x00024DE0
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0000560B File Offset: 0x0000380B
		public unsafe float _deltaTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__deltaTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00026C08 File Offset: 0x00024E08
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00005626 File Offset: 0x00003826
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00026C30 File Offset: 0x00024E30
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00005641 File Offset: 0x00003841
		public unsafe float _pressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00026C58 File Offset: 0x00024E58
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0000565C File Offset: 0x0000385C
		public unsafe float _tangentialPressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00026C80 File Offset: 0x00024E80
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00005677 File Offset: 0x00003877
		public unsafe float _altitudeAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__altitudeAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__altitudeAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00026CA8 File Offset: 0x00024EA8
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00005692 File Offset: 0x00003892
		public unsafe float _azimuthAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__azimuthAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__azimuthAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00026CD0 File Offset: 0x00024ED0
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000056AD File Offset: 0x000038AD
		public unsafe float _twist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__twist_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00026CF8 File Offset: 0x00024EF8
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000056C8 File Offset: 0x000038C8
		public unsafe Vector2 _radius_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radius_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00026D20 File Offset: 0x00024F20
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000056E3 File Offset: 0x000038E3
		public unsafe Vector2 _radiusVariance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00026D48 File Offset: 0x00024F48
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000056FE File Offset: 0x000038FE
		public unsafe EventModifiers _modifiers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__modifiers_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00026D70 File Offset: 0x00024F70
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005719 File Offset: 0x00003919
		public unsafe bool _UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00026D98 File Offset: 0x00024F98
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00005734 File Offset: 0x00003934
		public unsafe bool _UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventBase<T>.NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField)) = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00026DC0 File Offset: 0x00024FC0
		public bool shiftKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) > EventModifiers.None;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00026DE0 File Offset: 0x00024FE0
		public bool ctrlKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) > EventModifiers.None;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00026E00 File Offset: 0x00025000
		public bool commandKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) > EventModifiers.None;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00026E20 File Offset: 0x00025020
		public bool altKey
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) > EventModifiers.None;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00026E40 File Offset: 0x00025040
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

		// Token: 0x06000833 RID: 2099 RVA: 0x00026E7C File Offset: 0x0002507C
		public static T GetPooled(Touch touch, [Optional] EventModifiers modifiers)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.pointerId = touch.fingerId + PointerId.touchPointerIdBase;
			pooled.pointerType = PointerType.touch;
			bool flag = false;
			for (int i = PointerId.touchPointerIdBase; i < PointerId.touchPointerIdBase + PointerId.touchPointerCount; i++)
			{
				bool flag2 = i != pooled.pointerId && PointerDeviceState.GetPressedButtons(i) != 0;
				if (flag2)
				{
					flag = true;
					break;
				}
			}
			pooled.isPrimary = !flag;
			bool flag3 = touch.phase == TouchPhase.Began;
			if (flag3)
			{
				PointerDeviceState.PressButton(pooled.pointerId, 0);
				pooled.button = 0;
			}
			else
			{
				bool flag4 = touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled;
				if (flag4)
				{
					PointerDeviceState.ReleaseButton(pooled.pointerId, 0);
					pooled.button = 0;
				}
				else
				{
					pooled.button = -1;
				}
			}
			pooled.pressedButtons = PointerDeviceState.GetPressedButtons(pooled.pointerId);
			pooled.position = touch.position;
			pooled.localPosition = touch.position;
			pooled.deltaPosition = touch.deltaPosition;
			pooled.deltaTime = touch.deltaTime;
			pooled.clickCount = touch.tapCount;
			pooled.pressure = ((Mathf.Abs(touch.maximumPossiblePressure) > Mathf.Epsilon) ? (touch.pressure / touch.maximumPossiblePressure) : 1f);
			pooled.tangentialPressure = 0f;
			pooled.altitudeAngle = touch.altitudeAngle;
			pooled.azimuthAngle = touch.azimuthAngle;
			pooled.twist = 0f;
			pooled.radius = new Vector2(touch.radius, touch.radius);
			pooled.radiusVariance = new Vector2(touch.radiusVariance, touch.radiusVariance);
			pooled.modifiers = modifiers;
			pooled.triggeredByOS = true;
			return pooled;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000270FC File Offset: 0x000252FC
		public static T GetPooled(IMouseEvent triggerEvent)
		{
			T pooled = EventBase<T>.GetPooled();
			bool flag = triggerEvent != null;
			if (flag)
			{
				pooled.pointerId = PointerId.mousePointerId;
				pooled.pointerType = PointerType.mouse;
				pooled.isPrimary = true;
				pooled.button = triggerEvent.button;
				pooled.pressedButtons = triggerEvent.pressedButtons;
				pooled.position = triggerEvent.mousePosition;
				pooled.localPosition = triggerEvent.mousePosition;
				pooled.deltaPosition = triggerEvent.mouseDelta;
				pooled.deltaTime = 0f;
				pooled.clickCount = triggerEvent.clickCount;
				pooled.pressure = ((triggerEvent.pressedButtons == 0) ? 0f : 0.5f);
				pooled.tangentialPressure = 0f;
				pooled.altitudeAngle = 0f;
				pooled.azimuthAngle = 0f;
				pooled.twist = 0f;
				pooled.radius = default(Vector2);
				pooled.radiusVariance = default(Vector2);
				pooled.modifiers = triggerEvent.modifiers;
				IMouseEventInternal mouseEventInternal = triggerEvent.TryCast<IMouseEventInternal>();
				bool flag2 = mouseEventInternal != null;
				if (flag2)
				{
					pooled.triggeredByOS = mouseEventInternal.triggeredByOS;
				}
			}
			return pooled;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000272A4 File Offset: 0x000254A4
		public new static T GetPooled(EventBase e)
		{
			IPointerEvent pointerEvent = e.TryCast<IPointerEvent>();
			bool flag = pointerEvent != null;
			T t;
			if (flag)
			{
				t = PointerEventBase<T>.GetPooled(pointerEvent);
			}
			else
			{
				IMouseEvent mouseEvent = e.TryCast<IMouseEvent>();
				bool flag2 = mouseEvent != null;
				if (flag2)
				{
					t = PointerEventBase<T>.GetPooled(mouseEvent);
				}
				else
				{
					t = EventBase<T>.GetPooled(e);
				}
			}
			return t;
		}

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr__pointerType_k__BackingField;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr__isPrimary_k__BackingField;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr__pressedButtons_k__BackingField;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr__localPosition_k__BackingField;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr__deltaPosition_k__BackingField;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr__deltaTime_k__BackingField;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr__altitudeAngle_k__BackingField;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr__azimuthAngle_k__BackingField;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr__modifiers_k__BackingField;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_triggeredByOS_k__BackingField;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_UIElements_IPointerEventInternal_recomputeTopElementUnderPointer_k__BackingField;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Protected_set_Void_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerType_Protected_set_Void_String_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_set_isPrimary_Protected_set_Void_Boolean_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Protected_set_Void_Int32_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedButtons_Protected_set_Void_Int32_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Protected_set_Void_Vector3_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Virtual_Final_New_get_Vector3_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_set_deltaTime_Protected_set_Void_Single_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Protected_set_Void_Int32_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Protected_set_Void_Single_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Protected_set_Void_Single_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Protected_set_Void_Single_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Protected_set_Void_Single_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_set_twist_Protected_set_Void_Single_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_set_radius_Protected_set_Void_Vector2_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Virtual_Final_New_get_Vector2_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Protected_set_Void_Vector2_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Virtual_Final_New_get_EventModifiers_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_set_modifiers_Protected_set_Void_EventModifiers_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_triggeredByOS_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_triggeredByOS_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_get_recomputeTopElementUnderPointer_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UIElements_IPointerEventInternal_set_recomputeTopElementUnderPointer_Private_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTarget_Public_Virtual_get_IEventHandler_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTarget_Internal_Virtual_set_Void_IEventHandler_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_IsMouse_Private_Static_Boolean_Event_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_IPointerEvent_Vector2_Int32_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_IPointerEvent_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_PreDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_PostDispatch_FamOrAssem_Virtual_Void_IPanel_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
