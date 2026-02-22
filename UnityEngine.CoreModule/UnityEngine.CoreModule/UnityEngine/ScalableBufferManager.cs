using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001DE RID: 478
	public static class ScalableBufferManager
	{
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0001005F File Offset: 0x0000E25F
		public static float widthScaleFactor
		{
			get
			{
				return ScalableBufferManager.get_widthScaleFactorDelegateField();
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0001006B File Offset: 0x0000E26B
		public static float heightScaleFactor
		{
			get
			{
				return ScalableBufferManager.get_heightScaleFactorDelegateField();
			}
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00010077 File Offset: 0x0000E277
		public static void ResizeBuffers(float widthScale, float heightScale)
		{
			ScalableBufferManager.ResizeBuffersDelegateField(widthScale, heightScale);
		}

		// Token: 0x040016D3 RID: 5843
		private static readonly ScalableBufferManager.get_widthScaleFactorDelegate get_widthScaleFactorDelegateField = IL2CPP.ResolveICall<ScalableBufferManager.get_widthScaleFactorDelegate>("UnityEngine.ScalableBufferManager::get_widthScaleFactor");

		// Token: 0x040016D4 RID: 5844
		private static readonly ScalableBufferManager.get_heightScaleFactorDelegate get_heightScaleFactorDelegateField = IL2CPP.ResolveICall<ScalableBufferManager.get_heightScaleFactorDelegate>("UnityEngine.ScalableBufferManager::get_heightScaleFactor");

		// Token: 0x040016D5 RID: 5845
		private static readonly ScalableBufferManager.ResizeBuffersDelegate ResizeBuffersDelegateField = IL2CPP.ResolveICall<ScalableBufferManager.ResizeBuffersDelegate>("UnityEngine.ScalableBufferManager::ResizeBuffers");

		// Token: 0x02000AF4 RID: 2804
		// (Invoke) Token: 0x060033E8 RID: 13288
		private delegate float get_widthScaleFactorDelegate();

		// Token: 0x02000AF5 RID: 2805
		// (Invoke) Token: 0x060033EA RID: 13290
		private delegate float get_heightScaleFactorDelegate();

		// Token: 0x02000AF6 RID: 2806
		// (Invoke) Token: 0x060033EC RID: 13292
		private delegate void ResizeBuffersDelegate(float widthScale, float heightScale);
	}
}
