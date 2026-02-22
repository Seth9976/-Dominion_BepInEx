using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000073 RID: 115
	public class KeyUpEvent : KeyboardEventBase<KeyUpEvent>
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x00004F2C File Offset: 0x0000312C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyUpEvent()
		{
			Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyUpEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr);
			KeyUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr, 100663885);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00021378 File Offset: 0x0001F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94945, XrefRangeEnd = 94948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyUpEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyUpEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyUpEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00004F65 File Offset: 0x00003165
		public KeyUpEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
