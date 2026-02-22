using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004F RID: 79
	public class PointerEventData : BaseEventData
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00029C54 File Offset: 0x00027E54
		// Note: this type is marked as 'beforefieldinit'.
		static PointerEventData()
		{
			Il2CppClassPointerStore<PointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PointerEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr);
			PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerEnter>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_m_PointerPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "m_PointerPress");
			PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<lastPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<rawPointerPress>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerDrag>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerCurrentRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerPressRaycast>k__BackingField");
			PointerEventData.NativeFieldInfoPtr_hovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "hovered");
			PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<eligibleForClick>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pointerId>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<position>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<delta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pressPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldPosition>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<worldNormal>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickTime>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<clickCount>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<scrollDelta>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<useDragThreshold>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<dragging>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__button_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<button>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<pressure>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<tangentialPressure>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<altitudeAngle>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<azimuthAngle>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__twist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<twist>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__radius_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<radius>k__BackingField");
			PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, "<radiusVariance>k__BackingField");
			PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664608);
			PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664609);
			PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664610);
			PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664611);
			PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664612);
			PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664613);
			PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664614);
			PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664615);
			PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664616);
			PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664617);
			PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664618);
			PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664619);
			PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664620);
			PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664621);
			PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664622);
			PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664623);
			PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664624);
			PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664625);
			PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664626);
			PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664627);
			PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664628);
			PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664629);
			PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664630);
			PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664631);
			PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664632);
			PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664633);
			PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664634);
			PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664635);
			PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664636);
			PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664637);
			PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664638);
			PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664639);
			PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664640);
			PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664641);
			PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664642);
			PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664643);
			PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664644);
			PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664645);
			PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664646);
			PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664647);
			PointerEventData.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664648);
			PointerEventData.NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664649);
			PointerEventData.NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664650);
			PointerEventData.NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664651);
			PointerEventData.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664652);
			PointerEventData.NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664653);
			PointerEventData.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664654);
			PointerEventData.NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664655);
			PointerEventData.NativeMethodInfoPtr_get_twist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664656);
			PointerEventData.NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664657);
			PointerEventData.NativeMethodInfoPtr_get_radius_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664658);
			PointerEventData.NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664659);
			PointerEventData.NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664660);
			PointerEventData.NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664661);
			PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664662);
			PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664663);
			PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664664);
			PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664665);
			PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664666);
			PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664667);
			PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664668);
			PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr, 100664669);
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0002A3A0 File Offset: 0x000285A0
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x0002A3E0 File Offset: 0x000285E0
		public unsafe GameObject pointerEnter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0002A424 File Offset: 0x00028624
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x0002A464 File Offset: 0x00028664
		public unsafe GameObject lastPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0002A4A8 File Offset: 0x000286A8
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x0002A4E8 File Offset: 0x000286E8
		public unsafe GameObject rawPointerPress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0002A52C File Offset: 0x0002872C
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x0002A56C File Offset: 0x0002876C
		public unsafe GameObject pointerDrag
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0002A5B0 File Offset: 0x000287B0
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x0002A5F0 File Offset: 0x000287F0
		public unsafe GameObject pointerClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0002A634 File Offset: 0x00028834
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0002A66C File Offset: 0x0002886C
		public unsafe RaycastResult pointerCurrentRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0002A6B4 File Offset: 0x000288B4
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0002A6EC File Offset: 0x000288EC
		public unsafe RaycastResult pointerPressRaycast
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RaycastResult(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0002A734 File Offset: 0x00028934
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x0002A770 File Offset: 0x00028970
		public unsafe bool eligibleForClick
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0002A7B0 File Offset: 0x000289B0
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x0002A7EC File Offset: 0x000289EC
		public unsafe int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002A82C File Offset: 0x00028A2C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x0002A868 File Offset: 0x00028A68
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002A8A8 File Offset: 0x00028AA8
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x0002A8E4 File Offset: 0x00028AE4
		public unsafe Vector2 delta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_delta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002A924 File Offset: 0x00028B24
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x0002A960 File Offset: 0x00028B60
		public unsafe Vector2 pressPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0002A9DC File Offset: 0x00028BDC
		public unsafe Vector3 worldPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0002AA1C File Offset: 0x00028C1C
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0002AA58 File Offset: 0x00028C58
		public unsafe Vector3 worldNormal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0002AA98 File Offset: 0x00028C98
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x0002AAD4 File Offset: 0x00028CD4
		public unsafe float clickTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0002AB14 File Offset: 0x00028D14
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x0002AB50 File Offset: 0x00028D50
		public unsafe int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0002AB90 File Offset: 0x00028D90
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0002ABCC File Offset: 0x00028DCC
		public unsafe Vector2 scrollDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0002AC0C File Offset: 0x00028E0C
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0002AC48 File Offset: 0x00028E48
		public unsafe bool useDragThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0002AC88 File Offset: 0x00028E88
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		public unsafe bool dragging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0002AD04 File Offset: 0x00028F04
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x0002AD40 File Offset: 0x00028F40
		public unsafe PointerEventData.InputButton button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_button_Public_get_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0002AD80 File Offset: 0x00028F80
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x0002ADBC File Offset: 0x00028FBC
		public unsafe float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0002ADFC File Offset: 0x00028FFC
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x0002AE38 File Offset: 0x00029038
		public unsafe float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0002AE78 File Offset: 0x00029078
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x0002AEB4 File Offset: 0x000290B4
		public unsafe float altitudeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0002AEF4 File Offset: 0x000290F4
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0002AF30 File Offset: 0x00029130
		public unsafe float azimuthAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0002AF70 File Offset: 0x00029170
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x0002AFAC File Offset: 0x000291AC
		public unsafe float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_twist_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0002AFEC File Offset: 0x000291EC
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x0002B028 File Offset: 0x00029228
		public unsafe Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_radius_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0002B068 File Offset: 0x00029268
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x0002B0A4 File Offset: 0x000292A4
		public unsafe Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0002B0E4 File Offset: 0x000292E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 120929, RefRangeEnd = 120932, XrefRangeStart = 120916, XrefRangeEnd = 120929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002B130 File Offset: 0x00029330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120933, RefRangeEnd = 120934, XrefRangeStart = 120932, XrefRangeEnd = 120933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerMoving()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0002B16C File Offset: 0x0002936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120934, XrefRangeEnd = 120935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScrolling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_IsScrolling_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002B1A8 File Offset: 0x000293A8
		public unsafe Camera enterEventCamera
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 120939, RefRangeEnd = 120943, XrefRangeStart = 120935, XrefRangeEnd = 120939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0002B1E8 File Offset: 0x000293E8
		public unsafe Camera pressEventCamera
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 120947, RefRangeEnd = 120964, XrefRangeStart = 120943, XrefRangeEnd = 120947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002B228 File Offset: 0x00029428
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0002B268 File Offset: 0x00029468
		public unsafe GameObject pointerPress
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 120968, RefRangeEnd = 120978, XrefRangeStart = 120964, XrefRangeEnd = 120968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerEventData.NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002B2AC File Offset: 0x000294AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120978, XrefRangeEnd = 121066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0000508D File Offset: 0x0000328D
		public PointerEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002B2F0 File Offset: 0x000294F0
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00005096 File Offset: 0x00003296
		public unsafe GameObject _pointerEnter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerEnter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002B320 File Offset: 0x00029520
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x000050B5 File Offset: 0x000032B5
		public unsafe GameObject m_PointerPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_m_PointerPress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0002B350 File Offset: 0x00029550
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x000050D4 File Offset: 0x000032D4
		public unsafe GameObject _lastPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__lastPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0002B380 File Offset: 0x00029580
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x000050F3 File Offset: 0x000032F3
		public unsafe GameObject _rawPointerPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__rawPointerPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0002B3B0 File Offset: 0x000295B0
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00005112 File Offset: 0x00003312
		public unsafe GameObject _pointerDrag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerDrag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0002B3E0 File Offset: 0x000295E0
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00005131 File Offset: 0x00003331
		public unsafe GameObject _pointerClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerClick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x0002B410 File Offset: 0x00029610
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00005150 File Offset: 0x00003350
		public RaycastResult _pointerCurrentRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0002B440 File Offset: 0x00029640
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x0000517E File Offset: 0x0000337E
		public RaycastResult _pointerPressRaycast_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField);
				return new RaycastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerPressRaycast_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x0002B470 File Offset: 0x00029670
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x000051AC File Offset: 0x000033AC
		public unsafe List<GameObject> hovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr_hovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002B4A0 File Offset: 0x000296A0
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000051CB File Offset: 0x000033CB
		public unsafe bool _eligibleForClick_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__eligibleForClick_k__BackingField)) = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002B4C8 File Offset: 0x000296C8
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000051E6 File Offset: 0x000033E6
		public unsafe int _pointerId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pointerId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x0002B4F0 File Offset: 0x000296F0
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00005201 File Offset: 0x00003401
		public unsafe Vector2 _position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x0002B518 File Offset: 0x00029718
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x0000521C File Offset: 0x0000341C
		public unsafe Vector2 _delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__delta_k__BackingField)) = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x0002B540 File Offset: 0x00029740
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00005237 File Offset: 0x00003437
		public unsafe Vector2 _pressPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0002B568 File Offset: 0x00029768
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00005252 File Offset: 0x00003452
		public unsafe Vector3 _worldPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0002B590 File Offset: 0x00029790
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0000526D File Offset: 0x0000346D
		public unsafe Vector3 _worldNormal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__worldNormal_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x0002B5B8 File Offset: 0x000297B8
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00005288 File Offset: 0x00003488
		public unsafe float _clickTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0002B5E0 File Offset: 0x000297E0
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x000052A3 File Offset: 0x000034A3
		public unsafe int _clickCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__clickCount_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0002B608 File Offset: 0x00029808
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x000052BE File Offset: 0x000034BE
		public unsafe Vector2 _scrollDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__scrollDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002B630 File Offset: 0x00029830
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x000052D9 File Offset: 0x000034D9
		public unsafe bool _useDragThreshold_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__useDragThreshold_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0002B658 File Offset: 0x00029858
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x000052F4 File Offset: 0x000034F4
		public unsafe bool _dragging_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__dragging_k__BackingField)) = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0002B680 File Offset: 0x00029880
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0000530F File Offset: 0x0000350F
		public unsafe PointerEventData.InputButton _button_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__button_k__BackingField)) = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0002B6A8 File Offset: 0x000298A8
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0000532A File Offset: 0x0000352A
		public unsafe float _pressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__pressure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0002B6D0 File Offset: 0x000298D0
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x00005345 File Offset: 0x00003545
		public unsafe float _tangentialPressure_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__tangentialPressure_k__BackingField)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0002B6F8 File Offset: 0x000298F8
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00005360 File Offset: 0x00003560
		public unsafe float _altitudeAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__altitudeAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0002B720 File Offset: 0x00029920
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000537B File Offset: 0x0000357B
		public unsafe float _azimuthAngle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__azimuthAngle_k__BackingField)) = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002B748 File Offset: 0x00029948
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00005396 File Offset: 0x00003596
		public unsafe float _twist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__twist_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__twist_k__BackingField)) = value;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0002B770 File Offset: 0x00029970
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x000053B1 File Offset: 0x000035B1
		public unsafe Vector2 _radius_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radius_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radius_k__BackingField)) = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0002B798 File Offset: 0x00029998
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x000053CC File Offset: 0x000035CC
		public unsafe Vector2 _radiusVariance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PointerEventData.NativeFieldInfoPtr__radiusVariance_k__BackingField)) = value;
			}
		}

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeFieldInfoPtr__pointerEnter_k__BackingField;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeFieldInfoPtr_m_PointerPress;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeFieldInfoPtr__lastPress_k__BackingField;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr__rawPointerPress_k__BackingField;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr__pointerDrag_k__BackingField;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeFieldInfoPtr__pointerClick_k__BackingField;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeFieldInfoPtr__pointerCurrentRaycast_k__BackingField;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeFieldInfoPtr__pointerPressRaycast_k__BackingField;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeFieldInfoPtr_hovered;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeFieldInfoPtr__eligibleForClick_k__BackingField;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr__pointerId_k__BackingField;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr__position_k__BackingField;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr__delta_k__BackingField;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr__pressPosition_k__BackingField;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__worldPosition_k__BackingField;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr__worldNormal_k__BackingField;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr__clickTime_k__BackingField;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeFieldInfoPtr__scrollDelta_k__BackingField;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeFieldInfoPtr__useDragThreshold_k__BackingField;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeFieldInfoPtr__dragging_k__BackingField;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr__button_k__BackingField;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr__pressure_k__BackingField;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr__tangentialPressure_k__BackingField;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr__altitudeAngle_k__BackingField;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr__azimuthAngle_k__BackingField;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr__twist_k__BackingField;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeFieldInfoPtr__radius_k__BackingField;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeFieldInfoPtr__radiusVariance_k__BackingField;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerEnter_Public_get_GameObject_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerEnter_Public_set_Void_GameObject_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_get_lastPress_Public_get_GameObject_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_set_lastPress_Private_set_Void_GameObject_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_get_rawPointerPress_Public_get_GameObject_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_set_rawPointerPress_Public_set_Void_GameObject_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerDrag_Public_get_GameObject_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerDrag_Public_set_Void_GameObject_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerClick_Public_get_GameObject_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerClick_Public_set_Void_GameObject_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerCurrentRaycast_Public_get_RaycastResult_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerCurrentRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPressRaycast_Public_get_RaycastResult_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPressRaycast_Public_set_Void_RaycastResult_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_get_eligibleForClick_Public_get_Boolean_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_set_eligibleForClick_Public_set_Void_Boolean_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_get_Int32_0;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerId_Public_set_Void_Int32_0;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr_get_delta_Public_get_Vector2_0;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Public_set_Void_Vector2_0;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeMethodInfoPtr_get_pressPosition_Public_get_Vector2_0;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_set_pressPosition_Public_set_Void_Vector2_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_get_worldPosition_Public_get_Vector3_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_set_worldPosition_Public_set_Void_Vector3_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_worldNormal_Public_get_Vector3_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_set_worldNormal_Public_set_Void_Vector3_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_get_clickTime_Public_get_Single_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_set_clickTime_Public_set_Void_Single_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_Int32_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Public_set_Void_Int32_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_get_scrollDelta_Public_get_Vector2_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_set_scrollDelta_Public_set_Void_Vector2_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_useDragThreshold_Public_get_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_set_useDragThreshold_Public_set_Void_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_dragging_Public_get_Boolean_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set_dragging_Public_set_Void_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_get_InputButton_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_set_button_Public_set_Void_InputButton_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_set_pressure_Public_set_Void_Single_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_get_Single_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_set_tangentialPressure_Public_set_Void_Single_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_set_altitudeAngle_Public_set_Void_Single_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_set_azimuthAngle_Public_set_Void_Single_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_get_Single_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_set_twist_Public_set_Void_Single_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Vector2_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_set_radius_Public_set_Void_Vector2_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_get_Vector2_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_radiusVariance_Public_set_Void_Vector2_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerMoving_Public_Boolean_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_IsScrolling_Public_Boolean_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_get_enterEventCamera_Public_get_Camera_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_pressEventCamera_Public_get_Camera_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerPress_Public_get_GameObject_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_set_pointerPress_Public_set_Void_GameObject_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020000C1 RID: 193
		public enum InputButton
		{
			// Token: 0x04000A45 RID: 2629
			Left,
			// Token: 0x04000A46 RID: 2630
			Right,
			// Token: 0x04000A47 RID: 2631
			Middle
		}

		// Token: 0x020000C2 RID: 194
		public enum FramePressState
		{
			// Token: 0x04000A49 RID: 2633
			Pressed,
			// Token: 0x04000A4A RID: 2634
			Released,
			// Token: 0x04000A4B RID: 2635
			PressedAndReleased,
			// Token: 0x04000A4C RID: 2636
			NotChanged
		}
	}
}
