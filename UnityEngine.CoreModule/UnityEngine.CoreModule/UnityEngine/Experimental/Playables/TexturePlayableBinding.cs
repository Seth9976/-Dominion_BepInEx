using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020002CE RID: 718
	public static class TexturePlayableBinding
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x0006A888 File Offset: 0x00068A88
		public static UnityEngine.Playables.PlayableBinding Create(string name, Object key)
		{
			return UnityEngine.Playables.PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new UnityEngine.Playables.PlayableBinding.CreateOutputMethod(TexturePlayableBinding.CreateTextureOutput));
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0006A8B8 File Offset: 0x00068AB8
		public static UnityEngine.Playables.PlayableOutput CreateTextureOutput(UnityEngine.Playables.PlayableGraph graph, string name)
		{
			return TexturePlayableOutput.Create(graph, name, null);
		}
	}
}
