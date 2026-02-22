using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000057 RID: 87
	public class ExecuteCommandEvent : CommandEventBase<ExecuteCommandEvent>
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x000048A5 File Offset: 0x00002AA5
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteCommandEvent()
		{
			Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ExecuteCommandEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr);
			ExecuteCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr, 100663707);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001C524 File Offset: 0x0001A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93678, XrefRangeEnd = 93681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteCommandEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteCommandEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000048DE File Offset: 0x00002ADE
		public ExecuteCommandEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
