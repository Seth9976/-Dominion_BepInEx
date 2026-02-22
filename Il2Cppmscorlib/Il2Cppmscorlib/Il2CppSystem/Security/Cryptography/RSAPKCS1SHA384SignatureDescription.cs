using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030C RID: 780
	public class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription
	{
		// Token: 0x060032C5 RID: 12997 RVA: 0x0001212E File Offset: 0x0001032E
		// Note: this type is marked as 'beforefieldinit'.
		static RSAPKCS1SHA384SignatureDescription()
		{
			Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAPKCS1SHA384SignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr);
			RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr, 100671205);
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000FA720 File Offset: 0x000F8920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341055, XrefRangeEnd = 341060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RSAPKCS1SHA384SignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAPKCS1SHA384SignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RSAPKCS1SHA384SignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00012167 File Offset: 0x00010367
		public RSAPKCS1SHA384SignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
