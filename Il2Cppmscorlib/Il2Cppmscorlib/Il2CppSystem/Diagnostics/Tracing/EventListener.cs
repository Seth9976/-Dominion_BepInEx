using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000514 RID: 1300
	public class EventListener : Object
	{
		// Token: 0x06004B0E RID: 19214 RVA: 0x001579EC File Offset: 0x00155BEC
		// Note: this type is marked as 'beforefieldinit'.
		static EventListener()
		{
			Il2CppClassPointerStore<EventListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventListener>.NativeClassPtr);
			EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSourceCreatedLock");
			EventListener.NativeFieldInfoPtr__EventSourceCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "_EventSourceCreated");
			EventListener.NativeFieldInfoPtr_EventWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "EventWritten");
			EventListener.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "m_Next");
			EventListener.NativeFieldInfoPtr_m_activityFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "m_activityFilter");
			EventListener.NativeFieldInfoPtr_s_Listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_Listeners");
			EventListener.NativeFieldInfoPtr_s_EventSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSources");
			EventListener.NativeFieldInfoPtr_s_CreatingListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_CreatingListener");
			EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventListener>.NativeClassPtr, "s_EventSourceShutdownRegistered");
			EventListener.NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674423);
			EventListener.NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674424);
			EventListener.NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674425);
			EventListener.NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674426);
			EventListener.NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventListener>.NativeClassPtr, 100674427);
		}

		// Token: 0x06004B0F RID: 19215 RVA: 0x00157B34 File Offset: 0x00155D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373323, XrefRangeEnd = 373330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventSourceCreated(EventSource eventSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventListener.NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B10 RID: 19216 RVA: 0x00157B84 File Offset: 0x00155D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373330, XrefRangeEnd = 373333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEventWritten(EventWrittenEventArgs eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventListener.NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B11 RID: 19217 RVA: 0x00157BD4 File Offset: 0x00155DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373398, RefRangeEnd = 373399, XrefRangeStart = 373333, XrefRangeEnd = 373398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddEventSource(EventSource newEventSource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B12 RID: 19218 RVA: 0x00157C0C File Offset: 0x00155E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373399, XrefRangeEnd = 373425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeOnShutdown(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x00157C54 File Offset: 0x00155E54
		public unsafe static Object EventListenersLock
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 373441, RefRangeEnd = 373447, XrefRangeStart = 373425, XrefRangeEnd = 373441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventListener.NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004B14 RID: 19220 RVA: 0x0001C269 File Offset: 0x0001A469
		public EventListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x06004B15 RID: 19221 RVA: 0x00157C88 File Offset: 0x00155E88
		// (set) Token: 0x06004B16 RID: 19222 RVA: 0x0001C272 File Offset: 0x0001A472
		public unsafe static Object s_EventSourceCreatedLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSourceCreatedLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x06004B17 RID: 19223 RVA: 0x00157CB0 File Offset: 0x00155EB0
		// (set) Token: 0x06004B18 RID: 19224 RVA: 0x0001C284 File Offset: 0x0001A484
		public unsafe EventHandler<EventSourceCreatedEventArgs> _EventSourceCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr__EventSourceCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventSourceCreatedEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr__EventSourceCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x06004B19 RID: 19225 RVA: 0x00157CE0 File Offset: 0x00155EE0
		// (set) Token: 0x06004B1A RID: 19226 RVA: 0x0001C2A3 File Offset: 0x0001A4A3
		public unsafe EventHandler<EventWrittenEventArgs> EventWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_EventWritten);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<EventWrittenEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_EventWritten), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x06004B1B RID: 19227 RVA: 0x00157D10 File Offset: 0x00155F10
		// (set) Token: 0x06004B1C RID: 19228 RVA: 0x0001C2C2 File Offset: 0x0001A4C2
		public unsafe EventListener m_Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06004B1D RID: 19229 RVA: 0x00157D40 File Offset: 0x00155F40
		// (set) Token: 0x06004B1E RID: 19230 RVA: 0x0001C2E1 File Offset: 0x0001A4E1
		public unsafe ActivityFilter m_activityFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_activityFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventListener.NativeFieldInfoPtr_m_activityFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06004B1F RID: 19231 RVA: 0x00157D70 File Offset: 0x00155F70
		// (set) Token: 0x06004B20 RID: 19232 RVA: 0x0001C300 File Offset: 0x0001A500
		public unsafe static EventListener s_Listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_Listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_Listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06004B21 RID: 19233 RVA: 0x00157D98 File Offset: 0x00155F98
		// (set) Token: 0x06004B22 RID: 19234 RVA: 0x0001C312 File Offset: 0x0001A512
		public unsafe static List<WeakReference> s_EventSources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x00157DC0 File Offset: 0x00155FC0
		// (set) Token: 0x06004B24 RID: 19236 RVA: 0x0001C324 File Offset: 0x0001A524
		public unsafe static bool s_CreatingListener
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_CreatingListener, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_CreatingListener, (void*)(&value));
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x00157DDC File Offset: 0x00155FDC
		// (set) Token: 0x06004B26 RID: 19238 RVA: 0x0001C332 File Offset: 0x0001A532
		public unsafe static bool s_EventSourceShutdownRegistered
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventListener.NativeFieldInfoPtr_s_EventSourceShutdownRegistered, (void*)(&value));
			}
		}

		// Token: 0x04003CAC RID: 15532
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSourceCreatedLock;

		// Token: 0x04003CAD RID: 15533
		private static readonly IntPtr NativeFieldInfoPtr__EventSourceCreated;

		// Token: 0x04003CAE RID: 15534
		private static readonly IntPtr NativeFieldInfoPtr_EventWritten;

		// Token: 0x04003CAF RID: 15535
		private static readonly IntPtr NativeFieldInfoPtr_m_Next;

		// Token: 0x04003CB0 RID: 15536
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilter;

		// Token: 0x04003CB1 RID: 15537
		private static readonly IntPtr NativeFieldInfoPtr_s_Listeners;

		// Token: 0x04003CB2 RID: 15538
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSources;

		// Token: 0x04003CB3 RID: 15539
		private static readonly IntPtr NativeFieldInfoPtr_s_CreatingListener;

		// Token: 0x04003CB4 RID: 15540
		private static readonly IntPtr NativeFieldInfoPtr_s_EventSourceShutdownRegistered;

		// Token: 0x04003CB5 RID: 15541
		private static readonly IntPtr NativeMethodInfoPtr_OnEventSourceCreated_FamOrAssem_Virtual_New_Void_EventSource_0;

		// Token: 0x04003CB6 RID: 15542
		private static readonly IntPtr NativeMethodInfoPtr_OnEventWritten_FamOrAssem_Virtual_New_Void_EventWrittenEventArgs_0;

		// Token: 0x04003CB7 RID: 15543
		private static readonly IntPtr NativeMethodInfoPtr_AddEventSource_Internal_Static_Void_EventSource_0;

		// Token: 0x04003CB8 RID: 15544
		private static readonly IntPtr NativeMethodInfoPtr_DisposeOnShutdown_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x04003CB9 RID: 15545
		private static readonly IntPtr NativeMethodInfoPtr_get_EventListenersLock_Internal_Static_get_Object_0;
	}
}
