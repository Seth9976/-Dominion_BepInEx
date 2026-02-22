using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Jobs;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013E RID: 318
	[StructLayout(2)]
	public struct BatchRendererCullingOutput
	{
		// Token: 0x060017DF RID: 6111 RVA: 0x000592A0 File Offset: 0x000574A0
		// Note: this type is marked as 'beforefieldinit'.
		static BatchRendererCullingOutput()
		{
			Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchRendererCullingOutput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingJobsFence");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingMatrix");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanes");
			BatchRendererCullingOutput.NativeFieldInfoPtr_batchVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "batchVisibility");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndices");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndicesY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndicesY");
			BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "cullingPlanesCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_batchVisibilityCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "batchVisibilityCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_visibleIndicesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "visibleIndicesCount");
			BatchRendererCullingOutput.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, "nearPlane");
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x0000D619 File Offset: 0x0000B819
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, ref this));
		}

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeFieldInfoPtr_cullingJobsFence;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeFieldInfoPtr_cullingMatrix;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanes;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibility;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndices;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesY;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeFieldInfoPtr_cullingPlanesCount;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_batchVisibilityCount;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_visibleIndicesCount;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_nearPlane;

		// Token: 0x040011C7 RID: 4551
		[FieldOffset(0)]
		public Unity.Jobs.JobHandle cullingJobsFence;

		// Token: 0x040011C8 RID: 4552
		[FieldOffset(16)]
		public Matrix4x4 cullingMatrix;

		// Token: 0x040011C9 RID: 4553
		[FieldOffset(80)]
		public IntPtr cullingPlanes;

		// Token: 0x040011CA RID: 4554
		[FieldOffset(88)]
		public IntPtr batchVisibility;

		// Token: 0x040011CB RID: 4555
		[FieldOffset(96)]
		public IntPtr visibleIndices;

		// Token: 0x040011CC RID: 4556
		[FieldOffset(104)]
		public IntPtr visibleIndicesY;

		// Token: 0x040011CD RID: 4557
		[FieldOffset(112)]
		public int cullingPlanesCount;

		// Token: 0x040011CE RID: 4558
		[FieldOffset(116)]
		public int batchVisibilityCount;

		// Token: 0x040011CF RID: 4559
		[FieldOffset(120)]
		public int visibleIndicesCount;

		// Token: 0x040011D0 RID: 4560
		[FieldOffset(124)]
		public float nearPlane;
	}
}
