using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000065 RID: 101
	public class CallbackEventHandler : Object
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		// Note: this type is marked as 'beforefieldinit'.
		static CallbackEventHandler()
		{
			Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CallbackEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr);
			CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, "m_CallbackRegistry");
			CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663836);
			CallbackEventHandler.NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663837);
			CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663838);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663839);
			CallbackEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663840);
			CallbackEventHandler.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663841);
			CallbackEventHandler.NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663842);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663843);
			CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr, 100663844);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001FDCC File Offset: 0x0001DFCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94648, RefRangeEnd = 94650, XrefRangeStart = 94643, XrefRangeEnd = 94648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001FE1C File Offset: 0x0001E01C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94650, RefRangeEnd = 94654, XrefRangeStart = 94650, XrefRangeEnd = 94650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.MethodInfoStoreGeneric_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001FE6C File Offset: 0x0001E06C
		[CallerCount(0)]
		public unsafe virtual void SendEvent(EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001FEBC File Offset: 0x0001E0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94654, XrefRangeEnd = 94655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleEventAtTargetPhase(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001FF00 File Offset: 0x0001E100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94655, XrefRangeEnd = 94668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleEvent(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001FF50 File Offset: 0x0001E150
		[CallerCount(0)]
		public unsafe virtual bool HasTrickleDownHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001FF8C File Offset: 0x0001E18C
		[CallerCount(0)]
		public unsafe virtual bool HasBubbleUpHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallbackEventHandler.NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00020018 File Offset: 0x0001E218
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallbackEventHandler.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00004D53 File Offset: 0x00002F53
		public CallbackEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00020068 File Offset: 0x0001E268
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00004D5C File Offset: 0x00002F5C
		public unsafe EventCallbackRegistry m_CallbackRegistry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackRegistry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallbackEventHandler.NativeFieldInfoPtr_m_CallbackRegistry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_m_CallbackRegistry;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_EventBase_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_HandleEventAtTargetPhase_Internal_Void_EventBase_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_HandleEvent_Public_Virtual_New_Void_EventBase_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_HasBubbleUpHandlers_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Protected_Virtual_New_Void_EventBase_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_New_Void_EventBase_0;

		// Token: 0x02000212 RID: 530
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x040008B4 RID: 2228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000213 RID: 531
		private sealed class MethodInfoStoreGeneric_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x040008B5 RID: 2229
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallbackEventHandler.NativeMethodInfoPtr_UnregisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<CallbackEventHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}
	}
}
