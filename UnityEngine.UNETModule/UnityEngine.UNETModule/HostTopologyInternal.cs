using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x0200000F RID: 15
	public class HostTopologyInternal
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00002C8E File Offset: 0x00000E8E
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000041B0 File Offset: 0x000023B0
		public ~HostTopologyInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002C9B File Offset: 0x00000E9B
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public static IntPtr InternalCreate(ConnectionConfigInternal config, int maxDefaultConnections)
		{
			return HostTopologyInternal.InternalCreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(config), maxDefaultConnections);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002CBB File Offset: 0x00000EBB
		public static void InternalDestroy(IntPtr ptr)
		{
			HostTopologyInternal.InternalDestroyDelegateField(ptr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public ushort AddSpecialConnectionConfig(ConnectionConfigInternal config)
		{
			return HostTopologyInternal.AddSpecialConnectionConfigDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(config));
		}

		// Token: 0x1700004C RID: 76
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002CE0 File Offset: 0x00000EE0
		public ushort ReceivedMessagePoolSize
		{
			set
			{
				HostTopologyInternal.set_ReceivedMessagePoolSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public ushort SentMessagePoolSize
		{
			set
			{
				HostTopologyInternal.set_SentMessagePoolSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002D06 File Offset: 0x00000F06
		public float MessagePoolSizeGrowthFactor
		{
			set
			{
				HostTopologyInternal.set_MessagePoolSizeGrowthFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly HostTopologyInternal.InternalCreateDelegate InternalCreateDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.InternalCreateDelegate>("UnityEngine.Networking.HostTopologyInternal::InternalCreate");

		// Token: 0x04000091 RID: 145
		private static readonly HostTopologyInternal.InternalDestroyDelegate InternalDestroyDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.InternalDestroyDelegate>("UnityEngine.Networking.HostTopologyInternal::InternalDestroy");

		// Token: 0x04000092 RID: 146
		private static readonly HostTopologyInternal.AddSpecialConnectionConfigDelegate AddSpecialConnectionConfigDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.AddSpecialConnectionConfigDelegate>("UnityEngine.Networking.HostTopologyInternal::AddSpecialConnectionConfig");

		// Token: 0x04000093 RID: 147
		private static readonly HostTopologyInternal.set_ReceivedMessagePoolSizeDelegate set_ReceivedMessagePoolSizeDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.set_ReceivedMessagePoolSizeDelegate>("UnityEngine.Networking.HostTopologyInternal::set_ReceivedMessagePoolSize");

		// Token: 0x04000094 RID: 148
		private static readonly HostTopologyInternal.set_SentMessagePoolSizeDelegate set_SentMessagePoolSizeDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.set_SentMessagePoolSizeDelegate>("UnityEngine.Networking.HostTopologyInternal::set_SentMessagePoolSize");

		// Token: 0x04000095 RID: 149
		private static readonly HostTopologyInternal.set_MessagePoolSizeGrowthFactorDelegate set_MessagePoolSizeGrowthFactorDelegateField = IL2CPP.ResolveICall<HostTopologyInternal.set_MessagePoolSizeGrowthFactorDelegate>("UnityEngine.Networking.HostTopologyInternal::set_MessagePoolSizeGrowthFactor");

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x06000268 RID: 616
		private delegate IntPtr InternalCreateDelegate(IntPtr config, int maxDefaultConnections);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x0600026A RID: 618
		private delegate void InternalDestroyDelegate(IntPtr ptr);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x0600026C RID: 620
		private delegate ushort AddSpecialConnectionConfigDelegate(IntPtr @this, IntPtr config);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x0600026E RID: 622
		private delegate void set_ReceivedMessagePoolSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000270 RID: 624
		private delegate void set_SentMessagePoolSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000272 RID: 626
		private delegate void set_MessagePoolSizeGrowthFactorDelegate(IntPtr @this, float value);
	}
}
