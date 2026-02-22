using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001D5 RID: 469
	public static class CSSSpec
	{
		// Token: 0x060012D5 RID: 4821 RVA: 0x0003A310 File Offset: 0x00038510
		public static int GetSelectorSpecificity(string selector)
		{
			int num = 0;
			Il2CppReferenceArray<StyleSelectorPart> il2CppReferenceArray;
			bool flag = CSSSpec.ParseSelector(selector, out il2CppReferenceArray);
			if (flag)
			{
				num = CSSSpec.GetSelectorSpecificity(il2CppReferenceArray);
			}
			return num;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0000C386 File Offset: 0x0000A586
		public static int GetSelectorSpecificity(Il2CppReferenceArray<StyleSelectorPart> parts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0000C393 File Offset: 0x0000A593
		public static bool ParseSelector(string selector, out Il2CppReferenceArray<StyleSelectorPart> parts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400082C RID: 2092
		public const int typeSelectorWeight = 1;

		// Token: 0x0400082D RID: 2093
		public const int classSelectorWeight = 10;

		// Token: 0x0400082E RID: 2094
		public const int idSelectorWeight = 100;
	}
}
