using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000023 RID: 35
	public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute : Attribute
	{
		// Token: 0x060000FF RID: 255 RVA: 0x00002B01 File Offset: 0x00000D01
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeallocateOnJobCompletionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeallocateOnJobCompletionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr);
			NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000196D0 File Offset: 0x000178D0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeallocateOnJobCompletionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002B3A File Offset: 0x00000D3A
		public NativeContainerSupportsDeallocateOnJobCompletionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
