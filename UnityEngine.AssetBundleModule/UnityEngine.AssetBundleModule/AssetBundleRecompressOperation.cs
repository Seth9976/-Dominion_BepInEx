using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class AssetBundleRecompressOperation : AsyncOperation
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021E8 File Offset: 0x000003E8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRecompressOperation()
		{
			Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRecompressOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr);
			AssetBundleRecompressOperation.get_humanReadableResultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_humanReadableResultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_humanReadableResult");
			AssetBundleRecompressOperation.get_inputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_inputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_inputPath");
			AssetBundleRecompressOperation.get_outputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_outputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_outputPath");
			AssetBundleRecompressOperation.get_resultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_resultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_result");
			AssetBundleRecompressOperation.get_successDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_successDelegate>("UnityEngine.AssetBundleRecompressOperation::get_success");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002077 File Offset: 0x00000277
		public AssetBundleRecompressOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002264 File Offset: 0x00000464
		public string humanReadableResult
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_humanReadableResultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002288 File Offset: 0x00000488
		public string inputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_inputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022AC File Offset: 0x000004AC
		public string outputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_outputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002080 File Offset: 0x00000280
		public AssetBundleLoadResult result
		{
			get
			{
				return AssetBundleRecompressOperation.get_resultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002092 File Offset: 0x00000292
		public bool success
		{
			get
			{
				return AssetBundleRecompressOperation.get_successDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly AssetBundleRecompressOperation.get_humanReadableResultDelegate get_humanReadableResultDelegateField;

		// Token: 0x04000004 RID: 4
		private static readonly AssetBundleRecompressOperation.get_inputPathDelegate get_inputPathDelegateField;

		// Token: 0x04000005 RID: 5
		private static readonly AssetBundleRecompressOperation.get_outputPathDelegate get_outputPathDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly AssetBundleRecompressOperation.get_resultDelegate get_resultDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly AssetBundleRecompressOperation.get_successDelegate get_successDelegateField;

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000060 RID: 96
		private delegate IntPtr get_humanReadableResultDelegate(IntPtr @this);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000062 RID: 98
		private delegate IntPtr get_inputPathDelegate(IntPtr @this);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000064 RID: 100
		private delegate IntPtr get_outputPathDelegate(IntPtr @this);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000066 RID: 102
		private delegate AssetBundleLoadResult get_resultDelegate(IntPtr @this);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000068 RID: 104
		private delegate bool get_successDelegate(IntPtr @this);
	}
}
