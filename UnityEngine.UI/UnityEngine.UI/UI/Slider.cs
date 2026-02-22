using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000036 RID: 54
	public class Slider : Selectable
	{
		// Token: 0x060006D5 RID: 1749 RVA: 0x00021790 File Offset: 0x0001F990
		// Note: this type is marked as 'beforefieldinit'.
		static Slider()
		{
			Il2CppClassPointerStore<Slider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Slider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slider>.NativeClassPtr);
			Slider.NativeFieldInfoPtr_m_FillRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_FillRect");
			Slider.NativeFieldInfoPtr_m_HandleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_HandleRect");
			Slider.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_Direction");
			Slider.NativeFieldInfoPtr_m_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_MinValue");
			Slider.NativeFieldInfoPtr_m_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_MaxValue");
			Slider.NativeFieldInfoPtr_m_WholeNumbers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_WholeNumbers");
			Slider.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_Value");
			Slider.NativeFieldInfoPtr_m_OnValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_OnValueChanged");
			Slider.NativeFieldInfoPtr_m_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_FillImage");
			Slider.NativeFieldInfoPtr_m_FillTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_FillTransform");
			Slider.NativeFieldInfoPtr_m_FillContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_FillContainerRect");
			Slider.NativeFieldInfoPtr_m_HandleTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_HandleTransform");
			Slider.NativeFieldInfoPtr_m_HandleContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_HandleContainerRect");
			Slider.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_Offset");
			Slider.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_Tracker");
			Slider.NativeFieldInfoPtr_m_DelayedUpdateVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slider>.NativeClassPtr, "m_DelayedUpdateVisuals");
			Slider.NativeMethodInfoPtr_get_fillRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664299);
			Slider.NativeMethodInfoPtr_set_fillRect_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664300);
			Slider.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664301);
			Slider.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664302);
			Slider.NativeMethodInfoPtr_get_direction_Public_get_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664303);
			Slider.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664304);
			Slider.NativeMethodInfoPtr_get_minValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664305);
			Slider.NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664306);
			Slider.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664307);
			Slider.NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664308);
			Slider.NativeMethodInfoPtr_get_wholeNumbers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664309);
			Slider.NativeMethodInfoPtr_set_wholeNumbers_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664310);
			Slider.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664311);
			Slider.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664312);
			Slider.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664313);
			Slider.NativeMethodInfoPtr_get_normalizedValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664314);
			Slider.NativeMethodInfoPtr_set_normalizedValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664315);
			Slider.NativeMethodInfoPtr_get_onValueChanged_Public_get_SliderEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664316);
			Slider.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_SliderEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664317);
			Slider.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664318);
			Slider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664319);
			Slider.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664320);
			Slider.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664321);
			Slider.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664322);
			Slider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664323);
			Slider.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664324);
			Slider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664325);
			Slider.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664326);
			Slider.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664327);
			Slider.NativeMethodInfoPtr_ClampValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664328);
			Slider.NativeMethodInfoPtr_Set_Protected_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664329);
			Slider.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664330);
			Slider.NativeMethodInfoPtr_get_axis_Private_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664331);
			Slider.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664332);
			Slider.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664333);
			Slider.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664334);
			Slider.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664335);
			Slider.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664336);
			Slider.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664337);
			Slider.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664338);
			Slider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664339);
			Slider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664340);
			Slider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664341);
			Slider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664342);
			Slider.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664343);
			Slider.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664344);
			Slider.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider>.NativeClassPtr, 100664345);
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00021CAC File Offset: 0x0001FEAC
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00021CEC File Offset: 0x0001FEEC
		public unsafe RectTransform fillRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_fillRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118418, RefRangeEnd = 118419, XrefRangeStart = 118413, XrefRangeEnd = 118418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_fillRect_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00021D30 File Offset: 0x0001FF30
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00021D70 File Offset: 0x0001FF70
		public unsafe RectTransform handleRect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118424, RefRangeEnd = 118425, XrefRangeStart = 118419, XrefRangeEnd = 118424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00021DB4 File Offset: 0x0001FFB4
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00021DF0 File Offset: 0x0001FFF0
		public unsafe Slider.Direction direction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_direction_Public_get_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118429, RefRangeEnd = 118430, XrefRangeStart = 118425, XrefRangeEnd = 118429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00021E30 File Offset: 0x00020030
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00021E6C File Offset: 0x0002006C
		public unsafe float minValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_minValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118430, XrefRangeEnd = 118434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00021EAC File Offset: 0x000200AC
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00021EE8 File Offset: 0x000200E8
		public unsafe float maxValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_maxValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118434, XrefRangeEnd = 118438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00021F28 File Offset: 0x00020128
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00021F64 File Offset: 0x00020164
		public unsafe bool wholeNumbers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_wholeNumbers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118438, XrefRangeEnd = 118442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_wholeNumbers_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00021FA4 File Offset: 0x000201A4
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00021FEC File Offset: 0x000201EC
		public unsafe virtual float value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00022038 File Offset: 0x00020238
		[CallerCount(0)]
		public unsafe virtual void SetValueWithoutNotify(float input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00022084 File Offset: 0x00020284
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x000220C0 File Offset: 0x000202C0
		public unsafe float normalizedValue
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118444, RefRangeEnd = 118450, XrefRangeStart = 118442, XrefRangeEnd = 118444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_normalizedValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118450, XrefRangeEnd = 118451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_normalizedValue_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00022100 File Offset: 0x00020300
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00022140 File Offset: 0x00020340
		public unsafe Slider.SliderEvent onValueChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_onValueChanged_Public_get_SliderEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Slider.SliderEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_SliderEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00022184 File Offset: 0x00020384
		public unsafe float stepSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_stepSize_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000221C0 File Offset: 0x000203C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118451, XrefRangeEnd = 118462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Slider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x000221FC File Offset: 0x000203FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00022248 File Offset: 0x00020448
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00022284 File Offset: 0x00020484
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x000222C0 File Offset: 0x000204C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118462, XrefRangeEnd = 118465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000222FC File Offset: 0x000204FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118465, XrefRangeEnd = 118467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00022338 File Offset: 0x00020538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118467, XrefRangeEnd = 118468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00022374 File Offset: 0x00020574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118468, XrefRangeEnd = 118498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x000223B0 File Offset: 0x000205B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118538, RefRangeEnd = 118541, XrefRangeStart = 118498, XrefRangeEnd = 118538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCachedReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000223E4 File Offset: 0x000205E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118541, XrefRangeEnd = 118543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ClampValue(float input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_ClampValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00022430 File Offset: 0x00020630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118543, XrefRangeEnd = 118552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Set(float input, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref input;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_Set_Protected_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00022488 File Offset: 0x00020688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118552, XrefRangeEnd = 118553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000224C4 File Offset: 0x000206C4
		public unsafe Slider.Axis axis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_axis_Private_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00022500 File Offset: 0x00020700
		public unsafe bool reverseValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0002253C File Offset: 0x0002073C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 118588, RefRangeEnd = 118600, XrefRangeStart = 118553, XrefRangeEnd = 118588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00022570 File Offset: 0x00020770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118621, RefRangeEnd = 118622, XrefRangeStart = 118600, XrefRangeEnd = 118621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag(PointerEventData eventData, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000225C4 File Offset: 0x000207C4
		[CallerCount(0)]
		public unsafe bool MayDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00022614 File Offset: 0x00020814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118622, XrefRangeEnd = 118637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00022664 File Offset: 0x00020864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118637, XrefRangeEnd = 118639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000226B4 File Offset: 0x000208B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118639, XrefRangeEnd = 118652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMove(AxisEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00022704 File Offset: 0x00020904
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00022750 File Offset: 0x00020950
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0002279C File Offset: 0x0002099C
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000227E8 File Offset: 0x000209E8
		[CallerCount(0)]
		public unsafe override Selectable FindSelectableOnDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00022834 File Offset: 0x00020A34
		[CallerCount(0)]
		public unsafe virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Slider.NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00022884 File Offset: 0x00020A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118652, XrefRangeEnd = 118670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(Slider.Direction direction, bool includeRectLayouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeRectLayouts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x000228D0 File Offset: 0x00020AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000045FA File Offset: 0x000027FA
		public Slider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00022910 File Offset: 0x00020B10
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00004603 File Offset: 0x00002803
		public unsafe RectTransform m_FillRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00022940 File Offset: 0x00020B40
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe RectTransform m_HandleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00022970 File Offset: 0x00020B70
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00004641 File Offset: 0x00002841
		public unsafe Slider.Direction m_Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Direction)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00022998 File Offset: 0x00020B98
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0000465C File Offset: 0x0000285C
		public unsafe float m_MinValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_MinValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_MinValue)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000229C0 File Offset: 0x00020BC0
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00004677 File Offset: 0x00002877
		public unsafe float m_MaxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_MaxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_MaxValue)) = value;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000229E8 File Offset: 0x00020BE8
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00004692 File Offset: 0x00002892
		public unsafe bool m_WholeNumbers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_WholeNumbers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_WholeNumbers)) = value;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00022A10 File Offset: 0x00020C10
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000046AD File Offset: 0x000028AD
		public unsafe float m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00022A38 File Offset: 0x00020C38
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000046C8 File Offset: 0x000028C8
		public unsafe Slider.SliderEvent m_OnValueChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_OnValueChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider.SliderEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_OnValueChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00022A68 File Offset: 0x00020C68
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000046E7 File Offset: 0x000028E7
		public unsafe Image m_FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00022A98 File Offset: 0x00020C98
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00004706 File Offset: 0x00002906
		public unsafe Transform m_FillTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00022AC8 File Offset: 0x00020CC8
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00004725 File Offset: 0x00002925
		public unsafe RectTransform m_FillContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_FillContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00022AF8 File Offset: 0x00020CF8
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00004744 File Offset: 0x00002944
		public unsafe Transform m_HandleTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00022B28 File Offset: 0x00020D28
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00004763 File Offset: 0x00002963
		public unsafe RectTransform m_HandleContainerRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleContainerRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_HandleContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00022B58 File Offset: 0x00020D58
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004782 File Offset: 0x00002982
		public unsafe Vector2 m_Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Offset)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00022B80 File Offset: 0x00020D80
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0000479D File Offset: 0x0000299D
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00022BA8 File Offset: 0x00020DA8
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000047B8 File Offset: 0x000029B8
		public unsafe bool m_DelayedUpdateVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_DelayedUpdateVisuals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Slider.NativeFieldInfoPtr_m_DelayedUpdateVisuals)) = value;
			}
		}

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_m_FillRect;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_m_HandleRect;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_m_MinValue;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxValue;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_m_WholeNumbers;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_m_OnValueChanged;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_m_FillImage;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_m_FillTransform;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_m_FillContainerRect;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_m_HandleTransform;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_m_HandleContainerRect;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_m_Offset;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_m_DelayedUpdateVisuals;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_get_fillRect_Public_get_RectTransform_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_set_fillRect_Public_set_Void_RectTransform_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_get_handleRect_Public_get_RectTransform_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_set_handleRect_Public_set_Void_RectTransform_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_get_direction_Public_get_Direction_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_Direction_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_get_minValue_Public_get_Single_0;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeMethodInfoPtr_set_minValue_Public_set_Void_Single_0;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeMethodInfoPtr_get_maxValue_Public_get_Single_0;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_set_maxValue_Public_set_Void_Single_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_get_wholeNumbers_Public_get_Boolean_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_set_wholeNumbers_Public_set_Void_Boolean_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_New_get_Single_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_New_set_Void_Single_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_New_Void_Single_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedValue_Public_get_Single_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_set_normalizedValue_Public_set_Void_Single_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_get_onValueChanged_Public_get_SliderEvent_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_set_onValueChanged_Public_set_Void_SliderEvent_0;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeMethodInfoPtr_get_stepSize_Private_get_Single_0;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCachedReferences_Private_Void_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr_ClampValue_Private_Single_Single_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_Set_Protected_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_get_axis_Private_get_Axis_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseValue_Private_get_Boolean_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_PointerEventData_Camera_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_MayDrag_Private_Boolean_PointerEventData_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_OnDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializePotentialDrag_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Direction_Boolean_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;

		// Token: 0x020000AE RID: 174
		public enum Direction
		{
			// Token: 0x040009BC RID: 2492
			LeftToRight,
			// Token: 0x040009BD RID: 2493
			RightToLeft,
			// Token: 0x040009BE RID: 2494
			BottomToTop,
			// Token: 0x040009BF RID: 2495
			TopToBottom
		}

		// Token: 0x020000AF RID: 175
		[Serializable]
		public class SliderEvent : UnityEvent<float>
		{
			// Token: 0x06000C66 RID: 3174 RVA: 0x000069CE File Offset: 0x00004BCE
			// Note: this type is marked as 'beforefieldinit'.
			static SliderEvent()
			{
				Il2CppClassPointerStore<Slider.SliderEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Slider>.NativeClassPtr, "SliderEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slider.SliderEvent>.NativeClassPtr);
				Slider.SliderEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slider.SliderEvent>.NativeClassPtr, 100665044);
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x00035E2C File Offset: 0x0003402C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118410, XrefRangeEnd = 118413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SliderEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Slider.SliderEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Slider.SliderEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x00006A02 File Offset: 0x00004C02
			public SliderEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009C0 RID: 2496
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000B0 RID: 176
		public enum Axis
		{
			// Token: 0x040009C2 RID: 2498
			Horizontal,
			// Token: 0x040009C3 RID: 2499
			Vertical
		}
	}
}
