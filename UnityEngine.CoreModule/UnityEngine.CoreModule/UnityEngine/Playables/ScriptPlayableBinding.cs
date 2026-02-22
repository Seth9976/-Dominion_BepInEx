using System;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x020002C6 RID: 710
	public static class ScriptPlayableBinding
	{
		// Token: 0x06002232 RID: 8754 RVA: 0x0006A680 File Offset: 0x00068880
		public static PlayableBinding Create(string name, Object key, Type type)
		{
			return PlayableBinding.CreateInternal(name, key, type, new PlayableBinding.CreateOutputMethod(ScriptPlayableBinding.CreateScriptOutput));
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x0006A6A8 File Offset: 0x000688A8
		public static PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
		{
			return ScriptPlayableOutput.Create(graph, name);
		}
	}
}
