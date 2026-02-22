using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A4 RID: 164
	[StructLayout(2)]
	public struct EventDebuggerLogExecuteDefaultAction
	{
		// Token: 0x0600088B RID: 2187 RVA: 0x00028390 File Offset: 0x00026590
		// Note: this type is marked as 'beforefieldinit'.
		static EventDebuggerLogExecuteDefaultAction()
		{
			Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDebuggerLogExecuteDefaultAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr);
			EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, 100664139);
			EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, 100664140);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000283E8 File Offset: 0x000265E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDebuggerLogExecuteDefaultAction(EventBase evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr__ctor_Public_Void_EventBase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00028420 File Offset: 0x00026620
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDebuggerLogExecuteDefaultAction.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000058FF File Offset: 0x00003AFF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventDebuggerLogExecuteDefaultAction>.NativeClassPtr, ref this));
		}

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventBase_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
