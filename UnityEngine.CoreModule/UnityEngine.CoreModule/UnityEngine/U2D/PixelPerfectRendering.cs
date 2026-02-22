using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.U2D
{
	// Token: 0x0200024E RID: 590
	public static class PixelPerfectRendering
	{
		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x000120D0 File Offset: 0x000102D0
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x000120DC File Offset: 0x000102DC
		public static float pixelSnapSpacing
		{
			get
			{
				return PixelPerfectRendering.get_pixelSnapSpacingDelegateField();
			}
			set
			{
				PixelPerfectRendering.set_pixelSnapSpacingDelegateField(value);
			}
		}

		// Token: 0x040018EE RID: 6382
		private static readonly PixelPerfectRendering.get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");

		// Token: 0x040018EF RID: 6383
		private static readonly PixelPerfectRendering.set_pixelSnapSpacingDelegate set_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.set_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::set_pixelSnapSpacing");

		// Token: 0x02000C2A RID: 3114
		// (Invoke) Token: 0x0600363C RID: 13884
		private delegate float get_pixelSnapSpacingDelegate();

		// Token: 0x02000C2B RID: 3115
		// (Invoke) Token: 0x0600363E RID: 13886
		private delegate void set_pixelSnapSpacingDelegate(float value);
	}
}
