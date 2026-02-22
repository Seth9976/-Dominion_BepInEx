using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.Device
{
	// Token: 0x020002CA RID: 714
	public static class Application
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x0001431A File Offset: 0x0001251A
		public static string absoluteURL
		{
			get
			{
				return Application.absoluteURL;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00014321 File Offset: 0x00012521
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00014328 File Offset: 0x00012528
		public static ThreadPriority backgroundLoadingPriority
		{
			get
			{
				return Application.backgroundLoadingPriority;
			}
			set
			{
				Application.backgroundLoadingPriority = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00014331 File Offset: 0x00012531
		public static string buildGUID
		{
			get
			{
				return Application.buildGUID;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x00014338 File Offset: 0x00012538
		public static string cloudProjectId
		{
			get
			{
				return Application.cloudProjectId;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0001433F File Offset: 0x0001253F
		public static string companyName
		{
			get
			{
				return Application.companyName;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00014346 File Offset: 0x00012546
		public static string consoleLogPath
		{
			get
			{
				return Application.consoleLogPath;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0001434D File Offset: 0x0001254D
		public static string dataPath
		{
			get
			{
				return Application.dataPath;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x00014354 File Offset: 0x00012554
		public static bool genuine
		{
			get
			{
				return Application.genuine;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0001435B File Offset: 0x0001255B
		public static bool genuineCheckAvailable
		{
			get
			{
				return Application.genuineCheckAvailable;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00014362 File Offset: 0x00012562
		public static string identifier
		{
			get
			{
				return Application.identifier;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00014369 File Offset: 0x00012569
		public static string installerName
		{
			get
			{
				return Application.installerName;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00014370 File Offset: 0x00012570
		public static ApplicationInstallMode installMode
		{
			get
			{
				return Application.installMode;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00014377 File Offset: 0x00012577
		public static NetworkReachability internetReachability
		{
			get
			{
				return Application.internetReachability;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0001437E File Offset: 0x0001257E
		public static bool isBatchMode
		{
			get
			{
				return Application.isBatchMode;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00014385 File Offset: 0x00012585
		public static bool isConsolePlatform
		{
			get
			{
				return Application.isConsolePlatform;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x0001438C File Offset: 0x0001258C
		public static bool isEditor
		{
			get
			{
				return Application.isEditor;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00014393 File Offset: 0x00012593
		public static bool isFocused
		{
			get
			{
				return Application.isFocused;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x0001439A File Offset: 0x0001259A
		public static bool isMobilePlatform
		{
			get
			{
				return Application.isMobilePlatform;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x000143A1 File Offset: 0x000125A1
		public static bool isPlaying
		{
			get
			{
				return Application.isPlaying;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000143A8 File Offset: 0x000125A8
		public static string persistentDataPath
		{
			get
			{
				return Application.persistentDataPath;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000143AF File Offset: 0x000125AF
		public static RuntimePlatform platform
		{
			get
			{
				return Application.platform;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000143B6 File Offset: 0x000125B6
		public static string productName
		{
			get
			{
				return Application.productName;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000143BD File Offset: 0x000125BD
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x000143C4 File Offset: 0x000125C4
		public static bool runInBackground
		{
			get
			{
				return Application.runInBackground;
			}
			set
			{
				Application.runInBackground = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000143CD File Offset: 0x000125CD
		public static ApplicationSandboxType sandboxType
		{
			get
			{
				return Application.sandboxType;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x000143D4 File Offset: 0x000125D4
		public static string streamingAssetsPath
		{
			get
			{
				return Application.streamingAssetsPath;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x000143DB File Offset: 0x000125DB
		public static SystemLanguage systemLanguage
		{
			get
			{
				return Application.systemLanguage;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x000143E2 File Offset: 0x000125E2
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x000143E9 File Offset: 0x000125E9
		public static int targetFrameRate
		{
			get
			{
				return Application.targetFrameRate;
			}
			set
			{
				Application.targetFrameRate = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000143F2 File Offset: 0x000125F2
		public static string temporaryCachePath
		{
			get
			{
				return Application.temporaryCachePath;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000143F9 File Offset: 0x000125F9
		public static string unityVersion
		{
			get
			{
				return Application.unityVersion;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x00014400 File Offset: 0x00012600
		public static string version
		{
			get
			{
				return Application.version;
			}
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00014407 File Offset: 0x00012607
		public static void add_deepLinkActivated(Action<string> value)
		{
			Application.add_deepLinkActivated(value);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00014410 File Offset: 0x00012610
		public static void remove_deepLinkActivated(Action<string> value)
		{
			Application.remove_deepLinkActivated(value);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00014419 File Offset: 0x00012619
		public static void add_focusChanged(Action<bool> value)
		{
			Application.add_focusChanged(value);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00014422 File Offset: 0x00012622
		public static void remove_focusChanged(Action<bool> value)
		{
			Application.remove_focusChanged(value);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0001442B File Offset: 0x0001262B
		public static void add_logMessageReceived(Application.LogCallback value)
		{
			Application.add_logMessageReceived(value);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00014434 File Offset: 0x00012634
		public static void remove_logMessageReceived(Application.LogCallback value)
		{
			Application.remove_logMessageReceived(value);
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0001443D File Offset: 0x0001263D
		public static void add_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.add_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00014446 File Offset: 0x00012646
		public static void remove_logMessageReceivedThreaded(Application.LogCallback value)
		{
			Application.remove_logMessageReceivedThreaded(value);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0001444F File Offset: 0x0001264F
		public static void add_lowMemory(Application.LowMemoryCallback value)
		{
			Application.add_lowMemory(value);
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00014458 File Offset: 0x00012658
		public static void remove_lowMemory(Application.LowMemoryCallback value)
		{
			Application.remove_lowMemory(value);
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00014461 File Offset: 0x00012661
		public static void add_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.add_onBeforeRender(value);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0001446A File Offset: 0x0001266A
		public static void remove_onBeforeRender(UnityEngine.Events.UnityAction value)
		{
			Application.remove_onBeforeRender(value);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x0006A6E4 File Offset: 0x000688E4
		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return Application.CanStreamedLevelBeLoaded(levelIndex);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0006A6FC File Offset: 0x000688FC
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return Application.CanStreamedLevelBeLoaded(levelName);
		}

		// Token: 0x0600226A RID: 8810 RVA: 0x0006A714 File Offset: 0x00068914
		public static Il2CppStringArray GetBuildTags()
		{
			return Application.GetBuildTags();
		}

		// Token: 0x0600226B RID: 8811 RVA: 0x0006A72C File Offset: 0x0006892C
		public static StackTraceLogType GetStackTraceLogType(LogType logType)
		{
			return Application.GetStackTraceLogType(logType);
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x0006A744 File Offset: 0x00068944
		public static bool HasProLicense()
		{
			return Application.HasProLicense();
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x0006A75C File Offset: 0x0006895C
		public static bool HasUserAuthorization(UserAuthorization mode)
		{
			return Application.HasUserAuthorization(mode);
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x0006A774 File Offset: 0x00068974
		public static bool IsPlaying(Object obj)
		{
			return Application.IsPlaying(obj);
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00014473 File Offset: 0x00012673
		public static void OpenURL(string url)
		{
			Application.OpenURL(url);
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x0001447D File Offset: 0x0001267D
		public static void Quit()
		{
			Application.Quit();
		}

		// Token: 0x06002271 RID: 8817 RVA: 0x00014486 File Offset: 0x00012686
		public static void Quit(int exitCode)
		{
			Application.Quit(exitCode);
		}

		// Token: 0x06002272 RID: 8818 RVA: 0x0006A78C File Offset: 0x0006898C
		public static AsyncOperation RequestUserAuthorization(UserAuthorization mode)
		{
			return Application.RequestUserAuthorization(mode);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00014490 File Offset: 0x00012690
		public static void SetBuildTags(Il2CppStringArray buildTags)
		{
			Application.SetBuildTags(buildTags);
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x0001449A File Offset: 0x0001269A
		public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType)
		{
			Application.SetStackTraceLogType(logType, stackTraceType);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000144A5 File Offset: 0x000126A5
		public static void Unload()
		{
			Application.Unload();
		}
	}
}
