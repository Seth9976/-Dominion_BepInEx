using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity
{
	// Token: 0x02000162 RID: 354
	public sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x0000AFA3 File Offset: 0x000091A3
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowStub()
		{
			Il2CppClassPointerStore<ThrowStub>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Unity", "ThrowStub");
			ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowStub>.NativeClassPtr, 100666288);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00061434 File Offset: 0x0005F634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57693, XrefRangeEnd = 57698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowStub.NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0000AFD2 File Offset: 0x000091D2
		public ThrowStub(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Public_Static_Void_0;
	}
}
