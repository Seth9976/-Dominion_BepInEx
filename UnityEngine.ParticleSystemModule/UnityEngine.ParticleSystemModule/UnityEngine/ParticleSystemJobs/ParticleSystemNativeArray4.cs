using System;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x0200003A RID: 58
	public struct ParticleSystemNativeArray4
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000046B4 File Offset: 0x000028B4
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000046FC File Offset: 0x000028FC
		public Vector4 Item
		{
			get
			{
				return new Vector4(this.x[index], this.y[index], this.z[index], this.w[index]);
			}
			set
			{
				this.x[index] = value.x;
				this.y[index] = value.y;
				this.z[index] = value.z;
				this.w[index] = value.w;
			}
		}

		// Token: 0x0400017B RID: 379
		public NativeArray<float> x;

		// Token: 0x0400017C RID: 380
		public NativeArray<float> y;

		// Token: 0x0400017D RID: 381
		public NativeArray<float> z;

		// Token: 0x0400017E RID: 382
		public NativeArray<float> w;
	}
}
