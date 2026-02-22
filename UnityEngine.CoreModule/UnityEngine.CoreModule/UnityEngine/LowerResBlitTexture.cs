using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000D1 RID: 209
	public class LowerResBlitTexture : Object
	{
		// Token: 0x060011E6 RID: 4582 RVA: 0x0000ADBE File Offset: 0x00008FBE
		// Note: this type is marked as 'beforefieldinit'.
		static LowerResBlitTexture()
		{
			Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LowerResBlitTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
			LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100664542);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0004798C File Offset: 0x00045B8C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerResBlitTextureDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0000ADF7 File Offset: 0x00008FF7
		public LowerResBlitTexture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;
	}
}
