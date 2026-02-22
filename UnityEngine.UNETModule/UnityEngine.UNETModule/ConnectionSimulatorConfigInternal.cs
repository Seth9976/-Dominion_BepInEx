using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000010 RID: 16
	public class ConnectionSimulatorConfigInternal
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00002D39 File Offset: 0x00000F39
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000041E4 File Offset: 0x000023E4
		public ~ConnectionSimulatorConfigInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002D46 File Offset: 0x00000F46
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002D53 File Offset: 0x00000F53
		public static IntPtr InternalCreate(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage)
		{
			return ConnectionSimulatorConfigInternal.InternalCreateDelegateField(outMinDelay, outAvgDelay, inMinDelay, inAvgDelay, packetLossPercentage);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002D65 File Offset: 0x00000F65
		public static void InternalDestroy(IntPtr ptr)
		{
			ConnectionSimulatorConfigInternal.InternalDestroyDelegateField(ptr);
		}

		// Token: 0x04000096 RID: 150
		private static readonly ConnectionSimulatorConfigInternal.InternalCreateDelegate InternalCreateDelegateField = IL2CPP.ResolveICall<ConnectionSimulatorConfigInternal.InternalCreateDelegate>("UnityEngine.Networking.ConnectionSimulatorConfigInternal::InternalCreate");

		// Token: 0x04000097 RID: 151
		private static readonly ConnectionSimulatorConfigInternal.InternalDestroyDelegate InternalDestroyDelegateField = IL2CPP.ResolveICall<ConnectionSimulatorConfigInternal.InternalDestroyDelegate>("UnityEngine.Networking.ConnectionSimulatorConfigInternal::InternalDestroy");

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000274 RID: 628
		private delegate IntPtr InternalCreateDelegate(int outMinDelay, int outAvgDelay, int inMinDelay, int inAvgDelay, float packetLossPercentage);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000276 RID: 630
		private delegate void InternalDestroyDelegate(IntPtr ptr);
	}
}
