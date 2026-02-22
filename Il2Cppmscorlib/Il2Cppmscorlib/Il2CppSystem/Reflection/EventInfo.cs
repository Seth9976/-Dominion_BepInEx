using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C6 RID: 454
	[Serializable]
	public class EventInfo : MemberInfo
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x000A4F04 File Offset: 0x000A3104
		// Note: this type is marked as 'beforefieldinit'.
		static EventInfo()
		{
			Il2CppClassPointerStore<EventInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "EventInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInfo>.NativeClassPtr);
			EventInfo.NativeFieldInfoPtr_cached_add_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, "cached_add_event");
			EventInfo.NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668148);
			EventInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668149);
			EventInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668150);
			EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668151);
			EventInfo.NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668152);
			EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668153);
			EventInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668154);
			EventInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668155);
			EventInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668156);
			EventInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668157);
			EventInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668158);
			EventInfo.NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, 100668159);
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000A5038 File Offset: 0x000A3238
		public unsafe virtual Type EventHandlerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000A5084 File Offset: 0x000A3284
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x000A50CC File Offset: 0x000A32CC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x000A5108 File Offset: 0x000A3308
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetAddMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x000A5160 File Offset: 0x000A3360
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetRaiseMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000A51B8 File Offset: 0x000A33B8
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetRemoveMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x000A5210 File Offset: 0x000A3410
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x000A5268 File Offset: 0x000A3468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317065, RefRangeEnd = 317066, XrefRangeStart = 317065, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x000A52B0 File Offset: 0x000A34B0
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(EventInfo left, EventInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x000A5304 File Offset: 0x000A3504
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 317601, RefRangeEnd = 317626, XrefRangeStart = 317601, XrefRangeEnd = 317626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(EventInfo left, EventInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x000A5358 File Offset: 0x000A3558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318200, XrefRangeEnd = 318201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref event_handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type_handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x000A53A8 File Offset: 0x000A35A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318204, RefRangeEnd = 318205, XrefRangeStart = 318201, XrefRangeEnd = 318204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reflectedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0000A0CE File Offset: 0x000082CE
		public EventInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x000A53F8 File Offset: 0x000A35F8
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0000A0D7 File Offset: 0x000082D7
		public unsafe EventInfo.AddEventAdapter cached_add_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInfo.NativeFieldInfoPtr_cached_add_event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventInfo.AddEventAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventInfo.NativeFieldInfoPtr_cached_add_event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_cached_add_event;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandlerType_Public_Virtual_New_get_Type_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_GetRaiseMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Abstract_Virtual_New_MethodInfo_Boolean_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EventInfo_EventInfo_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EventInfo_EventInfo_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr_internal_from_handle_type_Private_Static_EventInfo_IntPtr_IntPtr_0;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeMethodInfoPtr_GetEventFromHandle_Internal_Static_EventInfo_RuntimeEventHandle_RuntimeTypeHandle_0;

		// Token: 0x020005C7 RID: 1479
		public sealed class AddEventAdapter : MulticastDelegate
		{
			// Token: 0x0600511A RID: 20762 RVA: 0x0001EE57 File Offset: 0x0001D057
			// Note: this type is marked as 'beforefieldinit'.
			static AddEventAdapter()
			{
				Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventInfo>.NativeClassPtr, "AddEventAdapter");
				EventInfo.AddEventAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr, 100668160);
				EventInfo.AddEventAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr, 100668161);
			}

			// Token: 0x0600511B RID: 20763 RVA: 0x0016AED0 File Offset: 0x001690D0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddEventAdapter(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventInfo.AddEventAdapter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.AddEventAdapter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600511C RID: 20764 RVA: 0x0016AF2C File Offset: 0x0016912C
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Object _this, Delegate dele)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_this);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dele);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventInfo.AddEventAdapter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600511D RID: 20765 RVA: 0x0001EE95 File Offset: 0x0001D095
			public AddEventAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600511E RID: 20766 RVA: 0x0001EE9E File Offset: 0x0001D09E
			public static implicit operator EventInfo.AddEventAdapter(Action<Object, Delegate> A_0)
			{
				return DelegateSupport.ConvertDelegate<EventInfo.AddEventAdapter>(A_0);
			}

			// Token: 0x0600511F RID: 20767 RVA: 0x0001EEA6 File Offset: 0x0001D0A6
			public static EventInfo.AddEventAdapter operator +(EventInfo.AddEventAdapter A_0, EventInfo.AddEventAdapter A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<EventInfo.AddEventAdapter>();
			}

			// Token: 0x06005120 RID: 20768 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			public static EventInfo.AddEventAdapter operator -(EventInfo.AddEventAdapter A_0, EventInfo.AddEventAdapter A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<EventInfo.AddEventAdapter>();
				}
				return delegate2;
			}

			// Token: 0x040041C9 RID: 16841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040041CA RID: 16842
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_Delegate_0;
		}
	}
}
