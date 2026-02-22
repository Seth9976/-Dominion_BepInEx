using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000C RID: 12
	public sealed class EventDispatcher : Object
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000D828 File Offset: 0x0000BA28
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcher()
		{
			Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr);
			EventDispatcher.NativeFieldInfoPtr_m_ClickDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_ClickDetector");
			EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_DispatchingStrategies");
			EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "k_EventQueuePool");
			EventDispatcher.NativeFieldInfoPtr_m_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Queue");
			EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "<pointerState>k__BackingField");
			EventDispatcher.NativeFieldInfoPtr_m_GateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_GateCount");
			EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_DispatchContexts");
			EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "s_EditorStrategies");
			EventDispatcher.NativeFieldInfoPtr_m_Immediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Immediate");
			EventDispatcher.NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663319);
			EventDispatcher.NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663320);
			EventDispatcher.NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663321);
			EventDispatcher.NativeMethodInfoPtr_CloseGate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663322);
			EventDispatcher.NativeMethodInfoPtr_OpenGate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663323);
			EventDispatcher.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663324);
			EventDispatcher.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663325);
			EventDispatcher.NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100663326);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		public unsafe PointerDispatchState pointerState
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr3) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		public unsafe bool dispatchImmediately
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91064, RefRangeEnd = 91065, XrefRangeStart = 91048, XrefRangeEnd = 91064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000DA8C File Offset: 0x0000BC8C
		[CallerCount(0)]
		public unsafe void CloseGate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_CloseGate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000DAC0 File Offset: 0x0000BCC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91070, RefRangeEnd = 91071, XrefRangeStart = 91065, XrefRangeEnd = 91070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_OpenGate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91098, RefRangeEnd = 91100, XrefRangeStart = 91071, XrefRangeEnd = 91098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEventQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000DB28 File Offset: 0x0000BD28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91132, RefRangeEnd = 91133, XrefRangeStart = 91100, XrefRangeEnd = 91132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 91160, RefRangeEnd = 91161, XrefRangeStart = 91133, XrefRangeEnd = 91160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imguiEventIsInitiallyUsed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000238A File Offset: 0x0000058A
		public EventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002393 File Offset: 0x00000593
		public unsafe ClickDetector m_ClickDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_ClickDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClickDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_ClickDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000DC10 File Offset: 0x0000BE10
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000023B2 File Offset: 0x000005B2
		public unsafe List<IEventDispatchingStrategy> m_DispatchingStrategies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEventDispatchingStrategy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000DC40 File Offset: 0x0000BE40
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000023D1 File Offset: 0x000005D1
		public unsafe static ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Queue<EventDispatcher.EventRecord>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000DC68 File Offset: 0x0000BE68
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000023E3 File Offset: 0x000005E3
		public unsafe Queue<EventDispatcher.EventRecord> m_Queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<EventDispatcher.EventRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000DC98 File Offset: 0x0000BE98
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe PointerDispatchState _pointerState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002421 File Offset: 0x00000621
		public unsafe uint m_GateCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateCount)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000243C File Offset: 0x0000063C
		public unsafe Stack<EventDispatcher.DispatchContext> m_DispatchContexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<EventDispatcher.DispatchContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000DD20 File Offset: 0x0000BF20
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe static Il2CppReferenceArray<IEventDispatchingStrategy> s_EditorStrategies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventDispatchingStrategy>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000DD48 File Offset: 0x0000BF48
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000246D File Offset: 0x0000066D
		public unsafe bool m_Immediate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Immediate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Immediate)) = value;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public static EventDispatcher CreateDefault()
		{
			return new EventDispatcher(EventDispatcher.s_EditorStrategies);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
		{
			return new EventDispatcher(strategies);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		public void PushDispatcherContext()
		{
			this.ProcessEventQueue();
			Stack<EventDispatcher.DispatchContext> dispatchContexts = this.m_DispatchContexts;
			EventDispatcher.DispatchContext dispatchContext = null;
			dispatchContext.m_GateCount = this.m_GateCount;
			dispatchContext.m_Queue = this.m_Queue;
			dispatchContexts.Push(dispatchContext);
			this.m_GateCount = 0U;
			this.m_Queue = EventDispatcher.k_EventQueuePool.Get();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000DE00 File Offset: 0x0000C000
		public void PopDispatcherContext()
		{
			Debug.Assert(this.m_GateCount == 0U, "All gates should have been opened before popping dispatch context.");
			Debug.Assert(this.m_Queue.Count == 0, "Queue should be empty when popping dispatch context.");
			EventDispatcher.k_EventQueuePool.Release(this.m_Queue);
			this.m_GateCount = this.m_DispatchContexts.Peek().m_GateCount;
			this.m_Queue = this.m_DispatchContexts.Peek().m_Queue;
			this.m_DispatchContexts.Pop();
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_m_ClickDetector;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingStrategies;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_k_EventQueuePool;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_m_Queue;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__pointerState_k__BackingField;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_m_GateCount;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchContexts;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_s_EditorStrategies;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_Immediate;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_CloseGate_Internal_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_OpenGate_Internal_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0;

		// Token: 0x020001E9 RID: 489
		public sealed class EventRecord : ValueType
		{
			// Token: 0x06001338 RID: 4920 RVA: 0x0003ADE8 File Offset: 0x00038FE8
			// Note: this type is marked as 'beforefieldinit'.
			static EventRecord()
			{
				Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "EventRecord");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr);
				EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr, "m_Event");
				EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr, "m_Panel");
			}

			// Token: 0x06001339 RID: 4921 RVA: 0x0000C634 File Offset: 0x0000A834
			public EventRecord(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600133A RID: 4922 RVA: 0x0000C63D File Offset: 0x0000A83D
			public EventRecord()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr))
			{
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x0600133B RID: 4923 RVA: 0x0003AE3C File Offset: 0x0003903C
			// (set) Token: 0x0600133C RID: 4924 RVA: 0x0000C64F File Offset: 0x0000A84F
			public unsafe EventBase m_Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x0600133D RID: 4925 RVA: 0x0003AE6C File Offset: 0x0003906C
			// (set) Token: 0x0600133E RID: 4926 RVA: 0x0000C66E File Offset: 0x0000A86E
			public unsafe IPanel m_Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000854 RID: 2132
			private static readonly IntPtr NativeFieldInfoPtr_m_Event;

			// Token: 0x04000855 RID: 2133
			private static readonly IntPtr NativeFieldInfoPtr_m_Panel;
		}

		// Token: 0x020001EA RID: 490
		public sealed class DispatchContext : ValueType
		{
			// Token: 0x0600133F RID: 4927 RVA: 0x0003AE9C File Offset: 0x0003909C
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchContext()
			{
				Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "DispatchContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr);
				EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr, "m_GateCount");
				EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr, "m_Queue");
			}

			// Token: 0x06001340 RID: 4928 RVA: 0x0000C68D File Offset: 0x0000A88D
			public DispatchContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001341 RID: 4929 RVA: 0x0000C696 File Offset: 0x0000A896
			public DispatchContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr))
			{
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001342 RID: 4930 RVA: 0x0003AEF0 File Offset: 0x000390F0
			// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
			public unsafe uint m_GateCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount)) = value;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001344 RID: 4932 RVA: 0x0003AF18 File Offset: 0x00039118
			// (set) Token: 0x06001345 RID: 4933 RVA: 0x0000C6C3 File Offset: 0x0000A8C3
			public unsafe Queue<EventDispatcher.EventRecord> m_Queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<EventDispatcher.EventRecord>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000856 RID: 2134
			private static readonly IntPtr NativeFieldInfoPtr_m_GateCount;

			// Token: 0x04000857 RID: 2135
			private static readonly IntPtr NativeFieldInfoPtr_m_Queue;
		}
	}
}
