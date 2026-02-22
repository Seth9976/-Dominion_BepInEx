using System;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020001CF RID: 463
	public sealed class Caching
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x0000F80A File Offset: 0x0000DA0A
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000F816 File Offset: 0x0000DA16
		public static bool compressionEnabled
		{
			get
			{
				return Caching.get_compressionEnabledDelegateField();
			}
			set
			{
				Caching.set_compressionEnabledDelegateField(value);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x0000F823 File Offset: 0x0000DA23
		public static bool ready
		{
			get
			{
				return Caching.get_readyDelegateField();
			}
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0000F82F File Offset: 0x0000DA2F
		public static bool ClearCache()
		{
			return Caching.ClearCacheDelegateField();
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00061E9C File Offset: 0x0006009C
		public static bool ClearCache(int expiration)
		{
			return Caching.ClearCache_Int(expiration);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0000F83B File Offset: 0x0000DA3B
		public static bool ClearCache_Int(int expiration)
		{
			return Caching.ClearCache_IntDelegateField(expiration);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0000F848 File Offset: 0x0000DA48
		public static bool ClearAllCachedVersions(string assetBundleName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0000F855 File Offset: 0x0000DA55
		public static bool IsVersionCached(string url, int version)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0000F862 File Offset: 0x0000DA62
		public static bool MarkAsUsed(string url, int version)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00061EB4 File Offset: 0x000600B4
		public static int GetVersionFromCache(string url)
		{
			return -1;
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00061EC8 File Offset: 0x000600C8
		public static int spaceUsed
		{
			get
			{
				return (int)Caching.spaceOccupied;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0000F86F File Offset: 0x0000DA6F
		public static long spaceOccupied
		{
			get
			{
				return Caching.get_spaceOccupiedDelegateField();
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x00061EE0 File Offset: 0x000600E0
		public static int spaceAvailable
		{
			get
			{
				return (int)Caching.spaceFree;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0000F87B File Offset: 0x0000DA7B
		public static long spaceFree
		{
			get
			{
				return Caching.get_spaceFreeDelegateField();
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0000F887 File Offset: 0x0000DA87
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0000F893 File Offset: 0x0000DA93
		public static long maximumAvailableDiskSpace
		{
			get
			{
				return Caching.get_maximumAvailableDiskSpaceDelegateField();
			}
			set
			{
				Caching.set_maximumAvailableDiskSpaceDelegateField(value);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0000F8AC File Offset: 0x0000DAAC
		public static int expirationDelay
		{
			get
			{
				return Caching.get_expirationDelayDelegateField();
			}
			set
			{
				Caching.set_expirationDelayDelegateField(value);
			}
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0000F8B9 File Offset: 0x0000DAB9
		public static void GetAllCachePaths(List<string> cachePaths)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0000F8C6 File Offset: 0x0000DAC6
		public static int cacheCount
		{
			get
			{
				return Caching.get_cacheCountDelegateField();
			}
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00061EF8 File Offset: 0x000600F8
		public static bool CleanCache()
		{
			return Caching.ClearCache();
		}

		// Token: 0x0400165D RID: 5725
		private static readonly Caching.get_compressionEnabledDelegate get_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");

		// Token: 0x0400165E RID: 5726
		private static readonly Caching.set_compressionEnabledDelegate set_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.set_compressionEnabledDelegate>("UnityEngine.Caching::set_compressionEnabled");

		// Token: 0x0400165F RID: 5727
		private static readonly Caching.get_readyDelegate get_readyDelegateField = IL2CPP.ResolveICall<Caching.get_readyDelegate>("UnityEngine.Caching::get_ready");

		// Token: 0x04001660 RID: 5728
		private static readonly Caching.ClearCacheDelegate ClearCacheDelegateField = IL2CPP.ResolveICall<Caching.ClearCacheDelegate>("UnityEngine.Caching::ClearCache");

		// Token: 0x04001661 RID: 5729
		private static readonly Caching.ClearCache_IntDelegate ClearCache_IntDelegateField = IL2CPP.ResolveICall<Caching.ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");

		// Token: 0x04001662 RID: 5730
		private static readonly Caching.get_spaceOccupiedDelegate get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<Caching.get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");

		// Token: 0x04001663 RID: 5731
		private static readonly Caching.get_spaceFreeDelegate get_spaceFreeDelegateField = IL2CPP.ResolveICall<Caching.get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");

		// Token: 0x04001664 RID: 5732
		private static readonly Caching.get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");

		// Token: 0x04001665 RID: 5733
		private static readonly Caching.set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");

		// Token: 0x04001666 RID: 5734
		private static readonly Caching.get_expirationDelayDelegate get_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");

		// Token: 0x04001667 RID: 5735
		private static readonly Caching.set_expirationDelayDelegate set_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");

		// Token: 0x04001668 RID: 5736
		private static readonly Caching.get_cacheCountDelegate get_cacheCountDelegateField = IL2CPP.ResolveICall<Caching.get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");

		// Token: 0x02000A9A RID: 2714
		// (Invoke) Token: 0x06003336 RID: 13110
		private delegate bool get_compressionEnabledDelegate();

		// Token: 0x02000A9B RID: 2715
		// (Invoke) Token: 0x06003338 RID: 13112
		private delegate void set_compressionEnabledDelegate(bool value);

		// Token: 0x02000A9C RID: 2716
		// (Invoke) Token: 0x0600333A RID: 13114
		private delegate bool get_readyDelegate();

		// Token: 0x02000A9D RID: 2717
		// (Invoke) Token: 0x0600333C RID: 13116
		private delegate bool ClearCacheDelegate();

		// Token: 0x02000A9E RID: 2718
		// (Invoke) Token: 0x0600333E RID: 13118
		private delegate bool ClearCache_IntDelegate(int expiration);

		// Token: 0x02000A9F RID: 2719
		// (Invoke) Token: 0x06003340 RID: 13120
		private delegate long get_spaceOccupiedDelegate();

		// Token: 0x02000AA0 RID: 2720
		// (Invoke) Token: 0x06003342 RID: 13122
		private delegate long get_spaceFreeDelegate();

		// Token: 0x02000AA1 RID: 2721
		// (Invoke) Token: 0x06003344 RID: 13124
		private delegate long get_maximumAvailableDiskSpaceDelegate();

		// Token: 0x02000AA2 RID: 2722
		// (Invoke) Token: 0x06003346 RID: 13126
		private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

		// Token: 0x02000AA3 RID: 2723
		// (Invoke) Token: 0x06003348 RID: 13128
		private delegate int get_expirationDelayDelegate();

		// Token: 0x02000AA4 RID: 2724
		// (Invoke) Token: 0x0600334A RID: 13130
		private delegate void set_expirationDelayDelegate(int value);

		// Token: 0x02000AA5 RID: 2725
		// (Invoke) Token: 0x0600334C RID: 13132
		private delegate int get_cacheCountDelegate();
	}
}
