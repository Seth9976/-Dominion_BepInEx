using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011A RID: 282
	public static class StringUtilsExtensions
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x00008C3C File Offset: 0x00006E3C
		public static string ToPascalCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00008C49 File Offset: 0x00006E49
		public static string ToCamelCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00008C56 File Offset: 0x00006E56
		public static string ToKebabCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00008C63 File Offset: 0x00006E63
		public static string ToTrainCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00008C70 File Offset: 0x00006E70
		public static string ToSnakeCase(string text)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00035084 File Offset: 0x00033284
		public static bool EndsWithIgnoreCaseFast(string a, string b)
		{
			int num = a.Length - 1;
			int num2 = b.Length - 1;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			while (num >= 0 && num2 >= 0 && (a.get_Chars(num) == b.get_Chars(num2) || Char.ToLower(a.get_Chars(num), invariantCulture) == Char.ToLower(b.get_Chars(num2), invariantCulture)))
			{
				num--;
				num2--;
			}
			return num2 < 0;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00035100 File Offset: 0x00033300
		public static bool StartsWithIgnoreCaseFast(string a, string b)
		{
			int length = a.Length;
			int length2 = b.Length;
			int num = 0;
			int num2 = 0;
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			while (num < length && num2 < length2 && (a.get_Chars(num) == b.get_Chars(num2) || Char.ToLower(a.get_Chars(num), invariantCulture) == Char.ToLower(b.get_Chars(num2), invariantCulture)))
			{
				num++;
				num2++;
			}
			return num2 == length2;
		}
	}
}
