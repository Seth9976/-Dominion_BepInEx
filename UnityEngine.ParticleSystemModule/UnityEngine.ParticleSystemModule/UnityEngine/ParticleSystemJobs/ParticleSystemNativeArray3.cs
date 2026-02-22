using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000039 RID: 57
	public struct ParticleSystemNativeArray3
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004678 File Offset: 0x00002878
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000029CA File Offset: 0x00000BCA
		public Vector3 Item
		{
			get
			{
				return new Vector3(this.x[index], this.y[index], this.z[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
			}
		}

		// Token: 0x04000178 RID: 376
		public NativeArray<float> x;

		// Token: 0x04000179 RID: 377
		public NativeArray<float> y;

		// Token: 0x0400017A RID: 378
		public NativeArray<float> z;
	}
}
