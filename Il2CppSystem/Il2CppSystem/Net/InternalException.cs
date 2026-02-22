using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CC RID: 204
	public class InternalException : SystemException
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00006AF3 File Offset: 0x00004CF3
		// Note: this type is marked as 'beforefieldinit'.
		static InternalException()
		{
			Il2CppClassPointerStore<InternalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "InternalException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalException>.NativeClassPtr);
			InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalException>.NativeClassPtr, 100664977);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0003D364 File Offset: 0x0003B564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 45967, RefRangeEnd = 45968, XrefRangeStart = 45966, XrefRangeEnd = 45967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00006B2C File Offset: 0x00004D2C
		public InternalException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
