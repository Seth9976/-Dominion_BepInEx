using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030E RID: 782
	public class DSASignatureDescription : SignatureDescription
	{
		// Token: 0x060032CB RID: 13003 RVA: 0x000121B2 File Offset: 0x000103B2
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureDescription()
		{
			Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr);
			DSASignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr, 100671207);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x000FA798 File Offset: 0x000F8998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341065, XrefRangeEnd = 341074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x000121EB File Offset: 0x000103EB
		public DSASignatureDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
