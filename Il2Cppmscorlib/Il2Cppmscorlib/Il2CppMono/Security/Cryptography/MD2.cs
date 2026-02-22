using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002C RID: 44
	public class MD2 : HashAlgorithm
	{
		// Token: 0x060002EE RID: 750 RVA: 0x0002D87C File Offset: 0x0002BA7C
		// Note: this type is marked as 'beforefieldinit'.
		static MD2()
		{
			Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "MD2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
			MD2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663686);
			MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663687);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0002D8D4 File Offset: 0x0002BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0002D910 File Offset: 0x0002BB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262834, RefRangeEnd = 262835, XrefRangeStart = 262821, XrefRangeEnd = 262834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD2>(intPtr3) : null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000335B File Offset: 0x0000155B
		public MD2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;
	}
}
