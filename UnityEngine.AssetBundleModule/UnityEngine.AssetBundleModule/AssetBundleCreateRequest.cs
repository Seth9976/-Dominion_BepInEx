using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class AssetBundleCreateRequest : AsyncOperation
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000216C File Offset: 0x0000036C
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleCreateRequest()
		{
			Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleCreateRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleCreateRequest>.NativeClassPtr);
			AssetBundleCreateRequest.get_assetBundleDelegateField = IL2CPP.ResolveICall<AssetBundleCreateRequest.get_assetBundleDelegate>("UnityEngine.AssetBundleCreateRequest::get_assetBundle");
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField = IL2CPP.ResolveICall<AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate>("UnityEngine.AssetBundleCreateRequest::SetEnableCompatibilityChecks");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public AssetBundleCreateRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000021BC File Offset: 0x000003BC
		public AssetBundle assetBundle
		{
			get
			{
				IntPtr intPtr = AssetBundleCreateRequest.get_assetBundleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundle>(intPtr2) : null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		public void SetEnableCompatibilityChecks(bool set)
		{
			AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), set);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		public void DisableCompatibilityChecks()
		{
			this.SetEnableCompatibilityChecks(false);
		}

		// Token: 0x04000001 RID: 1
		private static readonly AssetBundleCreateRequest.get_assetBundleDelegate get_assetBundleDelegateField;

		// Token: 0x04000002 RID: 2
		private static readonly AssetBundleCreateRequest.SetEnableCompatibilityChecksDelegate SetEnableCompatibilityChecksDelegateField;

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600005C RID: 92
		private delegate IntPtr get_assetBundleDelegate(IntPtr @this);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600005E RID: 94
		private delegate void SetEnableCompatibilityChecksDelegate(IntPtr @this, bool set);
	}
}
