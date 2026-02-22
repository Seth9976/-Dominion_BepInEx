using System;

namespace UnityEngine.TextCore
{
	// Token: 0x02000036 RID: 54
	[Serializable]
	public class TextStyleSheet : ScriptableObject
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00003350 File Offset: 0x00001550
		public static TextStyleSheet instance
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000335D File Offset: 0x0000155D
		public static TextStyleSheet LoadDefaultStyleSheet()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007680 File Offset: 0x00005880
		public static TextStyle GetStyle(int hashCode)
		{
			bool flag = TextStyleSheet.instance == null;
			TextStyle textStyle;
			if (flag)
			{
				textStyle = null;
			}
			else
			{
				textStyle = TextStyleSheet.instance.GetStyleInternal(hashCode);
			}
			return textStyle;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000336A File Offset: 0x0000156A
		public TextStyle GetStyleInternal(int hashCode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00003377 File Offset: 0x00001577
		public void UpdateStyleDictionaryKey(int old_key, int new_key)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003384 File Offset: 0x00001584
		public static void RefreshStyles()
		{
			TextStyleSheet.instance.LoadStyleDictionaryInternal();
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00003392 File Offset: 0x00001592
		public void LoadStyleDictionaryInternal()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
