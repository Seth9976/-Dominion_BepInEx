using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020001E3 RID: 483
	public static class RendererExtensions
	{
		// Token: 0x06001D20 RID: 7456 RVA: 0x000102DB File Offset: 0x0000E4DB
		public static void UpdateGIMaterials(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRenderer(renderer);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000102E5 File Offset: 0x0000E4E5
		public static void UpdateGIMaterialsForRenderer(Renderer renderer)
		{
			RendererExtensions.UpdateGIMaterialsForRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x040016EA RID: 5866
		private static readonly RendererExtensions.UpdateGIMaterialsForRendererDelegate UpdateGIMaterialsForRendererDelegateField = IL2CPP.ResolveICall<RendererExtensions.UpdateGIMaterialsForRendererDelegate>("UnityEngine.RendererExtensions::UpdateGIMaterialsForRenderer");

		// Token: 0x02000B08 RID: 2824
		// (Invoke) Token: 0x06003410 RID: 13328
		private delegate void UpdateGIMaterialsForRendererDelegate(IntPtr renderer);
	}
}
