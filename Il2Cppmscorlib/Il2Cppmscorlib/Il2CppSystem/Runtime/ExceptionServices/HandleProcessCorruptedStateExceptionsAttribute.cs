using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices
{
	// Token: 0x0200040C RID: 1036
	public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
	{
		// Token: 0x0600415F RID: 16735 RVA: 0x00018D84 File Offset: 0x00016F84
		// Note: this type is marked as 'beforefieldinit'.
		static HandleProcessCorruptedStateExceptionsAttribute()
		{
			Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "HandleProcessCorruptedStateExceptionsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr);
			HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr, 100672816);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0012E3C0 File Offset: 0x0012C5C0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandleProcessCorruptedStateExceptionsAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandleProcessCorruptedStateExceptionsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00018DBD File Offset: 0x00016FBD
		public HandleProcessCorruptedStateExceptionsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003560 RID: 13664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
