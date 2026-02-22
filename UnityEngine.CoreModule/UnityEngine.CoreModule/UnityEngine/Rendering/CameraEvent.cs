using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000285 RID: 645
	public enum CameraEvent
	{
		// Token: 0x040019C5 RID: 6597
		BeforeDepthTexture,
		// Token: 0x040019C6 RID: 6598
		AfterDepthTexture,
		// Token: 0x040019C7 RID: 6599
		BeforeDepthNormalsTexture,
		// Token: 0x040019C8 RID: 6600
		AfterDepthNormalsTexture,
		// Token: 0x040019C9 RID: 6601
		BeforeGBuffer,
		// Token: 0x040019CA RID: 6602
		AfterGBuffer,
		// Token: 0x040019CB RID: 6603
		BeforeLighting,
		// Token: 0x040019CC RID: 6604
		AfterLighting,
		// Token: 0x040019CD RID: 6605
		BeforeFinalPass,
		// Token: 0x040019CE RID: 6606
		AfterFinalPass,
		// Token: 0x040019CF RID: 6607
		BeforeForwardOpaque,
		// Token: 0x040019D0 RID: 6608
		AfterForwardOpaque,
		// Token: 0x040019D1 RID: 6609
		BeforeImageEffectsOpaque,
		// Token: 0x040019D2 RID: 6610
		AfterImageEffectsOpaque,
		// Token: 0x040019D3 RID: 6611
		BeforeSkybox,
		// Token: 0x040019D4 RID: 6612
		AfterSkybox,
		// Token: 0x040019D5 RID: 6613
		BeforeForwardAlpha,
		// Token: 0x040019D6 RID: 6614
		AfterForwardAlpha,
		// Token: 0x040019D7 RID: 6615
		BeforeImageEffects,
		// Token: 0x040019D8 RID: 6616
		AfterImageEffects,
		// Token: 0x040019D9 RID: 6617
		AfterEverything,
		// Token: 0x040019DA RID: 6618
		BeforeReflections,
		// Token: 0x040019DB RID: 6619
		AfterReflections,
		// Token: 0x040019DC RID: 6620
		BeforeHaloAndLensFlares,
		// Token: 0x040019DD RID: 6621
		AfterHaloAndLensFlares
	}
}
