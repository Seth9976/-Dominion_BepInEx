using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000011 RID: 17
	public class GlobalConfigInternal
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002D72 File Offset: 0x00000F72
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000042E8 File Offset: 0x000024E8
		public ~GlobalConfigInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002D7F File Offset: 0x00000F7F
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002D8C File Offset: 0x00000F8C
		public static IntPtr InternalCreate()
		{
			return GlobalConfigInternal.InternalCreateDelegateField();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002D98 File Offset: 0x00000F98
		public static void InternalDestroy(IntPtr ptr)
		{
			GlobalConfigInternal.InternalDestroyDelegateField(ptr);
		}

		// Token: 0x1700004F RID: 79
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002DA5 File Offset: 0x00000FA5
		public uint ThreadAwakeTimeout
		{
			set
			{
				GlobalConfigInternal.set_ThreadAwakeTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (set) Token: 0x0600011A RID: 282 RVA: 0x00002DB8 File Offset: 0x00000FB8
		public byte ReactorModel
		{
			set
			{
				GlobalConfigInternal.set_ReactorModelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002DCB File Offset: 0x00000FCB
		public ushort ReactorMaximumReceivedMessages
		{
			set
			{
				GlobalConfigInternal.set_ReactorMaximumReceivedMessagesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002DDE File Offset: 0x00000FDE
		public ushort ReactorMaximumSentMessages
		{
			set
			{
				GlobalConfigInternal.set_ReactorMaximumSentMessagesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002DF1 File Offset: 0x00000FF1
		public ushort MaxPacketSize
		{
			set
			{
				GlobalConfigInternal.set_MaxPacketSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00002E04 File Offset: 0x00001004
		public ushort MaxHosts
		{
			set
			{
				GlobalConfigInternal.set_MaxHostsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002E17 File Offset: 0x00001017
		public byte ThreadPoolSize
		{
			set
			{
				GlobalConfigInternal.set_ThreadPoolSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (set) Token: 0x06000120 RID: 288 RVA: 0x00002E2A File Offset: 0x0000102A
		public uint MinTimerTimeout
		{
			set
			{
				GlobalConfigInternal.set_MinTimerTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002E3D File Offset: 0x0000103D
		public uint MaxTimerTimeout
		{
			set
			{
				GlobalConfigInternal.set_MaxTimerTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00002E50 File Offset: 0x00001050
		public uint MinNetSimulatorTimeout
		{
			set
			{
				GlobalConfigInternal.set_MinNetSimulatorTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002E63 File Offset: 0x00001063
		public uint MaxNetSimulatorTimeout
		{
			set
			{
				GlobalConfigInternal.set_MaxNetSimulatorTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly GlobalConfigInternal.InternalCreateDelegate InternalCreateDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.InternalCreateDelegate>("UnityEngine.Networking.GlobalConfigInternal::InternalCreate");

		// Token: 0x04000099 RID: 153
		private static readonly GlobalConfigInternal.InternalDestroyDelegate InternalDestroyDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.InternalDestroyDelegate>("UnityEngine.Networking.GlobalConfigInternal::InternalDestroy");

		// Token: 0x0400009A RID: 154
		private static readonly GlobalConfigInternal.set_ThreadAwakeTimeoutDelegate set_ThreadAwakeTimeoutDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_ThreadAwakeTimeoutDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_ThreadAwakeTimeout");

		// Token: 0x0400009B RID: 155
		private static readonly GlobalConfigInternal.set_ReactorModelDelegate set_ReactorModelDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_ReactorModelDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_ReactorModel");

		// Token: 0x0400009C RID: 156
		private static readonly GlobalConfigInternal.set_ReactorMaximumReceivedMessagesDelegate set_ReactorMaximumReceivedMessagesDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_ReactorMaximumReceivedMessagesDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_ReactorMaximumReceivedMessages");

		// Token: 0x0400009D RID: 157
		private static readonly GlobalConfigInternal.set_ReactorMaximumSentMessagesDelegate set_ReactorMaximumSentMessagesDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_ReactorMaximumSentMessagesDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_ReactorMaximumSentMessages");

		// Token: 0x0400009E RID: 158
		private static readonly GlobalConfigInternal.set_MaxPacketSizeDelegate set_MaxPacketSizeDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MaxPacketSizeDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MaxPacketSize");

		// Token: 0x0400009F RID: 159
		private static readonly GlobalConfigInternal.set_MaxHostsDelegate set_MaxHostsDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MaxHostsDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MaxHosts");

		// Token: 0x040000A0 RID: 160
		private static readonly GlobalConfigInternal.set_ThreadPoolSizeDelegate set_ThreadPoolSizeDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_ThreadPoolSizeDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_ThreadPoolSize");

		// Token: 0x040000A1 RID: 161
		private static readonly GlobalConfigInternal.set_MinTimerTimeoutDelegate set_MinTimerTimeoutDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MinTimerTimeoutDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MinTimerTimeout");

		// Token: 0x040000A2 RID: 162
		private static readonly GlobalConfigInternal.set_MaxTimerTimeoutDelegate set_MaxTimerTimeoutDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MaxTimerTimeoutDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MaxTimerTimeout");

		// Token: 0x040000A3 RID: 163
		private static readonly GlobalConfigInternal.set_MinNetSimulatorTimeoutDelegate set_MinNetSimulatorTimeoutDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MinNetSimulatorTimeoutDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MinNetSimulatorTimeout");

		// Token: 0x040000A4 RID: 164
		private static readonly GlobalConfigInternal.set_MaxNetSimulatorTimeoutDelegate set_MaxNetSimulatorTimeoutDelegateField = IL2CPP.ResolveICall<GlobalConfigInternal.set_MaxNetSimulatorTimeoutDelegate>("UnityEngine.Networking.GlobalConfigInternal::set_MaxNetSimulatorTimeout");

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x06000278 RID: 632
		private delegate IntPtr InternalCreateDelegate();

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600027A RID: 634
		private delegate void InternalDestroyDelegate(IntPtr ptr);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x0600027C RID: 636
		private delegate void set_ThreadAwakeTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x0600027E RID: 638
		private delegate void set_ReactorModelDelegate(IntPtr @this, byte value);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000280 RID: 640
		private delegate void set_ReactorMaximumReceivedMessagesDelegate(IntPtr @this, ushort value);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000282 RID: 642
		private delegate void set_ReactorMaximumSentMessagesDelegate(IntPtr @this, ushort value);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000284 RID: 644
		private delegate void set_MaxPacketSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000286 RID: 646
		private delegate void set_MaxHostsDelegate(IntPtr @this, ushort value);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000288 RID: 648
		private delegate void set_ThreadPoolSizeDelegate(IntPtr @this, byte value);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600028A RID: 650
		private delegate void set_MinTimerTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x0600028C RID: 652
		private delegate void set_MaxTimerTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x0600028E RID: 654
		private delegate void set_MinNetSimulatorTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x06000290 RID: 656
		private delegate void set_MaxNetSimulatorTimeoutDelegate(IntPtr @this, uint value);
	}
}
