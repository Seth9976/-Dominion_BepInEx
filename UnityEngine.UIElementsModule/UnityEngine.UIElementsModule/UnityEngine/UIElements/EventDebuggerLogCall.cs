using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A2 RID: 162
	[StructLayout(2)]
	public struct EventDebuggerLogCall
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x00028210 File Offset: 0x00026410
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebuggerLogCall()
		{
			Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebuggerLogCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr);
			EventDebuggerLogCall.NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, 100664135);
			EventDebuggerLogCall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, 100664136);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00028268 File Offset: 0x00026468
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDebuggerLogCall(Delegate callback, EventBase evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogCall.NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000282B0 File Offset: 0x000264B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogCall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000058DB File Offset: 0x00003ADB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDebuggerLogCall>.NativeClassPtr, ref this));
		}

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Delegate_EventBase_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
