using System;
using System.Runtime.InteropServices;
using Unity.Jobs;

namespace UnityEngine.ParticleSystemJobs
{
	// Token: 0x02000038 RID: 56
	public static class IParticleSystemJobExtensions
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000029A3 File Offset: 0x00000BA3
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000029B0 File Offset: 0x00000BB0
		public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, int minIndicesPerJobCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000029BD File Offset: 0x00000BBD
		public static JobHandle ScheduleBatch<T>(T jobData, ParticleSystem ps, int innerLoopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
