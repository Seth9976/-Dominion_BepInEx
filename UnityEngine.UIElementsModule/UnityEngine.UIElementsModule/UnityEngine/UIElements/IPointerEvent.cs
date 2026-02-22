using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UIElements
{
	// Token: 0x02000093 RID: 147
	public class IPointerEvent : Il2CppObjectBase
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x00024FB4 File Offset: 0x000231B4
		// Note: this type is marked as 'beforefieldinit'.
		static IPointerEvent()
		{
			Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "IPointerEvent");
			IPointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664023);
			IPointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664024);
			IPointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664025);
			IPointerEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664026);
			IPointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664027);
			IPointerEvent.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664028);
			IPointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664029);
			IPointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664030);
			IPointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664031);
			IPointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664032);
			IPointerEvent.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664033);
			IPointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664034);
			IPointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664035);
			IPointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664036);
			IPointerEvent.NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664037);
			IPointerEvent.NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664038);
			IPointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664039);
			IPointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPointerEvent>.NativeClassPtr, 100664040);
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00025144 File Offset: 0x00023344
		public unsafe virtual int pointerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002518C File Offset: 0x0002338C
		public unsafe virtual string pointerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000251D0 File Offset: 0x000233D0
		public unsafe virtual bool isPrimary
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x00025218 File Offset: 0x00023418
		public unsafe virtual int button
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x00025260 File Offset: 0x00023460
		public unsafe virtual int pressedButtons
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x000252A8 File Offset: 0x000234A8
		public unsafe virtual Vector3 position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000252F0 File Offset: 0x000234F0
		public unsafe virtual Vector3 localPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00025338 File Offset: 0x00023538
		public unsafe virtual Vector3 deltaPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00025380 File Offset: 0x00023580
		public unsafe virtual float deltaTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x000253C8 File Offset: 0x000235C8
		public unsafe virtual int clickCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00025410 File Offset: 0x00023610
		public unsafe virtual float pressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00025458 File Offset: 0x00023658
		public unsafe virtual float tangentialPressure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x000254A0 File Offset: 0x000236A0
		public unsafe virtual float altitudeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x000254E8 File Offset: 0x000236E8
		public unsafe virtual float azimuthAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00025530 File Offset: 0x00023730
		public unsafe virtual float twist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00025578 File Offset: 0x00023778
		public unsafe virtual Vector2 radius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000255C0 File Offset: 0x000237C0
		public unsafe virtual Vector2 radiusVariance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00025608 File Offset: 0x00023808
		public unsafe virtual EventModifiers modifiers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPointerEvent.NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00005514 File Offset: 0x00003714
		public IPointerEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerId_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerType_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_isPrimary_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_button_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedButtons_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_Abstract_Virtual_New_get_Vector3_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_tangentialPressure_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_get_twist_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_Abstract_Virtual_New_get_Vector2_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_get_modifiers_Public_Abstract_Virtual_New_get_EventModifiers_0;
	}
}
