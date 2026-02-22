using System;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public class Compass
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002495 File Offset: 0x00000695
		public float magneticHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000024A2 File Offset: 0x000006A2
		public float trueHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000024AF File Offset: 0x000006AF
		public float headingAccuracy
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000024BC File Offset: 0x000006BC
		public Vector3 rawVector
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000024C9 File Offset: 0x000006C9
		public double timestamp
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000024D6 File Offset: 0x000006D6
		public bool enabled
		{
			get
			{
				return LocationService.IsHeadingUpdatesEnabled();
			}
			set
			{
				LocationService.SetHeadingUpdatesEnabled(value);
			}
		}
	}
}
