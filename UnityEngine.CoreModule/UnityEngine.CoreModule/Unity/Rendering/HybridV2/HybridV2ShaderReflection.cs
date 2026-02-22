using System;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Unity.Rendering.HybridV2
{
	// Token: 0x02000197 RID: 407
	public class HybridV2ShaderReflection
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x0000F49E File Offset: 0x0000D69E
		public static IntPtr GetDOTSInstancingCbuffersPointer(global::UnityEngine.Shader shader, ref int cbufferCount)
		{
			return HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), ref cbufferCount);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0000F4B1 File Offset: 0x0000D6B1
		public static IntPtr GetDOTSInstancingPropertiesPointer(global::UnityEngine.Shader shader, ref int propertyCount)
		{
			return HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(shader), ref propertyCount);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public static uint GetDOTSReflectionVersionNumber()
		{
			return HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegateField();
		}

		// Token: 0x040015BE RID: 5566
		private static readonly HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegate GetDOTSInstancingCbuffersPointerDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSInstancingCbuffersPointerDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingCbuffersPointer");

		// Token: 0x040015BF RID: 5567
		private static readonly HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegate GetDOTSInstancingPropertiesPointerDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSInstancingPropertiesPointerDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSInstancingPropertiesPointer");

		// Token: 0x040015C0 RID: 5568
		private static readonly HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegate GetDOTSReflectionVersionNumberDelegateField = IL2CPP.ResolveICall<HybridV2ShaderReflection.GetDOTSReflectionVersionNumberDelegate>("Unity.Rendering.HybridV2.HybridV2ShaderReflection::GetDOTSReflectionVersionNumber");

		// Token: 0x02000A7C RID: 2684
		// (Invoke) Token: 0x060032FE RID: 13054
		private delegate IntPtr GetDOTSInstancingCbuffersPointerDelegate(IntPtr shader, IntPtr cbufferCount);

		// Token: 0x02000A7D RID: 2685
		// (Invoke) Token: 0x06003300 RID: 13056
		private delegate IntPtr GetDOTSInstancingPropertiesPointerDelegate(IntPtr shader, IntPtr propertyCount);

		// Token: 0x02000A7E RID: 2686
		// (Invoke) Token: 0x06003302 RID: 13058
		private delegate uint GetDOTSReflectionVersionNumberDelegate();
	}
}
