using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.TextCore
{
	// Token: 0x02000028 RID: 40
	public class TextGenerator
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00002E61 File Offset: 0x00001061
		public static TextGenerator GetTextGenerator()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002E6E File Offset: 0x0000106E
		public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002E7B File Offset: 0x0000107B
		public static Vector2 GetCursorPosition(TextGenerationSettings settings, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002E88 File Offset: 0x00001088
		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002E95 File Offset: 0x00001095
		public static float GetPreferredWidth(TextGenerationSettings settings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002EA2 File Offset: 0x000010A2
		public static float GetPreferredHeight(TextGenerationSettings settings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002EAF File Offset: 0x000010AF
		public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002EBC File Offset: 0x000010BC
		public void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002EC9 File Offset: 0x000010C9
		public void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002ED6 File Offset: 0x000010D6
		public bool ValidateRichTextTag(string sourceText, ref int readIndex, ref int writeIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002EE3 File Offset: 0x000010E3
		public bool ValidateHtmlTag(Il2CppStructArray<int> chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002EF0 File Offset: 0x000010F0
		public void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002EFD File Offset: 0x000010FD
		public void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002F0A File Offset: 0x0000110A
		public void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002F17 File Offset: 0x00001117
		public void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002F24 File Offset: 0x00001124
		public static void ClearMesh(bool updateMesh, TextInfo textInfo)
		{
			textInfo.ClearMeshInfo(updateMesh);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002F2F File Offset: 0x0000112F
		public void EnableMasking()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002F3C File Offset: 0x0000113C
		public void DisableMasking()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002F49 File Offset: 0x00001149
		public void SetArraySizes(Il2CppStructArray<int> chars, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002F56 File Offset: 0x00001156
		public void ComputeMarginSize(Rect rect, Vector4 margins)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002F63 File Offset: 0x00001163
		public void GetSpecialCharacters(FontAsset fontAsset)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002F70 File Offset: 0x00001170
		public float GetPaddingForMaterial(Material material, bool extraPadding)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002F7D File Offset: 0x0000117D
		public float GetPreferredWidthInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002F8A File Offset: 0x0000118A
		public float GetPreferredHeightInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002F97 File Offset: 0x00001197
		public Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002FA4 File Offset: 0x000011A4
		public virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040001B4 RID: 436
		public const int k_Tab = 9;

		// Token: 0x040001B5 RID: 437
		public const int k_LineFeed = 10;

		// Token: 0x040001B6 RID: 438
		public const int k_CarriageReturn = 13;

		// Token: 0x040001B7 RID: 439
		public const int k_Space = 32;

		// Token: 0x040001B8 RID: 440
		public const int k_DoubleQuotes = 34;

		// Token: 0x040001B9 RID: 441
		public const int k_NumberSign = 35;

		// Token: 0x040001BA RID: 442
		public const int k_PercentSign = 37;

		// Token: 0x040001BB RID: 443
		public const int k_SingleQuote = 39;

		// Token: 0x040001BC RID: 444
		public const int k_Plus = 43;

		// Token: 0x040001BD RID: 445
		public const int k_Minus = 45;

		// Token: 0x040001BE RID: 446
		public const int k_Period = 46;

		// Token: 0x040001BF RID: 447
		public const int k_LesserThan = 60;

		// Token: 0x040001C0 RID: 448
		public const int k_Equal = 61;

		// Token: 0x040001C1 RID: 449
		public const int k_GreaterThan = 62;

		// Token: 0x040001C2 RID: 450
		public const int k_Underline = 95;

		// Token: 0x040001C3 RID: 451
		public const int k_NoBreakSpace = 160;

		// Token: 0x040001C4 RID: 452
		public const int k_SoftHyphen = 173;

		// Token: 0x040001C5 RID: 453
		public const int k_HyphenMinus = 45;

		// Token: 0x040001C6 RID: 454
		public const int k_FigureSpace = 8199;

		// Token: 0x040001C7 RID: 455
		public const int k_Hyphen = 8208;

		// Token: 0x040001C8 RID: 456
		public const int k_NonBreakingHyphen = 8209;

		// Token: 0x040001C9 RID: 457
		public const int k_ZeroWidthSpace = 8203;

		// Token: 0x040001CA RID: 458
		public const int k_NarrowNoBreakSpace = 8239;

		// Token: 0x040001CB RID: 459
		public const int k_WordJoiner = 8288;

		// Token: 0x040001CC RID: 460
		public const int k_HorizontalEllipsis = 8230;

		// Token: 0x040001CD RID: 461
		public const int k_RightSingleQuote = 8217;

		// Token: 0x040001CE RID: 462
		public const int k_Square = 9633;

		// Token: 0x040001CF RID: 463
		public const int k_HangulJamoStart = 4352;

		// Token: 0x040001D0 RID: 464
		public const int k_HangulJamoEnd = 4607;

		// Token: 0x040001D1 RID: 465
		public const int k_CjkStart = 11904;

		// Token: 0x040001D2 RID: 466
		public const int k_CjkEnd = 40959;

		// Token: 0x040001D3 RID: 467
		public const int k_HangulJameExtendedStart = 43360;

		// Token: 0x040001D4 RID: 468
		public const int k_HangulJameExtendedEnd = 43391;

		// Token: 0x040001D5 RID: 469
		public const int k_HangulSyllablesStart = 44032;

		// Token: 0x040001D6 RID: 470
		public const int k_HangulSyllablesEnd = 55295;

		// Token: 0x040001D7 RID: 471
		public const int k_CjkIdeographsStart = 63744;

		// Token: 0x040001D8 RID: 472
		public const int k_CjkIdeographsEnd = 64255;

		// Token: 0x040001D9 RID: 473
		public const int k_CjkFormsStart = 65072;

		// Token: 0x040001DA RID: 474
		public const int k_CjkFormsEnd = 65103;

		// Token: 0x040001DB RID: 475
		public const int k_CjkHalfwidthStart = 65280;

		// Token: 0x040001DC RID: 476
		public const int k_CjkHalfwidthEnd = 65519;

		// Token: 0x040001DD RID: 477
		public const int k_VerticesMax = 16383;

		// Token: 0x040001DE RID: 478
		public const int k_SpritesStart = 57344;

		// Token: 0x040001DF RID: 479
		public const float k_FloatUnset = -32767f;

		// Token: 0x040001E0 RID: 480
		public const int k_MaxCharacters = 8;
	}
}
