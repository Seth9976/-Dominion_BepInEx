using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000061 RID: 97
	public class EventCallbackListPool : Object
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x0001EF00 File Offset: 0x0001D100
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackListPool()
		{
			Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackListPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr);
			EventCallbackListPool.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, "m_Stack");
			EventCallbackListPool.NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100663805);
			EventCallbackListPool.NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100663806);
			EventCallbackListPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr, 100663807);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0001EF80 File Offset: 0x0001D180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94474, XrefRangeEnd = 94480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList Get(EventCallbackList initializer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94480, XrefRangeEnd = 94487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(EventCallbackList element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0001F014 File Offset: 0x0001D214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94487, XrefRangeEnd = 94494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackListPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackListPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackListPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004C3F File Offset: 0x00002E3F
		public EventCallbackListPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001F050 File Offset: 0x0001D250
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00004C48 File Offset: 0x00002E48
		public unsafe Stack<EventCallbackList> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackListPool.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<EventCallbackList>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackListPool.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_EventCallbackList_EventCallbackList_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_EventCallbackList_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
