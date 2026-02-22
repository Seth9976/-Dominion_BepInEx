using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x020001E0 RID: 480
	public class StyleSyntaxTokenizer
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x0000C5AE File Offset: 0x0000A7AE
		public void Tokenize(string syntax)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003A408 File Offset: 0x00038608
		public static bool IsNextCharacter(string s, int index, char c)
		{
			return index + 1 < s.Length && s.get_Chars(index + 1) == c;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003A434 File Offset: 0x00038634
		public static bool IsNextLetterOrDash(string s, int index)
		{
			return index + 1 < s.Length && (Char.IsLetter(s.get_Chars(index + 1)) || s.get_Chars(index + 1) == '-');
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0003A474 File Offset: 0x00038674
		public static bool IsNextNumber(string s, int index)
		{
			return index + 1 < s.Length && Char.IsNumber(s.get_Chars(index + 1));
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0003A4A4 File Offset: 0x000386A4
		public static int GlobCharacter(string s, int index, char c)
		{
			while (StyleSyntaxTokenizer.IsNextCharacter(s, index, c))
			{
				index++;
			}
			return index;
		}
	}
}
