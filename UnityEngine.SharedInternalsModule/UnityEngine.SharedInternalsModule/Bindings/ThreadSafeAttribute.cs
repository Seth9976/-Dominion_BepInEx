using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000016 RID: 22
	public class ThreadSafeAttribute : NativeMethodAttribute
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000256C File Offset: 0x0000076C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeAttribute()
		{
			Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "ThreadSafeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr);
			ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003EEC File Offset: 0x000020EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58942, XrefRangeEnd = 58943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadSafeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000025A5 File Offset: 0x000007A5
		public ThreadSafeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
