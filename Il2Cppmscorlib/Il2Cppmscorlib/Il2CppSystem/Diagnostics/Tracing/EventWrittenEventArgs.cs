using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000517 RID: 1303
	public class EventWrittenEventArgs : EventArgs
	{
		// Token: 0x06004B4A RID: 19274 RVA: 0x0015842C File Offset: 0x0015662C
		// Note: this type is marked as 'beforefieldinit'.
		static EventWrittenEventArgs()
		{
			Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventWrittenEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr);
			EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<EventId>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<RelatedActivityId>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "<Payload>k__BackingField");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_message");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_eventName");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_eventSource");
			EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, "m_payloadNames");
			EventWrittenEventArgs.NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674436);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674437);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674438);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674439);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674440);
			EventWrittenEventArgs.NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674441);
			EventWrittenEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr, 100674442);
		}

		// Token: 0x170012DE RID: 4830
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x00158574 File Offset: 0x00156774
		public unsafe string EventName
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012DF RID: 4831
		// (set) Token: 0x06004B4C RID: 19276 RVA: 0x001585B8 File Offset: 0x001567B8
		public unsafe int EventId
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (set) Token: 0x06004B4D RID: 19277 RVA: 0x001585F8 File Offset: 0x001567F8
		public unsafe Guid RelatedActivityId
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (set) Token: 0x06004B4E RID: 19278 RVA: 0x00158638 File Offset: 0x00156838
		public unsafe ReadOnlyCollection<Object> Payload
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (set) Token: 0x06004B4F RID: 19279 RVA: 0x0015867C File Offset: 0x0015687C
		public unsafe ReadOnlyCollection<string> PayloadNames
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (set) Token: 0x06004B50 RID: 19280 RVA: 0x001586C0 File Offset: 0x001568C0
		public unsafe string Message
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00158704 File Offset: 0x00156904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 373460, RefRangeEnd = 373463, XrefRangeStart = 373456, XrefRangeEnd = 373460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWrittenEventArgs(EventSource eventSource)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWrittenEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWrittenEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x0001C4AE File Offset: 0x0001A6AE
		public EventWrittenEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004B53 RID: 19283 RVA: 0x00158750 File Offset: 0x00156950
		// (set) Token: 0x06004B54 RID: 19284 RVA: 0x0001C4B7 File Offset: 0x0001A6B7
		public unsafe int _EventId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x00158778 File Offset: 0x00156978
		// (set) Token: 0x06004B56 RID: 19286 RVA: 0x0001C4D2 File Offset: 0x0001A6D2
		public unsafe Guid _RelatedActivityId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__RelatedActivityId_k__BackingField)) = value;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004B57 RID: 19287 RVA: 0x001587A0 File Offset: 0x001569A0
		// (set) Token: 0x06004B58 RID: 19288 RVA: 0x0001C4ED File Offset: 0x0001A6ED
		public unsafe ReadOnlyCollection<Object> _Payload_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr__Payload_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x001587D0 File Offset: 0x001569D0
		// (set) Token: 0x06004B5A RID: 19290 RVA: 0x0001C50C File Offset: 0x0001A70C
		public unsafe string m_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004B5B RID: 19291 RVA: 0x001587F8 File Offset: 0x001569F8
		// (set) Token: 0x06004B5C RID: 19292 RVA: 0x0001C52B File Offset: 0x0001A72B
		public unsafe string m_eventName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x00158820 File Offset: 0x00156A20
		// (set) Token: 0x06004B5E RID: 19294 RVA: 0x0001C54A File Offset: 0x0001A74A
		public unsafe EventSource m_eventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x00158850 File Offset: 0x00156A50
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x0001C569 File Offset: 0x0001A769
		public unsafe ReadOnlyCollection<string> m_payloadNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventWrittenEventArgs.NativeFieldInfoPtr_m_payloadNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CCD RID: 15565
		private static readonly IntPtr NativeFieldInfoPtr__EventId_k__BackingField;

		// Token: 0x04003CCE RID: 15566
		private static readonly IntPtr NativeFieldInfoPtr__RelatedActivityId_k__BackingField;

		// Token: 0x04003CCF RID: 15567
		private static readonly IntPtr NativeFieldInfoPtr__Payload_k__BackingField;

		// Token: 0x04003CD0 RID: 15568
		private static readonly IntPtr NativeFieldInfoPtr_m_message;

		// Token: 0x04003CD1 RID: 15569
		private static readonly IntPtr NativeFieldInfoPtr_m_eventName;

		// Token: 0x04003CD2 RID: 15570
		private static readonly IntPtr NativeFieldInfoPtr_m_eventSource;

		// Token: 0x04003CD3 RID: 15571
		private static readonly IntPtr NativeFieldInfoPtr_m_payloadNames;

		// Token: 0x04003CD4 RID: 15572
		private static readonly IntPtr NativeMethodInfoPtr_set_EventName_Internal_set_Void_String_0;

		// Token: 0x04003CD5 RID: 15573
		private static readonly IntPtr NativeMethodInfoPtr_set_EventId_Internal_set_Void_Int32_0;

		// Token: 0x04003CD6 RID: 15574
		private static readonly IntPtr NativeMethodInfoPtr_set_RelatedActivityId_Internal_set_Void_Guid_0;

		// Token: 0x04003CD7 RID: 15575
		private static readonly IntPtr NativeMethodInfoPtr_set_Payload_Internal_set_Void_ReadOnlyCollection_1_Object_0;

		// Token: 0x04003CD8 RID: 15576
		private static readonly IntPtr NativeMethodInfoPtr_set_PayloadNames_Internal_set_Void_ReadOnlyCollection_1_String_0;

		// Token: 0x04003CD9 RID: 15577
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Internal_set_Void_String_0;

		// Token: 0x04003CDA RID: 15578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventSource_0;
	}
}
