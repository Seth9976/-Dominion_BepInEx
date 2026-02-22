using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001DB RID: 475
	public class StyleMatcher : BaseStyleMatcher
	{
		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x0000C4DB File Offset: 0x0000A6DB
		public string current
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x0000C4E8 File Offset: 0x0000A6E8
		public override int valueCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		public override bool isVariable
		{
			get
			{
				return base.hasCurrent && this.current.StartsWith("var(");
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0000C512 File Offset: 0x0000A712
		public void Initialize(string propertyValue)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0003A37C File Offset: 0x0003857C
		public override bool MatchKeyword(string keyword)
		{
			return this.current != null && keyword == this.current.ToLower();
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0000C51F File Offset: 0x0000A71F
		public override bool MatchNumber()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0000C52C File Offset: 0x0000A72C
		public override bool MatchInteger()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0000C539 File Offset: 0x0000A739
		public override bool MatchLength()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000C546 File Offset: 0x0000A746
		public override bool MatchPercentage()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0000C553 File Offset: 0x0000A753
		public override bool MatchColor()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0000C560 File Offset: 0x0000A760
		public override bool MatchResource()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0000C56D File Offset: 0x0000A76D
		public override bool MatchUrl()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
