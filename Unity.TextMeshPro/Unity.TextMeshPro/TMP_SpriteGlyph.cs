using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000055 RID: 85
	[Serializable]
	public class TMP_SpriteGlyph : Glyph
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00029740 File Offset: 0x00027940
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SpriteGlyph()
		{
			Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteGlyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr);
			TMP_SpriteGlyph.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr, "sprite");
			TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr, 100664261);
			TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr, 100664262);
			TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr, 100664263);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000297C0 File Offset: 0x000279C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145432, XrefRangeEnd = 145433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteGlyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000297FC File Offset: 0x000279FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145433, XrefRangeEnd = 145439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metrics;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002987C File Offset: 0x00027A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145439, XrefRangeEnd = 145445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SpriteGlyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SpriteGlyph>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metrics;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000681C File Offset: 0x00004A1C
		public TMP_SpriteGlyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00029910 File Offset: 0x00027B10
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00006825 File Offset: 0x00004A25
		public unsafe Sprite sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteGlyph.NativeFieldInfoPtr_sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SpriteGlyph.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_sprite;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_Sprite_0;
	}
}
