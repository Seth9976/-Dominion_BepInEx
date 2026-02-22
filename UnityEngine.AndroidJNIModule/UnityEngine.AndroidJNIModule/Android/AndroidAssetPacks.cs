using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Android
{
	// Token: 0x02000017 RID: 23
	public static class AndroidAssetPacks
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public static bool coreUnityAssetPacksDownloaded
		{
			get
			{
				return AndroidAssetPacks.CoreUnityAssetPacksDownloaded();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000A210 File Offset: 0x00008410
		public static string dataPackName
		{
			get
			{
				return AndroidAssetPacks.GetDataPackName();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000A228 File Offset: 0x00008428
		public static string streamingAssetsPackName
		{
			get
			{
				return AndroidAssetPacks.GetStreamingAssetsPackName();
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000292E File Offset: 0x00000B2E
		public static bool CoreUnityAssetPacksDownloaded()
		{
			return AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegateField();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A240 File Offset: 0x00008440
		public static Il2CppStringArray GetCoreUnityAssetPackNames()
		{
			return new Il2CppStringArray(0L);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A25C File Offset: 0x0000845C
		public static GetAssetPackStateAsyncOperation GetAssetPackStateAsync(Il2CppStringArray assetPackNames)
		{
			return null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000293A File Offset: 0x00000B3A
		public static void DownloadAssetPackAsync(Il2CppStringArray assetPackNames, Action<AndroidAssetPackInfo> callback)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A270 File Offset: 0x00008470
		public static DownloadAssetPackAsyncOperation DownloadAssetPackAsync(Il2CppStringArray assetPackNames)
		{
			return null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000293D File Offset: 0x00000B3D
		public static void RequestToUseMobileDataAsync(Action<AndroidAssetPackUseMobileDataRequestResult> callback)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A284 File Offset: 0x00008484
		public static RequestToUseMobileDataAsyncOperation RequestToUseMobileDataAsync()
		{
			return null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A298 File Offset: 0x00008498
		public static string GetAssetPackPath(string assetPackName)
		{
			return "";
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002940 File Offset: 0x00000B40
		public static void CancelAssetPackDownload(Il2CppStringArray assetPackNames)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002943 File Offset: 0x00000B43
		public static void RemoveAssetPack(string assetPackName)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A2B0 File Offset: 0x000084B0
		public static string GetDataPackName()
		{
			return "UnityDataAssetPack";
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A2C8 File Offset: 0x000084C8
		public static string GetStreamingAssetsPackName()
		{
			return "UnityStreamingAssetsPack";
		}

		// Token: 0x0400016E RID: 366
		private static readonly AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate CoreUnityAssetPacksDownloadedDelegateField = IL2CPP.ResolveICall<AndroidAssetPacks.CoreUnityAssetPacksDownloadedDelegate>("UnityEngine.Android.AndroidAssetPacks::CoreUnityAssetPacksDownloaded");

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x060002A5 RID: 677
		private delegate bool CoreUnityAssetPacksDownloadedDelegate();
	}
}
