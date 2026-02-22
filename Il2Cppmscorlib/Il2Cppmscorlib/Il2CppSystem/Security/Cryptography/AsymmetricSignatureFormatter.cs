using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D7 RID: 727
	public class AsymmetricSignatureFormatter : Object
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x000110AD File Offset: 0x0000F2AD
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricSignatureFormatter()
		{
			Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "AsymmetricSignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr);
			AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr, 100670904);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000F1540 File Offset: 0x000EF740
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricSignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricSignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricSignatureFormatter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x000110E6 File Offset: 0x0000F2E6
		public AsymmetricSignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
