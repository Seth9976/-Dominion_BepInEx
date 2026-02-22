using System;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000010 RID: 16
	public static class YogaConstants
	{
		// Token: 0x0600014A RID: 330 RVA: 0x000050B4 File Offset: 0x000032B4
		public static bool IsUndefined(float value)
		{
			return Single.IsNaN(value);
		}

		// Token: 0x040000C7 RID: 199
		public const float Undefined = float.NaN;
	}
}
