using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030D RID: 781
	public class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060032C8 RID: 13000 RVA: 0x00012170 File Offset: 0x00010370
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA512SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA512SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr, 100671206);
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x000FA75C File Offset: 0x000F895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341060, XrefRangeEnd = 341065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA512SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA512SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA512SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x000121A9 File Offset: 0x000103A9
		public RSAPKCS1SHA512SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
