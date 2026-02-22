using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018D RID: 397
	public struct StyleFontDefinition
	{
		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0003845C File Offset: 0x0003665C
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x0000AFF8 File Offset: 0x000091F8
		public StyleKeyword keyword
		{
			get
			{
				return this.m_Keyword;
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00038474 File Offset: 0x00036674
		public static implicit operator StyleFontDefinition(StyleKeyword keyword)
		{
			return new StyleFontDefinition(keyword);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0000B002 File Offset: 0x00009202
		public bool Equals(StyleFontDefinition other)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0003848C File Offset: 0x0003668C
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleFontDefinition)
			{
				StyleFontDefinition styleFontDefinition = (StyleFontDefinition)obj;
				flag = this.Equals(styleFontDefinition);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0000B00F File Offset: 0x0000920F
		public override int GetHashCode()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x000384B8 File Offset: 0x000366B8
		public static bool operator ==(StyleFontDefinition left, StyleFontDefinition right)
		{
			return left.Equals(right);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000384D4 File Offset: 0x000366D4
		public static bool operator !=(StyleFontDefinition left, StyleFontDefinition right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040007EA RID: 2026
		public StyleKeyword m_Keyword;
	}
}
