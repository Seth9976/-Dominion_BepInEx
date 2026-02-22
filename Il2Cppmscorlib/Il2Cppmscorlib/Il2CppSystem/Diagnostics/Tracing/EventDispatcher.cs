using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051F RID: 1311
	public class EventDispatcher : Object
	{
		// Token: 0x06004BD2 RID: 19410 RVA: 0x0015A128 File Offset: 0x00158328
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcher()
		{
			Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr);
			EventDispatcher.NativeFieldInfoPtr_m_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Listener");
			EventDispatcher.NativeFieldInfoPtr_m_EventEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_EventEnabled");
			EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_activityFilteringEnabled");
			EventDispatcher.NativeFieldInfoPtr_m_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Next");
			EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100674512);
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x0015A1BC File Offset: 0x001583BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373900, XrefRangeEnd = 373901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDispatcher(EventDispatcher next, Il2CppStructArray<bool> eventEnabled, EventListener listener)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventEnabled);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x0001C8BE File Offset: 0x0001AABE
		public EventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0015A22C File Offset: 0x0015842C
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x0001C8C7 File Offset: 0x0001AAC7
		public unsafe EventListener m_Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0015A25C File Offset: 0x0015845C
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x0001C8E6 File Offset: 0x0001AAE6
		public unsafe Il2CppStructArray<bool> m_EventEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_EventEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_EventEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x0015A28C File Offset: 0x0015848C
		// (set) Token: 0x06004BDA RID: 19418 RVA: 0x0001C905 File Offset: 0x0001AB05
		public unsafe bool m_activityFilteringEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_activityFilteringEnabled)) = value;
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x0015A2B4 File Offset: 0x001584B4
		// (set) Token: 0x06004BDC RID: 19420 RVA: 0x0001C920 File Offset: 0x0001AB20
		public unsafe EventDispatcher m_Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeFieldInfoPtr_m_Listener;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeFieldInfoPtr_m_EventEnabled;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeFieldInfoPtr_m_activityFilteringEnabled;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeFieldInfoPtr_m_Next;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventDispatcher_Il2CppStructArray_1_Boolean_EventListener_0;
	}
}
