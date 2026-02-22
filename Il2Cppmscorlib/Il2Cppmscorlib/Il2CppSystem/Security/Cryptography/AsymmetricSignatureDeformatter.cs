using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D6 RID: 726
	public class AsymmetricSignatureDeformatter : Object
	{
		// Token: 0x06003041 RID: 12353 RVA: 0x0001106B File Offset: 0x0000F26B
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureDeformatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr);
			AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr, 100670903);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000F1504 File Offset: 0x000EF704
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureDeformatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000110A4 File Offset: 0x0000F2A4
		public AsymmetricSignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
