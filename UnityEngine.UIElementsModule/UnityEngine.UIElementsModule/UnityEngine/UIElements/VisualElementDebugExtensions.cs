using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000123 RID: 291
	public static class VisualElementDebugExtensions
	{
		// Token: 0x06000DFE RID: 3582 RVA: 0x0003557C File Offset: 0x0003377C
		public static string GetDisplayName(VisualElement ve, [Optional] bool withHashCode)
		{
			bool flag = ve == null;
			string text;
			if (flag)
			{
				text = String.Empty;
			}
			else
			{
				string text2 = ve.GetType().Name;
				bool flag2 = !String.IsNullOrEmpty(ve.name);
				if (flag2)
				{
					text2 = String.Concat(text2, "#", ve.name);
				}
				if (withHashCode)
				{
					text2 = String.Concat(text2, " (", ve.GetHashCode().ToString("x8"), ")");
				}
				text = text2;
			}
			return text;
		}
	}
}
