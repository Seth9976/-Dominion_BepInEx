using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000302 RID: 770
	public class SHA256 : HashAlgorithm
	{
		// Token: 0x0600324B RID: 12875 RVA: 0x000F8AEC File Offset: 0x000F6CEC
		// Note: this type is marked as 'beforefieldinit'.
		static SHA256()
		{
			Il2CppClassPointerStore<SHA256>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA256");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA256>.NativeClassPtr);
			SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100671140);
			SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA256>.NativeClassPtr, 100671141);
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000F8B44 File Offset: 0x000F6D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340592, XrefRangeEnd = 340593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA256()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA256>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000F8B80 File Offset: 0x000F6D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340607, RefRangeEnd = 340608, XrefRangeStart = 340593, XrefRangeEnd = 340607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA256 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA256.NativeMethodInfoPtr_Create_Public_Static_SHA256_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA256>(intPtr3) : null;
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x00011E29 File Offset: 0x00010029
		public SHA256(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA256_0;
	}
}
