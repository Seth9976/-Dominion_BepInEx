using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005D RID: 93
	public class EventCallbackFunctorBase : Object
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x0001E9FC File Offset: 0x0001CBFC
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackFunctorBase()
		{
			Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackFunctorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr);
			EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, "<phase>k__BackingField");
			EventCallbackFunctorBase.NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663796);
			EventCallbackFunctorBase.NativeMethodInfoPtr_set_phase_Private_set_Void_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663797);
			EventCallbackFunctorBase.NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663798);
			EventCallbackFunctorBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663799);
			EventCallbackFunctorBase.NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663800);
			EventCallbackFunctorBase.NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100663801);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0001EAB8 File Offset: 0x0001CCB8
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0001EAF4 File Offset: 0x0001CCF4
		public unsafe CallbackPhase phase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_set_phase_Private_set_Void_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0001EB34 File Offset: 0x0001CD34
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctorBase(CallbackPhase phase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001EB7C File Offset: 0x0001CD7C
		[CallerCount(0)]
		public unsafe virtual void Invoke(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctorBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001EBCC File Offset: 0x0001CDCC
		[CallerCount(0)]
		public unsafe virtual bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctorBase.NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0001EC40 File Offset: 0x0001CE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94457, RefRangeEnd = 94458, XrefRangeStart = 94457, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PhaseMatches(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004BD8 File Offset: 0x00002DD8
		public EventCallbackFunctorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001EC90 File Offset: 0x0001CE90
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004BE1 File Offset: 0x00002DE1
		public unsafe CallbackPhase _phase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField)) = value;
			}
		}

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr__phase_k__BackingField;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_set_phase_Private_set_Void_CallbackPhase_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_EventBase_0;
	}
}
