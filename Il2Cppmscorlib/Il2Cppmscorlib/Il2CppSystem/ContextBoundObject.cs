using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008F RID: 143
	[Serializable]
	public class ContextBoundObject : MarshalByRefObject
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x000048C3 File Offset: 0x00002AC3
		// Note: this type is marked as 'beforefieldinit'.
		static ContextBoundObject()
		{
			Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextBoundObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr);
			ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr, 100664650);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0004820C File Offset: 0x0004640C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextBoundObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextBoundObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextBoundObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x000048FC File Offset: 0x00002AFC
		public ContextBoundObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
