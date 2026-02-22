using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x02000063 RID: 99
	public class EventCallbackRegistry : Object
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x0001F68C File Offset: 0x0001D88C
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackRegistry()
		{
			Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr);
			EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "s_ListPool");
			EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_Callbacks");
			EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_TemporaryCallbacks");
			EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_IsInvoking");
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663822);
			EventCallbackRegistry.NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663823);
			EventCallbackRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663824);
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663825);
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663826);
			EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663827);
			EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663828);
			EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663829);
			EventCallbackRegistry.NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663830);
			EventCallbackRegistry.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663831);
			EventCallbackRegistry.NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100663832);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 94571, RefRangeEnd = 94576, XrefRangeStart = 94561, XrefRangeEnd = 94571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventCallbackList GetCallbackList(EventCallbackList initializer = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001F82C File Offset: 0x0001DA2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94587, RefRangeEnd = 94591, XrefRangeStart = 94576, XrefRangeEnd = 94587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCallbackList(EventCallbackList toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0001F864 File Offset: 0x0001DA64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94592, RefRangeEnd = 94593, XrefRangeStart = 94591, XrefRangeEnd = 94592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94597, RefRangeEnd = 94598, XrefRangeStart = 94593, XrefRangeEnd = 94597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList GetCallbackListForWriting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001F8E0 File Offset: 0x0001DAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94598, RefRangeEnd = 94599, XrefRangeStart = 94598, XrefRangeEnd = 94598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList GetCallbackListForReading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001F920 File Offset: 0x0001DB20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94618, RefRangeEnd = 94619, XrefRangeStart = 94599, XrefRangeEnd = 94618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0001F98C File Offset: 0x0001DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94619, XrefRangeEnd = 94629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0001F9DC File Offset: 0x0001DBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94629, XrefRangeEnd = 94634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.MethodInfoStoreGeneric_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001FA38 File Offset: 0x0001DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94634, XrefRangeEnd = 94643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallbacks(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001FA7C File Offset: 0x0001DC7C
		[CallerCount(0)]
		public unsafe bool HasTrickleDownHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[CallerCount(0)]
		public unsafe bool HasBubbleHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public EventCallbackRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001FAF4 File Offset: 0x0001DCF4
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00004CDF File Offset: 0x00002EDF
		public unsafe static EventCallbackListPool s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackListPool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001FB1C File Offset: 0x0001DD1C
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public unsafe EventCallbackList m_Callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00004D10 File Offset: 0x00002F10
		public unsafe EventCallbackList m_TemporaryCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001FB7C File Offset: 0x0001DD7C
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00004D2F File Offset: 0x00002F2F
		public unsafe int m_IsInvoking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking)) = value;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		public bool ShouldRegisterCallback(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			bool flag = callback == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventCallbackList callbackListForReading = this.GetCallbackListForReading();
				bool flag3 = callbackListForReading != null;
				flag2 = !flag3 || !callbackListForReading.Contains(eventTypeId, callback, phase);
			}
			return flag2;
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr_m_Callbacks;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr_m_TemporaryCallbacks;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInvoking;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0;

		// Token: 0x02000210 RID: 528
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x040008B2 RID: 2226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000211 RID: 529
		private sealed class MethodInfoStoreGeneric_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x040008B3 RID: 2227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}
	}
}
