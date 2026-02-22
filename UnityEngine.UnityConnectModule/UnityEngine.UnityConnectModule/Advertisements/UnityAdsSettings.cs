using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Advertisements
{
	// Token: 0x02000002 RID: 2
	public static class UnityAdsSettings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000205C File Offset: 0x0000025C
		public static bool enabled
		{
			get
			{
				return UnityAdsSettings.get_enabledDelegateField();
			}
			set
			{
				UnityAdsSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021BC File Offset: 0x000003BC
		public static bool IsPlatformEnabled(RuntimePlatform platform)
		{
			return true;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002069 File Offset: 0x00000269
		public static void SetPlatformEnabled(RuntimePlatform platform, bool value)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002078 File Offset: 0x00000278
		public static bool initializeOnStartup
		{
			get
			{
				return UnityAdsSettings.get_initializeOnStartupDelegateField();
			}
			set
			{
				UnityAdsSettings.set_initializeOnStartupDelegateField(value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002085 File Offset: 0x00000285
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002091 File Offset: 0x00000291
		public static bool testMode
		{
			get
			{
				return UnityAdsSettings.get_testModeDelegateField();
			}
			set
			{
				UnityAdsSettings.set_testModeDelegateField(value);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000021D0 File Offset: 0x000003D0
		public static string GetGameId(RuntimePlatform platform)
		{
			IntPtr intPtr = UnityAdsSettings.GetGameIdDelegateField(platform);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000209E File Offset: 0x0000029E
		public static void SetGameId(RuntimePlatform platform, string gameId)
		{
			UnityAdsSettings.SetGameIdDelegateField(platform, IL2CPP.ManagedStringToIl2Cpp(gameId));
		}

		// Token: 0x04000001 RID: 1
		private static readonly UnityAdsSettings.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_enabled");

		// Token: 0x04000002 RID: 2
		private static readonly UnityAdsSettings.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_enabled");

		// Token: 0x04000003 RID: 3
		private static readonly UnityAdsSettings.get_initializeOnStartupDelegate get_initializeOnStartupDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_initializeOnStartup");

		// Token: 0x04000004 RID: 4
		private static readonly UnityAdsSettings.set_initializeOnStartupDelegate set_initializeOnStartupDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_initializeOnStartup");

		// Token: 0x04000005 RID: 5
		private static readonly UnityAdsSettings.get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.get_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_testMode");

		// Token: 0x04000006 RID: 6
		private static readonly UnityAdsSettings.set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.set_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_testMode");

		// Token: 0x04000007 RID: 7
		private static readonly UnityAdsSettings.GetGameIdDelegate GetGameIdDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.GetGameIdDelegate>("UnityEngine.Advertisements.UnityAdsSettings::GetGameId");

		// Token: 0x04000008 RID: 8
		private static readonly UnityAdsSettings.SetGameIdDelegate SetGameIdDelegateField = IL2CPP.ResolveICall<UnityAdsSettings.SetGameIdDelegate>("UnityEngine.Advertisements.UnityAdsSettings::SetGameId");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600001A RID: 26
		private delegate bool get_enabledDelegate();

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001C RID: 28
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600001E RID: 30
		private delegate bool get_initializeOnStartupDelegate();

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate void set_initializeOnStartupDelegate(bool value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate bool get_testModeDelegate();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate void set_testModeDelegate(bool value);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate IntPtr GetGameIdDelegate(RuntimePlatform platform);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate void SetGameIdDelegate(RuntimePlatform platform, IntPtr gameId);
	}
}
