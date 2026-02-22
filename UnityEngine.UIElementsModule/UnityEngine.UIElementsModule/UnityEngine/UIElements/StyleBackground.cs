using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200018A RID: 394
	public struct StyleBackground
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00037B48 File Offset: 0x00035D48
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0000AF0C File Offset: 0x0000910C
		public Background value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : null;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00037B74 File Offset: 0x00035D74
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x0000AF1D File Offset: 0x0000911D
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

		// Token: 0x060010ED RID: 4333 RVA: 0x00037B8C File Offset: 0x00035D8C
		public static bool operator ==(StyleBackground lhs, StyleBackground rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00037BC0 File Offset: 0x00035DC0
		public static bool operator !=(StyleBackground lhs, StyleBackground rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00037BDC File Offset: 0x00035DDC
		public static implicit operator StyleBackground(StyleKeyword keyword)
		{
			return new StyleBackground(keyword);
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00037BF4 File Offset: 0x00035DF4
		public static implicit operator StyleBackground(Background v)
		{
			return new StyleBackground(v);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00037C0C File Offset: 0x00035E0C
		public static implicit operator StyleBackground(Texture2D v)
		{
			return new StyleBackground(v);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00037C24 File Offset: 0x00035E24
		public bool Equals(StyleBackground other)
		{
			return other == this;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00037C44 File Offset: 0x00035E44
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleBackground)
			{
				StyleBackground styleBackground = (StyleBackground)obj;
				flag = this.Equals(styleBackground);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00037C70 File Offset: 0x00035E70
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00037CA4 File Offset: 0x00035EA4
		public override string ToString()
		{
			return this.DebugString<Background>();
		}

		// Token: 0x040007E2 RID: 2018
		public Background m_Value;

		// Token: 0x040007E3 RID: 2019
		public StyleKeyword m_Keyword;
	}
}
