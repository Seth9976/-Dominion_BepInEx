using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000319 RID: 793
	public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060033A3 RID: 13219 RVA: 0x000126D8 File Offset: 0x000108D8
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SignatureDeformatter()
		{
			Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr);
			RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr, 100671311);
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000FD870 File Offset: 0x000FBA70
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00012711 File Offset: 0x00010911
		public RSAPKCS1SignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
