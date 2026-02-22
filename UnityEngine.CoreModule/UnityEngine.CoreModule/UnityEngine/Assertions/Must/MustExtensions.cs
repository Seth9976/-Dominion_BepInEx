using System;

namespace UnityEngine.Assertions.Must
{
	// Token: 0x020002D9 RID: 729
	public static class MustExtensions
	{
		// Token: 0x06002345 RID: 9029 RVA: 0x00014DAD File Offset: 0x00012FAD
		public static void MustBeTrue(bool value)
		{
			Assert.IsTrue(value);
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00014DB7 File Offset: 0x00012FB7
		public static void MustBeTrue(bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00014DC2 File Offset: 0x00012FC2
		public static void MustBeFalse(bool value)
		{
			Assert.IsFalse(value);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00014DCC File Offset: 0x00012FCC
		public static void MustBeFalse(bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00014DD7 File Offset: 0x00012FD7
		public static void MustBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00014DE2 File Offset: 0x00012FE2
		public static void MustBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00014DEE File Offset: 0x00012FEE
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00014DFA File Offset: 0x00012FFA
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00014E07 File Offset: 0x00013007
		public static void MustNotBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00014E12 File Offset: 0x00013012
		public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00014E1E File Offset: 0x0001301E
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00014E2A File Offset: 0x0001302A
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00014E37 File Offset: 0x00013037
		public static void MustBeEqual<T>(T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00014E42 File Offset: 0x00013042
		public static void MustBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00014E4E File Offset: 0x0001304E
		public static void MustNotBeEqual<T>(T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00014E59 File Offset: 0x00013059
		public static void MustNotBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00014E65 File Offset: 0x00013065
		public static void MustBeNull<T>(T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00014E6F File Offset: 0x0001306F
		public static void MustBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00014E7A File Offset: 0x0001307A
		public static void MustNotBeNull<T>(T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00014E84 File Offset: 0x00013084
		public static void MustNotBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
