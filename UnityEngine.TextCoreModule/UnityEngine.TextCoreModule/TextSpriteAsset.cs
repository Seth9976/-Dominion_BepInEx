using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore
{
	// Token: 0x02000034 RID: 52
	[Serializable]
	public class TextSpriteAsset : ScriptableObject
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00003185 File Offset: 0x00001385
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00003192 File Offset: 0x00001392
		public string version
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000319F File Offset: 0x0000139F
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000031AC File Offset: 0x000013AC
		public int hashCode
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000031B9 File Offset: 0x000013B9
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000031C6 File Offset: 0x000013C6
		public Material material
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

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000031D3 File Offset: 0x000013D3
		public int materialHashCode
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x06000202 RID: 514 RVA: 0x000031ED File Offset: 0x000013ED
		public List<SpriteCharacter> spriteCharacterTable
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000031FA File Offset: 0x000013FA
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00003207 File Offset: 0x00001407
		public List<SpriteGlyph> spriteGlyphTable
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

		// Token: 0x06000205 RID: 517 RVA: 0x00003214 File Offset: 0x00001414
		public void Awake()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00003221 File Offset: 0x00001421
		public Material GetDefaultSpriteMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000322E File Offset: 0x0000142E
		public void UpdateLookupTables()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000323B File Offset: 0x0000143B
		public int GetSpriteIndexFromHashcode(int hashCode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00003248 File Offset: 0x00001448
		public int GetSpriteIndexFromUnicode(uint unicode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00003255 File Offset: 0x00001455
		public int GetSpriteIndexFromName(string spriteName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003262 File Offset: 0x00001462
		public static TextSpriteAsset SearchForSpriteByUnicode(TextSpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000326F File Offset: 0x0000146F
		public static TextSpriteAsset SearchForSpriteByUnicodeInternal(List<TextSpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000327C File Offset: 0x0000147C
		public static TextSpriteAsset SearchForSpriteByUnicodeInternal(TextSpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003289 File Offset: 0x00001489
		public static TextSpriteAsset SearchForSpriteByHashCode(TextSpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00003296 File Offset: 0x00001496
		public static TextSpriteAsset SearchForSpriteByHashCodeInternal(List<TextSpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000032A3 File Offset: 0x000014A3
		public static TextSpriteAsset SearchForSpriteByHashCodeInternal(TextSpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000032B0 File Offset: 0x000014B0
		public void SortGlyphTable()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000032BD File Offset: 0x000014BD
		public void SortCharacterTable()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000032CA File Offset: 0x000014CA
		public void SortGlyphAndCharacterTables()
		{
			this.SortGlyphTable();
			this.SortCharacterTable();
		}

		// Token: 0x02000068 RID: 104
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
