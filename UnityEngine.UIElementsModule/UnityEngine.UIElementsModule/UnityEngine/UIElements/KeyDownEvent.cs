using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000072 RID: 114
	public class KeyDownEvent : KeyboardEventBase<KeyDownEvent>
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x00004EEA File Offset: 0x000030EA
		// Note: this type is marked as 'beforefieldinit'.
		static KeyDownEvent()
		{
			Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "KeyDownEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr);
			KeyDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr, 100663884);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000212DC File Offset: 0x0001F4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94942, XrefRangeEnd = 94945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyDownEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyDownEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyDownEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00004F23 File Offset: 0x00003123
		public KeyDownEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00021318 File Offset: 0x0001F518
		public void GetEquivalentImguiEvent(Event outImguiEvent)
		{
			bool flag = base.imguiEvent != null;
			if (flag)
			{
				outImguiEvent.CopyFrom(base.imguiEvent);
			}
			else
			{
				outImguiEvent.type = EventType.KeyDown;
				outImguiEvent.modifiers = base.modifiers;
				outImguiEvent.character = base.character;
				outImguiEvent.keyCode = base.keyCode;
			}
		}

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
