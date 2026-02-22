using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000056 RID: 86
	public class ValidateCommandEvent : CommandEventBase<ValidateCommandEvent>
	{
		// Token: 0x06000550 RID: 1360 RVA: 0x00004863 File Offset: 0x00002A63
		// Note: this type is marked as 'beforefieldinit'.
		static ValidateCommandEvent()
		{
			Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ValidateCommandEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr);
			ValidateCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr, 100663706);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93675, XrefRangeEnd = 93678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidateCommandEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidateCommandEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidateCommandEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0000489C File Offset: 0x00002A9C
		public ValidateCommandEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
