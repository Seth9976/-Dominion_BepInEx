using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics
{
	// Token: 0x020002C9 RID: 713
	public static class PlayerConnection
	{
		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0006A6C8 File Offset: 0x000688C8
		public static bool connected
		{
			get
			{
				return UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;
			}
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00014317 File Offset: 0x00012517
		public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
		{
		}
	}
}
