using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000EE RID: 238
	[Serializable]
	public class ThreadStaticAttribute : Attribute
	{
		// Token: 0x060010A8 RID: 4264 RVA: 0x00006132 File Offset: 0x00004332
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadStaticAttribute()
		{
			Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThreadStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr);
			ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr, 100666161);
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0006F5D4 File Offset: 0x0006D7D4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0000616B File Offset: 0x0000436B
		public ThreadStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
