using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000152 RID: 338
	public class __ComObject : Object
	{
		// Token: 0x06001731 RID: 5937 RVA: 0x00008309 File Offset: 0x00006509
		// Note: this type is marked as 'beforefieldinit'.
		static __ComObject()
		{
			Il2CppClassPointerStore<__ComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__ComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__ComObject>.NativeClassPtr);
			__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__ComObject>.NativeClassPtr, 100667172);
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0008A2DC File Offset: 0x000884DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309570, XrefRangeEnd = 309576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __ComObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__ComObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__ComObject.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00008342 File Offset: 0x00006542
		public __ComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001580 RID: 5504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}
