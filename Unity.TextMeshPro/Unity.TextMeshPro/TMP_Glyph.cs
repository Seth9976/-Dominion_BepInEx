using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace TMPro
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class TMP_Glyph : TMP_TextElement_Legacy
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x0001B2FC File Offset: 0x000194FC
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Glyph()
		{
			Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Glyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr);
			TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663808);
			TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663809);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001B354 File Offset: 0x00019554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140465, XrefRangeEnd = 140469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_Glyph Clone(TMP_Glyph source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Glyph>(intPtr3) : null;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001B398 File Offset: 0x00019598
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Glyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Glyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00004AAD File Offset: 0x00002CAD
		public TMP_Glyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
