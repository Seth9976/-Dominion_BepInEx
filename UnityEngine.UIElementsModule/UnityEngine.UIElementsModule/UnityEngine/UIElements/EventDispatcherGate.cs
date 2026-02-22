using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000B RID: 11
	public sealed class EventDispatcherGate : ValueType
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000D59C File Offset: 0x0000B79C
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcherGate()
		{
			Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatcherGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr);
			EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, "m_Dispatcher");
			EventDispatcherGate.NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100663314);
			EventDispatcherGate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100663315);
			EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100663316);
			EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100663317);
			EventDispatcherGate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr, 100663318);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000D644 File Offset: 0x0000B844
		[CallerCount(0)]
		public unsafe EventDispatcherGate(EventDispatcher d)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000D694 File Offset: 0x0000B894
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91039, RefRangeEnd = 91043, XrefRangeStart = 91034, XrefRangeEnd = 91039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91043, XrefRangeEnd = 91044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(EventDispatcherGate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000D724 File Offset: 0x0000B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91044, XrefRangeEnd = 91048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000D778 File Offset: 0x0000B978
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcherGate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002350 File Offset: 0x00000550
		public EventDispatcherGate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002359 File Offset: 0x00000559
		public EventDispatcherGate()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcherGate>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000236B File Offset: 0x0000056B
		public unsafe EventDispatcher m_Dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcherGate.NativeFieldInfoPtr_m_Dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000D7EC File Offset: 0x0000B9EC
		public static bool operator ==(EventDispatcherGate left, EventDispatcherGate right)
		{
			return left.Equals(right);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000D808 File Offset: 0x0000BA08
		public static bool operator !=(EventDispatcherGate left, EventDispatcherGate right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_m_Dispatcher;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventDispatcher_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EventDispatcherGate_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
