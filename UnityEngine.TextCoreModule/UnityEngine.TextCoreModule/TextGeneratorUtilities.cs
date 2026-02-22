using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x0200002F RID: 47
	public static class TextGeneratorUtilities
	{
		// Token: 0x060001C8 RID: 456 RVA: 0x00007100 File Offset: 0x00005300
		public static bool Approximately(float a, float b)
		{
			return b - 0.0001f < a && a < b + 0.0001f;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002FBE File Offset: 0x000011BE
		public static Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int tagCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002FCB File Offset: 0x000011CB
		public static Color32 HexCharsToColor(Il2CppStructArray<char> hexChars, int startIndex, int length)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000712C File Offset: 0x0000532C
		public static int HexToInt(char hex)
		{
			switch (hex)
			{
			case '0':
				return 0;
			case '1':
				return 1;
			case '2':
				return 2;
			case '3':
				return 3;
			case '4':
				return 4;
			case '5':
				return 5;
			case '6':
				return 6;
			case '7':
				return 7;
			case '8':
				return 8;
			case '9':
				return 9;
			case ':':
			case ';':
			case '<':
			case '=':
			case '>':
			case '?':
			case '@':
				break;
			case 'A':
				return 10;
			case 'B':
				return 11;
			case 'C':
				return 12;
			case 'D':
				return 13;
			case 'E':
				return 14;
			case 'F':
				return 15;
			default:
				switch (hex)
				{
				case 'a':
					return 10;
				case 'b':
					return 11;
				case 'c':
					return 12;
				case 'd':
					return 13;
				case 'e':
					return 14;
				case 'f':
					return 15;
				}
				break;
			}
			return 15;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007234 File Offset: 0x00005434
		public static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length)
		{
			int num;
			return TextGeneratorUtilities.ConvertToFloat(chars, startIndex, length, out num);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002FD8 File Offset: 0x000011D8
		public static float ConvertToFloat(Il2CppStructArray<char> chars, int startIndex, int length, out int lastIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00007250 File Offset: 0x00005450
		public static Vector2 PackUV(float x, float y, float scale)
		{
			Vector2 vector;
			vector.x = (float)((int)(x * 511f));
			vector.y = (float)((int)(y * 511f));
			vector.x = vector.x * 4096f + vector.y;
			vector.y = scale;
			return vector;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000072A8 File Offset: 0x000054A8
		public static void ResizeInternalArray<T>(ref Il2CppArrayBase<T> array)
		{
			int num = Mathf.NextPowerOfTwo(array.Length + 1);
			Array.Resize<T>(ref array, num);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000072D0 File Offset: 0x000054D0
		public static void ResizeArray<T>(Il2CppArrayBase<T> array)
		{
			int num = array.Length * 2;
			bool flag = num == 0;
			if (flag)
			{
				num = 8;
			}
			Array.Resize<T>(ref array, num);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000072FC File Offset: 0x000054FC
		public static bool IsTagName(ref string text, string tag, int index)
		{
			bool flag = text.Length < index + tag.Length;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				for (int i = 0; i < tag.Length; i++)
				{
					bool flag3 = TextUtilities.ToUpperFast(text.get_Chars(index + i)) != tag.get_Chars(i);
					if (flag3)
					{
						return false;
					}
				}
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002FE5 File Offset: 0x000011E5
		public static bool IsTagName(ref Il2CppStructArray<int> text, string tag, int index)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007364 File Offset: 0x00005564
		public static int GetUtf32(string text, int i)
		{
			int num = 0;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i)) << 30;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 1)) << 24;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 2)) << 20;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 3)) << 16;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 4)) << 12;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 5)) << 8;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 6)) << 4;
			return num + TextGeneratorUtilities.HexToInt(text.get_Chars(i + 7));
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007414 File Offset: 0x00005614
		public static int GetUtf16(string text, int i)
		{
			int num = 0;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i)) << 12;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 1)) << 8;
			num += TextGeneratorUtilities.HexToInt(text.get_Chars(i + 2)) << 4;
			return num + TextGeneratorUtilities.HexToInt(text.get_Chars(i + 3));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002FF2 File Offset: 0x000011F2
		public static int GetTagHashCode(ref Il2CppStructArray<int> text, int index, out int closeIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007474 File Offset: 0x00005674
		public static int GetTagHashCode(ref string text, int index, out int closeIndex)
		{
			int num = 0;
			closeIndex = 0;
			for (int i = index; i < text.Length; i++)
			{
				bool flag = text.get_Chars(i) == '"';
				if (!flag)
				{
					bool flag2 = text.get_Chars(i) == '>';
					if (flag2)
					{
						closeIndex = i;
						break;
					}
					num = ((num << 5) + num) ^ (int)TextUtilities.ToUpperASCIIFast((uint)text.get_Chars(i));
				}
			}
			return num;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002FFF File Offset: 0x000011FF
		public static void FillCharacterVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000300C File Offset: 0x0000120C
		public static void FillSpriteVertexBuffers(int i, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00003019 File Offset: 0x00001219
		public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00003026 File Offset: 0x00001226
		public static void ResizeLineExtents(int size, TextInfo textInfo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000074E4 File Offset: 0x000056E4
		public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle)
		{
			FontStyles fontStyles;
			switch (fontStyle)
			{
			case FontStyle.Bold:
				fontStyles = FontStyles.Bold;
				break;
			case FontStyle.Italic:
				fontStyles = FontStyles.Italic;
				break;
			case FontStyle.BoldAndItalic:
				fontStyles = (FontStyles)3;
				break;
			default:
				fontStyles = FontStyles.Normal;
				break;
			}
			return fontStyles;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00007520 File Offset: 0x00005720
		public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor)
		{
			TextAlignment textAlignment;
			switch (anchor)
			{
			case TextAnchor.UpperLeft:
				textAlignment = TextAlignment.TopLeft;
				break;
			case TextAnchor.UpperCenter:
				textAlignment = TextAlignment.TopCenter;
				break;
			case TextAnchor.UpperRight:
				textAlignment = TextAlignment.TopRight;
				break;
			case TextAnchor.MiddleLeft:
				textAlignment = TextAlignment.MiddleLeft;
				break;
			case TextAnchor.MiddleCenter:
				textAlignment = TextAlignment.MiddleCenter;
				break;
			case TextAnchor.MiddleRight:
				textAlignment = TextAlignment.MiddleRight;
				break;
			case TextAnchor.LowerLeft:
				textAlignment = TextAlignment.BottomLeft;
				break;
			case TextAnchor.LowerCenter:
				textAlignment = TextAlignment.BottomCenter;
				break;
			case TextAnchor.LowerRight:
				textAlignment = TextAlignment.BottomRight;
				break;
			default:
				textAlignment = TextAlignment.TopLeft;
				break;
			}
			return textAlignment;
		}

		// Token: 0x0400022C RID: 556
		public const float largePositiveFloat = 32767f;

		// Token: 0x0400022D RID: 557
		public const float largeNegativeFloat = -32767f;
	}
}
