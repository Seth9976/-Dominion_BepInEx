using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001D0 RID: 464
	public static class ShorthandApplicator
	{
		// Token: 0x060012C6 RID: 4806 RVA: 0x0000C31E File Offset: 0x0000A51E
		public static void ApplyBorderColor(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0000C32B File Offset: 0x0000A52B
		public static void ApplyBorderRadius(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0000C338 File Offset: 0x0000A538
		public static void ApplyBorderWidth(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0000C345 File Offset: 0x0000A545
		public static void ApplyFlex(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0000C352 File Offset: 0x0000A552
		public static void ApplyMargin(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0000C35F File Offset: 0x0000A55F
		public static void ApplyPadding(StylePropertyReader reader, ComputedStyle computedStyle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00039764 File Offset: 0x00037964
		public static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis)
		{
			grow = 0f;
			shrink = 1f;
			basis = Length.Auto();
			bool flag = false;
			int valueCount = reader.valueCount;
			bool flag2 = valueCount == 1 && reader.IsValueType(0, StyleValueType.Keyword);
			if (flag2)
			{
				bool flag3 = reader.IsKeyword(0, StyleValueKeyword.None);
				if (flag3)
				{
					flag = true;
					grow = 0f;
					shrink = 0f;
					basis = Length.Auto();
				}
				else
				{
					bool flag4 = reader.IsKeyword(0, StyleValueKeyword.Auto);
					if (flag4)
					{
						flag = true;
						grow = 1f;
						shrink = 1f;
						basis = Length.Auto();
					}
				}
			}
			else
			{
				bool flag5 = valueCount <= 3;
				if (flag5)
				{
					flag = true;
					grow = 0f;
					shrink = 1f;
					basis = Length.Percent(0f);
					bool flag6 = false;
					bool flag7 = false;
					int num = 0;
					while (num < valueCount && flag)
					{
						StyleValueType valueType = reader.GetValueType(num);
						bool flag8 = valueType == StyleValueType.Dimension || valueType == StyleValueType.Keyword;
						if (flag8)
						{
							bool flag9 = flag7;
							if (flag9)
							{
								flag = false;
								break;
							}
							flag7 = true;
							bool flag10 = valueType == StyleValueType.Keyword;
							if (flag10)
							{
								bool flag11 = reader.IsKeyword(num, StyleValueKeyword.Auto);
								if (flag11)
								{
									basis = Length.Auto();
								}
							}
							else
							{
								bool flag12 = valueType == StyleValueType.Dimension;
								if (flag12)
								{
									basis = reader.ReadLength(num);
								}
							}
							bool flag13 = flag6 && num != valueCount - 1;
							if (flag13)
							{
								flag = false;
							}
						}
						else
						{
							bool flag14 = valueType == StyleValueType.Float;
							if (flag14)
							{
								float num2 = reader.ReadFloat(num);
								bool flag15 = !flag6;
								if (flag15)
								{
									flag6 = true;
									grow = num2;
								}
								else
								{
									shrink = num2;
								}
							}
							else
							{
								flag = false;
							}
						}
						num++;
					}
				}
			}
			return flag;
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00039930 File Offset: 0x00037B30
		public static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
			ShorthandApplicator.CompileBoxArea(reader, out top, out right, out bottom, out left);
			bool flag = top.IsAuto() || top.IsNone();
			if (flag)
			{
				top = 0f;
			}
			bool flag2 = right.IsAuto() || right.IsNone();
			if (flag2)
			{
				right = 0f;
			}
			bool flag3 = bottom.IsAuto() || bottom.IsNone();
			if (flag3)
			{
				bottom = 0f;
			}
			bool flag4 = left.IsAuto() || left.IsNone();
			if (flag4)
			{
				left = 0f;
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000399E4 File Offset: 0x00037BE4
		public static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
			top = 0f;
			right = 0f;
			bottom = 0f;
			left = 0f;
			switch (reader.valueCount)
			{
			case 0:
				break;
			case 1:
				top = (right = (bottom = (left = reader.ReadLength(0))));
				break;
			case 2:
				top = (bottom = reader.ReadLength(0));
				left = (right = reader.ReadLength(1));
				break;
			case 3:
				top = reader.ReadLength(0);
				left = (right = reader.ReadLength(1));
				bottom = reader.ReadLength(2);
				break;
			default:
				top = reader.ReadLength(0);
				right = reader.ReadLength(1);
				bottom = reader.ReadLength(2);
				left = reader.ReadLength(3);
				break;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00039B2C File Offset: 0x00037D2C
		public static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left)
		{
			Length length;
			Length length2;
			Length length3;
			Length length4;
			ShorthandApplicator.CompileBoxArea(reader, out length, out length2, out length3, out length4);
			top = length.value;
			right = length2.value;
			bottom = length3.value;
			left = length4.value;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00039B70 File Offset: 0x00037D70
		public static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left)
		{
			top = Color.clear;
			right = Color.clear;
			bottom = Color.clear;
			left = Color.clear;
			switch (reader.valueCount)
			{
			case 0:
				break;
			case 1:
				top = (right = (bottom = (left = reader.ReadColor(0))));
				break;
			case 2:
				top = (bottom = reader.ReadColor(0));
				left = (right = reader.ReadColor(1));
				break;
			case 3:
				top = reader.ReadColor(0);
				left = (right = reader.ReadColor(1));
				bottom = reader.ReadColor(2);
				break;
			default:
				top = reader.ReadColor(0);
				right = reader.ReadColor(1);
				bottom = reader.ReadColor(2);
				left = reader.ReadColor(3);
				break;
			}
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00039CA4 File Offset: 0x00037EA4
		public static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth)
		{
			outlineColor = Color.clear;
			outlineWidth = 0f;
			int valueCount = reader.valueCount;
			for (int i = 0; i < valueCount; i++)
			{
				StyleValueType valueType = reader.GetValueType(i);
				bool flag = valueType == StyleValueType.Dimension;
				if (flag)
				{
					outlineWidth = reader.ReadFloat(i);
				}
				else
				{
					bool flag2 = valueType == StyleValueType.Enum || valueType == StyleValueType.Color;
					if (flag2)
					{
						outlineColor = reader.ReadColor(i);
					}
				}
			}
		}
	}
}
