using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public class AssetBundleRequest : ResourceRequest
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000022D0 File Offset: 0x000004D0
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRequest()
		{
			Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRequest>.NativeClassPtr);
			AssetBundleRequest.GetResultDelegateField = IL2CPP.ResolveICall<AssetBundleRequest.GetResultDelegate>("UnityEngine.AssetBundleRequest::GetResult");
			AssetBundleRequest.get_allAssetsDelegateField = IL2CPP.ResolveICall<AssetBundleRequest.get_allAssetsDelegate>("UnityEngine.AssetBundleRequest::get_allAssets");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020A4 File Offset: 0x000002A4
		public AssetBundleRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002320 File Offset: 0x00000520
		public override Object GetResult()
		{
			IntPtr intPtr = AssetBundleRequest.GetResultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000234C File Offset: 0x0000054C
		public new Object asset
		{
			get
			{
				return this.GetResult();
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002364 File Offset: 0x00000564
		public Il2CppReferenceArray<Object> allAssets
		{
			get
			{
				IntPtr intPtr = AssetBundleRequest.get_allAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly AssetBundleRequest.GetResultDelegate GetResultDelegateField;

		// Token: 0x04000009 RID: 9
		private static readonly AssetBundleRequest.get_allAssetsDelegate get_allAssetsDelegateField;

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600006A RID: 106
		private delegate IntPtr GetResultDelegate(IntPtr @this);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600006C RID: 108
		private delegate IntPtr get_allAssetsDelegate(IntPtr @this);
	}
}
