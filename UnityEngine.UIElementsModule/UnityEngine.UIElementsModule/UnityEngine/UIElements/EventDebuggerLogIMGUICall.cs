using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A3 RID: 163
	[StructLayout(2)]
	public struct EventDebuggerLogIMGUICall
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x000282D8 File Offset: 0x000264D8
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebuggerLogIMGUICall()
		{
			Il2CppClassPointerStore<EventDebuggerLogIMGUICall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebuggerLogIMGUICall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebuggerLogIMGUICall>.NativeClassPtr);
			EventDebuggerLogIMGUICall.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogIMGUICall>.NativeClassPtr, 100664137);
			EventDebuggerLogIMGUICall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogIMGUICall>.NativeClassPtr, 100664138);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00028330 File Offset: 0x00026530
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDebuggerLogIMGUICall(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogIMGUICall.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00028368 File Offset: 0x00026568
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogIMGUICall.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000058ED File Offset: 0x00003AED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDebuggerLogIMGUICall>.NativeClassPtr, ref this));
		}

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventBase_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
