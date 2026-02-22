using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x0200052A RID: 1322
	[Serializable]
	public sealed class UnmanagedMarshal : Object
	{
		// Token: 0x06004D41 RID: 19777 RVA: 0x0001D323 File Offset: 0x0001B523
		// Note: this type is marked as 'beforefieldinit'.
		static UnmanagedMarshal()
		{
			Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "UnmanagedMarshal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr);
			UnmanagedMarshal.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr, 100674544);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x0015CE9C File Offset: 0x0015B09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375072, XrefRangeEnd = 375075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnmanagedMarshal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnmanagedMarshal.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x0001D35C File Offset: 0x0001B55C
		public UnmanagedMarshal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E27 RID: 15911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
