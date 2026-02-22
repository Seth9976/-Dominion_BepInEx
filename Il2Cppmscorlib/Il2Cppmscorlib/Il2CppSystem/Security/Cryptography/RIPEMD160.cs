using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FB RID: 763
	public class RIPEMD160 : HashAlgorithm
	{
		// Token: 0x060031E0 RID: 12768 RVA: 0x000F7340 File Offset: 0x000F5540
		// Note: this type is marked as 'beforefieldinit'.
		static RIPEMD160()
		{
			Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RIPEMD160");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr);
			RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100671094);
			RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr, 100671095);
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000F7398 File Offset: 0x000F5598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340216, XrefRangeEnd = 340217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RIPEMD160()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RIPEMD160>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000F73D4 File Offset: 0x000F55D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340231, RefRangeEnd = 340232, XrefRangeStart = 340217, XrefRangeEnd = 340231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RIPEMD160 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RIPEMD160.NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RIPEMD160>(intPtr3) : null;
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00011B38 File Offset: 0x0000FD38
		public RIPEMD160(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RIPEMD160_0;
	}
}
