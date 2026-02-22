using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005E RID: 94
	public class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackFunctor()
		{
			Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackFunctor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr);
			EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, "m_Callback");
			EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, "m_EventTypeId");
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100663802);
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100663803);
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100663804);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001ED88 File Offset: 0x0001CF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94458, XrefRangeEnd = 94463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctor<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94463, XrefRangeEnd = 94473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001EE34 File Offset: 0x0001D034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94473, XrefRangeEnd = 94474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00004BFC File Offset: 0x00002DFC
		public EventCallbackFunctor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00004C05 File Offset: 0x00002E05
		public unsafe EventCallback<TEventType> m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<TEventType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001EED8 File Offset: 0x0001D0D8
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00004C24 File Offset: 0x00002E24
		public unsafe long m_EventTypeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId)) = value;
			}
		}

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_m_EventTypeId;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0;
	}
}
