using System;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x0200000D RID: 13
	public class Utility
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00003EFC File Offset: 0x000020FC
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002A13 File Offset: 0x00000C13
		public static bool useRandomSourceID
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003F10 File Offset: 0x00002110
		public static UnityEngine.Networking.Types.SourceID GetSourceID()
		{
			return (UnityEngine.Networking.Types.SourceID)((long)SystemInfo.deviceUniqueIdentifier.GetHashCode());
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002A16 File Offset: 0x00000C16
		public static void SetAppID(UnityEngine.Networking.Types.AppID newAppID)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003F30 File Offset: 0x00002130
		public static UnityEngine.Networking.Types.AppID GetAppID()
		{
			return UnityEngine.Networking.Types.AppID.Invalid;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002A19 File Offset: 0x00000C19
		public static void SetAccessTokenForNetwork(UnityEngine.Networking.Types.NetworkID netId, UnityEngine.Networking.Types.NetworkAccessToken accessToken)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002A26 File Offset: 0x00000C26
		public static UnityEngine.Networking.Types.NetworkAccessToken GetAccessTokenForNetwork(UnityEngine.Networking.Types.NetworkID netId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
