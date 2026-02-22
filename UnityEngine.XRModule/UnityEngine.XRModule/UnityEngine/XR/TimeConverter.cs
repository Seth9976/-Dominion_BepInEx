using System;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200001F RID: 31
	public static class TimeConverter
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000587C File Offset: 0x00003A7C
		public static DateTime now
		{
			get
			{
				return DateTime.Now;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002CFA File Offset: 0x00000EFA
		public static long LocalDateTimeToUnixTimeMilliseconds(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002D07 File Offset: 0x00000F07
		public static DateTime UnixTimeMillisecondsToLocalDateTime(long unixTimeInMilliseconds)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
