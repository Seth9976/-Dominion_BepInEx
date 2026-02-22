using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002E RID: 46
	public class MD4 : HashAlgorithm
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0002DD64 File Offset: 0x0002BF64
		// Note: this type is marked as 'beforefieldinit'.
		static MD4()
		{
			Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
			MD4.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663695);
			MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663696);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0002DDBC File Offset: 0x0002BFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD4()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD4>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262887, RefRangeEnd = 262888, XrefRangeStart = 262871, XrefRangeEnd = 262887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD4>(intPtr3) : null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003416 File Offset: 0x00001616
		public MD4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;
	}
}
