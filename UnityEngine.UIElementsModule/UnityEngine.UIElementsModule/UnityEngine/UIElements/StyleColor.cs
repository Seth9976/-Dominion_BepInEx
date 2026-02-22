using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018B RID: 395
	public struct StyleColor
	{
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00037CC8 File Offset: 0x00035EC8
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0000AF27 File Offset: 0x00009127
		public Color value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : Color.clear;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00037CF0 File Offset: 0x00035EF0
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x0000AF38 File Offset: 0x00009138
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

		// Token: 0x060010FA RID: 4346 RVA: 0x00037D08 File Offset: 0x00035F08
		public static bool operator ==(StyleColor lhs, StyleColor rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00037D3C File Offset: 0x00035F3C
		public static bool operator !=(StyleColor lhs, StyleColor rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00037D58 File Offset: 0x00035F58
		public static bool operator ==(StyleColor lhs, Color rhs)
		{
			StyleColor styleColor = new StyleColor(rhs);
			return lhs == styleColor;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00037D7C File Offset: 0x00035F7C
		public static bool operator !=(StyleColor lhs, Color rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00037D98 File Offset: 0x00035F98
		public static implicit operator StyleColor(StyleKeyword keyword)
		{
			return new StyleColor(keyword);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00037DB0 File Offset: 0x00035FB0
		public static implicit operator StyleColor(Color v)
		{
			return new StyleColor(v);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00037DC8 File Offset: 0x00035FC8
		public bool Equals(StyleColor other)
		{
			return other == this;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00037DE8 File Offset: 0x00035FE8
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleColor)
			{
				StyleColor styleColor = (StyleColor)obj;
				flag = this.Equals(styleColor);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00037E14 File Offset: 0x00036014
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00037E48 File Offset: 0x00036048
		public override string ToString()
		{
			return this.DebugString<Color>();
		}

		// Token: 0x040007E4 RID: 2020
		public Color m_Value;

		// Token: 0x040007E5 RID: 2021
		public StyleKeyword m_Keyword;
	}
}
