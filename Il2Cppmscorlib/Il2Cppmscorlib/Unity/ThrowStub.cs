using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity
{
	// Token: 0x0200052C RID: 1324
	public sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x06004D51 RID: 19793 RVA: 0x0001D36E File Offset: 0x0001B56E
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowStub()
		{
			Il2CppClassPointerStore<ThrowStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Unity", "ThrowStub");
			ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowStub>.NativeClassPtr, 100674556);
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x0015D330 File Offset: 0x0015B530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375108, XrefRangeEnd = 375113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x0001D39D File Offset: 0x0001B59D
		public ThrowStub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E33 RID: 15923
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0;
	}
}
