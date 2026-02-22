using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Connect
{
	// Token: 0x02000003 RID: 3
	public class UnityConnectSettings : Object
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020B1 File Offset: 0x000002B1
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020BD File Offset: 0x000002BD
		public static bool enabled
		{
			get
			{
				return UnityConnectSettings.get_enabledDelegateField();
			}
			set
			{
				UnityConnectSettings.set_enabledDelegateField(value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020D6 File Offset: 0x000002D6
		public static bool testMode
		{
			get
			{
				return UnityConnectSettings.get_testModeDelegateField();
			}
			set
			{
				UnityConnectSettings.set_testModeDelegateField(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000022B4 File Offset: 0x000004B4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020E3 File Offset: 0x000002E3
		public static string eventUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_eventUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_eventUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022D4 File Offset: 0x000004D4
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F5 File Offset: 0x000002F5
		public static string eventOldUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_eventOldUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_eventOldUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002107 File Offset: 0x00000307
		public static string configUrl
		{
			get
			{
				IntPtr intPtr = UnityConnectSettings.get_configUrlDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				UnityConnectSettings.set_configUrlDelegateField(IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002119 File Offset: 0x00000319
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002125 File Offset: 0x00000325
		public static int testInitMode
		{
			get
			{
				return UnityConnectSettings.get_testInitModeDelegateField();
			}
			set
			{
				UnityConnectSettings.set_testInitModeDelegateField(value);
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly UnityConnectSettings.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::get_enabled");

		// Token: 0x0400000A RID: 10
		private static readonly UnityConnectSettings.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::set_enabled");

		// Token: 0x0400000B RID: 11
		private static readonly UnityConnectSettings.get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testMode");

		// Token: 0x0400000C RID: 12
		private static readonly UnityConnectSettings.set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testMode");

		// Token: 0x0400000D RID: 13
		private static readonly UnityConnectSettings.get_eventUrlDelegate get_eventUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_eventUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventUrl");

		// Token: 0x0400000E RID: 14
		private static readonly UnityConnectSettings.set_eventUrlDelegate set_eventUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_eventUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventUrl");

		// Token: 0x0400000F RID: 15
		private static readonly UnityConnectSettings.get_eventOldUrlDelegate get_eventOldUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_eventOldUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventOldUrl");

		// Token: 0x04000010 RID: 16
		private static readonly UnityConnectSettings.set_eventOldUrlDelegate set_eventOldUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_eventOldUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventOldUrl");

		// Token: 0x04000011 RID: 17
		private static readonly UnityConnectSettings.get_configUrlDelegate get_configUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_configUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::get_configUrl");

		// Token: 0x04000012 RID: 18
		private static readonly UnityConnectSettings.set_configUrlDelegate set_configUrlDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_configUrlDelegate>("UnityEngine.Connect.UnityConnectSettings::set_configUrl");

		// Token: 0x04000013 RID: 19
		private static readonly UnityConnectSettings.get_testInitModeDelegate get_testInitModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.get_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testInitMode");

		// Token: 0x04000014 RID: 20
		private static readonly UnityConnectSettings.set_testInitModeDelegate set_testInitModeDelegateField = IL2CPP.ResolveICall<UnityConnectSettings.set_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testInitMode");

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate bool get_enabledDelegate();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate void set_enabledDelegate(bool value);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002E RID: 46
		private delegate bool get_testModeDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000030 RID: 48
		private delegate void set_testModeDelegate(bool value);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000032 RID: 50
		private delegate IntPtr get_eventUrlDelegate();

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000034 RID: 52
		private delegate void set_eventUrlDelegate(IntPtr value);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000036 RID: 54
		private delegate IntPtr get_eventOldUrlDelegate();

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000038 RID: 56
		private delegate void set_eventOldUrlDelegate(IntPtr value);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x0600003A RID: 58
		private delegate IntPtr get_configUrlDelegate();

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600003C RID: 60
		private delegate void set_configUrlDelegate(IntPtr value);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600003E RID: 62
		private delegate int get_testInitModeDelegate();

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000040 RID: 64
		private delegate void set_testInitModeDelegate(int value);
	}
}
