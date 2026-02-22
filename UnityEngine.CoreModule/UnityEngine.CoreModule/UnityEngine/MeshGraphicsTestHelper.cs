using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200021B RID: 539
	public struct MeshGraphicsTestHelper
	{
		// Token: 0x06001EC7 RID: 7879 RVA: 0x000119F8 File Offset: 0x0000FBF8
		public static void InternalEnableComputeBufferBindings(Mesh mesh)
		{
			MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00011A0A File Offset: 0x0000FC0A
		public static void InternalEnableComputeBufferBindingsSkinned(SkinnedMeshRenderer mesh)
		{
			MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh));
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00011A1C File Offset: 0x0000FC1C
		public static bool InternalAssignComputeBuffer(Mesh mesh, ComputeShader shader, int kernelIndex, int iboTargetID, int vboTargetID)
		{
			return MeshGraphicsTestHelper.InternalAssignComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, iboTargetID, vboTargetID);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00011A38 File Offset: 0x0000FC38
		public static bool InternalAssignComputeBufferSkinned(SkinnedMeshRenderer mesh, ComputeShader shader, int kernelIndex, int vboTargetID)
		{
			return MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, vboTargetID);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00064CB4 File Offset: 0x00062EB4
		public static bool InternalSetChannelInfo(Mesh mesh, ComputeShader shader, int kernelIndex, int vertexStrideID, int positionOffsetID, int normalOffsetID, int uvOffsetID, int colorOffsetID)
		{
			return MeshGraphicsTestHelper.InternalSetChannelInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mesh), IL2CPP.Il2CppObjectBaseToPtr(shader), kernelIndex, vertexStrideID, positionOffsetID, normalOffsetID, uvOffsetID, colorOffsetID);
		}

		// Token: 0x0400186A RID: 6250
		private static readonly MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegate InternalEnableComputeBufferBindingsDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalEnableComputeBufferBindings");

		// Token: 0x0400186B RID: 6251
		private static readonly MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegate InternalEnableComputeBufferBindingsSkinnedDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalEnableComputeBufferBindingsSkinnedDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalEnableComputeBufferBindingsSkinned");

		// Token: 0x0400186C RID: 6252
		private static readonly MeshGraphicsTestHelper.InternalAssignComputeBufferDelegate InternalAssignComputeBufferDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalAssignComputeBufferDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalAssignComputeBuffer");

		// Token: 0x0400186D RID: 6253
		private static readonly MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegate InternalAssignComputeBufferSkinnedDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalAssignComputeBufferSkinnedDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalAssignComputeBufferSkinned");

		// Token: 0x0400186E RID: 6254
		private static readonly MeshGraphicsTestHelper.InternalSetChannelInfoDelegate InternalSetChannelInfoDelegateField = IL2CPP.ResolveICall<MeshGraphicsTestHelper.InternalSetChannelInfoDelegate>("UnityEngine.MeshGraphicsTestHelper::InternalSetChannelInfo");

		// Token: 0x02000BEF RID: 3055
		// (Invoke) Token: 0x060035D0 RID: 13776
		private delegate void InternalEnableComputeBufferBindingsDelegate(IntPtr mesh);

		// Token: 0x02000BF0 RID: 3056
		// (Invoke) Token: 0x060035D2 RID: 13778
		private delegate void InternalEnableComputeBufferBindingsSkinnedDelegate(IntPtr mesh);

		// Token: 0x02000BF1 RID: 3057
		// (Invoke) Token: 0x060035D4 RID: 13780
		private delegate bool InternalAssignComputeBufferDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int iboTargetID, int vboTargetID);

		// Token: 0x02000BF2 RID: 3058
		// (Invoke) Token: 0x060035D6 RID: 13782
		private delegate bool InternalAssignComputeBufferSkinnedDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int vboTargetID);

		// Token: 0x02000BF3 RID: 3059
		// (Invoke) Token: 0x060035D8 RID: 13784
		private delegate bool InternalSetChannelInfoDelegate(IntPtr mesh, IntPtr shader, int kernelIndex, int vertexStrideID, int positionOffsetID, int normalOffsetID, int uvOffsetID, int colorOffsetID);
	}
}
