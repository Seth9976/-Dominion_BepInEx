using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000190 RID: 400
	public static class StyleValueKeywordExtension
	{
		// Token: 0x0600112A RID: 4394 RVA: 0x00038674 File Offset: 0x00036874
		public static string ToUssString(StyleValueKeyword svk)
		{
			string text;
			switch (svk)
			{
			case StyleValueKeyword.Inherit:
				text = "inherit";
				break;
			case StyleValueKeyword.Initial:
				text = "initial";
				break;
			case StyleValueKeyword.Auto:
				text = "auto";
				break;
			case StyleValueKeyword.Unset:
				text = "unset";
				break;
			case StyleValueKeyword.True:
				text = "true";
				break;
			case StyleValueKeyword.False:
				text = "false";
				break;
			case StyleValueKeyword.None:
				text = "none";
				break;
			default:
				throw new ArgumentOutOfRangeException("svk", svk, "Unknown StyleValueKeyword");
			}
			return text;
		}
	}
}
