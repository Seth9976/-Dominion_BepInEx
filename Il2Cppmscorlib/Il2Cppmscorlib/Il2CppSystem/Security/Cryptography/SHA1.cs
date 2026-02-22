using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000300 RID: 768
	public class SHA1 : HashAlgorithm
	{
		// Token: 0x06003234 RID: 12852 RVA: 0x000F85B4 File Offset: 0x000F67B4
		// Note: this type is marked as 'beforefieldinit'.
		static SHA1()
		{
			Il2CppClassPointerStore<SHA1>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SHA1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHA1>.NativeClassPtr);
			SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100671129);
			SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHA1>.NativeClassPtr, 100671130);
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x000F860C File Offset: 0x000F680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SHA1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SHA1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000F8648 File Offset: 0x000F6848
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 340534, RefRangeEnd = 340541, XrefRangeStart = 340517, XrefRangeEnd = 340534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SHA1 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SHA1.NativeMethodInfoPtr_Create_Public_Static_SHA1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SHA1>(intPtr3) : null;
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00011D9F File Offset: 0x0000FF9F
		public SHA1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SHA1_0;
	}
}
