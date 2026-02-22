using System;

namespace UnityEngine.TextCore
{
	// Token: 0x02000019 RID: 25
	public class MaterialReferenceManager
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00002C66 File Offset: 0x00000E66
		public static MaterialReferenceManager instance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002C73 File Offset: 0x00000E73
		public static void AddFontAsset(FontAsset fontAsset)
		{
			MaterialReferenceManager.instance.AddFontAssetInternal(fontAsset);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002C82 File Offset: 0x00000E82
		public void AddFontAssetInternal(FontAsset fontAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002C8F File Offset: 0x00000E8F
		public static void AddSpriteAsset(TextSpriteAsset spriteAsset)
		{
			MaterialReferenceManager.instance.AddSpriteAssetInternal(spriteAsset);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002C9E File Offset: 0x00000E9E
		public void AddSpriteAssetInternal(TextSpriteAsset spriteAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002CAB File Offset: 0x00000EAB
		public static void AddSpriteAsset(int hashCode, TextSpriteAsset spriteAsset)
		{
			MaterialReferenceManager.instance.AddSpriteAssetInternal(hashCode, spriteAsset);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002CBB File Offset: 0x00000EBB
		public void AddSpriteAssetInternal(int hashCode, TextSpriteAsset spriteAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public static void AddFontMaterial(int hashCode, Material material)
		{
			MaterialReferenceManager.instance.AddFontMaterialInternal(hashCode, material);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002CD8 File Offset: 0x00000ED8
		public void AddFontMaterialInternal(int hashCode, Material material)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002CE5 File Offset: 0x00000EE5
		public static void AddColorGradientPreset(int hashCode, TextGradientPreset spriteAsset)
		{
			MaterialReferenceManager.instance.AddColorGradientPreset_Internal(hashCode, spriteAsset);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002CF5 File Offset: 0x00000EF5
		public void AddColorGradientPreset_Internal(int hashCode, TextGradientPreset spriteAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002D02 File Offset: 0x00000F02
		public bool Contains(FontAsset font)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002D0F File Offset: 0x00000F0F
		public bool Contains(TextSpriteAsset sprite)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006FF8 File Offset: 0x000051F8
		public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset)
		{
			return MaterialReferenceManager.instance.TryGetFontAssetInternal(hashCode, out fontAsset);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002D1C File Offset: 0x00000F1C
		public bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007018 File Offset: 0x00005218
		public static bool TryGetSpriteAsset(int hashCode, out TextSpriteAsset spriteAsset)
		{
			return MaterialReferenceManager.instance.TryGetSpriteAssetInternal(hashCode, out spriteAsset);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002D29 File Offset: 0x00000F29
		public bool TryGetSpriteAssetInternal(int hashCode, out TextSpriteAsset spriteAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00007038 File Offset: 0x00005238
		public static bool TryGetColorGradientPreset(int hashCode, out TextGradientPreset gradientPreset)
		{
			return MaterialReferenceManager.instance.TryGetColorGradientPresetInternal(hashCode, out gradientPreset);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002D36 File Offset: 0x00000F36
		public bool TryGetColorGradientPresetInternal(int hashCode, out TextGradientPreset gradientPreset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007058 File Offset: 0x00005258
		public static bool TryGetMaterial(int hashCode, out Material material)
		{
			return MaterialReferenceManager.instance.TryGetMaterialInternal(hashCode, out material);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002D43 File Offset: 0x00000F43
		public bool TryGetMaterialInternal(int hashCode, out Material material)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
