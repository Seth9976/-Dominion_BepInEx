using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	public sealed class DownloadHandlerAssetBundle : DownloadHandler
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002070 File Offset: 0x00000270
		public static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc)
		{
			return DownloadHandlerAssetBundle.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(url), crc);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002089 File Offset: 0x00000289
		public void InternalCreateAssetBundle(string url, uint crc)
		{
			base.m_Ptr = DownloadHandlerAssetBundle.Create(this, url, crc);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209A File Offset: 0x0000029A
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Raw data access is not supported for asset bundles");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A7 File Offset: 0x000002A7
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported for asset bundles");
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002198 File Offset: 0x00000398
		public AssetBundle assetBundle
		{
			get
			{
				IntPtr intPtr = DownloadHandlerAssetBundle.get_assetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000021C4 File Offset: 0x000003C4
		public static AssetBundle GetContent(UnityWebRequest www)
		{
			return DownloadHandler.GetCheckedDownloader<DownloadHandlerAssetBundle>(www).assetBundle;
		}

		// Token: 0x04000001 RID: 1
		private static readonly DownloadHandlerAssetBundle.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.CreateDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::Create");

		// Token: 0x04000002 RID: 2
		private static readonly DownloadHandlerAssetBundle.get_assetBundleDelegate get_assetBundleDelegateField = IL2CPP.ResolveICall<DownloadHandlerAssetBundle.get_assetBundleDelegate>("UnityEngine.Networking.DownloadHandlerAssetBundle::get_assetBundle");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr url, uint crc);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000011 RID: 17
		private delegate IntPtr get_assetBundleDelegate(IntPtr @this);
	}
}
