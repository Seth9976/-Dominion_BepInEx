using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000057 RID: 87
	[StructLayout(2)]
	public struct LightBakingOutput
	{
		// Token: 0x0600088E RID: 2190 RVA: 0x000292A8 File Offset: 0x000274A8
		// Note: this type is marked as 'beforefieldinit'.
		static LightBakingOutput()
		{
			Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightBakingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
			LightBakingOutput.NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "probeOcclusionLightIndex");
			LightBakingOutput.NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "occlusionMaskChannel");
			LightBakingOutput.NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "lightmapBakeType");
			LightBakingOutput.NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "mixedLightingMode");
			LightBakingOutput.NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, "isBaked");
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00006F27 File Offset: 0x00005127
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_occlusionMaskChannel;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_lightmapBakeType;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_mixedLightingMode;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_isBaked;

		// Token: 0x0400054C RID: 1356
		[FieldOffset(0)]
		public int probeOcclusionLightIndex;

		// Token: 0x0400054D RID: 1357
		[FieldOffset(4)]
		public int occlusionMaskChannel;

		// Token: 0x0400054E RID: 1358
		[FieldOffset(8)]
		public LightmapBakeType lightmapBakeType;

		// Token: 0x0400054F RID: 1359
		[FieldOffset(12)]
		public MixedLightingMode mixedLightingMode;

		// Token: 0x04000550 RID: 1360
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool isBaked;
	}
}
