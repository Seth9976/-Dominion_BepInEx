using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030A RID: 778
	public class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060032BF RID: 12991 RVA: 0x000120AA File Offset: 0x000102AA
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA1SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA1SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr, 100671203);
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x000FA6A8 File Offset: 0x000F88A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341045, XrefRangeEnd = 341050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA1SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA1SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA1SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x000120E3 File Offset: 0x000102E3
		public RSAPKCS1SHA1SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
