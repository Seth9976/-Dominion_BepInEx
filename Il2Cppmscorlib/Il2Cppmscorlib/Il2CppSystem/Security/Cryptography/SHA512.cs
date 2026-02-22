using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000306 RID: 774
	public class SHA512 : HashAlgorithm
	{
		// Token: 0x0600328B RID: 12939 RVA: 0x000F9AF4 File Offset: 0x000F7CF4
		// Note: this type is marked as 'beforefieldinit'.
		static SHA512()
		{
			Il2CppClassPointerStore<SHA512>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA512");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA512>.NativeClassPtr);
			SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100671178);
			SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA512>.NativeClassPtr, 100671179);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x000F9B4C File Offset: 0x000F7D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340886, XrefRangeEnd = 340887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA512()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA512>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x000F9B88 File Offset: 0x000F7D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340901, RefRangeEnd = 340903, XrefRangeStart = 340887, XrefRangeEnd = 340901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA512 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA512.NativeMethodInfoPtr_Create_Public_Static_SHA512_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA512>(intPtr3) : null;
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x00011F61 File Offset: 0x00010161
		public SHA512(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA512_0;
	}
}
