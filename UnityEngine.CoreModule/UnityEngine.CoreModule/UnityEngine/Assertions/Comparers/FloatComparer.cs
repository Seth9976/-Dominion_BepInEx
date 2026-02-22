using System;
using Il2CppSystem;

namespace UnityEngine.Assertions.Comparers
{
	// Token: 0x020002DA RID: 730
	public class FloatComparer
	{
		// Token: 0x06002359 RID: 9049 RVA: 0x00014E8F File Offset: 0x0001308F
		public bool Equals(float a, float b)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0006AB78 File Offset: 0x00068D78
		public int GetHashCode(float obj)
		{
			return base.GetHashCode();
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0006AB90 File Offset: 0x00068D90
		public static bool AreEqual(float expected, float actual, float error)
		{
			return Math.Abs(actual - expected) <= error;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x0006ABB0 File Offset: 0x00068DB0
		public static bool AreEqualRelative(float expected, float actual, float error)
		{
			bool flag = expected == actual;
			bool flag2;
			if (flag)
			{
				flag2 = true;
			}
			else
			{
				float num = Math.Abs(expected);
				float num2 = Math.Abs(actual);
				float num3 = Math.Abs((actual - expected) / ((num > num2) ? num : num2));
				flag2 = num3 <= error;
			}
			return flag2;
		}

		// Token: 0x04001C07 RID: 7175
		public const float kEpsilon = 1E-05f;
	}
}
