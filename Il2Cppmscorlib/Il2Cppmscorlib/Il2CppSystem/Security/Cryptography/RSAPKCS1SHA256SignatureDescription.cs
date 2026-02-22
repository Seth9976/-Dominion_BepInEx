using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030B RID: 779
	public class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060032C2 RID: 12994 RVA: 0x000120EC File Offset: 0x000102EC
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA256SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA256SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr, 100671204);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000FA6E4 File Offset: 0x000F88E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341050, XrefRangeEnd = 341055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA256SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA256SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA256SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00012125 File Offset: 0x00010325
		public RSAPKCS1SHA256SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
