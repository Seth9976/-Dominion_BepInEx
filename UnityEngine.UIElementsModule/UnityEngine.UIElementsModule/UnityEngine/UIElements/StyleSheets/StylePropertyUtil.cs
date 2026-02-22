using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001D4 RID: 468
	public static class StylePropertyUtil
	{
		// Token: 0x060012D4 RID: 4820 RVA: 0x00039D18 File Offset: 0x00037F18
		public static int GetEnumIntValue(StyleEnumType enumType, string value)
		{
			int num;
			switch (enumType)
			{
			case StyleEnumType.Align:
			{
				bool flag = String.Equals(value, "auto", StringComparison.OrdinalIgnoreCase);
				if (flag)
				{
					num = 0;
				}
				else
				{
					bool flag2 = String.Equals(value, "flex-start", StringComparison.OrdinalIgnoreCase);
					if (flag2)
					{
						num = 1;
					}
					else
					{
						bool flag3 = String.Equals(value, "center", StringComparison.OrdinalIgnoreCase);
						if (flag3)
						{
							num = 2;
						}
						else
						{
							bool flag4 = String.Equals(value, "flex-end", StringComparison.OrdinalIgnoreCase);
							if (flag4)
							{
								num = 3;
							}
							else
							{
								bool flag5 = String.Equals(value, "stretch", StringComparison.OrdinalIgnoreCase);
								if (flag5)
								{
									num = 4;
								}
								else
								{
									num = 0;
								}
							}
						}
					}
				}
				break;
			}
			case StyleEnumType.DisplayStyle:
			{
				bool flag6 = String.Equals(value, "flex", StringComparison.OrdinalIgnoreCase);
				if (flag6)
				{
					num = 0;
				}
				else
				{
					bool flag7 = String.Equals(value, "none", StringComparison.OrdinalIgnoreCase);
					if (flag7)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.FlexDirection:
			{
				bool flag8 = String.Equals(value, "column", StringComparison.OrdinalIgnoreCase);
				if (flag8)
				{
					num = 0;
				}
				else
				{
					bool flag9 = String.Equals(value, "column-reverse", StringComparison.OrdinalIgnoreCase);
					if (flag9)
					{
						num = 1;
					}
					else
					{
						bool flag10 = String.Equals(value, "row", StringComparison.OrdinalIgnoreCase);
						if (flag10)
						{
							num = 2;
						}
						else
						{
							bool flag11 = String.Equals(value, "row-reverse", StringComparison.OrdinalIgnoreCase);
							if (flag11)
							{
								num = 3;
							}
							else
							{
								num = 0;
							}
						}
					}
				}
				break;
			}
			case StyleEnumType.FontStyle:
			{
				bool flag12 = String.Equals(value, "normal", StringComparison.OrdinalIgnoreCase);
				if (flag12)
				{
					num = 0;
				}
				else
				{
					bool flag13 = String.Equals(value, "bold", StringComparison.OrdinalIgnoreCase);
					if (flag13)
					{
						num = 1;
					}
					else
					{
						bool flag14 = String.Equals(value, "italic", StringComparison.OrdinalIgnoreCase);
						if (flag14)
						{
							num = 2;
						}
						else
						{
							bool flag15 = String.Equals(value, "bold-and-italic", StringComparison.OrdinalIgnoreCase);
							if (flag15)
							{
								num = 3;
							}
							else
							{
								num = 0;
							}
						}
					}
				}
				break;
			}
			case StyleEnumType.Justify:
			{
				bool flag16 = String.Equals(value, "flex-start", StringComparison.OrdinalIgnoreCase);
				if (flag16)
				{
					num = 0;
				}
				else
				{
					bool flag17 = String.Equals(value, "center", StringComparison.OrdinalIgnoreCase);
					if (flag17)
					{
						num = 1;
					}
					else
					{
						bool flag18 = String.Equals(value, "flex-end", StringComparison.OrdinalIgnoreCase);
						if (flag18)
						{
							num = 2;
						}
						else
						{
							bool flag19 = String.Equals(value, "space-between", StringComparison.OrdinalIgnoreCase);
							if (flag19)
							{
								num = 3;
							}
							else
							{
								bool flag20 = String.Equals(value, "space-around", StringComparison.OrdinalIgnoreCase);
								if (flag20)
								{
									num = 4;
								}
								else
								{
									num = 0;
								}
							}
						}
					}
				}
				break;
			}
			case StyleEnumType.Overflow:
			{
				bool flag21 = String.Equals(value, "visible", StringComparison.OrdinalIgnoreCase);
				if (flag21)
				{
					num = 0;
				}
				else
				{
					bool flag22 = String.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase);
					if (flag22)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.OverflowClipBox:
			{
				bool flag23 = String.Equals(value, "padding-box", StringComparison.OrdinalIgnoreCase);
				if (flag23)
				{
					num = 0;
				}
				else
				{
					bool flag24 = String.Equals(value, "content-box", StringComparison.OrdinalIgnoreCase);
					if (flag24)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.OverflowInternal:
			{
				bool flag25 = String.Equals(value, "visible", StringComparison.OrdinalIgnoreCase);
				if (flag25)
				{
					num = 0;
				}
				else
				{
					bool flag26 = String.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase);
					if (flag26)
					{
						num = 1;
					}
					else
					{
						bool flag27 = String.Equals(value, "scroll", StringComparison.OrdinalIgnoreCase);
						if (flag27)
						{
							num = 2;
						}
						else
						{
							num = 0;
						}
					}
				}
				break;
			}
			case StyleEnumType.Position:
			{
				bool flag28 = String.Equals(value, "relative", StringComparison.OrdinalIgnoreCase);
				if (flag28)
				{
					num = 0;
				}
				else
				{
					bool flag29 = String.Equals(value, "absolute", StringComparison.OrdinalIgnoreCase);
					if (flag29)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.ScaleMode:
			{
				bool flag30 = String.Equals(value, "stretch-to-fill", StringComparison.OrdinalIgnoreCase);
				if (flag30)
				{
					num = 0;
				}
				else
				{
					bool flag31 = String.Equals(value, "scale-and-crop", StringComparison.OrdinalIgnoreCase);
					if (flag31)
					{
						num = 1;
					}
					else
					{
						bool flag32 = String.Equals(value, "scale-to-fit", StringComparison.OrdinalIgnoreCase);
						if (flag32)
						{
							num = 2;
						}
						else
						{
							num = 0;
						}
					}
				}
				break;
			}
			case StyleEnumType.TextAnchor:
			{
				bool flag33 = String.Equals(value, "upper-left", StringComparison.OrdinalIgnoreCase);
				if (flag33)
				{
					num = 0;
				}
				else
				{
					bool flag34 = String.Equals(value, "upper-center", StringComparison.OrdinalIgnoreCase);
					if (flag34)
					{
						num = 1;
					}
					else
					{
						bool flag35 = String.Equals(value, "upper-right", StringComparison.OrdinalIgnoreCase);
						if (flag35)
						{
							num = 2;
						}
						else
						{
							bool flag36 = String.Equals(value, "middle-left", StringComparison.OrdinalIgnoreCase);
							if (flag36)
							{
								num = 3;
							}
							else
							{
								bool flag37 = String.Equals(value, "middle-center", StringComparison.OrdinalIgnoreCase);
								if (flag37)
								{
									num = 4;
								}
								else
								{
									bool flag38 = String.Equals(value, "middle-right", StringComparison.OrdinalIgnoreCase);
									if (flag38)
									{
										num = 5;
									}
									else
									{
										bool flag39 = String.Equals(value, "lower-left", StringComparison.OrdinalIgnoreCase);
										if (flag39)
										{
											num = 6;
										}
										else
										{
											bool flag40 = String.Equals(value, "lower-center", StringComparison.OrdinalIgnoreCase);
											if (flag40)
											{
												num = 7;
											}
											else
											{
												bool flag41 = String.Equals(value, "lower-right", StringComparison.OrdinalIgnoreCase);
												if (flag41)
												{
													num = 8;
												}
												else
												{
													num = 0;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				break;
			}
			case StyleEnumType.TextOverflow:
			{
				bool flag42 = String.Equals(value, "clip", StringComparison.OrdinalIgnoreCase);
				if (flag42)
				{
					num = 0;
				}
				else
				{
					bool flag43 = String.Equals(value, "ellipsis", StringComparison.OrdinalIgnoreCase);
					if (flag43)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.TextOverflowPosition:
			{
				bool flag44 = String.Equals(value, "start", StringComparison.OrdinalIgnoreCase);
				if (flag44)
				{
					num = 1;
				}
				else
				{
					bool flag45 = String.Equals(value, "middle", StringComparison.OrdinalIgnoreCase);
					if (flag45)
					{
						num = 2;
					}
					else
					{
						bool flag46 = String.Equals(value, "end", StringComparison.OrdinalIgnoreCase);
						if (flag46)
						{
							num = 0;
						}
						else
						{
							num = 0;
						}
					}
				}
				break;
			}
			case StyleEnumType.Visibility:
			{
				bool flag47 = String.Equals(value, "visible", StringComparison.OrdinalIgnoreCase);
				if (flag47)
				{
					num = 0;
				}
				else
				{
					bool flag48 = String.Equals(value, "hidden", StringComparison.OrdinalIgnoreCase);
					if (flag48)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.WhiteSpace:
			{
				bool flag49 = String.Equals(value, "normal", StringComparison.OrdinalIgnoreCase);
				if (flag49)
				{
					num = 0;
				}
				else
				{
					bool flag50 = String.Equals(value, "nowrap", StringComparison.OrdinalIgnoreCase);
					if (flag50)
					{
						num = 1;
					}
					else
					{
						num = 0;
					}
				}
				break;
			}
			case StyleEnumType.Wrap:
			{
				bool flag51 = String.Equals(value, "nowrap", StringComparison.OrdinalIgnoreCase);
				if (flag51)
				{
					num = 0;
				}
				else
				{
					bool flag52 = String.Equals(value, "wrap", StringComparison.OrdinalIgnoreCase);
					if (flag52)
					{
						num = 1;
					}
					else
					{
						bool flag53 = String.Equals(value, "wrap-reverse", StringComparison.OrdinalIgnoreCase);
						if (flag53)
						{
							num = 2;
						}
						else
						{
							num = 0;
						}
					}
				}
				break;
			}
			default:
				num = 0;
				break;
			}
			return num;
		}

		// Token: 0x0400082B RID: 2091
		public const int k_GroupOffset = 16;
	}
}
