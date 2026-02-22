using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D4 RID: 724
	public static class GraphicsDeviceSettings
	{
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000148EB File Offset: 0x00012AEB
		// (set) Token: 0x060022FE RID: 8958 RVA: 0x000148F7 File Offset: 0x00012AF7
		public static WaitForPresentSyncPoint waitForPresentSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_waitForPresentSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_waitForPresentSyncPointDelegateField(value);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x00014904 File Offset: 0x00012B04
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x00014910 File Offset: 0x00012B10
		public static GraphicsJobsSyncPoint graphicsJobsSyncPoint
		{
			get
			{
				return GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegateField();
			}
			set
			{
				GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegateField(value);
			}
		}

		// Token: 0x04001BE3 RID: 7139
		private static readonly GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate get_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_waitForPresentSyncPoint");

		// Token: 0x04001BE4 RID: 7140
		private static readonly GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate set_waitForPresentSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_waitForPresentSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_waitForPresentSyncPoint");

		// Token: 0x04001BE5 RID: 7141
		private static readonly GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate get_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.get_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::get_graphicsJobsSyncPoint");

		// Token: 0x04001BE6 RID: 7142
		private static readonly GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate set_graphicsJobsSyncPointDelegateField = IL2CPP.ResolveICall<GraphicsDeviceSettings.set_graphicsJobsSyncPointDelegate>("UnityEngine.Experimental.Rendering.GraphicsDeviceSettings::set_graphicsJobsSyncPoint");

		// Token: 0x02000D24 RID: 3364
		// (Invoke) Token: 0x0600382C RID: 14380
		private delegate WaitForPresentSyncPoint get_waitForPresentSyncPointDelegate();

		// Token: 0x02000D25 RID: 3365
		// (Invoke) Token: 0x0600382E RID: 14382
		private delegate void set_waitForPresentSyncPointDelegate(WaitForPresentSyncPoint value);

		// Token: 0x02000D26 RID: 3366
		// (Invoke) Token: 0x06003830 RID: 14384
		private delegate GraphicsJobsSyncPoint get_graphicsJobsSyncPointDelegate();

		// Token: 0x02000D27 RID: 3367
		// (Invoke) Token: 0x06003832 RID: 14386
		private delegate void set_graphicsJobsSyncPointDelegate(GraphicsJobsSyncPoint value);
	}
}
