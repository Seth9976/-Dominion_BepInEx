using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009F RID: 159
	public sealed class PointerOutEvent : PointerEventBase<PointerOutEvent>
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x000057FC File Offset: 0x000039FC
		// Note: this type is marked as 'beforefieldinit'.
		static PointerOutEvent()
		{
			Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerOutEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr);
			PointerOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr, 100664125);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00027D74 File Offset: 0x00025F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96499, XrefRangeEnd = 96502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PointerOutEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PointerOutEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerOutEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00005835 File Offset: 0x00003A35
		public PointerOutEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
