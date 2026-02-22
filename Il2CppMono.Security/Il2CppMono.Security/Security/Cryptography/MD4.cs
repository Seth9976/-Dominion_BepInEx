using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002C RID: 44
	public class MD4 : HashAlgorithm
	{
		// Token: 0x06000230 RID: 560 RVA: 0x0000BA40 File Offset: 0x00009C40
		// Note: this type is marked as 'beforefieldinit'.
		static MD4()
		{
			Il2CppClassPointerStore<MD4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD4>.NativeClassPtr);
			MD4.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663584);
			MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD4>.NativeClassPtr, 100663585);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000BA98 File Offset: 0x00009C98
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

		// Token: 0x06000232 RID: 562 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 10348, RefRangeEnd = 10351, XrefRangeStart = 10332, XrefRangeEnd = 10348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD4 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD4.NativeMethodInfoPtr_Create_Public_Static_MD4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD4>(intPtr3) : null;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002F6B File Offset: 0x0000116B
		public MD4(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD4_0;
	}
}
