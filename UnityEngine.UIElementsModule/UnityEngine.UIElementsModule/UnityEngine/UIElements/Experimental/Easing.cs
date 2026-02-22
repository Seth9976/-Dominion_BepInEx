using System;

namespace UnityEngine.UIElements.Experimental
{
	// Token: 0x020001E1 RID: 481
	public static class Easing
	{
		// Token: 0x06001309 RID: 4873 RVA: 0x0003A4CC File Offset: 0x000386CC
		public static float Step(float t)
		{
			return (float)((t < 0.5f) ? 0 : 1);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x0003A4EC File Offset: 0x000386EC
		public static float Linear(float t)
		{
			return t;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0003A500 File Offset: 0x00038700
		public static float InSine(float t)
		{
			return Mathf.Sin(1.5707964f * (t - 1f)) + 1f;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0003A52C File Offset: 0x0003872C
		public static float OutSine(float t)
		{
			return Mathf.Sin(t * 1.5707964f);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0003A54C File Offset: 0x0003874C
		public static float InOutSine(float t)
		{
			return (Mathf.Sin(3.1415927f * (t - 0.5f)) + 1f) * 0.5f;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0003A57C File Offset: 0x0003877C
		public static float InQuad(float t)
		{
			return t * t;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x0003A594 File Offset: 0x00038794
		public static float OutQuad(float t)
		{
			return t * (2f - t);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0003A5B0 File Offset: 0x000387B0
		public static float InOutQuad(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = t * t * 0.5f;
			}
			else
			{
				num = -0.5f * ((t - 1f) * (t - 3f) - 1f);
			}
			return num;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0003A600 File Offset: 0x00038800
		public static float InCubic(float t)
		{
			return Easing.InPower(t, 3);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0003A61C File Offset: 0x0003881C
		public static float OutCubic(float t)
		{
			return Easing.OutPower(t, 3);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0003A638 File Offset: 0x00038838
		public static float InOutCubic(float t)
		{
			return Easing.InOutPower(t, 3);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0003A654 File Offset: 0x00038854
		public static float InPower(float t, int power)
		{
			return Mathf.Pow(t, (float)power);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0003A670 File Offset: 0x00038870
		public static float OutPower(float t, int power)
		{
			int num = ((power % 2 == 0) ? (-1) : 1);
			return (float)num * (Mathf.Pow(t - 1f, (float)power) + (float)num);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003A6A4 File Offset: 0x000388A4
		public static float InOutPower(float t, int power)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = Easing.InPower(t, power) * 0.5f;
			}
			else
			{
				int num2 = ((power % 2 == 0) ? (-1) : 1);
				num = (float)num2 * 0.5f * (Mathf.Pow(t - 2f, (float)power) + (float)(num2 * 2));
			}
			return num;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003A704 File Offset: 0x00038904
		public static float InBounce(float t)
		{
			return 1f - Easing.OutBounce(1f - t);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003A728 File Offset: 0x00038928
		public static float OutBounce(float t)
		{
			bool flag = t < 0.36363637f;
			float num;
			if (flag)
			{
				num = 7.5625f * t * t;
			}
			else
			{
				bool flag2 = t < 0.72727275f;
				if (flag2)
				{
					float num2;
					t = (num2 = t - 0.54545456f);
					num = 7.5625f * num2 * t + 0.75f;
				}
				else
				{
					bool flag3 = t < 0.90909094f;
					if (flag3)
					{
						float num3;
						t = (num3 = t - 0.8181818f);
						num = 7.5625f * num3 * t + 0.9375f;
					}
					else
					{
						float num4;
						t = (num4 = t - 0.95454544f);
						num = 7.5625f * num4 * t + 0.984375f;
					}
				}
			}
			return num;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x0003A7C8 File Offset: 0x000389C8
		public static float InOutBounce(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBounce(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutBounce((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x0003A81C File Offset: 0x00038A1C
		public static float InElastic(float t)
		{
			bool flag = t == 0f;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					num = 1f;
				}
				else
				{
					float num2 = 0.3f;
					float num3 = num2 / 4f;
					float num4 = Mathf.Pow(2f, 10f * (t -= 1f));
					num = -(num4 * Mathf.Sin((t - num3) * 6.2831855f / num2));
				}
			}
			return num;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x0003A898 File Offset: 0x00038A98
		public static float OutElastic(float t)
		{
			bool flag = t == 0f;
			float num;
			if (flag)
			{
				num = 0f;
			}
			else
			{
				bool flag2 = t == 1f;
				if (flag2)
				{
					num = 1f;
				}
				else
				{
					float num2 = 0.3f;
					float num3 = num2 / 4f;
					num = Mathf.Pow(2f, -10f * t) * Mathf.Sin((t - num3) * 6.2831855f / num2) + 1f;
				}
			}
			return num;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0003A90C File Offset: 0x00038B0C
		public static float InOutElastic(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InElastic(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutElastic((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0003A960 File Offset: 0x00038B60
		public static float InBack(float t)
		{
			float num = 1.70158f;
			return t * t * ((num + 1f) * t - num);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0003A988 File Offset: 0x00038B88
		public static float OutBack(float t)
		{
			return 1f - Easing.InBack(1f - t);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0003A9AC File Offset: 0x00038BAC
		public static float InOutBack(float t)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBack(t * 2f) * 0.5f;
			}
			else
			{
				num = Easing.OutBack((t - 0.5f) * 2f) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0003AA00 File Offset: 0x00038C00
		public static float InBack(float t, float s)
		{
			return t * t * ((s + 1f) * t - s);
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0003AA24 File Offset: 0x00038C24
		public static float OutBack(float t, float s)
		{
			return 1f - Easing.InBack(1f - t, s);
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0003AA4C File Offset: 0x00038C4C
		public static float InOutBack(float t, float s)
		{
			bool flag = t < 0.5f;
			float num;
			if (flag)
			{
				num = Easing.InBack(t * 2f, s) * 0.5f;
			}
			else
			{
				num = Easing.OutBack((t - 0.5f) * 2f, s) * 0.5f + 0.5f;
			}
			return num;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0003AAA4 File Offset: 0x00038CA4
		public static float InCirc(float t)
		{
			return -(Mathf.Sqrt(1f - t * t) - 1f);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0003AACC File Offset: 0x00038CCC
		public static float OutCirc(float t)
		{
			t -= 1f;
			return Mathf.Sqrt(1f - t * t);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0003AAF8 File Offset: 0x00038CF8
		public static float InOutCirc(float t)
		{
			t *= 2f;
			bool flag = t < 1f;
			float num;
			if (flag)
			{
				num = -0.5f * (Mathf.Sqrt(1f - t * t) - 1f);
			}
			else
			{
				t -= 2f;
				num = 0.5f * (Mathf.Sqrt(1f - t * t) + 1f);
			}
			return num;
		}

		// Token: 0x0400084E RID: 2126
		public const float HalfPi = 1.5707964f;
	}
}
