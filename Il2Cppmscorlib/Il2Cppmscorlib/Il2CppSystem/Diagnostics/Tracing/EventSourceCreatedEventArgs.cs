using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000516 RID: 1302
	public class EventSourceCreatedEventArgs : EventArgs
	{
		// Token: 0x06004B44 RID: 19268 RVA: 0x00158310 File Offset: 0x00156510
		// Note: this type is marked as 'beforefieldinit'.
		static EventSourceCreatedEventArgs()
		{
			Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceCreatedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr);
			EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, "<EventSource>k__BackingField");
			EventSourceCreatedEventArgs.NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, 100674434);
			EventSourceCreatedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr, 100674435);
		}

		// Token: 0x170012D6 RID: 4822
		// (set) Token: 0x06004B45 RID: 19269 RVA: 0x0015837C File Offset: 0x0015657C
		public unsafe EventSource EventSource
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceCreatedEventArgs.NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x001583C0 File Offset: 0x001565C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 373455, RefRangeEnd = 373456, XrefRangeStart = 373451, XrefRangeEnd = 373455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventSourceCreatedEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventSourceCreatedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventSourceCreatedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0001C486 File Offset: 0x0001A686
		public EventSourceCreatedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004B48 RID: 19272 RVA: 0x001583FC File Offset: 0x001565FC
		// (set) Token: 0x06004B49 RID: 19273 RVA: 0x0001C48F File Offset: 0x0001A68F
		public unsafe EventSource _EventSource_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventSourceCreatedEventArgs.NativeFieldInfoPtr__EventSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003CCA RID: 15562
		private static readonly IntPtr NativeFieldInfoPtr__EventSource_k__BackingField;

		// Token: 0x04003CCB RID: 15563
		private static readonly IntPtr NativeMethodInfoPtr_set_EventSource_Internal_set_Void_EventSource_0;

		// Token: 0x04003CCC RID: 15564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
