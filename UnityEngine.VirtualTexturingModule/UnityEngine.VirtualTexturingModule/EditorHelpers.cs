using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000003 RID: 3
	public static class EditorHelpers
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020EA File Offset: 0x000002EA
		public static int tileSize
		{
			get
			{
				return EditorHelpers.get_tileSizeDelegateField();
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022DC File Offset: 0x000004DC
		public unsafe static bool ValidateTextureStack(Il2CppReferenceArray<Texture> textures, out string errorMessage)
		{
			EditorHelpers.ValidateTextureStackDelegate validateTextureStackDelegateField = EditorHelpers.ValidateTextureStackDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(textures);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			return validateTextureStackDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002304 File Offset: 0x00000504
		public static Il2CppStructArray<GraphicsFormat> QuerySupportedFormats()
		{
			IntPtr intPtr = EditorHelpers.QuerySupportedFormatsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}

		// Token: 0x04000005 RID: 5
		private static readonly EditorHelpers.get_tileSizeDelegate get_tileSizeDelegateField = IL2CPP.ResolveICall<EditorHelpers.get_tileSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::get_tileSize");

		// Token: 0x04000006 RID: 6
		private static readonly EditorHelpers.ValidateTextureStackDelegate ValidateTextureStackDelegateField = IL2CPP.ResolveICall<EditorHelpers.ValidateTextureStackDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::ValidateTextureStack");

		// Token: 0x04000007 RID: 7
		private static readonly EditorHelpers.QuerySupportedFormatsDelegate QuerySupportedFormatsDelegateField = IL2CPP.ResolveICall<EditorHelpers.QuerySupportedFormatsDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::QuerySupportedFormats");

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate int get_tileSizeDelegate();

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000033 RID: 51
		private delegate bool ValidateTextureStackDelegate(IntPtr textures, [Out] IntPtr errorMessage);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate IntPtr QuerySupportedFormatsDelegate();
	}
}
