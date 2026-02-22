using System;

// Token: 0x0200002C RID: 44
public sealed class <PrivateImplementationDetails>
{
	// Token: 0x06000626 RID: 1574 RVA: 0x00016E78 File Offset: 0x00015078
	public static uint ComputeStringHash(string s)
	{
		uint num;
		if (s != null)
		{
			num = 2166136261U;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((uint)s.get_Chars(i) ^ num) * 16777619U;
			}
		}
		return num;
	}
}
