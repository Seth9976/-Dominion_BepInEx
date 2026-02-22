using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000011 RID: 17
	public enum VFXTaskType
	{
		// Token: 0x04000161 RID: 353
		None,
		// Token: 0x04000162 RID: 354
		Spawner = 268435456,
		// Token: 0x04000163 RID: 355
		Initialize = 536870912,
		// Token: 0x04000164 RID: 356
		Update = 805306368,
		// Token: 0x04000165 RID: 357
		Output = 1073741824,
		// Token: 0x04000166 RID: 358
		CameraSort = 805306369,
		// Token: 0x04000167 RID: 359
		PerCameraUpdate,
		// Token: 0x04000168 RID: 360
		PerCameraSort,
		// Token: 0x04000169 RID: 361
		ParticlePointOutput = 1073741824,
		// Token: 0x0400016A RID: 362
		ParticleLineOutput,
		// Token: 0x0400016B RID: 363
		ParticleQuadOutput,
		// Token: 0x0400016C RID: 364
		ParticleHexahedronOutput,
		// Token: 0x0400016D RID: 365
		ParticleMeshOutput,
		// Token: 0x0400016E RID: 366
		ParticleTriangleOutput,
		// Token: 0x0400016F RID: 367
		ParticleOctagonOutput,
		// Token: 0x04000170 RID: 368
		ConstantRateSpawner = 268435456,
		// Token: 0x04000171 RID: 369
		BurstSpawner,
		// Token: 0x04000172 RID: 370
		PeriodicBurstSpawner,
		// Token: 0x04000173 RID: 371
		VariableRateSpawner,
		// Token: 0x04000174 RID: 372
		CustomCallbackSpawner,
		// Token: 0x04000175 RID: 373
		SetAttributeSpawner,
		// Token: 0x04000176 RID: 374
		EvaluateExpressionsSpawner
	}
}
