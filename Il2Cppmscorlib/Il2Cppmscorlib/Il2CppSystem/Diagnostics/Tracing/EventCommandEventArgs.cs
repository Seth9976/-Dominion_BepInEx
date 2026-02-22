using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000515 RID: 1301
	public class EventCommandEventArgs : EventArgs
	{
		// Token: 0x06004B27 RID: 19239 RVA: 0x00157DF8 File Offset: 0x00155FF8
		// Note: this type is marked as 'beforefieldinit'.
		static EventCommandEventArgs()
		{
			Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventCommandEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr);
			EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "<Command>k__BackingField");
			EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "<Arguments>k__BackingField");
			EventCommandEventArgs.NativeFieldInfoPtr_eventSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "eventSource");
			EventCommandEventArgs.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "dispatcher");
			EventCommandEventArgs.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "listener");
			EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "perEventSourceSessionId");
			EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "etwSessionId");
			EventCommandEventArgs.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "enable");
			EventCommandEventArgs.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "level");
			EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "matchAnyKeyword");
			EventCommandEventArgs.NativeFieldInfoPtr_nextCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, "nextCommand");
			EventCommandEventArgs.NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674429);
			EventCommandEventArgs.NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674430);
			EventCommandEventArgs.NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674431);
			EventCommandEventArgs.NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674432);
			EventCommandEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr, 100674433);
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x00157F68 File Offset: 0x00156168
		// (set) Token: 0x06004B29 RID: 19241 RVA: 0x00157FA4 File Offset: 0x001561A4
		public unsafe EventCommand Command
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x00157FE4 File Offset: 0x001561E4
		// (set) Token: 0x06004B2B RID: 19243 RVA: 0x00158024 File Offset: 0x00156224
		public unsafe IDictionary<string, string> Arguments
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00158068 File Offset: 0x00156268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373447, XrefRangeEnd = 373451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCommandEventArgs(EventCommand command, IDictionary<string, string> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCommandEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref command;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventSource);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref perEventSourceSessionId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref etwSessionId;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeyword;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCommandEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x0001C340 File Offset: 0x0001A540
		public EventCommandEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x00158130 File Offset: 0x00156330
		// (set) Token: 0x06004B2F RID: 19247 RVA: 0x0001C349 File Offset: 0x0001A549
		public unsafe EventCommand _Command_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Command_k__BackingField)) = value;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x00158158 File Offset: 0x00156358
		// (set) Token: 0x06004B31 RID: 19249 RVA: 0x0001C364 File Offset: 0x0001A564
		public unsafe IDictionary<string, string> _Arguments_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr__Arguments_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004B32 RID: 19250 RVA: 0x00158188 File Offset: 0x00156388
		// (set) Token: 0x06004B33 RID: 19251 RVA: 0x0001C383 File Offset: 0x0001A583
		public unsafe EventSource eventSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_eventSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_eventSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004B34 RID: 19252 RVA: 0x001581B8 File Offset: 0x001563B8
		// (set) Token: 0x06004B35 RID: 19253 RVA: 0x0001C3A2 File Offset: 0x0001A5A2
		public unsafe EventDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004B36 RID: 19254 RVA: 0x001581E8 File Offset: 0x001563E8
		// (set) Token: 0x06004B37 RID: 19255 RVA: 0x0001C3C1 File Offset: 0x0001A5C1
		public unsafe EventListener listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x00158218 File Offset: 0x00156418
		// (set) Token: 0x06004B39 RID: 19257 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		public unsafe int perEventSourceSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_perEventSourceSessionId)) = value;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004B3A RID: 19258 RVA: 0x00158240 File Offset: 0x00156440
		// (set) Token: 0x06004B3B RID: 19259 RVA: 0x0001C3FB File Offset: 0x0001A5FB
		public unsafe int etwSessionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_etwSessionId)) = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x00158268 File Offset: 0x00156468
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x0001C416 File Offset: 0x0001A616
		public unsafe bool enable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_enable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_enable)) = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x00158290 File Offset: 0x00156490
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x0001C431 File Offset: 0x0001A631
		public unsafe EventLevel level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_level)) = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004B40 RID: 19264 RVA: 0x001582B8 File Offset: 0x001564B8
		// (set) Token: 0x06004B41 RID: 19265 RVA: 0x0001C44C File Offset: 0x0001A64C
		public unsafe EventKeywords matchAnyKeyword
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_matchAnyKeyword)) = value;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004B42 RID: 19266 RVA: 0x001582E0 File Offset: 0x001564E0
		// (set) Token: 0x06004B43 RID: 19267 RVA: 0x0001C467 File Offset: 0x0001A667
		public unsafe EventCommandEventArgs nextCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_nextCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCommandEventArgs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCommandEventArgs.NativeFieldInfoPtr_nextCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CBA RID: 15546
		private static readonly IntPtr NativeFieldInfoPtr__Command_k__BackingField;

		// Token: 0x04003CBB RID: 15547
		private static readonly IntPtr NativeFieldInfoPtr__Arguments_k__BackingField;

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeFieldInfoPtr_eventSource;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x04003CBE RID: 15550
		private static readonly IntPtr NativeFieldInfoPtr_listener;

		// Token: 0x04003CBF RID: 15551
		private static readonly IntPtr NativeFieldInfoPtr_perEventSourceSessionId;

		// Token: 0x04003CC0 RID: 15552
		private static readonly IntPtr NativeFieldInfoPtr_etwSessionId;

		// Token: 0x04003CC1 RID: 15553
		private static readonly IntPtr NativeFieldInfoPtr_enable;

		// Token: 0x04003CC2 RID: 15554
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04003CC3 RID: 15555
		private static readonly IntPtr NativeFieldInfoPtr_matchAnyKeyword;

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeFieldInfoPtr_nextCommand;

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeMethodInfoPtr_get_Command_Public_get_EventCommand_0;

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeMethodInfoPtr_set_Command_Internal_set_Void_EventCommand_0;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_IDictionary_2_String_String_0;

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeMethodInfoPtr_set_Arguments_Internal_set_Void_IDictionary_2_String_String_0;

		// Token: 0x04003CC9 RID: 15561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_EventCommand_IDictionary_2_String_String_EventSource_EventListener_Int32_Int32_Boolean_EventLevel_EventKeywords_0;
	}
}
