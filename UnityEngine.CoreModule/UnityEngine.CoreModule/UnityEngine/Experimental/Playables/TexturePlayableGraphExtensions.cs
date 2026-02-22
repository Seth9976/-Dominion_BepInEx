using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002CF RID: 719
	public static class TexturePlayableGraphExtensions
	{
		// Token: 0x060022F4 RID: 8948 RVA: 0x00014831 File Offset: 0x00012A31
		public static bool InternalCreateTextureOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, out UnityEngine.Playables.PlayableOutputHandle handle)
		{
			return TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegateField(ref graph, IL2CPP.ManagedStringToIl2Cpp(name), out handle);
		}

		// Token: 0x04001BD7 RID: 7127
		private static readonly TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate InternalCreateTextureOutputDelegateField = IL2CPP.ResolveICall<TexturePlayableGraphExtensions.InternalCreateTextureOutputDelegate>("UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions::InternalCreateTextureOutput");

		// Token: 0x02000D20 RID: 3360
		// (Invoke) Token: 0x06003824 RID: 14372
		private delegate bool InternalCreateTextureOutputDelegate(IntPtr graph, IntPtr name, [Out] IntPtr handle);
	}
}
