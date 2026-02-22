using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018E RID: 398
	public struct StyleLength
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000384F4 File Offset: 0x000366F4
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x0000B01C File Offset: 0x0000921C
		public Length value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(Length);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00038520 File Offset: 0x00036720
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x0000B02D File Offset: 0x0000922D
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

		// Token: 0x06001121 RID: 4385 RVA: 0x00038538 File Offset: 0x00036738
		public static bool operator ==(StyleLength lhs, StyleLength rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0003856C File Offset: 0x0003676C
		public static bool operator !=(StyleLength lhs, StyleLength rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00038588 File Offset: 0x00036788
		public static implicit operator StyleLength(StyleKeyword keyword)
		{
			return new StyleLength(keyword);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000385A0 File Offset: 0x000367A0
		public static implicit operator StyleLength(float v)
		{
			return new StyleLength(v);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000385B8 File Offset: 0x000367B8
		public static implicit operator StyleLength(Length v)
		{
			return new StyleLength(v);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000385D0 File Offset: 0x000367D0
		public bool Equals(StyleLength other)
		{
			return other == this;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000385F0 File Offset: 0x000367F0
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleLength)
			{
				StyleLength styleLength = (StyleLength)obj;
				flag = this.Equals(styleLength);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0003861C File Offset: 0x0003681C
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00038650 File Offset: 0x00036850
		public override string ToString()
		{
			return this.DebugString<Length>();
		}

		// Token: 0x040007EB RID: 2027
		public Length m_Value;

		// Token: 0x040007EC RID: 2028
		public StyleKeyword m_Keyword;
	}
}
