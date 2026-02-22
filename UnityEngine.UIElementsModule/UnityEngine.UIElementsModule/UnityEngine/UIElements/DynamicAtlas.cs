using System;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F6 RID: 246
	public class DynamicAtlas : AtlasBase
	{
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0000873C File Offset: 0x0000693C
		public bool isInitialized
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00008749 File Offset: 0x00006949
		public override void OnAssignedToPanel(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00008756 File Offset: 0x00006956
		public override void OnRemovedFromPanel(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00008763 File Offset: 0x00006963
		public override void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00008770 File Offset: 0x00006970
		public void InitPages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0000877D File Offset: 0x0000697D
		public void DestroyPages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0000878A File Offset: 0x0000698A
		public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00008797 File Offset: 0x00006997
		public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000087A4 File Offset: 0x000069A4
		public override void OnUpdateDynamicTextures(IPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0003425C File Offset: 0x0003245C
		public static bool IsTextureFormatSupported(TextureFormat format)
		{
			switch (format)
			{
			case TextureFormat.Alpha8:
			case TextureFormat.ARGB4444:
			case TextureFormat.RGB24:
			case TextureFormat.RGBA32:
			case TextureFormat.ARGB32:
			case TextureFormat.RGB565:
			case TextureFormat.R16:
			case TextureFormat.DXT1:
			case TextureFormat.DXT5:
			case TextureFormat.RGBA4444:
			case TextureFormat.BGRA32:
			case TextureFormat.BC7:
			case TextureFormat.BC4:
			case TextureFormat.BC5:
			case TextureFormat.DXT1Crunched:
			case TextureFormat.DXT5Crunched:
			case TextureFormat.PVRTC_RGB2:
			case TextureFormat.PVRTC_RGBA2:
			case TextureFormat.PVRTC_RGB4:
			case TextureFormat.PVRTC_RGBA4:
			case TextureFormat.ETC_RGB4:
			case TextureFormat.EAC_R:
			case TextureFormat.EAC_R_SIGNED:
			case TextureFormat.EAC_RG:
			case TextureFormat.EAC_RG_SIGNED:
			case TextureFormat.ETC2_RGB:
			case TextureFormat.ETC2_RGBA1:
			case TextureFormat.ETC2_RGBA8:
			case TextureFormat.ASTC_4x4:
			case TextureFormat.ASTC_5x5:
			case TextureFormat.ASTC_6x6:
			case TextureFormat.ASTC_8x8:
			case TextureFormat.ASTC_10x10:
			case TextureFormat.ASTC_12x12:
			case TextureFormat.ASTC_RGBA_4x4:
			case TextureFormat.ASTC_RGBA_5x5:
			case TextureFormat.ASTC_RGBA_6x6:
			case TextureFormat.ASTC_RGBA_8x8:
			case TextureFormat.ASTC_RGBA_10x10:
			case TextureFormat.ASTC_RGBA_12x12:
			case TextureFormat.ETC_RGB4_3DS:
			case TextureFormat.ETC_RGBA8_3DS:
			case TextureFormat.RG16:
			case TextureFormat.R8:
			case TextureFormat.ETC_RGB4Crunched:
			case TextureFormat.ETC2_RGBA8Crunched:
				return true;
			case TextureFormat.RHalf:
			case TextureFormat.RGHalf:
			case TextureFormat.RGBAHalf:
			case TextureFormat.RFloat:
			case TextureFormat.RGFloat:
			case TextureFormat.RGBAFloat:
			case TextureFormat.YUY2:
			case TextureFormat.RGB9e5Float:
			case TextureFormat.BC6H:
			case TextureFormat.ASTC_HDR_4x4:
			case TextureFormat.ASTC_HDR_5x5:
			case TextureFormat.ASTC_HDR_6x6:
			case TextureFormat.ASTC_HDR_8x8:
			case TextureFormat.ASTC_HDR_10x10:
			case TextureFormat.ASTC_HDR_12x12:
			case TextureFormat.RG32:
			case TextureFormat.RGB48:
			case TextureFormat.RGBA64:
				return false;
			}
			return false;
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000087B1 File Offset: 0x000069B1
		public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000087BE File Offset: 0x000069BE
		public void SetDirty(Texture2D tex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000087CB File Offset: 0x000069CB
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x000087D8 File Offset: 0x000069D8
		public int minAtlasSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000087E5 File Offset: 0x000069E5
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000087F2 File Offset: 0x000069F2
		public int maxAtlasSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000087FF File Offset: 0x000069FF
		public static DynamicAtlasFilters defaultFilters
		{
			get
			{
				return (DynamicAtlasFilters)31;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00008803 File Offset: 0x00006A03
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x00008810 File Offset: 0x00006A10
		public DynamicAtlasFilters activeFilters
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0000881D File Offset: 0x00006A1D
		// (set) Token: 0x06000D65 RID: 3429 RVA: 0x0000882A File Offset: 0x00006A2A
		public int maxSubTextureSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x02000230 RID: 560
		public class TextureInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<DynamicAtlas.TextureInfo>
		{
		}
	}
}
