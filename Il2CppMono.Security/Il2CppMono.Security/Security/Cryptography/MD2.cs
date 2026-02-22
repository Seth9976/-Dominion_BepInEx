using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002A RID: 42
	public class MD2 : HashAlgorithm
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000B558 File Offset: 0x00009758
		// Note: this type is marked as 'beforefieldinit'.
		static MD2()
		{
			Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
			MD2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663575);
			MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663576);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10278, XrefRangeEnd = 10279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MD2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000B5EC File Offset: 0x000097EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10279, XrefRangeEnd = 10292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD2>(intPtr3) : null;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002EB0 File Offset: 0x000010B0
		public MD2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;
	}
}
