using System;
using Il2CppSystem;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
	// Token: 0x020000F3 RID: 243
	public static class PackageEditorAtlasMonitor
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x000086E6 File Offset: 0x000068E6
		public static void StaticInit()
		{
			UnityEngine.UIElements.Panel.add_beforeAnyRepaint(new Action<UnityEngine.UIElements.Panel>(PackageEditorAtlasMonitor.OnBeforeRepaint));
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000086FB File Offset: 0x000068FB
		public static void OnBeforeRepaint(UnityEngine.UIElements.Panel source)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00008708 File Offset: 0x00006908
		public static bool CheckForColorSpaceChange()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00008715 File Offset: 0x00006915
		public static bool CheckForImportedTextures()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00008722 File Offset: 0x00006922
		public static bool CheckForImportedVectorImages()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0000872F File Offset: 0x0000692F
		public static bool CheckForRenderTexturesTrashed()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0200022F RID: 559
		public class TexturePostProcessor
		{
		}
	}
}
